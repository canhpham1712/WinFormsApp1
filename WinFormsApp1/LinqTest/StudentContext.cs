using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class StudentContext : DbContext
    {
        // hàm tạo để thực hiện hàm addDbContext
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Scores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // kết nối với csdl
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the primary key for Enrollment entity
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.StudentID, e.CourseID });

            // Optional: Configure relationships if necessary
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentID);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseID);
        }
    }
}
