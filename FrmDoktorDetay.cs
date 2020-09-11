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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
            
        {
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();

            //RANDEVULAR
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

           



        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCno = lblTC.Text;
            fr.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            rchŞikayet.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();

        }

        private void btnÇıkış_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
