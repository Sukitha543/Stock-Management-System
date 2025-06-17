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
    public partial class ViewStocks : Form
    {
        public ViewStocks()
        {
            InitializeComponent();
        }

        private void ViewStocks_Load(object sender, EventArgs e)
        {
            loadStockData();
        }

        private void loadStockData()
        {
            try
            {
               
                DataTable stockData = EmployeeManager.GetAllStocks();

                StockDataGrid.DataSource = stockData;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
