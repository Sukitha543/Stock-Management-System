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
    public partial class EmployeeDashboard : Form
    {
        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void AddNewStockBtn_Click(object sender, EventArgs e)
        {
            AddNewStock stock = new AddNewStock();
            stock.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
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

        private void AddQuantityBtn_Click(object sender, EventArgs e)
        {
            AddQuantity add = new AddQuantity();
            add.Show();
        }

        private void ViewStocksBtn_Click(object sender, EventArgs e)
        {
            ViewStocks view = new ViewStocks();
            view.Show();
        }

        private void IssueStockBtn_Click(object sender, EventArgs e)
        {
            IssueStocks issue = new IssueStocks();
            issue.Show();
        }
    }
}
