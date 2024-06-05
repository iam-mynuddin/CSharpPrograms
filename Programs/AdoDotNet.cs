// using System;
// using System.Data;
// using System.Data.SqlClient;
// namespace AdoDotNet
// {

// class Program
// {
//     static void Main()
//     {
//         string connectionString = "";

//         // Create and open a connection
//         using (SqlConnection connection = new SqlConnection(connectionString))
//         {
//             connection.Open();

//             // Execute a SELECT query
//             string selectQuery = "SELECT Id, Name, Age FROM Persons";
//             using (SqlCommand command = new SqlCommand(selectQuery, connection))
//             {
//                 using (SqlDataReader reader = command.ExecuteReader())
//                 {
//                     while (reader.Read())
//                     {
//                         Console.WriteLine($"Id: {reader.GetInt32(0)}, Name: {reader.GetString(1)}, Age: {reader.GetInt32(2)}");
//                     }
//                 }
//             }

//             // Execute an INSERT query
//             string insertQuery = "INSERT INTO Persons (Name, Age) VALUES (@Name, @Age)";
//             using (SqlCommand command = new SqlCommand(insertQuery, connection))
//             {
//                 command.Parameters.AddWithValue("@Name", "John");
//                 command.Parameters.AddWithValue("@Age", 30);

//                 int rowsAffected = command.ExecuteNonQuery();
//                 Console.WriteLine($"{rowsAffected} row(s) inserted.");
//             }

//             // Execute an UPDATE query
//             string updateQuery = "UPDATE Persons SET Age = @Age WHERE Name = @Name";
//             using (SqlCommand command = new SqlCommand(updateQuery, connection))
//             {
//                 command.Parameters.AddWithValue("@Name", "John");
//                 command.Parameters.AddWithValue("@Age", 31);

//                 int rowsAffected = command.ExecuteNonQuery();
//                 Console.WriteLine($"{rowsAffected} row(s) updated.");
//             }

//             // Execute a DELETE query
//             string deleteQuery = "DELETE FROM Persons WHERE Name = @Name";
//             using (SqlCommand command = new SqlCommand(deleteQuery, connection))
//             {
//                 command.Parameters.AddWithValue("@Name", "John");

//                 int rowsAffected = command.ExecuteNonQuery();
//                 Console.WriteLine($"{rowsAffected} row(s) deleted.");
//             }
//         }
//     }
// }

// }