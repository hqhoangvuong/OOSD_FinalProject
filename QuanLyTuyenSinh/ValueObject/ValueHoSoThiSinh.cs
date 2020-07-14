using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.ValueObject
{
    class ValueHoSoThiSinh
    {
        public string sbd;
        public string hodem;
        public string ten;
        public DateTime ngaysinh;
        public string gioitinh;
        public string tenhuyen;
        public string tentinh;
        public string doituong;
        public string dantoc;
        public double toan;
        public double ly;
        public double hoa;
        public double sinh;
        public double van;
        public double su;
        public double dia;
        public double anhvan;

        public ValueHoSoThiSinh(string sbd, string hodem, string ten, DateTime ngaysinh, string gioitinh, string tenhuyen, string tentinh, string doituong, string dantoc, double toan, double ly, double hoa, double sinh, double van, double su, double dia, double anhvan)
        {
            this.sbd = sbd;
            this.hodem = hodem;
            this.ten = ten;
            this.ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.tenhuyen = tenhuyen;
            this.tentinh = tentinh;
            this.doituong = doituong;
            this.dantoc = dantoc;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
            this.sinh = sinh;
            this.van = van;
            this.su = su;
            this.dia = dia;
            this.anhvan = anhvan;
        }

        public ValueHoSoThiSinh(string sbd)
        {
            this.sbd = sbd;
        }
    }
}
