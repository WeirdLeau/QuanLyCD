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
        public frmMainUI(int type,frmDangNhap frmDangNhap)
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
            this.Hide();
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmNhanVien nv = new frmNhanVien();
            nv.Show();
        }

        private void frmMainUI_Load(object sender, EventArgs e)
        {
            label1.Text = "BÉ CUTE";
        }
    }
}
