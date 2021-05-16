
namespace DXApplication2
{
     partial class FormNhanVien
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
               this.dataNV = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnSuaNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoaNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnLuuNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnHuyNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnBDTKNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnTKNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnXuatNV = new DevExpress.XtraEditors.SimpleButton();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
               this.txtHoTenNV = new DevExpress.XtraEditors.TextEdit();
               this.dateNV = new DevExpress.XtraEditors.DateEdit();
               this.dateNV1 = new DevExpress.XtraEditors.DateEdit();
               this.txtGTNV = new DevExpress.XtraEditors.TextEdit();
               this.txtSDTNV = new DevExpress.XtraEditors.TextEdit();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutThongTinNV = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               this.btnXuatBCNV = new DevExpress.XtraEditors.SimpleButton();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.btnNVNghiHuu = new DevExpress.XtraEditors.SimpleButton();
               this.btnThoatNV = new DevExpress.XtraEditors.SimpleButton();
               this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.dataNV)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV1.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV1.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtGTNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtSDTNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutThongTinNV)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataNV
               // 
               this.dataNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
               this.dataNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
               this.dataNV.Location = new System.Drawing.Point(63, 56);
               this.dataNV.Name = "dataNV";
               this.dataNV.RowHeadersWidth = 51;
               this.dataNV.RowTemplate.Height = 24;
               this.dataNV.Size = new System.Drawing.Size(985, 754);
               this.dataNV.TabIndex = 0;
               this.dataNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNV_CellClick);
               // 
               // Column1
               // 
               this.Column1.HeaderText = "STT";
               this.Column1.MinimumWidth = 6;
               this.Column1.Name = "Column1";
               this.Column1.Width = 65;
               // 
               // Column2
               // 
               this.Column2.DataPropertyName = "MaNV";
               this.Column2.HeaderText = "Mã nhân viên";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               this.Column2.Width = 120;
               // 
               // Column3
               // 
               this.Column3.DataPropertyName = "HoTenNV";
               this.Column3.HeaderText = "Họ tên nhân viên";
               this.Column3.MinimumWidth = 6;
               this.Column3.Name = "Column3";
               this.Column3.Width = 200;
               // 
               // Column4
               // 
               this.Column4.DataPropertyName = "NgaySinh";
               this.Column4.HeaderText = "Ngày sinh";
               this.Column4.MinimumWidth = 6;
               this.Column4.Name = "Column4";
               this.Column4.Width = 145;
               // 
               // Column5
               // 
               this.Column5.DataPropertyName = "GioiTinh";
               this.Column5.HeaderText = "Giới tính";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.Width = 115;
               // 
               // Column6
               // 
               this.Column6.DataPropertyName = "SDT";
               this.Column6.HeaderText = "SĐT";
               this.Column6.MinimumWidth = 6;
               this.Column6.Name = "Column6";
               this.Column6.Width = 135;
               // 
               // btnThemNV
               // 
               this.btnThemNV.Location = new System.Drawing.Point(1202, 723);
               this.btnThemNV.Name = "btnThemNV";
               this.btnThemNV.Size = new System.Drawing.Size(94, 29);
               this.btnThemNV.TabIndex = 2;
               this.btnThemNV.Text = "Thêm";
               this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
               // 
               // btnSuaNV
               // 
               this.btnSuaNV.Location = new System.Drawing.Point(1302, 723);
               this.btnSuaNV.Name = "btnSuaNV";
               this.btnSuaNV.Size = new System.Drawing.Size(93, 29);
               this.btnSuaNV.TabIndex = 3;
               this.btnSuaNV.Text = "Sửa";
               this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
               // 
               // btnXoaNV
               // 
               this.btnXoaNV.Location = new System.Drawing.Point(1401, 723);
               this.btnXoaNV.Name = "btnXoaNV";
               this.btnXoaNV.Size = new System.Drawing.Size(90, 29);
               this.btnXoaNV.TabIndex = 4;
               this.btnXoaNV.Text = "Xóa";
               this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
               // 
               // btnLuuNV
               // 
               this.btnLuuNV.Location = new System.Drawing.Point(1257, 781);
               this.btnLuuNV.Name = "btnLuuNV";
               this.btnLuuNV.Size = new System.Drawing.Size(94, 29);
               this.btnLuuNV.TabIndex = 5;
               this.btnLuuNV.Text = "Lưu";
               this.btnLuuNV.Click += new System.EventHandler(this.btnLuuNV_Click);
               // 
               // btnHuyNV
               // 
               this.btnHuyNV.Location = new System.Drawing.Point(1357, 781);
               this.btnHuyNV.Name = "btnHuyNV";
               this.btnHuyNV.Size = new System.Drawing.Size(94, 29);
               this.btnHuyNV.TabIndex = 6;
               this.btnHuyNV.Text = "Hủy";
               this.btnHuyNV.Click += new System.EventHandler(this.btnHuyNV_Click);
               // 
               // btnBDTKNV
               // 
               this.btnBDTKNV.Location = new System.Drawing.Point(1559, 723);
               this.btnBDTKNV.Name = "btnBDTKNV";
               this.btnBDTKNV.Size = new System.Drawing.Size(121, 29);
               this.btnBDTKNV.TabIndex = 7;
               this.btnBDTKNV.Text = "Bắt đầu tìm kiếm";
               this.btnBDTKNV.Click += new System.EventHandler(this.btnBDTKNV_Click);
               // 
               // btnTKNV
               // 
               this.btnTKNV.Location = new System.Drawing.Point(1686, 723);
               this.btnTKNV.Name = "btnTKNV";
               this.btnTKNV.Size = new System.Drawing.Size(94, 29);
               this.btnTKNV.TabIndex = 8;
               this.btnTKNV.Text = "Tìm kiếm";
               this.btnTKNV.Click += new System.EventHandler(this.btnTKNV_Click);
               // 
               // btnXuatNV
               // 
               this.btnXuatNV.Location = new System.Drawing.Point(1913, 723);
               this.btnXuatNV.Name = "btnXuatNV";
               this.btnXuatNV.Size = new System.Drawing.Size(94, 29);
               this.btnXuatNV.TabIndex = 9;
               this.btnXuatNV.Text = "Xuất excel";
               this.btnXuatNV.Click += new System.EventHandler(this.btnXuatNV_Click);
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.txtMaNV);
               this.layoutControl1.Controls.Add(this.txtHoTenNV);
               this.layoutControl1.Controls.Add(this.dateNV);
               this.layoutControl1.Controls.Add(this.dateNV1);
               this.layoutControl1.Controls.Add(this.txtGTNV);
               this.layoutControl1.Controls.Add(this.txtSDTNV);
               this.layoutControl1.Location = new System.Drawing.Point(1202, 470);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 35, 812, 500);
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(820, 233);
               this.layoutControl1.TabIndex = 11;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // txtMaNV
               // 
               this.txtMaNV.Location = new System.Drawing.Point(146, 50);
               this.txtMaNV.Name = "txtMaNV";
               this.txtMaNV.Size = new System.Drawing.Size(650, 22);
               this.txtMaNV.StyleController = this.layoutControl1;
               this.txtMaNV.TabIndex = 4;
               // 
               // txtHoTenNV
               // 
               this.txtHoTenNV.Location = new System.Drawing.Point(146, 76);
               this.txtHoTenNV.Name = "txtHoTenNV";
               this.txtHoTenNV.Size = new System.Drawing.Size(650, 22);
               this.txtHoTenNV.StyleController = this.layoutControl1;
               this.txtHoTenNV.TabIndex = 5;
               // 
               // dateNV
               // 
               this.dateNV.EditValue = null;
               this.dateNV.Location = new System.Drawing.Point(146, 102);
               this.dateNV.Name = "dateNV";
               this.dateNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateNV.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.dateNV_Properties_Validating);
               this.dateNV.Size = new System.Drawing.Size(261, 22);
               this.dateNV.StyleController = this.layoutControl1;
               this.dateNV.TabIndex = 6;
               // 
               // dateNV1
               // 
               this.dateNV1.EditValue = null;
               this.dateNV1.Location = new System.Drawing.Point(533, 102);
               this.dateNV1.Name = "dateNV1";
               this.dateNV1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateNV1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateNV1.Size = new System.Drawing.Size(263, 22);
               this.dateNV1.StyleController = this.layoutControl1;
               this.dateNV1.TabIndex = 7;
               // 
               // txtGTNV
               // 
               this.txtGTNV.Location = new System.Drawing.Point(146, 128);
               this.txtGTNV.Name = "txtGTNV";
               this.txtGTNV.Size = new System.Drawing.Size(650, 22);
               this.txtGTNV.StyleController = this.layoutControl1;
               this.txtGTNV.TabIndex = 8;
               // 
               // txtSDTNV
               // 
               this.txtSDTNV.Location = new System.Drawing.Point(146, 154);
               this.txtSDTNV.Name = "txtSDTNV";
               this.txtSDTNV.Size = new System.Drawing.Size(650, 22);
               this.txtSDTNV.StyleController = this.layoutControl1;
               this.txtSDTNV.TabIndex = 9;
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutThongTinNV});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(820, 233);
               this.Root.TextVisible = false;
               // 
               // layoutThongTinNV
               // 
               this.layoutThongTinNV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem4});
               this.layoutThongTinNV.Location = new System.Drawing.Point(0, 0);
               this.layoutThongTinNV.Name = "layoutThongTinNV";
               this.layoutThongTinNV.Size = new System.Drawing.Size(800, 213);
               this.layoutThongTinNV.Text = "Thông tin nhân viên";
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.txtMaNV;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(776, 26);
               this.layoutControlItem1.Text = "Mã nhân viên:";
               this.layoutControlItem1.TextSize = new System.Drawing.Size(110, 16);
               // 
               // layoutControlItem2
               // 
               this.layoutControlItem2.Control = this.txtHoTenNV;
               this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
               this.layoutControlItem2.Name = "layoutControlItem2";
               this.layoutControlItem2.Size = new System.Drawing.Size(776, 26);
               this.layoutControlItem2.Text = "Họ tên nhân viên:";
               this.layoutControlItem2.TextSize = new System.Drawing.Size(110, 17);
               // 
               // layoutControlItem3
               // 
               this.layoutControlItem3.Control = this.dateNV;
               this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
               this.layoutControlItem3.Name = "layoutControlItem3";
               this.layoutControlItem3.Size = new System.Drawing.Size(387, 26);
               this.layoutControlItem3.Text = "Ngày sinh:";
               this.layoutControlItem3.TextSize = new System.Drawing.Size(110, 16);
               // 
               // layoutControlItem5
               // 
               this.layoutControlItem5.Control = this.txtGTNV;
               this.layoutControlItem5.Location = new System.Drawing.Point(0, 78);
               this.layoutControlItem5.Name = "layoutControlItem5";
               this.layoutControlItem5.Size = new System.Drawing.Size(776, 26);
               this.layoutControlItem5.Text = "Giới tính:";
               this.layoutControlItem5.TextSize = new System.Drawing.Size(110, 17);
               // 
               // layoutControlItem6
               // 
               this.layoutControlItem6.Control = this.txtSDTNV;
               this.layoutControlItem6.Location = new System.Drawing.Point(0, 104);
               this.layoutControlItem6.Name = "layoutControlItem6";
               this.layoutControlItem6.Size = new System.Drawing.Size(776, 59);
               this.layoutControlItem6.Text = "Số điện thoại:";
               this.layoutControlItem6.TextSize = new System.Drawing.Size(110, 17);
               // 
               // layoutControlItem4
               // 
               this.layoutControlItem4.Control = this.dateNV1;
               this.layoutControlItem4.Location = new System.Drawing.Point(387, 52);
               this.layoutControlItem4.Name = "layoutControlItem4";
               this.layoutControlItem4.Size = new System.Drawing.Size(389, 26);
               this.layoutControlItem4.Text = "đến:";
               this.layoutControlItem4.TextSize = new System.Drawing.Size(110, 17);
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(63, 25);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(118, 16);
               this.labelControl1.TabIndex = 12;
               this.labelControl1.Text = "Danh sách nhân viên";
               // 
               // btnXuatBCNV
               // 
               this.btnXuatBCNV.Location = new System.Drawing.Point(1786, 723);
               this.btnXuatBCNV.Name = "btnXuatBCNV";
               this.btnXuatBCNV.Size = new System.Drawing.Size(121, 29);
               this.btnXuatBCNV.TabIndex = 13;
               this.btnXuatBCNV.Text = "Xuất báo cáo";
               this.btnXuatBCNV.Click += new System.EventHandler(this.btnXuatBCNV_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(1467, 132);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(322, 322);
               this.pictureBox1.TabIndex = 14;
               this.pictureBox1.TabStop = false;
               // 
               // btnNVNghiHuu
               // 
               this.btnNVNghiHuu.Location = new System.Drawing.Point(1559, 781);
               this.btnNVNghiHuu.Name = "btnNVNghiHuu";
               this.btnNVNghiHuu.Size = new System.Drawing.Size(348, 29);
               this.btnNVNghiHuu.TabIndex = 16;
               this.btnNVNghiHuu.Text = "Danh sách nhân viên nghỉ hưu trong năm nay";
               this.btnNVNghiHuu.Click += new System.EventHandler(this.btnNVNghiHuu_Click);
               // 
               // btnThoatNV
               // 
               this.btnThoatNV.Location = new System.Drawing.Point(1913, 781);
               this.btnThoatNV.Name = "btnThoatNV";
               this.btnThoatNV.Size = new System.Drawing.Size(94, 29);
               this.btnThoatNV.TabIndex = 17;
               this.btnThoatNV.Text = "Thoát";
               this.btnThoatNV.Click += new System.EventHandler(this.btnThoatNV_Click);
               // 
               // dxErrorProvider1
               // 
               this.dxErrorProvider1.ContainerControl = this;
               // 
               // FormNhanVien
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnThoatNV);
               this.Controls.Add(this.btnNVNghiHuu);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.btnXuatBCNV);
               this.Controls.Add(this.labelControl1);
               this.Controls.Add(this.layoutControl1);
               this.Controls.Add(this.btnXuatNV);
               this.Controls.Add(this.btnTKNV);
               this.Controls.Add(this.btnBDTKNV);
               this.Controls.Add(this.btnHuyNV);
               this.Controls.Add(this.btnLuuNV);
               this.Controls.Add(this.btnXoaNV);
               this.Controls.Add(this.btnSuaNV);
               this.Controls.Add(this.btnThemNV);
               this.Controls.Add(this.dataNV);
               this.Name = "FormNhanVien";
               this.Size = new System.Drawing.Size(2248, 844);
               this.Load += new System.EventHandler(this.FormNhanVien_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataNV)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtHoTenNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV1.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateNV1.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtGTNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtSDTNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutThongTinNV)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataNV;
          private DevExpress.XtraEditors.SimpleButton btnThemNV;
          private DevExpress.XtraEditors.SimpleButton btnSuaNV;
          private DevExpress.XtraEditors.SimpleButton btnXoaNV;
          private DevExpress.XtraEditors.SimpleButton btnLuuNV;
          private DevExpress.XtraEditors.SimpleButton btnHuyNV;
          private DevExpress.XtraEditors.SimpleButton btnBDTKNV;
          private DevExpress.XtraEditors.SimpleButton btnTKNV;
          private DevExpress.XtraEditors.SimpleButton btnXuatNV;
          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraEditors.TextEdit txtMaNV;
          private DevExpress.XtraEditors.TextEdit txtHoTenNV;
          private DevExpress.XtraEditors.DateEdit dateNV;
          private DevExpress.XtraEditors.DateEdit dateNV1;
          private DevExpress.XtraEditors.TextEdit txtGTNV;
          private DevExpress.XtraEditors.TextEdit txtSDTNV;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraLayout.LayoutControlGroup layoutThongTinNV;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
          private DevExpress.XtraEditors.LabelControl labelControl1;
          private DevExpress.XtraEditors.SimpleButton btnXuatBCNV;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
          private System.Windows.Forms.PictureBox pictureBox1;
          private DevExpress.XtraEditors.SimpleButton btnNVNghiHuu;
          private DevExpress.XtraEditors.SimpleButton btnThoatNV;
          private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
     }
}
