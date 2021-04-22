using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class UpdateUrun : Form
    {
        public UpdateUrun()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
        }

        private void Urun_Load(object sender, EventArgs e)
        {
            cUrunler prs = new cUrunler();// sayfa acildiginda cUrunler classindaki geturuns methodu ile urunleri listeliyoruz
            prs.geturuns(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            maas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(maas.Text.ToString(), out value))//guncelle dedigimizde maasi sadece yukseltecek sekilde kotrol edip veritabanýný guncelliyoruz
            {
                cGenel gnl = new cGenel();
                SqlConnection baglanti = new SqlConnection(gnl.conString);
                string sorgu = "UPDATE Urunler SET IndirimOrani=@indirim , IndirimTarihi=@tarih , SonIndirimMiktari=@eskiindirim, SonIndirimTarihi=@eskitarih where UrunAdi=@urunadi";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@eskitarih", dataGridView1.CurrentRow.Cells[2].Value);
                komut.Parameters.AddWithValue("@eskiindirim", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                komut.Parameters.AddWithValue("@indirim", maas.Text);
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                cUrunler prs = new cUrunler();
                prs.geturuns(dataGridView1);
            }
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            if (this.isadmin.Text == "0")//anasayfa butonuna tikladiginda admin olup olmadigina gore calisan bilgilerini degistirme butonunu gizleyip homepage formuna gonderiyor
            {
                hm.calisanupdate.Visible = false;
                hm.Show();
                this.Hide();
            }
            else
            {
                hm.Show();
                this.Hide();
            }
        }
    }
}