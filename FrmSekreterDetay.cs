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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string tcnumara;
        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();


        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcnumara;

            //Ad-Soyad 

            SqlCommand sqlCommand = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lbladsoyad.Text = sqlDataReader[0].ToString();
            }
            sqlbaglantisi.baglanti().Close();


            //Branşları gösterme
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select BransAd from Tbl_Brans", sqlbaglantisi.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

            //Doktorları listeye aktarma
            DataTable dt2= new DataTable();
            sqlDataAdapter = new SqlDataAdapter("select(DoktorAd + '  ' + DoktorSoyad) as Doktorlar, DoktorBrans from Tbl_Doktor", sqlbaglantisi.baglanti());
            sqlDataAdapter.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı comboboxa aktarma
            SqlCommand komut3 = new SqlCommand("Select BransAd From Tbl_Brans", sqlbaglantisi.baglanti());
            SqlDataReader sqlDataReader1 = komut3.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                cmbbrans.Items.Add(sqlDataReader1[0].ToString());
            }
            sqlbaglantisi.baglanti() .Close();


        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1, @r2, @r3, @r4) ", sqlbaglantisi.baglanti());
            komut.Parameters.AddWithValue("@r1", maskedtarih.Text);
            komut.Parameters.AddWithValue("@r2", maskedsaat.Text);
            komut.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komut.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturulmuştur...");

        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand sqlCommand = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                cmbdoktor.Items.Add(reader[0] + " " + reader[1]);
            }
            sqlbaglantisi.baglanti().Close();

        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@d1", RichDuyuru.Text);
            sqlCommand.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturulmuştur...");

        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmDoktorPaneli = new FrmDoktorPaneli();    
            frmDoktorPaneli.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBrans frmBrans   = new FrmBrans();
            frmBrans.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
           FrmRandevuListesi frmRandevuListesi = new FrmRandevuListesi();
            frmRandevuListesi.Show();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frmDuyurular = new FrmDuyurular();
            frmDuyurular.Show();
        }
    }
}
