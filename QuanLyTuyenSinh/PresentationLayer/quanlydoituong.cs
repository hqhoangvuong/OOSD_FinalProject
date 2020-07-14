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
    public partial class quanlydoituong : Form
    {
        List<DOITUONG> listDT;
        private int row;
        public quanlydoituong()
        {
            listDT = new List<DOITUONG>();
            listDT = DoiTuongDAO.Instance.LoadTableDoiTuong();
            InitializeComponent();
            foreach (DOITUONG item in listDT)
            {
                cmbMadoituong.Items.Add(item.MaDoiTuong);
                cmbTendoituong.Items.Add(item.LoaiDoiTuong);
                cmbDiemcong.Items.Add(item.DiemCongDTuong);
            }
            LoadTable();
        }

        public void LoadTable()
        {
            dgvDoiTuong.DataSource = DoiTuongDAO.Instance.LoadTableDoiTuong();
            dgvDoiTuong.DataSource = listDT;
            //Đóng nữa nút ban đầu không cần thiết
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //
            btnLuu.Enabled = true;
            btnhuy.Enabled = true;

            //
            cmbMadoituong.Text = "";
            cmbTendoituong.Text = "";
            cmbDiemcong.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmbMadoituong.Text = "";
            cmbTendoituong.Text = "";
            cmbDiemcong.Text = "";
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;


            int id = Convert.ToInt32(dgvDoiTuong.Rows[row].Cells[0].Value);

            if (DoiTuongDAO.Instance.DeleteDoiTuong(id))
            {
                MessageBox.Show("Xoa Doi Tuong Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTable();
            }
            else
            {
                MessageBox.Show("Xoa Doi Tuong That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;

            int madoituong = Convert.ToInt32(dgvDoiTuong.Rows[row].Cells[0].Value);
            string loaidoituong = cmbTendoituong.Text;
            float diemcongdtuong = Convert.ToInt32(dgvDoiTuong.Rows[row].Cells[2].Value);


            if (DoiTuongDAO.Instance.EditDoiTuong(madoituong, loaidoituong, diemcongdtuong))
            {
                MessageBox.Show("Sua Doi Tuong Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();

                cmbMadoituong.Text = "";
                cmbTendoituong.Text = "";
                cmbDiemcong.Text = "";

            }
            else
            {
                MessageBox.Show("Sua Doi Tuong That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string madoituong = cmbMadoituong.Text;
            string loaidoituong = cmbTendoituong.Text;
            string diemcongdtuong = cmbDiemcong.Text;

            if (HoKhauDAO.Instance.InsertHoKhau(madoituong, loaidoituong, diemcongdtuong))
            {
                MessageBox.Show("Them Doi Tuong Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
            }
            else
            {
                MessageBox.Show("Them Doi Tuong That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cmbMadoituong.Text = "";
            cmbTendoituong.Text = "";
            cmbDiemcong.Text = "";
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void dgvDoiTuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvDoiTuong.CurrentCell.RowIndex;

            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            //
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnhuy.Enabled = true;

            try
            {
                cmbMadoituong.Text = dgvDoiTuong.Rows[row].Cells[0].Value.ToString();
                cmbTendoituong.Text = dgvDoiTuong.Rows[row].Cells[1].Value.ToString();
                cmbDiemcong.Text = dgvDoiTuong.Rows[row].Cells[2].Value.ToString();
            }
            catch
            { }
        }
    }
}
