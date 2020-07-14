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
    public partial class Tracuudiem : Form
    {

        public Tracuudiem()
        {
            InitializeComponent();
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            string ten = txbHoten.Text;
            int sbd = Convert.ToInt32(txbSBD.Text);
            DataTable data = QuanLyTuyenSinhContext.Instance.ExecuteQuery("LOADTraCuuDiem @sbd , @ten ", new object[] {sbd,ten });
            dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ketqua form = new Ketqua();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Tracuudiem_Load(object sender, EventArgs e)
        {

        }
    }
}
