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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public Form RefTofrmMainUI { get; set; }

        private void frmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefTofrmMainUI.Show();
        }
    }
}
