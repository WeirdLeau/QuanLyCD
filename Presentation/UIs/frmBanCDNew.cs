using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.UIs
{
    public partial class frmBanCDNew : Form
    {
        public frmBanCDNew()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCD.Text = null;
            txtDonGia.Text = null;
            txtLoaiCD.Text = null;
            txtSoLuong.Text = null;
            txtTenCD.Text = null;
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            txtMaCD.Text = null;
            txtDonGia.Text = null;
            txtLoaiCD.Text = null;
            txtSoLuong.Text = null;
            txtTenCD.Text = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void frmBanCDNew_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chăc chưa?","Thoát",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
