using QuanLyTuyenSinh.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuyenSinh.PresentationLayer
{
    public partial class Thongtintaikhoan : Form
    {
        //private static Thongtintaikhoan instance;
        private int Id;
        private string nameAccount;
        private string passAccount;
        List<ACCOUNT> lstaccount;

        //public static Thongtintaikhoan Instance 
        //{
        //    get { if (instance == null) instance = new Thongtintaikhoan(); return instance; }
        //    private set { instance = value; }
        //}

        public Thongtintaikhoan(string name)
        {
            InitializeComponent();
            this.nameAccount = name;
            Load();
        }
        private void Load()
        {
            try
            {
                lstaccount = AccountDAO.Instance.LoadAccount();
                //dgvaccount.DataSource = lstaccount;
            }
            catch
            {
                MessageBox.Show("Load bi loi.");
            }
            foreach (ACCOUNT item in lstaccount)
            {
                if (item.UserName == nameAccount)
                {
                    this.Id = item.ID;
                    tbxtendangnhap.Text = item.UserName;
                    tbxten.Text = item.NamePerson;
                    tbxquyenhan.Text = item.TypePerson.ToString();
                    tbxmatkhaucu.Text = item.Pass;
                    tbxtenhienthi.Text = item.NamePerson;
                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string Newpass = tbxmatkhaumoi.Text;
            if(AccountDAO.Instance.UpdateAccount(this.Id,Newpass))
            {
                MessageBox.Show("Thay doi mat khau Account thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay doi mat khau Account thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
