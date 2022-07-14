using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGUYENMINHKHOI_21211TT4621
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue arr = new Queue();
            char YN;
            do
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1. Nhap so luong don hang");
                Console.WriteLine("2. Xem thong tin tat ca don hang hien co");
                Console.WriteLine("3. Them mot don hang moi");
                Console.WriteLine("4. Xem thong tin don hang sap duoc xu ly");
                Console.WriteLine("5. Xu ly tat ca don hang");
                int chon;
                Console.Write("Chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        {
                            Console.Write("Nhap so luong don hang: ");
                            int n = int.Parse(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                                Console.WriteLine($"Don hang thu {i + 1}");
                                arr.EnQueue(NhapDonHang());
                            }
                        }
                        break;
                    case 2:
                        {
                            arr.Print();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Them mot don hang moi: ");
                            arr.EnQueue(NhapDonHang());
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Thong tin don hang sap duoc xu ly: ");
                            Console.WriteLine(arr.Peek());
                        }
                        break;
                    case 5:
                        {
                            XuLyTatCa(arr);
                        }
                        break;
                    default:
                        break;
                }
                Console.Write("Bam Y/y de tiep tuc thuc hien: ");
                YN = char.Parse(Console.ReadLine());
                Console.WriteLine();
            } while (YN == 'Y' || YN == 'y');
        }

        /// <summary>
        /// Ham nhap don hang
        /// </summary>
        /// <returns>Tra ve don hang da nhap</returns>
        static DonHang NhapDonHang()
        {
            string hoTen;
            string diaChi;
            string sdt;
            string tenHang;
            double donGia;
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine();
            while (hoTen=="")
            {
                Console.Write("Nhap lai ho ten: ");
                hoTen = Console.ReadLine();
            }
            Console.Write("Dia chi: ");
            diaChi = Console.ReadLine();
            while (diaChi == "")
            {
                Console.Write("Nhap lai dia chi: ");
                diaChi = Console.ReadLine();
            }
            Console.Write("So dien thoai: ");
            sdt = Console.ReadLine();
            Console.Write("Ten hang: ");
            tenHang = Console.ReadLine();
            Console.Write("Don gia: ");
            donGia = double.Parse(Console.ReadLine());
            DonHang d = new DonHang(hoTen, diaChi, sdt, tenHang, donGia);
            return d;
        }

        /// <summary>
        /// Ham xu ly tat ca don hang
        /// </summary>
        /// <param name="arr">Danh sach don hang</param>
        static void XuLyTatCa(Queue arr)
        {
            if (arr.Front == null)
            {
                Console.WriteLine("Khong co don hang nao can xu ly");
            }
            else
            {
                while (arr.Front != null)
                {
                    arr.DeQueue();
                }
                Console.WriteLine("Da xu ly het tat ca don hang");
                arr.Rear = null;
            }
        }
    }
}
