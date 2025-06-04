using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stock_Management_System
{
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void AdminRegister_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = UserName.Text;
                string id = AdminId.Text;
                string password = Pwd.Text;
                string confirmPassword = ConfirmPwd.Text;

                if (password != confirmPassword)
                {
                    throw new Exception("Password and Confirm Password do not match.");
                }

                // Create AdminManager instance
                AdminManager adminManager = new AdminManager(username, id, password);

                // Call the create method with parameters
                adminManager.create(username, id, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
