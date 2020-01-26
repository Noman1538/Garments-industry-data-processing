using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using Information;
using Operations;

namespace Form1
{
    public partial class ManagerLog : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();
        public ManagerLog()
        {
            InitializeComponent();
        }

        private void ManagerLog_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerHomepage mh = new OwnerHomepage();
            mh.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            dt = opr.ProductLog2(info);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt = opr.TeamLog(info);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt = opr.DProductLog2(info);
            dt = opr.DTeamLog(info);
            dt = opr.DSuperLog(info);
            dt = opr.ProductLog2(info);
            dataGridView1.DataSource = dt;
        }

        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OwnerHomepage oh = new OwnerHomepage();
            oh.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = opr.SuperLog(info);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OwnerHomepage oh = new OwnerHomepage();
            oh.Show();
            this.Hide();
        }
    }
}
