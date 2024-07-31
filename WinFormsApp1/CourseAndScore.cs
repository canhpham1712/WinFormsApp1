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
using Dapper;

namespace WinFormsApp1
{
    public partial class CourseAndScore : Form
    {

        private readonly string connectionString = "Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public CourseAndScore()
        {
            InitializeComponent();
            LoadCourseList();
            GetStudentList();
            //GetStudentAndScoreByCourse(courseID);
        }

        private void CourseAndScore_Load(object sender, EventArgs e)
        {

        }

        private void LoadCourseList()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetAllCourse", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                cbb_course_name_list.DisplayMember = "CourseName";
                cbb_course_name_list.ValueMember = "CourseID";
                cbb_course_name_list.DataSource = dataTable;
            }
        }

        private void GetStudentList()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Students", connection);
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgv_student_list.DataSource = dataTable;
            }
        }

        private void GetStudentAndScoreByCourse(int courseID)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("GetStudentsByCourse", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@CourseID", courseID);
                var adapter = new SqlDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgv_score.DataSource = dataTable;
            }
        }

        private void cbb_course_name_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_course_name_list != null)
            {
                int courseID = (int)cbb_course_name_list.SelectedValue;
                txtb_course_id.Text = courseID.ToString();
                GetStudentAndScoreByCourse(courseID);
            }
        }

        private void btn_add_to_course_Click(object sender, EventArgs e)
        {
            try
            {
                int courseID = int.Parse(txtb_course_id.Text);
                int studentID = int.Parse(txtb_selected_id.Text);

                using (var connection = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("RegisterCourse", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@studentID", studentID);
                    cmd.Parameters.AddWithValue("@courseID", courseID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                GetStudentAndScoreByCourse(courseID);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Học sinh được chọn không hợp lệ hoặc học sinh được chọn đã có môn học này.", "Thêm học sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                if (txtb_selected_id.Text == string.Empty)
                {
                    MessageBox.Show("Chọn 1 học sinh trong danh sách để thêm môn học.", "Thêm môn học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"Lỗi thêm học sinh : {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Xóa 1 môn học cho học sinh dựa vào học sinh và môn học được chọn
        private void btn_delete_from_course_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Xóa môn học này cho học sinh?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int courseID = int.Parse(txtb_course_id.Text);
                int studentID = int.Parse(txtb_selected_id.Text);

                using (var connection = new SqlConnection(connectionString))
                {
                    var cmd = new SqlCommand("UnregisterCourse", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@StudentID", studentID);
                    cmd.Parameters.AddWithValue("@CourseID", courseID);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                GetStudentAndScoreByCourse(courseID);
            }
        }

        private void dgv_score_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dgv_score.Rows[e.RowIndex];
                int studentID = Convert.ToInt32(row.Cells["StudentID"].Value);
                int courseID = (int)cbb_course_name_list.SelectedValue;

                // Check if the Score cell is not empty and contains a valid decimal value
                if (decimal.TryParse(row.Cells["Score"].Value?.ToString(), out decimal score))
                {
                    using (var connection = new SqlConnection(connectionString))
                    {
                        var command = new SqlCommand("IF EXISTS (SELECT 1 FROM Scores WHERE StudentID = @studentID AND CourseID = @courseID) " +
                                                     "UPDATE Scores SET Score = @score WHERE StudentID = @studentID AND CourseID = @courseID " +
                                                     "ELSE " +
                                                     "INSERT INTO Scores (StudentID, CourseID, Score) VALUES (@studentID, @courseID, @score)", connection);
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@courseID", courseID);
                        command.Parameters.AddWithValue("@score", score);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }

            }
        }

        private void dgv_score_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgv_score.CurrentRow != null)
            {
                // Move to the next cell
                int col = dgv_score.CurrentCell.ColumnIndex;
                int row = dgv_score.CurrentCell.RowIndex;
                if (col < dgv_score.ColumnCount - 1)
                {
                    dgv_score.CurrentCell = dgv_score[col + 1, row];
                }
                else if (row < dgv_score.RowCount - 1)
                {
                    dgv_score.CurrentCell = dgv_score[0, row + 1];
                }
                e.Handled = true;
            }
        }

        private void dgv_student_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_selected_id.Text = string.Empty;
            txtb_selected_name.Text = string.Empty;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_student_list.Rows[e.RowIndex];
                txtb_selected_name.Text = row.Cells["Name"].Value.ToString();
                txtb_selected_id.Text = row.Cells["StudentID"].Value.ToString();
            }
        }

        private void dgv_score_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtb_selected_id.Text = string.Empty;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_score.Rows[e.RowIndex];
                txtb_selected_id.Text = row.Cells["StudentID"].Value.ToString();

            }
        }
    }
}
