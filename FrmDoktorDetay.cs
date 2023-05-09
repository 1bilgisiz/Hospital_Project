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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();

        public String TC;


        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TC;

            //Doktor AD-Soyad

            SqlCommand cmd = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor where DoktorTC=@p1 ", sqlbaglantisi.baglanti());
            cmd.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader adapter = cmd.ExecuteReader();
            while (adapter.Read())
            {
                lbladsoyad.Text = adapter[0] + " " + adapter[1];
            }
            sqlbaglantisi.baglanti().Close();


            //Randevular 
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lbladsoyad.Text + "'", sqlbaglantisi.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frmDoktorBilgiDüzenle = new FrmDoktorBilgiDüzenle();
            frmDoktorBilgiDüzenle.TCNO = lbltc.Text;
            frmDoktorBilgiDüzenle.Show();

        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular    frmDuyurular = new FrmDuyurular();  
            frmDuyurular.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text= dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
