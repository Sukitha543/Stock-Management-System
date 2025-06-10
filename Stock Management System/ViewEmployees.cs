using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class ViewEmployees : Form
    {
        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeId = EmployeeID.Text;

                if (string.IsNullOrEmpty(employeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    AdminManager manager = new AdminManager();
                    Employee emp = manager.GetEmployeeDetailsById(employeeId);

                    FirstNameLbl.Text = emp.FirstName;
                    LastNameLbl.Text = emp.LastName;
                    ContactNumberLbl.Text = emp.ContactNo.ToString();
                    EmailLbl.Text = emp.Email;
                    AddressLbl.Text = emp.Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContactNumberLbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}   

