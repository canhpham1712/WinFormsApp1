using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class ClassesClass
    {
        private readonly DBConnect dBConnect;

        public ClassesClass()
        {
            this.dBConnect = new DBConnect();
        }
        // take student data from classs
        public DataTable getClassList()
        {
            SqlCommand cmd = new SqlCommand("select * from Classes", dBConnect.GetConnection());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            return table;
        }


        public DataTable searchClass(string searchTerm)
        {
            using (var connection = dBConnect.GetConnection())
            {
                var query = "SELECT * FROM Classes WHERE CourseID LIKE @SearchTerm OR ClassNo LIKE @SearchTerm OR TeacherID LIKE @SearchTerm OR CourseName like @CourseName";
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
                        MessageBox.Show($"Error searching class: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return dt;
                }
            }
        }

        public bool updateClass(string CourseID, string CycleID, string ClassNo, string TeacherID, string CourseName)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = @"UPDATE Classes 
                                SET CycleID = @CycleID, ClassNo = @ClassNo, TeacherID = @TeacherID, CourseName = @CourseName
                                WHERE CourseID = @CourseID
";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", CourseID);
                        command.Parameters.AddWithValue("@CycleID", CycleID);
                        command.Parameters.AddWithValue("@ClassNo", ClassNo);
                        command.Parameters.AddWithValue("@TeacherID", TeacherID);
                        command.Parameters.AddWithValue("@CourseName", CourseName);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // return true if at least one row was updated
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating class {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool deleteClass(string courseID = null, string cycleID = null, string classNo = null, string teacherID = null, string courseName = null)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = "DELETE FROM Classes WHERE 1=1";
                    if (!string.IsNullOrEmpty(courseID))
                    {
                        query += " AND CourseID = @CourseID";
                    }
                    if (!string.IsNullOrEmpty(cycleID))
                    {
                        query += " AND CycleID = @CycleID";
                    }
                    if (!string.IsNullOrEmpty(classNo))
                    {
                        query += " AND classNo = @ClassNo";
                    }
                    if (!string.IsNullOrEmpty(teacherID))
                    {
                        query += " AND teacherID = @TeacherID";
                    }
                    if (!string.IsNullOrEmpty(courseName))
                    {
                        query += " AND courseName = @CourseName";
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
                MessageBox.Show($"Error deleting class: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool addClass(string courseID, string cycleID, string classNo, string teacherID, string courseName)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = @"INSERT INTO Classes (CourseID, CycleID, ClassNo, TeacherID, CourseName) 
                                  VALUES (@CourseID, @CycleID, @ClassNo, @TeacherID, @CourseName)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CourseID", courseID);
                        command.Parameters.AddWithValue("@CycleID", cycleID);
                        command.Parameters.AddWithValue("@ClassNo", classNo);
                        command.Parameters.AddWithValue("@TeacherID", teacherID);
                        command.Parameters.AddWithValue("@CourseName", courseName);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding class: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    } 
}
