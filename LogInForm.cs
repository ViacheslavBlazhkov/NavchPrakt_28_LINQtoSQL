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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
