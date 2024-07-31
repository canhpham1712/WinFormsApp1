using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////
/// 
/// lớp đại diện thực thể Students trong csdl
/// 
/////////////////////////

namespace WinFormsApp1
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth {  get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
