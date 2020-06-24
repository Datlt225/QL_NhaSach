namespace QL_NhaSach
{
    partial class frmChamCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamCong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sbtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.numSoGio = new System.Windows.Forms.NumericUpDown();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBtnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvBtnXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.qLNHASACHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHASACHDataSet = new QL_NhaSach.QLNHASACHDataSet();
            this.listNhanVien = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHASACHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHASACHDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listNhanVien);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.sbtnThem);
            this.groupBox1.Controls.Add(this.numSoGio);
            this.groupBox1.Controls.Add(this.dtNgay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chấm công";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(250, 181);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(126, 63);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Tính Lương";
            // 
            // sbtnThem
            // 
            this.sbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.sbtnThem.Location = new System.Drawing.Point(105, 181);
            this.sbtnThem.Name = "sbtnThem";
            this.sbtnThem.Size = new System.Drawing.Size(108, 63);
            this.sbtnThem.TabIndex = 4;
            this.sbtnThem.Text = "Thêm";
            this.sbtnThem.Click += new System.EventHandler(this.sbtnThem_Click);
            // 
            // numSoGio
            // 
            this.numSoGio.Location = new System.Drawing.Point(241, 118);
            this.numSoGio.Name = "numSoGio";
            this.numSoGio.Size = new System.Drawing.Size(91, 22);
            this.numSoGio.TabIndex = 2;
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(241, 58);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(200, 22);
            this.dtNgay.TabIndex = 1;
            this.dtNgay.ValueChanged += new System.EventHandler(this.dtNgay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(505, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách nhân viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số giờ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày chấm công: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chi tiết chấm công:";
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AutoGenerateColumns = false;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenNV,
            this.Ngay,
            this.SoGio,
            this.dgvBtnEdit,
            this.dgvBtnXoa});
            this.dgvChamCong.DataSource = this.qLNHASACHDataSetBindingSource;
            this.dgvChamCong.Location = new System.Drawing.Point(52, 360);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(979, 224);
            this.dgvChamCong.TabIndex = 1;
            this.dgvChamCong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellContentClick);
            this.dgvChamCong.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvChamCong_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên Nhân Viên";
            this.TenNV.Name = "TenNV";
            // 
            // Ngay
            // 
            this.Ngay.HeaderText = "Ngày chấm công";
            this.Ngay.Name = "Ngay";
            // 
            // SoGio
            // 
            this.SoGio.HeaderText = "Số Giờ";
            this.SoGio.Name = "SoGio";
            // 
            // dgvBtnEdit
            // 
            this.dgvBtnEdit.HeaderText = "Sửa";
            this.dgvBtnEdit.Name = "dgvBtnEdit";
            // 
            // dgvBtnXoa
            // 
            this.dgvBtnXoa.HeaderText = "Xoá";
            this.dgvBtnXoa.Name = "dgvBtnXoa";
            // 
            // qLNHASACHDataSetBindingSource
            // 
            this.qLNHASACHDataSetBindingSource.DataSource = this.qLNHASACHDataSet;
            this.qLNHASACHDataSetBindingSource.Position = 0;
            // 
            // qLNHASACHDataSet
            // 
            this.qLNHASACHDataSet.DataSetName = "QLNHASACHDataSet";
            this.qLNHASACHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listNhanVien
            // 
            this.listNhanVien.FormattingEnabled = true;
            this.listNhanVien.ItemHeight = 16;
            this.listNhanVien.Location = new System.Drawing.Point(513, 107);
            this.listNhanVien.Name = "listNhanVien";
            this.listNhanVien.Size = new System.Drawing.Size(262, 100);
            this.listNhanVien.TabIndex = 5;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 620);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.Load += new System.EventHandler(this.frmChamCong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHASACHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHASACHDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton sbtnThem;
        private System.Windows.Forms.NumericUpDown numSoGio;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGio;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn dgvBtnXoa;
        private System.Windows.Forms.BindingSource qLNHASACHDataSetBindingSource;
        private QLNHASACHDataSet qLNHASACHDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listNhanVien;
    }
}