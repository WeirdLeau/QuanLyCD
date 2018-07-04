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
    public partial class frmMainUI : Form
    {
        public frmDangNhap frmDangNhap;
        public frmMainUI(int type, frmDangNhap frmDangNhap)
        {
            this.frmDangNhap = frmDangNhap;
            InitializeComponent();
            switch (type)
            {
                // nhan vien
                case 0:
                    this.adminToolStripMenuItem.Enabled = false;
                    this.quảnLýToolStripMenuItem.Enabled = false;
                    this.thốngKêToolStripMenuItem.Enabled = false;
                    break;
                // admin
                case 1:
                    break;
            }
        }



        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)

        {

            this.frmDangNhap.clear();
            this.Close();

        }

        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }

        private void frmMainUI_Load(object sender, EventArgs e)
        {
            label1.Text = "BÉ CUTE";
        }

        private void quảnLýKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.ShowDialog();
        }

        private void quảnLýCDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCD cd = new frmCD();
            cd.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.ShowDialog();
        }


    }
}
