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

namespace WinFormsApp1
{
    public partial class ManageStudentForm : Form
    {
        public readonly string connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StdManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        StudentClass student = new StudentClass();
        public ManageStudentForm()
        {
            InitializeComponent();
            button_upload.Click += button_upload_Click;
            button_update.Click += button_update_Click;
            button_manaStdSearch.Click += button_manaStdSearch_Click;
            button_delete.Click += button_delete_Click;
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_manaStdPhoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button_manaStdClear_Click(object sender, EventArgs e)
        {
            textBox_manaStdID.Clear();
            textBox_manaStdFname.Clear();
            textBox_manaStdLname.Clear();
            textBox_manaStdEmail.Clear();
            textBox_manaStdPhone.Clear();
            textBox_manaStdAddress.Clear();
            pictureBox_manaStdPhoto.Image = null;
        }

        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_manaStdID.Text) ||
                string.IsNullOrWhiteSpace(textBox_manaStdFname.Text) ||
                string.IsNullOrWhiteSpace(textBox_manaStdLname.Text) ||
                string.IsNullOrWhiteSpace(textBox_manaStdEmail.Text) ||
                string.IsNullOrWhiteSpace(textBox_manaStdPhone.Text) ||
                string.IsNullOrWhiteSpace(textBox_manaStdAddress.Text) ||
                pictureBox_manaStdPhoto.Image == null)
            {
                return false;
            }
            return true;
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void showTable()
        {
            guna2DataGridView_manaStd.DataSource = student.getStudentList();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)guna2DataGridView_manaStd.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_manaStdSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox_manaStdSearch.Text;
            DataTable dt = student.searchStudent(searchTerm);
            if (dt.Rows.Count > 0)
            {
                guna2DataGridView_manaStd.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No student found.", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            // Update student
            string studentID = textBox_manaStdID.Text;
            string firstName = textBox_manaStdFname.Text;
            string lastName = textBox_manaStdLname.Text;
            DateTime birthDate = dateTimePicker_manaStdBirthDate.Value;
            string phoneNo = textBox_manaStdPhone.Text;
            string address = textBox_manaStdAddress.Text;
            string email = textBox_manaStdEmail.Text;
            string gender = radioButton_manaStdMale.Checked ? "Male" : "Female";

            if (verify())
            {
                try
                {
                    // Get the image
                    MemoryStream ms = new MemoryStream();
                    pictureBox_manaStdPhoto.Image.Save(ms, pictureBox_manaStdPhoto.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.updateStudent(studentID, firstName, lastName, birthDate, phoneNo, email, gender, address, img))
                    {
                        MessageBox.Show("Student information updated.", "Update Student.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Empty field.", "Update student.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string studentID = textBox_manaStdID.Text;
            string firstName = textBox_manaStdFname.Text;
            string lastName = textBox_manaStdLname.Text;

            if (string.IsNullOrEmpty(studentID) && string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please provide at least one identifier (ID, First Name, or Last Name).", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (student.deleteStudent(studentID, firstName, lastName))
            {
                MessageBox.Show("Student deleted successfully.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showTable();
            }
            else
            {
                MessageBox.Show("No student found with the provided information.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
