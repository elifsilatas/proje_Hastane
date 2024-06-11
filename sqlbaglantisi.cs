using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlbaglantisi//sqlbaglantisi, sınıfımın adı.
    {
        public SqlConnection baglanti()//baglanti, metodumun adı.
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-PV3KMDS\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            //baglan, sqlconnection sınıfından türettiğim ve benim adresimi tutan nesnemin adı.
            baglan.Open();//open, bir metod.
            return baglan;//return, geriye dönen değeri tutan kısım.
        }     
    }
}
