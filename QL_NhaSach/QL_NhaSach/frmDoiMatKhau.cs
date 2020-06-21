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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtPassNew, "");
            errorProvider1.SetError(txtConfirmPass, "");

            if (txtPassNew.Text.Length < 8 || !txtPassNew.Text.Any(char.IsDigit)
                || !txtPassNew.Text.Any(char.IsLower) || !txtPassNew.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtPassNew, "Mat khau moi toi thieu 8 ki tu, bao gom so, " +
                    "in hoa, in thuong.");
                return;
            }

            if(txtPassNew.Text != txtConfirmPass.Text)
            {
                errorProvider1.SetError(txtPassNew, "Mat khau khong trung khop!!");
                return;
            }

            frmMain f = (frmMain)this.MdiParent;
            int count = XL_BANG.Thuc_hien_lenh("Update NHANVIEN set Password ='"
                + txtPassNew.Text + "'where MaNV ='" + f.maNV + "'");

            if (count > 0)
            {
                MessageBox.Show("Cap nhat thanh cong!!");
            }
            else
            {
                MessageBox.Show("Cap nhat that bai!!");
            }
        }
    }
}
