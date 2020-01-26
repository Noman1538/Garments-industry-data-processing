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
    public partial class WorkerInfo : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();

        public WorkerInfo()
        {
            InitializeComponent();
            //idtextBox.Visible = false;
        }

        private void homepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupervisorHomepage sh = new SupervisorHomepage();
            sh.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }

        private void WorkerInfo_Load(object sender, EventArgs e)
        {
            refreshing(WorkersGridView);

        }

        public void refreshing(DataGridView datagridview) {
            nametextBox.Text = "";
            addresstextBox.Text = "";
            mobiletextBox.Text = "";
            // idtextBox.Text = row.Cells[3].Value.ToString();
            positioncomboBox.Text = "";
            performancecomboBox.Text = "";
            dt = opr.viewWorker(info);
            WorkersGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkerInfo wi = new WorkerInfo();
            wi.Show();
            this.Hide();
        }

        private void WorkersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.WorkersGridView.Rows[e.RowIndex];
                nametextBox.Text = row.Cells[0].Value.ToString();
                addresstextBox.Text = row.Cells[1].Value.ToString();
                mobiletextBox.Text = row.Cells[2].Value.ToString();
               // idtextBox.Text = row.Cells[3].Value.ToString();
                positioncomboBox.Text = row.Cells[3].Value.ToString();
                performancecomboBox.Text = row.Cells[4].Value.ToString();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            info.name = nametextBox.Text;
            info.address = addresstextBox.Text;
            info.mobile = mobiletextBox.Text;
            info.position = positioncomboBox.SelectedItem.ToString();
            info.performance = performancecomboBox.SelectedItem.ToString();
            dt = opr.NewWorker(info);

            refreshing(WorkersGridView);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            info.name = nametextBox.Text;
            info.address = addresstextBox.Text;
            info.mobile = mobiletextBox.Text;
            info.position = positioncomboBox.SelectedItem.ToString();
            info.performance = performancecomboBox.SelectedItem.ToString();
          //  info.id = Convert.ToInt32(idtextBox.Text);
            dt = opr.UpdateWorker(info);

            refreshing(WorkersGridView);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //     info.id = Convert.ToInt32(idtextBox.Text);
            info.name = nametextBox.Text;
            dt = opr.DeleteWorker(info);
            refreshing(WorkersGridView);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervisorHomepage sh = new SupervisorHomepage();
            sh.Show();
            this.Hide();
        }
    }
}
