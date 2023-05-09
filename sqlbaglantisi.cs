using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace HastaneProjesi
{
    class sqlbaglantisi
    {

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=1BILGISIZ\\SQLEXPRESS01;Initial Catalog=HastaneProject;Integrated Security=True");
            baglan.Open();
            return baglan;

        }


    }
}
