using System;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Calisan_Load(object sender, EventArgs e) //calisanlar sayfasi acildiginda personeller classindaki getpersonels methodu ile personelleri listeliyoruz
        {
            cPersoneller prs = new cPersoneller();
            prs.getpersonels(calisanlar);
        }

        private void homebutton_Click(object sender, EventArgs e) //anasayfa butonuna tikladiginda admin olup olmadigina gore calisan bilgilerini degistirme butonunu gizleyip homepage formuna gonderiyor
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