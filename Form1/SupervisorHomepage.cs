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
    public partial class SupervisorHomepage : MetroFramework.Forms.MetroForm
    {
        public SupervisorHomepage()
        {
            InitializeComponent();
        }

        private void SupervisorHomepage_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkerInfo wi = new WorkerInfo();
            wi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductUpdate pu = new ProductUpdate();
            this.Hide();
            pu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
