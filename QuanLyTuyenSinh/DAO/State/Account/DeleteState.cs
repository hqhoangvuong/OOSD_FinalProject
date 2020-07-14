using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.ValueObject;

namespace QuanLyTuyenSinh.DAO.State.Account
{
    class DeleteState : IState<ACCOUNT>
    {
        public bool doCRUDAction(ACCOUNT obj)
        {
            int Delete = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("DELETEAccount @Id",
                new object[] { obj.ID });

            return Delete > 0;
        }

        public List<ACCOUNT> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
