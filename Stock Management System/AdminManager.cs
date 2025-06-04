using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Stock_Management_System
{
    internal class AdminManager : Person, Interface
    {
        private string connectionString = "server=localhost;database=stock_management;uid=root;";


        public AdminManager(string username, string id, string password) : base(username, id, password)
        {
        }

        public override void create(string username,string id,string password)
        {
            try
            {
                // Connect to the database
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Verify the admin_id exists in the admin_details table
                    string verifyQuery = "SELECT COUNT(*) FROM admin_details WHERE admin_id = @id";
                    MySqlCommand verifyCmd = new MySqlCommand(verifyQuery, conn);
                    verifyCmd.Parameters.AddWithValue("@id", Id);

                    int adminExists = Convert.ToInt32(verifyCmd.ExecuteScalar());
                    if (adminExists == 0)
                    {
                        throw new Exception("Admin ID does not exist in admin_details database.");
                    }

                    // Check if the admin_id already has an account in admin_accounts
                    string checkQuery = "SELECT COUNT(*) FROM admin_accounts WHERE admin_id = @id";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id", Id);

                    int accountExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (accountExists > 0)
                    {
                        throw new Exception("An account already exists for this Admin ID.");
                    }

                    // Insert admin credentials into admin_accounts table
                    string insertQuery = "INSERT INTO admin_accounts (username, admin_id, password) VALUES (@username, @id, @password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", Username);
                    insertCmd.Parameters.AddWithValue("@id", Id);
                    insertCmd.Parameters.AddWithValue("@password", Password);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Admin account created successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        

        }

        public void idAlreadyExists()
        {
            
        }

        public override void login()
        {
            
        }
    }
}
