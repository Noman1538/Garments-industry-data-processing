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
    public partial class ProductInfo : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();

        public ProductInfo()
        {
            InitializeComponent();
        }
        public void refreshing(DataGridView datagridview)
        {
            ProductIDtextBox.Text = "";
            TeamIDtextBox.Text = "";
            StyleNotextBox.Text = "";
            OrderQuantitytextBox.Text = "";
            ProducttextBox.Text = "";
            LabeltextBox.Text = "";
            SMVtextBox.Text = "";
            // FirstOutdateTimePicker.Value = Convert.ToDateTime(row.Cells[7].Value);
            StyleChangestextBox.Text = "";
            PlanMantextBox.Text = "";
            TargetInputtextBox.Text = "";
            TargetOutputtextBox.Text = "";
            dt = opr.viewProduct(info);
            dataGridView1.DataSource = dt;
        }
        private void ProductInfo_Load(object sender, EventArgs e)
        {
            refreshing(dataGridView1);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewProduct_Click(object sender, EventArgs e)
        {

            refreshing(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                ProductIDtextBox.Text = row.Cells[0].Value.ToString();
                TeamIDtextBox.Text = row.Cells[1].Value.ToString();
                StyleNotextBox.Text = row.Cells[2].Value.ToString();
                OrderQuantitytextBox.Text = row.Cells[3].Value.ToString();
                ProducttextBox.Text = row.Cells[4].Value.ToString();
                LabeltextBox.Text = row.Cells[5].Value.ToString();
                SMVtextBox.Text = row.Cells[6].Value.ToString();
                FirstOutdateTimePicker.Value = Convert.ToDateTime(row.Cells[7].Value);
                StyleChangestextBox.Text = row.Cells[8].Value.ToString();
                PlanMantextBox.Text = row.Cells[9].Value.ToString();
                TargetInputtextBox.Text = row.Cells[10].Value.ToString();
                TargetOutputtextBox.Text = row.Cells[11].Value.ToString();
                }
            
        }

        private void SaveProduct_Click(object sender, EventArgs e)
        {
            info.product_id =Convert.ToInt32(ProductIDtextBox.Text);
            info.team_id = TeamIDtextBox.Text;
            info.style_no = StyleNotextBox.Text;
            info.order_qty =Convert.ToInt32(OrderQuantitytextBox.Text);
            info.product = ProducttextBox.Text;
            info.label = LabeltextBox.Text;
            info.smv = (float)Convert.ToDouble(SMVtextBox.Text);
            info.first_out = FirstOutdateTimePicker.Value;
            info.style_changes =Convert.ToInt32(StyleChangestextBox.Text);
            info.plan_man = PlanMantextBox.Text;
            info.target_input = Convert.ToInt32(TargetInputtextBox.Text);
            info.target_output = TargetOutputtextBox.Text;

            dt = opr.NewProduct(info);

            refreshing(dataGridView1);
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            info.product_id = Convert.ToInt32(ProductIDtextBox.Text);
            info.team_id = TeamIDtextBox.Text;
            info.style_no = StyleNotextBox.Text;
            info.order_qty = Convert.ToInt32(OrderQuantitytextBox.Text);
            info.product = ProducttextBox.Text;
            info.label = LabeltextBox.Text;
            info.smv = Convert.ToInt32(SMVtextBox.Text);
            info.first_out = FirstOutdateTimePicker.Value;
            info.style_changes = Convert.ToInt32(StyleChangestextBox.Text);
            info.plan_man = PlanMantextBox.Text;
            info.target_input = Convert.ToInt32(TargetInputtextBox.Text);
            info.target_output = TargetOutputtextBox.Text;

            dt = opr.UpdateProduct(info);

            refreshing(dataGridView1);

        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            //try
            //{
                info.product_id = Convert.ToInt32(ProductIDtextBox.Text);
                dt = opr.DeleteProduct(info);
                refreshing(dataGridView1);
            //}
            //catch {
            //    MetroFramework.MetroMessageBox.Show(this, "Owner must need to delete the log first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagerHomepage mh = new ManagerHomepage();
            mh.Show();
            this.Hide();
        }
    }
}
