using QuanLyTuyenSinh.DAO.State;
using QuanLyTuyenSinh.DAO.State.DanToc;
using QuanLyTuyenSinh.DTO;

using System.Collections.Generic;

namespace QuanLyTuyenSinh.DAO
{
    class DanTocDAO
    {
        private static DanTocDAO instance;
        private GenericContext<DANTOC> context;

        internal static DanTocDAO Instance 
        {
            get { if (instance == null) instance = new DanTocDAO(); return instance; }
            private set { instance = value; }
        }

        private DanTocDAO()
        {
            context = new GenericContext<DANTOC>();
        }

        public List<DANTOC> LoadTableDanToc()
        {
            context.setState(new LoadState()); 
            return context.doLoadAction();
        }
    }
}
