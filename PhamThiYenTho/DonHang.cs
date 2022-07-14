using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra
{
    class DonHang
    {
        private int sTT;
        private string hoTen;
        private string diaChi;
        private int soDT;
        private string tenHang;
        private int soLuong;
        private double donGia;

        public int STT
        {
            get
            {
                return sTT;
            }

            set
            {
                sTT = value;
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

        public int SoDT
        {
            get
            {
                return soDT;
            }

            set
            {
                soDT = value;
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

        public double DonGia
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
        public DonHang(int sTT, string hoTen, string diaChi, int soDT, string tenHang, int soLuong, double donGia)
        {
            this.sTT = sTT;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soDT = soDT;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
        public override string ToString()
        {
            return $"\nsTT{sTT} : \nhoTen{hoTen} : \ndiaChi{diaChi} : \nsoDT{soDT} : \ntenHang{tenHang} : \nsoLuong{soLuong} : \ndonGia{donGia}";
        }
    }
}
