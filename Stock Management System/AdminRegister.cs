using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
               
                AdminManager adminRegister = new AdminManager(username, id, password);
                if (password != confirmPassword)
                {
                    MessageBox.Show("password and confirm password does not match","Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Pwd.Text = string.Empty;
                    ConfirmPwd.Text = string.Empty;

                }
                else
                {
                    // Call the create method with parameters
                    adminRegister.create(username, id,password);
                    
                    UserName.Text = string.Empty;
                    AdminId.Text = string.Empty;
                    Pwd.Text = string.Empty;
                    ConfirmPwd.Text = string.Empty;
                    this.Close();


                }
            }
            catch(Exception ex)  
            {
                MessageBox.Show($"{ex.Message}", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AdminId.Text = string.Empty;
            }
            
            
        }

            

    


    }
}


