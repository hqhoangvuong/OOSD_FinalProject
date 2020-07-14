using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DTO
{
    class NGUYENVONG
    {
        private string sBD;
        private string hoTen;
        private string maNganh;
        private string tenNganh;
        private string khoi;
        private int nguyenVong;

        public string SBD { get => sBD; set => sBD = value; }
        public string MaNganh { get => maNganh; set => maNganh = value; }
        public string Khoi { get => khoi; set => khoi = value; }
        public int NguyenVong { get => nguyenVong; set => nguyenVong = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string TenNganh { get => tenNganh; set => tenNganh = value; }

        public NGUYENVONG() { }

        public NGUYENVONG(string sbd, string manganh, string khoi, int nguyenvong, double diemTB)
        {
            this.SBD = sbd;
            this.MaNganh = manganh;
            this.Khoi = khoi;
            this.NguyenVong = nguyenvong;
            //this.DiemTB = diemTB;
        }

        public NGUYENVONG(DataRow row)
        {
            this.SBD = row["SBD"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.TenNganh = row["TenNganh"].ToString();
            this.MaNganh = row["TenNganh"].ToString();
            this.Khoi = row["Khoi"].ToString();
            this.NguyenVong = (int)row["NguyenVong"];
            
        }

        public NGUYENVONG(string sbd, string tenganh, string khoi, int nguyenvong)
        {
            this.SBD = sbd;
            this.tenNganh = tenganh;
            this.Khoi = khoi;
            this.NguyenVong = nguyenvong;
        }
    }
}
