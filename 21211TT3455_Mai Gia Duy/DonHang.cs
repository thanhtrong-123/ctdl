using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class DonHang
    {
        //fields
        private int soThuTuDonHang;
        private string hoTen;
        private string diaChi;
        private string soDienThoai;
        private string tenHang;
        private int soLuong;
        private long donGia;
        private static int Count = 0;
        
        //attributes
        public int SoThuTuDonHang
        {
            get
            {
                return soThuTuDonHang;
            }

            set
            {
                soThuTuDonHang = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string TenHang
        {
            get
            {
                return tenHang;
            }

            set
            {
                tenHang = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public long DonGia
        {
            get
            {
                return donGia;
            }

            set
            {
                donGia = value;
            }
        }

        //constructors
        public DonHang(string hoTen, string diaChi, string soDienThoai, string tenHang, int soLuong, long donGia)
        {
            SoThuTuDonHang = Count++;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            TenHang = tenHang;
            SoLuong = soLuong;
            DonGia = donGia;
        }

        public override string ToString()
        {
            return $"{SoThuTuDonHang}#{HoTen}#{DiaChi}#{soDienThoai}#{TenHang}#{SoLuong}#{DonGia}";
        }

    }
}
