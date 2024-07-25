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
using Guna.UI2.WinForms.Internal;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Xml.Serialization;
using System.Globalization;

namespace WinFormsApp1
{
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass();
        private const string PlaceholderText = "dd/mm/yyyy";
        private const string PlaceholderName = "Nhập họ và tên";
        private const string PlaceholderAddress = "Nhập địa chỉ thường trú";

        public ManageStudentForm()
        {
            InitializeComponent();
            InitializeAddressControls();
            InitializeTextBoxPlaceholder();
            InitializeTextBoxPlaceholderName();
            button_update.Click += button_update_Click;
            button_manaStdSearch.Click += button_manaStdSearch_Click;
            button_delete.Click += button_delete_Click;

            //guna2ComboBox_Nations.SelectedIndex = 0;
            // Handle click out of text box
            this.Click += Form_CLick;
            guna2DataGridView_manaStd.CellClick += guna2DataGridView_manaStd_CellClick;
        }

        private void InitializeAddressControls()
        {
            // Dummy data for demonstration purposes
            var nations = new List<string> { "Việt Nam", "United States", "United Kingdom" };
            var provinces = new Dictionary<string, List<string>>
            {
                {"Việt Nam", new List<string>{"Hà Nội", "Hải Phòng", "Hồ Chí Minh"}},
                {"United States", new List<string>{"Texas", "Florida"}},
                {"United Kingdom", new List<string>{"Liverpool", "London"}}
            };

            guna2ComboBox_Nations.Items.AddRange(nations.ToArray());
            guna2ComboBox_Nations.SelectedIndexChanged += (s, e) =>
            {
                var selectedNation = guna2ComboBox_Nations.SelectedItem.ToString();
                guna2ComboBox_CitiesOrProvinces.Items.Clear();
                guna2ComboBox_Districts.Items.Clear();
                guna2ComboBox_WardsOrCommunes.Items.Clear();
                guna2ComboBox_CitiesOrProvinces.Items.AddRange(provinces[selectedNation].ToArray());
            };

            var districts = new Dictionary<string, List<string>>
            {
                {"Hà Nội", new List<string>{"Ba Đình", "Tây Hồ", "Hai Bà Trưng"} },
                {"Hồ Chí Minh", new List<string>{"District 1", "District 2", "District 3" }},
                {"Hải Phòng", new List<string>{"Hải Châu", "Sơn Trà" }}
            };
            guna2ComboBox_CitiesOrProvinces.SelectedIndexChanged += (s, e) =>
            {
                var selectedProvinces = guna2ComboBox_CitiesOrProvinces.SelectedItem.ToString();
                guna2ComboBox_Districts.Items.Clear();
                guna2ComboBox_WardsOrCommunes.Items.Clear();
                if (districts.ContainsKey(selectedProvinces))
                {
                    guna2ComboBox_Districts.Items.AddRange(districts[selectedProvinces].ToArray());
                }
            };

            var communes = new Dictionary<string, List<string>>
            {
                {"Ba Đình", new List<string>{"Điện Biên", "Đội Cấn", "Giảng Võ"} },
                {"Tây Hồ", new List<string>{"Nhật Tân", "Quảng An", "Thụy Khuê"} },
                {"Hai Bà Trưng", new List<string>{"Bách Khoa", "Bạch Đằng", "Bạch Mai"} }
            };
            guna2ComboBox_Districts.SelectedIndexChanged += (s, e) =>
            {
                var selectedDistricts = guna2ComboBox_Districts.SelectedItem.ToString();
                guna2ComboBox_WardsOrCommunes.Items.Clear();
                if (communes.ContainsKey(selectedDistricts))
                {
                    guna2ComboBox_WardsOrCommunes.Items.AddRange(communes[selectedDistricts].ToArray());
                }
            };
        }

        private (string street, string nation, string city, string district, string commune) ExtractAddressComponents(string address)
        {
            string[] addressParts = address.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                           .Select(part => part.Trim())
                                           .ToArray();

            string street = addressParts.Length > 0 ? addressParts[0] : string.Empty;
            string commune = addressParts.Length > 1 ? addressParts[1] : string.Empty;
            string district = addressParts.Length > 2 ? addressParts[2] : string.Empty;
            string city = addressParts.Length > 3 ? addressParts[3] : string.Empty;
            string nation = addressParts.Length > 4 ? addressParts[4] : string.Empty;

            return (street, nation, city, district, commune);
        }

        // Cell click event handler
        private void guna2DataGridView_manaStd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2ComboBox_Nations.Items.Clear();
            guna2ComboBox_Districts.Items.Clear();
            guna2ComboBox_CitiesOrProvinces.Items.Clear();
            guna2ComboBox_WardsOrCommunes.Items.Clear();
            InitializeAddressControls();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView_manaStd.Rows[e.RowIndex];

                // Set text boxes
                textBox_manaStdID.Text = row.Cells["StudentID"].Value.ToString();
                textBox_Name.Text = row.Cells["Name"].Value.ToString();

