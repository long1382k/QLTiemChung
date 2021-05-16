
namespace DXApplication2
{
     partial class FormTK_ThanhTichBS
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
               DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView1 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.dateFromBS = new DevExpress.XtraEditors.DateEdit();
               this.dateToBS = new DevExpress.XtraEditors.DateEdit();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutTKTTBS = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
               this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
               this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
               this.dataTKTTBS = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               this.btnTKBS = new DevExpress.XtraEditors.SimpleButton();
               this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
               this.searchLookUpTTBS = new DevExpress.XtraEditors.SearchLookUpEdit();
               this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
               this.labelTTBS = new DevExpress.XtraEditors.LabelControl();
               this.btnBCBS = new DevExpress.XtraEditors.SimpleButton();
               this.btnXuatTKBS = new DevExpress.XtraEditors.SimpleButton();
               this.btnBieuDoTTBS = new DevExpress.XtraEditors.SimpleButton();
               this.chartControlBS = new DevExpress.XtraCharts.ChartControl();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromBS.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromBS.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToBS.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToBS.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTKTTBS)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataTKTTBS)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
               this.layoutControl2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTTBS.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControlBS)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).BeginInit();
               this.SuspendLayout();
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.dateFromBS);
               this.layoutControl1.Controls.Add(this.dateToBS);
               this.layoutControl1.Location = new System.Drawing.Point(128, 23);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1108, 0, 812, 500);
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(805, 108);
               this.layoutControl1.TabIndex = 0;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // dateFromBS
               // 
               this.dateFromBS.EditValue = null;
               this.dateFromBS.Location = new System.Drawing.Point(63, 50);
               this.dateFromBS.Name = "dateFromBS";
               this.dateFromBS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateFromBS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateFromBS.Size = new System.Drawing.Size(331, 22);
               this.dateFromBS.StyleController = this.layoutControl1;
               this.dateFromBS.TabIndex = 4;
               // 
               // dateToBS
               // 
               this.dateToBS.EditValue = null;
               this.dateToBS.Location = new System.Drawing.Point(435, 50);
               this.dateToBS.Name = "dateToBS";
               this.dateToBS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateToBS.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dateToBS.Size = new System.Drawing.Size(344, 22);
               this.dateToBS.StyleController = this.layoutControl1;
               this.dateToBS.TabIndex = 5;
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTKTTBS});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(805, 108);
               this.Root.TextVisible = false;
               // 
               // layoutTKTTBS
               // 
               this.layoutTKTTBS.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem2});
               this.layoutTKTTBS.Location = new System.Drawing.Point(0, 0);
               this.layoutTKTTBS.Name = "layoutTKTTBS";
               this.layoutTKTTBS.Size = new System.Drawing.Size(783, 88);
               this.layoutTKTTBS.Text = "Thành tích kiểm tra sức khỏe của bác sĩ trong khoảng thời gian:";
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.dateFromBS;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(372, 26);
               this.layoutControlItem1.Text = "Từ ";
               this.layoutControlItem1.TextSize = new System.Drawing.Size(23, 17);
               // 
               // layoutControlItem2
               // 
               this.layoutControlItem2.Control = this.dateToBS;
               this.layoutControlItem2.Location = new System.Drawing.Point(372, 0);
               this.layoutControlItem2.Name = "layoutControlItem2";
               this.layoutControlItem2.Size = new System.Drawing.Size(385, 26);
               this.layoutControlItem2.Text = "đến";
               this.layoutControlItem2.TextSize = new System.Drawing.Size(23, 17);
               // 
               // emptySpaceItem1
               // 
               this.emptySpaceItem1.AllowHotTrack = false;
               this.emptySpaceItem1.Location = new System.Drawing.Point(0, 26);
               this.emptySpaceItem1.Name = "emptySpaceItem1";
               this.emptySpaceItem1.Size = new System.Drawing.Size(372, 12);
               this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
               // 
               // emptySpaceItem2
               // 
               this.emptySpaceItem2.AllowHotTrack = false;
               this.emptySpaceItem2.Location = new System.Drawing.Point(372, 26);
               this.emptySpaceItem2.Name = "emptySpaceItem2";
               this.emptySpaceItem2.Size = new System.Drawing.Size(385, 12);
               this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
               // 
               // dataTKTTBS
               // 
               this.dataTKTTBS.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
               this.dataTKTTBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataTKTTBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
               this.dataTKTTBS.Location = new System.Drawing.Point(27, 149);
               this.dataTKTTBS.Name = "dataTKTTBS";
               this.dataTKTTBS.RowHeadersWidth = 51;
               this.dataTKTTBS.RowTemplate.Height = 24;
               this.dataTKTTBS.Size = new System.Drawing.Size(1092, 636);
               this.dataTKTTBS.TabIndex = 1;
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
               this.Column2.DataPropertyName = "MaBS";
               this.Column2.HeaderText = "Mã bác sĩ";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               this.Column2.Width = 95;
               // 
               // Column3
               // 
               this.Column3.DataPropertyName = "HoTenBS";
               this.Column3.HeaderText = "Họ tên bác sĩ";
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
               this.Column4.Width = 115;
               // 
               // Column5
               // 
               this.Column5.DataPropertyName = "GioiTinh";
               this.Column5.HeaderText = "Giới tính";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.Width = 90;
               // 
               // Column6
               // 
               this.Column6.DataPropertyName = "TrinhDo";
               this.Column6.HeaderText = "Trình độ";
               this.Column6.MinimumWidth = 6;
               this.Column6.Name = "Column6";
               this.Column6.Width = 85;
               // 
               // Column7
               // 
               this.Column7.DataPropertyName = "SDT";
               this.Column7.HeaderText = "SĐT";
               this.Column7.MinimumWidth = 6;
               this.Column7.Name = "Column7";
               this.Column7.Width = 115;
               // 
               // Column8
               // 
               this.Column8.DataPropertyName = "TongSoPhieuKTSK";
               this.Column8.HeaderText = "Tổng số phiếu KTSK";
               this.Column8.MinimumWidth = 6;
               this.Column8.Name = "Column8";
               this.Column8.Width = 115;
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(27, 125);
               this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(308, 17);
               this.labelControl1.TabIndex = 2;
               this.labelControl1.Text = "Danh sách thành tích kiểm tra sức khỏe của bác sĩ";
               // 
               // btnTKBS
               // 
               this.btnTKBS.Location = new System.Drawing.Point(941, 68);
               this.btnTKBS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.btnTKBS.Name = "btnTKBS";
               this.btnTKBS.Size = new System.Drawing.Size(118, 36);
               this.btnTKBS.TabIndex = 3;
               this.btnTKBS.Text = "Thống kê";
               this.btnTKBS.Click += new System.EventHandler(this.btnTKBS_Click);
               // 
               // layoutControl2
               // 
               this.layoutControl2.Controls.Add(this.searchLookUpTTBS);
               this.layoutControl2.Location = new System.Drawing.Point(1143, 42);
               this.layoutControl2.Name = "layoutControl2";
               this.layoutControl2.Root = this.layoutControlGroup1;
               this.layoutControl2.Size = new System.Drawing.Size(715, 56);
               this.layoutControl2.TabIndex = 5;
               this.layoutControl2.Text = "layoutControl2";
               // 
               // searchLookUpTTBS
               // 
               this.searchLookUpTTBS.Location = new System.Drawing.Point(146, 12);
               this.searchLookUpTTBS.Name = "searchLookUpTTBS";
               this.searchLookUpTTBS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.searchLookUpTTBS.Properties.PopupView = this.searchLookUpEdit1View;
               this.searchLookUpTTBS.Size = new System.Drawing.Size(556, 22);
               this.searchLookUpTTBS.StyleController = this.layoutControl2;
               this.searchLookUpTTBS.TabIndex = 4;
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
            this.layoutControlItem3});
               this.layoutControlGroup1.Name = "layoutControlGroup1";
               this.layoutControlGroup1.Size = new System.Drawing.Size(715, 56);
               this.layoutControlGroup1.TextVisible = false;
               // 
               // layoutControlItem3
               // 
               this.layoutControlItem3.Control = this.searchLookUpTTBS;
               this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem3.Name = "layoutControlItem3";
               this.layoutControlItem3.Size = new System.Drawing.Size(693, 36);
               this.layoutControlItem3.Text = "Thông tin tìm kiếm:";
               this.layoutControlItem3.TextSize = new System.Drawing.Size(119, 17);
               // 
               // labelTTBS
               // 
               this.labelTTBS.Location = new System.Drawing.Point(1157, 114);
               this.labelTTBS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.labelTTBS.Name = "labelTTBS";
               this.labelTTBS.Size = new System.Drawing.Size(288, 17);
               this.labelTTBS.TabIndex = 9;
               this.labelTTBS.Text = "Hiển thị thành tích kiểm tra sức khỏe của bác sĩ";
               // 
               // btnBCBS
               // 
               this.btnBCBS.Location = new System.Drawing.Point(1670, 1188);
               this.btnBCBS.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
               this.btnBCBS.Name = "btnBCBS";
               this.btnBCBS.Size = new System.Drawing.Size(118, 36);
               this.btnBCBS.TabIndex = 10;
               this.btnBCBS.Text = "Xem báo cáo";
               // 
               // btnXuatTKBS
               // 
               this.btnXuatTKBS.Location = new System.Drawing.Point(553, 801);
               this.btnXuatTKBS.Name = "btnXuatTKBS";
               this.btnXuatTKBS.Size = new System.Drawing.Size(94, 29);
               this.btnXuatTKBS.TabIndex = 11;
               this.btnXuatTKBS.Text = "Xuất excel";
               this.btnXuatTKBS.Click += new System.EventHandler(this.btnXuatTKBS_Click);
               // 
               // btnBieuDoTTBS
               // 
               this.btnBieuDoTTBS.Location = new System.Drawing.Point(1617, 801);
               this.btnBieuDoTTBS.Name = "btnBieuDoTTBS";
               this.btnBieuDoTTBS.Size = new System.Drawing.Size(94, 29);
               this.btnBieuDoTTBS.TabIndex = 12;
               this.btnBieuDoTTBS.Text = "Xem biểu đồ";
               this.btnBieuDoTTBS.Click += new System.EventHandler(this.btnBieuDoTTBS_Click);
               // 
               // chartControlBS
               // 
               this.chartControlBS.AppearanceNameSerializable = "Light";
               this.chartControlBS.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
               xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
               xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
               this.chartControlBS.Diagram = xyDiagram1;
               this.chartControlBS.Legend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
               this.chartControlBS.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.False;
               this.chartControlBS.Legend.MarkerSize = new System.Drawing.Size(20, 15);
               this.chartControlBS.Legend.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
               this.chartControlBS.Location = new System.Drawing.Point(1157, 153);
               this.chartControlBS.Name = "chartControlBS";
               this.chartControlBS.PaletteBaseColorNumber = 1;
               this.chartControlBS.PaletteName = "Blue II";
               series1.ArgumentDataMember = "MaBS";
               series1.Name = "Số phiếu KTSK";
               series1.ValueDataMembersSerializable = "TongSoPhieuKTSK";
               series1.View = sideBySideStackedBarSeriesView1;
               this.chartControlBS.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
               this.chartControlBS.Size = new System.Drawing.Size(1000, 632);
               this.chartControlBS.TabIndex = 13;
               // 
               // FormTK_ThanhTichBS
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.chartControlBS);
               this.Controls.Add(this.btnBieuDoTTBS);
               this.Controls.Add(this.btnXuatTKBS);
               this.Controls.Add(this.btnBCBS);
               this.Controls.Add(this.labelTTBS);
               this.Controls.Add(this.layoutControl2);
               this.Controls.Add(this.btnTKBS);
               this.Controls.Add(this.labelControl1);
               this.Controls.Add(this.dataTKTTBS);
               this.Controls.Add(this.layoutControl1);
               this.Name = "FormTK_ThanhTichBS";
               this.Size = new System.Drawing.Size(2248, 844);
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.dateFromBS.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateFromBS.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToBS.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dateToBS.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTKTTBS)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dataTKTTBS)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
               this.layoutControl2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpTTBS.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.chartControlBS)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraEditors.DateEdit dateFromBS;
          private DevExpress.XtraEditors.DateEdit dateToBS;
          private DevExpress.XtraLayout.LayoutControlGroup layoutTKTTBS;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
          private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
          private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
          private System.Windows.Forms.DataGridView dataTKTTBS;
          private DevExpress.XtraEditors.LabelControl labelControl1;
          private DevExpress.XtraEditors.SimpleButton btnTKBS;
          private DevExpress.XtraLayout.LayoutControl layoutControl2;
          private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpTTBS;
          private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
          private DevExpress.XtraEditors.LabelControl labelTTBS;
          private DevExpress.XtraEditors.SimpleButton btnBCBS;
          private DevExpress.XtraEditors.SimpleButton btnXuatTKBS;
          private DevExpress.XtraEditors.SimpleButton btnBieuDoTTBS;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
          private DevExpress.XtraCharts.ChartControl chartControlBS;
     }
}