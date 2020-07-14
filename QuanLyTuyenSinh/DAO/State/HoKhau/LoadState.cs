using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.HoKhau
{
    class LoadState : IState<HOKHAU>
    {
        public bool doCRUDAction(HOKHAU obj)
        {
            throw new NotImplementedException();
        }

        public List<HOKHAU> doLoadAction()
        {
            List<HOKHAU> table = new List<HOKHAU>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADHoKhau");

            foreach (DataRow item in data.Rows)
            {
                HOKHAU hokhau = new HOKHAU(item);
                table.Add(hokhau);
            }
            return table;
        }
    }
}
