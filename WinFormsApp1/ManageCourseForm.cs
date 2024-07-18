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
        public readonly string connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StdManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        CourseClass course = new CourseClass();
        public ManageCourseForm()
        {
            InitializeComponent();
            button_updateCourse.Click += button_updateCourse_Click;
            button_deleteCourse.Click += button_deleteCourse_Click;
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

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
        }
    }
}
