using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.UIs
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private int count = 0;
        NhanVien[] ds;
        private void btnlogin_Click(object sender, EventArgs e)
        {
            // tao ds nhan vien (mai mot tao function load database)
            ds = new NhanVien[2];
            ds[0] = new NhanVien()
            //nhanvien
            {
                TenNV = "vungho@gmail.com",
                Mk = "123",
                LoaiNV = 0
            };
            //admin
            ds[1] = new NhanVien()
            {
                TenNV = "dangchaugiang@gmail.com",
                Mk = "789",
                LoaiNV = 1
            };

            int type;
            string username = txtuser.Text;
            string password = txtpass.Text;
            
            type = -1;
            foreach(NhanVien nv in ds)
            {
                if (nv.TenNV == username && nv.Mk == password)
                    type = nv.LoaiNV;
            }
            if (type!=-1)
            {
                this.Hide();
                frmMainUI p = new frmMainUI(type,this);
                p.ShowDialog();
                this.Show();
            }
         

            
        }
        public void clear()
        {
            txtuser.Text = txtpass.Text = "";
        }
        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void piclogin_Click(object sender, EventArgs e)
        {

        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
