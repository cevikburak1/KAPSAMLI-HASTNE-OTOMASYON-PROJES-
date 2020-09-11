using System;
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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public string TCnumara;
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCnumara;
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where  SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Branşıd,BranşAd From Tbl_Branşlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select ( DoktorAd + ' ' + DoktorSoyad) as ' ',DoktorBranş From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            SqlCommand komut2 = new SqlCommand("Select BranşAd From Tbl_Branşlar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();




        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuHastaŞikayet)values (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@p1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@p2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@p3", cmbBranş.Text);
            komutkaydet.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komutkaydet.Parameters.AddWithValue("@p5", rchŞikayet.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(mskTarih.Text + " " +"Tarihi" + " " + mskSaat.Text+ " " + "Saatine" + " " + "RANDEVU ALINDI");


          
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)


        {
            cmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBranş=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBranş.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();

            drp.Show();
        }

        private void btnBranşPaneli_Click(object sender, EventArgs e)
        {
            FrmBranş frb = new FrmBranş();
            frb.Show();

        }

        private void btnRandevuListele_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi rd = new FrmRandevuListesi();
            rd.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
          
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
