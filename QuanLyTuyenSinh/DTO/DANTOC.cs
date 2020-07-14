using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DTO
{
    public class DANTOC
    {
        [Key]
        private int maDanToc;
        private string tenDanToc;
        private double diemDanToc;

        public int MaDanToc { get => maDanToc; set => maDanToc = value; }
        public string TenDanToc { get => tenDanToc; set => tenDanToc = value; }
        public double DiemDanToc { get => diemDanToc; set => diemDanToc = value; }

        public DANTOC() { }
        public DANTOC(int madantoc, string tendantoc, double diemcong)
        {
            this.MaDanToc = madantoc;
            this.TenDanToc = tendantoc;
            this.DiemDanToc = diemcong;
        }

        public DANTOC(DataRow row)
        {
            this.MaDanToc = (int)row["MaDanToc"];
            this.TenDanToc = row["TenDanToc"].ToString();
            this.DiemDanToc = (double)row["DiemCongDToc"];
        }

    }
}
