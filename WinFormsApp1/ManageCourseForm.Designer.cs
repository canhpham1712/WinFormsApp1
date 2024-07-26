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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            button_manaSearchCourse = new Button();
            textBox_manaSearchCourse = new TextBox();
            label_ManageCourse = new Label();
            label_manaCourseID = new Label();
            button_clearCourse = new Button();
            button_updateCourse = new Button();
            button_deleteCourse = new Button();
            guna2DataGridView_manaCourse = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2ComboBox_Classes = new Guna.UI2.WinForms.Guna2ComboBox();
            button1 = new Button();
            textBox_studentID = new TextBox();
            label1 = new Label();
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
            label_ManageCourse.Size = new Size(243, 37);
            label_ManageCourse.TabIndex = 0;
            label_ManageCourse.Text = "Quản lý lớp học";
            // 
            // label_manaCourseID
            // 
            label_manaCourseID.Anchor = AnchorStyles.Bottom;
            label_manaCourseID.AutoSize = true;
            label_manaCourseID.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_manaCourseID.ForeColor = SystemColors.Highlight;
            label_manaCourseID.Location = new Point(119, 393);
            label_manaCourseID.Name = "label_manaCourseID";
            label_manaCourseID.Size = new Size(120, 23);
            label_manaCourseID.TabIndex = 9;
            label_manaCourseID.Text = "ID học sinh : ";
            // 
            // button_clearCourse
            // 
            button_clearCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clearCourse.BackColor = Color.MidnightBlue;
            button_clearCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clearCourse.ForeColor = Color.White;
            button_clearCourse.Location = new Point(672, 539);
            button_clearCourse.Name = "button_clearCourse";
            button_clearCourse.Size = new Size(120, 40);
            button_clearCourse.TabIndex = 15;
            button_clearCourse.Text = "Dọn";
            button_clearCourse.UseVisualStyleBackColor = false;
            // 
            // button_updateCourse
            // 
            button_updateCourse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_updateCourse.BackColor = Color.MidnightBlue;
            button_updateCourse.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_updateCourse.ForeColor = Color.White;
            button_updateCourse.Location = new Point(800, 493);
            button_updateCourse.Name = "button_updateCourse";
            button_updateCourse.Size = new Size(120, 40);
            button_updateCourse.TabIndex = 16;
            button_updateCourse.Text = "Cập nhật";
            button_updateCourse.UseVisualStyleBackColor = false;
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
            button_deleteCourse.Text = "Xóa";
            button_deleteCourse.UseVisualStyleBackColor = false;
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
            // guna2ComboBox_Classes
            // 
            guna2ComboBox_Classes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            guna2ComboBox_Classes.BackColor = Color.Transparent;
            guna2ComboBox_Classes.CustomizableEdges = customizableEdges1;
            guna2ComboBox_Classes.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox_Classes.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox_Classes.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox_Classes.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox_Classes.Font = new Font("Segoe UI", 10F);
            guna2ComboBox_Classes.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox_Classes.ItemHeight = 30;
            guna2ComboBox_Classes.Location = new Point(575, 386);
            guna2ComboBox_Classes.Name = "guna2ComboBox_Classes";
            guna2ComboBox_Classes.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBox_Classes.Size = new Size(175, 36);
            guna2ComboBox_Classes.TabIndex = 37;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(800, 447);
            button1.Name = "button1";
            button1.Size = new Size(120, 40);
            button1.TabIndex = 38;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox_studentID
            // 
            textBox_studentID.Anchor = AnchorStyles.Bottom;
            textBox_studentID.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_studentID.Location = new Point(245, 388);
            textBox_studentID.Name = "textBox_studentID";
            textBox_studentID.Size = new Size(125, 32);
            textBox_studentID.TabIndex = 39;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(437, 393);
            label1.Name = "label1";
            label1.Size = new Size(132, 23);
            label1.TabIndex = 40;
            label1.Text = "Danh sách lớp ";
            // 
            // ManageCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 603);
            Controls.Add(label1);
            Controls.Add(textBox_studentID);
            Controls.Add(button1);
            Controls.Add(guna2ComboBox_Classes);
            Controls.Add(guna2DataGridView_manaCourse);
            Controls.Add(button_deleteCourse);
            Controls.Add(button_updateCourse);
            Controls.Add(button_clearCourse);
            Controls.Add(label_manaCourseID);
            Controls.Add(panel1);
            Name = "ManageCourseForm";
            Text = "ManageCourseForm";
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
        private Label label_manaCourseID;
        private Button button_clearCourse;
        private Button button_updateCourse;
        private Button button_deleteCourse;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView_manaCourse;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox_Classes;
        private Button button1;
        private TextBox textBox_studentID;
        private Label label1;
    }
}