﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class EmployeeLogin : Form
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void NewAccountBtn_Click(object sender, EventArgs e)
        {

            EmployeeRegister employeeRegister = new EmployeeRegister();
            employeeRegister.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            userMode usermode = new userMode();
            usermode.Show();
            this.Hide();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserName.Text.Trim();
                string password = Pwd.Text.Trim();

                // Validate empty fields
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and Password cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    EmployeeManager employeeLogin = new EmployeeManager(username, password);
                    employeeLogin.login(username, password);

                    EmployeeDashboard employeeDashboard = new EmployeeDashboard();
                    employeeDashboard.Show();
                    this.Hide();
                }


            }
            catch (Exception ex)
            {
                // Display any login errors
                MessageBox.Show($"{ex.Message}", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clear input fields
                UserName.Text = string.Empty;
                Pwd.Text = string.Empty;
            }

        }
    }
}
