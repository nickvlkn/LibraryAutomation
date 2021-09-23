
namespace library_program
{
    partial class index
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.btn_index = new System.Windows.Forms.Button();
            this.btn_uyeIslemleri = new System.Windows.Forms.Button();
            this.btn_kitapVer = new System.Windows.Forms.Button();
            this.btn_kitapTeslimAl = new System.Windows.Forms.Button();
            this.index_panel = new System.Windows.Forms.Panel();
            this.btn_kitapIslemleri = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btn_index
            // 
            this.btn_index.Location = new System.Drawing.Point(0, 0);
            this.btn_index.Name = "btn_index";
            this.btn_index.Size = new System.Drawing.Size(166, 48);
            this.btn_index.TabIndex = 1;
            this.btn_index.Text = "Anasayfa";
            this.btn_index.UseVisualStyleBackColor = true;
            this.btn_index.Click += new System.EventHandler(this.btn_index_Click);
            // 
            // btn_uyeIslemleri
            // 
            this.btn_uyeIslemleri.Location = new System.Drawing.Point(0, 108);
            this.btn_uyeIslemleri.Name = "btn_uyeIslemleri";
            this.btn_uyeIslemleri.Size = new System.Drawing.Size(166, 48);
            this.btn_uyeIslemleri.TabIndex = 2;
            this.btn_uyeIslemleri.Text = "Üye işlemleri";
            this.btn_uyeIslemleri.UseVisualStyleBackColor = true;
            this.btn_uyeIslemleri.Click += new System.EventHandler(this.btn_uyeIslemleri_Click);
            // 
            // btn_kitapVer
            // 
            this.btn_kitapVer.Location = new System.Drawing.Point(0, 162);
            this.btn_kitapVer.Name = "btn_kitapVer";
            this.btn_kitapVer.Size = new System.Drawing.Size(166, 48);
            this.btn_kitapVer.TabIndex = 3;
            this.btn_kitapVer.Text = "Kitap Ver";
            this.btn_kitapVer.UseVisualStyleBackColor = true;
            this.btn_kitapVer.Click += new System.EventHandler(this.btn_kitapVer_Click);
            // 
            // btn_kitapTeslimAl
            // 
            this.btn_kitapTeslimAl.Location = new System.Drawing.Point(0, 216);
            this.btn_kitapTeslimAl.Name = "btn_kitapTeslimAl";
            this.btn_kitapTeslimAl.Size = new System.Drawing.Size(166, 48);
            this.btn_kitapTeslimAl.TabIndex = 4;
            this.btn_kitapTeslimAl.Text = "Kitap Teslim Al";
            this.btn_kitapTeslimAl.UseVisualStyleBackColor = true;
            this.btn_kitapTeslimAl.Click += new System.EventHandler(this.btn_kitapTeslimAl_Click);
            // 
            // index_panel
            // 
            this.index_panel.BackColor = System.Drawing.Color.Silver;
            this.index_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("index_panel.BackgroundImage")));
            this.index_panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.index_panel.Location = new System.Drawing.Point(172, 2);
            this.index_panel.Name = "index_panel";
            this.index_panel.Size = new System.Drawing.Size(1500, 650);
            this.index_panel.TabIndex = 6;
            this.index_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.index_panel_Paint);
            // 
            // btn_kitapIslemleri
            // 
            this.btn_kitapIslemleri.Location = new System.Drawing.Point(0, 54);
            this.btn_kitapIslemleri.Name = "btn_kitapIslemleri";
            this.btn_kitapIslemleri.Size = new System.Drawing.Size(166, 48);
            this.btn_kitapIslemleri.TabIndex = 7;
            this.btn_kitapIslemleri.Text = "Kitap İşlemleri ";
            this.btn_kitapIslemleri.UseVisualStyleBackColor = true;
            this.btn_kitapIslemleri.Click += new System.EventHandler(this.btn_kitapIslemleri_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Kütüphane";
            this.notifyIcon1.Visible = true;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1673, 654);
            this.Controls.Add(this.btn_kitapIslemleri);
            this.Controls.Add(this.index_panel);
            this.Controls.Add(this.btn_kitapTeslimAl);
            this.Controls.Add(this.btn_kitapVer);
            this.Controls.Add(this.btn_uyeIslemleri);
            this.Controls.Add(this.btn_index);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "index";
            this.Text = "Kütüphane";
            this.Load += new System.EventHandler(this.index_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_index;
        private System.Windows.Forms.Button btn_uyeIslemleri;
        private System.Windows.Forms.Button btn_kitapVer;
        private System.Windows.Forms.Button btn_kitapTeslimAl;
        private System.Windows.Forms.Panel index_panel;
        private System.Windows.Forms.Button btn_kitapIslemleri;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

