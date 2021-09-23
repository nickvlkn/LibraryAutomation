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
    public partial class kitapVer : Form
    {
        public kitapVer()
        {
            InitializeComponent();
        }

        SqlConnection con;



        private void kitapGoster()
        {

            try
            {
                con = new SqlConnection("Data Source=localhost;Initial Catalog=library_database;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from booksTable", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "fristTable");
                kitap_goster_datagrid.DataSource = ds.Tables["fristTable"];
                con.Close();
            }
            catch (Exception hatamsj)
            {

                MessageBox.Show(hatamsj.Message, "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }


        private void uyeGoser()
        {
            try
            {
                con = new SqlConnection("Data Source=localhost;Initial Catalog=library_database;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from membersTable", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "fristTable");
                uye_goser_dataGrid.DataSource = ds.Tables["fristTable"];
                con.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void kitapVer_Load(object sender, EventArgs e)
        {
            kitapGoster();
            uyeGoser();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void uye_goser_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Data Grid View çökyordu başlığa tıklayınca çökmemesi için 
            if (e.RowIndex == -1) return;

      
            txt_uyetcno.Text = uye_goser_dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ad.Text = uye_goser_dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_uyesoyad.Text = uye_goser_dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_uyetelefon.Text = uye_goser_dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_uyeeposta.Text = uye_goser_dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_uyeno.Text = uye_goser_dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        

        }

        private void kitap_goster_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Data Grid View çökyordu başlığa tıklayınca çökmemesi için 
            if (e.RowIndex == -1) return;
            txt_kitapno.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_kitapadi.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_kitapyazari.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_kitapyayinevi.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_durum.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        void listele()
        {
            SqlDataAdapter aracListele = new SqlDataAdapter(
                "select * from booksTable where KitapDurum='bos' Order By KitapNo ASC", con);

            DataSet dsHafiza2 = new DataSet();
            //fill dolduruyor
            aracListele.Fill(dsHafiza2);
            kitap_goster_datagrid.DataSource = dsHafiza2.Tables[0];
            con.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {        
            bool kayitKontrol = false;

            //ekleyeceğimiz kişi daha önce varmı yokmu bakıyoruz
            con.Open();
            SqlCommand selectSorgu = new SqlCommand("select * from transactionsTable where islem_kitapNo='" + txt_kitapno.Text + "'", con);
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
                if (txt_kitapno.Text == "")
                    lblkitapno.ForeColor = Color.Red;
                else
                    lblkitapno.ForeColor = Color.White;

                if (txt_uyetcno.Text == "")
                    lbltc.ForeColor = Color.Red;
                else
                    lbltc.ForeColor = Color.White;

                if (txt_uyetcno.Text != "" && txt_kitapno.Text != "")
                {
                    try
                    {
                        txt_durum.Text = "dolu";
                        con.Open();                                                   
                        SqlCommand ekle = new SqlCommand("insert  into transactionsTable (islem_kitapNo,islem_kitapAdi,islem_kitapYazari,islem_uyeNo,islem_uyeTcNo,islem_uyeAd,islem_uyeTelefon,islem_durum)" +
                            "values('" + txt_kitapno.Text + "','" + txt_kitapadi.Text + "','" + txt_kitapyazari.Text + "','" + txt_uyeno.Text + "','" + txt_uyetcno.Text + "','" + txt_ad.Text + "','" + txt_uyetelefon.Text + "','" + txt_durum.Text + "')", con);
                        ekle.ExecuteNonQuery();
                        SqlCommand KiraDurumuEkle = new SqlCommand("update booksTable set KitapDurum='dolu' where KitapNo='" + txt_kitapno.Text + "'", con);
                        KiraDurumuEkle.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Kitap Verildi.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        listele();
                    }
                    catch (Exception hatamsj)
                    {
                        MessageBox.Show(hatamsj.Message, "Kitap Verilemedi . Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                    }
                }
                else
                    MessageBox.Show("Kırmızı alanları düzeltin.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("'" + txt_kitapno.Text + "'nolu kitap zaten verilmiştir.", "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
