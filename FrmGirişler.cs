using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_otomasyon_projesi
{
    public partial class FrmGirişler : Form
    {
        public FrmGirişler()
        {
            InitializeComponent();
        }

        private void btnHastaGirişi_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş fr = new FrmHastaGiriş();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGirişi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş frm = new FrmDoktorGiriş();
            frm.Show();
            this.Hide();
        }

        private void btnSekreterGirişi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş frm = new FrmSekreterGiriş();
            frm.Show();
            this.Hide();

        }
    }
}
