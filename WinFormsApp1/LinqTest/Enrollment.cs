using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////
///
/// lớp đại diện thực thể Scores trong csdl
/// 
/////////////////////////////////

namespace WinFormsApp1
{
    public class Enrollment
    {
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public decimal Score { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
