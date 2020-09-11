namespace Hastane_otomasyon_projesi
{
    partial class FrmSekreterGiriş
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
            this.BtnGirişYap.Location = new System.Drawing.Point(205, 244);
            this.BtnGirişYap.Name = "BtnGirişYap";
            this.BtnGirişYap.Size = new System.Drawing.Size(152, 49);
            this.BtnGirişYap.TabIndex = 14;
            this.BtnGirişYap.Text = "Giriş Yap";
            this.BtnGirişYap.UseVisualStyleBackColor = true;
            this.BtnGirişYap.Click += new System.EventHandler(this.BtnGirişYap_Click);
            // 
            // txtŞifre
            // 
            this.txtŞifre.Location = new System.Drawing.Point(236, 207);
            this.txtŞifre.Name = "txtŞifre";
            this.txtŞifre.Size = new System.Drawing.Size(98, 22);
            this.txtŞifre.TabIndex = 12;
            this.txtŞifre.Text = "5555";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(235, 168);
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(99, 22);
            this.MskTC.TabIndex = 11;
            this.MskTC.Text = "55555555555";
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(156, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(72, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "TC Kimlik No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 67);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sekreter Giriş Paneli";
            // 
            // FrmSekreterGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(558, 380);
            this.Controls.Add(this.BtnGirişYap);
            this.Controls.Add(this.txtŞifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSekreterGiriş";
            this.Text = "SEKRETER GİRİŞ";
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