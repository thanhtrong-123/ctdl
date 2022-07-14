using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra4
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            NhapDH(ref q);
            //Xuat kho
            q.Print();

            DonHang matHang = q.Peak();
            Console.WriteLine("Thong tin mat hang sap duoc xuat kho:");
            Console.WriteLine(matHang.ToString());

            Console.WriteLine("Nhap thong tin mat hang can them: ");
            DonHang value = new DonHang(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));
            q.Enqueue(value);
            Console.WriteLine("Hang doi sau khi them mat hang moi: ");
            q.Print();
        }
        static void NhapDH(ref Queue q)
        {
            int n;
            Console.WriteLine("Nhap s luong mat hang co can nhap kho: ");
            n = int.Parse(Console.ReadLine());
            DonHang value;
            int sTT;
            string hoTen;
            string diaChi;
            int soDT;
            string tenHang;
            int soLuong;
            double donGia;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Nhap so thu tu: ");
                sTT = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ho ten: ");
                hoTen = Console.ReadLine();
                Console.WriteLine("Nhap dia chi: ");
                diaChi = Console.ReadLine();
                Console.WriteLine("Nhap so dien thoai: ");
                soDT = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten hang: ");
                tenHang = Console.ReadLine();
                Console.WriteLine("Nhap so luong: ");
                soLuong = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap don gia: ");
                donGia = double.Parse(Console.ReadLine());

                value = new DonHang(sTT, hoTen, diaChi, soDT, tenHang, soLuong, donGia);
                q.Enqueue(value);
            }
        }
    }
}
