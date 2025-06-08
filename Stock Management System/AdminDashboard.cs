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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AddEmployeesBtn_Click(object sender, EventArgs e)
        {
            AddEmployees addEmployees = new AddEmployees();
            addEmployees.Show();
            
        }


        private void LogOutBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to log out", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                userMode userMode = new userMode();
                userMode.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void RemoveEmployeesBtn_Click(object sender, EventArgs e)
        {
            RemoveEmployee removeEmployee = new RemoveEmployee();
            removeEmployee.Show();
        }
    }
}
