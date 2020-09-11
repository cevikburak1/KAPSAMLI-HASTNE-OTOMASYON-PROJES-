namespace Hastane_otomasyon_projesi
{
    partial class FrmGirişler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirişler));
            this.btnHastaGirişi = new System.Windows.Forms.Button();
            this.btnDoktorGirişi = new System.Windows.Forms.Button();
            this.btnSekreterGirişi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHastaGirişi
            // 
            this.btnHastaGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGirişi.BackgroundImage")));
            this.btnHastaGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGirişi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnHastaGirişi.Location = new System.Drawing.Point(32, 161);
            this.btnHastaGirişi.Name = "btnHastaGirişi";
            this.btnHastaGirişi.Size = new System.Drawing.Size(223, 159);
            this.btnHastaGirişi.TabIndex = 0;
            this.btnHastaGirişi.UseVisualStyleBackColor = true;
            this.btnHastaGirişi.Click += new System.EventHandler(this.btnHastaGirişi_Click);
            // 
            // btnDoktorGirişi
            // 
            this.btnDoktorGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGirişi.BackgroundImage")));
            this.btnDoktorGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGirişi.Location = new System.Drawing.Point(293, 179);
            this.btnDoktorGirişi.Name = "btnDoktorGirişi";
            this.btnDoktorGirişi.Size = new System.Drawing.Size(223, 141);
            this.btnDoktorGirişi.TabIndex = 1;
            this.btnDoktorGirişi.UseVisualStyleBackColor = true;
            this.btnDoktorGirişi.Click += new System.EventHandler(this.btnDoktorGirişi_Click);
            // 
            // btnSekreterGirişi
            // 
            this.btnSekreterGirişi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGirişi.BackgroundImage")));
            this.btnSekreterGirişi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGirişi.Location = new System.Drawing.Point(562, 179);
            this.btnSekreterGirişi.Name = "btnSekreterGirişi";
            this.btnSekreterGirişi.Size = new System.Drawing.Size(223, 141);
            this.btnSekreterGirişi.TabIndex = 2;
            this.btnSekreterGirişi.UseVisualStyleBackColor = true;
            this.btnSekreterGirişi.Click += new System.EventHandler(this.btnSekreterGirişi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(785, 99);
            this.label4.TabIndex = 6;
            this.label4.Text = "BURAK HASTANELERİ";
            // 
            // FrmGirişler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(876, 392);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGirişi);
            this.Controls.Add(this.btnDoktorGirişi);
            this.Controls.Add(this.btnHastaGirişi);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGirişler";
            this.Text = "BURAK HASTANELERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGirişi;
        private System.Windows.Forms.Button btnDoktorGirişi;
        private System.Windows.Forms.Button btnSekreterGirişi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

