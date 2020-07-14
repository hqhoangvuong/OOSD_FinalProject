using QuanLyTuyenSinh.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.HoSoThiSinh
{
    class DeleteState : IState<ValueHoSoThiSinh>
    {
        public bool doCRUDAction(ValueHoSoThiSinh obj)
        {
            int delete = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("DELETEHoSoThiSinh @sbd", 
                new object[] { obj.sbd });
            return delete > 0;
        }

        public List<ValueHoSoThiSinh> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
