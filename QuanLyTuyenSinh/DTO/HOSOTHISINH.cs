using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DTO
{
    class HOSOTHISINH
    {
        private string iD;
        private string hoDem;
        private string ten;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private int maHoKhau;
        private string tenHuyen;
        private string tenTinh;
        private int maDoiTuong;
        private string loaiDoiTuong;
        private int maDanToc;
        private string tenDanToc;
        private double toan;
        private double ly;
        private double sinh;
        private double hoa;
        private double van;
        private double su;
        private double dia;
        private double anhVan;


        public string ID { get => iD; set => iD = value; }
        public string HoDem { get => hoDem; set => hoDem = value; }
        public string Ten { get => ten; set => ten = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TenHuyen { get => tenHuyen; set => tenHuyen = value; }
        public string TenTinh { get => tenTinh; set => tenTinh = value; }
        public string LoaiDoiTuong { get => loaiDoiTuong; set => loaiDoiTuong = value; }
        public string TenDanToc { get => tenDanToc; set => tenDanToc = value; }
        public int MaHoKhau { get => maHoKhau; set => maHoKhau = value; }
        public int MaDoiTuong { get => maDoiTuong; set => maDoiTuong = value; }
        public int MaDanToc { get => maDanToc; set => maDanToc = value; }
        public double Toan { get => toan; set => toan = value; }
        public double Ly { get => ly; set => ly = value; }
        public double Sinh { get => sinh; set => sinh = value; }
        public double Hoa { get => hoa; set => hoa = value; }
        public double Van { get => van; set => van = value; }
        public double Su { get => su; set => su = value; }
        public double Dia { get => dia; set => dia = value; }
        public double AnhVan { get => anhVan; set => anhVan = value; }

        public HOSOTHISINH(DataRow row)
        {
            this.ID = row["SBD"].ToString();
            this.HoDem = row["HoDem"].ToString();
            this.Ten = row["Ten"].ToString();
            this.NgaySinh=(DateTime)row["NgaySinh"];
            this.GioiTinh = (bool)row["GioiTinh"];
            this.MaHoKhau = (int)row["MaHoKhau"];
            this.TenHuyen = row["TenHuyen"].ToString();
            this.TenTinh = row["TenTinh"].ToString();
            this.MaDoiTuong = (int)row["MaDoiTuong"];
            this.LoaiDoiTuong = row["LoaiDoiTuong"].ToString();
            this.MaDanToc = (int)row["MaDanToc"];
            this.TenDanToc = row["TenDanToc"].ToString();
            this.Toan = (double)row["Toan"];
            this.Ly= (double)row["Ly"];
            this.Hoa = (double)row["Hoa"];
            this.Sinh = (double)row["Sinh"];
            this.Van= (double)row["Van"];
            this.Su= (double)row["Su"];
            this.Dia = (double)row["Dia"];
            this.AnhVan = (double)row["AnhVan"];




        }
    }
}
