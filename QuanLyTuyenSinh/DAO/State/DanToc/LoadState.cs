using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.DanToc
{
    class LoadState : IState<DANTOC>
    {
        public bool doCRUDAction(DANTOC obj)
        {
            throw new NotImplementedException();
        }

        public List<DANTOC> doLoadAction()
        {
            List<DANTOC> table = new List<DANTOC>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADDanToc");

            foreach (DataRow item in data.Rows)
            {
                DANTOC dT = new DANTOC(item);
                table.Add(dT);
            }

            return table;
        }
    }
}
