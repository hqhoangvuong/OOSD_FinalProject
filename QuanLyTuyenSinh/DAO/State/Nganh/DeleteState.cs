using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.Nganh
{
    class DeleteState : IState<NGANH>
    {
        public bool doCRUDAction(NGANH obj)
        {
            int delete = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("DELETENganh @Id", 
                new object[] { int.Parse(obj.MaNganh) });

            return delete > 0;
        }

        public List<NGANH> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
