using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class UpdateCalisan : Form
    {
        public UpdateCalisan()
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
            cPersoneller prs = new cPersoneller(); //sayfa acildiginda personelleri doldurmak icin cpersoneller classindan nesnemizi olusturduk
            prs.getpersonels(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            maas.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//tikladigimiz urunun istenen ozelliklerini ilgili textboxlara yazdirdik
            pozisyon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            market.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void guncelle_Click(object sender, EventArgs e)//maas biriminin eski maastan buyuk olduguna ve girilen degerin int olduguna emin olup veritabanına yazdirdik
        {
            int value;
            if (Int32.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString()) < Int32.Parse(maas.Text.ToString()) && int.TryParse(maas.Text.ToString(), out value))
            {
                cGenel gnl = new cGenel();
                SqlConnection baglanti = new SqlConnection(gnl.conString);
                string sorgu = "UPDATE Calisanlar SET Maas=@maas , Pozisyon=@pozisyon , Market=@market where IsimSoyisim=@isimsoyisim";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@isimsoyisim", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                komut.Parameters.AddWithValue("@maas", maas.Text);
                komut.Parameters.AddWithValue("@pozisyon", pozisyon.Text);
                komut.Parameters.AddWithValue("@market", market.Text);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                cPersoneller prs = new cPersoneller();
                prs.getpersonels(dataGridView1);
            }
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            if (this.isadmin.Text == "0")
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