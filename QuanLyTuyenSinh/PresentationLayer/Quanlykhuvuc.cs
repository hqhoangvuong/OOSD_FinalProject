using QuanLyTuyenSinh.DAO;
using QuanLyTuyenSinh.DTO;
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
    public partial class Quanlykhuvuc : Form
    {
        List<HOKHAU> listHK;
        List<KHUVUC> listKV;
        private int row;
        public Quanlykhuvuc()
        {
            listHK = new List<HOKHAU>();
            listKV = new List<KHUVUC>();
            // Load Ban đầu.
            listKV = KhuVucDAO.Instance.LoadTableKhuVuc();
            listHK = HoKhauDAO.Instance.LoadTableHoKhau();

            


            InitializeComponent();
            //Load DGV

            foreach (HOKHAU item in listHK)
            {
                cmbTenTinh.Items.Add(item.TenTinh);
                cmbTenHuyen.Items.Add(item.TenHuyen);
            }
            foreach (KHUVUC item in listKV)
            {
                cmbKhuVuc.Items.Add(item.TenKhuVuc);
                cbbKhuVuc.Items.Add(item.TenKhuVuc);
            }
            LoadTableKhuVuc();
            LoadTableHoKhau();
            
        }

        

        #region Methods
        private void LoadTableKhuVuc()
        {
            DataTable table = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADdataKHUVUC");
            listKV = KhuVucDAO.Instance.LoadTableKhuVuc();
            dgvdanhmuckhuvuc.DataSource = table;

            //
            btnTra.Enabled = true;
            //
            
            
            
        }

        public void LoadTableHoKhau()
        {
            dgvHoKhau.Columns[0].Visible = false; // Ẩn cột đã chọn (MaHoKhau)
            dgvHoKhau.Columns[3].Visible = false;
            //Lấy danh sách table load từ SQL lên
            listHK = HoKhauDAO.Instance.LoadTableHoKhau();
            dgvHoKhau.DataSource = listHK;

            //Đóng nữa nút ban đầu không cần thiết
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;

            //Đặt tên sẵn cho combobox
            cmbTenTinh.Text = listHK[0].TenTinh;
            cmbTenHuyen.Text = listHK[0].TenHuyen;
            cmbKhuVuc.Text = listHK[0].TenKhuVuc;

            //Load danh sách cho ComboBox
            
        }



        #endregion

        #region EventsHoKhau

        #region Them
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //
            btnLuu.Enabled = true;
            btnhuy.Enabled = true;

            //
            cmbTenTinh.Text = "";
            cmbTenHuyen.Text = "";
            cmbKhuVuc.Text = "";
            //
        }
        #endregion

        #region Xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmbTenTinh.Text = "";
            cmbTenHuyen.Text = "";
            cmbKhuVuc.Text = "";
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;


            int id = Convert.ToInt32(dgvHoKhau.Rows[row].Cells[0].Value);

            if (HoKhauDAO.Instance.DeleteHoKhau(id))
            {
                MessageBox.Show("Xoa Ho Khau Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTableHoKhau();
            }
            else
            {
                MessageBox.Show("Xoa Ho Khau That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tentinh = cmbTenTinh.Text;
            string tenhuyen = cmbTenHuyen.Text;
            string tenkhuvuc = cmbKhuVuc.Text;

            if (HoKhauDAO.Instance.InsertHoKhau(tenhuyen, tentinh, tenkhuvuc))
            {
                MessageBox.Show("Them Ho Khau Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTableHoKhau();
            }
            else
            {
                MessageBox.Show("Them Ho Khau That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Huy
        private void btnhuy_Click(object sender, EventArgs e)
        {
            cmbTenTinh.Text = "";
            cmbTenHuyen.Text = "";
            cmbKhuVuc.Text = "";
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;

        }

        #endregion

        #region Sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;

            int mahokhau = Convert.ToInt32(dgvHoKhau.Rows[row].Cells[0].Value);
            string tentinh = cmbTenTinh.Text;
            string tenhuyen = cmbTenHuyen.Text;
            string makhuvuc = dgvHoKhau.Rows[row].Cells[3].Value.ToString();
            string tenkhuvuc = cmbKhuVuc.Text;

            if (HoKhauDAO.Instance.EditHoKhau(mahokhau, tentinh, tenhuyen, makhuvuc, tenkhuvuc))
            {
                MessageBox.Show("Sua Ho Khau Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTableHoKhau();

                cmbTenTinh.Text = "";
                cmbTenHuyen.Text = "";
                cmbKhuVuc.Text = "";

            }
            else
            {
                MessageBox.Show("Sua Ho Khau That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        #endregion

        #region Click
        private void dgvHoKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvHoKhau.CurrentCell.RowIndex;

            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            //
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnhuy.Enabled = true;

            try
            {
                cmbTenHuyen.Text = dgvHoKhau.Rows[row].Cells[1].Value.ToString();
                cmbTenTinh.Text = dgvHoKhau.Rows[row].Cells[2].Value.ToString();
                cmbKhuVuc.Text = dgvHoKhau.Rows[row].Cells[4].Value.ToString();
            }
            catch
            { }
        }
        #endregion

        #endregion


        #region EventsKhuVuc

        #region Them
        private void btnthem2_Click(object sender, EventArgs e)
        {
            string tenkhuvuc = cbbKhuVuc.Text;
            DataTable table = QuanLyTuyenSinhContext.Instance.ExecuteQuery("SEARCHKhuVuc @khuvuc ", new object[] { tenkhuvuc });
            dgvdanhmuckhuvuc.DataSource = table;
        }
        #endregion
        #region Sua
        private void btnsua2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Xoa
        private void btnxoa2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Luu
        private void btnluu2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Huy
        private void btnhuy2_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #endregion

        private void Quanlykhuvuc_Load(object sender, EventArgs e)
        {

        }
    }
}
