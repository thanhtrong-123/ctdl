using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            NhapDonHang(ref q);
            //Xuat don hang
            q.Print();

            DonHang sTT = q.Peek();
            Console.WriteLine(" Thong tin don hang hien co: ");
            Console.WriteLine(sTT.ToString());

            //Them don hang
            Console.WriteLine("  Nhap tong tin don hang moi can them: ");
            DonHang value = new DonHang(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            q.EnQueue(value);
            Console.WriteLine(" Don hang sau khi them mot don hang moi: ");
            q.Print();

            //Xuat don hang
            q.DeQueue();
            Console.WriteLine("Mot don hang da duoc xuat ra ");
            Console.WriteLine(" Tinh trang hien tai ");
            q.Print();
        }
        static void NhapDonHang(ref Queue q)
        {
            int n;
            Console.WriteLine("Nhap so don hang: ");
            n = int.Parse(Console.ReadLine());
            DonHang value;
            int sTT;
            string hoTen;
            string diachi;
            int soDT;
            string tenHang;
            int soLuong;
            double donGia;

            for(int i =1; i <= n; i++)
            {
                Console.Write("Nhap so thu tu: ");
                sTT = int.Parse(Console.ReadLine());
                Console.Write("Nhap ho ten: ");
                hoTen = Console.ReadLine();
                Console.Write("Nhap dia chi: ");
                diachi = Console.ReadLine();
                Console.Write("Nhap so dien thoai: ");
                soDT = int.Parse(Console.ReadLine());
                Console.Write("Nhap ten hang: ");
                tenHang = Console.ReadLine();
                Console.Write("Nhap so luong: ");
                soLuong = int.Parse(Console.ReadLine());
                Console.Write("Nhap don gia: ");
                donGia = double.Parse(Console.ReadLine());

                value = new DonHang(sTT, hoTen, diachi, soDT, tenHang, soLuong, donGia);
                q.EnQueue(value);

            }
        }
    }
}
