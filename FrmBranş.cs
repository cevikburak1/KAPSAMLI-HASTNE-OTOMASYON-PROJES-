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
    public partial class FrmBranş : Form
    {
        public FrmBranş()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmBranş_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branşlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branşlar(BranşAd) values (@p1)", bgl.baglanti());
           
            komut.Parameters.AddWithValue("@p1", txtBranşAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi ");

        }

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBranşıd.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtBranşAd.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branşlar where Branşıd=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBranşıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show(" Branş Başarı İle Silindi ");
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update  Tbl_Branşlar set BranşAd=@p1 where Branşıd = @p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBranşAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBranşıd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi ");

        }
    }
}
