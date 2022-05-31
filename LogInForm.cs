using System;
using System.Windows.Forms;

namespace NavchPrakt_28_LINQtoSQL
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            Program.lf = this;
            InitializeComponent();
        }

        private void buttonAdmailLogIn_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
        }
        private void buttonUserLogIn_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
        }
    }
}
