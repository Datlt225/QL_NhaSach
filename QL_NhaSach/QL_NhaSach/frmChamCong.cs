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
using System.Data.SqlClient;

namespace QL_NhaSach
{
    public partial class frmChamCong : Form
    {
        public frmChamCong()
        {
            InitializeComponent();
        }
        XL_NHANVIEN tblNhanVien;
        XL_CHAMCONG tblChamCong;

        private void frmChamCong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLNHASACHDataSet.CHAMCONG' table. You can move, or remove it, as needed.
            this.cHAMCONGTableAdapter.Fill(this.qLNHASACHDataSet.CHAMCONG);
            tblNhanVien = new XL_NHANVIEN();
            tblChamCong = new XL_CHAMCONG();
            loadCTChamCong();
            loadNhanVien();
            dtNgay.Value = DateTime.Now;
        }

        private void loadCTChamCong()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblNhanVien, tblChamCong });
            DataRelation qh = new DataRelation("FRK_NHANVIEN_CHAMCONG", tblNhanVien.Columns["MaNV"],
                tblChamCong.Columns["MaNV"]);
            ds.Relations.Add(qh);

            DataColumn cTenNV = new DataColumn("TenNV", Type.GetType("System.String"),
                "Parent(FRK_NHANVIEN_CHAMCONG).TenNV");
            tblChamCong.Columns.Add(cTenNV);
            dgvChamCong.AutoGenerateColumns = false;
            dgvChamCong.DataSource = tblChamCong;
        }

        private void loadNhanVien()
        {
            listNhanVien.DataSource = tblNhanVien;
            listNhanVien.ValueMember = "MaNV";
            listNhanVien.DisplayMember = "TenNV";
        }

        private void sbtnThem_Click(object sender, EventArgs e)
        {
            DataRow r = tblChamCong.NewRow();
            r["MaNV"] = listNhanVien.SelectedValue;
            r["Ngay"] = dtNgay.Value.ToShortDateString();
            r["SoGio"] = numSoGio.Value;
            tblChamCong.Rows.Add(r);
            tblChamCong.ghi();
        }

        private void dtNgay_ValueChanged(object sender, EventArgs e)
        {
            tblChamCong.locDuLieu("Ngay='" + dtNgay.Value.ToShortDateString() + "'");
        }

        private void dgvChamCong_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvChamCong.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void dgvChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&(e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                if (e.ColumnIndex == 5)
                    tblChamCong.Rows[e.RowIndex].Delete();
                tblChamCong.ghi();
            }
        }
    }
}
