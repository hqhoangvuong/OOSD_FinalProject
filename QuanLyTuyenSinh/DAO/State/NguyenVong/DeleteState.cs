﻿using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO.State.NguyenVong
{
    class DeleteState : IState<NGUYENVONG>
    {
        public bool doCRUDAction(NGUYENVONG obj)
        {
            int delete = QuanLyTuyenSinhContext.Instance.ExecuteNonQuery("DELETENguyenVong @sbd , @tennganh , @khoi , @nguyenvong ", 
                new object[] { obj.SBD, obj.TenNganh, obj.Khoi, obj.NguyenVong });

            return delete > 0;
        }

        public List<NGUYENVONG> doLoadAction()
        {
            throw new NotImplementedException();
        }
    }
}
