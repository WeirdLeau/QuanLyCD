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
    public partial class frmCD : Form
    {
        public frmCD()
        {
            InitializeComponent();
            khoaControl(true);
        }

        private void khoaControl(bool k)
        {
            txtmacd.ReadOnly = k;
            txtgiabancd.ReadOnly = k;
            txtgianhapcd.ReadOnly = k;
            txtnhomcd.ReadOnly = k;
            txtslcd.ReadOnly = k;
            txttencd.ReadOnly = k;
            btnluucd.Enabled = !k;

        }

        private void btnhinhcd_Click(object sender, EventArgs e)
        {
            OpenFileDialog opHinh = new OpenFileDialog();
            opHinh.InitialDirectory = Application.StartupPath;
            opHinh.Filter = "Image(*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tiff)|*.bmp;*.jpg;*.jpeg;*.gif;*.png;*.tiff|All Files (*.*)|*.*";
            if (opHinh.ShowDialog() == DialogResult.OK)
            {
                string pathhinh = opHinh.FileName;
                picHinh.Image = Image.FromFile(pathhinh);
                if (!System.IO.File.Exists(Application.StartupPath + @"\Image\" + pathhinh.Substring(pathhinh.LastIndexOf("\\") + 1)))
                {
                    System.IO.File.Copy(pathhinh, Application.StartupPath + @"\Image\" + pathhinh.Substring(pathhinh.LastIndexOf("\\") + 1));
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        public void XoaTextBox()
        {
            txtmacd.Clear();
            txttencd.ResetText();
            txtgiabancd.Clear();
            txtgianhapcd.Clear();
            txtnhomcd.Clear();
            txtslcd.Clear();
           
        }
        public void btnThem_Click(object sender, EventArgs e)
        {
            if (btnthemcd.Text == "Thêm")
            {
                khoaControl(false);
                txtmacd.Focus();
                XoaTextBox();
                btnthemcd.Text = "Bỏ Qua";
            }
            else
            {
                khoaControl(true);
                btnthemcd.Text = "Thêm";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnthemcd.Text == "Bỏ Qua")
            {

            }
        }

        private void frmCD_Load(object sender, EventArgs e)
        {

        }
    }
}

