using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.NguyenVong
{
    class EditState : IState<NGUYENVONG>
    {
        public bool doCRUDAction(NGUYENVONG obj)
        {
            int edit = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("EDITNguyenVong @sbd , @tennganh , @khoi , @nguyenvong", 
                new object[] { obj.SBD, obj.TenNganh, obj.Khoi, obj.NguyenVong });
            return edit > 0;
        }

        public List<NGUYENVONG> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
