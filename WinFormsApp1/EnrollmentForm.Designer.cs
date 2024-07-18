namespace WinFormsApp1
{
    partial class EnrollmentForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label_CourseID = new Label();
            textBox_CourseID = new TextBox();
            textBox_CycleID = new TextBox();
            label_CycleID = new Label();
            textBox_StudentID = new TextBox();
            label_StudentID = new Label();
            label_EnrollmentDate = new Label();
            dateTimePicker_EnrollmentDate = new DateTimePicker();
            button_Add = new Button();
            button_Clear = new Button();
            button_Delete = new Button();
            button_Update = new Button();
            label_Enrollment = new Label();
            textBox_search = new TextBox();
            button_search = new Button();
            panel1 = new Panel();
            guna2DataGridView_Enrollments = new Guna.UI2.WinForms.Guna2DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_Enrollments).BeginInit();
            SuspendLayout();
            // 
            // label_CourseID
            // 
            label_CourseID.Anchor = AnchorStyles.Bottom;
            label_CourseID.AutoSize = true;
            label_CourseID.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_CourseID.ForeColor = SystemColors.Highlight;
            label_CourseID.Location = new Point(56, 380);
            label_CourseID.Name = "label_CourseID";
            label_CourseID.Size = new Size(123, 23);
            label_CourseID.TabIndex = 21;
            label_CourseID.Text = "Course ID : ";
            // 
            // textBox_CourseID
            // 
            textBox_CourseID.Anchor = AnchorStyles.Bottom;
            textBox_CourseID.Location = new Point(229, 380);
            textBox_CourseID.Name = "textBox_CourseID";
            textBox_CourseID.Size = new Size(129, 27);
            textBox_CourseID.TabIndex = 22;
            // 
            // textBox_CycleID
            // 
            textBox_CycleID.Anchor = AnchorStyles.Bottom;
            textBox_CycleID.Location = new Point(229, 443);
            textBox_CycleID.Name = "textBox_CycleID";
            textBox_CycleID.Size = new Size(129, 27);
            textBox_CycleID.TabIndex = 26;
            // 
            // label_CycleID
            // 
            label_CycleID.Anchor = AnchorStyles.Bottom;
            label_CycleID.AutoSize = true;
            label_CycleID.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_CycleID.ForeColor = SystemColors.Highlight;
            label_CycleID.Location = new Point(66, 443);
            label_CycleID.Name = "label_CycleID";
            label_CycleID.Size = new Size(113, 23);
            label_CycleID.TabIndex = 25;
            label_CycleID.Text = "Cycle ID : ";
            // 
            // textBox_StudentID
            // 
            textBox_StudentID.Anchor = AnchorStyles.Bottom;
            textBox_StudentID.Location = new Point(592, 380);
            textBox_StudentID.Name = "textBox_StudentID";
            textBox_StudentID.Size = new Size(129, 27);
            textBox_StudentID.TabIndex = 28;
            // 
            // label_StudentID
            // 
            label_StudentID.Anchor = AnchorStyles.Bottom;
            label_StudentID.AutoSize = true;
            label_StudentID.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_StudentID.ForeColor = SystemColors.Highlight;
            label_StudentID.Location = new Point(456, 384);
            label_StudentID.Name = "label_StudentID";
            label_StudentID.Size = new Size(126, 23);
            label_StudentID.TabIndex = 27;
            label_StudentID.Text = "Student ID : ";
            // 
            // label_EnrollmentDate
            // 
            label_EnrollmentDate.Anchor = AnchorStyles.Bottom;
            label_EnrollmentDate.AutoSize = true;
            label_EnrollmentDate.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            label_EnrollmentDate.ForeColor = SystemColors.Highlight;
            label_EnrollmentDate.Location = new Point(401, 443);
            label_EnrollmentDate.Name = "label_EnrollmentDate";
            label_EnrollmentDate.Size = new Size(181, 23);
            label_EnrollmentDate.TabIndex = 29;
            label_EnrollmentDate.Text = "Enrollment Date : ";
            // 
            // dateTimePicker_EnrollmentDate
            // 
            dateTimePicker_EnrollmentDate.Anchor = AnchorStyles.Bottom;
            dateTimePicker_EnrollmentDate.Location = new Point(592, 441);
            dateTimePicker_EnrollmentDate.Name = "dateTimePicker_EnrollmentDate";
            dateTimePicker_EnrollmentDate.Size = new Size(243, 27);
            dateTimePicker_EnrollmentDate.TabIndex = 30;
            // 
            // button_Add
            // 
            button_Add.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Add.BackColor = Color.MidnightBlue;
            button_Add.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Add.ForeColor = Color.White;
            button_Add.Location = new Point(800, 551);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(120, 40);
            button_Add.TabIndex = 31;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // button_Clear
            // 
            button_Clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Clear.BackColor = Color.MidnightBlue;
            button_Clear.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = Color.White;
            button_Clear.Location = new Point(422, 551);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(120, 40);
            button_Clear.TabIndex = 32;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Delete
            // 
            button_Delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Delete.BackColor = Color.MidnightBlue;
            button_Delete.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Delete.ForeColor = Color.White;
            button_Delete.Location = new Point(674, 551);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(120, 40);
            button_Delete.TabIndex = 33;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Update
            // 
            button_Update.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_Update.BackColor = Color.MidnightBlue;
            button_Update.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_Update.ForeColor = Color.White;
            button_Update.Location = new Point(548, 551);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(120, 40);
            button_Update.TabIndex = 34;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = false;
            button_Update.Click += button_Update_Click;
            // 
            // label_Enrollment
            // 
            label_Enrollment.AutoSize = true;
            label_Enrollment.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Enrollment.Location = new Point(28, 13);
            label_Enrollment.Name = "label_Enrollment";
            label_Enrollment.Size = new Size(188, 40);
            label_Enrollment.TabIndex = 0;
            label_Enrollment.Text = "Enrollment";
            // 
            // textBox_search
            // 
            textBox_search.Anchor = AnchorStyles.Top;
            textBox_search.Location = new Point(521, 23);
            textBox_search.Name = "textBox_search";
            textBox_search.Size = new Size(229, 27);
            textBox_search.TabIndex = 4;
            // 
            // button_search
            // 
            button_search.Anchor = AnchorStyles.Top;
            button_search.BackColor = Color.MidnightBlue;
            button_search.FlatStyle = FlatStyle.Flat;
            button_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_search.ForeColor = Color.WhiteSmoke;
            button_search.Location = new Point(1064, 19);
            button_search.Name = "button_search";
            button_search.Size = new Size(125, 38);
            button_search.TabIndex = 25;
            button_search.Text = "Search";
            button_search.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button_search);
            panel1.Controls.Add(textBox_search);
            panel1.Controls.Add(label_Enrollment);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 70);
            panel1.TabIndex = 20;
            // 
            // guna2DataGridView_Enrollments
            // 
            guna2DataGridView_Enrollments.AllowUserToAddRows = false;
            guna2DataGridView_Enrollments.AllowUserToDeleteRows = false;
            guna2DataGridView_Enrollments.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.White;
            guna2DataGridView_Enrollments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            guna2DataGridView_Enrollments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView_Enrollments.BackgroundColor = Color.Gainsboro;
            guna2DataGridView_Enrollments.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            guna2DataGridView_Enrollments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            guna2DataGridView_Enrollments.ColumnHeadersHeight = 24;
            guna2DataGridView_Enrollments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            guna2DataGridView_Enrollments.DefaultCellStyle = dataGridViewCellStyle9;
            guna2DataGridView_Enrollments.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_Enrollments.Location = new Point(12, 76);
            guna2DataGridView_Enrollments.Name = "guna2DataGridView_Enrollments";
            guna2DataGridView_Enrollments.RowHeadersVisible = false;
            guna2DataGridView_Enrollments.RowHeadersWidth = 51;
            guna2DataGridView_Enrollments.RowTemplate.Height = 80;
            guna2DataGridView_Enrollments.SelectionMode = DataGridViewSelectionMode.CellSelect;
            guna2DataGridView_Enrollments.Size = new Size(908, 273);
            guna2DataGridView_Enrollments.TabIndex = 35;
            guna2DataGridView_Enrollments.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView_Enrollments.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView_Enrollments.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView_Enrollments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView_Enrollments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView_Enrollments.ThemeStyle.BackColor = Color.Gainsboro;
            guna2DataGridView_Enrollments.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_Enrollments.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView_Enrollments.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView_Enrollments.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_Enrollments.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView_Enrollments.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView_Enrollments.ThemeStyle.HeaderStyle.Height = 24;
            guna2DataGridView_Enrollments.ThemeStyle.ReadOnly = false;
            guna2DataGridView_Enrollments.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView_Enrollments.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView_Enrollments.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_Enrollments.ThemeStyle.RowsStyle.ForeColor = SystemColors.Highlight;
            guna2DataGridView_Enrollments.ThemeStyle.RowsStyle.Height = 80;
            guna2DataGridView_Enrollments.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_Enrollments.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(780, 15);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 33;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // EnrollmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(guna2DataGridView_Enrollments);
            Controls.Add(button_Update);
            Controls.Add(button_Delete);
            Controls.Add(button_Clear);
            Controls.Add(button_Add);
            Controls.Add(dateTimePicker_EnrollmentDate);
            Controls.Add(label_EnrollmentDate);
            Controls.Add(textBox_StudentID);
            Controls.Add(label_StudentID);
            Controls.Add(textBox_CycleID);
            Controls.Add(label_CycleID);
            Controls.Add(textBox_CourseID);
            Controls.Add(label_CourseID);
            Controls.Add(panel1);
            Name = "EnrollmentForm";
            Text = "EnrollmentForm";
            Load += EnrollmentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_Enrollments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_CourseID;
        private TextBox textBox_CourseID;
        private TextBox textBox_CycleID;
        private Label label_CycleID;
        private TextBox textBox_StudentID;
        private Label label_StudentID;
        private Label label_EnrollmentDate;
        private DateTimePicker dateTimePicker_EnrollmentDate;
        private Button button_Add;
        private Button button_Clear;
        private Button button_Delete;
        private Button button_Update;
        private Label label_Enrollment;
        private TextBox textBox_search;
        private Button button_search;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_Enrollments;
        private Button button1;
    }
}