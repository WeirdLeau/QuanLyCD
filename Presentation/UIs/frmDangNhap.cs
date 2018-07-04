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
            ds = new NhanVien[3];
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
            //admin
            ds[2] = new NhanVien()
            {
                TenNV = "a@b",
                Mk = "123",
                LoaiNV = 1
            };
            int type;
            string username = txtuser.Text;
            string password = txtpass.Text;

            type = -1;
            if (type == -1)
            {
                foreach (NhanVien nv in ds)

                {

                    if (nv.TenNV == username && nv.Mk == password)
                    {
                        type = nv.LoaiNV;
                        count = 0;
                        MessageBox.Show("Đăng nhập thành công");
                    }

                }
                if (type != -1)
                {
                    this.Hide();
                    frmMainUI p = new frmMainUI(type, this);
                    p.ShowDialog();
                   this.Show();

                }
            
           else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }
        }


            count++;
            if (count > 2)
            {
                count = 2;
                timer1.Interval = 1000;
                btnlogin.Enabled = false;
                timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            count--;
            btnlogin.Text = "Next login: " + count;
            if (count == 0)
            {
                btnlogin.Text = "Login";
                btnlogin.Enabled = true;
                timer1.Stop();
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
