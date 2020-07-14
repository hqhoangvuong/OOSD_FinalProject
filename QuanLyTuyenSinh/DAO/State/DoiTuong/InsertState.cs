using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyTuyenSinh.DTO;

namespace QuanLyTuyenSinh.DAO.State.DoiTuong
{
    public class InsertState : IState<DOITUONG>
    {
        public bool doCRUDAction(DOITUONG obj)
        {
            int insert = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("INSERTDoiTuong @madoituong , @loaidoituong , @diemcongdtuong ", 
                new object[] { obj.MaDoiTuong, obj.LoaiDoiTuong, obj.DiemCongDTuong });

            return insert > 0;
        }

        public List<DOITUONG> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
