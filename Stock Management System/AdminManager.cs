using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Stock_Management_System
{
    internal class AdminManager : Person, Interface
    {
        private string connectionString = "server=localhost;database=stock_management;uid=root;";


       public AdminManager(string username, string id, string password) : base(username, id, password)
        {
        }

        public AdminManager(string username,string password) : base(username, password) 
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
                    verifyCmd.Parameters.AddWithValue("@id", id);

                    int adminExists = Convert.ToInt32(verifyCmd.ExecuteScalar());
                    if (adminExists == 0)
                    {
                        throw new Exception($"ID {Id} does not exist in the database");
                    }

                    // Check if the admin_id already has an account in admin_accounts
                    string checkQuery = "SELECT COUNT(*) FROM admin_accounts WHERE admin_id = @id";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id", id);

                    int accountExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (accountExists > 0)
                    {
                        throw new Exception($"An account already exists for {Id}");
                    }

                    // Insert admin credentials into admin_accounts table
                    string insertQuery = "INSERT INTO admin_accounts (username, admin_id, password) VALUES (@username, @id, @password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@id", id);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Admin account created successfully.","Account Creation Successful",MessageBoxButtons.OK);
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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the username and password exist in the admin_accounts table
                    string query = "SELECT COUNT(*) FROM admin_accounts WHERE username = @username AND password = @password";
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
        }
    }

