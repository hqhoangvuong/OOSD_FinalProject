using QuanLyTuyenSinh.DAO.State;
using QuanLyTuyenSinh.DAO.State.NguyenVong;
using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO
{
    class NguyenVongDAO
    {
        private static NguyenVongDAO instance;
        private GenericContext<NGUYENVONG> context;

        internal static NguyenVongDAO Instance 
        {
            get { if (instance == null) instance = new NguyenVongDAO(); return instance; }
            private set { instance = value; }
        }

        private NguyenVongDAO() 
        {
            this.context = new GenericContext<NGUYENVONG>();
        }

        public List<NGUYENVONG> LoadTableNguyenVong()
        {
            context.setState(new LoadState());
            return context.doLoadAction();
        }

        public bool InsertNguyenVong(string sbd,string tenganh,string khoi,int nguyenvong)
        {
            NGUYENVONG obj = new NGUYENVONG(sbd, tenganh, khoi, nguyenvong);

            context.setState(new InsertState());
            return context.doAction(obj);
        }

        public bool EditNguyenVong(string sbd,string tennganh,string khoi,int nguyenvong)
        {
            NGUYENVONG obj = new NGUYENVONG(sbd, tennganh, khoi, nguyenvong);

            context.setState(new EditState());
            return context.doAction(obj);
        }
        public bool DeleteNguyenVong(string sbd,string tennganh,string khoi,int nguyenvong)
        {
            NGUYENVONG obj = new NGUYENVONG(sbd, tennganh, khoi, nguyenvong);

            context.setState(new EditState());
            return context.doAction(obj);
        }
    }
}
