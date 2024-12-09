using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RosaDatabaseoperations
{
    internal class lab3q7
    {
        
    static string connectionString = "Server=localhost;Database=librarydb;Uid=root;Pwd=;";

       /* static void Main(string[] args)
        {
            Console.WriteLine("Nepali Books Management");

           *//* // Add Books
            AddBook("Muna Madan", "Laxmi Prasad Devkota", 1936);
            AddBook("Seto Bagh", "Diamond Shumsher Rana", 1973);
            AddBook("Palpasa Café", "Narayan Wagle", 2005);

            // View Books
            ViewBooks();

            // Update a Book
            UpdateBook(5, "Seto Bagh 2", "Diamond Rana", 1974);*//*

            // Delete a Book
            DeleteBook(5);

            // View Books Again
            ViewBooks();
        }*/

        static void AddBook(string title, string author, int year)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO books (title, author, year) VALUES (@title, @author, @year)";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine($"Added Book: {title}");
                }
            }
        }

        static void ViewBooks()
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM books";
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\nBooks in Library:");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Title: {reader["title"]}, Author: {reader["author"]}, Year: {reader["year"]}");
                    }
                }
            }
        }

        static void UpdateBook(int id, string newTitle, string newAuthor, int newYear)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE books SET title = @title, author = @author, year = @year WHERE id = @id";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@title", newTitle);
                    cmd.Parameters.AddWithValue("@author", newAuthor);
                    cmd.Parameters.AddWithValue("@year", newYear);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine($"Updated Book ID {id} to: {newTitle}");
                }
            }
        }

        static void DeleteBook(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM books WHERE id = @id";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine($"Deleted Book ID {id}");
                }
            }
        }
    }
}

