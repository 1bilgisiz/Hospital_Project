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
    public partial class FrmÜyeKayit : Form
    {
        public FrmÜyeKayit()
        {
            InitializeComponent();
        }
         
        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();


        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hasta(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", sqlbaglantisi.baglanti());

            komut.Parameters.AddWithValue("@p1", txtüyead.Text);
            komut.Parameters.AddWithValue("@p2", txtüyesoyad.Text);
            komut.Parameters.AddWithValue("@p3", MskdKimlikno.Text);
            komut.Parameters.AddWithValue("@p4", MskdTelefon.Text);
            komut.Parameters.AddWithValue("@p5", txtÜyeSifre.Text);
            komut.Parameters.AddWithValue("@p6", comboBox1.Text);
            komut.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Kaydınız gerçekleşmiştir. Şifreniz : " + txtÜyeSifre.Text, "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }
    }
}
