using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_program
{
    public partial class kitap_islemleri : Form
    {
        public kitap_islemleri()
        {
            InitializeComponent();

        }

        SqlConnection con;
        DataTable tablo = new DataTable();

        private void kitapGoster()
        {

            try
            {
                con = new SqlConnection("Data Source=localhost;Initial Catalog=library_database;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from booksTable", con);

             
                SqlCommand Cmd = new SqlCommand("SELECT COUNT(*) FROM booksTable", con);
                label6.Text = Cmd.ExecuteScalar().ToString();


                DataSet ds = new DataSet();
                da.Fill(ds, "fristTable");
                kitap_islemleri_dataGrid.DataSource = ds.Tables["fristTable"];
                con.Close();
            }
            catch (Exception hatamsj)
            {

                MessageBox.Show(hatamsj.Message, "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        
        private void temizle()
        {
            txt_index.Clear();
            txt_kitapad.Clear();
            txt_kitapno.Clear();
            txt_kitapyayinevi.Clear();
            txt_kitapyazari.Clear();
          
        }

        private void kitap_islemleri_Load(object sender, EventArgs e)
        {
            kitapGoster();
            kitap_islemleri_dataGrid.AllowUserToAddRows = false;
        }

        private void cikis()
        {
            this.Close();
            Application.Exit();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            bool kayitKontrol = false;
            con.Open();
            SqlCommand selectSorgu = new SqlCommand(@"select * from booksTable where KitapAd='" + txt_kitapad.Text + "'", con);
            SqlDataReader kayitOkuma = selectSorgu.ExecuteReader();
            while (kayitOkuma.Read())
            {
                kayitKontrol = true;
                break;
            }
            con.Close();

            //girilen de veri tabanın da yok ise kayıt yapıyoz
            if (kayitKontrol == false)
            {
                         
                if (txt_kitapad.Text == "")
                    lbl_kitapad.ForeColor = Color.Red;
                else
                    lbl_kitapad.ForeColor = Color.Teal;
                //-
                if (txt_kitapyazari.Text == "")
                    lbl_kitapyazari.ForeColor = Color.Red;
                else
                    lbl_kitapyazari.ForeColor = Color.Teal;
                //-
                if (txt_kitapyayinevi.Text == "")
                   lbl_yayinevi.ForeColor = Color.Red;
                else
                    lbl_yayinevi.ForeColor = Color.Teal;
                // // //
                if (txt_kitapyayinevi.Text!=""&& txt_kitapyazari.Text!="")
                  {
                    try
                    {
                        con.Open();
                        SqlCommand ekleKomutu = new SqlCommand("insert into booksTable(KitapAd,KitapYazari,KitapYayinEvi) values" +
                            "('" + txt_kitapad.Text + "','" + txt_kitapyazari.Text + "','" + txt_kitapyayinevi.Text + "')", con);
                        ekleKomutu.ExecuteNonQuery();
                        kitap_islemleri_Load(sender, e);
                        con.Close();

                    }
                    catch (Exception hatamesaj)
                    {

                        MessageBox.Show(hatamesaj.Message);
                        con.Close();
                    }
                  }
                else
                {
                    MessageBox.Show("Kırmızı alanları doğru girin", "kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Girilen kitap adı daha önceden kayıtlıdır. Tekrar kaydetmek istiyormusunuz", "kütüphane", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            }
        }

        private void txt_kitapyazari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
              && !char.IsSeparator(e.KeyChar);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_index.Text != "") 
            {
                bool kayitAramaDurumu = false;
                con.Open();
                SqlCommand selectsorgu = new SqlCommand("select * from booksTable where KitapNo='" + txt_index.Text + "'", con);
                SqlDataReader kayitokuma = selectsorgu.ExecuteReader();

            

                while (kayitokuma.Read())
                {
                    kayitAramaDurumu = true;
                    SqlCommand deleteSorgu = new SqlCommand("delete from booksTable where KitapNo='" + txt_index.Text + "'", con);
                    con.Close();
                    con.Open();
                    deleteSorgu.ExecuteNonQuery();   
                    MessageBox.Show("Kullanıcı Kaydı Silindi.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    kitapGoster();
                    temizle();
                    break;
                }
                if (kayitAramaDurumu == false)
                    MessageBox.Show("kitap Kaydı Bulunamadı!!", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);

                con.Close();
                kitapGoster();
                temizle();
            }
            else
                MessageBox.Show("Silmek istediğiniz kitap no sunu girin", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        //hatalı
        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand guncelleKomutu = new SqlCommand("update booksTable set " +
                            "KitapAd='" + txt_kitapad.Text + "'," +
                            "KitapYazari='" + txt_kitapyazari.Text + "'," +
                            "KitapYayinEvi ='" + txt_kitapyayinevi.Text + "'" +
                            "where KitapNo='" + txt_kitapno.Text + "'", con);

                guncelleKomutu.ExecuteNonQuery();
                con.Close();
                kitapGoster();
                temizle();
                MessageBox.Show("Güncelleme başarılı.", "Kütüphane ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Kayıt oluşturulamadı. VOLKAN RENT A CAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();

            }
        }


        private void kitap_islemleri_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Data Grid View çökyordu başlığa tıklayınca çökmemesi için 
            if (e.RowIndex == -1) return;

            txt_kitapno.Text = kitap_islemleri_dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_kitapad.Text = kitap_islemleri_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_kitapyazari.Text = kitap_islemleri_dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_kitapyayinevi.Text = kitap_islemleri_dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        //private void btn_ara_Click(object sender, EventArgs e)
        //{


        //    //bool kayitAramaDurumu = false;
        //    //if (txt_index.Text != "")
        //    //{

        //    //    con.Open();
        //    //    SqlCommand selectsorgu = new SqlCommand("select * from booksTable where KitapNo='" + txt_index.Text + "'", con);
        //    //    SqlDataReader kayitokuma = selectsorgu.ExecuteReader();

        //    //    while (kayitokuma.Read())
        //    //    {
        //    //        kayitAramaDurumu = true;
        //    //        txt_kitapno.Text = kayitokuma.GetValue(0).ToString();
        //    //        txt_kitapad.Text = kayitokuma.GetValue(1).ToString();
        //    //        txt_kitapyazari.Text = kayitokuma.GetValue(2).ToString();
        //    //        txt_kitapyayinevi.Text = kayitokuma.GetValue(3).ToString();

        //    //        break;

        //    //    }

        //    //    if (kayitAramaDurumu == false)
        //    //        MessageBox.Show("Kitap Kaydı BULUNAMADI !!.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    con.Close();
        //    //}
        //    //else
        //    //    MessageBox.Show("Aramak isteiğiniz kitabın (Kitap No) sunu girin", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //}
 

        private void txt_index_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from booksTable where (KitapAd+KitapYazari+KitapYayinEvi) Like'%" + txt_index.Text + "%' OR KitapNo Like '"+txt_index.Text+"'  "  ,con);
            adtr.Fill(tablo);
            kitap_islemleri_dataGrid.DataSource = tablo;
            con.Close();

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
