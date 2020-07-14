using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.Account
{
    class LoginState : IState<ACCOUNT>
    {
        public bool doCRUDAction(ACCOUNT obj)
        {
            string query = "dbo.CHECKLOGIN @UserName , @Pass";

            DataTable result = QuanLyTuyenSinhContext.Instance.ExecuteQuery(query, 
                new object[] { obj.UserName, obj.Pass });

            return result.Rows.Count > 0;
        }

        public List<ACCOUNT> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
