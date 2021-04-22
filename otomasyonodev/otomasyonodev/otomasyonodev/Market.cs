using System;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class Market : Form
    {
        public Market()
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
            cMarket prs = new cMarket();
            prs.getmarkets(markets);
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