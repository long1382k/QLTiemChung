
namespace DXApplication2
{
     partial class FormYTa
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYTa));
               this.dataYTa = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.txtMaYTa = new DevExpress.XtraEditors.TextEdit();
               this.txtHoTenYTa = new DevExpress.XtraEditors.TextEdit();
               this.txtGTYTa = new DevExpress.XtraEditors.TextEdit();
               this.dateYTa = new DevExpress.XtraEditors.DateEdit();
               this.txtSDTYTa = new DevExpress.XtraEditors.TextEdit();
               this.dateYTa1 = new DevExpress.XtraEditors.DateEdit();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutThongTinYTa = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
               this.btnThemYTa = new DevExpress.XtraEditors.SimpleButton();
               this.btnSuaYTa = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoaYTa = new DevExpress.XtraEditors.SimpleButton();
               this.btnLuuYTa = new DevExpress.XtraEditors.SimpleButton();
               this.btnHuyYTa = new DevExpress.XtraEditors.SimpleButton();
               this.btnBDTKYT = new DevExpress.XtraEditors.SimpleButton();
               this.btnTKYT = new DevExpress.XtraEditors.SimpleButton();
               this.btnXuatExcelYTa = new DevExpress.XtraEditors.SimpleButton();
               this.label1 = new System.Windows.Forms.Label();
               this.btnXuatYTa = new DevExpress.XtraEditors.SimpleButton();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.btnYTaNghiHuu = new DevExpress.XtraEditors.SimpleButton();
               this.btnThoatNV = new DevExpress.XtraEditors.SimpleButton();
               this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.dataYTa)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.txtMaYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtHoTenYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtGTYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtSDTYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa1.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa1.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutThongTinYTa)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataYTa
               // 
               this.dataYTa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
               this.dataYTa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataYTa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
               this.dataYTa.Location = new System.Drawing.Point(59, 61);
               this.dataYTa.Name = "dataYTa";
               this.dataYTa.RowHeadersWidth = 51;
               this.dataYTa.RowTemplate.Height = 24;
               this.dataYTa.Size = new System.Drawing.Size(967, 742);
               this.dataYTa.TabIndex = 0;
               this.dataYTa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataYTa_MouseClick);
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
               this.Column2.DataPropertyName = "MaYTa";
               this.Column2.HeaderText = "Mã y tá";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               this.Column2.Width = 125;
               // 
               // Column3
               // 
               this.Column3.DataPropertyName = "HoTenYTa";
               this.Column3.HeaderText = "Họ tên y tá";
               this.Column3.MinimumWidth = 6;
               this.Column3.Name = "Column3";
               this.Column3.Width = 215;
               // 
               // Column4
               // 
               this.Column4.DataPropertyName = "NgaySinh";
               this.Column4.HeaderText = "Ngày sinh";
               this.Column4.MinimumWidth = 6;
               this.Column4.Name = "Column4";
               this.Column4.Width = 125;
               // 
               // Column5
               // 
               this.Column5.DataPropertyName = "GioiTinh";
               this.Column5.HeaderText = "Giới tính";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.Width = 95;
               // 
               // Column6
               // 
               this.Column6.DataPropertyName = "SDT";
               this.Column6.HeaderText = "SĐT";
               this.Column6.MinimumWidth = 6;
               this.Column6.Name = "Column6";
               this.Column6.Width = 135;
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.txtMaYTa);
               this.layoutControl1.Controls.Add(this.txtHoTenYTa);
               this.layoutControl1.Controls.Add(this.txtGTYTa);
               this.layoutControl1.Controls.Add(this.dateYTa);
               this.layoutControl1.Controls.Add(this.txtSDTYTa);
               this.layoutControl1.Controls.Add(this.dateYTa1);
               this.layoutControl1.Location = new System.Drawing.Point(1237, 466);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(856, 245);
               this.layoutControl1.TabIndex = 1;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // txtMaYTa
               // 
               this.txtMaYTa.Location = new System.Drawing.Point(120, 50);
               this.txtMaYTa.Name = "txtMaYTa";
               this.txtMaYTa.Size = new System.Drawing.Size(712, 22);
               this.txtMaYTa.StyleController = this.layoutControl1;
               this.txtMaYTa.TabIndex = 4;
               // 
               // txtHoTenYTa
               // 
               this.txtHoTenYTa.Location = new System.Drawing.Point(120, 76);
               this.txtHoTenYTa.Name = "txtHoTenYTa";
               this.txtHoTenYTa.Size = new System.Drawing.Size(712, 22);
               this.txtHoTenYTa.StyleController = this.layoutControl1;
               this.txtHoTenYTa.TabIndex = 5;
               // 
               // txtGTYTa
               // 
               this.txtGTYTa.Location = new System.Drawing.Point(120, 128);
               this.txtGTYTa.Name = "txtGTYTa";
               this.txtGTYTa.Size = new System.Drawing.Size(712, 22);
               this.txtGTYTa.StyleController = this.layoutControl1;
               this.txtGTYTa.TabIndex = 6;
               // 
               // dateYTa
               // 
               this.dateYTa.EditValue = null;
               this.dateYTa.Location = new System.Drawing.Point(120, 102);
               this.dateYTa.Name = "dateYTa";
               this.dateYTa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateYTa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateYTa.Properties.Validating += new System.ComponentModel.CancelEventHandler(this.dateYTa_Properties_Validating);
               this.dateYTa.Size = new System.Drawing.Size(305, 22);
               this.dateYTa.StyleController = this.layoutControl1;
               this.dateYTa.TabIndex = 7;
               // 
               // txtSDTYTa
               // 
               this.txtSDTYTa.Location = new System.Drawing.Point(120, 154);
               this.txtSDTYTa.Name = "txtSDTYTa";
               this.txtSDTYTa.Size = new System.Drawing.Size(712, 22);
               this.txtSDTYTa.StyleController = this.layoutControl1;
               this.txtSDTYTa.TabIndex = 8;
               // 
               // dateYTa1
               // 
               this.dateYTa1.EditValue = null;
               this.dateYTa1.Location = new System.Drawing.Point(525, 102);
               this.dateYTa1.Name = "dateYTa1";
               this.dateYTa1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateYTa1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateYTa1.Size = new System.Drawing.Size(307, 22);
               this.dateYTa1.StyleController = this.layoutControl1;
               this.dateYTa1.TabIndex = 9;
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutThongTinYTa});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(856, 245);
               // 
               // layoutThongTinYTa
               // 
               this.layoutThongTinYTa.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
               this.layoutThongTinYTa.Location = new System.Drawing.Point(0, 0);
               this.layoutThongTinYTa.Name = "layoutThongTinYTa";
               this.layoutThongTinYTa.Size = new System.Drawing.Size(836, 225);
               this.layoutThongTinYTa.Text = "Thông tin y tá";
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.txtMaYTa;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(812, 26);
               this.layoutControlItem1.Text = "Mã y tá:";
               this.layoutControlItem1.TextSize = new System.Drawing.Size(84, 16);
               // 
               // layoutControlItem2
               // 
               this.layoutControlItem2.Control = this.txtHoTenYTa;
               this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
               this.layoutControlItem2.Name = "layoutControlItem2";
               this.layoutControlItem2.Size = new System.Drawing.Size(812, 26);
               this.layoutControlItem2.Text = "Họ tên y tá:";
               this.layoutControlItem2.TextSize = new System.Drawing.Size(84, 17);
               // 
               // layoutControlItem4
               // 
               this.layoutControlItem4.Control = this.dateYTa;
               this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
               this.layoutControlItem4.Name = "layoutControlItem4";
               this.layoutControlItem4.Size = new System.Drawing.Size(405, 26);
               this.layoutControlItem4.Text = "Ngày sinh:";
               this.layoutControlItem4.TextSize = new System.Drawing.Size(84, 16);
               // 
               // layoutControlItem3
               // 
               this.layoutControlItem3.Control = this.txtGTYTa;
               this.layoutControlItem3.Location = new System.Drawing.Point(0, 78);
               this.layoutControlItem3.Name = "layoutControlItem3";
               this.layoutControlItem3.Size = new System.Drawing.Size(812, 26);
               this.layoutControlItem3.Text = "Giới tính";
               this.layoutControlItem3.TextSize = new System.Drawing.Size(84, 17);
               // 
               // layoutControlItem5
               // 
               this.layoutControlItem5.Control = this.txtSDTYTa;
               this.layoutControlItem5.Location = new System.Drawing.Point(0, 104);
               this.layoutControlItem5.Name = "layoutControlItem5";
               this.layoutControlItem5.Size = new System.Drawing.Size(812, 71);
               this.layoutControlItem5.Text = "Số điện thoại:";
               this.layoutControlItem5.TextSize = new System.Drawing.Size(84, 17);
               // 
               // layoutControlItem6
               // 
               this.layoutControlItem6.Control = this.dateYTa1;
               this.layoutControlItem6.Location = new System.Drawing.Point(405, 52);
               this.layoutControlItem6.Name = "layoutControlItem6";
               this.layoutControlItem6.Size = new System.Drawing.Size(407, 26);
               this.layoutControlItem6.Text = "đến:";
               this.layoutControlItem6.TextSize = new System.Drawing.Size(84, 17);
               // 
               // btnThemYTa
               // 
               this.btnThemYTa.Location = new System.Drawing.Point(1250, 717);
               this.btnThemYTa.Name = "btnThemYTa";
               this.btnThemYTa.Size = new System.Drawing.Size(94, 29);
               this.btnThemYTa.TabIndex = 2;
               this.btnThemYTa.Text = "Thêm";
               this.btnThemYTa.Click += new System.EventHandler(this.btnThemYTa_Click);
               // 
               // btnSuaYTa
               // 
               this.btnSuaYTa.Location = new System.Drawing.Point(1350, 717);
               this.btnSuaYTa.Name = "btnSuaYTa";
               this.btnSuaYTa.Size = new System.Drawing.Size(94, 29);
               this.btnSuaYTa.TabIndex = 3;
               this.btnSuaYTa.Text = "Sửa";
               this.btnSuaYTa.Click += new System.EventHandler(this.btnSuaYTa_Click);
               // 
               // btnXoaYTa
               // 
               this.btnXoaYTa.Location = new System.Drawing.Point(1450, 717);
               this.btnXoaYTa.Name = "btnXoaYTa";
               this.btnXoaYTa.Size = new System.Drawing.Size(94, 29);
               this.btnXoaYTa.TabIndex = 4;
               this.btnXoaYTa.Text = "Xóa";
               this.btnXoaYTa.Click += new System.EventHandler(this.btnXoaYTa_Click);
               // 
               // btnLuuYTa
               // 
               this.btnLuuYTa.Location = new System.Drawing.Point(1306, 774);
               this.btnLuuYTa.Name = "btnLuuYTa";
               this.btnLuuYTa.Size = new System.Drawing.Size(94, 29);
               this.btnLuuYTa.TabIndex = 5;
               this.btnLuuYTa.Text = "Lưu";
               this.btnLuuYTa.Click += new System.EventHandler(this.btnLuuYTa_Click);
               // 
               // btnHuyYTa
               // 
               this.btnHuyYTa.Location = new System.Drawing.Point(1406, 774);
               this.btnHuyYTa.Name = "btnHuyYTa";
               this.btnHuyYTa.Size = new System.Drawing.Size(94, 29);
               this.btnHuyYTa.TabIndex = 6;
               this.btnHuyYTa.Text = "Hủy";
               this.btnHuyYTa.Click += new System.EventHandler(this.btnHuyYTa_Click);
               // 
               // btnBDTKYT
               // 
               this.btnBDTKYT.Location = new System.Drawing.Point(1576, 717);
               this.btnBDTKYT.Name = "btnBDTKYT";
               this.btnBDTKYT.Size = new System.Drawing.Size(131, 29);
               this.btnBDTKYT.TabIndex = 7;
               this.btnBDTKYT.Text = "Bắt đầu tìm kiếm";
               this.btnBDTKYT.Click += new System.EventHandler(this.btnBDTKYT_Click);
               // 
               // btnTKYT
               // 
               this.btnTKYT.Location = new System.Drawing.Point(1713, 717);
               this.btnTKYT.Name = "btnTKYT";
               this.btnTKYT.Size = new System.Drawing.Size(94, 29);
               this.btnTKYT.TabIndex = 8;
               this.btnTKYT.Text = "Tìm kiếm";
               this.btnTKYT.Click += new System.EventHandler(this.btnTKYT_Click);
               // 
               // btnXuatExcelYTa
               // 
               this.btnXuatExcelYTa.Location = new System.Drawing.Point(1984, 717);
               this.btnXuatExcelYTa.Name = "btnXuatExcelYTa";
               this.btnXuatExcelYTa.Size = new System.Drawing.Size(94, 29);
               this.btnXuatExcelYTa.TabIndex = 9;
               this.btnXuatExcelYTa.Text = "Xuất excel";
               this.btnXuatExcelYTa.Click += new System.EventHandler(this.btnXuatExcelYTa_Click);
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(57, 28);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(103, 17);
               this.label1.TabIndex = 11;
               this.label1.Text = "Danh sách y tá";
               // 
               // btnXuatYTa
               // 
               this.btnXuatYTa.Location = new System.Drawing.Point(1848, 717);
               this.btnXuatYTa.Name = "btnXuatYTa";
               this.btnXuatYTa.Size = new System.Drawing.Size(130, 29);
               this.btnXuatYTa.TabIndex = 12;
               this.btnXuatYTa.Text = "Xuất báo cáo";
               this.btnXuatYTa.Click += new System.EventHandler(this.btnXuatYTa_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
               this.pictureBox1.Location = new System.Drawing.Point(1505, 101);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(322, 322);
               this.pictureBox1.TabIndex = 13;
               this.pictureBox1.TabStop = false;
               // 
               // btnYTaNghiHuu
               // 
               this.btnYTaNghiHuu.Location = new System.Drawing.Point(1637, 774);
               this.btnYTaNghiHuu.Name = "btnYTaNghiHuu";
               this.btnYTaNghiHuu.Size = new System.Drawing.Size(291, 29);
               this.btnYTaNghiHuu.TabIndex = 14;
               this.btnYTaNghiHuu.Text = "Danh sách y tá nghỉ hưu trong năm nay";
               this.btnYTaNghiHuu.Click += new System.EventHandler(this.btnYTaNghiHuu_Click);
               // 
               // btnThoatNV
               // 
               this.btnThoatNV.Location = new System.Drawing.Point(1934, 774);
               this.btnThoatNV.Name = "btnThoatNV";
               this.btnThoatNV.Size = new System.Drawing.Size(94, 29);
               this.btnThoatNV.TabIndex = 16;
               this.btnThoatNV.Text = "Thoát";
               this.btnThoatNV.Click += new System.EventHandler(this.btnThoatNV_Click);
               // 
               // dxErrorProvider1
               // 
               this.dxErrorProvider1.ContainerControl = this;
               // 
               // FormYTa
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnThoatNV);
               this.Controls.Add(this.btnYTaNghiHuu);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.btnXuatYTa);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.btnXuatExcelYTa);
               this.Controls.Add(this.btnTKYT);
               this.Controls.Add(this.btnBDTKYT);
               this.Controls.Add(this.btnHuyYTa);
               this.Controls.Add(this.btnLuuYTa);
               this.Controls.Add(this.btnXoaYTa);
               this.Controls.Add(this.btnSuaYTa);
               this.Controls.Add(this.btnThemYTa);
               this.Controls.Add(this.layoutControl1);
               this.Controls.Add(this.dataYTa);
               this.Name = "FormYTa";
               this.Size = new System.Drawing.Size(2248, 844);
               this.Load += new System.EventHandler(this.FormYTa_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dataYTa)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.txtMaYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtHoTenYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtGTYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtSDTYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa1.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateYTa1.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutThongTinYTa)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataYTa;
          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraEditors.TextEdit txtMaYTa;
          private DevExpress.XtraLayout.LayoutControlGroup layoutThongTinYTa;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
          private DevExpress.XtraEditors.TextEdit txtHoTenYTa;
          private DevExpress.XtraEditors.TextEdit txtGTYTa;
          private DevExpress.XtraEditors.DateEdit dateYTa;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
          private DevExpress.XtraEditors.TextEdit txtSDTYTa;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
          private DevExpress.XtraEditors.SimpleButton btnThemYTa;
          private DevExpress.XtraEditors.SimpleButton btnSuaYTa;
          private DevExpress.XtraEditors.SimpleButton btnXoaYTa;
          private DevExpress.XtraEditors.SimpleButton btnLuuYTa;
          private DevExpress.XtraEditors.SimpleButton btnHuyYTa;
          private DevExpress.XtraEditors.SimpleButton btnBDTKYT;
          private DevExpress.XtraEditors.SimpleButton btnTKYT;
          private DevExpress.XtraEditors.SimpleButton btnXuatExcelYTa;
          private DevExpress.XtraEditors.DateEdit dateYTa1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
          private System.Windows.Forms.Label label1;
          private DevExpress.XtraEditors.SimpleButton btnXuatYTa;
          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>


          #endregion

          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
          private DevExpress.XtraEditors.SimpleButton btnYTaNghiHuu;
          private DevExpress.XtraEditors.SimpleButton btnThoatNV;
          private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
     }
}