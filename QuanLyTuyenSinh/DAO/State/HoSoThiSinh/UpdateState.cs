using QuanLyTuyenSinh.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.HoSoThiSinh
{
    class UpdateState : IState<ValueHoSoThiSinh>
    {
        public bool doCRUDAction(ValueHoSoThiSinh obj)
        {
            int insert = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("UPDATEHoSoThiSinh @sbd , @hodem , @ten , @ngaysinh , @gioitinh , @tenhuyen , @tentinh , @doituong , @dantoc , @toan , @ly , @hoa , @sinh , @van , @su , @dia , @anhvan ", 
                new object[] { obj.sbd, obj.hodem, obj.ten, obj.ngaysinh, obj.gioitinh, obj.tenhuyen, obj.tentinh, obj.doituong, obj.dantoc, obj.toan, obj.ly, obj.hoa, obj.sinh, obj.van, obj.su, obj.dia, obj.anhvan });
            return insert > 0;
        }

        public List<ValueHoSoThiSinh> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
