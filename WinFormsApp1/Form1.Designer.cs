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
            button_semester = new Button();
            button_exit1 = new Button();
            button_dashboard = new Button();
            panel_scoreSubmenu = new Panel();
            button_ClassList = new Button();
            button1 = new Button();
            button_scorePrint = new Button();
            button_manageScore = new Button();
            button_newScore = new Button();
            button_score = new Button();
            panel_courseSubmenu = new Panel();
            button_CoursesPerCycle = new Button();
            button_manageCourse = new Button();
            button_newCourse = new Button();
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
            panel_scoreSubmenu.SuspendLayout();
            panel_courseSubmenu.SuspendLayout();
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
            panel_slide.Controls.Add(button_semester);
            panel_slide.Controls.Add(button_exit1);
            panel_slide.Controls.Add(button_dashboard);
            panel_slide.Controls.Add(panel_scoreSubmenu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_courseSubmenu);
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
            button_Enrollment.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Enrollment.ForeColor = Color.White;
            button_Enrollment.Location = new Point(0, 770);
            button_Enrollment.Name = "button_Enrollment";
            button_Enrollment.Padding = new Padding(10, 0, 0, 0);
            button_Enrollment.Size = new Size(170, 48);
            button_Enrollment.TabIndex = 12;
            button_Enrollment.Text = "Enrollment";
            button_Enrollment.TextAlign = ContentAlignment.MiddleLeft;
            button_Enrollment.UseVisualStyleBackColor = false;
            button_Enrollment.Click += button_Enrollment_Click;
            // 
            // button_semester
            // 
            button_semester.BackColor = Color.RoyalBlue;
            button_semester.Dock = DockStyle.Top;
            button_semester.FlatAppearance.BorderSize = 0;
            button_semester.FlatStyle = FlatStyle.Flat;
            button_semester.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_semester.ForeColor = Color.White;
            button_semester.Location = new Point(0, 722);
            button_semester.Name = "button_semester";
            button_semester.Padding = new Padding(10, 0, 0, 0);
            button_semester.Size = new Size(170, 48);
            button_semester.TabIndex = 8;
            button_semester.Text = "Semester";
            button_semester.TextAlign = ContentAlignment.MiddleLeft;
            button_semester.UseVisualStyleBackColor = false;
            button_semester.Click += button_semester_Click;
            // 
            // button_exit1
            // 
            button_exit1.BackColor = Color.RoyalBlue;
            button_exit1.Dock = DockStyle.Top;
            button_exit1.FlatAppearance.BorderSize = 0;
            button_exit1.FlatStyle = FlatStyle.Flat;
            button_exit1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit1.ForeColor = Color.White;
            button_exit1.Location = new Point(0, 674);
            button_exit1.Name = "button_exit1";
            button_exit1.Padding = new Padding(10, 0, 0, 0);
            button_exit1.Size = new Size(170, 48);
            button_exit1.TabIndex = 7;
            button_exit1.Text = "Exit";
            button_exit1.TextAlign = ContentAlignment.MiddleLeft;
            button_exit1.UseVisualStyleBackColor = false;
            // 
            // button_dashboard
            // 
            button_dashboard.BackColor = Color.RoyalBlue;
            button_dashboard.Dock = DockStyle.Top;
            button_dashboard.FlatAppearance.BorderSize = 0;
            button_dashboard.FlatStyle = FlatStyle.Flat;
            button_dashboard.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_dashboard.ForeColor = Color.White;
            button_dashboard.Location = new Point(0, 626);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Padding = new Padding(10, 0, 0, 0);
            button_dashboard.Size = new Size(170, 48);
            button_dashboard.TabIndex = 6;
            button_dashboard.Text = "Dashboard";
            button_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            button_dashboard.UseVisualStyleBackColor = false;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // panel_scoreSubmenu
            // 
            panel_scoreSubmenu.Controls.Add(button_ClassList);
            panel_scoreSubmenu.Controls.Add(button1);
            panel_scoreSubmenu.Controls.Add(button_scorePrint);
            panel_scoreSubmenu.Controls.Add(button_manageScore);
            panel_scoreSubmenu.Controls.Add(button_newScore);
            panel_scoreSubmenu.Dock = DockStyle.Top;
            panel_scoreSubmenu.Location = new Point(0, 475);
            panel_scoreSubmenu.Name = "panel_scoreSubmenu";
            panel_scoreSubmenu.Size = new Size(170, 151);
            panel_scoreSubmenu.TabIndex = 5;
            // 
            // button_ClassList
            // 
            button_ClassList.Dock = DockStyle.Top;
            button_ClassList.FlatAppearance.BorderSize = 0;
            button_ClassList.FlatStyle = FlatStyle.Flat;
            button_ClassList.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_ClassList.ForeColor = Color.White;
            button_ClassList.Location = new Point(0, 202);
            button_ClassList.Name = "button_ClassList";
            button_ClassList.Padding = new Padding(35, 0, 0, 0);
            button_ClassList.Size = new Size(170, 49);
            button_ClassList.TabIndex = 10;
            button_ClassList.Text = "241";
            button_ClassList.TextAlign = ContentAlignment.MiddleLeft;
            button_ClassList.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 154);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(170, 48);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button_scorePrint
            // 
            button_scorePrint.Dock = DockStyle.Top;
            button_scorePrint.FlatAppearance.BorderSize = 0;
            button_scorePrint.FlatStyle = FlatStyle.Flat;
            button_scorePrint.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_scorePrint.ForeColor = Color.White;
            button_scorePrint.Location = new Point(0, 100);
            button_scorePrint.Name = "button_scorePrint";
            button_scorePrint.Padding = new Padding(35, 0, 0, 0);
            button_scorePrint.Size = new Size(170, 54);
            button_scorePrint.TabIndex = 3;
            button_scorePrint.Text = "Print";
            button_scorePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_scorePrint.UseVisualStyleBackColor = true;
            button_scorePrint.Click += button_scorePrint_Click;
            // 
            // button_manageScore
            // 
            button_manageScore.Dock = DockStyle.Top;
            button_manageScore.FlatAppearance.BorderSize = 0;
            button_manageScore.FlatStyle = FlatStyle.Flat;
            button_manageScore.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manageScore.ForeColor = Color.White;
            button_manageScore.Location = new Point(0, 50);
            button_manageScore.Name = "button_manageScore";
            button_manageScore.Padding = new Padding(35, 0, 0, 0);
            button_manageScore.Size = new Size(170, 50);
            button_manageScore.TabIndex = 1;
            button_manageScore.Text = "Manage Score";
            button_manageScore.TextAlign = ContentAlignment.MiddleLeft;
            button_manageScore.UseVisualStyleBackColor = true;
            button_manageScore.Click += button_manageScore_Click;
            // 
            // button_newScore
            // 
            button_newScore.Dock = DockStyle.Top;
            button_newScore.FlatAppearance.BorderSize = 0;
            button_newScore.FlatStyle = FlatStyle.Flat;
            button_newScore.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_newScore.ForeColor = Color.White;
            button_newScore.Location = new Point(0, 0);
            button_newScore.Name = "button_newScore";
            button_newScore.Padding = new Padding(35, 0, 0, 0);
            button_newScore.Size = new Size(170, 50);
            button_newScore.TabIndex = 0;
            button_newScore.Text = "New Score";
            button_newScore.TextAlign = ContentAlignment.MiddleLeft;
            button_newScore.UseVisualStyleBackColor = true;
            button_newScore.Click += button_newScore_Click;
            // 
            // button_score
            // 
            button_score.BackColor = Color.RoyalBlue;
            button_score.Dock = DockStyle.Top;
            button_score.FlatAppearance.BorderSize = 0;
            button_score.FlatStyle = FlatStyle.Flat;
            button_score.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_score.ForeColor = Color.White;
            button_score.Location = new Point(0, 427);
            button_score.Name = "button_score";
            button_score.Padding = new Padding(10, 0, 0, 0);
            button_score.Size = new Size(170, 48);
            button_score.TabIndex = 4;
            button_score.Text = "Score";
            button_score.TextAlign = ContentAlignment.MiddleLeft;
            button_score.UseVisualStyleBackColor = false;
            button_score.Click += button_score_Click;
            // 
            // panel_courseSubmenu
            // 
            panel_courseSubmenu.Controls.Add(button_CoursesPerCycle);
            panel_courseSubmenu.Controls.Add(button_manageCourse);
            panel_courseSubmenu.Controls.Add(button_newCourse);
            panel_courseSubmenu.Dock = DockStyle.Top;
            panel_courseSubmenu.Location = new Point(0, 275);
            panel_courseSubmenu.Name = "panel_courseSubmenu";
            panel_courseSubmenu.Size = new Size(170, 152);
            panel_courseSubmenu.TabIndex = 3;
            // 
            // button_CoursesPerCycle
            // 
            button_CoursesPerCycle.Dock = DockStyle.Top;
            button_CoursesPerCycle.FlatAppearance.BorderSize = 0;
            button_CoursesPerCycle.FlatStyle = FlatStyle.Flat;
            button_CoursesPerCycle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_CoursesPerCycle.ForeColor = Color.White;
            button_CoursesPerCycle.Location = new Point(0, 100);
            button_CoursesPerCycle.Name = "button_CoursesPerCycle";
            button_CoursesPerCycle.Padding = new Padding(35, 0, 0, 0);
            button_CoursesPerCycle.Size = new Size(170, 50);
            button_CoursesPerCycle.TabIndex = 3;
            button_CoursesPerCycle.Text = "Courses per Cycle";
            button_CoursesPerCycle.TextAlign = ContentAlignment.MiddleLeft;
            button_CoursesPerCycle.UseVisualStyleBackColor = true;
            button_CoursesPerCycle.Click += button_CoursesPerCycle_Click;
            // 
            // button_manageCourse
            // 
            button_manageCourse.Dock = DockStyle.Top;
            button_manageCourse.FlatAppearance.BorderSize = 0;
            button_manageCourse.FlatStyle = FlatStyle.Flat;
            button_manageCourse.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manageCourse.ForeColor = Color.White;
            button_manageCourse.Location = new Point(0, 50);
            button_manageCourse.Name = "button_manageCourse";
            button_manageCourse.Padding = new Padding(35, 0, 0, 0);
            button_manageCourse.Size = new Size(170, 50);
            button_manageCourse.TabIndex = 1;
            button_manageCourse.Text = "Manage Course";
            button_manageCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_manageCourse.UseVisualStyleBackColor = true;
            button_manageCourse.Click += button_manageCourse_Click;
            // 
            // button_newCourse
            // 
            button_newCourse.Dock = DockStyle.Top;
            button_newCourse.FlatAppearance.BorderSize = 0;
            button_newCourse.FlatStyle = FlatStyle.Flat;
            button_newCourse.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_newCourse.ForeColor = Color.White;
            button_newCourse.Location = new Point(0, 0);
            button_newCourse.Name = "button_newCourse";
            button_newCourse.Padding = new Padding(35, 0, 0, 0);
            button_newCourse.Size = new Size(170, 50);
            button_newCourse.TabIndex = 0;
            button_newCourse.Text = "New Course";
            button_newCourse.TextAlign = ContentAlignment.MiddleLeft;
            button_newCourse.UseVisualStyleBackColor = true;
            button_newCourse.Click += button_newCourse_Click;
            // 
            // button_course
            // 
            button_course.BackColor = Color.RoyalBlue;
            button_course.Dock = DockStyle.Top;
            button_course.FlatAppearance.BorderSize = 0;
            button_course.FlatStyle = FlatStyle.Flat;
            button_course.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_course.ForeColor = Color.White;
            button_course.Location = new Point(0, 227);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(170, 48);
            button_course.TabIndex = 2;
            button_course.Text = "Course";
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
            button_std.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 179);
            button_std.Name = "button_std";
            button_std.Padding = new Padding(10, 0, 0, 0);
            button_std.Size = new Size(170, 48);
            button_std.TabIndex = 1;
            button_std.Text = "Student";
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
            panel_logo.Size = new Size(170, 179);
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
            label_totalMaleStd.Size = new Size(49, 20);
            label_totalMaleStd.TabIndex = 3;
            label_totalMaleStd.Text = "Male :";
            // 
            // label_totalFemaleStd
            // 
            label_totalFemaleStd.AutoSize = true;
            label_totalFemaleStd.ForeColor = Color.White;
            label_totalFemaleStd.Location = new Point(118, 60);
            label_totalFemaleStd.Name = "label_totalFemaleStd";
            label_totalFemaleStd.Size = new Size(68, 20);
            label_totalFemaleStd.TabIndex = 2;
            label_totalFemaleStd.Text = "Female : ";
            // 
            // label_totalStd
            // 
            label_totalStd.AutoSize = true;
            label_totalStd.ForeColor = Color.White;
            label_totalStd.Location = new Point(30, 21);
            label_totalStd.Name = "label_totalStd";
            label_totalStd.Size = new Size(114, 20);
            label_totalStd.TabIndex = 1;
            label_totalStd.Text = "Total Students : ";
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
            panel_scoreSubmenu.ResumeLayout(false);
            panel_courseSubmenu.ResumeLayout(false);
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
        private Panel panel_scoreSubmenu;
        private Button button_scorePrint;
        private Button button_manageScore;
        private Button button_newScore;
        private Button button_score;
        private Panel panel_courseSubmenu;
        private Button button_manageCourse;
        private Button button_newCourse;
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
        private Button button_exit1;
        private Button button1;
        private Button button_semester;
        private Button button_ClassList;
        private Button button_CoursesPerCycle;
        private Button button_Enrollment;
    }
}
