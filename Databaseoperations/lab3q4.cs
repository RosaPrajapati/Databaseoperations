using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace RosaDatabaseoperations


{
    class Program2
    {
        /*static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=;";

            // Edit (Update) operation
            UpdateEmployee(connectionString, 1, "Jane Doe", 60000, "Kathmandu");

            // Delete operation
            DeleteEmployee(connectionString, 1);
        }

        // Method to update employee data in the database
        static void UpdateEmployee(string connectionString, int id, string name, decimal salary, string address)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE employees SET name = @name, salary = @salary, address = @address WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@salary", salary);
                    command.Parameters.AddWithValue("@address", address);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) updated successfully.");
                }
            }
        }

        // Method to delete an employee from the database
        static void DeleteEmployee(string connectionString, int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM employees WHERE id = @id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) deleted successfully.");
                }
            }
        }*/
    }
}

