using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace WinFormsApp1
{
    public class StudentClass
    {
        private readonly DBConnect dBConnect; // database connection string

        public StudentClass()
        {
            this.dBConnect = new DBConnect();
        }

        public bool insertStudent(string name, string dob, string gender, string nation, string city, string district, string commune, string street)
        {
            try
            {
                // Regular expression to match Vietnamese characters and basic punctuation
                string vietnameseCharPattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáạảâấầậẩãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂƯÔÀẲỰÙỚỜỞỠỢẹẻẽềềểệỉĩịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ\s,.'-]+$";

                if (!System.Text.RegularExpressions.Regex.IsMatch(name, vietnameseCharPattern))
                {
                    MessageBox.Show("Tên chỉ được chứa ký tự chữ và dấu câu thông thường của tiếng Việt.", "Sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                using (var connection = dBConnect.GetConnection()) 
                {
                    dBConnect.OpenConnection(connection);

                    DateTime dateOfBirth;
                    // Replace separators and validate the format
                    string cleanedDob = dob.Replace("/", "").Replace("\\", "").Replace("-", "");

                    // Check if the cleaned date string has exactly 8 characters
                    if (cleanedDob.Length != 8 || !int.TryParse(cleanedDob, out int _))
                    {
                        MessageBox.Show("Nhập nhiều hơn 8 ký tự. Hãy bảo đảm nhập đúng định dạng ddMMyyyy hoặc dd/mm/yyyy.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    string day = cleanedDob.Substring(0, 2);
                    string month = cleanedDob.Substring(2, 2);
                    string year = cleanedDob.Substring(4, 4);

                    // Validate day, month, and year
                    if (year.Length != 4 ||
                        !int.TryParse(day, out int d) || !int.TryParse(month, out int m) ||
                        !int.TryParse(year, out int y))
                    {
                        MessageBox.Show("Sai định dạng. Nhập đúng ngày tháng năm hợp lệ.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Ensure day, month and year are valid
                    if (d < 1 || d > 31 || m < 1 || m > 12 || y < 1900 || y > DateTime.Now.Year)
                    {
                        MessageBox.Show("Invalid date values. Ensure the day is between 1 and 31, month is between 1 and 12, and the year is a valid four-digit number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    try
                    {
                        dateOfBirth = new DateTime(y, m, d); // This will throw if the date is invalid
                    }
                    catch
                    {
                        MessageBox.Show("Invalid date. Ensure the date is correct and exists.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    // Build address string
                    var addressParts = new List<string>();
                    if (!string.IsNullOrWhiteSpace(street)) addressParts.Add(street);
                    if (!string.IsNullOrWhiteSpace(commune)) addressParts.Add(commune);
                    if (!string.IsNullOrWhiteSpace(district)) addressParts.Add(district);
                    if (!string.IsNullOrWhiteSpace(city)) addressParts.Add(city);
                    if (!string.IsNullOrWhiteSpace(nation)) addressParts.Add(nation);

                    string address = string.Join(", ", addressParts);

                    // Execute stored procedure
                    var command = new SqlCommand("InsertStudent", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@studentName", name);
                    command.Parameters.AddWithValue("@dob", dateOfBirth);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@address", address);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0; // Return true if at least one row was inserted
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
            using (var connection = dBConnect.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Students", connection);
                var adapter = new SqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataTable searchStudent(string searchTerm)
        {
            using (var connection = dBConnect.GetConnection())
            {
                var command = new SqlCommand("SearchStudentByName", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@studentName", searchTerm);
                var adapter = new SqlDataAdapter(command);
                var dt = new DataTable();
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

        public bool updateStudent(int studentID, string name, string dob, string gender,
    string nation, string city, string district, string commune, string street)
        {
            try
            {
                using (var connection = new SqlConnection("YourConnectionString"))
                {
                    connection.Open();
                    using (var command = new SqlCommand("UpdateStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@StudentID", studentID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@DateOfBirth", dob); // Ensure proper date format
                        command.Parameters.AddWithValue("@Gender", gender);

                        // Handle address fields, allowing for empty values
                        command.Parameters.AddWithValue("@Nation", (object)nation ?? DBNull.Value);
                        command.Parameters.AddWithValue("@City", (object)city ?? DBNull.Value);
                        command.Parameters.AddWithValue("@District", (object)district ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Commune", (object)commune ?? DBNull.Value);
                        command.Parameters.AddWithValue("@Street", (object)street ?? DBNull.Value);

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                MessageBox.Show($"An error occurred while updating student information: {ex.Message}",
                                "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        public bool deleteStudent(int studentID)
        {
            try
            {
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);

                    var command = new SqlCommand("DeleteStudent", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@studentID", studentID);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting student: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Functions to get counts of students
        public int GetTotalStudents()
        {
            using (var connection = dBConnect.GetConnection())
            {
                dBConnect.OpenConnection(connection);

                var command = new SqlCommand("SELECT COUNT(*) FROM Students", connection);
                return (int)command.ExecuteScalar();
            }
        }

        public int GetMaleStudents()
        {
            using (var connection = dBConnect.GetConnection())
            {
                dBConnect.OpenConnection(connection);

                var command = new SqlCommand("SELECT COUNT(*) FROM Students WHERE Gender = 'Male'", connection);
                return (int)command.ExecuteScalar();
            }
        }

        public int GetFemaleStudents()
        {
            using (var connection = dBConnect.GetConnection())
            {
                dBConnect.OpenConnection(connection);

                var command = new SqlCommand("SELECT COUNT(*) FROM Students WHERE Gender = 'Female'", connection);
                return (int)command.ExecuteScalar();
            }
        }
    }
}
