using QuanLyTuyenSinh.DAO;
using QuanLyTuyenSinh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTuyenSinh.PresentationLayer
{
    public partial class QuanLyTuyenSinh : Form
    {
        List<HOSOTHISINH> tableList;
        List<HOKHAU> listhk;
        List<DOITUONG> listdt;
        List<DANTOC> listdtoc;
        private int row;
        public QuanLyTuyenSinh()

        {

            listhk = new List<HOKHAU>();
            listhk = HoKhauDAO.Instance.LoadTableHoKhau();
            listdt = new List<DOITUONG>();
            listdt = DoiTuongDAO.Instance.LoadTableDoiTuong();
            listdtoc = new List<DANTOC>();
            listdtoc = DanTocDAO.Instance.LoadTableDanToc();
            InitializeComponent();
            foreach (HOKHAU item in listhk)
            {
                cbbTenHuyen.Items.Add(item.TenHuyen);
                cbbTenTinh.Items.Add(item.TenTinh);

            }
            foreach (DOITUONG item in listdt)
            {
                cbbDoiTuong.Items.Add(item.LoaiDoiTuong);
            }
            foreach (DANTOC item in listdtoc)
            {
                cbbDanToc.Items.Add(item.TenDanToc);
            }
            Setup();

            LoadTable();
        }



        #region Methods
        private void Setup() {
            dataGridView_QLTS.Columns[5].Visible = false;
            dataGridView_QLTS.Columns[8].Visible = false;
            dataGridView_QLTS.Columns[10].Visible = false;
            cbbGioiTinh.Items.Add("Nam");
            cbbGioiTinh.Items.Add("Nữ");
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnHuy.Enabled = false;

            
        }
        private void LoadTable()
        {

            tableList = new List<HOSOTHISINH>();

            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADTableHoSoThiSinh;");

            foreach (DataRow item in data.Rows)
            {
                HOSOTHISINH HoSo = new HOSOTHISINH(item);
                tableList.Add(HoSo);
            }
            dataGridView_QLTS.DataSource = tableList;
        }

        #endregion


        #region Events

        #region Click
        private void dataGridView_QLTS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridView_QLTS.CurrentCell.RowIndex;

            btnLuu.Enabled = false;
            btnThem.Enabled = false;
            btnReset.Enabled = false;
            //
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnHuy.Enabled = true;

            try
            {
                txt_SBD.Text = dataGridView_QLTS.Rows[row].Cells[0].Value.ToString();
                txt_HoDem.Text = dataGridView_QLTS.Rows[row].Cells[1].Value.ToString();
                txt_Ten.Text = dataGridView_QLTS.Rows[row].Cells[2].Value.ToString();
                dtpkNgaySinh.Text = dataGridView_QLTS.Rows[row].Cells[3].Value.ToString();
                
                if(dataGridView_QLTS.Rows[row].Cells[4].Value.ToString()=="True")
                {
                    cbbGioiTinh.Text = "Nam";
                }
                else
                {
                    cbbGioiTinh.Text = "Nữ";
                }
                cbbTenHuyen.Text = dataGridView_QLTS.Rows[row].Cells[5].Value.ToString();
                cbbTenTinh.Text = dataGridView_QLTS.Rows[row].Cells[6].Value.ToString();
                cbbDoiTuong.Text = dataGridView_QLTS.Rows[row].Cells[7].Value.ToString();
                cbbDanToc.Text = dataGridView_QLTS.Rows[row].Cells[8].Value.ToString();
                txtToan.Text = dataGridView_QLTS.Rows[row].Cells[12].Value.ToString();
                txtLy.Text = dataGridView_QLTS.Rows[row].Cells[13].Value.ToString();
                txtHoa.Text = dataGridView_QLTS.Rows[row].Cells[14].Value.ToString();
                txtSinh.Text = dataGridView_QLTS.Rows[row].Cells[15].Value.ToString();
                txtVan.Text = dataGridView_QLTS.Rows[row].Cells[16].Value.ToString();
                txtSu.Text = dataGridView_QLTS.Rows[row].Cells[17].Value.ToString();
                txtDia.Text = dataGridView_QLTS.Rows[row].Cells[18].Value.ToString();
                txtAnhVan.Text = dataGridView_QLTS.Rows[row].Cells[19].Value.ToString();
            }
            catch
            { }
        }
        #endregion

        #region Them
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            //
            btnReset.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //
            txt_SBD.Text = "";
            txt_HoDem.Text = "";
            txt_Ten.Text = "";
            dtpkNgaySinh.Text = "";
            cbbGioiTinh.Text = "";
            cbbTenHuyen.Text = "";
            cbbTenTinh.Text = "";
            cbbDoiTuong.Text = "";
            cbbDanToc.Text = "";
            txtToan.Text = "";
            txtLy.Text = "";
            txtHoa.Text = "";
            txtSinh.Text = "";
            txtVan.Text = "";
            txtSu.Text = "";
            txtDia.Text = "";
            txtAnhVan.Text = "";
        }
        #endregion

        #region Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_SBD.Text = "";
            txt_HoDem.Text = "";
            txt_Ten.Text = "";
            dtpkNgaySinh.Text = "";
            cbbGioiTinh.Text = "";
            cbbTenHuyen.Text = "";
            cbbTenTinh.Text = "";
            cbbDoiTuong.Text = "";
            cbbDanToc.Text = "";
            txtToan.Text = "";
            txtLy.Text = "";
            txtHoa.Text = "";
            txtSinh.Text = "";
            txtVan.Text = "";
            txtSu.Text = "";
            txtDia.Text = "";
            txtAnhVan.Text = "";
        }
        #endregion

        #region Luu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnHuy.Enabled = false;
            string sbd = txt_SBD.Text.TrimEnd();
            string hodem = txt_HoDem.Text.TrimEnd();
            string ten = txt_Ten.Text;
            DateTime ngaysinh = Convert.ToDateTime(dtpkNgaySinh.Text);
            string gioitinh="0";
            if(cbbGioiTinh.Text=="Nam")
            {
                gioitinh = "1";
            }
            else if(cbbGioiTinh.Text=="Nữ")
            {
                gioitinh = "0";
            }
            string tenhuyen = cbbTenHuyen.Text.TrimEnd();
            string tentinh = cbbTenTinh.Text.TrimEnd();
            string doituong = cbbDoiTuong.Text.TrimEnd();
            string dantoc = cbbDanToc.Text.TrimEnd();
            #region Điểm
            double toan=0;
            try
            {
                toan = Convert.ToDouble(txtToan.Text);

            }
            catch
            {
                toan = 0;
            }
            double ly=0;
            try
            {
                ly = Convert.ToDouble(txtLy.Text);

            }
            catch
            {
                ly = 0;
            }
            double hoa=0;
            try
            {
                hoa = Convert.ToDouble(txtHoa.Text);

            }
            catch
            {
                hoa = 0;
            }
            double sinh=0;
            try
            {
                sinh = Convert.ToDouble(txtSinh.Text);

            }
            catch
            {
                sinh = 0;
            }
            double van=0;
            try
            {
                van = Convert.ToDouble(txtVan.Text);

            }
            catch
            {
                van = 0;
            }
            double su=0;
            try
            {
                su = Convert.ToDouble(txtSu.Text);

            }
            catch
            {
                su = 0;
            }
            double dia=0;
            try
            {
                dia = Convert.ToDouble(txtDia.Text);

            }
            catch
            {
                dia = 0;
            }
            double anhvan=0;
            try
            {
                anhvan = Convert.ToDouble(txtAnhVan.Text);

            }
            catch
            {
                anhvan = 0;
            }
            #endregion
            if(HoSoThiSinhDAO.Instance.InsertSinhVien(sbd,hodem,ten,ngaysinh,gioitinh,tenhuyen,tentinh,doituong,dantoc,toan,ly,hoa,sinh,van,su,dia,anhvan))
            {
                MessageBox.Show("Them Thi Sinh Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
            }

        }
        #endregion

        #region Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sbd = txt_SBD.Text;
            string hodem = txt_HoDem.Text.TrimEnd();
            string ten = txt_Ten.Text;
            DateTime ngaysinh = Convert.ToDateTime(dtpkNgaySinh.Text);
            string gioitinh = "0";
            if (cbbGioiTinh.Text == "Nam")
            {
                gioitinh = "1";
            }
            else if (cbbGioiTinh.Text == "Nữ")
            {
                gioitinh = "0";
            }
            string tenhuyen = cbbTenHuyen.Text.TrimEnd();
            string tentinh = cbbTenTinh.Text.TrimEnd();
            string doituong = cbbDoiTuong.Text.TrimEnd();
            string dantoc = cbbDanToc.Text.TrimEnd();
            #region Điểm
            double toan = 0;
            try
            {
                toan = Convert.ToDouble(txtToan.Text);

            }
            catch
            {
                toan = 0;
            }
            double ly = 0;
            try
            {
                ly = Convert.ToDouble(txtLy.Text);

            }
            catch
            {
                ly = 0;
            }
            double hoa = 0;
            try
            {
                hoa = Convert.ToDouble(txtHoa.Text);

            }
            catch
            {
                hoa = 0;
            }
            double sinh = 0;
            try
            {
                sinh = Convert.ToDouble(txtSinh.Text);

            }
            catch
            {
                sinh = 0;
            }
            double van = 0;
            try
            {
                van = Convert.ToDouble(txtVan.Text);

            }
            catch
            {
                van = 0;
            }
            double su = 0;
            try
            {
                su = Convert.ToDouble(txtSu.Text);

            }
            catch
            {
                su = 0;
            }
            double dia = 0;
            try
            {
                dia = Convert.ToDouble(txtDia.Text);

            }
            catch
            {
                dia = 0;
            }
            double anhvan = 0;
            try
            {
                anhvan = Convert.ToDouble(txtAnhVan.Text);

            }
            catch
            {
                anhvan = 0;
            }
            #endregion
            if (HoSoThiSinhDAO.Instance.UpdateSinhVien(sbd, hodem, ten, ngaysinh, gioitinh, tenhuyen, tentinh, doituong, dantoc, toan, ly, hoa, sinh, van, su, dia, anhvan))
            {
                MessageBox.Show("Cap Nhat Thi Sinh Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
            }
            #endregion
        }
        #region Xoa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sbd = txt_SBD.Text;

            if (HoSoThiSinhDAO.Instance.DeleteSinhVien(sbd))
            {
                MessageBox.Show("Xoa Thi Sinh Thanh Cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadTable();

                txt_SBD.Text = "";
                txt_HoDem.Text = "";
                txt_Ten.Text = "";
                dtpkNgaySinh.Text = "";
                cbbGioiTinh.Text = "";
                cbbTenHuyen.Text = "";
                cbbTenTinh.Text = "";
                cbbDoiTuong.Text = "";
                cbbDanToc.Text = "";
                txtToan.Text = "";
                txtLy.Text = "";
                txtHoa.Text = "";
                txtSinh.Text = "";
                txtVan.Text = "";
                txtSu.Text = "";
                txtDia.Text = "";
                txtAnhVan.Text = "";
                btnThem.Enabled = true;
                btnLuu.Enabled = false;
                btnReset.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xoa Thi Sinh That Bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Huy
        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnHuy.Enabled = false;

            txt_SBD.Text = "";
            txt_HoDem.Text = "";
            txt_Ten.Text = "";
            dtpkNgaySinh.Text = "";
            cbbGioiTinh.Text = "";
            cbbTenHuyen.Text = "";
            cbbTenTinh.Text = "";
            cbbDoiTuong.Text = "";
            cbbDanToc.Text = "";
            txtToan.Text = "";
            txtLy.Text = "";
            txtHoa.Text = "";
            txtSinh.Text = "";
            txtVan.Text = "";
            txtSu.Text = "";
            txtDia.Text = "";
            txtAnhVan.Text = "";
        }
        #endregion
        #endregion
    }
}
