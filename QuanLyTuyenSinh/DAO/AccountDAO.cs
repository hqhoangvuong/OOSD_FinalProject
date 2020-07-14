using System;
using QuanLyTuyenSinh.ValueObject;
using QuanLyTuyenSinh.DAO.State.Account;
using QuanLyTuyenSinh.DAO.State;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTuyenSinh.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        private GenericContext<ACCOUNT> context;

        public static AccountDAO Instance 
        {
            get { if (instance == null) instance = new AccountDAO();  return instance; }
            private set { instance = value; } 
        }

        private AccountDAO()
        {
            this.context = new GenericContext<ACCOUNT>();
        }

        public bool Login(string userName,string passWord)
        {
            ACCOUNT obj = new ACCOUNT(userName, passWord);

            context.setState(new LoginState());
            return context.doAction(obj);
        }

        public List<ACCOUNT> LoadAccount()
        { 

            context.setState(new LoadState());
            return context.doLoadAction();
        }

        public bool Insert(string nameperson,string username,string pass,int type)
        {
            ACCOUNT obj = new ACCOUNT(nameperson, username, pass, type);

            context.setState(new InsertState());
            return context.doAction(obj);
        }

        public bool RePass(int Id, string pass)
        {
            ACCOUNT obj = new ACCOUNT(Id, pass);

            context.setState(new RePassState());
            return context.doAction(obj);
        }

        public bool Delete(int Id)
        {
            ACCOUNT obj = new ACCOUNT(Id);


            
            context.setState(new DeleteState());
            return context.doAction(obj);
        }

        public bool UpdateAccount(int Id,string pass)
        {
            ACCOUNT obj = new ACCOUNT(Id, pass);

            context.setState(new EditState());
            return context.doAction(obj);
        }
    }
}
