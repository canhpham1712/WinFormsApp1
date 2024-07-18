namespace WinFormsApp1
{
    partial class ManageCourseForm
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
            button_manaSearchCourse = new Button();
            textBox_manaSearchCourse = new TextBox();
            label_ManageCourse = new Label();
            textBox_manaCredits = new TextBox();
            label_manaCredits = new Label();
            textBox_manaCourseName = new TextBox();
            label_manaCourseName = new Label();
            textBox_ManaCourseID = new TextBox();
            label_manaCourseID = new Label();
            button_clearCourse = new Button();
            button_updateCourse = new Button();
            button_deleteCourse = new Button();
            guna2DataGridView_manaCourse = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_manaCourse).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(button_manaSearchCourse);
            panel1.Controls.Add(textBox_manaSearchCourse);
            panel1.Controls.Add(label_ManageCourse);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 62);
            panel1.TabIndex = 2;
            // 
            // button_manaSearchCourse
            // 
            button_manaSearchCourse.Anchor = AnchorStyles.Top;
            button_manaSearchCourse.FlatStyle = FlatStyle.Flat;
            button_manaSearchCourse.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_manaSearchCourse.ForeColor = Color.White;
            button_manaSearchCourse.Location = new Point(811, 15);
            button_manaSearchCourse.Name = "button_manaSearchCourse";
            button_manaSearchCourse.Size = new Size(94, 29);
            button_manaSearchCourse.TabIndex = 2;
            button_manaSearchCourse.Text = "Search";
            button_manaSearchCourse.UseVisualStyleBackColor = true;
            button_manaSearchCourse.Click += button_manaSearchCourse_Click;
            // 
            // textBox_manaSearchCourse
            // 
            textBox_manaSearchCourse.Anchor = AnchorStyles.Top;
            textBox_manaSearchCourse.Location = new Point(575, 17);
            textBox_manaSearchCourse.Name = "textBox_manaSearchCourse";
            textBox_manaSearchCourse.Size = new Size(217, 27);
            textBox_manaSearchCourse.TabIndex = 1;
            // 
            // label_ManageCourse
            // 
            label_ManageCourse.AutoSize = true;
            label_ManageCourse.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ManageCourse.ForeColor = Color.White;
            label_ManageCourse.Location = new Point(20, 8);
            label_ManageCourse.Name = "label_ManageCourse";
            label_ManageCourse.Size = new Size(251, 37);
            label_ManageCourse.TabIndex = 0;
            label_ManageCourse.Text = "Manage Course";
            // 
            // textBox_manaCredits
            // 
            textBox_manaCredits.Anchor = AnchorStyles.Bottom;
            textBox_manaCredits.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_manaCredits.Location = new Point(263, 515);
            textBox_manaCredits.Name = "textBox_manaCredits";
            textBox_manaCredits.Size = new Size(125, 32);
            textBox_manaCredits.TabIndex = 14;
            // 
            // label_manaCredits
            // 
            label_manaCredits.Anchor = AnchorStyles.Bottom;
            label_manaCredits.AutoSize = true;
            label_manaCredits.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaCredits.ForeColor = SystemColors.Highlight;
            label_manaCredits.Location = new Point(146, 518);
            label_manaCredits.Name = "label_manaCredits";
            label_manaCredits.Size = new Size(96, 23);
            label_manaCredits.TabIndex = 13;
            label_manaCredits.Text = "Credits : ";
            // 
            // textBox_manaCourseName
            // 
            textBox_manaCourseName.Anchor = AnchorStyles.Bottom;
            textBox_manaCourseName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_manaCourseName.Location = new Point(263, 455);
            textBox_manaCourseName.Name = "textBox_manaCourseName";
            textBox_manaCourseName.Size = new Size(281, 32);
            textBox_manaCourseName.TabIndex = 12;
            // 
            // label_manaCourseName
            // 
            label_manaCourseName.Anchor = AnchorStyles.Bottom;
            label_manaCourseName.AutoSize = true;
            label_manaCourseName.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaCourseName.ForeColor = SystemColors.Highlight;
            label_manaCourseName.Location = new Point(79, 458);
            label_manaCourseName.Name = "label_manaCourseName";
            label_manaCourseName.Size = new Size(163, 23);
            label_manaCourseName.TabIndex = 11;
            label_manaCourseName.Text = "Course Name : ";
            // 
            // textBox_ManaCourseID
            // 
            textBox_ManaCourseID.Anchor = AnchorStyles.Bottom;
            textBox_ManaCourseID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_ManaCourseID.Location = new Point(263, 390);
            textBox_ManaCourseID.Name = "textBox_ManaCourseID";
            textBox_ManaCourseID.Size = new Size(125, 32);
            textBox_ManaCourseID.TabIndex = 10;
            // 
            // label_manaCourseID
            // 
            label_manaCourseID.Anchor = AnchorStyles.Bottom;
            label_manaCourseID.AutoSize = true;
            label_manaCourseID.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaCourseID.ForeColor = SystemColors.Highlight;
            label_manaCourseID.Location = new Point(119, 393);
            label_manaCourseID.Name = "label_manaCourseID";
            label_manaCourseID.Size = new Size(123, 23);
            label_manaCourseID.TabIndex = 9;
            label_manaCourseID.Text = "Course ID : ";
            // 
            // button_clearCourse
            // 
            button_clearCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearCourse.BackColor = Color.MidnightBlue;
            button_clearCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clearCourse.ForeColor = Color.White;
            button_clearCourse.Location = new Point(537, 539);
            button_clearCourse.Name = "button_clearCourse";
            button_clearCourse.Size = new Size(120, 40);
            button_clearCourse.TabIndex = 15;
            button_clearCourse.Text = "Clear";
            button_clearCourse.UseVisualStyleBackColor = false;
            button_clearCourse.Click += button_clearCourse_Click;
            // 
            // button_updateCourse
            // 
            button_updateCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_updateCourse.BackColor = Color.MidnightBlue;
            button_updateCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_updateCourse.ForeColor = Color.White;
            button_updateCourse.Location = new Point(670, 539);
            button_updateCourse.Name = "button_updateCourse";
            button_updateCourse.Size = new Size(120, 40);
            button_updateCourse.TabIndex = 16;
            button_updateCourse.Text = "Update";
            button_updateCourse.UseVisualStyleBackColor = false;
            button_updateCourse.Click += button_updateCourse_Click;
            // 
            // button_deleteCourse
            // 
            button_deleteCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_deleteCourse.BackColor = Color.MidnightBlue;
            button_deleteCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_deleteCourse.ForeColor = Color.White;
            button_deleteCourse.Location = new Point(800, 539);
            button_deleteCourse.Name = "button_deleteCourse";
            button_deleteCourse.Size = new Size(120, 40);
            button_deleteCourse.TabIndex = 17;
            button_deleteCourse.Text = "Delete";
            button_deleteCourse.UseVisualStyleBackColor = false;
            button_deleteCourse.Click += button_deleteCourse_Click;
            // 
            // guna2DataGridView_manaCourse
            // 
            guna2DataGridView_manaCourse.AllowUserToAddRows = false;
            guna2DataGridView_manaCourse.AllowUserToDeleteRows = false;
            guna2DataGridView_manaCourse.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView_manaCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            guna2DataGridView_manaCourse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            guna2DataGridView_manaCourse.BackgroundColor = Color.Gainsboro;
            guna2DataGridView_manaCourse.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView_manaCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView_manaCourse.ColumnHeadersHeight = 24;
            guna2DataGridView_manaCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView_manaCourse.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView_manaCourse.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaCourse.Location = new Point(12, 68);
            guna2DataGridView_manaCourse.Name = "guna2DataGridView_manaCourse";
            guna2DataGridView_manaCourse.RowHeadersVisible = false;
            guna2DataGridView_manaCourse.RowHeadersWidth = 51;
            guna2DataGridView_manaCourse.RowTemplate.Height = 80;
            guna2DataGridView_manaCourse.SelectionMode = DataGridViewSelectionMode.CellSelect;
            guna2DataGridView_manaCourse.Size = new Size(908, 273);
            guna2DataGridView_manaCourse.TabIndex = 36;
            guna2DataGridView_manaCourse.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView_manaCourse.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView_manaCourse.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView_manaCourse.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView_manaCourse.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView_manaCourse.ThemeStyle.BackColor = Color.Gainsboro;
            guna2DataGridView_manaCourse.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaCourse.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView_manaCourse.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView_manaCourse.ThemeStyle.HeaderStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_manaCourse.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView_manaCourse.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView_manaCourse.ThemeStyle.HeaderStyle.Height = 24;
            guna2DataGridView_manaCourse.ThemeStyle.ReadOnly = false;
            guna2DataGridView_manaCourse.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView_manaCourse.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView_manaCourse.ThemeStyle.RowsStyle.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView_manaCourse.ThemeStyle.RowsStyle.ForeColor = SystemColors.Highlight;
            guna2DataGridView_manaCourse.ThemeStyle.RowsStyle.Height = 80;
            guna2DataGridView_manaCourse.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView_manaCourse.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(guna2DataGridView_manaCourse);
            Controls.Add(button_deleteCourse);
            Controls.Add(button_updateCourse);
            Controls.Add(button_clearCourse);
            Controls.Add(textBox_manaCredits);
            Controls.Add(label_manaCredits);
            Controls.Add(textBox_manaCourseName);
            Controls.Add(label_manaCourseName);
            Controls.Add(textBox_ManaCourseID);
            Controls.Add(label_manaCourseID);
            Controls.Add(panel1);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
            Load += ManageCourseForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView_manaCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button_manaSearchCourse;
        private TextBox textBox_manaSearchCourse;
        private Label label_ManageCourse;
        private TextBox textBox_manaCredits;
        private Label label_manaCredits;
        private TextBox textBox_manaCourseName;
        private Label label_manaCourseName;
        private TextBox textBox_ManaCourseID;
        private Label label_manaCourseID;
        private Button button_clearCourse;
        private Button button_updateCourse;
        private Button button_deleteCourse;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_manaCourse;
    }
}