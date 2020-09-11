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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
           
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mskTelefon.Text = dr[4].ToString();
                txtŞifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaŞifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",bgl.baglanti());
            komut5.Parameters.AddWithValue("@p1", txtAd.Text);
            komut5.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut5.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut5.Parameters.AddWithValue("@p4", txtŞifre.Text);
            komut5.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            komut5.Parameters.AddWithValue("@p6", mskTC.Text);
            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi ");

        }
        
    }
}
