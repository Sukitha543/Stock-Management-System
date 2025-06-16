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
    public partial class IssueStocks : Form
    {
        public IssueStocks()
        {
            InitializeComponent();
        }

        private void IssueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string stockId = Id.Text;
                int quantity = Convert.ToInt32(Quantity.Text);

                if (quantity <= 0)
                {
                    MessageBox.Show("Please enter a valid positive number for the quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    EmployeeManager issue = new EmployeeManager();
                    issue.issueStocks(stockId, quantity);

                    Id.Text = string.Empty;
                    Quantity.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Entry.Please check your inputs.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

