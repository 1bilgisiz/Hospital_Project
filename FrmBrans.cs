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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Tbl_Brans ", sqlbaglantisi.baglanti());
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Insert into Tbl_Brans (BransAd) values (@p1)", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", txtsoyad.Text);
            sqlCommand.ExecuteNonQuery();
                sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int  secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtsoyad.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete from Tbl_Brans where Bransid=@b1", sqlbaglantisi.baglanti());
            command.Parameters.AddWithValue("@b1", txtad.Text);
            command.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Branş Silindi...");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Brans set BransAd=@p1 where Bransid=@p2", sqlbaglantisi.baglanti());
            komut.Parameters.AddWithValue("@p1", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtad.Text);
            komut.ExecuteNonQuery();
            sqlbaglantisi.baglanti().Close();
            MessageBox.Show("Branş Güncellendi...");

        }
    }
}
