
namespace library_program
{
    partial class startPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPage));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_toplamkitap = new System.Windows.Forms.Label();
            this.lbl_uyesay = new System.Windows.Forms.Label();
            this.lblverkitap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(297, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(665, 113);
            this.label2.TabIndex = 1;
            this.label2.Text = "KÜTÜPHANE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOPLAM KİTAP SAYISI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(778, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(356, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "TOPLAM ÜYE SAYISI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(467, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "VERİLMİŞ KİTAP SAYISI";
            // 
            // lbl_toplamkitap
            // 
            this.lbl_toplamkitap.AutoSize = true;
            this.lbl_toplamkitap.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toplamkitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_toplamkitap.ForeColor = System.Drawing.Color.White;
            this.lbl_toplamkitap.Location = new System.Drawing.Point(388, 313);
            this.lbl_toplamkitap.Name = "lbl_toplamkitap";
            this.lbl_toplamkitap.Size = new System.Drawing.Size(26, 39);
            this.lbl_toplamkitap.TabIndex = 5;
            this.lbl_toplamkitap.Text = ".";
            this.lbl_toplamkitap.Click += new System.EventHandler(this.lbl_toplamkitap_Click);
            // 
            // lbl_uyesay
            // 
            this.lbl_uyesay.AutoSize = true;
            this.lbl_uyesay.BackColor = System.Drawing.Color.Transparent;
            this.lbl_uyesay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_uyesay.ForeColor = System.Drawing.Color.White;
            this.lbl_uyesay.Location = new System.Drawing.Point(936, 302);
            this.lbl_uyesay.Name = "lbl_uyesay";
            this.lbl_uyesay.Size = new System.Drawing.Size(26, 39);
            this.lbl_uyesay.TabIndex = 6;
            this.lbl_uyesay.Text = ".";
            // 
            // lblverkitap
            // 
            this.lblverkitap.AutoSize = true;
            this.lblverkitap.BackColor = System.Drawing.Color.Transparent;
            this.lblverkitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblverkitap.ForeColor = System.Drawing.Color.White;
            this.lblverkitap.Location = new System.Drawing.Point(653, 510);
            this.lblverkitap.Name = "lblverkitap";
            this.lblverkitap.Size = new System.Drawing.Size(26, 39);
            this.lblverkitap.TabIndex = 7;
            this.lblverkitap.Text = ".";
            // 
            // startPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.lblverkitap);
            this.Controls.Add(this.lbl_uyesay);
            this.Controls.Add(this.lbl_toplamkitap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startPage";
            this.Text = "startPage";
            this.Load += new System.EventHandler(this.startPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_toplamkitap;
        private System.Windows.Forms.Label lbl_uyesay;
        private System.Windows.Forms.Label lblverkitap;
    }
}