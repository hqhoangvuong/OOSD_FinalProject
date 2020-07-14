using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.ValueObject;

namespace QuanLyTuyenSinh.DAO.State.Account
{
    class EditState : IState<ACCOUNT>
    {
        public bool doCRUDAction(ACCOUNT obj)
        {
            int Update = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("UPDATEAccount @Id , @pass",
                new object[] { obj.ID, obj.Pass });
            return Update > 0;
        }

        public List<ACCOUNT> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
