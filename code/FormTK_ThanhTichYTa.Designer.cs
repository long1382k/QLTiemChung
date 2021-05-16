
namespace DXApplication2
{
     partial class FormTK_ThanhTichYTa
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
               DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
               DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
               this.dataTKTTYTa = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.btnXuatTTYTa = new DevExpress.XtraEditors.SimpleButton();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.dateFromYTa = new DevExpress.XtraEditors.DateEdit();
               this.dateToYTa = new DevExpress.XtraEditors.DateEdit();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutTKTTYTa = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
               this.btnTKYTa = new DevExpress.XtraEditors.SimpleButton();
               this.searchLookUpTTYTa = new DevExpress.XtraEditors.SearchLookUpEdit();
               this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
               this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
               this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
               this.btnBieuDoYTa = new DevExpress.XtraEditors.SimpleButton();
               this.labelTTYTa = new DevExpress.XtraEditors.LabelControl();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               this.chartControlYTa = new DevExpress.XtraCharts.ChartControl();
               ((System.ComponentModel.ISupportInitialize)(this.dataTKTTYTa)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromYTa.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToYTa.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTKTTYTa)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTTYTa.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
               this.layoutControl2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControlYTa)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataTKTTYTa
               // 
               this.dataTKTTYTa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
               this.dataTKTTYTa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataTKTTYTa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
               this.dataTKTTYTa.Location = new System.Drawing.Point(26, 175);
               this.dataTKTTYTa.Name = "dataTKTTYTa";
               this.dataTKTTYTa.RowHeadersWidth = 51;
               this.dataTKTTYTa.RowTemplate.Height = 24;
               this.dataTKTTYTa.Size = new System.Drawing.Size(935, 559);
               this.dataTKTTYTa.TabIndex = 0;
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
               this.Column2.Width = 85;
               // 
               // Column3
               // 
               this.Column3.DataPropertyName = "HoTenYTa";
               this.Column3.HeaderText = "Họ tên y tá";
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
               this.Column4.Width = 105;
               // 
               // Column5
               // 
               this.Column5.DataPropertyName = "GioiTinh";
               this.Column5.HeaderText = "Giới tính";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.Width = 65;
               // 
               // Column6
               // 
               this.Column6.DataPropertyName = "SDT";
               this.Column6.HeaderText = "SĐT";
               this.Column6.MinimumWidth = 6;
               this.Column6.Name = "Column6";
               this.Column6.Width = 105;
               // 
               // Column7
               // 
               this.Column7.DataPropertyName = "TongSoPhieuTiem";
               this.Column7.HeaderText = "Tổng số phiếu tiêm";
               this.Column7.MinimumWidth = 6;
               this.Column7.Name = "Column7";
               this.Column7.Width = 115;
               // 
               // btnXuatTTYTa
               // 
               this.btnXuatTTYTa.Location = new System.Drawing.Point(457, 751);
               this.btnXuatTTYTa.Name = "btnXuatTTYTa";
               this.btnXuatTTYTa.Size = new System.Drawing.Size(94, 29);
               this.btnXuatTTYTa.TabIndex = 1;
               this.btnXuatTTYTa.Text = "Xuất excel";
               this.btnXuatTTYTa.Click += new System.EventHandler(this.btnXuatTTYTa_Click);
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.dateFromYTa);
               this.layoutControl1.Controls.Add(this.dateToYTa);
               this.layoutControl1.Location = new System.Drawing.Point(147, 26);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(693, 120);
               this.layoutControl1.TabIndex = 2;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // dateFromYTa
               // 
               this.dateFromYTa.EditValue = null;
               this.dateFromYTa.Location = new System.Drawing.Point(63, 50);
               this.dateFromYTa.Name = "dateFromYTa";
               this.dateFromYTa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateFromYTa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateFromYTa.Size = new System.Drawing.Size(280, 22);
               this.dateFromYTa.StyleController = this.layoutControl1;
               this.dateFromYTa.TabIndex = 4;
               // 
               // dateToYTa
               // 
               this.dateToYTa.EditValue = null;
               this.dateToYTa.Location = new System.Drawing.Point(384, 50);
               this.dateToYTa.Name = "dateToYTa";
               this.dateToYTa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateToYTa.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateToYTa.Size = new System.Drawing.Size(283, 22);
               this.dateToYTa.StyleController = this.layoutControl1;
               this.dateToYTa.TabIndex = 5;
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTKTTYTa});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(693, 120);
               this.Root.TextVisible = false;
               // 
               // layoutTKTTYTa
               // 
               this.layoutTKTTYTa.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
               this.layoutTKTTYTa.Location = new System.Drawing.Point(0, 0);
               this.layoutTKTTYTa.Name = "layoutTKTTYTa";
               this.layoutTKTTYTa.Size = new System.Drawing.Size(671, 100);
               this.layoutTKTTYTa.Text = "Thành tích tiêm vaccine của y tá trong khoảng thời gian";
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.dateFromYTa;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(321, 50);
               this.layoutControlItem1.Text = "Từ";
               this.layoutControlItem1.TextSize = new System.Drawing.Size(23, 17);
               // 
               // layoutControlItem2
               // 
               this.layoutControlItem2.Control = this.dateToYTa;
               this.layoutControlItem2.Location = new System.Drawing.Point(321, 0);
               this.layoutControlItem2.Name = "layoutControlItem2";
               this.layoutControlItem2.Size = new System.Drawing.Size(324, 50);
               this.layoutControlItem2.Text = "đến";
               this.layoutControlItem2.TextSize = new System.Drawing.Size(23, 17);
               // 
               // btnTKYTa
               // 
               this.btnTKYTa.Location = new System.Drawing.Point(867, 81);
               this.btnTKYTa.Name = "btnTKYTa";
               this.btnTKYTa.Size = new System.Drawing.Size(94, 29);
               this.btnTKYTa.TabIndex = 3;
               this.btnTKYTa.Text = "Thống kê";
               this.btnTKYTa.Click += new System.EventHandler(this.btnTKYTa_Click);
               // 
               // searchLookUpTTYTa
               // 
               this.searchLookUpTTYTa.Location = new System.Drawing.Point(146, 12);
               this.searchLookUpTTYTa.Name = "searchLookUpTTYTa";
               this.searchLookUpTTYTa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.searchLookUpTTYTa.Properties.PopupView = this.searchLookUpEdit1View;
               this.searchLookUpTTYTa.Size = new System.Drawing.Size(537, 22);
               this.searchLookUpTTYTa.StyleController = this.layoutControl2;
               this.searchLookUpTTYTa.TabIndex = 4;
               // 
               // searchLookUpEdit1View
               // 
               this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
               this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
               this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
               this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
               // 
               // layoutControl2
               // 
               this.layoutControl2.Controls.Add(this.searchLookUpTTYTa);
               this.layoutControl2.Location = new System.Drawing.Point(1089, 26);
               this.layoutControl2.Name = "layoutControl2";
               this.layoutControl2.Root = this.layoutControlGroup1;
               this.layoutControl2.Size = new System.Drawing.Size(696, 120);
               this.layoutControl2.TabIndex = 5;
               this.layoutControl2.Text = "layoutControl2";
               // 
               // layoutControlGroup1
               // 
               this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.layoutControlGroup1.GroupBordersVisible = false;
               this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.emptySpaceItem1});
               this.layoutControlGroup1.Name = "layoutControlGroup1";
               this.layoutControlGroup1.Size = new System.Drawing.Size(696, 120);
               this.layoutControlGroup1.TextVisible = false;
               // 
               // layoutControlItem3
               // 
               this.layoutControlItem3.Control = this.searchLookUpTTYTa;
               this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem3.Name = "layoutControlItem3";
               this.layoutControlItem3.Size = new System.Drawing.Size(674, 26);
               this.layoutControlItem3.Text = "Thông tin tìm kiếm:";
               this.layoutControlItem3.TextSize = new System.Drawing.Size(119, 17);
               // 
               // emptySpaceItem1
               // 
               this.emptySpaceItem1.AllowHotTrack = false;
               this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
               this.emptySpaceItem1.Name = "emptySpaceItem1";
               this.emptySpaceItem1.Size = new System.Drawing.Size(674, 74);
               this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
               // 
               // btnBieuDoYTa
               // 
               this.btnBieuDoYTa.Location = new System.Drawing.Point(1522, 751);
               this.btnBieuDoYTa.Name = "btnBieuDoYTa";
               this.btnBieuDoYTa.Size = new System.Drawing.Size(94, 29);
               this.btnBieuDoYTa.TabIndex = 7;
               this.btnBieuDoYTa.Text = "Xem biểu đồ";
               this.btnBieuDoYTa.Click += new System.EventHandler(this.btnBieuDoYTa_Click);
               // 
               // labelTTYTa
               // 
               this.labelTTYTa.Location = new System.Drawing.Point(967, 151);
               this.labelTTYTa.Name = "labelTTYTa";
               this.labelTTYTa.Size = new System.Drawing.Size(65, 16);
               this.labelTTYTa.TabIndex = 8;
               this.labelTTYTa.Text = "labelTTYTa";
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(26, 151);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(265, 17);
               this.labelControl1.TabIndex = 9;
               this.labelControl1.Text = "Danh sách thành tích tiêm vaccine của y tá";
               // 
               // chartControlYTa
               // 
               this.chartControlYTa.AppearanceNameSerializable = "Chameleon";
               xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
               xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
               this.chartControlYTa.Diagram = xyDiagram1;
               this.chartControlYTa.Location = new System.Drawing.Point(967, 175);
               this.chartControlYTa.Name = "chartControlYTa";
               this.chartControlYTa.PaletteName = "Blue II";
               series1.ArgumentDataMember = "MaYTa";
               series1.Name = "Số phiếu tiêm";
               series1.ValueDataMembersSerializable = "TongSoPhieuTiem";
               this.chartControlYTa.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
               this.chartControlYTa.SeriesTemplate.ValueDataMembersSerializable = "TongSoPhieuTiem";
               this.chartControlYTa.Size = new System.Drawing.Size(1198, 559);
               this.chartControlYTa.TabIndex = 10;
               // 
               // FormTK_ThanhTichYTa
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.chartControlYTa);
               this.Controls.Add(this.labelControl1);
               this.Controls.Add(this.labelTTYTa);
               this.Controls.Add(this.btnBieuDoYTa);
               this.Controls.Add(this.layoutControl2);
               this.Controls.Add(this.btnTKYTa);
               this.Controls.Add(this.layoutControl1);
               this.Controls.Add(this.btnXuatTTYTa);
               this.Controls.Add(this.dataTKTTYTa);
               this.Name = "FormTK_ThanhTichYTa";
               this.Size = new System.Drawing.Size(2248, 844);
               ((System.ComponentModel.ISupportInitialize)(this.dataTKTTYTa)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dateFromYTa.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToYTa.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTKTTYTa)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTTYTa.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
               this.layoutControl2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControlYTa)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.DataGridView dataTKTTYTa;
          private DevExpress.XtraEditors.SimpleButton btnXuatTTYTa;
          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraEditors.DateEdit dateFromYTa;
          private DevExpress.XtraEditors.DateEdit dateToYTa;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraLayout.LayoutControlGroup layoutTKTTYTa;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
          private DevExpress.XtraEditors.SimpleButton btnTKYTa;
          private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpTTYTa;
          private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
          private DevExpress.XtraLayout.LayoutControl layoutControl2;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
          private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
          private DevExpress.XtraEditors.SimpleButton btnBieuDoYTa;
          private DevExpress.XtraEditors.LabelControl labelTTYTa;
          private DevExpress.XtraEditors.LabelControl labelControl1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
          private DevExpress.XtraCharts.ChartControl chartControlYTa;
     }
}