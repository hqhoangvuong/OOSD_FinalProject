using QuanLyTuyenSinh.DAO.State.DoiTuong;
using QuanLyTuyenSinh.ValueObject;
using QuanLyTuyenSinh.DAO.State;
using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO
{
    public class DoiTuongDAO
    {
        private static DoiTuongDAO instance;
        private GenericContext<DOITUONG> context;

        public static DoiTuongDAO Instance
        {
            get { if (instance == null) instance = new DoiTuongDAO(); return instance; }
            private set { instance = value; }
        }

        private DoiTuongDAO()
        {
            context = new GenericContext<DOITUONG>();
        }

        public List<DOITUONG> LoadTableDoiTuong()
        {
            context.setState(new LoadState());
            return context.doLoadAction();
        }

        public bool InsertDoiTuong(int madoituong, string loaidoituong, double diemcongdtuong)
        {
            DOITUONG obj = new DOITUONG(madoituong, loaidoituong, diemcongdtuong);

            context.setState(new InsertState());
            return context.doAction(obj);
            
        }

        public bool DeleteDoiTuong(int id)
        {
            DOITUONG obj = new DOITUONG(id);

            context.setState(new DeleteState());
            return context.doAction(obj);
        }

        public bool EditDoiTuong(int madoituong, string loaidoituong, double diemcongdtuong)
        {
            DOITUONG obj = new DOITUONG(madoituong, loaidoituong, diemcongdtuong);

            context.setState(new EditState());
            return context.doAction(obj);
        }
    }
}
