using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otomasyonodev
{
    internal class cPersoneller
    {
        private cGenel gnl = new cGenel(); //baglanti stringim icin genel classindan nesne olusturdum

        public bool personelEntryControl(string pass, string username) //giris yapan kisinin mudur olup olmadigini kontrol etme
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString); //sql baglantisi
            SqlCommand cmd = new SqlCommand("Select * from Calisanlar where KullaniciAdi=@username and Sifre=@pass and MudurMu=1", con);// sql sorgusu
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;//giris yapilan bilgiler ile veritabanindakileri karsilastirma
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

            try
            {
                if (con.State == ConnectionState.Closed) //sql baglantisini kapali ise acma
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteScalar()); //sonuc eslesiyor ise true donduruyor degilse basta tanimlandigi gibi false kaliyor
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);//herhangi bir hata gelirse gorebilmek icin exception handling
                throw;
            }

            return result;
        }

        public bool patronEntryControl(string pass, string username)//ustteki method gibi fakat patron olup olmadigini kontrol ediyor
        {
            bool result = false;

            SqlConnection con = new SqlConnection(gnl.conString);
            SqlCommand cmd = new SqlCommand("Select * from Calisanlar where KullaniciAdi=@username and Sifre=@pass and MudurMu=2", con);
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

            try
            {
                if (con.State == ConnectionState.Closed) //sql baglantisini kapali ise acma
                {
                    con.Open();
                }

                result = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

            return result;
        }

        public void getpersonels(ListView lv) //marketleri veritabanından çekip listview tooluna ekleme methodu
        {
            lv.Items.Clear(); //listview icerisini temizliyor
            SqlConnection con = new SqlConnection(gnl.conString);//sql baglantisi
            SqlCommand cmd = new SqlCommand("Select IsimSoyisim,Maas,IseBasladigiTarih,Pozisyon,Adres,YillikIzin,HaftalikIzin,Market from Calisanlar", con); // sql sorgusu

            if (con.State == ConnectionState.Closed) //sql baglantisini kapali ise acma
            {
                con.Open();
            }

            SqlDataReader dr = cmd.ExecuteReader(); //sql verilerini okumak icin sqldatareader classindan bir nesne olusturdum ve sql sorgumu verdim
            int i = 0;
            while (dr.Read()) //okunacak bir sey oldugu surece listview da olusturdugum sutunlara sqldeki verileri cekiyor
            {
                lv.Items.Add(dr["IsimSoyisim"].ToString());
                lv.Items[i].SubItems.Add(dr["Maas"].ToString());
                DateTime myDate = DateTime.ParseExact(dr["IseBasladigiTarih"].ToString(), "dd.MM.yyyy HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture);
                int a = (DateTime.Now - myDate).Days;
                lv.Items[i].SubItems.Add(a.ToString());
                lv.Items[i].SubItems.Add(dr["Pozisyon"].ToString());
                lv.Items[i].SubItems.Add(dr["Adres"].ToString());
                lv.Items[i].SubItems.Add(dr["YillikIzin"].ToString());
                lv.Items[i].SubItems.Add(dr["HaftalikIzin"].ToString());
                lv.Items[i].SubItems.Add(dr["Market"].ToString());
                i++;
            }
            dr.Close(); //baglanti ve reader nesnelerini kapatma
            con.Dispose();
            con.Close();
        }

        public void getpersonels(DataGridView lv) //calisanlari listview yerine datagridviewe yazdirma
        {
            SqlConnection con = new SqlConnection(gnl.conString);//sql baglantisi
            SqlDataAdapter cmd = new SqlDataAdapter("Select IsimSoyisim,Maas,IseBasladigiTarih,Pozisyon,Adres,YillikIzin,HaftalikIzin,Market from Calisanlar", con);// sql sorgusu
            if (con.State == ConnectionState.Closed)//sql baglantisini kapali ise acma
            {
                con.Open();
            }
            DataTable tablo = new DataTable(); //verilerin bulunacagi tablo nesnesini olusturdum
            cmd.Fill(tablo); //sql sorgusundan gelen verileri tabloya yazdirma
            lv.DataSource = tablo; //tablodakileri datagridview icine atma
            con.Close();//sql baglantisini kapatma
        }
    }
}