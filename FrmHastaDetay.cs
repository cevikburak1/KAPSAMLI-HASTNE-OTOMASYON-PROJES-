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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string tc;
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        { //AD SOYAD ÇEKME
            lblTC.Text=tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where  HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text=dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //RANDEVU GEÇMİŞİ
            

            //BRANŞLARI ÇEKME
            SqlCommand komut2 = new SqlCommand("Select BranşAd From Tbl_Branşlar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
                
        }
        //SEÇİLEN BRANŞA GÖRE DOKTOR SEÇME
        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBranş=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBranş.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cmbBranş.Text + "'" + " and RandevuDoktor='" + cmbDoktor.Text+"'and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle frm = new FrmBilgiDüzenle();
            frm.TCno = lblTC.Text;
            frm.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,RandevuHastaTC=@p1,RandevuHastaŞikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", rchŞikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
