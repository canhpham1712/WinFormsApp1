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
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public class StudentClass
    {
        private readonly DBConnect dBConnect; // database connection string

        public StudentClass()
        {
            this.dBConnect = new DBConnect();
        }

        // validate dateOfBirth: check if day, month, year are valid, date chosen is in the future or not
        private bool IsValidDate(int day, int month, int year)
        {          
            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 1900 || year > DateTime.Now.Year)
            {
                return false;
            }
            try
            {
                // Create a DateOnly instance for the given date
                var date = new DateTime(year, month, day);

                // Get the current date
                var today = DateTime.Today;

                // Check if the date is in the future
                if (date > today)
                {
                    return false;
                }

                return true;
            }
            catch { return false; }              
        }

        public bool InsertStudent(string name, int day, int month, int year, string gender, string nation, string city, string district, string commune, string street)
        {
            try
            {
                // Regular expression to match Vietnamese characters and basic punctuation
                string vietnameseCharPattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáạảâấầậẩăằắẳẵặãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂƯÔÀẲỰÙỚỜỞỠỢẹẻẽềếễểệỉĩịọỏốồổỗộớờởỡợụủưứừửữựỳỵỷỹ\s,.'-]+$";

                if (!System.Text.RegularExpressions.Regex.IsMatch(name, vietnameseCharPattern))
                {
                    MessageBox.Show("Tên chỉ được chứa ký tự chữ và dấu câu thông thường của tiếng Việt.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }            

                // Replace separators and validate the format
                if (!IsValidDate(day, month, year))
                {
                    MessageBox.Show("Dữ liệu ngày tháng năm sinh không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                DateTime dateOfBirth = new DateTime(year, month, day);

                // Build address string
                var addressParts = new List<string>();
                if (!string.IsNullOrWhiteSpace(street)) addressParts.Add(street);
                if (!string.IsNullOrWhiteSpace(commune)) addressParts.Add(commune);
                if (!string.IsNullOrWhiteSpace(district)) addressParts.Add(district);
                if (!string.IsNullOrWhiteSpace(city)) addressParts.Add(city);
                if (!string.IsNullOrWhiteSpace(nation)) addressParts.Add(nation);

                string address = string.Join(", ", addressParts);

                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);
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
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Học sinh đã có trong danh sách.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            catch (Exception ex)
            { 
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public DataTable SearchStudent(string searchTerm)
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

        public bool UpdateStudent(int studentID, string name, int day, int month, int year, string gender, string address)
        {
            try
            {             
                    // Regular expression to match Vietnamese characters and basic punctuation
                    string vietnameseCharPattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáạảâấầậẩăằắẳẵặãèéêìíòóôõùúũăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂƯÔÀẲỰÙỚỜỞỠỢẹẻẽềếễểệỉĩịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ\s,.'-]+$";

                    if (!System.Text.RegularExpressions.Regex.IsMatch(name, vietnameseCharPattern))
                    {
                        MessageBox.Show("Tên chỉ được chứa ký tự chữ và dấu câu thông thường của tiếng Việt.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!IsValidDate(day, month, year))
                {
                    MessageBox.Show("Dữ liệu ngày tháng năm sinh không hợp lệ.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                DateOnly dateOfBirth = new DateOnly(year, month, day);
                using (var connection = dBConnect.GetConnection())
                {
                    dBConnect.OpenConnection(connection);
                    var command = new SqlCommand("UpdateStudent", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth); // Ensure proper date format
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Address", address);
                       
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;           
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Thông tin trùng khớp với học sinh khác trong lớp học.", "Lỗi cậ nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                MessageBox.Show($"Lỗi khi đang cập nhật: {ex.Message}",
                                "Lỗi cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool DeleteStudent(int studentID)
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
                MessageBox.Show($"Lỗi xóa học sinh: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var command = new SqlCommand("SELECT COUNT(*) FROM Students WHERE Gender = 'Nam'", connection);
                return (int)command.ExecuteScalar();
            }
        }

        public int GetFemaleStudents()
        {
            using (var connection = dBConnect.GetConnection())
            {
                dBConnect.OpenConnection(connection);

                var command = new SqlCommand("SELECT COUNT(*) FROM Students WHERE Gender = 'Nữ'", connection);
                return (int)command.ExecuteScalar();
            }
        }
    }
}
