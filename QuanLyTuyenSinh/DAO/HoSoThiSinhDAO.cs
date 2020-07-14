using QuanLyTuyenSinh.DAO.State;
using QuanLyTuyenSinh.DAO.State.HoSoThiSinh;
using QuanLyTuyenSinh.ValueObject;
using System;


namespace QuanLyTuyenSinh.DAO
{
    public class HoSoThiSinhDAO
    {
        private static HoSoThiSinhDAO instance;
        private GenericContext<ValueHoSoThiSinh> context;

        public static HoSoThiSinhDAO Instance 
        {
            get { if (instance == null) instance = new HoSoThiSinhDAO(); return instance; }
            private set { instance = value; }
        }

        private HoSoThiSinhDAO()
        {
            context = new GenericContext<ValueHoSoThiSinh>();
        }


        public bool DeleteSinhVien(string sbd)
        {
            ValueHoSoThiSinh obj = new ValueHoSoThiSinh(sbd);

            context.setState(new DeleteState());
            return context.doAction(obj);
        }

        public bool InsertSinhVien(string sbd,string hodem,string ten,DateTime ngaysinh,string gioitinh,string tenhuyen,string tentinh,string doituong,string dantoc,double toan,double ly, double hoa,double sinh,double van,double su,double dia,double anhvan)
        {
            ValueHoSoThiSinh obj = new ValueHoSoThiSinh(sbd, hodem, ten, ngaysinh, gioitinh, tenhuyen, tentinh, doituong, dantoc, toan, ly, hoa, sinh, van, su, dia, anhvan);

            context.setState(new InsertState());
            return context.doAction(obj);
        }

        public bool UpdateSinhVien(string sbd, string hodem, string ten, DateTime ngaysinh, string gioitinh, string tenhuyen, string tentinh, string doituong, string dantoc, double toan, double ly, double hoa, double sinh, double van, double su, double dia, double anhvan)
        {
            ValueHoSoThiSinh obj = new ValueHoSoThiSinh(sbd, hodem, ten, ngaysinh, gioitinh, tenhuyen, tentinh, doituong, dantoc, toan, ly, hoa, sinh, van, su, dia, anhvan);

            context.setState(new UpdateState());
            return context.doAction(obj);
        }
    }
}
