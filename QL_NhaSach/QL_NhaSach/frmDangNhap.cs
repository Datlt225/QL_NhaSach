using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NhaSach.Class;

namespace QL_NhaSach
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        frmMain fMain = null;
        XL_NHANVIEN tblNhanVien;

        public frmDangNhap(frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tblNhanVien = new XL_NHANVIEN();
            DataRow[] r = tblNhanVien.Select("Username='" + txtUserName.Text + "'and Password='"
                + txtPassword.Text + "'");
            if (r.Count() > 0)
            {
                fMain.Text = "Quan ly Nha Sach - Chao " + r[0]["TenNV"].ToString();
                fMain.maNV = r[0]["MaNV"].ToString();
                fMain.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

      
    }
}
