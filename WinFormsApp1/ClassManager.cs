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
using Guna.UI2.WinForms;

public class ClassManager
{
    private string connectionString;

    public ClassManager(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void LoadClasses(Guna2ComboBox comboBox)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("GetAllClasses", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                using (var reader = command.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    comboBox.DataSource = dt;
                    comboBox.DisplayMember = "ClassName";
                    comboBox.ValueMember = "ClassID";
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading classes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public DataTable GetStudentsByClass(int classID)
    {
        DataTable dt = new DataTable();
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("GetStudentsByClass", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@ClassID", classID);

                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return dt;
    }

    public bool AddStudentToClass(int classID, int studentID)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("AddStudentToClass", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@ClassID", classID);
                command.Parameters.AddWithValue("@StudentID", studentID);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error adding student to class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public bool DeleteStudentFromClass(int studentID)
    {
        try
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var command = new SqlCommand("DeleteStudentFromClass", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@StudentID", studentID);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error deleting student from class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}