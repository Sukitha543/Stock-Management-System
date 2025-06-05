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
    }
}
