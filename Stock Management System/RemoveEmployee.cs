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
    public partial class RemoveEmployee : Form
    {
        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string employeeId = EmployeeID.Text.Trim();

                if (string.IsNullOrEmpty(employeeId))
                {
                    MessageBox.Show("Please enter a valid Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult result = MessageBox.Show($"Are you sure you want to delete {employeeId} from the system?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        AdminManager deleteEmp = new AdminManager();
                        deleteEmp.delete(employeeId);
                        EmployeeID.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmployeeID.Text = string.Empty;
            }
        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
