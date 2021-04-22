using System;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void calisanupdate_Click(object sender, EventArgs e)
        {
            UpdateCalisan upt = new UpdateCalisan();
            upt.Show();
            this.Hide();
        }

        private void gototedarikci_Click(object sender, EventArgs e)//token sistemini burada kullanmadigimdan gittigimiz sayfadaki bir textboxa kisinin yetkisine gore sayi yazdirdim boylece geri geldiginde de kisinin bilgisini bilebilecegim
        {
            Tedarikciler tdrk = new Tedarikciler();
            if (this.calisanupdate.Visible == false)
            {
                tdrk.isadmin.Text = "0";
            }
            else
            {
                tdrk.isadmin.Text = "1";
            }
            tdrk.Show();
            this.Hide();
        }

        private void gotourun_Click(object sender, EventArgs e)
        {
            Urunler urun = new Urunler();
            if (this.calisanupdate.Visible == false)
            {
                urun.isadmin.Text = "0";
            }
            else
            {
                urun.isadmin.Text = "1";
            }
            urun.Show();
            this.Hide();
        }

        private void gotomarket_Click(object sender, EventArgs e)
        {
            Market mrkt = new Market();
            if (this.calisanupdate.Visible == false)
            {
                mrkt.isadmin.Text = "0";
            }
            else
            {
                mrkt.isadmin.Text = "1";
            }
            mrkt.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Market_Load(object sender, EventArgs e)
        {
        }

        private void indirimyap_Click(object sender, EventArgs e)
        {
            UpdateUrun urn = new UpdateUrun();
            if (this.calisanupdate.Visible == false)
            {
                urn.isadmin.Text = "0";
            }
            else
            {
                urn.isadmin.Text = "1";
            }
            urn.Show();
            this.Hide();
        }

        private void cikisyap_Click(object sender, EventArgs e)
        {
            LoginPage urn = new LoginPage();
            urn.Show();
            this.Hide();
        }

        private void kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gotocalisan_Click(object sender, EventArgs e)
        {
            Calisan cls = new Calisan();
            if (this.calisanupdate.Visible==false)
            {
                cls.isadmin.Text = "0";
            }
            else
            {
                cls.isadmin.Text = "1";
            }
            cls.Show();
            this.Hide();
        }
    }
}