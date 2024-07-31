using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

/////////////////////////////////////////////////////
///
/// Linq Test và Entity Framework cho class Course and Score Form
/// Thay thế các đoạn mã sử dụng SqlConnection và SqlCommand, SqlAdapter bằng các truy vấn Linq
/// 
/////////////////////////////////////////////////////

namespace WinFormsApp1
{
    public partial class LinqTest : Form
    {
        private readonly StudentContext _context;

        public LinqTest(StudentContext context)
        {
            InitializeComponent();
            _context = context;
            LoadCourseList();
            GetStudentList();
        }

        private void LinqTest_Load(object sender, EventArgs e)
        {

        }

        private void LoadCourseList()
        {
            // lấy danh sách các khóa học vào combo box bằng linq
            var courses = _context.Courses.ToList();
            cbb_course_list.DisplayMember = "CourseName";
            cbb_course_list.ValueMember = "CourseID";
            cbb_course_list.DataSource = courses;
        }

        public class StudentListViewModel
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string Address { get; set; }
        }



        private void GetStudentList()
        {
            var students = _context.Students.ToList();

            var viewModel = students.Select(e => new StudentListViewModel
            {
                StudentID = e.StudentID,
                Name = e.Name,
                DateOfBirth = e.DateOfBirth,
                Gender = e.Gender,
                Address = e.Address,
            }).ToList();
            dgv_test_std_list.DataSource = new BindingList<StudentListViewModel>(viewModel);
        }

        // cấu hình hiển thị cho data grid view chỉ hiển thị StudentID, Name và Score
        public class StudentScoreViewModel
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public decimal? Score { get; set; } // Thay đổi kiểu dữ liệu thành string để dễ dàng xử lý giá trị null
        }


        private void GetStudentScoreByCourse(int courseId)
        {
            var enrollments = _context.Scores
                .Where(e => e.CourseID == courseId)
                .Include(e => e.Student)
                .ToList();

            var viewModel = enrollments.Select(e => new StudentScoreViewModel
            {
                StudentID = e.StudentID,
                Name = e.Student.Name,
                Score = e.Score
            }).ToList();

            dgv_score.DataSource = new BindingList<StudentScoreViewModel>(viewModel);

            /*dgv_score.DataSource = enrollments.Select(e => new
            {
                e.Student.StudentID,
                e.Student.Name,
                e.Score,
            }).ToList();*/
        }

        private void cbb_course_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_course_list != null)
            {
                int courseID = (int)cbb_course_list.SelectedValue;
                tb_course_id.Text = courseID.ToString();
                GetStudentScoreByCourse(courseID);
            }
        }

        private void dgv_score_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgv_score.Columns["Score"].ReadOnly = false;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_score.Rows[e.RowIndex];
                int studentID = Convert.ToInt32(row.Cells["StudentID"].Value);
                int courseID = (int)cbb_course_list.SelectedValue;

                if (decimal.TryParse(row.Cells["Score"].Value?.ToString(), out decimal score))
                {
                    var scores = _context.Scores
                        .FirstOrDefault(e => e.StudentID == studentID && e.CourseID == courseID);

                    if (scores != null)
                    {
                        scores.Score = score;
                    }
                    else
                    {
                        _context.Scores.Add(new Enrollment
                        {
                            StudentID = studentID,
                            CourseID = courseID,
                            Score = score
                        });
                    }
                    _context.SaveChanges();
                }
            }
        }

        private void dgv_score_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgv_score.CurrentRow != null)
            {
                int col = dgv_score.CurrentCell.ColumnIndex;
                int row = dgv_score.CurrentCell.RowIndex;
                if (col < dgv_score.ColumnCount - 1)
                {
                    dgv_score.CurrentCell = dgv_score[col + 1, row];
                }
                else if (row < dgv_score.ColumnCount - 1)
                {
                    dgv_score.CurrentCell = dgv_score[0, row + 1];
                }
                e.Handled = true;
            }
        }

        private void dgv_test_std_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Xóa nội dung của các TextBox
                tb_std_id.Text = string.Empty;
                tb_std_name.Text = string.Empty;

                // Kiểm tra nếu nhấp vào một hàng hợp lệ
                if (e.RowIndex >= 0)
                {
                    // Lấy hàng được chọn
                    DataGridViewRow row = dgv_test_std_list.Rows[e.RowIndex];

                    // Kiểm tra nếu cột "StudentID" và "Name" tồn tại
                    if (row.Cells["StudentID"] != null && row.Cells["Name"] != null)
                    {
                        // Cập nhật giá trị cho các TextBox
                        tb_std_id.Text = row.Cells["StudentID"].Value?.ToString() ?? string.Empty;
                        tb_std_name.Text = row.Cells["Name"].Value?.ToString() ?? string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // event handler add a course to a student
        private void bt_add_Click(object sender, EventArgs e)
        {
            int courseID = int.Parse(tb_course_id.Text);
            int studentID = int.Parse(tb_std_id.Text);

            var enrollment = new Enrollment()
            {
                CourseID = courseID,
                StudentID = studentID,
            };

            _context.Scores.Add(enrollment);
            _context.SaveChanges();

            GetStudentScoreByCourse(courseID);
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
