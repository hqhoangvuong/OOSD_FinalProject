using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.Nganh
{
    class LoadState : IState<NGANH>
    {
        public bool doCRUDAction(NGANH obj)
        {
            throw new NotImplementedException();
        }

        public List<NGANH> doLoadAction()
        {
            List<NGANH> table = new List<NGANH>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADNganh");

            foreach (DataRow item in data.Rows)
            {
                NGANH nganh = new NGANH(item);
                table.Add(nganh);
            }

            return table;
        }
    }
}
