using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue managerDonHang = new Queue();
            int choose = 0;
            do
            {
              
                Console.WriteLine("***********MENU********");
                Console.WriteLine("1.Nhap n Don Hang");
                Console.WriteLine("2.Xem Thong Tin Tat CA Don Hang Hien Co");
                Console.WriteLine("3.Them 1 Don Hang Moi");
                Console.WriteLine("4.Xem Thong Tin Don Hang Sap Duoc Xu Ly");
                Console.WriteLine("5.Xu Ly Tat Ca Don Hang Va In RA Man Hinh Don Hang Dang Xu Ly");
                Console.WriteLine("6.Thoat");
                Console.WriteLine("moi ban chon");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        CreateDonHang(ref managerDonHang); break;
                    case 2:
                        managerDonHang.Display(); break;
                    case 3:
                        Add(ref managerDonHang); break;
                    case 4:
                        Console.WriteLine(managerDonHang.Peek().ToString()); ; break;
                    case 5:
                        ProcessDonHang(ref managerDonHang); break;
                    case 6:
                        break;
                }
            } while (choose > 0 && choose < 6);
        }


        public static void CreateDonHang (ref Queue managerDonHang)
        {
            int n = 0;
            do
            {
                Console.WriteLine("nhap so don hang muon tao");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"don hang thu {i+1}");
                Add(ref managerDonHang);
            }
        }
        public static void Add(ref Queue managerDonHang)
        {
            string hoTen;
            string diaChi;
            string soDienThoai;
            string tenHang;
            int soLuong;
            long donGia;
            Console.WriteLine("nhap ho ten");
            hoTen = Console.ReadLine();
            Console.WriteLine("nhap dia chi");
            diaChi = Console.ReadLine();
            Console.WriteLine("nhap so dien thoai");
            soDienThoai = Console.ReadLine();
            Console.WriteLine("nhap ten hang");
            tenHang = Console.ReadLine();
            Console.WriteLine("nhap so luong");
            soLuong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap don gia");
            donGia = Convert.ToInt32(Console.ReadLine());
            DonHang temp = new DonHang(hoTen, diaChi, soDienThoai, tenHang, soLuong, donGia);
            managerDonHang.EnQueue(temp);
        }

        public static void ProcessDonHang(ref Queue managerDonHang)
        {
            if (managerDonHang.Front == null)
            {
                Console.WriteLine("khong co don hang nao de xu ly");
                return;
            }
            DonHang temp = managerDonHang.DeQueue();
            while (temp != null)
            {
                Console.WriteLine(temp.ToString());
                if (managerDonHang.Peek() == null)
                {
                    Console.WriteLine();
                    return;
                }
                temp = managerDonHang.DeQueue();

            }
            Console.WriteLine();
        }
    }
}
