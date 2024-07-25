namespace WinFormsApp1
{
    partial class NewCourseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button_searchCourse = new Button();
            textBox_searchCourse = new TextBox();
            label_courses = new Label();
            button_addCourse = new Button();
            label1 = new Label();
            textBox_courseID = new TextBox();
            textBox_courseName = new TextBox();
            label_courseName = new Label();
            textBox_teacherID = new TextBox();
            label2 = new Label();
            button_clearCourse = new Button();
            guna2DataGridView_Course = new Guna.UI2.WinForms.Guna2DataGridView();
            textBox_semester = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_Course).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button_searchCourse);
            panel1.Controls.Add(textBox_searchCourse);
            panel1.Controls.Add(label_courses);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 62);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button_searchCourse
            // 
            button_searchCourse.Anchor = AnchorStyles.Top;
            button_searchCourse.FlatStyle = FlatStyle.Flat;
            button_searchCourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_searchCourse.ForeColor = Color.White;
            button_searchCourse.Location = new Point(546, 20);
            button_searchCourse.Name = "button_searchCourse";
            button_searchCourse.Size = new Size(94, 29);
            button_searchCourse.TabIndex = 2;
            button_searchCourse.Text = "Search";
            button_searchCourse.UseVisualStyleBackColor = true;
            button_searchCourse.Click += button_searchCourse_Click;
            // 
            // textBox_searchCourse
            // 
            textBox_searchCourse.Anchor = AnchorStyles.Top;
            textBox_searchCourse.Location = new Point(272, 21);
            textBox_searchCourse.Name = "textBox_searchCourse";
            textBox_searchCourse.Size = new Size(217, 27);
            textBox_searchCourse.TabIndex = 1;
            // 
            // label_courses
            // 
            label_courses.AutoSize = true;
            label_courses.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_courses.ForeColor = Color.White;
            label_courses.Location = new Point(22, 12);
            label_courses.Name = "label_courses";
            label_courses.Size = new Size(192, 37);
            label_courses.TabIndex = 0;
            label_courses.Text = "New Course";
            // 
            // button_addCourse
            // 
            button_addCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_addCourse.BackColor = Color.MidnightBlue;
            button_addCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_addCourse.ForeColor = Color.White;
            button_addCourse.Location = new Point(800, 551);
            button_addCourse.Name = "button_addCourse";
            button_addCourse.Size = new Size(120, 40);
            button_addCourse.TabIndex = 2;
            button_addCourse.Text = "Add";
            button_addCourse.UseVisualStyleBackColor = false;
            button_addCourse.Click += button_addCourse_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(98, 395);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 3;
            label1.Text = "Course ID : ";
            // 
            // textBox_courseID
            // 
            textBox_courseID.Anchor = AnchorStyles.Bottom;
            textBox_courseID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_courseID.Location = new Point(242, 392);
            textBox_courseID.Name = "textBox_courseID";
            textBox_courseID.Size = new Size(125, 32);
            textBox_courseID.TabIndex = 4;
            // 
            // textBox_courseName
            // 
            textBox_courseName.Anchor = AnchorStyles.Bottom;
            textBox_courseName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_courseName.Location = new Point(242, 457);
            textBox_courseName.Name = "textBox_courseName";
            textBox_courseName.Size = new Size(281, 32);
            textBox_courseName.TabIndex = 6;
            // 
            // label_courseName
            // 
            label_courseName.Anchor = AnchorStyles.Bottom;
            label_courseName.AutoSize = true;
            label_courseName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_courseName.ForeColor = SystemColors.Highlight;
            label_courseName.Location = new Point(58, 460);
            label_courseName.Name = "label_courseName";
            label_courseName.Size = new Size(163, 23);
            label_courseName.TabIndex = 5;
            label_courseName.Text = "Course Name : ";
            // 
            // textBox_teacherID
            // 
            textBox_teacherID.Anchor = AnchorStyles.Bottom;
            textBox_teacherID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_teacherID.Location = new Point(242, 517);
            textBox_teacherID.Name = "textBox_teacherID";
            textBox_teacherID.Size = new Size(125, 32);
            textBox_teacherID.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(125, 520);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 7;
            label2.Text = "Credits : ";
            // 
            // button_clearCourse
            // 
            button_clearCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearCourse.BackColor = Color.MidnightBlue;
            button_clearCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clearCourse.ForeColor = Color.White;
            button_clearCourse.Location = new Point(646, 551);
            button_clearCourse.Name = "button_clearCourse";
            button_clearCourse.Size = new Size(120, 40);
            button_clearCourse.TabIndex = 9;
            button_clearCourse.Text = "Clear";
            button_clearCourse.UseVisualStyleBackColor = false;
            button_clearCourse.Click += button_clearCourse_Click;
            // 
            // guna2DataGridView_Course
            // 
            guna2DataGridView_Course.AllowUserToAddRows = false;
            guna2DataGridView_Course.AllowUserToDeleteRows = false;
            guna2DataGridView_Course.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView_Course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView_Course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView_Course.BackgroundColor = Color.Gainsboro;
            guna2DataGridView_Course.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView_Course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView_Course.ColumnHeadersHeight = 24;
            guna2DataGridView_Course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView_Course.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView_Course.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_Course.Location = new Point(12, 68);
            guna2DataGridView_Course.Name = "guna2DataGridView_Course";
            guna2DataGridView_Course.RowHeadersVisible = false;
            guna2DataGridView_Course.RowHeadersWidth = 51;
            guna2DataGridView_Course.RowTemplate.Height = 80;
            guna2DataGridView_Course.SelectionMode = DataGridViewSelectionMode.CellSelect;
            guna2DataGridView_Course.Size = new Size(908, 273);
            guna2DataGridView_Course.TabIndex = 36;
            guna2DataGridView_Course.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView_Course.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView_Course.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView_Course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView_Course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView_Course.ThemeStyle.BackColor = Color.Gainsboro;
            guna2DataGridView_Course.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_Course.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView_Course.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView_Course.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_Course.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView_Course.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView_Course.ThemeStyle.HeaderStyle.Height = 24;
            guna2DataGridView_Course.ThemeStyle.ReadOnly = false;
            guna2DataGridView_Course.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView_Course.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView_Course.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_Course.ThemeStyle.RowsStyle.ForeColor = SystemColors.Highlight;
            guna2DataGridView_Course.ThemeStyle.RowsStyle.Height = 80;
            guna2DataGridView_Course.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_Course.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // textBox_semester
            // 
            textBox_semester.Anchor = AnchorStyles.Bottom;
            textBox_semester.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_semester.Location = new Point(438, 517);
            textBox_semester.Name = "textBox_semester";
            textBox_semester.Size = new Size(125, 32);
            textBox_semester.TabIndex = 37;
            textBox_semester.Click += textBox_semester_Click;
            // 
            // NewCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(textBox_semester);
            Controls.Add(guna2DataGridView_Course);
            Controls.Add(button_clearCourse);
            Controls.Add(textBox_teacherID);
            Controls.Add(label2);
            Controls.Add(textBox_courseName);
            Controls.Add(label_courseName);
            Controls.Add(textBox_courseID);
            Controls.Add(label1);
            Controls.Add(button_addCourse);
            Controls.Add(panel1);
            Name = "NewCourseForm";
            Text = "CoursesForm";
            Load += CoursesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_Course).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label_courses;
        private Button button_addCourse;
        private Label label1;
        private TextBox textBox_courseID;
        private TextBox textBox_courseName;
        private Label label_courseName;
        private TextBox textBox_teacherID;
        private Label label2;
        private Button button_searchCourse;
        private TextBox textBox_searchCourse;
        private Button button_clearCourse;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Course;
        private TextBox textBox_semester;
    }
}