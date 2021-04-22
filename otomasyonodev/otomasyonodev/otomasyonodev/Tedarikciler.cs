using System;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class Tedarikciler : Form
    {
        public Tedarikciler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Calisan_Load(object sender, EventArgs e)
        {
            cTedarikciler urun = new cTedarikciler();
            urun.gettedarikciler(tedarikcilerr);
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