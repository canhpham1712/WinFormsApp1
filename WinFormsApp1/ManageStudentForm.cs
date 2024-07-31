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
using System.Data.OleDb;
using Microsoft.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class ManageStudentForm : Form
    {
        StudentClass student = new StudentClass(); // object for take method from Student Class
        private Form activeForm = null;
        private readonly string connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        public ManageStudentForm()
        {
            InitializeComponent();
            InitializeAddressControls();
            LoadClasses();
            //LoadTop10Students();
            // thêm data vào combo box danh sách lớp
            //cmb_class_list = new ComboBox();
            //this.Controls.Add(cmb_class_list);
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

                cmb_class_list.DisplayMember = "ClassName";
                cmb_class_list.ValueMember = "ClassID";
                cmb_class_list.DataSource = dataTable;
            }
        }

        // load dữ liệu cột tên lớp vào combo box
        private void cmb_class_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_class_list.SelectedValue != null)
            {
                txtb_class_id_sys.Text = cmb_class_list.SelectedValue.ToString(); // cập nhật textbox với ClassID đã chọn
                int classID = (int)cmb_class_list.SelectedValue; // lấy class id đã được chọn và load học sinh trong class id
                LoadStudentsInClass(classID);
            }
        }

        private void LoadStudentsInClass(int classID)
        {
            using (var connection = new SqlConnection(connectionString)) // tạo 1 kết nối sql mới
            {
                // tạo 1 lệnh sql để thực thi procedure
                var cmd = new SqlCommand("GetStudentsInClass", connection)
                {
                    CommandType = CommandType.StoredProcedure // cụ thể hóa kiểu lệnh là stored procedure
                };
                cmd.Parameters.AddWithValue("@ClassID", classID);
                var adapter = new SqlDataAdapter(cmd); // tạo 1 adapter để thực thi lệnh và fill DataTable
                var data_table = new DataTable(); // tạo 1 data_table để giữ kết quả
                adapter.Fill(data_table); // fill data table bằng kết quả của lệnh

                dtgrid_class.DataSource = data_table;
            }
        }

        private void InitializeAddressControls()
        {
            // dữ liệu giả định demo
            var nations = new List<string> { "Việt Nam", "United States", "United Kingdom" };
            var provinces = new Dictionary<string, List<string>>
            {
                {"Việt Nam", new List<string>{"Hà Nội", "Hải Phòng", "Hồ Chí Minh", "Nam Định"}},
                {"United States", new List<string>{"Texas", "Florida"}},
                {"United Kingdom", new List<string>{"Liverpool", "London"}}
            };

            comboBox_nation.Items.AddRange(nations.ToArray());
            comboBox_nation.SelectedIndexChanged += (s, e) =>
            {
                if (comboBox_nation.SelectedItem != null)
                {
                    var selectedNation = comboBox_nation.SelectedItem.ToString();
                    combobox_city.Items.Clear();
                    combobox_district.Items.Clear();
                    combobox_ward.Items.Clear();

                    if (provinces.ContainsKey(selectedNation))
                    {
                        combobox_city.Items.AddRange(provinces[selectedNation].ToArray());
                    }
                }
            };

            var districts = new Dictionary<string, List<string>>
            {
                {"Hà Nội", new List<string>{"Ba Đình", "Tây Hồ", "Hai Bà Trưng"} },
                {"Hồ Chí Minh", new List<string>{"Quận 1", "Quận 2", "Quận 3" }},
                {"Hải Phòng", new List<string>{"Hải Châu", "Sơn Trà" }},
                {"Nam Định", new List<string>{"Ý Yên", "Xuân Trường", "Hải Hậu"} },
                {"Texas", new List<string>{"Houston", "Dallas", "Austin", "San Antonio" } },
                {"Florida", new List<string>{ "Miami", "Orlando", "Tampa", "Jacksonville" } },
                {"Liverpool", new List<string>{"City Centre", "Anfield", "Everton", "Toxteth"}},
                {"London", new List<string>{"Camden", "Greenwich", "Hackney", "Islington", "Kensington"}}

            };
            combobox_city.SelectedIndexChanged += (s, e) =>
            {
                if (combobox_city.SelectedItem != null)
                {
                    var selectedProvinces = combobox_city.SelectedItem.ToString();
                    combobox_district.Items.Clear();
                    combobox_ward.Items.Clear();

                    if (districts.ContainsKey(selectedProvinces))
                    {
                        combobox_district.Items.AddRange(districts[selectedProvinces].ToArray());
                    }
                }
            };

            var communes = new Dictionary<string, List<string>>
            {
                {"Ba Đình", new List<string>{"Điện Biên", "Đội Cấn", "Giảng Võ"} },
                {"Tây Hồ", new List<string>{"Nhật Tân", "Quảng An", "Thụy Khuê"} },
                {"Hai Bà Trưng", new List<string>{"Bách Khoa", "Bạch Đằng", "Bạch Mai"} },
                {"Quận 1", new List<string>{"Bến Nghé", "Cô Giang", "Đa Kao" } },
                {"Quận 2", new List<string>{"An Khánh", "An Phú", "Bình An"} },
                {"Quận 3", new List<string>{"Phường 1", "Phường 2", "Võ Thị Sáu"} },
                {"Hải Châu", new List<string>{"Bình Hiên", "Bình Thuận", "Thạch Trang"} },
                {"Sơn Trà", new List<string>{"Thọ Quang", "Mân Thái", "Phước Mỹ"} },
                {"Ý Yên", new List<string>{"Thị trấn Lâm", "Hồng Quang", "Phú Hưng"} },
                {"Xuân Trường", new List<string>{"Thọ Nghiệp", "Trà Lũ","Xuân Châu"} },
                {"Hải Hậu", new List<string>{"Hải Anh", "Hải Đường", "Thị trấn Yên Định"} },
                {"Houston", new List<string>{"Downtown", "Midtown", "Montrose", "The Heights", "River Oaks"}},
                {"Dallas", new List<string>{"Downtown", "Uptown", "Deep Ellum", "Oak Lawn", "Bishop Arts District"}},
                {"Austin", new List<string>{"Downtown", "South Congress", "East Austin", "West Campus", "Hyde Park"}},
                {"San Antonio", new List<string>{"Downtown", "Alamo Heights", "King William", "Stone Oak", "The Dominion"}},
                {"Miami", new List<string>{"Downtown", "Little Havana", "Wynwood", "Coconut Grove", "Coral Gables"}},
                {"Orlando", new List<string>{"Downtown", "Winter Park", "Lake Nona", "Baldwin Park", "Dr. Phillips"}},
                {"Tampa", new List<string>{"Downtown", "Ybor City", "Hyde Park", "Channelside", "Seminole Heights"}},
                {"Jacksonville", new List<string>{"Downtown", "Riverside", "San Marco", "Southside", "Arlington"}},
                {"City Centre", new List<string>{"Central", "Commercial", "Residential"}},
                {"Anfield", new List<string>{"Anfield Road", "Walton Breck", "Rockfield"}},
                {"Everton", new List<string>{"Prince Edwin", "Islington", "Netherfield"}},
                {"Toxteth", new List<string>{"Smithdown", "Dingle", "Sefton Park"}},
                {"Camden", new List<string>{"Camden Town", "Kentish Town", "Regent's Park"}},
                {"Greenwich", new List<string>{"Greenwich Town", "Woolwich", "Blackheath"}},
                {"Hackney", new List<string>{"Hackney Central", "Shoreditch", "Stamford Hill"}},
                {"Islington", new List<string>{"Angel", "Barnsbury", "Holloway"}},
                {"Kensington", new List<string>{"South Kensington", "West Kensington", "North Kensington"}}
            };
            combobox_district.SelectedIndexChanged += (s, e) =>
            {
                if (combobox_district.SelectedItem != null)
                {
                    var selectedDistricts = combobox_district.SelectedItem.ToString();
                    combobox_ward.Items.Clear();

                    if (communes.ContainsKey(selectedDistricts))
                    {
                        combobox_ward.Items.AddRange(communes[selectedDistricts].ToArray());
                    }
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

        private void ManageStudentForm_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void Button_addStd_Click(object sender, EventArgs e)
        {
            if (verify())
            {
                string name = textBox_Name.Text;
                string dob = textBox_DoB.Text;
                string gender = radioButton_manaStdMale.Checked ? "Nam" : "Nữ";

                string nation = comboBox_nation.Text.ToString();
                string city = combobox_city.Text.ToString();
                string district = combobox_district.Text.ToString();
                string commune = combobox_ward.Text.ToString();
                string street = textbox_street.Text;

                if (student.InsertStudent(name, dob, gender, nation, city, district, commune, street))
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

        private void guna2DataGridView_manaStd_CellClick(object sender, DataGridViewCellEventArgs e)
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
                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob)) // chuyển đổi giá trị trong cột ngày sinh thành 
                {                                                                                   // dạng string, sau đó chuyển sang dạng DateOnly
                    DateOnly date = DateOnly.FromDateTime(dob);
                    textBox_DoB.Text = date.ToString("dd/MM/yyyy");                                  // sau đó lưu trong biến dob nếu thành công
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
                comboBox_nation.SelectedIndex = -1; // đặt các combo box về trạng thái chưa chọn
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

        private void button_update_Click_1(object sender, EventArgs e)
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
                    string nation = comboBox_nation.Text.ToString();
                    string city = combobox_city.Text.ToString();
                    string district = combobox_district.Text.ToString();
                    string commune = combobox_ward.Text.ToString();
                    string street = textbox_street.Text;
                    string address = $"{street}, {commune}, {district}, {city}, {nation}";

                    // Ensure the address is handled even if some fields are empty
                    if (student.UpdateStudent(studentID, name, dob, gender, address))
                    {
                        showTable();
                        int class_id = int.Parse(txtb_class_id_sys.Text);
                        LoadStudentsInClass(class_id);
                        MessageBox.Show("Cập nhật thành công.", "Cập nhật học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công.", "Cập nhật học sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}", "Cập nhật học sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Điền đủ thông tin hoặc nhấn vào học sinh để cập nhật.", "Cập nhật học sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_delete_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_manaStdID.Text, out int studentID))
            {
                var confirmResult = MessageBox.Show("Xóa học sinh này khỏi danh sách?",
                                                     "Xóa học sinh",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    if (student.DeleteStudent(studentID))
                    {
                        MessageBox.Show("Đã xóa học sinh khỏi danh sách.", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showTable();
                        int class_id = int.Parse(txtb_class_id_sys.Text);
                        LoadStudentsInClass(class_id);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy học sinh như yêu cầu.", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nhấp vào học sinh cần xóa.", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            textBox_manaStdID.Clear();
            textBox_Name.Clear();
            textBox_DoB.Clear();
            textbox_street.Clear();

            // Change the radio button to male status
            radioButton_manaStdFemale.Checked = false;
            radioButton_manaStdMale.Checked = true;

            comboBox_nation.Text = string.Empty;
            combobox_district.Text = string.Empty;
            combobox_city.Text = string.Empty;
            combobox_ward.Text = string.Empty;
        }

        private void bt_add_to_class_Click(object sender, MouseEventArgs e)
        {
            try
            {
                int classID = int.Parse(txtb_class_id_sys.Text); // lấy id của lớp 
                int studentID = int.Parse(textBox_manaStdID.Text); // lấy id học sinh 

                using (var connection = new SqlConnection(connectionString)) // sử dụng procedure để add hs với id hiện tại vào lớp có id tương ứng
                {
                    var cmd = new SqlCommand("AddStudentToClass", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@ClassID", classID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                LoadStudentsInClass(classID);
                MessageBox.Show("Thêm học sinh thành công.", "Thêm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Học sinh đã có trong lớp học.", "Thêm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm học sinh : {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_from_class_Click(object sender, MouseEventArgs e)
        {
            var result = MessageBox.Show($"Xóa học sinh khỏi lớp học?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int class_id = int.Parse(txtb_class_id_sys.Text);
                int student_id = int.Parse(textBox_manaStdID.Text);

                using (var connection = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("RemoveStudentFromClass", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@ClassID", class_id);
                    cmd.Parameters.AddWithValue("@StudentID", student_id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                showTable();
                LoadStudentsInClass(class_id);
                MessageBox.Show("Đã xóa học sinh khỏi lớp học.", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CourseAndScore CourseAndScore = new CourseAndScore();
            CourseAndScore.Show();
        }

        private void dtgrid_class_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            combobox_city.Text = string.Empty;
            comboBox_nation.Text = string.Empty;
            combobox_district.Text = string.Empty;
            combobox_ward.Text = string.Empty;
            textbox_street.Text = string.Empty;
            textBox_manaStdID.Text = string.Empty;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgrid_class.Rows[e.RowIndex];

                textBox_Name.Text = row.Cells["Name"].Value.ToString();

                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob))
                {
                    DateOnly date = DateOnly.FromDateTime(dob);
                    textBox_DoB.Text = date.ToString("dd/MM/yyyy");
                }

                string gender = row.Cells["Gender"].Value.ToString();
                radioButton_manaStdMale.Checked = gender == "Nam";
                radioButton_manaStdFemale.Checked = gender == "Nữ";

                textBox_manaStdID.Text = row.Cells["StudentID"].Value.ToString();

                string address = row.Cells["Address"].Value.ToString(); // vẫn lấy giá trị của ô address trong datagridview, chuyển về string và lưu vào biến address
                string[] addressComponents = address.Split(',').Select(c => c.Trim()).ToArray();
                // phân chia chuỗi address thành các phẩn ngăn cách bởi dấu phảy. 
                // Clear combo boxes
                comboBox_nation.SelectedIndex = -1; // đặt các combo box về trạng thái chưa chọn
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

        private void button_manaStdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchStudents();
            }
        }

        private void SearchByLevel(object sender, EventArgs e)
        {
            SearchStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStudents();
        }

        private void SearchStudents()
        {
            string studentName = txtb_search_by_name.Text.Trim();
            string studyLevel = cbb_search_by_level.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(studentName))
            {
                SearchStudentByName(studentName);
            }
            else if (!string.IsNullOrEmpty(studyLevel))
            {
                SearchStudentByLevel();
            }
            else
            {
                LoadTop10Students();
            }
        }

        private void SearchStudentByName(string studentName)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SearchStudentByName", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@studentName", studentName);
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView_manaStd.DataSource = dataTable;
            }
        }

        private void SearchStudentByLevel()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SearchStudentByLevel", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                string studyLevel = cbb_search_by_level.Text.ToString();
                command.Parameters.AddWithValue("@studyLevel", studyLevel);
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView_manaStd.DataSource = dataTable;
            }
        }

        private void LoadTop10Students()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("DisplayTop10Students", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                guna2DataGridView_manaStd.DataSource = dataTable;
            }
        }

        private void cbb_search_by_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_search_by_level.SelectedItem != null)
            {
                string studyLevel = cbb_search_by_level.SelectedItem.ToString();
                LoadStudentsByLevel(studyLevel);
            }
        }
        private void LoadStudentsByLevel(string studyLevel)
        {
            using (var connection = new SqlConnection(connectionString)) // tạo 1 kết nối sql mới
            {
                // tạo 1 lệnh sql để thực thi procedure
                var cmd = new SqlCommand("SearchStudentByLevel", connection)
                {
                    CommandType = CommandType.StoredProcedure // cụ thể hóa kiểu lệnh là stored procedure
                };
                cmd.Parameters.AddWithValue("@studyLevel", studyLevel);
                var adapter = new SqlDataAdapter(cmd); // tạo 1 adapter để thực thi lệnh và fill DataTable
                var data_table = new DataTable(); // tạo 1 data_table để giữ kết quả
                adapter.Fill(data_table); // fill data table bằng kết quả của lệnh

                guna2DataGridView_manaStd.DataSource = data_table;
            }
        }
    }
}
