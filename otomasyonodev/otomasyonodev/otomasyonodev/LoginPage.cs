using System;
using System.Windows.Forms;

namespace otomasyonodev
{
    public partial class LoginPage : Form
    {
        public LoginPage()
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
            cPersoneller p = new cPersoneller();//giris yapan kisinin patron mu mudur mu oldugunu kontrol ettik
            bool result = p.personelEntryControl(password.Text, username.Text);
            bool result2 = p.patronEntryControl(password.Text, username.Text);

            if (result)
            {
                HomePage home = new HomePage();
                home.Show();
                home.calisanupdate.Visible = false;
                this.Hide();
            }
            else if (result2)
            {
                HomePage home = new HomePage();
                home.Show();
                this.Hide();
            }
        }

        private void Urun_Load(object sender, EventArgs e)
        {
        }
    }
}