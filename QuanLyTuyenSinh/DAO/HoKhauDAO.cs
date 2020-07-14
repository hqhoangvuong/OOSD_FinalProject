using QuanLyTuyenSinh.DAO.State;
using QuanLyTuyenSinh.DAO.State.HoKhau;
using QuanLyTuyenSinh.DTO;
using System.Collections.Generic;

namespace QuanLyTuyenSinh.DAO
{
    public class HoKhauDAO
    {
        private static HoKhauDAO instance;
        private GenericContext<HOKHAU> context;

        public static HoKhauDAO Instance 
        {
            get { if (instance == null) instance = new HoKhauDAO(); return instance; }
            private set { instance = value; }
        }

        private HoKhauDAO()
        {
            this.context = new GenericContext<HOKHAU>();
        }

        public List<HOKHAU> LoadTableHoKhau()
        {
            context.setState(new LoadState());
            return context.doLoadAction();
        }

        public bool InsertHoKhau(string tenhuyen,string tentinh,string tenkhuvuc)
        {
            HOKHAU obj = new HOKHAU(tenhuyen, tentinh, tenkhuvuc);

            context.setState(new InsertState());
            return context.doAction(obj);
        }

        public bool DeleteHoKhau(int id)
        {
            HOKHAU obj = new HOKHAU(id);

            context.setState(new InsertState());
            return context.doAction(obj);
        }

        public bool EditHoKhau(int mahokhau,string tentinh,string tenhuyen,string makhuvuc,string tenkhuvuc)
        {
            HOKHAU obj = new HOKHAU(mahokhau, tentinh, tenhuyen, makhuvuc, tenkhuvuc);

            context.setState(new EditState());
            return context.doAction(obj);
        }
    }
}
