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
    public partial class FrmHastaGrs : Form
    {
        public FrmHastaGrs()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmÜyeKayit frmÜyeKayit =   new FrmÜyeKayit();
            frmÜyeKayit.Show();
            this.Hide();

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From  Tbl_Hasta where HastaTC=@p1 and HastaSifre=@p2", sqlbaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", MskdNo.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();
                frmHastaDetay.tc = MskdNo.Text;
                frmHastaDetay.Show();   
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre !!!");

            }

            sqlbaglantisi.baglanti().Close();

        }
    }
}
