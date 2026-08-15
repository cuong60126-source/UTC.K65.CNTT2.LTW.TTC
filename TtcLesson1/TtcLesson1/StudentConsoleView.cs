using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TtcLesson1
{
    internal class StudentConsoleView
    {
        public void HienThiMotSinhVien(Student student)
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
            Console.WriteLine("---------------------------");
        }
        public void HienThiMenu()
        {
            Console.WriteLine("============= CHUC NANG =============");
            Console.WriteLine("1.\tThem sinh vien.");
            Console.WriteLine("2.\tHien thi danh sach.");
            Console.WriteLine("3.\tTim sinh vien theo ma.");
            Console.WriteLine("4.\tTim gan dung theo ho ten.");
            Console.WriteLine("5.\tCap nhat sinh vien.");
            Console.WriteLine("6.\tXoa sinh vien.");
            Console.WriteLine("7.\tSap xep theo ho ten.");
            Console.WriteLine("8.\tSap xep theo diem trung binh.");
            Console.WriteLine("9.\tHien thi sinh vien co diem tu 8 tro len.");
            Console.WriteLine("10.\tHien thi sinh vien co diem cao nhat.");
            Console.WriteLine("11.\tTinh diem trung binh toan bo sinh vien.");
            Console.WriteLine("12.\tThong ke sinh vien theo nganh.");
            Console.WriteLine("13.\tThong ke sinh vien theo trang thai.");
            Console.WriteLine("14.\tThoat.");
        }

        public void ThongBao(string message)
        {
            Console.WriteLine(message);
        }
    }
}
