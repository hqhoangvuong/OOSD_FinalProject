using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.ValueObject
{
    public class ValueAccount
    {
        public int Id { get; set; }
        public string nameperson { get; set; }
        public string username { get; set; }
        public string pass { get; set; }
        public int type { get; set; }

        public ValueAccount(int Id)
        {
            this.Id = Id;
        }

        public ValueAccount(string nameperson, string username, string pass, int type)
        {
            this.nameperson = nameperson;
            this.username = username;
            this.pass = pass;
            this.type = type;
        }

        public ValueAccount(int id, string nameperson, string username, string pass, int type)
        {
            this.Id = id;
            this.nameperson = nameperson;
            this.username = username;
            this.pass = pass;
            this.type = type;
        }

        public ValueAccount(int Id, string pass)
        {
            this.Id = Id;
            this.pass = pass;
        }
    }
}
