
namespace library_program
{
    partial class uye_islemleri
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
            this.uye_islemleri_dataGrid = new System.Windows.Forms.DataGridView();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_tc = new System.Windows.Forms.TextBox();
            this.lbl_uyesoyad = new System.Windows.Forms.Label();
            this.lbl_uyeno = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_uyeadi = new System.Windows.Forms.Label();
            this.lbl_uyetc = new System.Windows.Forms.Label();
            this.txt_uyeno = new System.Windows.Forms.TextBox();
            this.lbl_uyeeposta = new System.Windows.Forms.Label();
            this.txt_eposta = new System.Windows.Forms.TextBox();
            this.lbl_uyetelefon = new System.Windows.Forms.Label();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_index = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uye_islemleri_dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uye_islemleri_dataGrid
            // 
            this.uye_islemleri_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uye_islemleri_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uye_islemleri_dataGrid.Location = new System.Drawing.Point(12, 309);
            this.uye_islemleri_dataGrid.Name = "uye_islemleri_dataGrid";
            this.uye_islemleri_dataGrid.RowHeadersWidth = 51;
            this.uye_islemleri_dataGrid.RowTemplate.Height = 24;
            this.uye_islemleri_dataGrid.Size = new System.Drawing.Size(1339, 339);
            this.uye_islemleri_dataGrid.TabIndex = 1;
            this.uye_islemleri_dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uye_islemleri_dataGrid_CellClick);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(255, 250);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(138, 33);
            this.btn_guncelle.TabIndex = 12;
            this.btn_guncelle.Text = "Üye Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(108, 252);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(127, 33);
            this.btn_ekle.TabIndex = 10;
            this.btn_ekle.Text = "Üye Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_tc
            // 
            this.txt_tc.Location = new System.Drawing.Point(380, 65);
            this.txt_tc.Multiline = true;
            this.txt_tc.Name = "txt_tc";
            this.txt_tc.Size = new System.Drawing.Size(258, 30);
            this.txt_tc.TabIndex = 5;
            this.txt_tc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tc_KeyPress);
            // 
            // lbl_uyesoyad
            // 
            this.lbl_uyesoyad.AutoSize = true;
            this.lbl_uyesoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyesoyad.ForeColor = System.Drawing.Color.White;
            this.lbl_uyesoyad.Location = new System.Drawing.Point(380, 100);
            this.lbl_uyesoyad.Name = "lbl_uyesoyad";
            this.lbl_uyesoyad.Size = new System.Drawing.Size(113, 25);
            this.lbl_uyesoyad.TabIndex = 23;
            this.lbl_uyesoyad.Text = "Üye Soyadı";
            // 
            // lbl_uyeno
            // 
            this.lbl_uyeno.AutoSize = true;
            this.lbl_uyeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyeno.ForeColor = System.Drawing.Color.White;
            this.lbl_uyeno.Location = new System.Drawing.Point(103, 32);
            this.lbl_uyeno.Name = "lbl_uyeno";
            this.lbl_uyeno.Size = new System.Drawing.Size(77, 25);
            this.lbl_uyeno.TabIndex = 22;
            this.lbl_uyeno.Text = "Üye No";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(380, 133);
            this.txt_soyad.Multiline = true;
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(258, 30);
            this.txt_soyad.TabIndex = 6;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(106, 133);
            this.txt_ad.Multiline = true;
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(258, 30);
            this.txt_ad.TabIndex = 3;
            // 
            // lbl_uyeadi
            // 
            this.lbl_uyeadi.AutoSize = true;
            this.lbl_uyeadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyeadi.ForeColor = System.Drawing.Color.White;
            this.lbl_uyeadi.Location = new System.Drawing.Point(101, 100);
            this.lbl_uyeadi.Name = "lbl_uyeadi";
            this.lbl_uyeadi.Size = new System.Drawing.Size(81, 25);
            this.lbl_uyeadi.TabIndex = 19;
            this.lbl_uyeadi.Text = "Üye Adı";
            // 
            // lbl_uyetc
            // 
            this.lbl_uyetc.AutoSize = true;
            this.lbl_uyetc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyetc.ForeColor = System.Drawing.Color.White;
            this.lbl_uyetc.Location = new System.Drawing.Point(380, 32);
            this.lbl_uyetc.Name = "lbl_uyetc";
            this.lbl_uyetc.Size = new System.Drawing.Size(75, 25);
            this.lbl_uyetc.TabIndex = 18;
            this.lbl_uyetc.Text = "Üye Tc";
            // 
            // txt_uyeno
            // 
            this.txt_uyeno.Enabled = false;
            this.txt_uyeno.Location = new System.Drawing.Point(106, 65);
            this.txt_uyeno.Multiline = true;
            this.txt_uyeno.Name = "txt_uyeno";
            this.txt_uyeno.Size = new System.Drawing.Size(258, 30);
            this.txt_uyeno.TabIndex = 2;
            // 
            // lbl_uyeeposta
            // 
            this.lbl_uyeeposta.AutoSize = true;
            this.lbl_uyeeposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyeeposta.ForeColor = System.Drawing.Color.White;
            this.lbl_uyeeposta.Location = new System.Drawing.Point(375, 171);
            this.lbl_uyeeposta.Name = "lbl_uyeeposta";
            this.lbl_uyeeposta.Size = new System.Drawing.Size(113, 25);
            this.lbl_uyeeposta.TabIndex = 26;
            this.lbl_uyeeposta.Text = "Üye Eposta";
            // 
            // txt_eposta
            // 
            this.txt_eposta.Location = new System.Drawing.Point(380, 209);
            this.txt_eposta.Multiline = true;
            this.txt_eposta.Name = "txt_eposta";
            this.txt_eposta.Size = new System.Drawing.Size(258, 30);
            this.txt_eposta.TabIndex = 7;
            // 
            // lbl_uyetelefon
            // 
            this.lbl_uyetelefon.AutoSize = true;
            this.lbl_uyetelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_uyetelefon.ForeColor = System.Drawing.Color.White;
            this.lbl_uyetelefon.Location = new System.Drawing.Point(103, 171);
            this.lbl_uyetelefon.Name = "lbl_uyetelefon";
            this.lbl_uyetelefon.Size = new System.Drawing.Size(118, 25);
            this.lbl_uyetelefon.TabIndex = 28;
            this.lbl_uyetelefon.Text = "Üye Telefon";
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(108, 209);
            this.txt_telefon.Multiline = true;
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(258, 30);
            this.txt_telefon.TabIndex = 4;
            this.txt_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefon_KeyPress);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Location = new System.Drawing.Point(524, 250);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(114, 33);
            this.btn_temizle.TabIndex = 31;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.lbl_uyeno);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.txt_uyeno);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.lbl_uyetc);
            this.groupBox1.Controls.Add(this.lbl_uyetelefon);
            this.groupBox1.Controls.Add(this.lbl_uyeadi);
            this.groupBox1.Controls.Add(this.txt_telefon);
            this.groupBox1.Controls.Add(this.txt_ad);
            this.groupBox1.Controls.Add(this.lbl_uyeeposta);
            this.groupBox1.Controls.Add(this.txt_soyad);
            this.groupBox1.Controls.Add(this.txt_eposta);
            this.groupBox1.Controls.Add(this.lbl_uyesoyad);
            this.groupBox1.Controls.Add(this.txt_tc);
            this.groupBox1.Location = new System.Drawing.Point(597, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 302);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kayıt";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.txt_index);
            this.groupBox2.Location = new System.Drawing.Point(0, -8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 311);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(37, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Arama ve silme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(37, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Üye,No,Tc,Adı,Soyadı,Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(166, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = " Kutuya Sadece  Tc No yazın";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(166, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Üye Silmek İçin";
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(32, 210);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(128, 38);
            this.btn_sil.TabIndex = 38;
            this.btn_sil.Text = "Üye Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            // 
            // txt_index
            // 
            this.txt_index.Location = new System.Drawing.Point(32, 157);
            this.txt_index.Multiline = true;
            this.txt_index.Name = "txt_index";
            this.txt_index.Size = new System.Drawing.Size(542, 38);
            this.txt_index.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 39);
            this.label1.TabIndex = 43;
            this.label1.Text = "Üye İşlemleri";
            // 
            // uye_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.uye_islemleri_dataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "uye_islemleri";
            this.Text = "uye_islemleri";
            this.Load += new System.EventHandler(this.uye_islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uye_islemleri_dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView uye_islemleri_dataGrid;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_tc;
        private System.Windows.Forms.Label lbl_uyesoyad;
        private System.Windows.Forms.Label lbl_uyeno;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_uyeadi;
        private System.Windows.Forms.Label lbl_uyetc;
        private System.Windows.Forms.TextBox txt_uyeno;
        private System.Windows.Forms.Label lbl_uyeeposta;
        private System.Windows.Forms.TextBox txt_eposta;
        private System.Windows.Forms.Label lbl_uyetelefon;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_index;
    }
}