using Lab01;
using System;

namespace Lab01
{
    class Program
    {
        static Student[] ds;
        static int n;

        // Nhập 1 sinh viên
        static Student Nhap1SV()
        {
            Student sv = new Student();

            Console.Write("MSSV: ");
            sv.SetStudentID(int.Parse(Console.ReadLine()));

            Console.Write("Họ tên: ");
            sv.SetName(Console.ReadLine());

            Console.Write("Khoa: ");
            sv.SetFaculty(Console.ReadLine());

            Console.Write("Điểm TB: ");
            sv.SetMark(float.Parse(Console.ReadLine()));

            return sv;
        }

        // Nhập danh sách sinh viên
        static void NhapDS()
        {
            Console.Write("Nhập số lượng sinh viên: ");
            n = int.Parse(Console.ReadLine());
            ds = new Student[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nNhập sinh viên thứ {i + 1}:");
                ds[i] = Nhap1SV();
            }
        }

        // Xuất danh sách sinh viên
        static void XuatDS()
        {
            Console.WriteLine("\n=== DANH SÁCH SINH VIÊN ===");
            foreach (Student sv in ds)
            {
                sv.Show();
            }
        }

        static void Main(string[] args)
        {
            NhapDS();
            XuatDS();
            Console.ReadLine();
        }
    }
}
