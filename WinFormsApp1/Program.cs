using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


/*namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}*/

namespace WinFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cấu hình dịch vụ DI
            var serviceProvider = new ServiceCollection()
                .AddDbContext<StudentContext>(options =>
                    options.UseSqlServer("Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                .BuildServiceProvider();

            // Chạy ứng dụng và truyền dịch vụ cần thiết
            Application.Run(new LinqTest(serviceProvider.GetRequiredService<StudentContext>()));
        }
    }
}

/*using System;
using System.Windows.Forms;
using WinFormsApp1;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-CEIK1QBD\\MSSQLSERVER01;Initial Catalog=StudentManagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            var context = new StudentContext();
            Application.Run(new LinqTest(context));
        }
    }
}*/
