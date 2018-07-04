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
        
        private frmDangNhap frmDangNhap;
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
            
            this.Visible = false;

            //this.Close();
            //this.DialogResult = DialogResult.OK;

        }

       
        
        private void frmMainUI_Load(object sender, EventArgs e)
        {
            label1.Text = "BÉ CUTE";
        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien nv = new frmNhanVien();
            nv.RefToMainUI = this;
            this.Hide();
            nv.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang kh = new frmKhachHang();
            kh.RefTofrmMainUI = this;
            this.Hide();
            kh.ShowDialog();
        }

        private void quảnLýCDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCD cd = new frmCD();
            cd.RefToMainUI = this;
            this.Hide();
            cd.ShowDialog();
        }

        
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien nv = new frmNhanVien();
            nv.RefToMainUI = this;
            this.Hide();
            nv.ShowDialog();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang kh = new frmKhachHang();
            kh.RefTofrmMainUI = this;
            this.Hide();
            kh.ShowDialog();
        }

        private void quảnLýCDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCD cd = new frmCD();
            cd.RefToMainUI = this;
            this.Hide();
            cd.ShowDialog();
        }

        //private void frmMainUI_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}
    }
}
