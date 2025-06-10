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
    public partial class AddEmployees : Form
    {
       
        public AddEmployees()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int contactNo = Convert.ToInt32(ContactNumber.Text);
                string id = AdminManager.GetNextEmployeeId();
                string firstName = FirstName.Text;
                string lastName = LastName.Text;
                string email = Email.Text;
                string address = Address.Text;

                if (ContactNumber.Text.Length != 10)
                {
                    MessageBox.Show("Contact number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ContactNumber.Text = string.Empty;

                }
                else if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Text = string.Empty;

                }
                else
                {
                    // Create an Employee object
                    Employee emp = new Employee(id, firstName, lastName, contactNo, email, address);

                    // Create an instance of the subclass and add the employee
                    AdminManager addemployee = new AdminManager();
                    addemployee.addEmployees(emp);
                    this.Close();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Entry. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void AddEmployees_Load(object sender, EventArgs e)
        {

        }
    }
}
