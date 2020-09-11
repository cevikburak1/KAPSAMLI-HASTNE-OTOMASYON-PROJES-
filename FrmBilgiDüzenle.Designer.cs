namespace Hastane_otomasyon_projesi
{
    partial class FrmBilgiDüzenle
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
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek\t",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(175, 221);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(128, 24);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(62, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cinsiyet :";
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(175, 136);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(128, 22);
            this.mskTelefon.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(68, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefon :";
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(176, 177);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(127, 22);
            this.txtŞifre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 28;
            this.label3.Text = "Şifre :";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(176, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(127, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Soyad :";
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(162, 265);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(152, 49);
            this.btnBilgiGüncelle.TabIndex = 7;
            this.btnBilgiGüncelle.Text = "Bilgi Güncelle";
            this.btnBilgiGüncelle.UseVisualStyleBackColor = true;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(176, 22);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(127, 22);
            this.txtAd.TabIndex = 1;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(175, 98);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(128, 22);
            this.mskTC.TabIndex = 3;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(111, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "AD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "TC Kimlik No :";
            // 
            // FrmBilgiDüzenle
            // 
            this.AcceptButton = this.btnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(399, 367);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBilgiGüncelle);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "FrmBilgiDüzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBilgiGüncelle;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}