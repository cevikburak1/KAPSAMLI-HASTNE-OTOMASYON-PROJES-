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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirişYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Sekreter where SekreterTC=@p1 and SekreterŞifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", txtŞifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {

                SekreterDetay frs = new SekreterDetay();
                frs.TCnumara = MskTC.Text;
                frs.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ LÜTFEN TEKRAR DENEYİN");
            }
            bgl.baglanti().Close();
        }
    }
}
