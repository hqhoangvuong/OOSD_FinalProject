using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.Nganh
{
    class EditState : IState<NGANH>
    {
        public bool doCRUDAction(NGANH obj)
        {
            int Edit = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("EDITNganh @manganh , @tennganh ,@chitieu , @diemchuan ", 
                new object[] { obj.MaNganh, obj.TenNganh, obj.ChiTieu, obj.DiemChuan });
            return Edit > 0;
        }

        public List<NGANH> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
