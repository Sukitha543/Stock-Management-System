using System;
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
    public partial class EmployeeRegister : Form
    {
        public EmployeeRegister()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.Show();
            this.Hide();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserName.Text;
                string id = AdminId.Text;
                string password = Pwd.Text;
                string confirmPassword = ConfirmPwd.Text;

                EmployeeManager employeeRegister = new EmployeeManager(username, id, password);
                if (password != confirmPassword)
                {
                    MessageBox.Show("password and confirm password does not match", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pwd.Text = string.Empty;
                    ConfirmPwd.Text = string.Empty;

                }
                else
                {
                    // Call the create method with parameters
                    employeeRegister.create(username, id, password);
                    EmployeeLogin employeeLogin = new EmployeeLogin();
                    employeeLogin.Show();
                    this.Hide();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();

            }
        }

        private void EmployeeRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
