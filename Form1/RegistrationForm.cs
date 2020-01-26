﻿using System;
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
    public partial class RegistrationForm : MetroFramework.Forms.MetroForm
    {
        public info info = new info();
        public opr opr = new opr();
        DataTable dt = new DataTable();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            info.name = NameTextBox.Text;
            info.password = PasswordTextBox.Text;
            info.role = RolecomboBox.SelectedItem.ToString();
            info.username = UsernameTextBox.Text;
            info.address = AddressTextBox.Text;
            info.mobile = MobileTextBox.Text;
            info.team_id = TeamIDtextBox.Text;


            if (NameTextBox.Text == "" || UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || AddressTextBox.Text == "" || MobileTextBox.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Something is missing.Plese check it again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dt = opr.NewUser(info);
                LoginForm lf = new LoginForm();
                lf.Show();
                this.Hide();

                MetroFramework.MetroMessageBox.Show(this, "Congratulation.", "Registration Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Datainfo() {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }
    }
}
