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
        StudentClass student = new StudentClass(); // object for take method from Student Class

        public ManageStudentForm()
        {
            InitializeComponent();
            InitializeAddressControls();
            button_update.Click += button_update_Click;
            button_manaStdSearch.Click += button_manaStdSearch_Click;
            button_delete.Click += button_delete_Click;
        }

        private void InitializeAddressControls()
        {
            // demo data for demonstration purposes
            var nations = new List<string> { "Việt Nam", "United States", "United Kingdom" };
            var provinces = new Dictionary<string, List<string>>
            {
                {"Việt Nam", new List<string>{"Hà Nội", "Hải Phòng", "Hồ Chí Minh"}},
                {"United States", new List<string>{"Texas", "Florida"}},
                {"United Kingdom", new List<string>{"Liverpool", "London"}}
            };

            comboBox_nation.Items.AddRange(nations.ToArray());
            comboBox_nation.SelectedIndexChanged += (s, e) =>
            {
                var selectedNation = comboBox_nation.SelectedItem.ToString();
                combobox_city.Items.Clear();
                combobox_district.Items.Clear();
                combobox_ward.Items.Clear();
                combobox_city.Items.AddRange(provinces[selectedNation].ToArray());
            };

            var districts = new Dictionary<string, List<string>>
            {
                {"Hà Nội", new List<string>{"Ba Đình", "Tây Hồ", "Hai Bà Trưng"} },
                {"Hồ Chí Minh", new List<string>{"District 1", "District 2", "District 3" }},
                {"Hải Phòng", new List<string>{"Hải Châu", "Sơn Trà" }}
            };
            combobox_city.SelectedIndexChanged += (s, e) =>
            {
                var selectedProvinces = combobox_city.SelectedItem.ToString();
                combobox_district.Items.Clear();
                combobox_ward.Items.Clear();
                if (districts.ContainsKey(selectedProvinces))
                {
                    combobox_district.Items.AddRange(districts[selectedProvinces].ToArray());
                }
            };

            var communes = new Dictionary<string, List<string>>
            {
                {"Ba Đình", new List<string>{"Điện Biên", "Đội Cấn", "Giảng Võ"} },
                {"Tây Hồ", new List<string>{"Nhật Tân", "Quảng An", "Thụy Khuê"} },
                {"Hai Bà Trưng", new List<string>{"Bách Khoa", "Bạch Đằng", "Bạch Mai"} }
            };
            combobox_district.SelectedIndexChanged += (s, e) =>
            {
                var selectedDistricts = combobox_district.SelectedItem.ToString();
                combobox_ward.Items.Clear();
                if (communes.ContainsKey(selectedDistricts))
                {
                    combobox_ward.Items.AddRange(communes[selectedDistricts].ToArray());
                }
            };
        }

        private void InitializeCustomComboBox()
        {
            var autoCompleteSource = new AutoCompleteStringCollection();
            autoCompleteSource.AddRange(new string[] { "Vietnam", "USA", "Canada" });

            comboBox_nation.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_nation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox_nation.AutoCompleteCustomSource = autoCompleteSource;
        }

        private void Guna2ComboBox_Districts_SelectedIndexChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_manaStdClear_Click(object sender, EventArgs e)
        {
            textBox_manaStdID.Clear();
            textBox_Name.Clear();
            textBox_DoB.Clear();
            textbox_street.Clear();

            // Change the radio button to male status
            radioButton_manaStdFemale.Checked = false;
            radioButton_manaStdMale.Checked = true;

            //comboBox_nation.SelectedIndex = -1;
            comboBox_nation.Text = string.Empty;
            combobox_city.Text = string.Empty;
            combobox_city.Items.Clear();
            combobox_district.Text = string.Empty;
            combobox_district.Items.Clear();
            combobox_ward.Text = string.Empty;
            combobox_ward.Items.Clear();
        }

        bool verify()
        {
            return !string.IsNullOrWhiteSpace(textBox_Name.Text) &&
                    !string.IsNullOrWhiteSpace(textBox_DoB.Text) &&
                    comboBox_nation.SelectedItem != null &&
                    combobox_city.SelectedItem != null &&
                    combobox_district.SelectedItem != null &&
                    combobox_ward.SelectedItem != null &&
                    !string.IsNullOrWhiteSpace(textbox_street.Text);
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
            if (guna2DataGridView_manaStd.Columns["Address"] != null)
            {
                guna2DataGridView_manaStd.Columns["Address"].HeaderText = "Địa chỉ";
            }
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
                    string nation = comboBox_nation.SelectedItem.ToString();
                    string city = combobox_city.SelectedItem.ToString();
                    string district = combobox_district.SelectedItem.ToString();
                    string commune = combobox_ward.SelectedItem.ToString();
                    string street = textbox_street.Text;
                    string address = $"{street}, {commune}, {district}, {city}, {nation}";

                    // Ensure the address is handled even if some fields are empty
                    if (student.updateStudent(studentID, name, dob, gender, address))
                    {
                        MessageBox.Show("Cập nhật thành công.", "Cập nhật thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                var confirmResult = MessageBox.Show("Are you sure to remove this student?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
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
            }
            else
            {
                MessageBox.Show("Please provide a valid student ID.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox_manaStdID.Clear();
            textBox_Name.Clear();
            textBox_DoB.Clear();
            textbox_street.Clear();

            // Change the radio button to male status
            radioButton_manaStdFemale.Checked = false;
            radioButton_manaStdMale.Checked = true;

            //comboBox_nation.SelectedIndex = -1;
            comboBox_nation.Items.Clear();
            combobox_district.Items.Clear();
            combobox_city.Items.Clear();
            combobox_ward.Items.Clear();
            InitializeAddressControls();
        }

        private void button_addStd_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                string name = textBox_Name.Text;
                string dob = textBox_DoB.Text;
                string gender = radioButton_manaStdMale.Checked ? "Nam" : "Nữ";

                string nation = comboBox_nation.SelectedItem.ToString();
                string city = combobox_city.SelectedItem.ToString();
                string district = combobox_district.SelectedItem.ToString();
                string commune = combobox_ward.SelectedItem.ToString();
                string street = textbox_street.Text;

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

        private void guna2DataGridView_manaStd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox_nation.Text = string.Empty;
            combobox_city.Text = string.Empty;
            combobox_district.Text = string.Empty;
            combobox_ward.Text = string.Empty;
            textbox_street.Text = string.Empty;
            textBox_manaStdID.Text = string.Empty;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = guna2DataGridView_manaStd.Rows[e.RowIndex]; // lấy dữ liệu trong 1 hàng của 1 bảng để tương tác

                // Set text boxes
                textBox_Name.Text = row.Cells["Name"].Value.ToString(); // chọn cột Name trong hàng đã đc chọn và chuyển về dạng string

                // hàm if ktra có thể chuyển ngày sinh ko, nếu có thì 
                if (DateOnly.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateOnly dob)) // chuyển đổi giá trị trong cột ngày sinh thành 
                {                                                                                   // dạng string, sau đó chuyển sang dạng DateOnly
                    textBox_DoB.Text = dob.ToString("dd/MM/yyyy");                                  // sau đó lưu trong biến dob nếu thành công
                    // nếu chuyển được thì đưa vào textbox với dạng string chuyển từ kiểu DateOnly
                } 
                
                // fill radio button giới tính
                string gender = row.Cells["Gender"].Value.ToString(); // chuyển giá trị trong cột Gender thành string và gán gtri vào biến gender
                radioButton_manaStdMale.Checked = gender == "Nam"; // syntax cho ktra liệu giá trị gender là Nam thì sẽ được checked và ngược lại
                radioButton_manaStdFemale.Checked = gender == "Nữ";

                textBox_manaStdID.Text = row.Cells["StudentID"].Value.ToString(); // textbox StudentID được nhận dữ liệu ID 

                // Extract address
                string address = row.Cells["Address"].Value.ToString(); // vẫn lấy giá trị của ô address trong datagridview, chuyển về string và lưu vào biến address
                string[] addressComponents = address.Split(',').Select(c => c.Trim()).ToArray();
                // phân chia chuỗi address thành các phẩn ngăn cách bởi dấu phảy. 
                // Clear combo boxes
                comboBox_nation.SelectedIndex = -1;
                combobox_city.SelectedIndex = -1;
                combobox_district.SelectedIndex = -1;
                combobox_ward.SelectedIndex = -1;
                textbox_street.Text = string.Empty;

                // Address contains street
                textbox_street.Text = addressComponents[0];
                comboBox_nation.Text = addressComponents[4];
                combobox_city.Text = addressComponents[3];
                combobox_district.Text = addressComponents[2];
                combobox_ward.Text = addressComponents[1];
            }
        }

        private void guna2DataGridView_manaStd_Click(object sender, EventArgs e)
        {

        }

        private void ManageStudentForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
