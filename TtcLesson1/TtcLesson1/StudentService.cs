using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TtcLesson1
{
    internal class StudentService
    {
        private StudentValidator validator;
        private StudentConsoleView view;

        public StudentService()
        {

            validator = new StudentValidator();
            view = new StudentConsoleView();
        }

        public void ThemMotSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap thong tin sinh vien: ");

            Student student = new Student();

            Console.WriteLine("Ma sinh vien: ");
            student.masv = Console.ReadLine();

            if (validator.KiemTraMaSinhVien(students, student.masv) == false)
            {
                return;
            }

            Console.WriteLine("Ho ten: ");
            student.hoTen = Console.ReadLine();

            if (validator.KiemTraHoTen(student.hoTen))
            {
                Console.WriteLine("Nhap sai dinh dang ho ten");
            }

            Console.WriteLine("Ngay sinh: ");
            student.ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Gioi tinh: ");
            student.gioiTinh = Console.ReadLine();
            Console.WriteLine("Email: ");
            student.email = Console.ReadLine();
            Console.WriteLine("So dien thoai: ");

            if (validator.KiemTraEmail(student.email) == false)
            {
                Console.WriteLine("Email khong dung dinh dang");
                return;
            }

            student.sdt = Console.ReadLine();
            Console.WriteLine("Nghanh hoc: ");
            student.nganhHoc = Console.ReadLine();
            Console.WriteLine("Diem trung binh: ");

            if (validator.KiemTraDiem(student.dtb) == false)
            {
                Console.WriteLine("Sai dinh dang diem");
                return;
            }

            student.dtb = float.Parse(Console.ReadLine());
            Console.WriteLine("Trang thai hoc tap: ");
            student.trangThai = bool.Parse(Console.ReadLine());

            students.Add(student);

            Console.WriteLine("Them sinh vien thanh cong!");
        }

        public void HienThiThongTin(List<Student> students)
        {
            Console.WriteLine("Danh sach sinh vien");
            foreach (var item in students)
            {
                view.HienThiMotSinhVien(item);
            }


        }

        public void TimSinhVienTheoMa(List<Student> students)
        {
            Console.WriteLine("Nhap ma sinh vien can tim: ");
            string ma = Console.ReadLine();

            bool timThay = false;

            foreach (var student in students)
            {
                if (student.masv == ma)
                {
                    view.HienThiMotSinhVien(student);

                    timThay = true;
                    return;
                }
            }

            Console.WriteLine("Khong tim thay sinh vien co ma: " + ma);
        }

        public void TimGanDungHoTen(List<Student> students)
        {
            Console.WriteLine("Nhap ho ten can tim: ");
            string ten = Console.ReadLine();

            bool timThay = false;

            foreach (var student in students)
            {
                if (student.hoTen.Contains(ten, StringComparison.OrdinalIgnoreCase))
                {
                    view.HienThiMotSinhVien(student);

                    timThay = true;
                }
            }

            if (timThay != true)
            {
                Console.WriteLine("Khong tim thay sinh vien");
            }
        }

        public void CapNhatSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap ma sinh vien can cap nhat: ");
            string ma = Console.ReadLine();

            bool timThay = false;

            foreach (var student in students)
            {
                if (student.masv == ma)
                {
                    Console.WriteLine("Nhap thong tin moi:");

                    Console.Write("Ho ten: ");
                    student.hoTen = Console.ReadLine();
                    if (validator.KiemTraHoTen(student.hoTen))
                    {
                        Console.WriteLine("Nhap sai dinh dang ho ten");
                    }

                    Console.Write("Ngay sinh: ");
                    student.ngaySinh = DateTime.Parse(Console.ReadLine());

                    Console.Write("Gioi tinh (true/false): ");
                    student.gioiTinh = Console.ReadLine();

                    Console.Write("Email: ");
                    student.email = Console.ReadLine();
                    if (validator.KiemTraEmail(student.email) == false)
                    {
                        Console.WriteLine("Email khong dung dinh dang");
                        return;
                    }

                    Console.Write("So dien thoai: ");
                    student.sdt = Console.ReadLine();

                    Console.Write("Nganh hoc: ");
                    student.nganhHoc = Console.ReadLine();

                    Console.Write("Diem trung binh: ");
                    student.dtb = float.Parse(Console.ReadLine());
                    if (validator.KiemTraDiem(student.dtb) == false)
                    {
                        Console.WriteLine("Sai dinh dang diem");
                        return;
                    }

                    Console.Write("Trang thai hoc tap (true/false): ");
                    student.trangThai = bool.Parse(Console.ReadLine());

                    Console.WriteLine("Cap nhat sinh vien thanh cong!");

                    timThay = true;
                    break;
                }
            }

            if (timThay != true)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma: " + ma);
            }
        }

        public void XoaSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap ma sinh vien can xoa: ");
            string ma = Console.ReadLine();

            bool timThay = false;

            foreach (var student in students)
            {
                if (student.masv == ma)
                {
                    students.Remove(student);
                    Console.WriteLine("Xoa sinh vien thanh cong!");
                    timThay = true;
                    break;
                }
            }

            if (timThay != true)
            {
                Console.WriteLine("Khong tim thay sinh vien co ma: " + ma);
            }
        }

        public void SapXepTheoHoTen(List<Student> students)
        {
            students.Sort((sv1, sv2) => sv1.hoTen.CompareTo(sv2.hoTen));
            Console.WriteLine("Da sap xep thanh cong");
            view.HienThiThongTin(students);
        }

        public void SapXepTheoDiemTrungBinh(List<Student> students)
        {
            students.Sort((sv1, sv2) => sv1.dtb.CompareTo(sv2.dtb));
            Console.WriteLine("Da sap xep thanh cong");
            view.HienThiThongTin(students);
        }

        public void HienThiSinhVienTren8(List<Student> students)
        {
            bool kiemTra = false;
            foreach (var student in students)
            {
                if (student.dtb > 8)
                {
                    HienThiMotSinhVien(student);

                    kiemTra = true;
                }
            }

            if (kiemTra != true)
            {
                Console.WriteLine("Khong co sinh vien nao co diem trung binh tren 8");
            }
        }

        public void HienThiSinhVienTop(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach khong co sinh vien");
                return;
            }

            List<Student> tStudent = new List<Student>(students);

            SapXepTheoDiemTrungBinh(tStudent);

            Student sinhVienTop = tStudent[tStudent.Count - 1];

            Console.WriteLine("Sinh vien co diem cao nhat:");
            view.HienThiMotSinhVien(sinhVienTop);
        }

        public void TinhDiemTrungBinh(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Danh sach khong co sinh vien");
                return;
            }

            float dtb = 0;

            foreach (var student in students)
            {
                dtb += student.dtb;
            }

            dtb = dtb / students.Count;
            Console.WriteLine("Diem trung binh: " + dtb);
        }

        public void ThongKeSinhVienTheoNghanh(List<Student> students)
        {
            Dictionary<string, int> thongKe = new Dictionary<string, int>();

            foreach (var student in students)
            {
                if (thongKe.ContainsKey(student.nganhHoc))
                {
                    thongKe[student.nganhHoc]++;
                }
                else
                {
                    thongKe.Add(student.nganhHoc, 1);
                }
            }

            Console.WriteLine("Thong ke sinh vien theo nghanh");

            foreach (var item in thongKe)
            {
                Console.WriteLine("Nghanh: " + item.Key + " - So sinh vien: " + item.Value);
            }
        }

        public void ThongKeSinhVienTheoTrangThai(List<Student> students)
        {
            int dangHoc = 0;
            int nghiHoc = 0;

            foreach (var student in students)
            {
                if (student.trangThai == true)
                {
                    dangHoc++;
                }
                else
                {
                    nghiHoc++;
                }
            }

            Console.WriteLine("Dang hoc: " + dangHoc);
            Console.WriteLine("Nghi hoc: " + nghiHoc);
        }
    }
}