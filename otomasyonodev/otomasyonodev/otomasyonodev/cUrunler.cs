using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otomasyonodev
{
    internal class cUrunler
    {
        private cGenel gnl = new cGenel(); //baglanti stringim icin genel classindan nesne olusturdu
        public void geturuns(ListView lv)//urunleri listviewa yazma metodu
        {
            lv.Items.Clear(); //listview icerisini temizliyor
            SqlConnection con = new SqlConnection(gnl.conString); //sql baglantisi
            SqlCommand cmd = new SqlCommand("SELECT UrunAdi,IndirimOrani,IndirimTarihi,SonIndirimMiktari,SonIndirimTarihi FROM Urunler", con);//sql sorgusu

            if (con.State == ConnectionState.Closed) //sql baglantisini kapali ise acma
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(); //sql verilerini okumak icin sqldatareader classindan bir nesne olusturdum ve sql sorgumu verdim
            int i = 0;
            while (dr.Read()) //okunacak bir sey oldugu surece listview da olusturdugum sutunlara sqldeki verileri cekiyor
            {
                lv.Items.Add(dr["UrunAdi"].ToString());
                lv.Items[i].SubItems.Add(dr["IndirimOrani"].ToString());
                lv.Items[i].SubItems.Add(dr["IndirimTarihi"].ToString());
                lv.Items[i].SubItems.Add(dr["SonIndirimMiktari"].ToString());
                lv.Items[i].SubItems.Add(dr["SonIndirimTarihi"].ToString());
                i++;
            }
            dr.Close(); //baglanti ve reader nesnelerini kapatma
            con.Dispose();
            con.Close();
        }

        public void geturuns(DataGridView lv) //urunleri listview yerine datagridviewe yazdirma
        {
            SqlConnection con = new SqlConnection(gnl.conString); //sql baglantisi
            SqlDataAdapter cmd = new SqlDataAdapter("SELECT UrunAdi,IndirimOrani,IndirimTarihi,SonIndirimMiktari,SonIndirimTarihi FROM Urunler", con);// sql sorgusu
            if (con.State == ConnectionState.Closed)//sql baglantisini kapali ise acma
            {
                con.Open();
            }
            DataTable tablo = new DataTable(); //verilerin bulunacagi tablo nesnesini olusturdum
            cmd.Fill(tablo);//sql sorgusundan gelen verileri tabloya yazdirma
            lv.DataSource = tablo;//tablodakileri datagridview icine atma
            con.Close();//sql baglantisini kapatma
        }
    }
}