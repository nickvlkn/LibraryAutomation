
namespace library_program
{
    partial class kitapVer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.kitap_goster_datagrid = new System.Windows.Forms.DataGridView();
            this.uye_goser_dataGrid = new System.Windows.Forms.DataGridView();
            this.dsasd = new System.Windows.Forms.GroupBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_uyeno = new System.Windows.Forms.TextBox();
            this.labeluye = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.txt_uyetcno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_uyesoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_uyeeposta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_uyetelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_kitapadi = new System.Windows.Forms.TextBox();
            this.lblkitapno = new System.Windows.Forms.Label();
            this.txt_kitapno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kitapyayinevi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_kitapyazari = new System.Windows.Forms.TextBox();
            this.txt_durum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_goster_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uye_goser_dataGrid)).BeginInit();
            this.dsasd.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kitap Ver";
            // 
            // kitap_goster_datagrid
            // 
            this.kitap_goster_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitap_goster_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_goster_datagrid.Location = new System.Drawing.Point(10, 348);
            this.kitap_goster_datagrid.Name = "kitap_goster_datagrid";
            this.kitap_goster_datagrid.RowHeadersWidth = 51;
            this.kitap_goster_datagrid.RowTemplate.Height = 24;
            this.kitap_goster_datagrid.Size = new System.Drawing.Size(851, 290);
            this.kitap_goster_datagrid.TabIndex = 3;
            this.kitap_goster_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitap_goster_datagrid_CellClick);
            // 
            // uye_goser_dataGrid
            // 
            this.uye_goser_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uye_goser_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uye_goser_dataGrid.Location = new System.Drawing.Point(12, 47);
            this.uye_goser_dataGrid.Name = "uye_goser_dataGrid";
            this.uye_goser_dataGrid.RowHeadersWidth = 51;
            this.uye_goser_dataGrid.RowTemplate.Height = 24;
            this.uye_goser_dataGrid.Size = new System.Drawing.Size(851, 295);
            this.uye_goser_dataGrid.TabIndex = 4;
            this.uye_goser_dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uye_goser_dataGrid_CellClick);
            // 
            // dsasd
            // 
            this.dsasd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.dsasd.Controls.Add(this.txt_durum);
            this.dsasd.Controls.Add(this.label10);
            this.dsasd.Controls.Add(this.btn_ekle);
            this.dsasd.Controls.Add(this.txt_kitapyayinevi);
            this.dsasd.Controls.Add(this.label11);
            this.dsasd.Controls.Add(this.txt_kitapyazari);
            this.dsasd.Controls.Add(this.label8);
            this.dsasd.Controls.Add(this.txt_kitapadi);
            this.dsasd.Controls.Add(this.lblkitapno);
            this.dsasd.Controls.Add(this.txt_kitapno);
            this.dsasd.Controls.Add(this.label6);
            this.dsasd.Controls.Add(this.txt_uyeeposta);
            this.dsasd.Controls.Add(this.label7);
            this.dsasd.Controls.Add(this.txt_uyetelefon);
            this.dsasd.Controls.Add(this.label4);
            this.dsasd.Controls.Add(this.txt_uyesoyad);
            this.dsasd.Controls.Add(this.label5);
            this.dsasd.Controls.Add(this.txt_ad);
            this.dsasd.Controls.Add(this.lbltc);
            this.dsasd.Controls.Add(this.txt_uyetcno);
            this.dsasd.Controls.Add(this.labeluye);
            this.dsasd.Controls.Add(this.txt_uyeno);
            this.dsasd.Location = new System.Drawing.Point(879, 24);
            this.dsasd.Name = "dsasd";
            this.dsasd.Size = new System.Drawing.Size(464, 614);
            this.dsasd.TabIndex = 33;
            this.dsasd.TabStop = false;
            this.dsasd.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(18, 488);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(428, 38);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "Kitap Ver";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_uyeno
            // 
            this.txt_uyeno.Location = new System.Drawing.Point(18, 51);
            this.txt_uyeno.Multiline = true;
            this.txt_uyeno.Name = "txt_uyeno";
            this.txt_uyeno.Size = new System.Drawing.Size(200, 35);
            this.txt_uyeno.TabIndex = 1;
            // 
            // labeluye
            // 
            this.labeluye.AutoSize = true;
            this.labeluye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labeluye.ForeColor = System.Drawing.Color.White;
            this.labeluye.Location = new System.Drawing.Point(25, 23);
            this.labeluye.Name = "labeluye";
            this.labeluye.Size = new System.Drawing.Size(77, 25);
            this.labeluye.TabIndex = 22;
            this.labeluye.Text = "Üye No";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbltc.ForeColor = System.Drawing.Color.White;
            this.lbltc.Location = new System.Drawing.Point(252, 23);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(115, 25);
            this.lbltc.TabIndex = 30;
            this.lbltc.Text = "Üye TC  No";
            this.lbltc.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_uyetcno
            // 
            this.txt_uyetcno.Location = new System.Drawing.Point(252, 51);
            this.txt_uyetcno.Multiline = true;
            this.txt_uyetcno.Name = "txt_uyetcno";
            this.txt_uyetcno.Size = new System.Drawing.Size(200, 35);
            this.txt_uyetcno.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(252, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Üye Soyad";
            // 
            // txt_uyesoyad
            // 
            this.txt_uyesoyad.Location = new System.Drawing.Point(246, 131);
            this.txt_uyesoyad.Multiline = true;
            this.txt_uyesoyad.Name = "txt_uyesoyad";
            this.txt_uyesoyad.Size = new System.Drawing.Size(200, 35);
            this.txt_uyesoyad.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Üye Ad";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(18, 131);
            this.txt_ad.Multiline = true;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(200, 35);
            this.txt_ad.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(252, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "Üye  eposta";
            // 
            // txt_uyeeposta
            // 
            this.txt_uyeeposta.Location = new System.Drawing.Point(246, 208);
            this.txt_uyeeposta.Multiline = true;
            this.txt_uyeeposta.Name = "txt_uyeeposta";
            this.txt_uyeeposta.Size = new System.Drawing.Size(200, 35);
            this.txt_uyeeposta.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "Üye Telefon";
            // 
            // txt_uyetelefon
            // 
            this.txt_uyetelefon.Location = new System.Drawing.Point(18, 208);
            this.txt_uyetelefon.Multiline = true;
            this.txt_uyetelefon.Name = "txt_uyetelefon";
            this.txt_uyetelefon.Size = new System.Drawing.Size(200, 35);
            this.txt_uyetelefon.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(252, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Kitap Adı";
            // 
            // txt_kitapadi
            // 
            this.txt_kitapadi.Location = new System.Drawing.Point(246, 321);
            this.txt_kitapadi.Multiline = true;
            this.txt_kitapadi.Name = "txt_kitapadi";
            this.txt_kitapadi.Size = new System.Drawing.Size(200, 35);
            this.txt_kitapadi.TabIndex = 8;
            // 
            // lblkitapno
            // 
            this.lblkitapno.AutoSize = true;
            this.lblkitapno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblkitapno.ForeColor = System.Drawing.Color.White;
            this.lblkitapno.Location = new System.Drawing.Point(25, 293);
            this.lblkitapno.Name = "lblkitapno";
            this.lblkitapno.Size = new System.Drawing.Size(87, 25);
            this.lblkitapno.TabIndex = 40;
            this.lblkitapno.Text = "Kitap No";
            this.lblkitapno.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_kitapno
            // 
            this.txt_kitapno.Location = new System.Drawing.Point(18, 321);
            this.txt_kitapno.Multiline = true;
            this.txt_kitapno.Name = "txt_kitapno";
            this.txt_kitapno.Size = new System.Drawing.Size(200, 35);
            this.txt_kitapno.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(252, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 25);
            this.label10.TabIndex = 46;
            this.label10.Text = "Kitap Yayın Evi";
            // 
            // txt_kitapyayinevi
            // 
            this.txt_kitapyayinevi.Location = new System.Drawing.Point(246, 396);
            this.txt_kitapyayinevi.Multiline = true;
            this.txt_kitapyayinevi.Name = "txt_kitapyayinevi";
            this.txt_kitapyayinevi.Size = new System.Drawing.Size(200, 35);
            this.txt_kitapyayinevi.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 44;
            this.label11.Text = "Kitap Yazarı";
            // 
            // txt_kitapyazari
            // 
            this.txt_kitapyazari.Location = new System.Drawing.Point(18, 396);
            this.txt_kitapyazari.Multiline = true;
            this.txt_kitapyazari.Name = "txt_kitapyazari";
            this.txt_kitapyazari.Size = new System.Drawing.Size(200, 35);
            this.txt_kitapyazari.TabIndex = 9;
            // 
            // txt_durum
            // 
            this.txt_durum.Enabled = false;
            this.txt_durum.Location = new System.Drawing.Point(18, 447);
            this.txt_durum.Multiline = true;
            this.txt_durum.Name = "txt_durum";
            this.txt_durum.Size = new System.Drawing.Size(200, 35);
            this.txt_durum.TabIndex = 47;
            // 
            // kitapVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 650);
            this.Controls.Add(this.dsasd);
            this.Controls.Add(this.uye_goser_dataGrid);
            this.Controls.Add(this.kitap_goster_datagrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kitapVer";
            this.Text = "kitapVer";
            this.Load += new System.EventHandler(this.kitapVer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitap_goster_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uye_goser_dataGrid)).EndInit();
            this.dsasd.ResumeLayout(false);
            this.dsasd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView kitap_goster_datagrid;
        private System.Windows.Forms.DataGridView uye_goser_dataGrid;
        private System.Windows.Forms.GroupBox dsasd;
        private System.Windows.Forms.Label labeluye;
        private System.Windows.Forms.TextBox txt_uyeno;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.TextBox txt_uyetcno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_kitapyayinevi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_kitapyazari;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_kitapadi;
        private System.Windows.Forms.Label lblkitapno;
        private System.Windows.Forms.TextBox txt_kitapno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_uyeeposta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_uyetelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_uyesoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_durum;
    }
}