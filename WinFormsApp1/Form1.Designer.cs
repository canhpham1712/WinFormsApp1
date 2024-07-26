namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel_slide = new Panel();
            button_Enrollment = new Button();
            button_dashboard = new Button();
            button_score = new Button();
            button_course = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            pictureBox2 = new PictureBox();
            label_welcome = new Label();
            label2 = new Label();
            panel_main = new Panel();
            panel_cover = new Panel();
            panel3 = new Panel();
            label_maleClassSelected = new Label();
            label_femaleClassSelected = new Label();
            label_selectClass = new Label();
            comboBox_listClass = new ComboBox();
            label_totalMaleStd = new Label();
            label_totalFemaleStd = new Label();
            label_totalStd = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label_role = new Label();
            label_user = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            panel_slide.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_main.SuspendLayout();
            panel_cover.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.MidnightBlue;
            panel_slide.Controls.Add(button_Enrollment);
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(191, 657);
            panel_slide.TabIndex = 0;
            // 
            // button_Enrollment
            // 
            button_Enrollment.BackColor = Color.RoyalBlue;
            button_Enrollment.Dock = DockStyle.Top;
            button_Enrollment.FlatAppearance.BorderSize = 0;
            button_Enrollment.FlatStyle = FlatStyle.Flat;
            button_Enrollment.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Enrollment.ForeColor = Color.White;
            button_Enrollment.Location = new Point(0, 371);
            button_Enrollment.Name = "button_Enrollment";
            button_Enrollment.Padding = new Padding(10, 0, 0, 0);
            button_Enrollment.Size = new Size(191, 48);
            button_Enrollment.TabIndex = 12;
            button_Enrollment.Text = "Đăng ký môn";
            button_Enrollment.TextAlign = ContentAlignment.MiddleLeft;
            button_Enrollment.UseVisualStyleBackColor = false;
            button_Enrollment.Click += button_Enrollment_Click;
            // 
            // button_dashboard
            // 
            button_dashboard.BackColor = Color.RoyalBlue;
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 323);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(10, 0, 0, 0);
            button_dashboard.Size = new Size(191, 48);
            button_dashboard.TabIndex = 6;
            button_dashboard.Text = "Trang chủ";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // button_score
            // 
            button_score.BackColor = Color.RoyalBlue;
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 275);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(191, 48);
            button_score.TabIndex = 4;
            button_score.Text = "Điểm";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = false;
            button_score.Click += button_score_Click;
            // 
            // button_course
            // 
            button_course.BackColor = Color.RoyalBlue;
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 227);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(191, 48);
            button_course.TabIndex = 2;
            button_course.Text = "Khóa học";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = false;
            button_course.Click += button_course_Click;
            // 
            // button_std
            // 
            button_std.BackColor = Color.RoyalBlue;
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 179);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(191, 48);
            button_std.TabIndex = 1;
            button_std.Text = "Học sinh";
            button_std.TextAlign = ContentAlignment.MiddleLeft;
            button_std.UseVisualStyleBackColor = false;
            button_std.Click += button_std_Click;
            // 
            // panel_logo
            // 
            panel_logo.BackColor = Color.RoyalBlue;
            panel_logo.Controls.Add(pictureBox2);
            panel_logo.Controls.Add(label_welcome);
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(191, 179);
            panel_logo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label_welcome
            // 
            label_welcome.AutoSize = true;
            label_welcome.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_welcome.Location = new Point(37, 46);
            label_welcome.Name = "label_welcome";
            label_welcome.Size = new Size(96, 28);
            label_welcome.TabIndex = 0;
            label_welcome.Text = "Welcome";
            label_welcome.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(6, 0);
            label2.Name = "label2";
            label2.Size = new Size(179, 46);
            label2.TabIndex = 1;
            label2.Text = "HCMUT";
            label2.UseWaitCursor = true;
            // 
            // panel_main
            // 
            panel_main.Controls.Add(panel_cover);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(191, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(1088, 657);
            panel_main.TabIndex = 1;
            // 
            // panel_cover
            // 
            panel_cover.Controls.Add(panel3);
            panel_cover.Controls.Add(panel2);
            panel_cover.Controls.Add(panel1);
            panel_cover.Dock = DockStyle.Fill;
            panel_cover.Location = new Point(0, 0);
            panel_cover.Name = "panel_cover";
            panel_cover.Size = new Size(1088, 657);
            panel_cover.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(label_maleClassSelected);
            panel3.Controls.Add(label_femaleClassSelected);
            panel3.Controls.Add(label_selectClass);
            panel3.Controls.Add(comboBox_listClass);
            panel3.Controls.Add(label_totalMaleStd);
            panel3.Controls.Add(label_totalFemaleStd);
            panel3.Controls.Add(label_totalStd);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 560);
            panel3.Name = "panel3";
            panel3.Size = new Size(1088, 97);
            panel3.TabIndex = 2;
            // 
            // label_maleClassSelected
            // 
            label_maleClassSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_maleClassSelected.AutoSize = true;
            label_maleClassSelected.ForeColor = Color.White;
            label_maleClassSelected.Location = new Point(881, 60);
            label_maleClassSelected.Name = "label_maleClassSelected";
            label_maleClassSelected.Size = new Size(49, 20);
            label_maleClassSelected.TabIndex = 6;
            label_maleClassSelected.Text = "Male :";
            // 
            // label_femaleClassSelected
            // 
            label_femaleClassSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_femaleClassSelected.AutoSize = true;
            label_femaleClassSelected.ForeColor = Color.White;
            label_femaleClassSelected.Location = new Point(964, 60);
            label_femaleClassSelected.Name = "label_femaleClassSelected";
            label_femaleClassSelected.Size = new Size(68, 20);
            label_femaleClassSelected.TabIndex = 5;
            label_femaleClassSelected.Text = "Female : ";
            // 
            // label_selectClass
            // 
            label_selectClass.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_selectClass.AutoSize = true;
            label_selectClass.ForeColor = Color.White;
            label_selectClass.Location = new Point(751, 21);
            label_selectClass.Name = "label_selectClass";
            label_selectClass.Size = new Size(97, 20);
            label_selectClass.TabIndex = 4;
            label_selectClass.Text = "Select Class : ";
            // 
            // comboBox_listClass
            // 
            comboBox_listClass.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBox_listClass.FormattingEnabled = true;
            comboBox_listClass.Location = new Point(881, 18);
            comboBox_listClass.Name = "comboBox_listClass";
            comboBox_listClass.Size = new Size(151, 28);
            comboBox_listClass.TabIndex = 3;
            // 
            // label_totalMaleStd
            // 
            label_totalMaleStd.AutoSize = true;
            label_totalMaleStd.ForeColor = Color.White;
            label_totalMaleStd.Location = new Point(30, 60);
            label_totalMaleStd.Name = "label_totalMaleStd";
            label_totalMaleStd.Size = new Size(48, 20);
            label_totalMaleStd.TabIndex = 3;
            label_totalMaleStd.Text = "Nam :";
            // 
            // label_totalFemaleStd
            // 
            label_totalFemaleStd.AutoSize = true;
            label_totalFemaleStd.ForeColor = Color.White;
            label_totalFemaleStd.Location = new Point(118, 60);
            label_totalFemaleStd.Name = "label_totalFemaleStd";
            label_totalFemaleStd.Size = new Size(40, 20);
            label_totalFemaleStd.TabIndex = 2;
            label_totalFemaleStd.Text = "Nữ : ";
            // 
            // label_totalStd
            // 
            label_totalStd.AutoSize = true;
            label_totalStd.ForeColor = Color.White;
            label_totalStd.Location = new Point(30, 21);
            label_totalStd.Name = "label_totalStd";
            label_totalStd.Size = new Size(112, 20);
            label_totalStd.TabIndex = 1;
            label_totalStd.Text = "Tổng học sinh : ";
            label_totalStd.Click += label_totalStd_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label_role);
            panel2.Controls.Add(label_user);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(1088, 89);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1008, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label_role
            // 
            label_role.AutoSize = true;
            label_role.ForeColor = Color.White;
            label_role.Location = new Point(118, 49);
            label_role.Name = "label_role";
            label_role.Size = new Size(53, 20);
            label_role.TabIndex = 3;
            label_role.Text = "Admin";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.ForeColor = Color.White;
            label_user.Location = new Point(118, 17);
            label_user.Name = "label_user";
            label_user.Size = new Size(38, 20);
            label_user.TabIndex = 2;
            label_user.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 49);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 1;
            label3.Text = "Role: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 17);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Welcome : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 68);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(30, 21);
            label10.Name = "label10";
            label10.Size = new Size(373, 25);
            label10.TabIndex = 1;
            label10.Text = "Ho Chi Minh City University of Technology";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1279, 657);
            Controls.Add(panel_main);
            Controls.Add(panel_slide);
            ForeColor = SystemColors.ControlLight;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_main.ResumeLayout(false);
            panel_cover.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Panel panel_logo;
        private Button button_std;
        private Button button_score;
        private Button button_course;
        private Button button_dashboard;
        private Label label2;
        private Label label_welcome;
        private Panel panel_main;
        private Panel panel_cover;
        private Panel panel3;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Label label_totalStd;
        private Label label_role;
        private Label label_user;
        private ComboBox comboBox_listClass;
        private Label label_totalMaleStd;
        private Label label_totalFemaleStd;
        private Label label_maleClassSelected;
        private Label label_femaleClassSelected;
        private Label label_selectClass;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label10;
        private Button button_Enrollment;
    }
}
