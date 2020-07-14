using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.DTO;

namespace QuanLyTuyenSinh.DAO.State.DoiTuong
{
    public class EditState : IState<DOITUONG>
    {
        public bool doCRUDAction(DOITUONG obj)
        {
            int Edit = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("EDITDoiTuong @madoituong , @loaidoituong , @diemcongdtuong ", 
                new object[] { obj.MaDoiTuong, obj.LoaiDoiTuong, obj.DiemCongDTuong });
            return Edit > 0;
        }

        public List<DOITUONG> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
