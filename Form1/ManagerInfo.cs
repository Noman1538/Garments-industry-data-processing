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
using Operations;
using Information;

namespace Form1
{
    public partial class ManagerInfo : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();

        public ManagerInfo()
        {
            InitializeComponent();
        }

        public void refreshing(DataGridView datagridview)
        {
            NameTextBox.Text = "";
            RolecomboBox.Text = "";
            PasswordTextBox.Text = "";
            AddressTextBox.Text = "";
            MobileTextBox.Text = "";
            TeamIdtextBox.Text = "";
            UsernametextBox.Text = "";
            dt = opr.viewManager(info);
            ManagerDataView.DataSource = dt;
        }

        private void OwnerInfo_Load(object sender, EventArgs e)
        {

            refreshing(ManagerDataView);
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

        private void ManagerDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ManagerDataView.Rows[e.RowIndex];
                UsernametextBox.Text = row.Cells[0].Value.ToString();
                NameTextBox.Text = row.Cells[1].Value.ToString();
                RolecomboBox.Text = row.Cells[2].Value.ToString();
                PasswordTextBox.Text = row.Cells[3].Value.ToString();
                AddressTextBox.Text = row.Cells[4].Value.ToString();
                MobileTextBox.Text = row.Cells[5].Value.ToString();
                TeamIdtextBox.Text = row.Cells[6].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            refreshing(ManagerDataView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.name = NameTextBox.Text;
            info.username = UsernametextBox.Text;
            info.role = RolecomboBox.SelectedItem.ToString();
            info.password = PasswordTextBox.Text;
            info.address = AddressTextBox.Text;
            info.mobile = MobileTextBox.Text;
            info.team_id = TeamIdtextBox.Text;
            dt = opr.NewUser(info);
            refreshing(ManagerDataView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info.username = UsernametextBox.Text;
            dt = opr.DeleteUser(info);
            MetroFramework.MetroMessageBox.Show(this, "Data Deleted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshing(ManagerDataView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            info.name = NameTextBox.Text;
            info.password = PasswordTextBox.Text;
            info.role = RolecomboBox.SelectedItem.ToString();
            info.password = PasswordTextBox.Text;
            info.address = AddressTextBox.Text;
            info.mobile = MobileTextBox.Text;
            info.username = TeamIdtextBox.Text;
            info.team_id = TeamIdtextBox.Text;

            dt = opr.UpdateUser(info);
            MetroFramework.MetroMessageBox.Show(this, "Data Updated", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshing(ManagerDataView);
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
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OwnerHomepage oh = new OwnerHomepage();
            oh.Show();
            this.Hide();
        }
    }
}
