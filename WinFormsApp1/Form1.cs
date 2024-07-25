namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        StudentClass student = new StudentClass();
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentCount();
        }

        // count std
        private void studentCount()
        {
            // display the total, male and female
            label_totalStd.Text = "Total Students : " + student.GetTotalStudents();
            label_totalMaleStd.Text = "Male : " + student.GetMaleStudents();
            label_totalFemaleStd.Text = "Female : " + student.GetFemaleStudents();
        }

        private void customizeDesign()
        {
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }


        private void button_std_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
        }

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }
        #region CourseSubmenu
        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new NewCourseForm());
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCourseForm());
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }
        #endregion CourseSubmenu
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }
        #region ScoreSubmenu
        // Score:
        // Add Score: StudentID, CycleID, CourseName/ID, Test, Score
        private void button_newScore_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            //....
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        #endregion ScoreSubmenu

        // get chiild from main form
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)

                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            panel_main.Controls.Add(panel_cover);
            studentCount();
        }

        private void button_semester_Click(object sender, EventArgs e)
        {
            
        }

        private void button_CoursesPerCycle_Click(object sender, EventArgs e)
        {
            //...
            hideSubmenu();
        }

        private void button_Enrollment_Click(object sender, EventArgs e)
        {
            openChildForm(new EnrollmentForm());
        }
    }
}
