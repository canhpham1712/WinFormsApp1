using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////
///
/// Lớp đại diện thực thế Courses trong csdl
/// 
/////////////////////////////

namespace WinFormsApp1
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
