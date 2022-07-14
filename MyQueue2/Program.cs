using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueue2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            //nhap don hang 
            NhapHoaDon(ref q);

            //xuat 
            q.Print();

            //xem don hang 
            DonHang HoaDon = q.Peek();
            Console.WriteLine("Thong tin don hang sap duoc chuye di:");
            Console.WriteLine(HoaDon.ToString());
            //them 
            Console.WriteLine("Nhap thong tin hoa don moi: ");
            DonHang value = new DonHang(int.Parse(Console.ReadLine()), Console.WriteLine(), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            q.Enqueue(value);
            Console.WriteLine("hoa don can doi sau khi them 1 hoa don moi:");
            q.Print();
            //xuat hoa don
            q.Dequeue();
            Console.WriteLine("mot hoa don duoc xuat di:");
            Console.WriteLine("tinh trang hoa don hien tai:");
            q.Print();
        }
        static void NhapHoaDon(ref Queue q)
        {
            int n;
            Console.WriteLine("Nhap so luong hoa don san co can nhap:");
            n = int.Parse(Console.ReadLine());
            DonHang value;
         int sttDonHang;
         string hoTen;
         string diaChi;
         int sDT;
         string tenHang;
         int soLuong;
         double donGia;

            for(int i = 1; i <=  n; i++)
            {
                Console.Write("Nhap thong tin can tim:");
                sttDonHang = int.Parse(Console.ReadLine());
                hoTen = Console.ReadLine();
                diaChi = Console.ReadLine();
                sDT = int.Parse(Console.ReadLine());
                tenHang = Console.ReadLine();
                soLuong = int.Parse(Console.ReadLine());
                donGia = double.Parse(Console.ReadLine());
                value = new DonHang(sttDonHang, hoTen, diaChi, sDT, tenHang, soLuong, donGia);
                q.Enqueue(value);
            }
    }
    }
}
