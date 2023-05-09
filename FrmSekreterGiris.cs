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


namespace HastaneProjesi
{
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.Add("@p1", MskdNosekreter.Text);
            sqlCommand.Parameters.Add("@p2", txtsifresekreter.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {

                FrmSekreterDetay frmSekreterDetay = new FrmSekreterDetay();
                frmSekreterDetay.tcnumara = MskdNosekreter.Text;
                frmSekreterDetay.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC vey Şifre !!!");

            }
            sqlbaglantisi.baglanti().Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
