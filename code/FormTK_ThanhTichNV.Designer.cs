
namespace DXApplication2
{
     partial class FormTK_ThanhTichNV
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
               DevExpress.XtraCharts.XYDiagram xyDiagram4 = new DevExpress.XtraCharts.XYDiagram();
               DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
               this.dataTKTTNV = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colum2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.dateFromNV = new DevExpress.XtraEditors.DateEdit();
               this.dateToNV = new DevExpress.XtraEditors.DateEdit();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutTKTTNV = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
               this.btnTKNV = new DevExpress.XtraEditors.SimpleButton();
               this.btnXuatTKNV = new DevExpress.XtraEditors.SimpleButton();
               this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
               this.searchLookUpTTNV = new DevExpress.XtraEditors.SearchLookUpEdit();
               this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
               this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
               this.btnBieuDoNV = new DevExpress.XtraEditors.SimpleButton();
               this.labelNV = new DevExpress.XtraEditors.LabelControl();
               this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
               this.chartControlNV = new DevExpress.XtraCharts.ChartControl();
               ((System.ComponentModel.ISupportInitialize)(this.dataTKTTNV)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromNV.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToNV.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTKTTNV)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
               this.layoutControl2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTTNV.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControlNV)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
               this.SuspendLayout();
               // 
               // dataTKTTNV
               // 
               this.dataTKTTNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
               this.dataTKTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataTKTTNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.colum2,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
               this.dataTKTTNV.Location = new System.Drawing.Point(46, 186);
               this.dataTKTTNV.Name = "dataTKTTNV";
               this.dataTKTTNV.RowHeadersWidth = 51;
               this.dataTKTTNV.RowTemplate.Height = 24;
               this.dataTKTTNV.Size = new System.Drawing.Size(906, 581);
               this.dataTKTTNV.TabIndex = 0;
               // 
               // Column1
               // 
               this.Column1.HeaderText = "STT";
               this.Column1.MinimumWidth = 6;
               this.Column1.Name = "Column1";
               this.Column1.Width = 55;
               // 
               // colum2
               // 
               this.colum2.DataPropertyName = "MaNV";
               this.colum2.HeaderText = "Mã nhân viên";
               this.colum2.MinimumWidth = 6;
               this.colum2.Name = "colum2";
               this.colum2.Width = 85;
               // 
               // Column2
               // 
               this.Column2.DataPropertyName = "HoTenNV";
               this.Column2.HeaderText = "Họ tên nhân viên";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               this.Column2.Width = 185;
               // 
               // Column3
               // 
               this.Column3.DataPropertyName = "NgaySinh";
               this.Column3.HeaderText = "Ngày sinh";
               this.Column3.MinimumWidth = 6;
               this.Column3.Name = "Column3";
               this.Column3.Width = 115;
               // 
               // Column4
               // 
               this.Column4.DataPropertyName = "GioiTinh";
               this.Column4.HeaderText = "Giới tính";
               this.Column4.MinimumWidth = 6;
               this.Column4.Name = "Column4";
               this.Column4.Width = 85;
               // 
               // Column5
               // 
               this.Column5.DataPropertyName = "SDT";
               this.Column5.HeaderText = "SĐT";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.Width = 105;
               // 
               // Column6
               // 
               this.Column6.DataPropertyName = "TongSoHoaDon";
               this.Column6.HeaderText = "Tống số hóa đơn";
               this.Column6.MinimumWidth = 6;
               this.Column6.Name = "Column6";
               this.Column6.Width = 105;
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.dateFromNV);
               this.layoutControl1.Controls.Add(this.dateToNV);
               this.layoutControl1.Location = new System.Drawing.Point(119, 30);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(722, 120);
               this.layoutControl1.TabIndex = 1;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // dateFromNV
               // 
               this.dateFromNV.EditValue = null;
               this.dateFromNV.Location = new System.Drawing.Point(59, 50);
               this.dateFromNV.Name = "dateFromNV";
               this.dateFromNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateFromNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateFromNV.Size = new System.Drawing.Size(299, 22);
               this.dateFromNV.StyleController = this.layoutControl1;
               this.dateFromNV.TabIndex = 4;
               // 
               // dateToNV
               // 
               this.dateToNV.EditValue = null;
               this.dateToNV.Location = new System.Drawing.Point(397, 50);
               this.dateToNV.Name = "dateToNV";
               this.dateToNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateToNV.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateToNV.Size = new System.Drawing.Size(301, 22);
               this.dateToNV.StyleController = this.layoutControl1;
               this.dateToNV.TabIndex = 5;
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTKTTNV});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(722, 120);
               this.Root.TextVisible = false;
               // 
               // layoutTKTTNV
               // 
               this.layoutTKTTNV.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
               this.layoutTKTTNV.Location = new System.Drawing.Point(0, 0);
               this.layoutTKTTNV.Name = "layoutTKTTNV";
               this.layoutTKTTNV.Size = new System.Drawing.Size(702, 100);
               this.layoutTKTTNV.Text = "Thành tích lập hóa đơn của nhân viên trong khoản gian";
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.dateFromNV;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(338, 50);
               this.layoutControlItem1.Text = "Từ";
               this.layoutControlItem1.TextSize = new System.Drawing.Size(23, 17);
               // 
               // layoutControlItem2
               // 
               this.layoutControlItem2.Control = this.dateToNV;
               this.layoutControlItem2.Location = new System.Drawing.Point(338, 0);
               this.layoutControlItem2.Name = "layoutControlItem2";
               this.layoutControlItem2.Size = new System.Drawing.Size(340, 50);
               this.layoutControlItem2.Text = "đến";
               this.layoutControlItem2.TextSize = new System.Drawing.Size(23, 17);
               // 
               // btnTKNV
               // 
               this.btnTKNV.Location = new System.Drawing.Point(848, 76);
               this.btnTKNV.Name = "btnTKNV";
               this.btnTKNV.Size = new System.Drawing.Size(94, 29);
               this.btnTKNV.TabIndex = 2;
               this.btnTKNV.Text = "Thống kê";
               this.btnTKNV.Click += new System.EventHandler(this.btnTKNV_Click);
               // 
               // btnXuatTKNV
               // 
               this.btnXuatTKNV.Location = new System.Drawing.Point(464, 784);
               this.btnXuatTKNV.Name = "btnXuatTKNV";
               this.btnXuatTKNV.Size = new System.Drawing.Size(94, 29);
               this.btnXuatTKNV.TabIndex = 3;
               this.btnXuatTKNV.Text = "Xuất excel";
               this.btnXuatTKNV.Click += new System.EventHandler(this.btnXuatTKNV_Click);
               // 
               // layoutControl2
               // 
               this.layoutControl2.Controls.Add(this.searchLookUpTTNV);
               this.layoutControl2.Location = new System.Drawing.Point(1096, 50);
               this.layoutControl2.Name = "layoutControl2";
               this.layoutControl2.Root = this.layoutControlGroup1;
               this.layoutControl2.Size = new System.Drawing.Size(768, 55);
               this.layoutControl2.TabIndex = 4;
               this.layoutControl2.Text = "layoutControl2";
               // 
               // searchLookUpTTNV
               // 
               this.searchLookUpTTNV.Location = new System.Drawing.Point(78, 12);
               this.searchLookUpTTNV.Name = "searchLookUpTTNV";
               this.searchLookUpTTNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.searchLookUpTTNV.Properties.PopupView = this.searchLookUpEdit1View;
               this.searchLookUpTTNV.Size = new System.Drawing.Size(657, 22);
               this.searchLookUpTTNV.StyleController = this.layoutControl2;
               this.searchLookUpTTNV.TabIndex = 4;
               // 
               // searchLookUpEdit1View
               // 
               this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
               this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
               this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
               this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
               // 
               // layoutControlGroup1
               // 
               this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.layoutControlGroup1.GroupBordersVisible = false;
               this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem1});
               this.layoutControlGroup1.Name = "layoutControlGroup1";
               this.layoutControlGroup1.Size = new System.Drawing.Size(747, 56);
               this.layoutControlGroup1.TextVisible = false;
               // 
               // layoutControlItem3
               // 
               this.layoutControlItem3.Control = this.searchLookUpTTNV;
               this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem3.Name = "layoutControlItem3";
               this.layoutControlItem3.Size = new System.Drawing.Size(727, 26);
               this.layoutControlItem3.Text = "Tìm kiếm";
               this.layoutControlItem3.TextSize = new System.Drawing.Size(54, 17);
               // 
               // emptySpaceItem1
               // 
               this.emptySpaceItem1.AllowHotTrack = false;
               this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
               this.emptySpaceItem1.Name = "emptySpaceItem1";
               this.emptySpaceItem1.Size = new System.Drawing.Size(727, 10);
               this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
               // 
               // btnBieuDoNV
               // 
               this.btnBieuDoNV.Location = new System.Drawing.Point(1568, 784);
               this.btnBieuDoNV.Name = "btnBieuDoNV";
               this.btnBieuDoNV.Size = new System.Drawing.Size(94, 29);
               this.btnBieuDoNV.TabIndex = 6;
               this.btnBieuDoNV.Text = "Xem biểu đồ";
               this.btnBieuDoNV.Click += new System.EventHandler(this.btnBieuDoNV_Click);
               // 
               // labelNV
               // 
               this.labelNV.Location = new System.Drawing.Point(1081, 157);
               this.labelNV.Name = "labelNV";
               this.labelNV.Size = new System.Drawing.Size(43, 16);
               this.labelNV.TabIndex = 7;
               this.labelNV.Text = "labelNV";
               // 
               // labelControl2
               // 
               this.labelControl2.Location = new System.Drawing.Point(46, 156);
               this.labelControl2.Name = "labelControl2";
               this.labelControl2.Size = new System.Drawing.Size(297, 17);
               this.labelControl2.TabIndex = 9;
               this.labelControl2.Text = "Danh sách thành tích lập hóa đơn của nhân viên";
               // 
               // chartControlNV
               // 
               this.chartControlNV.AppearanceNameSerializable = "Light";
               xyDiagram4.AxisX.VisibleInPanesSerializable = "-1";
               xyDiagram4.AxisY.VisibleInPanesSerializable = "-1";
               xyDiagram4.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
               this.chartControlNV.Diagram = xyDiagram4;
               this.chartControlNV.Location = new System.Drawing.Point(1081, 186);
               this.chartControlNV.Name = "chartControlNV";
               this.chartControlNV.PaletteName = "Blue II";
               series4.ArgumentDataMember = "MaNV";
               series4.Name = "Số hóa đơn";
               series4.ValueDataMembersSerializable = "TongSoHoaDon";
               this.chartControlNV.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
               this.chartControlNV.SeriesTemplate.ArgumentDataMember = "MaNV";
               this.chartControlNV.Size = new System.Drawing.Size(1081, 581);
               this.chartControlNV.TabIndex = 10;
               // 
               // FormTK_ThanhTichNV
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.chartControlNV);
               this.Controls.Add(this.labelControl2);
               this.Controls.Add(this.labelNV);
               this.Controls.Add(this.btnBieuDoNV);
               this.Controls.Add(this.layoutControl2);
               this.Controls.Add(this.btnXuatTKNV);
               this.Controls.Add(this.btnTKNV);
               this.Controls.Add(this.layoutControl1);
               this.Controls.Add(this.dataTKTTNV);
               this.Name = "FormTK_ThanhTichNV";
               this.Size = new System.Drawing.Size(2248, 844);
               ((System.ComponentModel.ISupportInitialize)(this.dataTKTTNV)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dateFromNV.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToNV.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTKTTNV)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
               this.layoutControl2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTTNV.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(xyDiagram4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControlNV)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataTKTTNV;
          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraEditors.DateEdit dateFromNV;
          private DevExpress.XtraEditors.DateEdit dateToNV;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraLayout.LayoutControlGroup layoutTKTTNV;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
          private DevExpress.XtraEditors.SimpleButton btnTKNV;
          private DevExpress.XtraEditors.SimpleButton btnXuatTKNV;
          private DevExpress.XtraLayout.LayoutControl layoutControl2;
          private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpTTNV;
          private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
          private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
          private DevExpress.XtraEditors.SimpleButton btnBieuDoNV;
          private DevExpress.XtraEditors.LabelControl labelNV;
          private DevExpress.XtraEditors.LabelControl labelControl2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn colum2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
          private DevExpress.XtraCharts.ChartControl chartControlNV;
     }
}