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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();  

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select * from Tbl_Doktor where DoktorTC=@p1 and DoktorSifre=@p2", sqlbaglantisi.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", MskdNo.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader adapter = sqlCommand.ExecuteReader();
            if (adapter.Read() ){

                FrmDoktorDetay frmDoktorDetay = new FrmDoktorDetay();
                frmDoktorDetay.TC = MskdNo.Text;
                frmDoktorDetay.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("Hatalı Şifre veye Kullanıcı Adı !!!", "Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
