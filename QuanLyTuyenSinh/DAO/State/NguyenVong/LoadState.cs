using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyTuyenSinh.DAO.State.NguyenVong
{
    class LoadState : IState<NGUYENVONG>
    {
        public bool doCRUDAction(NGUYENVONG obj)
        {
            throw new NotImplementedException();
        }

        public List<NGUYENVONG> doLoadAction()
        {
            List<NGUYENVONG> table = new List<NGUYENVONG>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADNguyenVong");

            foreach (DataRow item in data.Rows)
            {
                NGUYENVONG nguyenvong = new NGUYENVONG(item);
                table.Add(nguyenvong);
            }

            return table;
        }
    }
}
