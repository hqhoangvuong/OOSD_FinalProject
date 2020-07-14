using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.ValueObject
{
    public class ValueDoiTuong
    {
        public int madoituong;
        public string loaidoituong;
        public double diemcongdtuong;

        public ValueDoiTuong()
        {
            this.madoituong = -1;
            this.loaidoituong = "";
            this.diemcongdtuong = -1.0;
        }

        public ValueDoiTuong(int madoituong, string loaidoituong, double diemcongdtuong)
        {
            this.madoituong = madoituong;
            this.loaidoituong = loaidoituong;
            this.diemcongdtuong = diemcongdtuong;
        }

        public ValueDoiTuong(int madoituong)
        {
            this.madoituong = madoituong;
        }
    }
}
