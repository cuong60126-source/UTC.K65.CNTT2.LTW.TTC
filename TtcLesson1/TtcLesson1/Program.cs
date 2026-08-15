namespace TtcLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student{masv="SV001",hoTen="Chung Trinh",email = "chungtrinhj@gmail.com",sdt = "0978611889", trangThai = true},
                new Student{masv="SV002",hoTen="Chach Van Doanh",email = "doanh@gmail.com",sdt = "0978611889", trangThai = true},
            };

            StudentValidator validator = new StudentValidator();
            StudentConsoleView view = new StudentConsoleView();
            StudentService service = new StudentService();
            MenuManager menuManager = new MenuManager();

            menuManager.Run(students);
        }
    }
}