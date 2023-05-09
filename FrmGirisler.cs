using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void BtnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGrs frmHastaGrs = new FrmHastaGrs();
            frmHastaGrs.Show();
            this.Hide();
        }

        private void BtnDoktor_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm  = new FrmDoktorGiris();
            frm.Show();
            this.Hide();
        }

        private void BtnSekreter_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris sekreterGiris = new FrmSekreterGiris();
            sekreterGiris.Show();
            this.Hide();
        }
    }
}
