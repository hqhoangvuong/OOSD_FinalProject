using QuanLyTuyenSinh.DAO.State;
using QuanLyTuyenSinh.DAO.State.Nganh;
using QuanLyTuyenSinh.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyTuyenSinh.DAO
{
    public class NganhDAO
    {
        private static NganhDAO instance;
        private GenericContext<NGANH> context;

        public static NganhDAO Instance {
            get { if (instance == null) instance = new NganhDAO(); return instance; }
            private set { instance = value; }
        }

        private NganhDAO()
        {
            this.context = new GenericContext<NGANH>();
        }

        public List<NGANH> Fn_Nganh()
        {
            context.setState(new LoadState());
            return context.doLoadAction();
        }

        public bool InsertNganh(string manganh, string tennganh, int chitieu, double diemchuan)
        {
            NGANH obj = new NGANH(manganh, tennganh, chitieu, diemchuan);

            context.setState(new InsertState());
            return context.doAction(obj);
        }

        public bool DeleteNganh(int id)
        {
            NGANH obj = new NGANH(id.ToString());

            context.setState(new DeleteState());
            return context.doAction(obj);
        }

        public bool EditNganh(string manganh, string tennganh, int chitieu, double diemchuan)
        {
            NGANH obj = new NGANH(manganh, tennganh, chitieu, diemchuan);

            context.setState(new DeleteState());
            return context.doAction(obj);
        }

        //public bool SearchNganh(string manganh, string tennganh, int chitieu, double diemchuan)
        //{
        //    int search = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("SearchNganh @manganh , @tennganh , @chitieu , @diemchuan ", new object[] { manganh, tennganh, chitieu, diemchuan });

        //    return search > 0;
        //}

    }
}
