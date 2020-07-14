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
    public partial class QuanlyAccount : Form
    {
        List<ACCOUNT> lstaccount;
        private int row;
        public QuanlyAccount()
        {
            InitializeComponent();
            lstaccount = new List<ACCOUNT>();
            LoadTable();
            
       
        }
        #region Methods
        private void LoadTable()
        {
            dgvaccount.Columns[0].Visible = false;
            dgvaccount.Columns[3].Visible = false;
            tbxten.Enabled = false;
            tbxuser.Enabled = false;
            chbxadmin.Enabled = false;
            btnluu.Enabled = false;
            btnEdit.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = false;
            //
            btnthem.Enabled = true;
            try
            {
                lstaccount = AccountDAO.Instance.LoadAccount();
                dgvaccount.DataSource = lstaccount;
            }
            catch
            {
                MessageBox.Show("Load Table bi loi.");
            }
            
        }


        #endregion

        #region Events
        #region Them

        private void btnthem_Click(object sender, EventArgs e)
        {
            tbxten.Text = "";
            tbxuser.Text = "";
            chbxadmin.Checked = false;


            tbxten.Enabled = true;
            tbxuser.Enabled = true;
            chbxadmin.Enabled = true;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            //
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnEdit.Enabled = false;

        }
        #endregion

        #region Luu
        private void btnluu_Click(object sender, EventArgs e)
        {
            string namePerson = tbxten.Text;
            string userName = tbxuser.Text;
            string pass = "1";
            int typePerson;
            if (chbxadmin.Checked == true)
            {
                typePerson = 1;
            }
            else
                typePerson = 2;

            if (AccountDAO.Instance.Insert(namePerson, userName, pass, typePerson))
            {
                try
                { 
                    MessageBox.Show("Ban Da Them Tai Khoan Thanh Cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTable();
                }
                catch
                {
                    MessageBox.Show("Co Loi Them Tai Khoan", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            else
            {
                MessageBox.Show("Co Loi Them Tai Khoan", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Huy
        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
            //
            tbxten.Enabled = false;
            tbxuser.Enabled = false;
            chbxadmin.Enabled = false;
            btnhuy.Enabled = false;
            btnluu.Enabled = false;

            tbxten.Text = "";
            tbxuser.Text = "";
            chbxadmin.Checked = false;
        }
        #endregion

        #region Sua
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string pass = "1";
            if(AccountDAO.Instance.RePass(lstaccount[row].ID,pass))
            {
                MessageBox.Show("Da reset pass", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Ko reset duoc", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
        #endregion

        #region Xoa
        private void btnxoa_Click(object sender, EventArgs e)
        {
            
            if (AccountDAO.Instance.Delete(lstaccount[row].ID))
            {
                MessageBox.Show("Da Xoa Account","Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadTable();
                tbxten.Text = "";
                tbxuser.Text = "";
                chbxadmin.Checked = false;
            }
            else
            {
                MessageBox.Show("Ko xoa duoc", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        #endregion

        #region Click Dong
        private void dgvaccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvaccount.CurrentCell.RowIndex;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            /////
            btnxoa.Enabled = true;
            btnEdit.Enabled = true;
            btnthem.Enabled = true;


            try
            {
                tbxuser.Text = dgvaccount.Rows[row].Cells[1].Value.ToString();
                tbxten.Text = dgvaccount.Rows[row].Cells[3].Value.ToString();
                string check = dgvaccount.Rows[row].Cells[4].Value.ToString();
                if (check == "1")
                {
                    chbxadmin.Checked = true;
                }
                else
                    chbxadmin.Checked = false;
            }
            catch
            { }
        }
        #endregion

        #endregion


    }
}
