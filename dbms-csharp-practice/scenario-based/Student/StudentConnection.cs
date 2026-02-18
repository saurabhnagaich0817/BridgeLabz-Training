using System;
using System.Data;
using Microsoft.Data.SqlClient;

class StudentConnections
{
    public static void Main(string[] args)
    {
        string query = "SELECT * FROM Students";

        string connectionString =
        "Server=localhost;Database=PracticeDB;Trusted_Connection=True;TrustServerCertificate=True;";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            Console.WriteLine("Connection Opened Successfully");

            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Name"] + " " + reader["Age"]);
            }

            reader.Close();
            connection.Close();
        }
    }
}
