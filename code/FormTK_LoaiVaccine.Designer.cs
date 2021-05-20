
namespace DXApplication2
{
    partial class FormTK_LoaiVaccine
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.dtGVLoaiVaccine = new System.Windows.Forms.DataGridView();
            this.chartControlLoaiVaccine = new DevExpress.XtraCharts.ChartControl();
            this.btnXemBieuDo = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoaiVaccine = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpLoaiVaccine = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiemChungDataSet = new QLTiemChung.TiemChungDataSet();
            this.procTKLoaiVaccineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proc_TKLoaiVaccineTableAdapter = new QLTiemChung.TiemChungDataSetTableAdapters.proc_TKLoaiVaccineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLoaiVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlLoaiVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpLoaiVaccine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemChungDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procTKLoaiVaccineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVLoaiVaccine
            // 
            this.dtGVLoaiVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVLoaiVaccine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtGVLoaiVaccine.Location = new System.Drawing.Point(221, 96);
            this.dtGVLoaiVaccine.Name = "dtGVLoaiVaccine";
            this.dtGVLoaiVaccine.RowHeadersWidth = 51;
            this.dtGVLoaiVaccine.RowTemplate.Height = 24;
            this.dtGVLoaiVaccine.Size = new System.Drawing.Size(620, 524);
            this.dtGVLoaiVaccine.TabIndex = 0;
            // 
            // chartControlLoaiVaccine
            // 
            this.chartControlLoaiVaccine.AppearanceNameSerializable = "Chameleon";
            this.chartControlLoaiVaccine.DataAdapter = this.proc_TKLoaiVaccineTableAdapter;
            this.chartControlLoaiVaccine.DataSource = this.procTKLoaiVaccineBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControlLoaiVaccine.Diagram = xyDiagram1;
            this.chartControlLoaiVaccine.Location = new System.Drawing.Point(1120, 108);
            this.chartControlLoaiVaccine.Name = "chartControlLoaiVaccine";
            series1.ArgumentDataMember = "MaLoaiVaccine";
            series1.Name = "Tổng số lượng";
            series1.ValueDataMembersSerializable = "TongSoLuong";
            this.chartControlLoaiVaccine.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControlLoaiVaccine.SeriesTemplate.ArgumentDataMember = "MaLoaiVaccine";
            this.chartControlLoaiVaccine.SeriesTemplate.ValueDataMembersSerializable = "TongSoLuong";
            this.chartControlLoaiVaccine.Size = new System.Drawing.Size(815, 537);
            this.chartControlLoaiVaccine.TabIndex = 1;
            // 
            // btnXemBieuDo
            // 
            this.btnXemBieuDo.Location = new System.Drawing.Point(1487, 698);
            this.btnXemBieuDo.Name = "btnXemBieuDo";
            this.btnXemBieuDo.Size = new System.Drawing.Size(113, 41);
            this.btnXemBieuDo.TabIndex = 2;
            this.btnXemBieuDo.Text = "Xem biểu đồ";
            this.btnXemBieuDo.Click += new System.EventHandler(this.btnXemBieuDo_Click);
            // 
            // btnLoaiVaccine
            // 
            this.btnLoaiVaccine.Location = new System.Drawing.Point(428, 28);
            this.btnLoaiVaccine.Name = "btnLoaiVaccine";
            this.btnLoaiVaccine.Size = new System.Drawing.Size(113, 41);
            this.btnLoaiVaccine.TabIndex = 2;
            this.btnLoaiVaccine.Text = "Hiển thị danh sách";
            this.btnLoaiVaccine.Click += new System.EventHandler(this.btnLoaiVaccine_Click);
            // 
            // searchLookUpLoaiVaccine
            // 
            this.searchLookUpLoaiVaccine.Location = new System.Drawing.Point(1432, 28);
            this.searchLookUpLoaiVaccine.Name = "searchLookUpLoaiVaccine";
            this.searchLookUpLoaiVaccine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpLoaiVaccine.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpLoaiVaccine.Size = new System.Drawing.Size(297, 22);
            this.searchLookUpLoaiVaccine.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaLoaiVaccine";
            this.Column2.HeaderText = "Mã loại vaccine";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenLoaiVaccine";
            this.Column3.HeaderText = "Tên loại vaccine";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TongSoLuong";
            this.Column4.HeaderText = "Tổng số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // tiemChungDataSet
            // 
            this.tiemChungDataSet.DataSetName = "TiemChungDataSet";
            this.tiemChungDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // procTKLoaiVaccineBindingSource
            // 
            this.procTKLoaiVaccineBindingSource.DataMember = "proc_TKLoaiVaccine";
            this.procTKLoaiVaccineBindingSource.DataSource = this.tiemChungDataSet;
            // 
            // proc_TKLoaiVaccineTableAdapter
            // 
            this.proc_TKLoaiVaccineTableAdapter.ClearBeforeFill = true;
            // 
            // FormTK_LoaiVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchLookUpLoaiVaccine);
            this.Controls.Add(this.btnLoaiVaccine);
            this.Controls.Add(this.btnXemBieuDo);
            this.Controls.Add(this.chartControlLoaiVaccine);
            this.Controls.Add(this.dtGVLoaiVaccine);
            this.Name = "FormTK_LoaiVaccine";
            this.Size = new System.Drawing.Size(2248, 844);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLoaiVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControlLoaiVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpLoaiVaccine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiemChungDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procTKLoaiVaccineBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVLoaiVaccine;
        private DevExpress.XtraCharts.ChartControl chartControlLoaiVaccine;
        private DevExpress.XtraEditors.SimpleButton btnXemBieuDo;
        private DevExpress.XtraEditors.SimpleButton btnLoaiVaccine;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpLoaiVaccine;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private QLTiemChung.TiemChungDataSetTableAdapters.proc_TKLoaiVaccineTableAdapter proc_TKLoaiVaccineTableAdapter;
        private System.Windows.Forms.BindingSource procTKLoaiVaccineBindingSource;
        private QLTiemChung.TiemChungDataSet tiemChungDataSet;
    }
}
