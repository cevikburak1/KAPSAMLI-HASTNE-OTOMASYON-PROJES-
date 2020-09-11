﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_otomasyon_projesi
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
       
    private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            SqlCommand komut2 = new SqlCommand("Select BranşAd From Tbl_Branşlar", bgl.baglanti());
            SqlDataReader dr4 = komut2.ExecuteReader();
            while (dr4.Read())
            {
                cmbBranş.Items.Add(dr4[0]);
            }
            bgl.baglanti().Close();



        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorBranş,DoktorTC,DoktorŞifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",cmbBranş.Text );
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtŞifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi ");



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtSoyad.Text= dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            cmbBranş.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            txtŞifre.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" Kayıt Başarı İle Silindi ");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBranş=@p3,DoktorŞifre=@p5 where DoktorTC = @p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBranş.Text);
            komut.Parameters.AddWithValue("@p4", mskTC.Text);
            komut.Parameters.AddWithValue("@p5", txtŞifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi ");
        }
    }
}
