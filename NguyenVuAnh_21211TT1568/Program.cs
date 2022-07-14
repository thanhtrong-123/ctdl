using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenVuAnh_21211TT1568
{
    /*
     * Nguyen Vu Anh
     * 21211TT1568
     * program
     */
    class Program
    {
        static void Main(string[] args)
        {
            // khai bao bien
            // bien ho ten
            string hoten;
            // bien dia chi
            string diachi;
            // bien sdt
            string sdt;
            // bien ten hang
            string tenhang;
            // bien so luong
            int soluong;
            // bien gia
            double gia;
            // tao don hang;
            Donhang donhang;
            // tao Quere() ==> Quere khong tham so
            Quere q = new Quere();
            // bien chon
            int chon;
            // bien so luong don hang
            int soluongDH;
            // bien tra loi
            char traloi = ' ';

            do
            {
                Console.WriteLine("1. Xem thong tin tat ca don hang hien co");
                Console.WriteLine("2. Them mot don hang moi");
                Console.WriteLine("3. Xem thong tin don hang sap duoc xu ly");
                Console.WriteLine("4. Xu ly tat ca don hang cua khach hang");
                chon = int.Parse(Console.ReadLine());
                // neu chon = 1
                if (chon == 1)
                {
                    // xuat danh sach
                    q.DisPlay();
                }
                // neu chon = 2
                else if (chon == 2)
                {
                    do
                    {
                        // nhac nhap so luong don hang
                        Console.Write("So luong don hang: ");
                        // nhap so luong don hang
                        soluongDH = int.Parse(Console.ReadLine());
                        if (soluongDH <= 0)
                        {
                            Console.WriteLine("So luong don hang khong tha thi. Vui long nhap lai");
                        }
                    } while (soluongDH <= 0);
                    // vong lap
                    for (int i = 1; i <= soluongDH; i++)
                    {
                        Console.WriteLine($" ------ Don hang thu {i} ----- ");
                        // nhac nhap hoten
                        Console.Write("Ho ten khach hang: ");
                        // nhap ho ten
                        hoten = Console.ReadLine();
                        // nhac nhap dia chi
                        Console.Write("Dia chi: ");
                        // nhap dia chi
                        diachi = Console.ReadLine();
                        // nhac nhap sdt
                        Console.Write("SDT: ");
                        // nhap sdt
                        sdt = Console.ReadLine();
                        // nhac nhap ten hang
                        Console.Write("Ten hang: ");
                        // nhap ten hang
                        tenhang = Console.ReadLine();
                        // nhac nhap so luong
                        Console.Write("So luong: ");
                        soluong = int.Parse(Console.ReadLine());
                        // nhac nhap gia
                        Console.Write("Gia: ");
                        gia = double.Parse(Console.ReadLine());
                        // cap gai tri vao don hang;
                        donhang = new Donhang(hoten, diachi, sdt,tenhang,soluong,gia);
                        // them don hang vao Quere
                        q.EnQuere(donhang);

                    }
                }
                //neu chon = 3
                else if (chon == 3)
                {
                    Console.WriteLine($"Don hang sap duoc xu ly: {q.Peek().toString()}");
                }
                //neu chon = 4
                else if (chon == 4)
                {
                    Console.WriteLine("----- Xu ly tat ca don hang----");
                    // vong lap do ... while xem nguoi dung co muon xu ly tiep khong
                    do
                    {
                        // neu danh sach khong co don hang nao
                        if (q.getCount() == 0)
                        {
                            Console.WriteLine("Khong co don hang nao cho xu ly");
                            break;
                        }
                        // nguoc lai
                        else
                        {
                            Console.Write($"Ban muon xu ly don hang {q.Peek().toString()} nay khong (Y/N): ");
                            traloi = char.Parse(Console.ReadLine());
                            if (traloi == 'y' || traloi == 'Y')
                            {
                                q.DeQuere();
                                Console.WriteLine($"Don hang da xu ly thanh cong");
                            }
                        }
                        // hoi muon xu ly tiep khong
                        Console.Write("Ban muon xu ly tiep khong (Y/N): ");
                        traloi = char.Parse(Console.ReadLine());
                        if (traloi == 'Y' || traloi == 'y')
                        {
                            Console.Clear();
                        }
                    } while (traloi == 'Y' || traloi == 'y');
                }
                // hoi muon chon lai khong
                Console.Write($"Ban muon chon lai khong (Y/N): ");
                traloi = char.Parse(Console.ReadLine());
                if (traloi == 'y' || traloi == 'Y')
                {
                    Console.Clear();
                }
            } while (traloi == 'y' || traloi == 'Y');         

        }
    }
}
