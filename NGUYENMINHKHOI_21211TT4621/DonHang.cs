using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NGUYENMINHKHOI_21211TT4621
{
    class DonHang
    {
        private int stt;
        static int dem = 1;
        private string _hoTen;
        private string _diaChi;
        private string _sdt;
        private string _tenHang;
        private double _donGia;

        public string HoTen
        {
            get
            {
                return _hoTen;
            }

            set
            {
                _hoTen = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return _diaChi;
            }

            set
            {
                _diaChi = value;
            }
        }

        public string Sdt
        {
            get
            {
                return _sdt;
            }

            set
            {
                _sdt = value;
            }
        }

        public string TenHang
        {
            get
            {
                return _tenHang;
            }

            set
            {
                _tenHang = value;
            }
        }

        public double DonGia
        {
            get
            {
                return _donGia;
            }

            set
            {
                _donGia = value;
            }
        }

        public  int Stt
        {
            get
            {
                return stt;
            }

            set
            {
                stt = value;
            }
        }

        public DonHang(string hoTen, string diaChi, string sdt, string tenHang, double donGia)
        {
            HoTen = hoTen;
            DiaChi = diaChi;
            Sdt = sdt;
            TenHang = tenHang;
            DonGia = donGia;
            stt = dem;
            dem++;
        }

        public override string ToString()
        {
            return $"{Stt}#{HoTen}#{DiaChi}#{Sdt}#{TenHang}#{DonGia:0,0}";
        }
    }
}
