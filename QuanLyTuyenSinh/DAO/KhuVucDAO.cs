using QuanLyTuyenSinh.DAO.State;
using QuanLyTuyenSinh.DAO.State.KhuVuc;
using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO
{
    public class KhuVucDAO
    {
        private static KhuVucDAO instance;
        private GenericContext<KHUVUC> context;

        public static KhuVucDAO Instance 
        {
            get { if (instance == null) instance = new KhuVucDAO(); return instance; }
            private set { instance = value; }
        }

        private KhuVucDAO()
        {
            this.context = new GenericContext<KHUVUC>();
        }

        public List<KHUVUC> LoadTableKhuVuc()
        {
            context.setState(new LoadState());
            return context.doLoadAction();
        }
    }
}
