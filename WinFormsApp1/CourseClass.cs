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
    public class CourseClass
    {
        private readonly DBConnect dBconnect;

        public CourseClass()
        {
            this.dBconnect = new DBConnect();
        }

        public bool insertCourse(string courseID, string courseName, string teacherID, string semester)
        {
            try
            {
                using (var connection = dBconnect.GetConnection())
                {
                    dBconnect.OpenConnection(connection);

                    var query = @"insert into Courses (CourseID, CourseName, TeacherID, Semester) 
                        values (@CourseID, @CourseName, @TeacherID, @Semester)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@CourseName", courseName);
                        command.Parameters.AddWithValue("TeacherID", teacherID);
                        command.Parameters.AddWithValue("Semester", semester);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding course: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable getCourseList()
        {
            SqlCommand cmd = new SqlCommand("select * from Courses", dBconnect.GetConnection());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            return table;
        }

        public DataTable searchCourse(string searchTerm)
        {
            using (var connection = dBconnect.GetConnection())
            {
                var query = "SELECT * FROM Courses WHERE CourseID LIKE @SearchTerm OR CourseName LIKE @SearchTerm";
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
                        MessageBox.Show($"Error searching course: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return dt;
                }
            }
        }

        public bool updateCourse(string CourseID, string CourseName, string Credits)
        {
            try
            {
                using (var connection = dBconnect.GetConnection())
                {
                    dBconnect.OpenConnection(connection);

                    var query = @"UPDATE Courses 
                                SET CourseName = @CourseName, Credits = @Credits
                                WHERE CourseID = @CourseID
";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@CourseName", CourseName);
                        command.Parameters.AddWithValue("@Credits", Credits);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // return true if at least one row was updated
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating course {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool deleteCourse(string courseID = null, string courseName = null, string Credits = null)
        {
            try
            {
                using (var connection = dBconnect.GetConnection())
                {
                    dBconnect.OpenConnection(connection);

                    var query = "DELETE FROM Courses WHERE 1=1";
                    if (!string.IsNullOrEmpty(courseID))
                    {
                        query += " AND CourseID = @CourseID";
                    }
                    if (!string.IsNullOrEmpty(courseName))
                    {
                        query += " AND CourseName = @CourseName";
                    }

                    using (var command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(courseID))
                        {
                            command.Parameters.AddWithValue("@CourseID", courseID);
                        }
                        if (!string.IsNullOrEmpty(courseName))
                        {
                            command.Parameters.AddWithValue("@CourseName", courseName);
                        }

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting course: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataTable SearchCourse(string searchTerm)
        {
            using (var connection = dBconnect.GetConnection())
            {
                var query = "SELECT * FROM Courses WHERE CourseID LIKE @SearchTerm OR CourseName LIKE @SearchTerm";
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
                        MessageBox.Show($"Error searching course: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return dt;
                }
            }
        }
    }
}
