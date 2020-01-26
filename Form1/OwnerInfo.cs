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
    public partial class OwnerInfo : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();

        public void refreshing(DataGridView datagridview)
        {
            NameTextBox.Text = "";
            RolecomboBox.Text = "";
            PasswordTextBox.Text = "";
            AddressTextBox.Text = "";
            MobileTextBox.Text = "";
            TeamIdtextBox.Text = "";
            UsernametextBox.Text = "";
            dt = opr.viewOwner(info);
            OwnerDataView.DataSource = dt;
        }

        public OwnerInfo()
        {
            InitializeComponent();
        }

        private void OwnerInfo_Load(object sender, EventArgs e)
        {
            refreshing(OwnerDataView);
        }

        private void OwnerDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.OwnerDataView.Rows[e.RowIndex];
                UsernametextBox.Text = row.Cells[0].Value.ToString();
                NameTextBox.Text = row.Cells[1].Value.ToString();
                RolecomboBox.Text = row.Cells[2].Value.ToString();
                PasswordTextBox.Text = row.Cells[3].Value.ToString();
                AddressTextBox.Text = row.Cells[4].Value.ToString();
                MobileTextBox.Text = row.Cells[5].Value.ToString();
                TeamIdtextBox.Text = row.Cells[6].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            info.name = NameTextBox.Text;
            info.password = PasswordTextBox.Text;
            info.role = RolecomboBox.SelectedItem.ToString();
            info.password = PasswordTextBox.Text;
            info.address = AddressTextBox.Text;
            info.mobile = MobileTextBox.Text;
            info.username = UsernametextBox.Text;
            info.team_id = TeamIdtextBox.Text;

            dt = opr.UpdateUser(info);
            MetroFramework.MetroMessageBox.Show(this, "Data Updated", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshing(OwnerDataView);
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
            refreshing(OwnerDataView);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            refreshing(OwnerDataView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            info.username = UsernametextBox.Text;
            dt = opr.DeleteUser(info);
            MetroFramework.MetroMessageBox.Show(this, "Data Deleted", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshing(OwnerDataView);
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OwnerHomepage oh = new OwnerHomepage();
            oh.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            OwnerHomepage oh = new OwnerHomepage();
            oh.Show();
            this.Hide();
        }
    }
}
