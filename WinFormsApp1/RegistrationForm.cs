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

    
    public partial class RegistrationForm : Form
    {
        public readonly string connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StdManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        StudentClass student = new StudentClass();
        public RegistrationForm()
        {
            InitializeComponent();
            button_upload.Click += button_upload_Click;
            button_add.Click += button_add_Click;
            button_clear.Click += button_clear_Click;
            button_search.Click += button_search_Click;
        }
        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            // add new student
            string studentID = textBox_ID.Text;
            string firstName = textBox_firstName.Text;
            string lastName = textBox_lastName.Text;
            DateTime birthDate = dateTimePicker1.Value;
            string phoneNo = textBox_phone.Text;
            string address = textBox_address.Text;
            string email = textBox_email.Text;
            string gender = radioButton_male.Checked ? "Male" : "Female";

            // check if student age is less than 10 or more than 100
            int born_year = dateTimePicker1.Value.Year;
            int current_year = DateTime.Now.Year;
            if (born_year > current_year || current_year - born_year < 10 || current_year - born_year > 100)
            {
                MessageBox.Show("The student age should be between 10 and 100.", "Invalid Date of Birth.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {

                    // get the image 
                    MemoryStream ms = new MemoryStream();
                    // memory stream used - in-memory stream of bytes to read or write to data
                    pictureBox_student.Image.Save(ms, pictureBox_student.Image.RawFormat);
                    byte[] img = ms.ToArray();
                    if (student.insertStudent(studentID, firstName, lastName, birthDate, phoneNo, email, gender, address, img))
                    {
                        MessageBox.Show("New student added.", "Add Student.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Empty field.", "Add student.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verify()
        {
            if ((textBox_firstName.Text == "") || (textBox_lastName.Text == "") ||
                (textBox_phone.Text == "") || (textBox_address.Text == "") ||
                (pictureBox_student.Image == null) || (textBox_ID.Text == null) ||
                (textBox_email == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_firstName.Clear(); textBox_lastName.Clear();
            textBox_email.Clear(); textBox_address.Clear();
            textBox_ID.Clear(); textBox_phone.Clear();
            pictureBox_student.Image = null;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            showTable();
        }

        // get student list in datagridview
        private void showTable()
        {
            guna2DataGridView_students.DataSource = student.getStudentList();
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)guna2DataGridView_students.Columns[8];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox_search.Text;
            DataTable dt = student.searchStudent(searchTerm);
            if (dt.Rows.Count > 0) {
                guna2DataGridView_students.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No student found.", "Search Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
