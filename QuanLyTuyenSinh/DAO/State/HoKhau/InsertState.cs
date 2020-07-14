using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.HoKhau
{
    class InsertState : IState<HOKHAU>
    {
        public bool doCRUDAction(HOKHAU obj)
        {
            int insert = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("INSERTHoKhau @tenhuyen , @tentinh , @tenkhuvuc ",
                new object[] { obj.TenHuyen, obj.TenTinh, obj.TenKhuVuc });

            return insert > 0;
        }

        public List<HOKHAU> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
