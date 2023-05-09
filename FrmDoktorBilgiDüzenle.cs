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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();
        public String TCNO;


        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskdoktorKimlikno.Text = TCNO;

            SqlCommand sqlCommand = new SqlCommand("Select * From Tbl_Doktor where DoktorTC=@p1", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", MskdoktorKimlikno.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                txtdoktorad.Text = reader[1].ToString();
                txtdoktorsoyad.Text = reader[2].ToString();
                cmbbrans.Text = reader[3].ToString();
                txtdoktorsifre.Text = reader[5].ToString();
            }

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5 ", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", txtdoktorad.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtdoktorsoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cmbbrans.Text);
            sqlCommand.Parameters.AddWithValue("@p4", txtdoktorsifre.Text);
            sqlCommand.Parameters.AddWithValue("@p5", MskdoktorKimlikno.Text);
            sqlCommand.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
