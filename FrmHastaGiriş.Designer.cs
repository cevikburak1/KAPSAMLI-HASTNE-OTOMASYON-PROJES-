namespace Hastane_otomasyon_projesi
{
    partial class FrmHastaGiriş
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
            this.label4 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtŞifre = new System.Windows.Forms.TextBox();
            this.LnkÜyeOl = new System.Windows.Forms.LinkLabel();
            this.BtnGirişYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(86, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(170, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre :";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(249, 151);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(99, 22);
            this.MskTC.TabIndex = 1;
            this.MskTC.Text = "10043247584";
            this.MskTC.ValidatingType = typeof(int);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(250, 190);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(98, 22);
            this.txtŞifre.TabIndex = 2;
            this.txtŞifre.Text = "burakcevik1";
            // 
            // LnkÜyeOl
            // 
            this.LnkÜyeOl.AutoSize = true;
            this.LnkÜyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkÜyeOl.Location = new System.Drawing.Point(365, 193);
            this.LnkÜyeOl.Name = "LnkÜyeOl";
            this.LnkÜyeOl.Size = new System.Drawing.Size(60, 20);
            this.LnkÜyeOl.TabIndex = 3;
            this.LnkÜyeOl.TabStop = true;
            this.LnkÜyeOl.Text = "Üye Ol";
            this.LnkÜyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkÜyeOl_LinkClicked);
            // 
            // BtnGirişYap
            // 
            this.BtnGirişYap.Location = new System.Drawing.Point(219, 227);
            this.BtnGirişYap.Name = "BtnGirişYap";
            this.BtnGirişYap.Size = new System.Drawing.Size(152, 49);
            this.BtnGirişYap.TabIndex = 4;
            this.BtnGirişYap.Text = "Giriş Yap";
            this.BtnGirişYap.UseVisualStyleBackColor = true;
            this.BtnGirişYap.Click += new System.EventHandler(this.BtnGirişYap_Click);
            // 
            // FrmHastaGiriş
            // 
            this.AcceptButton = this.BtnGirişYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(547, 340);
            this.Controls.Add(this.BtnGirişYap);
            this.Controls.Add(this.LnkÜyeOl);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHastaGiriş";
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.TextBox txtŞifre;
        private System.Windows.Forms.LinkLabel LnkÜyeOl;
        private System.Windows.Forms.Button BtnGirişYap;
    }
}