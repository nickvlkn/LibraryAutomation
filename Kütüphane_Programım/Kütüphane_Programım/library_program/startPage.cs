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
    public partial class startPage : Form
    {
        public startPage()
        {
            InitializeComponent();
        }
        SqlConnection con;
        DataTable tablo = new DataTable();

  

        private void lbl_toplamkitap_Click(object sender, EventArgs e)
        {

         
        }

        private void kitapGoster()
        {

            try
            {
                con = new SqlConnection("Data Source=localhost;Initial Catalog=library_database;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from booksTable", con);


                SqlCommand Cmd = new SqlCommand("SELECT COUNT(*) FROM booksTable", con);
                lbl_toplamkitap.Text = Cmd.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception hatamsj)
            {

                MessageBox.Show(hatamsj.Message, "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        private void uyeGoster()
        {

            try
            {
                con = new SqlConnection("Data Source=localhost;Initial Catalog=library_database;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from membersTable", con);

                SqlCommand Cmd = new SqlCommand("SELECT COUNT(*) FROM membersTable", con);
                lbl_uyesay.Text = Cmd.ExecuteScalar().ToString();
            }
            catch (Exception hatamsj)
            {

                MessageBox.Show(hatamsj.Message, "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }
        private void verGoster()
        {

            try
            {
                con = new SqlConnection("Data Source=localhost;Initial Catalog=library_database;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from transactionsTable", con);

                SqlCommand Cmd = new SqlCommand("SELECT COUNT(*) FROM transactionsTable", con);
                lblverkitap.Text = Cmd.ExecuteScalar().ToString();
            }
            catch (Exception hatamsj)
            {

                MessageBox.Show(hatamsj.Message, "Kütüphane", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }


        private void startPage_Load(object sender, EventArgs e)
        {
            kitapGoster();
            uyeGoster();
            verGoster();
        }
    }
}
