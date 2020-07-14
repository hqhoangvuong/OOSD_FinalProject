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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tracuunganh form = new Tracuunganh();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            Tracuudiem form = new Tracuudiem();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
