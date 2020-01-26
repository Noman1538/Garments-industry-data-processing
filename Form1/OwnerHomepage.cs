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
    public partial class OwnerHomepage : MetroFramework.Forms.MetroForm
    {
        public OwnerHomepage()
        {
            InitializeComponent();
        }

        private void OwnerHomepage_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OwnerInfo wi = new OwnerInfo();
            wi.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo();
            mi.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerLog ml = new ManagerLog();
            ml.Show();
            this.Hide();
        }
    }
}
