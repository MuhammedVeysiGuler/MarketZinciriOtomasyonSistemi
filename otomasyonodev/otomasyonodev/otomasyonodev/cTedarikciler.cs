using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otomasyonodev
{
    internal class cTedarikciler
    {

        private cGenel gnl = new cGenel(); //baglanti stringim icin genel classindan nesne olusturdum

        public void gettedarikciler(ListView lv) //tedarikci bilgilerini veritabanından ceken method
        {
            lv.Items.Clear();//listview içerisini temizliyoruz
            SqlConnection con = new SqlConnection(gnl.conString); //sql baglantisi
            SqlCommand cmd = new SqlCommand("SELECT TedarikciAdi,Adres FROM Tedarikciler", con);// sql sorgusu

            if (con.State == ConnectionState.Closed) //sql baglantisini kapali ise acma
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(); //sql verilerini okumak icin sqldatareader classindan bir nesne olusturdum ve sql sorgumu verdim
            int i = 0;
            while (dr.Read()) //okunacak bir sey oldugu surece listview da olusturdugum sutunlara sqldeki verileri cekiyor
            {
                lv.Items.Add(dr["TedarikciAdi"].ToString());
                lv.Items[i].SubItems.Add(dr["Adres"].ToString());
                i++;
            }
            dr.Close();//baglanti ve reader nesnelerini kapatma
            con.Dispose();
            con.Close();
        }
    }
}