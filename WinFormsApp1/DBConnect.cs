using System;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    internal class DBConnect
    {
        private readonly string connectionString;

        public DBConnect()
        {
            connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StdManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void OpenConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening connection: {ex.Message}");
            }
        }

        public void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing connection: {ex.Message}");
            }
        }
    }
}
