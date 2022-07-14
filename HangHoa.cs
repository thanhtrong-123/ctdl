using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQueue
{
    class HangHoa
    {
        private string maHang;
        private string tenHang;
        private int soLuong;
        private double donGia;

        public HangHoa(string maHang, string tenHang, int soLuong, double donGia)
        {
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }

        public override string ToString()
        {
            return $"{maHang}#{tenHang}#{soLuong}# {donGia}";
        }
    }


}
