using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing.Text;
using Microsoft.Identity.Client;
using System.Data;

namespace WinFormsApp1
{
    public class StudentClass
    {
        private readonly DBConnect dBConnect; // database connection string

        public StudentClass()
        {
            this.dBConnect = new DBConnect();
        }

        public bool insertStudent(string StdID, string fname, string lname, DateTime bdate, string phone, string email, string gender, string address, byte[] img)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = @"INSERT INTO Students (StudentID, Email, BirthDate, PhoneNo, StudentFirstName, StudentLastName, Gender, Address, Image) 
                          VALUES (@StudentID, @Email, @BirthDate, @PhoneNo, @StudentFirstName, @StudentLastName, @Gender, @Address, @Image)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", StdID);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@BirthDate", bdate);
                        command.Parameters.AddWithValue("@PhoneNo", phone);
                        command.Parameters.AddWithValue("@StudentFirstName", fname);
                        command.Parameters.AddWithValue("@StudentLastName", lname);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Image", img);

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


        public DataTable getStudentList()
        {
            SqlCommand cmd = new SqlCommand("select * from Students", dBConnect.GetConnection());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adap.Fill(table);
            return table; 
        }

        public DataTable searchStudent(string searchTerm)
        {
            using (var connection = dBConnect.GetConnection())
            {
                var query = "SELECT * FROM Students WHERE StudentID LIKE @SearchTerm OR StudentFirstName LIKE @SearchTerm OR StudentLastName LIKE @SearchTerm";
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
                        MessageBox.Show($"Error searching student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return dt;
                }
            }
        }

        public bool updateStudent(string StdID, string fname, string lname, DateTime bdate, string phone, string email, string gender, string address, byte[] img)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = @"UPDATE Students 
                                  SET Email = @Email, BirthDate = @BirthDate, PhoneNo = @PhoneNo, 
                                      StudentFirstName = @StudentFirstName, StudentLastName = @StudentLastName, 
                                      Gender = @Gender, Address = @Address, Image = @Image 
                                  WHERE StudentID = @StudentID";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StudentID", StdID);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@BirthDate", bdate);
                        command.Parameters.AddWithValue("@PhoneNo", phone);
                        command.Parameters.AddWithValue("@StudentFirstName", fname);
                        command.Parameters.AddWithValue("@StudentLastName", lname);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@Image", img);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0; // return true if at least one row was updated
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool deleteStudent(string studentID = null, string firstName = null, string lastName = null)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var query = "DELETE FROM Students WHERE 1=1";
                    if (!string.IsNullOrEmpty(studentID))
                    {
                        query += " AND StudentID = @StudentID";
                    }
                    if (!string.IsNullOrEmpty(firstName))
                    {
                        query += " AND StudentFirstName = @FirstName";
                    }
                    if (!string.IsNullOrEmpty(lastName))
                    {
                        query += " AND StudentLastName = @LastName";
                    }

                    using (var command = new SqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(studentID))
                        {
                            command.Parameters.AddWithValue("@StudentID", studentID);
                        }
                        if (!string.IsNullOrEmpty(firstName))
                        {
                            command.Parameters.AddWithValue("@FirstName", firstName);
                        }
                        if (!string.IsNullOrEmpty(lastName))
                        {
                            command.Parameters.AddWithValue("@LastName", lastName);
                        }

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // function to execute query to count(total, male, female)
        public int GetTotalStudents()
        {
            using (var connection = dBConnect.GetConnection())
            {
                dBConnect.OpenConnection(connection);

                string query = "SELECT COUNT(*) FROM Students";
                using (var command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int GetMaleStudents()
        {
            using (var connection = dBConnect.GetConnection())
            {
                dBConnect.OpenConnection(connection);

                string query = "SELECT COUNT(*) FROM Students WHERE Gender = 'Male'";
                using (var command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }

        public int GetFemaleStudents()
        {
            using (var connection = dBConnect.GetConnection())
            {
                dBConnect.OpenConnection(connection);

                string query = "select count(*) from students where Gender = 'Female'";
                using (var command = new SqlCommand(query, connection))
                {
                    return (int)command.ExecuteScalar();
                }
            }
        }
    }
}
