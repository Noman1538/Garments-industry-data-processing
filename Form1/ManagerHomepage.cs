using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class ManagerHomepage : MetroFramework.Forms.MetroForm
    {
        public ManagerHomepage()
        {
            InitializeComponent();
        }

        private void ManagerHomepage_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervisorInfo ei = new SupervisorInfo();
            ei.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductInfo pi = new ProductInfo();
            pi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeamInfo ti = new TeamInfo();
            ti.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervisorLog sl = new SupervisorLog();
            sl.Show();
            this.Hide();
        }
    }
}
