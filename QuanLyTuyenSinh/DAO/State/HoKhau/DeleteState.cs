using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.HoKhau
{
    class DeleteState : IState<HOKHAU>
    {
        public bool doCRUDAction(HOKHAU obj)
        {
            int delete = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("DELETEHoKhau @Id", 
                new object[] { obj.MaHoKhau });

            return delete > 0;
        }

        public List<HOKHAU> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
