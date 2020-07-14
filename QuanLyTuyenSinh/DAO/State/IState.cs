using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State
{
    public interface IState <T> where T: class
    {
        bool doCRUDAction(T obj);

        List<T> doLoadAction();
    }
}