                // Format DateOfBirth cell value to "dd/MM/yyyy"
                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob))
                {
                    textBox_DoB.Text = dob.ToString("dd/MM/yyyy");
                }

                // Set gender
                string gender = row.Cells["Gender"].Value.ToString();
                radioButton_manaStdMale.Checked = gender == "Nam";
                radioButton_manaStdFemale.Checked = gender == "Nữ";

                // Extract address
                string address = row.Cells["Address"].Value.ToString();
                string[] addressComponents = address.Split(',').Select(c => c.Trim()).ToArray();

                // Clear combo boxes
                guna2ComboBox_Nations.SelectedIndex = -1;
                guna2ComboBox_CitiesOrProvinces.SelectedIndex = -1;
                guna2ComboBox_Districts.SelectedIndex = -1;
                guna2ComboBox_WardsOrCommunes.SelectedIndex = -1;
                guna2TextBox_Street.Text = string.Empty;

                // Populate address components
                if (addressComponents.Length == 5)
                {
                    // Address contains street
                    guna2TextBox_Street.Text = addressComponents[0];
                    guna2ComboBox_Nations.SelectedItem = addressComponents[1];
                    guna2ComboBox_CitiesOrProvinces.SelectedItem = addressComponents[2];
                    guna2ComboBox_Districts.SelectedItem = addressComponents[3];
                    guna2ComboBox_WardsOrCommunes.SelectedItem = addressComponents[4];
                }
                else if (addressComponents.Length == 4)
                {
                    // Address does not contain street
                    guna2ComboBox_Nations.SelectedItem = addressComponents[0];
                    guna2ComboBox_CitiesOrProvinces.SelectedItem = addressComponents[1];
                    guna2ComboBox_Districts.SelectedItem = addressComponents[2];
                    guna2ComboBox_WardsOrCommunes.SelectedItem = addressComponents[3];
                }
            }
        }

        private void InitializeCustomComboBox()
        {
            var autoCompleteSource = new AutoCompleteStringCollection();
            autoCompleteSource.AddRange(new string[] { "Vietnam", "USA", "Canada" });

            guna2ComboBox_Nations.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            guna2ComboBox_Nations.AutoCompleteSource = AutoCompleteSource.CustomSource;
            guna2ComboBox_Nations.AutoCompleteCustomSource = autoCompleteSource;
        }
        private void Guna2ComboBox_Districts_SelectedIndexChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InitializeTextBoxPlaceholder()
        {
            // Set the initial placeholder text
            textBox_DoB.Text = PlaceholderText;
            textBox_DoB.ForeColor = Color.Gray; // Placeholder text color
            textBox_DoB.Enter += TextBox_DoB_Enter;
            textBox_DoB.Leave += TextBox_DoB_Leave;
        }

        private void InitializeTextBoxPlaceholderName()
        {
            textBox_Name.Text = PlaceholderName;
            textBox_Name.ForeColor = Color.Gray;
            textBox_Name.Enter += TextBox_Name_Enter;
            textBox_Name.Leave += TextBox_Name_Leave;
        }


        private void TextBox_Name_Enter(object sender, EventArgs e)
        {
            // Clear placeholder text when the user focuses on the textbox
            if (textBox_Name.Text == PlaceholderName)
            {
                textBox_Name.Text = "";
                textBox_Name.ForeColor = Color.Black;
            }
        }

        private void TextBox_Name_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if the textbox is empty
            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                textBox_Name.Text = PlaceholderName;
                textBox_Name.ForeColor = Color.Gray;
            }
        }

       

        private void TextBox_DoB_Enter(object sender, EventArgs e)
        {
            // Clear placeholder text when the user focuses on the textbox
            if (textBox_DoB.Text == PlaceholderText)
            {
                textBox_DoB.Text = "";
                textBox_DoB.ForeColor = Color.Black; // Text color for user input
            }
        }

        private void TextBox_DoB_Leave(object sender, EventArgs e)
        {
            // Restore placeholder text if the textbox is empty
            if (string.IsNullOrWhiteSpace(textBox_DoB.Text))
            {
                textBox_DoB.Text = PlaceholderText;
                textBox_DoB.ForeColor = Color.Gray; // Placeholder text color
            }
        }
        private void button_manaStdClear_Click(object sender, EventArgs e)
        {
            textBox_manaStdID.Clear();
            textBox_Name.Clear();
            textBox_DoB.Clear();
            guna2TextBox_Street.Clear();

            // Change the radio button to male status
            radioButton_manaStdFemale.Checked = false;
            radioButton_manaStdMale.Checked = true;

            //guna2ComboBox_Nations.SelectedIndex = -1;
            guna2ComboBox_Nations.Items.Clear();
            guna2ComboBox_Districts.Items.Clear();
            guna2ComboBox_CitiesOrProvinces.Items.Clear();
            guna2ComboBox_WardsOrCommunes.Items.Clear();
            InitializeAddressControls();

            // Redisplay the blur format for the date of birth
            InitializeTextBoxPlaceholder();
            InitializeTextBoxPlaceholderName();
        }

        bool verify()
        {
            bool isValid = true;

            // Check if name is filled
            isValid = !string.IsNullOrWhiteSpace(textBox_Name.Text) && textBox_Name.Text != PlaceholderName;

            // Check if Date of Birth is filled and valid
            if (isValid)
            {
                isValid = !string.IsNullOrWhiteSpace(textBox_DoB.Text) && textBox_DoB.Text != PlaceholderText;

                // Optionally validate the Date of Birth format
                if (isValid && !DateTime.TryParseExact(textBox_DoB.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
                {
                    isValid = false;
                }
            }

            // Check if gender is selected
            if (isValid)
            {
                isValid = radioButton_manaStdMale.Checked || radioButton_manaStdFemale.Checked;
            }

            // Check if address fields are filled in order
            if (isValid)
            {
                isValid = !string.IsNullOrWhiteSpace(guna2ComboBox_Nations.SelectedItem?.ToString()) &&
                          !string.IsNullOrWhiteSpace(guna2ComboBox_CitiesOrProvinces.SelectedItem?.ToString()) &&
                          !string.IsNullOrWhiteSpace(guna2ComboBox_Districts.SelectedItem?.ToString()) &&
                          !string.IsNullOrWhiteSpace(guna2ComboBox_WardsOrCommunes.SelectedItem?.ToString());
            }

            return isValid;
        }


        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void showTable()
        {
            guna2DataGridView_manaStd.DataSource = student.getStudentList();
            if (guna2DataGridView_manaStd.Columns["StudentID"] != null)
            {
                guna2DataGridView_manaStd.Columns["StudentID"].Visible = false;
            }
            if (guna2DataGridView_manaStd.Columns["Name"] != null)
            {
                guna2DataGridView_manaStd.Columns["Name"].HeaderText = "Họ và tên";
            }
            if (guna2DataGridView_manaStd.Columns["DateOfBirth"] != null)
            {
                guna2DataGridView_manaStd.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
                guna2DataGridView_manaStd.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            if (guna2DataGridView_manaStd.Columns["Gender"] != null)
            {
                guna2DataGridView_manaStd.Columns["Gender"].HeaderText = "Giới tính";
            }        
        }

        private void Form_CLick (object sender, EventArgs e)
        {
            this.ActiveControl = null;
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
            if (verify())
            {
                try
                {
                    int studentID = int.Parse(textBox_manaStdID.Text);
                    string name = textBox_Name.Text;
                    string dob = textBox_DoB.Text;
                    string gender = radioButton_manaStdMale.Checked ? "Nam" : "Nữ";

                    // Handle address components, allowing for optional fields
                    string nation = guna2ComboBox_Nations.SelectedItem != null ? guna2ComboBox_Nations.SelectedItem.ToString() : string.Empty;
                    string city = guna2ComboBox_CitiesOrProvinces.SelectedItem != null ? guna2ComboBox_CitiesOrProvinces.SelectedItem.ToString() : string.Empty;
                    string district = guna2ComboBox_Districts.SelectedItem != null ? guna2ComboBox_Districts.SelectedItem.ToString() : string.Empty;
                    string commune = guna2ComboBox_WardsOrCommunes.SelectedItem != null ? guna2ComboBox_WardsOrCommunes.SelectedItem.ToString() : string.Empty;
                    string street = guna2TextBox_Street.Text;

                    // Ensure the address is handled even if some fields are empty
                    if (student.updateStudent(studentID, name, dob, gender, nation, city, district, commune, street))
                    {
                        MessageBox.Show("Student information updated.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update student information.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button_delete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_manaStdID.Text, out int studentID))
            {
                if (student.deleteStudent(studentID))
                {
                    MessageBox.Show("Student deleted successfully.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                }
                else
                {
                    MessageBox.Show("No student found with the provided information.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please provide a valid student ID.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_addStd_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                string name = textBox_Name.Text;
                string dob = textBox_DoB.Text;
                string gender = radioButton_manaStdMale.Checked ? "Nam" : "Nữ";

                string nation = guna2ComboBox_Nations.SelectedItem != null ? guna2ComboBox_Nations.SelectedItem.ToString() : string.Empty;
                string city = guna2ComboBox_CitiesOrProvinces.SelectedItem != null ? guna2ComboBox_CitiesOrProvinces.SelectedItem.ToString() : string.Empty;
                string district = guna2ComboBox_Districts.SelectedItem != null ? guna2ComboBox_Districts.SelectedItem.ToString() : string.Empty;
                string commune = guna2ComboBox_WardsOrCommunes.SelectedItem != null ? guna2ComboBox_WardsOrCommunes.SelectedItem.ToString() : string.Empty;
                string street = guna2TextBox_Street.Text;

                if (student.insertStudent(name, dob, gender, nation, city, district, commune, street))
                {
                    MessageBox.Show("Đã thêm học sinh.", "Thêm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    showTable();
                }
            }
            else
            {
                MessageBox.Show("Nhập đủ các thông tin học sinh.", "Thêm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
