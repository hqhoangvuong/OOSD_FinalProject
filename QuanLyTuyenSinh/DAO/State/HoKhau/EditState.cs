using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.HoKhau
{
    class EditState : IState<HOKHAU>
    {
        public bool doCRUDAction(HOKHAU obj)
        {
            int Edit = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("EDITHoKhau @mahokhau , @tentinh , @tenhhuyen , @makhuvuc , @tenkhuvuc", 
                new object[] { obj.MaHoKhau, obj.TenTinh, obj.TenHuyen, obj.MaKhuVuc, obj.TenKhuVuc });
            return Edit > 0;
        }

        public List<HOKHAU> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
