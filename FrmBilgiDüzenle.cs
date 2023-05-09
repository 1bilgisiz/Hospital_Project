using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string tcno;
        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskdKimlikno.Text = tcno;
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Hasta where HastaTC=@p1", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", MskdKimlikno.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) { 
            txtüyead.Text= sqlDataReader[1].ToString();
                txtüyesoyad.Text= sqlDataReader[2].ToString();
                MskdTelefon.Text = sqlDataReader[4].ToString();
                txtÜyeSifre.Text = sqlDataReader[5].ToString();
                comboBox1.Text = sqlDataReader[6].ToString();
            
            }
            sqlbaglantisi.baglanti().Close();
            
        }

        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
           SqlCommand komut = new SqlCommand("Update Tbl_Hasta set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p4,HastaCinsiyet=@p5 where HastaTC=@p6", sqlbaglantisi.baglanti());

            komut.Parameters.AddWithValue("@p1", txtüyead.Text);
            komut.Parameters.AddWithValue("@p2", txtüyesoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskdTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtÜyeSifre.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.Parameters.AddWithValue("@p6", MskdKimlikno.Text);
            komut.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
