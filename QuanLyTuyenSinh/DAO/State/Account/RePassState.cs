using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.ValueObject;

namespace QuanLyTuyenSinh.DAO.State.Account
{
    class RePassState : IState<ACCOUNT>
    {
        public bool doCRUDAction(ACCOUNT obj)
        {
            int RePass = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("RePassAccount @Id , @Pass",
                new object[] { obj.ID, obj.Pass });

            return RePass > 0;
        }

        public List<ACCOUNT> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
