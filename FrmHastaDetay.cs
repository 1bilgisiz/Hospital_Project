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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        public string tc;

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //Ad-Soyad Çekme
            lbltc.Text = tc;
            SqlCommand sqlCommand = new SqlCommand("Select HastaAd, HastaSoyad From Tbl_Hasta Where HastaTC=@p1", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + "   " + dr[1];

            }
            sqlbaglantisi.baglanti().Close();


            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc=" + tc, sqlbaglantisi.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Branş Çekme

            SqlCommand sqlCommand2 = new SqlCommand("Select BransAd from Tbl_Brans", sqlbaglantisi.baglanti());
            SqlDataReader dr2 = sqlCommand2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            sqlbaglantisi.baglanti().Close();


        }



        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand sqlCommand3 = new SqlCommand("Select DoktorAd, DoktorSoyad from Tbl_Doktor where DoktorBrans=@p1", sqlbaglantisi.baglanti());
            sqlCommand3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dataReader = sqlCommand3.ExecuteReader();
            while (dataReader.Read())
            {
                cmbdoktor.Items.Add(dataReader[0] + " " + dataReader[1]);
            }


            sqlbaglantisi.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter command = new SqlDataAdapter("Select * from Tbl_Randevular  where RandevuBrans='" + cmbbrans.Text + "'" + " and RandevuDoktor='" + cmbdoktor.Text + "'", sqlbaglantisi.baglanti());
            command.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle frmBilgiDüzenle = new FrmBilgiDüzenle();
            frmBilgiDüzenle.tcno = lbltc.Text;
            frmBilgiDüzenle.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtboxid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1, HastaTc=@p1, HastaSikayet=@p2  where Randevuid=@p3 ", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",lbltc.Text);
            sqlCommand.Parameters.AddWithValue("@p2", RichSikayet.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtboxid.Text);
            sqlCommand.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Randevunuz Alındı ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
