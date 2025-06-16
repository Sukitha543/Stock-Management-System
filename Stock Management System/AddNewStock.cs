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
    public partial class AddNewStock : Form
    {
        public AddNewStock()
        {
            InitializeComponent();
        }

        private void AddNewStock_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> suppliers = EmployeeManager.GetSuppliers();

                //put the supplier list to the combo box
                comboSupplier.DataSource = suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string stockId = EmployeeManager.GetNextStockId();
                string stockName = StockName.Text;
                int quantity = Convert.ToInt32(Quantity.Text);
                string supplier = comboSupplier.SelectedItem.ToString();
                int contact = Convert.ToInt32(Contact.Text);
                DateTime stockDate = DateTime.Now;

                if (string.IsNullOrEmpty(stockName) || string.IsNullOrEmpty(supplier))
                {
                    MessageBox.Show("Please provide valid stock details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Stock stock = new Stock(stockId, stockName, quantity, supplier, contact, stockDate);
                    EmployeeManager newStock = new EmployeeManager();
                    newStock.addNewStock(stock);


                    StockName.Text = string.Empty;
                    Quantity.Text = string.Empty;
                    Contact.Text = string.Empty;
                    comboSupplier.SelectedIndex = -1;


                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for quantity and contact.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        

      
    }
}
