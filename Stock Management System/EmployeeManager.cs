using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{

    internal class EmployeeManager : Person, Interface
    {
        public EmployeeManager() 
        {
        }

        public EmployeeManager(string username, string id, string password) : base(username, id, password)
        {
        }

        public EmployeeManager(string username, string password) : base(username, password)
        {
        }

        public override void create(string username, string id, string password)
        {
            try
            {
                // Connect to the database
                using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    conn.Open();

                    // Verify the admin_id exists in the admin_details table
                    string verifyQuery = "SELECT COUNT(*) FROM employee_details WHERE employee_id = @id";
                    MySqlCommand verifyCmd = new MySqlCommand(verifyQuery, conn);
                    verifyCmd.Parameters.AddWithValue("@id", id);

                    int adminExists = Convert.ToInt32(verifyCmd.ExecuteScalar());
                    if (adminExists == 0)
                    {
                        throw new Exception($"ID {Id} does not exist in the database");
                    }

                    // Check if the admin_id already has an account in admin_accounts
                    string checkQuery = "SELECT COUNT(*) FROM employee_accounts WHERE employee_id = @id";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id", id);

                    int accountExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (accountExists > 0)
                    {
                        throw new Exception($"An account already exists for{Id} ");
                    }

                    // Insert admin credentials into admin_accounts table
                    string insertQuery = "INSERT INTO employee_accounts (username, employee_id, password) VALUES (@username, @id, @password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@id", id);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    insertCmd.ExecuteNonQuery();


                    MessageBox.Show("Admin account created successfully.", "Account Creation Successful", MessageBoxButtons.OK);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}", "Account Creation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
        }

        public override void login(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    conn.Open();

                    // Check if the username and password exist in the admin_accounts table
                    string query = "SELECT COUNT(*) FROM employee_accounts WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int userExists = Convert.ToInt32(cmd.ExecuteScalar());
                    if (userExists == 0)
                    {
                        throw new Exception("Invalid Username or Password.");
                    }
                    else
                    {

                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

            catch (Exception ex)
            {
                // Rethrow the exception to handle it in the caller
                throw new Exception(ex.Message);


            }
        }


        public void addNewStock(Stock stock)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();

                // Add employee details
                string insertQuery = "INSERT INTO stocks (stock_id, name, quantity, supplier, contact, date) VALUES (@id, @name, @quantity, @supplier, @contact, @date)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@id", stock.Id);
                insertCmd.Parameters.AddWithValue("@name", stock.Name);
                insertCmd.Parameters.AddWithValue("@quantity", stock.Quantity);
                insertCmd.Parameters.AddWithValue("@supplier", stock.Supplier);
                insertCmd.Parameters.AddWithValue("@contact", stock.Contact);
                insertCmd.Parameters.AddWithValue("@date", stock.Date);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show($"The New srock with the ID {stock.Id} was added successfully.", "New Stock Added", MessageBoxButtons.OK);
            }
        }
        

        public static List<string> GetSuppliers()
        {
            List<string> suppliers = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();

                string query = "SELECT supplier_name FROM suppliers";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(reader["supplier_name"].ToString());
                    }
                }
            }

            return suppliers;
        }

        public static string GetNextStockId()
        {
            string nextID = " ";

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();

                string query = "SELECT stock_id FROM stocks ORDER BY stock_id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastID = result.ToString();  

                    int numericPart = int.Parse(lastID.Substring(1));

                    int newNumericPart = numericPart + 1;

                    nextID = "S" + newNumericPart.ToString("D3");
                }
                else
                {
                    nextID = "S001";
                }
            }
            return nextID;
        }


        public void addQuantity(string id, int additionalQuantity)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))

                try
                {
                    conn.Open();

                    // Check if the stock exists
                    string checkQuery = "SELECT quantity FROM stocks WHERE stock_id = @StockId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@StockId", id);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        throw new Exception("Stock ID not found.");
                    }

                    // Get the current quantity
                    int currentQuantity = Convert.ToInt32(count);

                    // Calculate the new quantity
                    int updatedQuantity = currentQuantity + additionalQuantity;

                    // Update the quantity in the database
                    string updateQuery = "UPDATE stocks SET quantity = @UpdatedQuantity WHERE stock_id = @StockId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
                    updateCmd.Parameters.AddWithValue("@StockId", id);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show($"Stock quantity updated successfully. New quantity: {updatedQuantity}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }
    
        
        
        public void issueStocks(string id, int quantity)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))

                try
                {
                    conn.Open();

                    // Check if the stock exists
                    string checkQuery = "SELECT quantity FROM stocks WHERE stock_id = @StockId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@StockId", id);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        throw new Exception("Stock ID not found.");
                    }

                    // Get the current quantity
                    int currentQuantity = Convert.ToInt32(count);

                    // Calculate the new quantity
                    int updatedQuantity = currentQuantity - quantity;

                    // Update the quantity in the database
                    string updateQuery = "UPDATE stocks SET quantity = @UpdatedQuantity WHERE stock_id = @StockId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@UpdatedQuantity", updatedQuantity);
                    updateCmd.Parameters.AddWithValue("@StockId", id);

                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show($"Stock issued successfully. New quantity: {updatedQuantity}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
        }

    }
}
