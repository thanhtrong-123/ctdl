using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NguyenVuAnh_21211TT1568
{
    /*
     * Nguyen Vu Anh
     * 21211TT1568
     * class: Don hang
     */
    class Donhang
    {
        // fields
        private string hoten;
        private string diachi;
        private string sdt;
        private int stt;
        private string tenhang;
        private int soluong;
        private double gia;
        private static int Sott;
        // ham tao Don hang
        public Donhang(string hoten, string diachi, string sdt,string tenhang, int soluong, double gia)
        {
            Sott++;
            this.hoten = hoten;
            this.diachi = diachi;
            this.sdt = sdt;
            stt = Sott;
            this.tenhang = tenhang;
            this.soluong = soluong;
            this.gia = gia;
            
        }
       static Donhang()
        {
            Sott = 0;
        }   
        // xuat thong tin don hang                
        public string toString()
        {
            return $"Stt: {stt}\t Ho ten: {hoten}\tDia chi: {diachi}\tSDT: {sdt}\tten hang: {tenhang}\tso luong: {soluong}\tGia: {gia}";
        }



 
    }
}
