using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EXE2
{
    class Donhang
    {
        private int stt;
        private string hoTen;
        private string diaChi;
        private int sdt;
        private string tenHang;
        private int soLuong;
        private double donGia;

        public int Stt
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

        public int Sdt
        {
            get
            {
                return sdt;
            }

            set
            {
                sdt = value;
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

        public Donhang(int stt, string hoTen, string diaChi, int sdt, string tenHang, int soLuong, double donGia)
        {
            this.stt = stt;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.sdt = sdt;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
        }
        public override string ToString()
        {
            return $"STT {stt} \n Ho ten: {hoTen} \n Dia chi: {diaChi} \n SDT: {sdt} \n Ten hang: {tenHang} \n So luong: {soLuong} \n Don gia: {donGia}";
        }
    }
}
