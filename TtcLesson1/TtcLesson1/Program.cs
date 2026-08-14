namespace TtcLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string choice;
            List<Student> students = new List<Student>()
            {
                new Student{masv="SV001", hoTen="Chung Trinh", email="chungtrinhj@gmail.com", sdt="0978611889"},
                new Student{masv="SV002", hoTen="Chach Van Doanh", email="doanh@gmail.com", sdt="0978611889"},
            };

            do
            {
                menu();
                Console.WriteLine("Ban chon chuc nang: ");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        //Them sinh vien
                        ThemMotSinhVien(students);
                        break;
                    case "2":
                        //Hien thi
                        HienThiThongTin(students);
                        break;
                    case "3":
                        //Tim sinh vien theo ma
                        TimSinhVienTheoMa(students);
                        break;
                    case "4":
                        //Tim gan dung ho ten
                        break;
                    case "5":
                        //Cap nhat sinh vien
                        break;
                    case "6":
                        //Xoa sinh vien
                        break;
                    case "7":
                        //Sap xep theo sinh vien
                        break;
                    case "8":
                        //Sap xep theo diem trung binh
                        break;
                    case "9":
                        //Hien thi sinh vien co diem 8 tro len
                        break;
                    case "10":
                        //Hien thi sinh vien co diem cao nhat
                        break;
                    case "11":
                        //Tinh diem trung binh sinh vien
                        break;
                    case "12":
                        //Thong ke sinh vien theo nghanh
                        break;
                    case "13":
                        //Thong ke sinh vien theo trang thai
                        break;
                    case "14":
                        Console.WriteLine("Ban da ket thuc chuc nang");
                        break;
                    default:
                        Console.WriteLine("Ban chon sai chuc nang");
                        break;
                }
            } while (choice != "14");

            menu();
        }

        static void menu()
        {
            Console.WriteLine("=============CHUC NANG=============");
            Console.WriteLine("1.\tThêm sinh viên.\r" +
                "\n2.\tHiển thị danh sách.\r" +
                "\n3.\tTìm sinh viên theo mã.\r" +
                "\n4.\tTìm gần đúng theo họ tên.\r" +
                "\n5.\tCập nhật sinh viên.\r" +
                "\n6.\tXóa sinh viên.\r" +
                "\n7.\tSắp xếp theo họ tên.\r" +
                "\n8.\tSắp xếp theo điểm trung bình.\r" +
                "\n9.\tHiển thị sinh viên có điểm từ 8 trở lên.\r" +
                "\n10.\tHiển thị sinh viên có điểm cao nhất.\r" +
                "\n11.\tTính điểm trung bình toàn bộ sinh viên.\r" +
                "\n12.\tThống kê sinh viên theo ngành.\r" +
                "\n13.\tThống kê sinh viên theo trạng thái.\r");

            Console.WriteLine("14.\tThoat ");
        }

        static void HienThiThongTin(List<Student> students)
        {
            Console.WriteLine("Danh sach sinh vien");
            foreach(var item in students)
            {
                Console.WriteLine("Ma sinh vien: " + item.masv);
                Console.WriteLine("Ho ten: " + item.hoTen);
                Console.WriteLine("Ngay sinh: " + item.ngaySinh);
                Console.WriteLine("Gioi tinh: " + item.gioiTinh);
                Console.WriteLine("Email: " + item.email);
                Console.WriteLine("Sdt: " + item.sdt);
                Console.WriteLine("Nganh hoc: " + item.sdt);
                Console.WriteLine("Diem trung binh: " + item.dtb);
                Console.WriteLine("Trang thai: " + item.trangThai);
                Console.WriteLine("---------------------------");
            }
        }

        static void ThemMotSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap thong tin sinh vien: ");

            Student student = new Student();

            Console.WriteLine("Ma sinh vien: ");
            student.masv = Console.ReadLine();
            Console.WriteLine("Ho ten: ");
            student.hoTen = Console.ReadLine();
            Console.WriteLine("Ngay sinh: ");
            student.ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Gioi tinh: ");
            student.gioiTinh = Console.ReadLine();
            Console.WriteLine("Email: ");
            student.email = Console.ReadLine();
            Console.WriteLine("So dien thoai: ");
            student.sdt = Console.ReadLine();
            Console.WriteLine("Nghanh hoc: ");
            student.nganhHoc = Console.ReadLine();
            Console.WriteLine("Diem trung binh: ");
            student.dtb = float.Parse(Console.ReadLine());
            Console.WriteLine("Trang thai hoc tap: ");
            student.trangThai = bool.Parse(Console.ReadLine());

            students.Add(student);
        }

        static void TimSinhVienTheoMa(List<Student> students)
        {
            Console.WriteLine("Nhap ma sinh vien can tim: ");
            string ma = Console.ReadLine();

            bool timThay = false;

            foreach(var student in students)
            {
                if (student.masv == ma)
                {
                    Console.WriteLine("Tim thay sinh vien: ");
                    Console.WriteLine("Ma sinh vien: " + student.masv);
                    Console.WriteLine("Ho ten: " + student.hoTen);
                    Console.WriteLine("Ngay sinh: " + student.ngaySinh);
                    Console.WriteLine("Gioi tinh: " + student.gioiTinh);
                    Console.WriteLine("Email: " + student.email);
                    Console.WriteLine("Sdt: " + student.sdt);
                    Console.WriteLine("Nganh hoc: " + student.nganhHoc);
                    Console.WriteLine("Diem trung binh: " + student.dtb);
                    Console.WriteLine("Trang thai: " + student.trangThai);

                    timThay = true;
                    break;
                }
            }

            if(timThay != true)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma: " + ma);
            }
        }
    }
}