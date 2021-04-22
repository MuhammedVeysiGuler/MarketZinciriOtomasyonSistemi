using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otomasyonodev
{
    internal class cMarket
    {
        private cGenel gnl = new cGenel();  //baglanti stringim icin genel classindan nesne olusturdum

        public void getmarkets(ListView lv) //marketleri veritabanından çekip listview tooluna ekleme methodu
        {
            lv.Items.Clear(); //listview icerisini temizliyor
            SqlConnection con = new SqlConnection(gnl.conString); //sql baglantisi
            SqlCommand cmd = new SqlCommand("SELECT MarketIsmi,Adres,TemizlikUrunleriStok,GidaUrunleriStok,HaftalikIndirimUrunleriStok FROM Marketler", con); // sql sorgusu

            if (con.State == ConnectionState.Closed) //sql baglantisini kapali ise acma
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(); //sql verilerini okumak icin sqldatareader classindan bir nesne olusturdum ve sql sorgumu verdim
            int i = 0;
            while (dr.Read()) //okunacak bir sey oldugu surece listview da olusturdugum sutunlara sqldeki verileri cekiyor
            {
                lv.Items.Add(dr["MarketIsmi"].ToString());
                lv.Items[i].SubItems.Add(dr["Adres"].ToString());
                lv.Items[i].SubItems.Add(dr["TemizlikUrunleriStok"].ToString());
                lv.Items[i].SubItems.Add(dr["GidaUrunleriStok"].ToString());
                lv.Items[i].SubItems.Add(dr["HaftalikIndirimUrunleriStok"].ToString());
                i++;
            }
            dr.Close(); //baglanti ve reader nesnelerini kapatma
            con.Dispose();
            con.Close();
        }
    }
}