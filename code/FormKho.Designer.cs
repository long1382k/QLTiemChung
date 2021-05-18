
namespace DXApplication2
{
    partial class FormKho
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
            this.dtGVKho = new System.Windows.Forms.DataGridView();
            this.MaKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKho = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaDiemKho = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnXoaKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKho = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyKho = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtGVLoaiVacineTrongKho = new System.Windows.Forms.DataGridView();
            this.TenLoaiVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiemKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLoaiVacineTrongKho)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGVKho
            // 
            this.dtGVKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKho,
            this.TenKho,
            this.DiaDiem});
            this.dtGVKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtGVKho.Location = new System.Drawing.Point(2, 28);
            this.dtGVKho.Name = "dtGVKho";
            this.dtGVKho.RowHeadersWidth = 51;
            this.dtGVKho.RowTemplate.Height = 24;
            this.dtGVKho.Size = new System.Drawing.Size(567, 238);
            this.dtGVKho.TabIndex = 0;
            this.dtGVKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVKho_CellClick);
            // 
            // MaKho
            // 
            this.MaKho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKho.DataPropertyName = "MaKho";
            this.MaKho.HeaderText = "Mã kho";
            this.MaKho.MinimumWidth = 6;
            this.MaKho.Name = "MaKho";
            this.MaKho.Width = 81;
            // 
            // TenKho
            // 
            this.TenKho.DataPropertyName = "TenKho";
            this.TenKho.HeaderText = "Tên kho";
            this.TenKho.MinimumWidth = 6;
            this.TenKho.Name = "TenKho";
            this.TenKho.Width = 125;
            // 
            // DiaDiem
            // 
            this.DiaDiem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.txtMaKho);
            this.dataLayoutControl1.Controls.Add(this.txtTenKho);
            this.dataLayoutControl1.Controls.Add(this.txtDiaDiemKho);
            this.dataLayoutControl1.Location = new System.Drawing.Point(93, 370);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(744, 215, 812, 500);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(380, 135);
            this.dataLayoutControl1.TabIndex = 1;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // txtMaKho
            // 
            this.txtMaKho.Location = new System.Drawing.Point(76, 12);
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(292, 22);
            this.txtMaKho.StyleController = this.dataLayoutControl1;
            this.txtMaKho.TabIndex = 4;
            // 
            // txtTenKho
            // 
            this.txtTenKho.Location = new System.Drawing.Point(76, 38);
            this.txtTenKho.Name = "txtTenKho";
            this.txtTenKho.Size = new System.Drawing.Size(292, 22);
            this.txtTenKho.StyleController = this.dataLayoutControl1;
            this.txtTenKho.TabIndex = 5;
            // 
            // txtDiaDiemKho
            // 
            this.txtDiaDiemKho.Location = new System.Drawing.Point(76, 64);
            this.txtDiaDiemKho.Name = "txtDiaDiemKho";
            this.txtDiaDiemKho.Size = new System.Drawing.Size(292, 22);
            this.txtDiaDiemKho.StyleController = this.dataLayoutControl1;
            this.txtDiaDiemKho.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(380, 135);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtMaKho;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(360, 26);
            this.layoutControlItem1.Text = "Mã kho";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDiaDiemKho;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.Size = new System.Drawing.Size(360, 63);
            this.layoutControlItem3.Text = "Địa điểm";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 17);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtTenKho;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(360, 26);
            this.layoutControlItem2.Text = "Tên kho";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 16);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHuyKho);
            this.groupControl1.Controls.Add(this.btnXoaKho);
            this.groupControl1.Controls.Add(this.btnSuaKho);
            this.groupControl1.Controls.Add(this.btnLuuKho);
            this.groupControl1.Controls.Add(this.btnThemKho);
            this.groupControl1.Controls.Add(this.dataLayoutControl1);
            this.groupControl1.Controls.Add(this.dtGVKho);
            this.groupControl1.Location = new System.Drawing.Point(294, 138);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(571, 613);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin kho";
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.Location = new System.Drawing.Point(383, 307);
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.Size = new System.Drawing.Size(78, 36);
            this.btnXoaKho.TabIndex = 2;
            this.btnXoaKho.Text = "Xoá";
            this.btnXoaKho.Click += new System.EventHandler(this.btnXoaKho_Click);
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.Location = new System.Drawing.Point(244, 307);
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.Size = new System.Drawing.Size(78, 36);
            this.btnSuaKho.TabIndex = 2;
            this.btnSuaKho.Text = "Sửa";
            this.btnSuaKho.Click += new System.EventHandler(this.btnSuaKho_Click);
            // 
            // btnLuuKho
            // 
            this.btnLuuKho.Location = new System.Drawing.Point(104, 529);
            this.btnLuuKho.Name = "btnLuuKho";
            this.btnLuuKho.Size = new System.Drawing.Size(78, 36);
            this.btnLuuKho.TabIndex = 2;
            this.btnLuuKho.Text = "Lưu";
            this.btnLuuKho.Click += new System.EventHandler(this.btnLuuKho_Click);
            // 
            // btnThemKho
            // 
            this.btnThemKho.Location = new System.Drawing.Point(104, 307);
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.Size = new System.Drawing.Size(78, 36);
            this.btnThemKho.TabIndex = 2;
            this.btnThemKho.Text = "Thêm";
            this.btnThemKho.Click += new System.EventHandler(this.btnThemKho_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(656, 77);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(209, 22);
            this.searchLookUpEdit1.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // btnHuyKho
            // 
            this.btnHuyKho.Location = new System.Drawing.Point(244, 529);
            this.btnHuyKho.Name = "btnHuyKho";
            this.btnHuyKho.Size = new System.Drawing.Size(78, 36);
            this.btnHuyKho.TabIndex = 3;
            this.btnHuyKho.Text = "Huỷ";
            this.btnHuyKho.Click += new System.EventHandler(this.btnHuyKho_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtGVLoaiVacineTrongKho);
            this.groupControl2.Location = new System.Drawing.Point(1120, 138);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(575, 266);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Loại vaccine trong kho";
            // 
            // dtGVLoaiVacineTrongKho
            // 
            this.dtGVLoaiVacineTrongKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVLoaiVacineTrongKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLoaiVaccine});
            this.dtGVLoaiVacineTrongKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGVLoaiVacineTrongKho.Location = new System.Drawing.Point(2, 28);
            this.dtGVLoaiVacineTrongKho.Name = "dtGVLoaiVacineTrongKho";
            this.dtGVLoaiVacineTrongKho.RowHeadersWidth = 51;
            this.dtGVLoaiVacineTrongKho.RowTemplate.Height = 24;
            this.dtGVLoaiVacineTrongKho.Size = new System.Drawing.Size(571, 236);
            this.dtGVLoaiVacineTrongKho.TabIndex = 0;
            // 
            // TenLoaiVaccine
            // 
            this.TenLoaiVaccine.DataPropertyName = "TenLoaiVaccine";
            this.TenLoaiVaccine.FillWeight = 200F;
            this.TenLoaiVaccine.HeaderText = "Tên loại vaccine";
            this.TenLoaiVaccine.MinimumWidth = 6;
            this.TenLoaiVaccine.Name = "TenLoaiVaccine";
            this.TenLoaiVaccine.Width = 200;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormKho";
            this.Size = new System.Drawing.Size(2248, 844);
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaDiemKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLoaiVacineTrongKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGVKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtTenKho;
        private DevExpress.XtraEditors.TextEdit txtDiaDiemKho;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaKho;
        private DevExpress.XtraEditors.SimpleButton btnSuaKho;
        private DevExpress.XtraEditors.SimpleButton btnLuuKho;
        private DevExpress.XtraEditors.SimpleButton btnThemKho;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnHuyKho;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dtGVLoaiVacineTrongKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiVaccine;
    }
}
