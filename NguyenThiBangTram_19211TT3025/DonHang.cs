using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KiemTra4
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
        private string v1;
        private string v2;
        private int v3;

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

        public DonHang(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public override string ToString()
        {
            return $"\nSTT: {sTT} \nHo ten: {hoTen} \nDia chi: {diaChi} \nSo DT: {soDT} \nTen hang: {tenHang} \nSo luong: {soLuong} \nDon gia: {donGia}";
        }
    }
}
