using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class EnrollmentClass
    {
        private readonly DBConnect dBConnect;
        public EnrollmentClass()
        {
            this.dBConnect = new DBConnect();
        }

        public bool EnrollmentExists(string courseID, string cycleID, string studentID)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                string query = "SELECT COUNT(*) FROM Enrollments WHERE CourseID = @CourseID AND CycleID = @CycleID AND StudentID = @StudentID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@CycleID", cycleID);
                    command.Parameters.AddWithValue("@StudentID", studentID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        // function add

        public bool AddEnrollment(string CourseID, string CycleID, string StudentID, DateTime EnrollmentDate)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = @"INSERT INTO Enrollments (CourseID, CycleID, StudentID, EnrollmentDate) 
                          VALUES (@CourseID, @CycleID, @StudentID, @EnrollmentDate)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@CycleID", CycleID);
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@EnrollmentDate", EnrollmentDate);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // return true if at least one row was inserted
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteEnrollment(string CourseID, string CycleID, string StudentID)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = "DELETE FROM Enrollments WHERE CourseID = @CourseID AND CycleID = @CycleID AND StudentID = @StudentID";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@CycleID", CycleID);
                        command.Parameters.AddWithValue("@StudentID", StudentID);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting enrollment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateEnrollment(string CourseID, string CycleID, string StudentID, DateTime EnrollmentDate)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = @"UPDATE Enrollments 
                                  SET CourseID = @CourseID, CycleID = @CycleID, EnrollmentDate = @EnrollmentDate 
                                  WHERE StudentID = @StudentID";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@CycleID", CycleID);
                        command.Parameters.AddWithValue("@StudentID", StudentID);
                        command.Parameters.AddWithValue("@EnrollmentDate", EnrollmentDate);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // return true if at least one row was updated
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating enrollment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable GetEnrollments()
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = "SELECT * FROM Enrollments";
                    using (var command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching enrollments: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }



        public DataTable SearchEnrollment(string searchTerm)
        {
            using (var connection = dBConnect.GetConnection())
            {
                var query = "SELECT * FROM Enrollments WHERE CourseID LIKE @SearchTerm OR CycleID LIKE @SearchTerm OR StudentID LIKE @SearchTerm";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    try
                    {
                        adapter.Fill(dt);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error searching enrollment: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return dt;
                }
            }
        }
    }
}
