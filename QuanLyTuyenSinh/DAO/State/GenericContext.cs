using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State
{
    class GenericContext<T> where T: class
    {
        private IState<T> state;

        public GenericContext()
        {
            state = null;
        }

        public void setState(IState<T> state)
        {
            this.state = state;
        }

        public bool doAction(T obj)
        {
            return state.doCRUDAction(obj);
        }

        public List<T> doLoadAction()
        {
            return state.doLoadAction();
        }
    }
}
