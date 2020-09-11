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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
           
       
        
            mskTC.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBranş.Text = dr[3].ToString();
                txtŞifre.Text = dr[5].ToString();
               
               
            }
            bgl.baglanti().Close();
        }

       

        private void btnGüncelle_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBranş=@p3,DoktorŞifre=@p4 where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBranş.Text);
            komut.Parameters.AddWithValue("@p4", txtŞifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTC.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi ");
        }
    }
}
