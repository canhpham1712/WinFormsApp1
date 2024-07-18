using Guna.UI2.WinForms;
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
    public partial class EnrollmentForm : Form
    {
        private readonly EnrollmentClass enrollmentClass;

        public EnrollmentForm()
        {
            InitializeComponent();
            enrollmentClass = new EnrollmentClass();

            LoadEnrollments();
            guna2DataGridView_Enrollments.EditMode = DataGridViewEditMode.EditOnEnter;
            guna2DataGridView_Enrollments.CellEndEdit += guna2DataGridView_Enrollments_CellEndEdit;
        }


        private void guna2DataGridView_Enrollments_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Save the data to the database when editing is finished
            SaveDataToDatabase(e.RowIndex);
        }

        private void SaveDataToDatabase(int rowIndex)
        {
            // Get the data from the DataGridView
            var row = guna2DataGridView_Enrollments.Rows[rowIndex];
            string courseID = row.Cells["CourseID"].Value?.ToString();
            string cycleID = row.Cells["CycleID"].Value?.ToString();
            string studentID = row.Cells["StudentID"].Value?.ToString();
            DateTime enrollmentDate = DateTime.Now; // or get from another cell if necessary

            if (!string.IsNullOrEmpty(courseID) && !string.IsNullOrEmpty(cycleID) && !string.IsNullOrEmpty(studentID))
            {
                // Check if the enrollment already exists
                bool exists = enrollmentClass.EnrollmentExists(courseID, cycleID, studentID);

                if (exists)
                {
                    // Update the existing enrollment
                    bool success = enrollmentClass.UpdateEnrollment(courseID, cycleID, studentID, enrollmentDate);
                    if (success)
                    {
                        MessageBox.Show("Enrollment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update enrollment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Add a new enrollment
                    bool success = enrollmentClass.AddEnrollment(courseID, cycleID, studentID, enrollmentDate);
                    if (success)
                    {
                        MessageBox.Show("Enrollment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to add enrollment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }




        private void LoadEnrollments()
        {
            DataTable enrollments = enrollmentClass.GetEnrollments();
            if (enrollments != null)
            {
                guna2DataGridView_Enrollments.DataSource = enrollments;
                guna2DataGridView_Enrollments.AutoGenerateColumns = true;
            }
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
            {

            }

            private void button_Add_Click(object sender, EventArgs e)
            {
                string courseID = textBox_CourseID.Text;
                string cycleID = textBox_CycleID.Text;
                string studentID = textBox_StudentID.Text;
                DateTime enrollmentDate = DateTime.Now;
                if (enrollmentClass.AddEnrollment(courseID, cycleID, studentID, enrollmentDate))
                {
                    MessageBox.Show("Enrollment added successfully.", "Add Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEnrollments();
                }
                else
                {
                    MessageBox.Show("Error adding enrollment.", "Add Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void button_Delete_Click(object sender, EventArgs e)
            {
                string courseID = textBox_CourseID.Text;
                string cycleID = textBox_CycleID.Text;
                string studentID = textBox_StudentID.Text;

                if (enrollmentClass.DeleteEnrollment(courseID, cycleID, studentID))
                {
                    MessageBox.Show("Enrollment deleted successfully.", "Delete Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEnrollments();
                }
                else
                {
                    MessageBox.Show("Error deleting enrollment.", "Delete Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void button_Update_Click(object sender, EventArgs e)
            {
                string courseID = textBox_CourseID.Text;
                string cycleID = textBox_CycleID.Text;
                string studentID = textBox_StudentID.Text;
                DateTime enrollmentDate = DateTime.Now; // You can replace this with a DateTimePicker control if you want to choose the date

                if (enrollmentClass.UpdateEnrollment(courseID, cycleID, studentID, enrollmentDate))
                {
                    MessageBox.Show("Enrollment updated successfully.", "Update Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadEnrollments();
                }
                else
                {
                    MessageBox.Show("Error updating enrollment.", "Update Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void button_Search_Click(object sender, EventArgs e)
            {

            }

            private void button_Clear_Click(object sender, EventArgs e)
            {
                textBox_CourseID.Clear();
                textBox_CycleID.Clear();
                textBox_search.Clear();
                textBox_StudentID.Clear();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                String searchTerm = textBox_search.Text;

                DataTable enrollments = enrollmentClass.SearchEnrollment(searchTerm);
                if (enrollments != null)
                {
                    guna2DataGridView_Enrollments.DataSource = enrollments;
                }
                else
                {
                    MessageBox.Show("No enrollments found.", "Search Enrollments", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    } 
