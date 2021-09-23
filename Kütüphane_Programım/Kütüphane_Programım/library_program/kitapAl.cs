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
    public partial class kitapAl : Form
    {
        public kitapAl()
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
                SqlDataAdapter da = new SqlDataAdapter("select * from transactionsTable", con);
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

        private void kitapAl_Load(object sender, EventArgs e)
        {
            kitapGoster();
        }


        void teslimAl()
        {
            if (txt_kitapno.Text != "")
            {
                bool kayitAramaDurumu = false;
                con.Open();
                SqlCommand aramaSorgu = new SqlCommand("select * from transactionsTable where islem_kitapNo='" + txt_kitapno.Text + "'", con);
                SqlDataReader kayitokuma = aramaSorgu.ExecuteReader();

                while (kayitokuma.Read())
                {
                    kayitAramaDurumu = true;
                    SqlCommand deleteSorgu = new SqlCommand("delete from transactionsTable where islem_kitapNo='" + txt_kitapno.Text + "'", con);

                    con.Close();
                    con.Open();
                    deleteSorgu.ExecuteNonQuery();
                    SqlCommand KiraDurumuEkle = new SqlCommand("update booksTable set KitapDurum='bos' where KitapNo='" + txt_kitapno.Text + "'", con);
                    KiraDurumuEkle.ExecuteNonQuery();

                    MessageBox.Show("Araç Teslim Alındı. (BAŞARILI)", "VOLKAN RENT A CAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //baglantim.Close();
                    //aracGoster();
                    //aracEkleTemizle();
                    break;

                }

                if (kayitAramaDurumu == false)
                    MessageBox.Show("Silinecek Araç Kaydı Bulunamadı!!", "VOLKAN RENT A CAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                con.Close();
                kitapGoster();

            }//if

            else
                MessageBox.Show("Silmek istediğiniz kaydın Plakasını doğru girin.!!", "VOLKAN RENT A CAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            teslimAl();
        }

        private void kitap_goster_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Data Grid View çökyordu başlığa tıklayınca çökmemesi için 
            if (e.RowIndex == -1) return;
            txt_kitapno.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_kitapadi.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_kitapyazari.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[2].Value.ToString();

            txt_uyeno.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_uyetcno.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_ad.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_uyetelefon.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_durum.Text = kitap_goster_datagrid.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void txt_durum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
