
namespace DXApplication2
{
    partial class FormVaccine
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.btnVaccineHetHSD = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiVaccine = new System.Windows.Forms.TextBox();
            this.txtKhoChua = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtNCC = new System.Windows.Forms.TextBox();
            this.txtSoLuongConLai = new System.Windows.Forms.TextBox();
            this.txtTenVaccine = new System.Windows.Forms.TextBox();
            this.txtMaVaccine = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtGVVaccine = new System.Windows.Forms.DataGridView();
            this.MaVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaVaccine = new DevExpress.XtraEditors.SimpleButton();
            this.cbbLoaiVaccine = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnXuatExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiVaccine.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBaoCao);
            this.groupControl1.Controls.Add(this.btnXuatExcel);
            this.groupControl1.Controls.Add(this.dtpHSD);
            this.groupControl1.Controls.Add(this.dtpNSX);
            this.groupControl1.Controls.Add(this.btnVaccineHetHSD);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label11);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtTenLoaiVaccine);
            this.groupControl1.Controls.Add(this.txtKhoChua);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtNCC);
            this.groupControl1.Controls.Add(this.txtSoLuongConLai);
            this.groupControl1.Controls.Add(this.txtTenVaccine);
            this.groupControl1.Controls.Add(this.txtMaVaccine);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.btnXoaVaccine);
            this.groupControl1.Location = new System.Drawing.Point(275, 27);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1402, 782);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin vaccine";
            // 
            // dtpHSD
            // 
            this.dtpHSD.CustomFormat = "dd/MM/yyyy";
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHSD.Location = new System.Drawing.Point(792, 108);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(141, 23);
            this.dtpHSD.TabIndex = 9;
            // 
            // dtpNSX
            // 
            this.dtpNSX.CustomFormat = "dd/MM/yyy";
            this.dtpNSX.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNSX.Location = new System.Drawing.Point(792, 58);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(141, 23);
            this.dtpNSX.TabIndex = 8;
            // 
            // btnVaccineHetHSD
            // 
            this.btnVaccineHetHSD.Location = new System.Drawing.Point(1202, 147);
            this.btnVaccineHetHSD.Name = "btnVaccineHetHSD";
            this.btnVaccineHetHSD.Size = new System.Drawing.Size(179, 29);
            this.btnVaccineHetHSD.TabIndex = 7;
            this.btnVaccineHetHSD.Text = "Vaccine hết hạn sử dụng";
            this.btnVaccineHetHSD.Click += new System.EventHandler(this.btnVaccineHetHSD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Loại vaccine";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng còn lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên vaccine";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Kho chứa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nhà cung cấp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(661, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Hạn sử dụng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(661, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã vaccine";
            // 
            // txtTenLoaiVaccine
            // 
            this.txtTenLoaiVaccine.Location = new System.Drawing.Point(447, 55);
            this.txtTenLoaiVaccine.Name = "txtTenLoaiVaccine";
            this.txtTenLoaiVaccine.Size = new System.Drawing.Size(141, 23);
            this.txtTenLoaiVaccine.TabIndex = 4;
            // 
            // txtKhoChua
            // 
            this.txtKhoChua.Location = new System.Drawing.Point(447, 165);
            this.txtKhoChua.Name = "txtKhoChua";
            this.txtKhoChua.Size = new System.Drawing.Size(141, 23);
            this.txtKhoChua.TabIndex = 4;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(792, 156);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(141, 23);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtNCC
            // 
            this.txtNCC.Location = new System.Drawing.Point(447, 105);
            this.txtNCC.Name = "txtNCC";
            this.txtNCC.Size = new System.Drawing.Size(141, 23);
            this.txtNCC.TabIndex = 4;
            // 
            // txtSoLuongConLai
            // 
            this.txtSoLuongConLai.Location = new System.Drawing.Point(146, 164);
            this.txtSoLuongConLai.Name = "txtSoLuongConLai";
            this.txtSoLuongConLai.Size = new System.Drawing.Size(141, 23);
            this.txtSoLuongConLai.TabIndex = 4;
            // 
            // txtTenVaccine
            // 
            this.txtTenVaccine.Location = new System.Drawing.Point(146, 107);
            this.txtTenVaccine.Name = "txtTenVaccine";
            this.txtTenVaccine.Size = new System.Drawing.Size(141, 23);
            this.txtTenVaccine.TabIndex = 4;
            // 
            // txtMaVaccine
            // 
            this.txtMaVaccine.Location = new System.Drawing.Point(146, 57);
            this.txtMaVaccine.Name = "txtMaVaccine";
            this.txtMaVaccine.Size = new System.Drawing.Size(141, 23);
            this.txtMaVaccine.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtGVVaccine);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(2, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1398, 554);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtGVVaccine
            // 
            this.dtGVVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVVaccine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVaccine,
            this.TenVaccine,
            this.SoLuong,
            this.DonGia,
            this.NSX,
            this.HSD,
            this.TenLoaiVaccine,
            this.NhaCungCap,
            this.KhoChua});
            this.dtGVVaccine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGVVaccine.Location = new System.Drawing.Point(3, 19);
            this.dtGVVaccine.Name = "dtGVVaccine";
            this.dtGVVaccine.RowHeadersWidth = 51;
            this.dtGVVaccine.RowTemplate.Height = 24;
            this.dtGVVaccine.Size = new System.Drawing.Size(1392, 532);
            this.dtGVVaccine.TabIndex = 1;
            this.dtGVVaccine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVVaccine_CellClick);
            // 
            // MaVaccine
            // 
            this.MaVaccine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaVaccine.DataPropertyName = "MaVaccine";
            this.MaVaccine.HeaderText = "Mã Vaccine";
            this.MaVaccine.MinimumWidth = 6;
            this.MaVaccine.Name = "MaVaccine";
            // 
            // TenVaccine
            // 
            this.TenVaccine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenVaccine.DataPropertyName = "TenVaccine";
            this.TenVaccine.HeaderText = "Tên vaccine";
            this.TenVaccine.MinimumWidth = 6;
            this.TenVaccine.Name = "TenVaccine";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // NSX
            // 
            this.NSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            // 
            // HSD
            // 
            this.HSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            // 
            // TenLoaiVaccine
            // 
            this.TenLoaiVaccine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiVaccine.DataPropertyName = "TenLoaiVaccine";
            this.TenLoaiVaccine.HeaderText = "Loại vaccine";
            this.TenLoaiVaccine.MinimumWidth = 6;
            this.TenLoaiVaccine.Name = "TenLoaiVaccine";
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhaCungCap.DataPropertyName = "NhaCungCap";
            this.NhaCungCap.HeaderText = "Nhà cung cấp";
            this.NhaCungCap.MinimumWidth = 6;
            this.NhaCungCap.Name = "NhaCungCap";
            // 
            // KhoChua
            // 
            this.KhoChua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KhoChua.DataPropertyName = "KhoChua";
            this.KhoChua.HeaderText = "Kho";
            this.KhoChua.MinimumWidth = 6;
            this.KhoChua.Name = "KhoChua";
            // 
            // btnXoaVaccine
            // 
            this.btnXoaVaccine.Location = new System.Drawing.Point(1202, 191);
            this.btnXoaVaccine.Name = "btnXoaVaccine";
            this.btnXoaVaccine.Size = new System.Drawing.Size(179, 29);
            this.btnXoaVaccine.TabIndex = 2;
            this.btnXoaVaccine.Text = "Tiêu huỷ";
            this.btnXoaVaccine.Click += new System.EventHandler(this.btnXoaVaccine_Click);
            // 
            // cbbLoaiVaccine
            // 
            this.cbbLoaiVaccine.Location = new System.Drawing.Point(128, 35);
            this.cbbLoaiVaccine.Name = "cbbLoaiVaccine";
            this.cbbLoaiVaccine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbLoaiVaccine.Properties.Items.AddRange(new object[] {
            "Vaccine Cúm",
            "Vaccine Dại",
            "Vaccine Lao",
            "Vaccine Sởi",
            "Vaccine Thuỷ đậu",
            "Vaccine Thương hàn",
            "Vaccine Uống ván"});
            this.cbbLoaiVaccine.Size = new System.Drawing.Size(132, 22);
            this.cbbLoaiVaccine.TabIndex = 2;
            this.cbbLoaiVaccine.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiVaccine_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cbbLoaiVaccine);
            this.groupBox2.Location = new System.Drawing.Point(3, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 3;
            this.label13.Text = "Loại vaccine";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Location = new System.Drawing.Point(1016, 147);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(94, 29);
            this.btnXuatExcel.TabIndex = 10;
            this.btnXuatExcel.Text = "Xuất ra excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(1016, 191);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(94, 29);
            this.btnBaoCao.TabIndex = 11;
            this.btnBaoCao.Text = "Báo cáo";
            // 
            // FormVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormVaccine";
            this.Size = new System.Drawing.Size(2248, 844);
            this.Load += new System.EventHandler(this.FormVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbbLoaiVaccine.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaVaccine;
        private System.Windows.Forms.DataGridView dtGVVaccine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenLoaiVaccine;
        private System.Windows.Forms.TextBox txtKhoChua;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtNCC;
        private System.Windows.Forms.TextBox txtSoLuongConLai;
        private System.Windows.Forms.TextBox txtTenVaccine;
        private System.Windows.Forms.TextBox txtMaVaccine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit cbbLoaiVaccine;
        private DevExpress.XtraEditors.SimpleButton btnVaccineHetHSD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoChua;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private DevExpress.XtraEditors.SimpleButton btnXuatExcel;
    }
}
