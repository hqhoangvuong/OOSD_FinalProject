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
    public partial class Ketqua : Form
    {
        private int row;
        public Ketqua()
        {
            int sbd = Convert.ToInt32(dgvtracuu.Rows[row].Cells[0].Value);
          
            InitializeComponent();
        }

        private void Ketqua_Load(object sender, EventArgs e)
        {

        }

        private void btnxacnhan_Click(object sender, EventArgs e)
        {

        }

        private void lbtongtien_Click(object sender, EventArgs e)
        {

        }

        private void lbtientra_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbgiamgia_Click(object sender, EventArgs e)
        {

        }

        private void lwMonDaChon_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
