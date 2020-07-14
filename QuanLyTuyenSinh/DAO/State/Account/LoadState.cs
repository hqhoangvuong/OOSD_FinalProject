using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.ValueObject;

namespace QuanLyTuyenSinh.DAO.State.Account
{
    class LoadState : IState<ACCOUNT>
    {
        public bool doCRUDAction(ACCOUNT obj)
        {
            throw new NotImplementedException();
        }

        public List<ACCOUNT> doLoadAction()
        {
            List<ACCOUNT> table = new List<ACCOUNT>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADAccount");
            foreach (DataRow item in data.Rows)
            {
                ACCOUNT account = new ACCOUNT(item);
                table.Add(account);
            }
            return table;
        }
    }
}
