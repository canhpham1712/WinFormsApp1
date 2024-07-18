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
    public partial class NewCourseForm : Form
    {

        public readonly string connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StdManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        CourseClass course = new CourseClass();
        public NewCourseForm()
        {
            InitializeComponent();
            button_addCourse.Click += button_addCourse_Click;
            button_clearCourse.Click += button_clearCourse_Click;
            button_searchCourse.Click += button_searchCourse_Click;
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_addCourse_Click(object sender, EventArgs e)
        {
            // add new course
            string courseID = textBox_courseID.Text;
            string courseName = textBox_courseName.Text;
            string credits = textBox_credits.Text;

            if (verify())
            {
                try
                {
                    if (course.insertCourse(courseID, courseName, credits))
                    {
                        MessageBox.Show("New course added.", "Add course.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showTable()
        {
            guna2DataGridView_Course.DataSource = course.getCourseList();

        }


        bool verify()
        {
            if ((textBox_courseID.Text == "") || (textBox_courseName.Text == "") || (textBox_credits.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_clearCourse_Click(object sender, EventArgs e)
        {
            textBox_courseID.Clear();
            textBox_courseName.Clear();
            textBox_credits.Clear();
        }

        private void button_searchCourse_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox_searchCourse.Text;
            DataTable dt = course.searchCourse(searchTerm);
            if (dt.Rows.Count > 0)
            {
                guna2DataGridView_Course.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No course found.", "Search course.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2DataGridView_Course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
