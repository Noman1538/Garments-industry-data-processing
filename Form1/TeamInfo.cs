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
    public partial class TeamInfo : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();
        public TeamInfo()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                TeamIDtextBox.Text = row.Cells[0].Value.ToString();
                NoOfEmptextBox.Text = row.Cells[1].Value.ToString();
                StartingdateTimePicker.Value = Convert.ToDateTime(row.Cells[2].Value);
                ClosingdateTimePicker.Value = Convert.ToDateTime(row.Cells[3].Value);
                ProducttextBox.Text = row.Cells[4].Value.ToString();
            }
        }



        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerHomepage mh = new ManagerHomepage();
            mh.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        public void refreshing(DataGridView datagridview)
        {
            TeamIDtextBox.Text = "";
            NoOfEmptextBox.Text = "";
            //StartingdateTimePicker.Value = Convert.ToDateTime("");
            //   ClosingdateTimePicker.Value = Convert.ToDateTime("");
            ProducttextBox.Text = "";
            dt = opr.viewTeam(info);
           dataGridView1.DataSource = dt;
        }

        private void TeamInfo_Load(object sender, EventArgs e)
        {
            refreshing(dataGridView1);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            info.team_id = TeamIDtextBox.Text;
            info.noofemp = Convert.ToInt32(NoOfEmptextBox.Text);
            info.startingdate = StartingdateTimePicker.Value;
            info.closingdate = ClosingdateTimePicker.Value;
            info.product_id = Convert.ToInt32(ProducttextBox.Text);
            dt = opr.NewTeam(info);
            refreshing(dataGridView1);
        }

        private void New_Click(object sender, EventArgs e)
        {



            refreshing(dataGridView1);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            info.team_id = TeamIDtextBox.Text;
            info.noofemp = Convert.ToInt32(NoOfEmptextBox.Text);
            info.startingdate = StartingdateTimePicker.Value;
            info.closingdate = ClosingdateTimePicker.Value;
            info.product_id = Convert.ToInt32(ProducttextBox.Text);
            dt = opr.UpdateTeam(info);

            refreshing(dataGridView1);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            info.team_id = TeamIDtextBox.Text;
            dt = opr.DeleteTeam(info);
            refreshing(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerHomepage mh = new ManagerHomepage();
            mh.Show();
            this.Hide();
        }
    }
}
