namespace Hastane_otomasyon_projesi
{
    partial class FrmDoktorGiriş
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
            this.BtnGirişYap = new System.Windows.Forms.Button();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGirişYap
            // 
            this.BtnGirişYap.Location = new System.Drawing.Point(191, 236);
            this.BtnGirişYap.Name = "BtnGirişYap";
            this.BtnGirişYap.Size = new System.Drawing.Size(152, 49);
            this.BtnGirişYap.TabIndex = 14;
            this.BtnGirişYap.Text = "Giriş Yap";
            this.BtnGirişYap.UseVisualStyleBackColor = true;
            this.BtnGirişYap.Click += new System.EventHandler(this.BtnGirişYap_Click);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(222, 199);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(98, 22);
            this.txtŞifre.TabIndex = 12;
            this.txtŞifre.Text = "123";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(221, 160);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(99, 22);
            this.MskTC.TabIndex = 11;
            this.MskTC.Text = "12345678948";
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(142, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 67);
            this.label1.TabIndex = 8;
            this.label1.Text = "Doktor Giriş Paneli";
            // 
            // FrmDoktorGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(568, 324);
            this.Controls.Add(this.BtnGirişYap);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoktorGiriş";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.FrmDoktorGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGirişYap;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}