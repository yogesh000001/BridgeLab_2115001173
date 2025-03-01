using System;
using System.Data.SqlClient;
using System.IO;

class Program
{
    static void Main()
    {
        string connectionString = "your_connection_string";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        string filePath = "employee_report.csv";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Employee ID,Name,Department,Salary");

                while (reader.Read())
                {
                    sw.WriteLine($"{reader["EmployeeID"]},{reader["Name"]},{reader["Department"]},{reader["Salary"]}");
                }
            }
        }

        Console.WriteLine("CSV report generated successfully.");
    }
}
