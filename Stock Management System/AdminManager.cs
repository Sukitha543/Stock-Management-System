using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace Stock_Management_System
{
    internal class AdminManager : Person, Interface
    {

        public AdminManager(string username, string id, string password) : base(username, id, password)
        {
        }

        public AdminManager(string username, string password) : base(username, password)
        {
        }

        public AdminManager() : base()
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
                        throw new Exception($"An account already exists for{Id} ");
                    }

                    // Insert admin credentials into admin_accounts table
                    string insertQuery = "INSERT INTO admin_accounts (username, admin_id, password) VALUES (@username, @id, @password)";
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


        public void addEmployees(Employee emp)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();

                // Add employee details
                string insertQuery = "INSERT INTO employee_details (employee_id, firstname, lastname, contact_number, email, address) VALUES (@id, @firstname, @lastname, @contact, @email, @address)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@id", emp.Id);
                insertCmd.Parameters.AddWithValue("@firstname", emp.FirstName);
                insertCmd.Parameters.AddWithValue("@lastname", emp.LastName);
                insertCmd.Parameters.AddWithValue("@contact", emp.ContactNo);
                insertCmd.Parameters.AddWithValue("@email", emp.Email);
                insertCmd.Parameters.AddWithValue("@address", emp.Address);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show($"The employee with the ID {emp.Id} was added successfully.", "Employee Added", MessageBoxButtons.OK);
            }
        }



        public static string GetNextEmployeeId()
        {
            string nextID = " ";

            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();

                // Query to get the last employeeID ordered descending
                string query = "SELECT employee_id FROM employee_details ORDER BY employee_id DESC LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastID = result.ToString();  // e.g. "E005"

                    // Extract number part from the string (remove the "E")
                    int numericPart = int.Parse(lastID.Substring(1));

                    // Increment number
                    int newNumericPart = numericPart + 1;

                    // Format the new ID with leading zeros (E.g. E006)
                    nextID = "E" + newNumericPart.ToString("D3");
                }
                else
                {
                    // If no records found, start from E001
                    nextID = "E001";
                }
            }
            return nextID;
        }

        public override void delete(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                try
                {
                    conn.Open();

                    // Check if the employee exists
                    string checkQuery = "SELECT COUNT(*) FROM employee_details WHERE employee_id = @Id";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@Id", id);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        throw new Exception("Employee ID not found.");
                    }

                    // Delete the employee (associated records in employee_accounts will be deleted automatically)
                    string deleteQuery = "DELETE FROM employee_details WHERE employee_id = @Id";
                    MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@Id", id);
                    deleteCmd.ExecuteNonQuery();
                    MessageBox.Show($"Employee with ID {id} has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public Employee GetEmployeeDetailsById(string id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
                {
                    conn.Open();

                    string query = "SELECT * FROM employee_details WHERE employee_id = @EmployeeId";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeId", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Employee(
                                reader["employee_id"].ToString(),
                                reader["firstname"].ToString(),
                                reader["lastname"].ToString(),
                                Convert.ToInt32(reader["contact_number"]),
                                reader["email"].ToString(),
                                reader["address"].ToString()
                            );
                        }
                        else
                        {
                            throw new Exception("Employee not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        public void UpdateEmployeeDetails(Employee emp)
        {
            using (MySqlConnection conn = new MySqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();

                string updateQuery = @" UPDATE employee_details SET firstname = @FirstName,lastname = @LastName,contact_number = @ContactNo,email = @Email, address = @Address WHERE employee_id = @EmployeeId";
               MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@EmployeeId", emp.Id);
                cmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                cmd.Parameters.AddWithValue("@LastName", emp.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", emp.ContactNo);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Address", emp.Address);

                cmd.ExecuteNonQuery();

                MessageBox.Show($"Employee details of {emp.Id} updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
        
    



