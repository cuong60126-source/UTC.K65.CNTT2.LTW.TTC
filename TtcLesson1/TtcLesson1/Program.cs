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
                        TimGanDungHoTen(students);
                        break;
                    case "5":
                        //Cap nhat sinh vien
                        CapNhatSinhVien(students);
                        break;
                    case "6":
                        //Xoa sinh vien
                        XoaSinhVien(students);
                        break;
                    case "7":
                        //Sap xep theo sinh vien
                        SapXepTheoHoTen(students);
                        break;
                    case "8":
                        //Sap xep theo diem trung binh
                        SapXepTheoDiemTrungBinh(students);
                        break;
                    case "9":
                        //Hien thi sinh vien co diem 8 tro len
                        HienThiSinhVienTren8(students);
                        break;
                    case "10":
                        //Hien thi sinh vien co diem cao nhat
                        HienThiSinhVienTop(students);
                        break;
                    case "11":
                        //Tinh diem trung binh sinh vien
                        TinhDiemTrungBinh(students);
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

        static void TimGanDungHoTen(List<Student> students)
        {
            Console.WriteLine("Nhap ho ten can tim: ");
            string ten = Console.ReadLine();

            bool timThay = false;

            foreach(var student in students)
            {
                if(student.hoTen.Contains(ten, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Tim thay sinh vien");
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
                }
            }

            if(timThay != true)
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }

        static void CapNhatSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap ma sinh vien can cap nhat: ");
            string ma = Console.ReadLine();

            bool timThay = false;

            foreach(var student in students)
            {
                if(student.masv == ma)
                {
                    Console.WriteLine("Nhap thong tin moi:");

                    Console.Write("Ho ten: ");
                    student.hoTen = Console.ReadLine();

                    Console.Write("Ngay sinh: ");
                    student.ngaySinh = DateTime.Parse(Console.ReadLine());

                    Console.Write("Gioi tinh (true/false): ");
                    student.gioiTinh = bool.Parse(Console.ReadLine());

                    Console.Write("Email: ");
                    student.email = Console.ReadLine();

                    Console.Write("So dien thoai: ");
                    student.sdt = Console.ReadLine();

                    Console.Write("Nganh hoc: ");
                    student.nganhHoc = Console.ReadLine();

                    Console.Write("Diem trung binh: ");
                    student.dtb = float.Parse(Console.ReadLine());

                    Console.Write("Trang thai hoc tap (true/false): ");
                    student.trangThai = bool.Parse(Console.ReadLine());

                    Console.WriteLine("Cap nhat sinh vien thanh cong!");

                    timThay = true;
                    break;
                }
            }

            if(timThay != true)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma: " + ma);
            }
        }

        static void XoaSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap ma sinh vien can xoa: ");
            string ma = Console.ReadLine();

            bool timThay = false;

            foreach(var student in students)
            {
                if(student.masv == ma)
                {
                    students.Remove(student);
                    Console.WriteLine("Xoa sinh vien thanh cong!");
                    timThay = true;
                    break;
                }
            }

            if(timThay != true)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma: " + ma);
            }
        }

        static void SapXepTheoHoTen(List<Student> students)
        {
            students.Sort((sv1, sv2) => sv1.hoTen.CompareTo(sv2.hoTen));
            Console.WriteLine("Da sap xep thanh cong");
            HienThiThongTin(students);
        }

        static void SapXepTheoDiemTrungBinh(List<Student> students)
        {
            students.Sort((sv1, sv2) => sv1.dtb.CompareTo(sv2.dtb));
            Console.WriteLine("Da sap xep thanh cong");
            HienThiThongTin(students);
        }

        static void HienThiSinhVienTren8(List<Student> students)
        {
            bool kiemTra = false;
            foreach(var student in students)
            {
                if(student.dtb > 8)
                {
                    Console.WriteLine("Ma sinh vien: " + student.masv);
                    Console.WriteLine("Ho ten: " + student.hoTen);
                    Console.WriteLine("Ngay sinh: " + student.ngaySinh);
                    Console.WriteLine("Gioi tinh: " + student.gioiTinh);
                    Console.WriteLine("Email: " + student.email);
                    Console.WriteLine("Sdt: " + student.sdt);
                    Console.WriteLine("Nganh hoc: " + student.nganhHoc);
                    Console.WriteLine("Diem trung binh: " + student.dtb);
                    Console.WriteLine("Trang thai: " + student.trangThai);

                    kiemTra = true;
                }
            }

            if(kiemTra != true)
            {
                Console.WriteLine("Khong co sinh vien nao co diem trung binh tren 8");
            }
        }

        static void HienThiSinhVienTop(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("Danh sach khong co sinh vien");
                return;
            }

            List<Student> tStudent = new List<Student>(students);

            SapXepTheoDiemTrungBinh(tStudent);

            Student sinhVienTop = tStudent[tStudent.Count - 1];

            Console.WriteLine("Sinh vien co diem cao nhat:");
            Console.WriteLine("Ma sinh vien: " + sinhVienCaoNhat.masv);
            Console.WriteLine("Ho ten: " + sinhVienCaoNhat.hoTen);
            Console.WriteLine("Ngay sinh: " + sinhVienCaoNhat.ngaySinh);
            Console.WriteLine("Gioi tinh: " + sinhVienCaoNhat.gioiTinh);
            Console.WriteLine("Email: " + sinhVienCaoNhat.email);
            Console.WriteLine("Sdt: " + sinhVienCaoNhat.sdt);
            Console.WriteLine("Nganh hoc: " + sinhVienCaoNhat.nganhHoc);
            Console.WriteLine("Diem trung binh: " + sinhVienCaoNhat.dtb);
            Console.WriteLine("Trang thai: " + sinhVienCaoNhat.trangThai);
        }

        static void TinhDiemTrungBinh(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("Danh sach khong co sinh vien");
                return;
            }

            float dtb = 0;

            foreach(var student in students)
            {
                dtb += student.dtb;
            }

            dtb = dtb / students.Count;
            Console.WriteLine("Diem trung binh: " + dtb);
        }
    }
}