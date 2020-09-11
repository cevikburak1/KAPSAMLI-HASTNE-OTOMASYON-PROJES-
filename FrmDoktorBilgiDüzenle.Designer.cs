namespace Hastane_otomasyon_projesi
{
    partial class FrmDoktorBilgiDüzenle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.cmbBranş = new System.Windows.Forms.ComboBox();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Branş :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Şifre :";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(182, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(124, 23);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(182, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(124, 23);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtŞifre
            // 
            this.txtŞifre.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtŞifre.Location = new System.Drawing.Point(182, 186);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(124, 23);
            this.txtŞifre.TabIndex = 7;
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(182, 109);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(124, 23);
            this.mskTC.TabIndex = 8;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // cmbBranş
            // 
            this.cmbBranş.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBranş.FormattingEnabled = true;
            this.cmbBranş.Location = new System.Drawing.Point(182, 144);
            this.cmbBranş.Name = "cmbBranş";
            this.cmbBranş.Size = new System.Drawing.Size(124, 23);
            this.cmbBranş.TabIndex = 9;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.Lime;
            this.btnGüncelle.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGüncelle.Location = new System.Drawing.Point(164, 222);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(155, 42);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click_1);
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(382, 285);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.cmbBranş);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.ComboBox cmbBranş;
        private System.Windows.Forms.Button btnGüncelle;
    }
}