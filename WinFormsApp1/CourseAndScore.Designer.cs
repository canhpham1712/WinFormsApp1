namespace WinFormsApp1
{
    partial class CourseAndScore
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
            dgv_student_list = new DataGridView();
            dgv_score = new DataGridView();
            panel1 = new Panel();
            txtb_course_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbb_course_name_list = new ComboBox();
            lb_course_list = new Label();
            lb_selected_id = new Label();
            txtb_selected_id = new TextBox();
            txtb_selected_name = new TextBox();
            lb_selected_name = new Label();
            btn_add_to_course = new Button();
            btn_delete_from_course = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_student_list).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_score).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_student_list
            // 
            dgv_student_list.AllowUserToAddRows = false;
            dgv_student_list.AllowUserToDeleteRows = false;
            dgv_student_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student_list.Location = new Point(12, 78);
            dgv_student_list.Name = "dgv_student_list";
            dgv_student_list.RowHeadersWidth = 51;
            dgv_student_list.Size = new Size(700, 338);
            dgv_student_list.TabIndex = 0;
            dgv_student_list.CellClick += dgv_student_list_CellClick;
            // 
            // dgv_score
            // 
            dgv_score.AllowUserToAddRows = false;
            dgv_score.AllowUserToDeleteRows = false;
            dgv_score.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_score.EditMode = DataGridViewEditMode.EditOnEnter;
            dgv_score.Location = new Point(718, 78);
            dgv_score.Name = "dgv_score";
            dgv_score.RowHeadersWidth = 51;
            dgv_score.Size = new Size(491, 338);
            dgv_score.TabIndex = 1;
            dgv_score.CellClick += dgv_score_CellClick;
            dgv_score.CellEndEdit += dgv_score_CellEndEdit;
            dgv_score.KeyDown += dgv_score_KeyDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtb_course_id);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbb_course_name_list);
            panel1.Controls.Add(lb_course_list);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1206, 60);
            panel1.TabIndex = 2;
            // 
            // txtb_course_id
            // 
            txtb_course_id.Location = new Point(1070, 18);
            txtb_course_id.Name = "txtb_course_id";
            txtb_course_id.Size = new Size(63, 27);
            txtb_course_id.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(971, 21);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 6;
            label2.Text = "ID môn học :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 21);
            label1.Name = "label1";
            label1.Size = new Size(385, 20);
            label1.TabIndex = 5;
            label1.Text = "Chọn 1 học sinh từ danh sách dưới đây để thêm môn học";
            // 
            // cbb_course_name_list
            // 
            cbb_course_name_list.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbb_course_name_list.FormattingEnabled = true;
            cbb_course_name_list.Location = new Point(845, 17);
            cbb_course_name_list.Name = "cbb_course_name_list";
            cbb_course_name_list.Size = new Size(99, 28);
            cbb_course_name_list.TabIndex = 3;
            cbb_course_name_list.SelectedIndexChanged += cbb_course_name_list_SelectedIndexChanged;
            // 
            // lb_course_list
            // 
            lb_course_list.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lb_course_list.AutoSize = true;
            lb_course_list.Location = new Point(715, 21);
            lb_course_list.Name = "lb_course_list";
            lb_course_list.Size = new Size(124, 20);
            lb_course_list.TabIndex = 4;
            lb_course_list.Text = "Chọn 1 môn học :";
            // 
            // lb_selected_id
            // 
            lb_selected_id.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_selected_id.AutoSize = true;
            lb_selected_id.Location = new Point(24, 472);
            lb_selected_id.Name = "lb_selected_id";
            lb_selected_id.Size = new Size(146, 20);
            lb_selected_id.TabIndex = 3;
            lb_selected_id.Text = "ID học sinh đã chọn :";
            // 
            // txtb_selected_id
            // 
            txtb_selected_id.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtb_selected_id.Location = new Point(181, 469);
            txtb_selected_id.Name = "txtb_selected_id";
            txtb_selected_id.Size = new Size(125, 27);
            txtb_selected_id.TabIndex = 4;
            // 
            // txtb_selected_name
            // 
            txtb_selected_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtb_selected_name.Location = new Point(181, 513);
            txtb_selected_name.Name = "txtb_selected_name";
            txtb_selected_name.Size = new Size(125, 27);
            txtb_selected_name.TabIndex = 5;
            // 
            // lb_selected_name
            // 
            lb_selected_name.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lb_selected_name.AutoSize = true;
            lb_selected_name.Location = new Point(17, 516);
            lb_selected_name.Name = "lb_selected_name";
            lb_selected_name.Size = new Size(158, 20);
            lb_selected_name.TabIndex = 6;
            lb_selected_name.Text = "Tên học sinh đã chọn : ";
            // 
            // btn_add_to_course
            // 
            btn_add_to_course.Location = new Point(364, 469);
            btn_add_to_course.Name = "btn_add_to_course";
            btn_add_to_course.Size = new Size(94, 29);
            btn_add_to_course.TabIndex = 7;
            btn_add_to_course.Text = "Thêm";
            btn_add_to_course.UseVisualStyleBackColor = true;
            btn_add_to_course.Click += btn_add_to_course_Click;
            // 
            // btn_delete_from_course
            // 
            btn_delete_from_course.Location = new Point(364, 513);
            btn_delete_from_course.Name = "btn_delete_from_course";
            btn_delete_from_course.Size = new Size(94, 29);
            btn_delete_from_course.TabIndex = 8;
            btn_delete_from_course.Text = "Xóa";
            btn_delete_from_course.UseVisualStyleBackColor = true;
            btn_delete_from_course.Click += btn_delete_from_course_Click;
            // 
            // CourseAndScore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 636);
            Controls.Add(btn_delete_from_course);
            Controls.Add(btn_add_to_course);
            Controls.Add(lb_selected_name);
            Controls.Add(txtb_selected_name);
            Controls.Add(txtb_selected_id);
            Controls.Add(lb_selected_id);
            Controls.Add(panel1);
            Controls.Add(dgv_score);
            Controls.Add(dgv_student_list);
            Name = "CourseAndScore";
            Text = "CourseAndScore";
            Load += CourseAndScore_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student_list).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_score).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student_list;
        private DataGridView dgv_score;
        private Panel panel1;
        private ComboBox cbb_course_name_list;
        private Label lb_course_list;
        private Label label1;
        private Label lb_selected_id;
        private TextBox txtb_selected_id;
        private TextBox txtb_selected_name;
        private Label lb_selected_name;
        private Button btn_add_to_course;
        private Button btn_delete_from_course;
        private TextBox txtb_course_id;
        private Label label2;
    }
}