using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.DoiTuong
{
    class LoadState : IState<DOITUONG>
    {
        public bool doCRUDAction(DOITUONG obj)
        {
            throw new NotImplementedException();
        }

        public List<DOITUONG> doLoadAction()
        {
            List<DOITUONG> table = new List<DOITUONG>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADDoiTuong");

            foreach (DataRow item in data.Rows)
            {
                DOITUONG doituong = new DOITUONG(item);
                table.Add(doituong);
            }

            return table;
        }
    }
}
