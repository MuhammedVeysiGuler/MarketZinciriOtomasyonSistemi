using System;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Calisan_Load(object sender, EventArgs e)//sayfa açılınca çalışan kodlar
        {
            cUrunler urun = new cUrunler();//ürünlerin içerisini doldurmak için nesnemizi oluşturup metodu çalıştırdık
            urun.geturuns(urunlerr);
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