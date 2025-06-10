using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Stock_Management_System
{
    public partial class EditEmployee : Form
    {
        private string currentEmployeeId { get; set; }
        
        public EditEmployee()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                currentEmployeeId = EmployeeId.Text.Trim();
                

                if (string.IsNullOrEmpty(currentEmployeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    AdminManager edit = new AdminManager();
                    Employee emp = edit.GetEmployeeDetailsById(currentEmployeeId);

                    FirstName.Text = emp.FirstName;
                    LastName.Text = emp.LastName;
                    ContactNumber.Text = emp.ContactNo.ToString();
                    Email.Text = emp.Email;
                    Address.Text = emp.Address;
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmployeeId.Text = string.Empty;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currentEmployeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmployeeId.Text = string.Empty;
                }
                else if (string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(LastName.Text) || string.IsNullOrEmpty(ContactNumber.Text) || string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Address.Text))
                {
                    MessageBox.Show("Invalid Entry. Please check your inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ContactNumber.Text.Length != 10 || !int.TryParse(ContactNumber.Text, out int contactNo))
                {
                    MessageBox.Show("Contact number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ContactNumber.Text = string.Empty;
                }
                else if (!Email.Text.Contains("@") || !Email.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Email.Text = string.Empty;
                }
                else
                {
                    // Create an updated Employee object
                    AdminManager edit = new AdminManager();
                    Employee emp = new Employee(currentEmployeeId, FirstName.Text.Trim(), LastName.Text.Trim(), contactNo, Email.Text.Trim(), Address.Text.Trim());
                    edit.UpdateEmployeeDetails(emp);

                    FirstName.Text = string.Empty;
                    LastName.Text = string.Empty;
                    ContactNumber.Text = string.Empty;
                    Email.Text = string.Empty;
                    Address.Text = string.Empty;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
