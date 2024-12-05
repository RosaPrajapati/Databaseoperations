using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaDatabaseoperations
{
    class Program
    {
        /*static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=csharp;Uid=root;Pwd=;";

            // Insert operation
            InsertEmployee(connectionString, "John Doe", 60000, "Kathmandu");
            InsertEmployee(connectionString, "Alice", 60000, "Kathmandu");
            InsertEmployee(connectionString, "Bob", 45000, "Pokhara");
            InsertEmployee(connectionString, "Charlie", 70000, "Kathmandu");
            InsertEmployee(connectionString, "Diana", 52000, "Lalitpur");
            InsertEmployee(connectionString, "Edward", 48000, "Kathmandu");

            // Select operation
            SelectEmployees(connectionString);
        }

        // Method to insert employee data into the database
        static void InsertEmployee(string connectionString, string name, decimal salary, string address)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO employees (name, salary, address) VALUES (@name, @salary, @address)";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@salary", salary);
                        command.Parameters.AddWithValue("@address", address);

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} row(s) inserted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to select and display employee data from the database
        static void SelectEmployees(string connectionString)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM employees";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            Console.WriteLine("Employee Data:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Salary: {reader["salary"]}, Address: {reader["address"]}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }*/
    }
}
