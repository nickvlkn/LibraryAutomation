
namespace library_program
{
    partial class kitap_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_islemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.kitap_islemleri_dataGrid = new System.Windows.Forms.DataGridView();
            this.txt_index = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.txt_kitapno = new System.Windows.Forms.TextBox();
            this.lbl_kitapno = new System.Windows.Forms.Label();
            this.lbl_kitapad = new System.Windows.Forms.Label();
            this.txt_kitapad = new System.Windows.Forms.TextBox();
            this.txt_kitapyayinevi = new System.Windows.Forms.TextBox();
            this.lbl_yayinevi = new System.Windows.Forms.Label();
            this.lbl_kitapyazari = new System.Windows.Forms.Label();
            this.txt_kitapyazari = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_islemleri_dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap İşlemleri";
            // 
            // kitap_islemleri_dataGrid
            // 
            this.kitap_islemleri_dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kitap_islemleri_dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitap_islemleri_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_islemleri_dataGrid.Location = new System.Drawing.Point(12, 282);
            this.kitap_islemleri_dataGrid.MultiSelect = false;
            this.kitap_islemleri_dataGrid.Name = "kitap_islemleri_dataGrid";
            this.kitap_islemleri_dataGrid.ReadOnly = true;
            this.kitap_islemleri_dataGrid.RowHeadersWidth = 51;
            this.kitap_islemleri_dataGrid.RowTemplate.Height = 24;
            this.kitap_islemleri_dataGrid.Size = new System.Drawing.Size(1278, 356);
            this.kitap_islemleri_dataGrid.TabIndex = 3;
            this.kitap_islemleri_dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitap_islemleri_dataGrid_CellClick);
            // 
            // txt_index
            // 
            this.txt_index.Location = new System.Drawing.Point(13, 137);
            this.txt_index.Multiline = true;
            this.txt_index.Name = "txt_index";
            this.txt_index.Size = new System.Drawing.Size(494, 38);
            this.txt_index.TabIndex = 1;
            this.txt_index.TextChanged += new System.EventHandler(this.txt_index_TextChanged);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_ekle.ForeColor = System.Drawing.Color.White;
            this.btn_ekle.Location = new System.Drawing.Point(139, 186);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(166, 38);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "Kitap Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_sil.ForeColor = System.Drawing.Color.White;
            this.btn_sil.Location = new System.Drawing.Point(13, 184);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(185, 38);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "Kitap Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_guncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_guncelle.ForeColor = System.Drawing.Color.White;
            this.btn_guncelle.Location = new System.Drawing.Point(313, 186);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(167, 38);
            this.btn_guncelle.TabIndex = 8;
            this.btn_guncelle.Text = "Kitap Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // txt_kitapno
            // 
            this.txt_kitapno.Enabled = false;
            this.txt_kitapno.Location = new System.Drawing.Point(139, 58);
            this.txt_kitapno.Multiline = true;
            this.txt_kitapno.Name = "txt_kitapno";
            this.txt_kitapno.Size = new System.Drawing.Size(258, 35);
            this.txt_kitapno.TabIndex = 2;
            // 
            // lbl_kitapno
            // 
            this.lbl_kitapno.AutoSize = true;
            this.lbl_kitapno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_kitapno.ForeColor = System.Drawing.Color.White;
            this.lbl_kitapno.Location = new System.Drawing.Point(136, 28);
            this.lbl_kitapno.Name = "lbl_kitapno";
            this.lbl_kitapno.Size = new System.Drawing.Size(87, 25);
            this.lbl_kitapno.TabIndex = 10;
            this.lbl_kitapno.Text = "Kitap No";
            // 
            // lbl_kitapad
            // 
            this.lbl_kitapad.AutoSize = true;
            this.lbl_kitapad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_kitapad.ForeColor = System.Drawing.Color.White;
            this.lbl_kitapad.Location = new System.Drawing.Point(134, 103);
            this.lbl_kitapad.Name = "lbl_kitapad";
            this.lbl_kitapad.Size = new System.Drawing.Size(91, 25);
            this.lbl_kitapad.TabIndex = 11;
            this.lbl_kitapad.Text = "Kitap Adı";
            // 
            // txt_kitapad
            // 
            this.txt_kitapad.Location = new System.Drawing.Point(139, 131);
            this.txt_kitapad.Multiline = true;
            this.txt_kitapad.Name = "txt_kitapad";
            this.txt_kitapad.Size = new System.Drawing.Size(258, 35);
            this.txt_kitapad.TabIndex = 4;
            // 
            // txt_kitapyayinevi
            // 
            this.txt_kitapyayinevi.Location = new System.Drawing.Point(413, 131);
            this.txt_kitapyayinevi.Multiline = true;
            this.txt_kitapyayinevi.Name = "txt_kitapyayinevi";
            this.txt_kitapyayinevi.Size = new System.Drawing.Size(258, 35);
            this.txt_kitapyayinevi.TabIndex = 5;
            // 
            // lbl_yayinevi
            // 
            this.lbl_yayinevi.AutoSize = true;
            this.lbl_yayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_yayinevi.ForeColor = System.Drawing.Color.White;
            this.lbl_yayinevi.Location = new System.Drawing.Point(408, 98);
            this.lbl_yayinevi.Name = "lbl_yayinevi";
            this.lbl_yayinevi.Size = new System.Drawing.Size(143, 25);
            this.lbl_yayinevi.TabIndex = 14;
            this.lbl_yayinevi.Text = "Kitap Yayın Evi";
            // 
            // lbl_kitapyazari
            // 
            this.lbl_kitapyazari.AutoSize = true;
            this.lbl_kitapyazari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_kitapyazari.ForeColor = System.Drawing.Color.White;
            this.lbl_kitapyazari.Location = new System.Drawing.Point(408, 24);
            this.lbl_kitapyazari.Name = "lbl_kitapyazari";
            this.lbl_kitapyazari.Size = new System.Drawing.Size(117, 25);
            this.lbl_kitapyazari.TabIndex = 15;
            this.lbl_kitapyazari.Text = "Kitap Yazarı";
            // 
            // txt_kitapyazari
            // 
            this.txt_kitapyazari.Location = new System.Drawing.Point(413, 58);
            this.txt_kitapyazari.Multiline = true;
            this.txt_kitapyazari.Name = "txt_kitapyazari";
            this.txt_kitapyazari.Size = new System.Drawing.Size(258, 35);
            this.txt_kitapyazari.TabIndex = 3;
            this.txt_kitapyazari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kitapyazari_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.txt_kitapno);
            this.groupBox1.Controls.Add(this.txt_kitapyazari);
            this.groupBox1.Controls.Add(this.lbl_kitapno);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.lbl_kitapyazari);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.lbl_kitapad);
            this.groupBox1.Controls.Add(this.lbl_yayinevi);
            this.groupBox1.Controls.Add(this.txt_kitapad);
            this.groupBox1.Controls.Add(this.txt_kitapyayinevi);
            this.groupBox1.Location = new System.Drawing.Point(540, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 264);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Bigileri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_temizle.ForeColor = System.Drawing.Color.White;
            this.btn_temizle.Location = new System.Drawing.Point(571, 186);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(100, 38);
            this.btn_temizle.TabIndex = 6;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kitap No,Ad,Yazar,Yayın evi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(204, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kitap Silmek İçin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(204, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = " Kutuya Sadece  Kitap No yazın";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Arama ve silme";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_index);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_sil);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 273);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // kitap_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kitap_islemleri_dataGrid);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kitap_islemleri";
            this.Load += new System.EventHandler(this.kitap_islemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitap_islemleri_dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView kitap_islemleri_dataGrid;
        private System.Windows.Forms.TextBox txt_index;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.TextBox txt_kitapno;
        private System.Windows.Forms.Label lbl_kitapno;
        private System.Windows.Forms.Label lbl_kitapad;
        private System.Windows.Forms.TextBox txt_kitapad;
        private System.Windows.Forms.TextBox txt_kitapyayinevi;
        private System.Windows.Forms.Label lbl_yayinevi;
        private System.Windows.Forms.Label lbl_kitapyazari;
        private System.Windows.Forms.TextBox txt_kitapyazari;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
    }
}