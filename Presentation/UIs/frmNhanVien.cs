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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public Form RefToMainUI { get; set; }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RefToMainUI.Show();
        }
    }
}
