using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            //Nhap don hang
            NhapduLieu(ref q);
            //xem thong tin don hang
            q.Print();
            //them vao don hang moi
            Console.WriteLine("Them vao don hang moi: ");
            Donhang value = new Donhang(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), Console.ReadLine(), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            q.Enqueue(value);
            Console.WriteLine("-----Thong tin sau khi them don hang moi-----");
            q.Print();
            //xem thong tin don hang sap duoc xu li
            Donhang mathang = q.Peek();
            Console.WriteLine("-----Thong tin don hang sap duoc xuat kho-----");
            Console.WriteLine(mathang.ToString());
            //
            Console.WriteLine("-------");
                q.Dequeue();
                Console.WriteLine("====>Da xu li don hang");
                Console.WriteLine("-----Thong tin don hang sau xu li-----");
                q.Print();
            
                
            
            
            Console.ReadKey();
        }
        static void NhapduLieu(ref Queue dh)
        {
            int stt;
            string hoTen;
            string diaChi;
            int sdt;
            string tenHang;
            int soLuong;
            double donGia;
            Donhang value;
            int n;
            Console.Write("Nhap vao so luong don hang: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("Nhap don hang thu {0}", i);
                Console.Write("Nhap vao STT: ");
                stt = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao ho ten: ");
                hoTen =Console.ReadLine();
                Console.Write("Nhap vao dia chi: ");
                diaChi =Console.ReadLine();
                Console.Write("Nhap vao SDT: ");
                sdt = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao ten hang: ");
                tenHang =Console.ReadLine();
                Console.Write("Nhap vao so luong: ");
                soLuong = int.Parse(Console.ReadLine());
                Console.Write("Nhap vao don gia: ");
                donGia = double.Parse(Console.ReadLine());

                value = new Donhang(stt, hoTen, diaChi, sdt, tenHang, soLuong, donGia);
                dh.Enqueue(value);

            }
        }
    }
}
