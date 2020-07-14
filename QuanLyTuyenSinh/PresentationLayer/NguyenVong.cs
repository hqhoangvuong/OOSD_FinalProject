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
    public partial class NguyenVong : Form
    {
        List<NGUYENVONG> lstnguyenvong;
        List<HOSOTHISINH> lstHoSoThiSinh;
        List<NGANH> lstNganh;
        private int row;
        public NguyenVong()
        {
            lstHoSoThiSinh = new List<HOSOTHISINH>();
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADTableHoSoThiSinh;");
            foreach (DataRow item in data.Rows)
            {
                HOSOTHISINH HoSo = new HOSOTHISINH(item);
                lstHoSoThiSinh.Add(HoSo);
            }
            lstNganh = new List<NGANH>();
            lstNganh = NganhDAO.Instance.Fn_Nganh();
            


            InitializeComponent();
            Setup();
            Load();
        }
        private void Setup()
        {
            dgvNguyenVong.Columns[3].Visible = false;
            cmbKhoi.Items.Add("A");
            cmbKhoi.Items.Add("A1");
            cmbKhoi.Items.Add("B");
            cmbKhoi.Items.Add("C");
            cmbKhoi.Items.Add("D");
            for(int i=1;i<11;i++)
            {
                cmbNguyenvong.Items.Add(i);
            }
            for(int i=0;i< lstHoSoThiSinh.Count;i++)
            {
                //foreach (HOSOTHISINH item in lstHoSoThiSinh)
                //{
                //    if(item.ID==lstHoSoThiSinh[i].ID)
                //    {
                //        cmbHoTen.Items.Add(item.HoDem + " " + item.Ten);
                //    }
                //}
                cmbHoTen.Items.Add(lstHoSoThiSinh[i].HoDem + " " + lstHoSoThiSinh[i].Ten);
            }
            foreach (NGANH item in lstNganh)
            {
                cmbTennganh.Items.Add(item.TenNganh);
            }
            

        }

        private void Load()
        {
            lstnguyenvong = new List<NGUYENVONG>();
            lstnguyenvong = NguyenVongDAO.Instance.LoadTableNguyenVong();
            dgvNguyenVong.DataSource = lstnguyenvong;
        }

        private void cmbHoTen_TextChanged(object sender, EventArgs e)
        {
            txtSBD.Text = "";
            foreach(HOSOTHISINH item in lstHoSoThiSinh)
            {
                if(cmbHoTen.Text==(item.HoDem+" "+item.Ten))
                {
                    if(txtSBD.Text=="")
                    {
                        txtSBD.Text = item.ID;
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            string SBD = txtSBD.Text;
            string tennganh = cmbTennganh.Text;
            string khoi = cmbKhoi.Text;
            int nguyenvong = Convert.ToInt32(cmbNguyenvong.Text);
            if(SBD!="" && tennganh!="" && khoi != "" && nguyenvong != null)
            {
                if(NguyenVongDAO.Instance.InsertNguyenVong(SBD,tennganh,khoi,nguyenvong))//Khi add xong tự xóa Store.
                {
                    MessageBox.Show("Them nguyen vong thanh cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbNguyenvong.Items.Remove(nguyenvong);
                    Load();
                }
            }
            else
            {
                MessageBox.Show("Them du lieu khong du", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sbd = txtSBD.Text;
            string tennganh = cmbTennganh.Text;
            string khoi = cmbKhoi.Text;
            int nguyenvong = Convert.ToInt32(cmbNguyenvong.Text);
            if (NguyenVongDAO.Instance.EditNguyenVong(sbd,tennganh,khoi,nguyenvong))
            {
                MessageBox.Show("Sua nguyen vong thanh cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Sua du lieu that bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string sbd = txtSBD.Text;
            string tennganh = cmbTennganh.Text;
            string khoi = cmbKhoi.Text;
            int nguyenvong = Convert.ToInt32(cmbNguyenvong.Text);
            if (NguyenVongDAO.Instance.DeleteNguyenVong(sbd,tennganh,khoi,nguyenvong))
            {
                MessageBox.Show("Xoa nguyen vong thanh cong", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Xoa nguyen vong that bai", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void dgvNguyenVong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvNguyenVong.CurrentCell.RowIndex;
            

            try
            {
                //this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                //this.cmbTennganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                //this.cmbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
                //this.cmbNguyenvong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

                txtSBD.Text = dgvNguyenVong.Rows[row].Cells[0].Value.ToString();
                cmbHoTen.Text = dgvNguyenVong.Rows[row].Cells[4].Value.ToString();
                cmbTennganh.Text = dgvNguyenVong.Rows[row].Cells[1].Value.ToString();
                cmbKhoi.Text = dgvNguyenVong.Rows[row].Cells[2].Value.ToString();
                cmbNguyenvong.Text = dgvNguyenVong.Rows[row].Cells[3].Value.ToString();
            }
            catch
            { }
            //this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.cmbTennganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.cmbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            //this.cmbNguyenvong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cmbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbHoTen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cmbTennganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbTennganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cmbKhoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void cmbNguyenvong_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.cmbNguyenvong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }
    }
}
