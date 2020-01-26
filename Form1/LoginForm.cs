using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DB;
using Information;
using Operations;


namespace Form1
    
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();
        Object o = new object();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.username = UsernameTextBox.Text;
            info.password = PasswordTextBox.Text;


            // string result = UsernameTextBox.Text.Substring(0, 2);


            // dt = opr.Login(info);
            string result;
            o = opr.Login(info);
            if (o == null)
            {
                MetroFramework.MetroMessageBox.Show(this, "Username Or Password is wrong. Please try again.", "Username Or Password is wrong. Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error, 15);
            }
            else
            {
                result = o.ToString();

                if (result == "Supervisor")
                {
                    SupervisorHomepage sh = new SupervisorHomepage();
                    sh.Show();
                    this.Hide();
                }
                else if (result == "Manager")
                {
                    ManagerHomepage sh = new ManagerHomepage();
                    sh.Show();
                    this.Hide();
                }
                else if (result == "Owner")
                {
                    OwnerHomepage sh = new OwnerHomepage();
                    sh.Show();
                    this.Hide();
                }
            }


        }

            


            

            

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            this.Hide();
            rf.Show();
        }
    }
}
