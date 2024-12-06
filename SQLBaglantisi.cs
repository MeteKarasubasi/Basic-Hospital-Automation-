using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneYönetimOtomasyonu
{
    internal class SQLBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=HastaneOtomasyonu;Integrated Security=True");
        baglan.Open();
            return baglan;
        }
    }
}
