using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.DTO;

namespace QuanLyTuyenSinh.DAO.State.DoiTuong
{
    public class DeleteState : IState<DOITUONG>
    {
        public bool doCRUDAction(DOITUONG obj)
        {
            int delete = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("DELETEDoiTuong @Id", new object[] { obj.MaDoiTuong });

            return delete > 0;
        }

        public List<DOITUONG> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
