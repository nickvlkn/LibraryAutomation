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
    public partial class uye_islemleri : Form
    {
        public uye_islemleri()
        {
            InitializeComponent();
        }

        SqlConnection con;
        DataTable tablo = new DataTable();

        private void uyeGoser()
        {
            try
            {
                con = new SqlConnection("Data Source=localhost;Initial Catalog=library_database;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from membersTable", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "fristTable");
                uye_islemleri_dataGrid.DataSource = ds.Tables["fristTable"];
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
            txt_tc.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_telefon.Clear();
            txt_eposta.Clear();
            txt_uyeno.Clear();
            txt_index.Clear();
        }

        private void uye_islemleri_Load(object sender, EventArgs e)
        {
            uyeGoser();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            bool kayitKontrol = false;
            con.Open();
            SqlCommand selectSorgu = new SqlCommand("select * from membersTable where UyeNo='" + txt_uyeno.Text + "'", con);
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
                if (txt_ad.Text == "")
                    lbl_uyeadi.ForeColor = Color.Red;
                else
                    lbl_uyeadi.ForeColor = Color.Teal;
                //-
                if (txt_soyad.Text == "")
                    lbl_uyesoyad.ForeColor = Color.Red;
                else
                    lbl_uyesoyad.ForeColor = Color.Teal;
                //-
                if (txt_tc.Text == "")
                    lbl_uyetc.ForeColor = Color.Red;
                else
                    lbl_uyetc.ForeColor = Color.Teal;
                //-
                if (txt_telefon.Text == "")
                    lbl_uyetelefon.ForeColor = Color.Red;
                else
                    lbl_uyetelefon.ForeColor = Color.Teal;
                //-
                if (txt_eposta.Text == "")
                    lbl_uyeeposta.ForeColor = Color.Red;
                else
                    lbl_uyeeposta.ForeColor = Color.Teal;

                // // //
                if (txt_tc.Text != "" && txt_ad.Text != "" && txt_soyad.Text != "" && txt_telefon.Text != "")
                {
                    try
                    {
                        con.Open();
                        SqlCommand ekleKomutu = new SqlCommand("insert into membersTable (UyeTcNo,UyeAd,UyeSoyAd,UyeTelefon,UyeEposta) values" +
                            "('" + txt_tc.Text + "','" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_telefon.Text + "','" + txt_eposta.Text + "')", con);
                        ekleKomutu.ExecuteNonQuery();
                        uye_islemleri_Load(sender, e);
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
                MessageBox.Show("Girilen Tc no daha önceden kayıtlıdır", "kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txt_tc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (txt_index.Text != "")
            {
                bool kayitAramaDurumu = false;
                con.Open();
                SqlCommand selectsorgu = new SqlCommand("select * from membersTable where UyeTcNo='" + txt_index.Text + "'", con);
                SqlDataReader kayitokuma = selectsorgu.ExecuteReader();



                while (kayitokuma.Read())
                {
                    kayitAramaDurumu = true;
                    SqlCommand deleteSorgu = new SqlCommand("delete from membersTable where UyeTcNo='" + txt_index.Text + "'", con);
                    con.Close();
                    con.Open();
                    deleteSorgu.ExecuteNonQuery();
                    MessageBox.Show("Üye Kaydı Silindi.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    con.Close();
                    uyeGoser();
                    temizle();
                    break;
                }
                if (kayitAramaDurumu == false)
                    MessageBox.Show("Üye Kaydı Bulunamadı!!", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);

                con.Close();
                uyeGoser();
                temizle();
            }
            else
                MessageBox.Show("Silmek istediğiniz üyenin Tc no sunu girin", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand guncelleKomutu = new SqlCommand("update membersTable set " +
                            "UyeAd='" + txt_ad.Text + "'," +
                            "UyeSoyAd='" + txt_soyad.Text + "'," +
                            "UyeEposta='" + txt_eposta.Text + "'," +
                            "UyeTelefon='" + txt_telefon.Text + ",'" +
                            "where UyeTcNo='" + txt_tc.Text + "'", con);

                guncelleKomutu.ExecuteNonQuery();
                con.Close();
                uyeGoser();
                temizle();
                MessageBox.Show("Güncelleme başarılı.", "Kütüphane ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Güncelleme başarısız.Kütüphane ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
       }

        private void uye_islemleri_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Data Grid View çökyordu başlığa tıklayınca çökmemesi için 
            if (e.RowIndex == -1) return;

            txt_tc.Text = uye_islemleri_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ad.Text = uye_islemleri_dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_soyad.Text = uye_islemleri_dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_telefon.Text = uye_islemleri_dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_eposta.Text = uye_islemleri_dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_uyeno.Text = uye_islemleri_dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_index.Text = uye_islemleri_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void txt_index_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            con.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from membersTable where (UyeAd+UyeSoyAd+UyeTcNo+UyeTelefon) Like'%" + txt_index.Text + "%' OR UyeNo Like '%" + txt_index.Text + "'  ", con);
            adtr.Fill(tablo);
            uye_islemleri_dataGrid.DataSource = tablo;
            con.Close();
        }
    }
}
