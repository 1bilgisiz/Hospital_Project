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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
             SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from Tbl_Doktor", sqlbaglantisi.baglanti());
            sqlDataAdapter.Fill(dt2);
            dataGridView1.DataSource = dt2;


            //Branş Çekme

            SqlCommand sqlCommand2 = new SqlCommand("Select BransAd from Tbl_Brans", sqlbaglantisi.baglanti());
            SqlDataReader dr2 = sqlCommand2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            sqlbaglantisi.baglanti().Close();

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into Tbl_Doktor (DoktorAd, DoktorSoyad, DoktorBrans,DoktorTC, DoktorSifre) values (@p1, @p2, @p3, @p4,@p5)", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", txtad.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtsoyad.Text);
            sqlCommand.Parameters.AddWithValue("@p3", cmbbrans.Text);
            sqlCommand.Parameters.AddWithValue("@p4", maskedtcno.Text);
            sqlCommand.Parameters.AddWithValue("@p5", txtsifre.Text);

            sqlCommand.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();

            MessageBox.Show("Doktor Eklenmiştir...", "Bilgi " , MessageBoxButtons.OK , MessageBoxIcon.Information );
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedtcno.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete from Tbl_Doktor where DoktorTC=@p1", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", maskedtcno.Text);
            sqlCommand.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Kayıt Silinmiştir...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand2 = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p5 where DoktorTc=@p4", sqlbaglantisi.baglanti());
            sqlCommand2.Parameters.AddWithValue("@p1", txtad.Text);
            sqlCommand2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            sqlCommand2.Parameters.AddWithValue("@p3", cmbbrans.Text);
            sqlCommand2.Parameters.AddWithValue("@p4", maskedtcno.Text);
            sqlCommand2.Parameters.AddWithValue("@p5", txtsifre.Text);

            sqlCommand2.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();

            MessageBox.Show("Doktor Güncellendi...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
