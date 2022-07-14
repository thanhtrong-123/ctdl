using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            //Nhap kho (nhap nhieu mat hang vao kho)
            NhapKho(ref q);

            //Xuat kho
            q.Print();

            //Xem mat hang sap duoc xuat kho
            HangHoa matHang = q.Peek();
            Console.WriteLine("==> Thong tin mat hang sap duoc xuat kho: ");
            Console.WriteLine(matHang.ToString());

            //Them moi mot mat hang vao kho
            Console.WriteLine("==> Nhap thong tin mat hang moi can them: ");
            HangHoa value = new HangHoa(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            q.Enqueue(value);
            Console.WriteLine("==>Hang doi sau khi them mat hang moi:");
            q.Print();

            //Xuat kho
            q.Dequeue();
            Console.WriteLine("Mot mat hang da duoc xuat ra khoi kho");
            Console.WriteLine("==> Tinh trang kho hien tai");
            q.Print();

        }

        static void NhapKho(ref Queue q)
        {
            int n;
            Console.WriteLine("Nhap so luong mat hang san co can nhap kho: ");
            n = int.Parse(Console.ReadLine());
            HangHoa value;
            string maHang;
            string tenHang;
            int soLuong;
            double donGia;

            for (int i = 1; i <= n; i++)
            {
                //voi moi i, nhap 1 mat hang moi vao kho
                Console.Write("Nhap ma hang/ten hang/so luong/don gia: ");
                maHang = Console.ReadLine();
                tenHang = Console.ReadLine();
                soLuong = int.Parse(Console.ReadLine());
                donGia = double.Parse(Console.ReadLine());

                value = new HangHoa(maHang, tenHang, soLuong, donGia);
                q.Enqueue(value);
            }
        }
    }
}
