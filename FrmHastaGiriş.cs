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
    public partial class FrmHastaGiriş : Form
    {
        public FrmHastaGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void LnkÜyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt frm = new FrmHastaKayıt();
            frm.Show();
           

        }

        private void BtnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1 and HastaŞifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtŞifre.Text);
           SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = MskTC.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ LÜTFEN TEKRAR DENEYİN");
            }
            bgl.baglanti().Close();

        }

        private void FrmHastaGiriş_Load(object sender, EventArgs e)
        {

        }
    }
}
