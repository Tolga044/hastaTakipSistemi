using System.Data.SqlClient;

namespace hastaTakipSistemi
{
    internal class sqlbaglanti
    {
        string adres = "Data Source= DESKTOP-HO4AB20\\SQLEXPRESS02;Initial Catalog = db_HastaneYonetim; Integrated Security = True; Encrypt=False";

        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(adres);
            baglan.Open();
            return baglan;
        }
    }
}
