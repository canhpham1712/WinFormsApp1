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
            panel_slide = new Panel();
            button_exit = new Button();
            panel_scoreSubmenu = new Panel();
            button_scorePrint = new Button();
            button_manageScore = new Button();
            button_newScore = new Button();
            button_score = new Button();
            panel_courseSubmenu = new Panel();
            button_coursePrint = new Button();
            button_manageCourse = new Button();
            button_newCourse = new Button();
            button_course = new Button();
            panel_stdsubmenu = new Panel();
            button_stdPrint = new Button();
            button_status = new Button();
            button_manageStd = new Button();
            button_registration = new Button();
            button_std = new Button();
            panel_logo = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            panel_slide.SuspendLayout();
            panel_scoreSubmenu.SuspendLayout();
            panel_courseSubmenu.SuspendLayout();
            panel_stdsubmenu.SuspendLayout();
            panel_logo.SuspendLayout();
            SuspendLayout();
            // 
            // panel_slide
            // 
            panel_slide.AutoScroll = true;
            panel_slide.BackColor = Color.MidnightBlue;
            panel_slide.Controls.Add(button_exit);
            panel_slide.Controls.Add(panel_scoreSubmenu);
            panel_slide.Controls.Add(button_score);
            panel_slide.Controls.Add(panel_courseSubmenu);
            panel_slide.Controls.Add(button_course);
            panel_slide.Controls.Add(panel_stdsubmenu);
            panel_slide.Controls.Add(button_std);
            panel_slide.Controls.Add(panel_logo);
            panel_slide.Dock = DockStyle.Left;
            panel_slide.Location = new Point(0, 0);
            panel_slide.Name = "panel_slide";
            panel_slide.Size = new Size(191, 603);
            panel_slide.TabIndex = 0;
            // 
            // button_exit
            // 
            button_exit.BackColor = Color.RoyalBlue;
            button_exit.Dock = DockStyle.Top;
            button_exit.FlatAppearance.BorderSize = 0;
            button_exit.FlatStyle = FlatStyle.Flat;
            button_exit.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_exit.ForeColor = Color.White;
            button_exit.Location = new Point(0, 740);
            button_exit.Name = "button_exit";
            button_exit.Padding = new Padding(10, 0, 0, 0);
            button_exit.Size = new Size(170, 48);
            button_exit.TabIndex = 6;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleLeft;
            button_exit.UseVisualStyleBackColor = false;
            // 
            // panel_scoreSubmenu
            // 
            panel_scoreSubmenu.Controls.Add(button_scorePrint);
            panel_scoreSubmenu.Controls.Add(button_manageScore);
            panel_scoreSubmenu.Controls.Add(button_newScore);
            panel_scoreSubmenu.Dock = DockStyle.Top;
            panel_scoreSubmenu.Location = new Point(0, 589);
            panel_scoreSubmenu.Name = "panel_scoreSubmenu";
            panel_scoreSubmenu.Size = new Size(170, 151);
            panel_scoreSubmenu.TabIndex = 5;
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
            button_score.Location = new Point(0, 541);
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
            panel_courseSubmenu.Controls.Add(button_coursePrint);
            panel_courseSubmenu.Controls.Add(button_manageCourse);
            panel_courseSubmenu.Controls.Add(button_newCourse);
            panel_courseSubmenu.Dock = DockStyle.Top;
            panel_courseSubmenu.Location = new Point(0, 389);
            panel_courseSubmenu.Name = "panel_courseSubmenu";
            panel_courseSubmenu.Size = new Size(170, 152);
            panel_courseSubmenu.TabIndex = 3;
            // 
            // button_coursePrint
            // 
            button_coursePrint.Dock = DockStyle.Top;
            button_coursePrint.FlatAppearance.BorderSize = 0;
            button_coursePrint.FlatStyle = FlatStyle.Flat;
            button_coursePrint.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_coursePrint.ForeColor = Color.White;
            button_coursePrint.Location = new Point(0, 100);
            button_coursePrint.Name = "button_coursePrint";
            button_coursePrint.Padding = new Padding(35, 0, 0, 0);
            button_coursePrint.Size = new Size(170, 49);
            button_coursePrint.TabIndex = 2;
            button_coursePrint.Text = "Print";
            button_coursePrint.TextAlign = ContentAlignment.MiddleLeft;
            button_coursePrint.UseVisualStyleBackColor = true;
            button_coursePrint.Click += button_coursePrint_Click;
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
            button_course.Location = new Point(0, 341);
            button_course.Name = "button_course";
            button_course.Padding = new Padding(10, 0, 0, 0);
            button_course.Size = new Size(170, 48);
            button_course.TabIndex = 2;
            button_course.Text = "Course";
            button_course.TextAlign = ContentAlignment.MiddleLeft;
            button_course.UseVisualStyleBackColor = false;
            button_course.Click += button_course_Click;
            // 
            // panel_stdsubmenu
            // 
            panel_stdsubmenu.BackColor = Color.MidnightBlue;
            panel_stdsubmenu.Controls.Add(button_stdPrint);
            panel_stdsubmenu.Controls.Add(button_status);
            panel_stdsubmenu.Controls.Add(button_manageStd);
            panel_stdsubmenu.Controls.Add(button_registration);
            panel_stdsubmenu.Dock = DockStyle.Top;
            panel_stdsubmenu.ForeColor = Color.White;
            panel_stdsubmenu.Location = new Point(0, 137);
            panel_stdsubmenu.Name = "panel_stdsubmenu";
            panel_stdsubmenu.Size = new Size(170, 204);
            panel_stdsubmenu.TabIndex = 1;
            // 
            // button_stdPrint
            // 
            button_stdPrint.Dock = DockStyle.Top;
            button_stdPrint.FlatAppearance.BorderSize = 0;
            button_stdPrint.FlatStyle = FlatStyle.Flat;
            button_stdPrint.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_stdPrint.ForeColor = Color.White;
            button_stdPrint.Location = new Point(0, 150);
            button_stdPrint.Name = "button_stdPrint";
            button_stdPrint.Padding = new Padding(35, 0, 0, 0);
            button_stdPrint.Size = new Size(170, 51);
            button_stdPrint.TabIndex = 3;
            button_stdPrint.Text = "Print";
            button_stdPrint.TextAlign = ContentAlignment.MiddleLeft;
            button_stdPrint.UseVisualStyleBackColor = true;
            button_stdPrint.Click += button_stdPrint_Click;
            // 
            // button_status
            // 
            button_status.Dock = DockStyle.Top;
            button_status.FlatAppearance.BorderSize = 0;
            button_status.FlatStyle = FlatStyle.Flat;
            button_status.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_status.ForeColor = Color.White;
            button_status.Location = new Point(0, 100);
            button_status.Name = "button_status";
            button_status.Padding = new Padding(35, 0, 0, 0);
            button_status.Size = new Size(170, 50);
            button_status.TabIndex = 2;
            button_status.Text = "Status";
            button_status.TextAlign = ContentAlignment.MiddleLeft;
            button_status.UseVisualStyleBackColor = true;
            button_status.Click += button_status_Click;
            // 
            // button_manageStd
            // 
            button_manageStd.Dock = DockStyle.Top;
            button_manageStd.FlatAppearance.BorderSize = 0;
            button_manageStd.FlatStyle = FlatStyle.Flat;
            button_manageStd.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_manageStd.ForeColor = Color.White;
            button_manageStd.Location = new Point(0, 50);
            button_manageStd.Name = "button_manageStd";
            button_manageStd.Padding = new Padding(35, 0, 0, 0);
            button_manageStd.Size = new Size(170, 50);
            button_manageStd.TabIndex = 1;
            button_manageStd.Text = "Manage Student";
            button_manageStd.TextAlign = ContentAlignment.MiddleLeft;
            button_manageStd.UseVisualStyleBackColor = true;
            button_manageStd.Click += button_manageStd_Click;
            // 
            // button_registration
            // 
            button_registration.Dock = DockStyle.Top;
            button_registration.FlatAppearance.BorderSize = 0;
            button_registration.FlatStyle = FlatStyle.Flat;
            button_registration.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_registration.ForeColor = Color.White;
            button_registration.Location = new Point(0, 0);
            button_registration.Name = "button_registration";
            button_registration.Padding = new Padding(35, 0, 0, 0);
            button_registration.Size = new Size(170, 50);
            button_registration.TabIndex = 0;
            button_registration.Text = "Registration";
            button_registration.TextAlign = ContentAlignment.MiddleLeft;
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += button_registration_ClicK;
            // 
            // button_std
            // 
            button_std.BackColor = Color.RoyalBlue;
            button_std.Dock = DockStyle.Top;
            button_std.FlatAppearance.BorderSize = 0;
            button_std.FlatStyle = FlatStyle.Flat;
            button_std.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_std.ForeColor = Color.White;
            button_std.Location = new Point(0, 89);
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
            panel_logo.Controls.Add(label2);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(170, 89);
            panel_logo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(191, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 89);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(191, 89);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 89);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 22);
            label2.Name = "label2";
            label2.Size = new Size(179, 46);
            label2.TabIndex = 1;
            label2.Text = "HCMUT";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1132, 603);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel_slide);
            ForeColor = SystemColors.ControlLight;
            MinimumSize = new Size(1150, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += Form1_Load;
            panel_slide.ResumeLayout(false);
            panel_scoreSubmenu.ResumeLayout(false);
            panel_courseSubmenu.ResumeLayout(false);
            panel_stdsubmenu.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_slide;
        private Panel panel_logo;
        private Button button_std;
        private Panel panel_stdsubmenu;
        private Button button_stdPrint;
        private Button button_status;
        private Button button_manageStd;
        private Button button_registration;
        private Panel panel_scoreSubmenu;
        private Button button_scorePrint;
        private Button button_manageScore;
        private Button button_newScore;
        private Button button_score;
        private Panel panel_courseSubmenu;
        private Button button_coursePrint;
        private Button button_manageCourse;
        private Button button_newCourse;
        private Button button_course;
        private Button button_exit;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
    }
}
