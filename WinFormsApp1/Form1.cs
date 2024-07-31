namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        StudentClass student = new StudentClass();
        public Form1()
        {
            InitializeComponent();
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

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {

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
            //openChildForm(new ManageCourseForm());
        }

        private void button_score_Click(object sender, EventArgs e)
        {
             openChildForm(new CourseAndScore());
        }

        private void button_Enrollment_Click(object sender, EventArgs e)
        {
            //openChildForm(new EnrollmentForm());
        }

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

        private void label_totalStd_Click(object sender, EventArgs e)
        {

        }
    }
}
