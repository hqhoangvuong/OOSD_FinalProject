
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
    public partial class QuanLynganh : Form
    {
        List<NGANH> listN;
        private int row;
        public QuanLynganh()
        {
            listN = new List<NGANH>();
            listN = NganhDAO.Instance.Fn_Nganh();
            InitializeComponent();
            foreach (NGANH item in listN)
            {
                cmbTennganh.Items.Add(item.TenNganh);
                cmbManganh.Items.Add(item.MaNganh);
                cmbChitieu.Items.Add(item.ChiTieu);
                cmbDiemchuan.Items.Add(item.DiemChuan);

            }
            LoadTable();
        }

        private void LoadTable()
        {
            dgvnganh.DataSource = NganhDAO.Instance.Fn_Nganh();
            dgvnganh.DataSource = listN;
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
            cmbTennganh.Text = "";
            cmbManganh.Text = "";
            cmbChitieu.Text = "";
            cmbDiemchuan.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmbTennganh.Text = "";
            cmbManganh.Text = "";
            cmbChitieu.Text = "";
            cmbDiemchuan.Text = "";
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;

            int id = Convert.ToInt32(dgvnganh.Rows[row].Cells[0].Value);

            if (NganhDAO.Instance.DeleteNganh(id))
            {
                MessageBox.Show("Xoa Nganh Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTable();
            }
            else
            {
                MessageBox.Show("Xoa Nganh That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tennganh = cmbTennganh.Text;
            string manganh = cmbManganh.Text;
            int chitieu = Convert.ToInt32(dgvnganh.Rows[row].Cells[2].Value);
            double diemchuan = Convert.ToInt32(dgvnganh.Rows[row].Cells[3].Value);

            if (NganhDAO.Instance.InsertNganh(manganh, tennganh, chitieu, diemchuan))
            {
                MessageBox.Show("Them Nganh Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
            }
            else
            {
                MessageBox.Show("Them Nganh That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cmbTennganh.Text = "";
            cmbManganh.Text = "";
            cmbChitieu.Text = "";
            cmbDiemchuan.Text = "";
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            //
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnhuy.Enabled = false;


            string manganh = cmbManganh.Text;
            string tennganh = cmbTennganh.Text;
            int chitieu = Convert.ToInt32(dgvnganh.Rows[row].Cells[2].Value);
            double diemchuan = Convert.ToInt32(dgvnganh.Rows[row].Cells[3].Value);

            if (NganhDAO.Instance.EditNganh(manganh, tennganh, chitieu, diemchuan))
            {
                MessageBox.Show("Sua Nganh Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();

                cmbTennganh.Text = "";
                cmbManganh.Text = "";
                cmbChitieu.Text = "";
                cmbDiemchuan.Text = "";

            }
            else
            {
                MessageBox.Show("Sua Nganh That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvnganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvnganh.CurrentCell.RowIndex;

            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            //
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnhuy.Enabled = true;

            try
            {
                cmbManganh.Text = dgvnganh.Rows[row].Cells[0].Value.ToString();
                cmbTennganh.Text = dgvnganh.Rows[row].Cells[1].Value.ToString();
                cmbChitieu.Text = dgvnganh.Rows[row].Cells[2].Value.ToString();
                cmbDiemchuan.Text = dgvnganh.Rows[row].Cells[3].Value.ToString();
            }
            catch
            { }
        }

        private void QuanLynganh_Load(object sender, EventArgs e)
        {

        }
    }
}
