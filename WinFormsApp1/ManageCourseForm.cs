using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ManageCourseForm : Form
    {
        public readonly string connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        CourseClass course = new CourseClass();

        public ManageCourseForm()
        {
            InitializeComponent();
            LoadClasses();

            //button_updateCourse.Click += button_updateCourse_Click;
            //button_deleteCourse.Click += button_deleteCourse_Click;
        }

        private void LoadClasses()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetAllClasses", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                guna2ComboBox_Classes.DisplayMember = "ClassName";
                guna2ComboBox_Classes.ValueMember = "ClassID";
                guna2ComboBox_Classes.DataSource = dataTable;
            }
        }

        private void comboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (guna2ComboBox_Classes.SelectedValue != null)
            {
                int classID = (int)guna2ComboBox_Classes.SelectedValue;
                LoadStudentInClass(classID);
            }
        }

        private void LoadStudentInClass(int classID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetStudentsInClass", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("ClassID", classID);
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                guna2DataGridView_manaCourse.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int classID = (int)guna2ComboBox_Classes.SelectedValue;
            int studentID = int.Parse(textBox_studentID.Text);

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("AddStudentToClass", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("ClassID", classID);
                command.Parameters.AddWithValue("StudentID", studentID);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadStudentInClass(classID);
        }

        private void button_deleteCourse_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView_manaCourse.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Xóa học sinh đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    int classID = (int)guna2ComboBox_Classes.SelectedValue;
                    int studentID = (int)guna2DataGridView_manaCourse.SelectedRows[0].Cells["StudentID"].Value;

                    using (var connection = new SqlConnection(connectionString))
                    {
                        var command = new SqlCommand("RemoveStudentFromClass", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("ClassID", classID);
                        command.Parameters.AddWithValue("StudentID", studentID);
                        connection.Open(); command.ExecuteNonQuery();
                        connection.Close();
                    }
                    LoadStudentInClass(classID);
                }
            }
            else
            {
                MessageBox.Show("Chọn học sinh để xóa.", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            
        }






        /*

        private void button_clearCourse_Click(object sender, EventArgs e)
        {
            textBox_ManaCourseID.Clear();
            textBox_manaCourseName.Clear();
            textBox_manaCredits.Clear();
        }

        private void button_updateCourse_Click(object sender, EventArgs e)
        {
            // Update course
            string courseID = textBox_ManaCourseID.Text;
            string courseName = textBox_manaCourseName.Text;
            string Credits = textBox_manaCredits.Text; 

            if (verify())
            {
                try
                { 
                    if (course.updateCourse(courseID, courseName, Credits))
                    {
                        MessageBox.Show("Course information updated.", "Update course.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty field.", "Update course.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_deleteCourse_Click(object sender, EventArgs e)
        {
            string courseID = textBox_ManaCourseID.Text;
            string courseName = textBox_manaCourseName.Text;

            if (string.IsNullOrEmpty(courseID) && string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please provide at least one identifier (ID, Course Name).", "Delete course.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (course.deleteCourse(courseID, courseName))
            {
                MessageBox.Show("Course deleted successfully.", "Delete course.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showTable();
            }
            else
            {
                MessageBox.Show("No student found with the provided information.", "Delete Student.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_manaSearchCourse_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox_manaSearchCourse.Text;
            DataTable dt = course.SearchCourse(searchTerm);
            if (dt.Rows.Count > 0)
            {
                guna2DataGridView_manaCourse.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No course found.", "Search course.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showTable()
        {
            guna2DataGridView_manaCourse.DataSource = course.getCourseList();
        }

        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_ManaCourseID.Text) ||
                string.IsNullOrWhiteSpace(textBox_manaCourseName.Text) ||
                string.IsNullOrWhiteSpace(textBox_manaCredits.Text))
            {
                return false;
            }
            return true;
        }*/
    }
}
