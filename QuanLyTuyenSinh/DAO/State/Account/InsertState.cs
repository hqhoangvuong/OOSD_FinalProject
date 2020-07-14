using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.ValueObject;

namespace QuanLyTuyenSinh.DAO.State.Account
{
    class InsertState : IState<ACCOUNT>
    {
        public bool doCRUDAction(ACCOUNT obj)
        {
            int result = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("INSERTAccount @NamePerson , @UserName , @Pass , @TypePerson", 
                new object[] { obj.NamePerson, obj.UserName, obj.Pass, obj.TypePerson });

            return result > 0;
        }

        public List<ACCOUNT> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
