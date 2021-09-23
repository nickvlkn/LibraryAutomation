using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_program
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }
        SqlConnection con;

        private void index_Load(object sender, EventArgs e)
        {
            startPage if1 = new startPage();
            if1.TopLevel = false;
            index_panel.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }


 

        private void btn_index_Click(object sender, EventArgs e)
        {
            //index_panel.Controls.Clear();
            startPage if1 = new startPage();
            if1.TopLevel = false;
            index_panel.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }

        private void btn_kitapIslemleri_Click(object sender, EventArgs e)
        {
            index_panel.Controls.Clear();
            kitap_islemleri if1 = new kitap_islemleri();
            if1.TopLevel = false;
            index_panel.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();

        }

        private void btn_uyeIslemleri_Click(object sender, EventArgs e)
        {
            index_panel.Controls.Clear();
            uye_islemleri if1 = new uye_islemleri();
            if1.TopLevel = false;
            index_panel.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }

        private void btn_kitapVer_Click(object sender, EventArgs e)
        {
            index_panel.Controls.Clear();
            kitapVer if1 = new kitapVer();
            if1.TopLevel = false;
            index_panel.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }

        private void btn_kitapTeslimAl_Click(object sender, EventArgs e)
        {
            index_panel.Controls.Clear();
            kitapAl if1 = new kitapAl();
            if1.TopLevel = false;
            index_panel.Controls.Add(if1);
            if1.Show();
            if1.Dock = DockStyle.Fill;
            if1.BringToFront();
        }

        private void index_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
