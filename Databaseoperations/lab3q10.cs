using System;
using MySql.Data.MySqlClient;

class TourismManager
{
    static string connectionString = "Server=localhost;Database=tourismdb;User ID=root;Password=yourpassword;";

    static void Main(string[] args)
    {
        Console.WriteLine("Tourism Management System");

        // Add Tourism Information
        AddDestination("Pokhara Tour", "Experience the beauty of lakes and mountains.", 3);
        AddDestination("Kathmandu Heritage Tour", "Explore the UNESCO heritage sites.", 2);

        // View All Destinations
        ViewDestinations();

        // Update a Destination
        UpdateDestination(1, "Pokhara Adventure Tour", "Enjoy paragliding and scenic views.", 4);

        // Delete a Destination
        DeleteDestination(2);

        // View All Destinations Again
        ViewDestinations();
    }

    static void AddDestination(string title, string description, int duration)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO TourDestination (Title, Description, Duration, CreatedDate) " +
                           "VALUES (@title, @description, @duration, @createdDate)";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                Console.WriteLine($"Added Destination: {title}");
            }
        }
    }

    static void ViewDestinations()
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM TourDestination";
            using (var cmd = new MySqlCommand(query, connection))
            using (var reader = cmd.ExecuteReader())
            {
                Console.WriteLine("\nTour Destinations:");
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]}, Title: {reader["Title"]}, Description: {reader["Description"]}, Duration: {reader["Duration"]} days, CreatedDate: {reader["CreatedDate"]}");
                }
            }
        }
    }

    static void UpdateDestination(int id, string newTitle, string newDescription, int newDuration)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE TourDestination SET Title = @title, Description = @description, Duration = @duration WHERE Id = @id";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@title", newTitle);
                cmd.Parameters.AddWithValue("@description", newDescription);
                cmd.Parameters.AddWithValue("@duration", newDuration);
                cmd.ExecuteNonQuery();
                Console.WriteLine($"Updated Destination ID {id} to: {newTitle}");
            }
        }
    }

    static void DeleteDestination(int id)
    {
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM TourDestination WHERE Id = @id";
            using (var cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                Console.WriteLine($"Deleted Destination ID {id}");
            }
        }
    }
}
