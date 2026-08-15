using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TtcLesson1
{
    internal class MenuManager
    {
        private StudentService service;
        private StudentConsoleView view;

        public MenuManager()
        {
            service = new StudentService();
            view = new StudentConsoleView();
        }

        public void Run(List<Student> students)
        {
            string choice;

            do
            {
                view.HienThiMenu();

                Console.Write("Chon chuc nang: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        service.ThemMotSinhVien(students);
                        break;

                    case "2":
                        service.HienThiThongTin(students);
                        break;

                    case "3":
                        service.TimSinhVienTheoMa(students);
                        break;

                    case "4":
                        service.TimGanDungHoTen(students);
                        break;

                    case "5":
                        service.CapNhatSinhVien(students);
                        break;

                    case "6":
                        service.XoaSinhVien(students);
                        break;

                    case "7":
                        service.SapXepTheoHoTen(students);
                        break;

                    case "8":
                        service.SapXepTheoDiemTrungBinh(students);
                        break;

                    case "9":
                        service.HienThiSinhVienTren8(students);
                        break;

                    case "10":
                        service.HienThiSinhVienTop(students);
                        break;

                    case "11":
                        service.TinhDiemTrungBinh(students);
                        break;

                    case "12":
                        service.ThongKeSinhVienTheoNghanh(students);
                        break;

                    case "13":
                        service.ThongKeSinhVienTheoTrangThai(students);
                        break;

                    case "14":
                        view.ThongBao("Ket thuc chuong trinh!");
                        break;

                    default:
                        view.ThongBao("Chon sai chuc nang!");
                        break;
                }

                Console.WriteLine();

            } while (choice != "14");
        }
    }
}
