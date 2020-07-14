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
    public partial class Tracuunganh : Form
    {
        List<NGANH> listN1;
        private int row;
        public Tracuunganh()
        {
            listN1 = new List<NGANH>();
            listN1 = NganhDAO.Instance.Fn_Nganh();
            InitializeComponent();
            foreach (NGANH item in listN1)
            {
                cmbTennganh.Items.Add(item.TenNganh);
                //cmbManganh.Items.Add(item.MaNganh);
            }
            LoadTable();
        }

        private void LoadTable()
        {
            dgvtracuu.DataSource = NganhDAO.Instance.Fn_Nganh();
            dgvtracuu.DataSource = listN1;

        }

        private void btnTracuu_Click(object sender, EventArgs e)
        { 
            string tennganh = cmbTennganh.Text;
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADTraCuuNganh @ten ", new object[] { tennganh });
            dgvtracuu.DataSource = data;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvtracuu.CurrentCell.RowIndex;
            try
            {
                //string manganh = dgvtracuu.Rows[row].Cells[0].Value.ToString();
                cmbTennganh.Text = dgvtracuu.Rows[row].Cells[1].Value.ToString();
                //int chitieu = Convert.ToInt32(dgvtracuu.Rows[row].Cells[2].Value);
                //double diemchuan = Convert.ToInt32(dgvtracuu.Rows[row].Cells[3].Value);

            }
            catch
            { }
        }
    }
}
