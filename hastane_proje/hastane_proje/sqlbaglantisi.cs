using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane_proje
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=hastaneproje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
