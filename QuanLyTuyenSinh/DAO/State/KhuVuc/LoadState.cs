using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.KhuVuc
{
    class LoadState : IState<KHUVUC>
    {
        public bool doCRUDAction(KHUVUC obj)
        {
            throw new NotImplementedException();
        }

        public List<KHUVUC> doLoadAction()
        {
            List<KHUVUC> table = new List<KHUVUC>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADKhuVuc");
            foreach (DataRow item in data.Rows)
            {
                KHUVUC khuvuc = new KHUVUC(item);
                table.Add(khuvuc);
            }
            return table;
        }
    }
}
