using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TtcLesson1
{
    internal class StudentValidator
    {
        public bool KiemTraMaSinhVien(List<Student> students, string ma)
        {
            foreach(var student in students)
            {
                if(student.masv == ma)
                {
                    return false;
                }
            }

            return true;
        }

        public bool KiemTraHoTen(string hoTen)
        {
            return !string.IsNullOrWhiteSpace(hoTen);
        }

        public bool KiemTraDiem(float dtb)
        {
            return dtb >= 0 && dtb <= 10;
        }

        public bool KiemTraEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
