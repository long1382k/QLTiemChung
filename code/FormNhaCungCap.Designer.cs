
namespace DXApplication2
{
     partial class Form1
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
               this.dgv_NCC = new System.Windows.Forms.DataGridView();
               this.MaNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.TenNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
               this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
               this.btn_remove = new DevExpress.XtraEditors.SimpleButton();
               this.btn_add = new DevExpress.XtraEditors.SimpleButton();
               this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
               this.btn_save = new DevExpress.XtraEditors.SimpleButton();
               this.layout_thongtinNCC = new DevExpress.XtraLayout.LayoutControl();
               this.txtTenNCC = new DevExpress.XtraEditors.TextEdit();
               this.txtMaNCC = new DevExpress.XtraEditors.TextEdit();
               this.txtDiaChi = new DevExpress.XtraEditors.ButtonEdit();
               this.txtSDT = new DevExpress.XtraEditors.ButtonEdit();
               this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
               this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
               this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutdgv_ncc = new DevExpress.XtraLayout.LayoutControl();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
               this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
               this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
               ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
               this.layoutControl2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layout_thongtinNCC)).BeginInit();
               this.layout_thongtinNCC.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutdgv_ncc)).BeginInit();
               this.layoutdgv_ncc.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
               this.SuspendLayout();
               // 
               // dgv_NCC
               // 
               this.dgv_NCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
               this.dgv_NCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgv_NCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhaCungCap,
            this.TenNhaCungCap,
            this.DiaChi,
            this.SDT});
               this.dgv_NCC.Location = new System.Drawing.Point(12, 12);
               this.dgv_NCC.Name = "dgv_NCC";
               this.dgv_NCC.Size = new System.Drawing.Size(450, 446);
               this.dgv_NCC.TabIndex = 0;
               this.dgv_NCC.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_NCC_CellMouseClick);
               // 
               // MaNhaCungCap
               // 
               this.MaNhaCungCap.DataPropertyName = "MaNhaCungCap";
               this.MaNhaCungCap.HeaderText = "Mã";
               this.MaNhaCungCap.Name = "MaNhaCungCap";
               // 
               // TenNhaCungCap
               // 
               this.TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
               this.TenNhaCungCap.HeaderText = "Tên NCC";
               this.TenNhaCungCap.Name = "TenNhaCungCap";
               // 
               // DiaChi
               // 
               this.DiaChi.DataPropertyName = "DiaChi";
               this.DiaChi.HeaderText = "Địa chỉ";
               this.DiaChi.Name = "DiaChi";
               // 
               // SDT
               // 
               this.SDT.DataPropertyName = "SDT";
               this.SDT.HeaderText = "SĐT";
               this.SDT.Name = "SDT";
               // 
               // btn_edit
               // 
               this.btn_edit.Location = new System.Drawing.Point(112, 12);
               this.btn_edit.Name = "btn_edit";
               this.btn_edit.Size = new System.Drawing.Size(95, 22);
               this.btn_edit.StyleController = this.layoutControl2;
               this.btn_edit.TabIndex = 1;
               this.btn_edit.Text = "Sửa";
               this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
               // 
               // layoutControl2
               // 
               this.layoutControl2.Controls.Add(this.btn_remove);
               this.layoutControl2.Controls.Add(this.btn_edit);
               this.layoutControl2.Controls.Add(this.btn_add);
               this.layoutControl2.Location = new System.Drawing.Point(774, 169);
               this.layoutControl2.Name = "layoutControl2";
               this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 0, 650, 400);
               this.layoutControl2.Root = this.layoutControlGroup3;
               this.layoutControl2.Size = new System.Drawing.Size(319, 99);
               this.layoutControl2.TabIndex = 10;
               this.layoutControl2.Text = "layoutControl2";
               // 
               // btn_remove
               // 
               this.btn_remove.Location = new System.Drawing.Point(211, 12);
               this.btn_remove.Name = "btn_remove";
               this.btn_remove.Size = new System.Drawing.Size(96, 22);
               this.btn_remove.StyleController = this.layoutControl2;
               this.btn_remove.TabIndex = 1;
               this.btn_remove.Text = "Xóa";
               this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
               // 
               // btn_add
               // 
               this.btn_add.Location = new System.Drawing.Point(12, 12);
               this.btn_add.Name = "btn_add";
               this.btn_add.Size = new System.Drawing.Size(96, 22);
               this.btn_add.StyleController = this.layoutControl2;
               this.btn_add.TabIndex = 1;
               this.btn_add.Text = "Thêm";
               this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
               // 
               // layoutControlGroup3
               // 
               this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.layoutControlGroup3.GroupBordersVisible = false;
               this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem8});
               this.layoutControlGroup3.Name = "Root";
               this.layoutControlGroup3.Size = new System.Drawing.Size(319, 99);
               this.layoutControlGroup3.TextVisible = false;
               // 
               // layoutControlItem7
               // 
               this.layoutControlItem7.Control = this.btn_edit;
               this.layoutControlItem7.Location = new System.Drawing.Point(100, 0);
               this.layoutControlItem7.Name = "layoutControlItem7";
               this.layoutControlItem7.Size = new System.Drawing.Size(99, 79);
               this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
               this.layoutControlItem7.TextVisible = false;
               // 
               // layoutControlItem6
               // 
               this.layoutControlItem6.Control = this.btn_add;
               this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem6.Name = "layoutControlItem6";
               this.layoutControlItem6.Size = new System.Drawing.Size(100, 79);
               this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
               this.layoutControlItem6.TextVisible = false;
               // 
               // layoutControlItem8
               // 
               this.layoutControlItem8.Control = this.btn_remove;
               this.layoutControlItem8.Location = new System.Drawing.Point(199, 0);
               this.layoutControlItem8.Name = "layoutControlItem8";
               this.layoutControlItem8.Size = new System.Drawing.Size(100, 79);
               this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
               this.layoutControlItem8.TextVisible = false;
               // 
               // btn_save
               // 
               this.btn_save.Location = new System.Drawing.Point(161, 173);
               this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.btn_save.Name = "btn_save";
               this.btn_save.Size = new System.Drawing.Size(89, 33);
               this.btn_save.StyleController = this.layout_thongtinNCC;
               this.btn_save.TabIndex = 7;
               this.btn_save.Text = "Lưu";
               this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
               // 
               // layout_thongtinNCC
               // 
               this.layout_thongtinNCC.Controls.Add(this.txtTenNCC);
               this.layout_thongtinNCC.Controls.Add(this.txtMaNCC);
               this.layout_thongtinNCC.Controls.Add(this.txtDiaChi);
               this.layout_thongtinNCC.Controls.Add(this.txtSDT);
               this.layout_thongtinNCC.Controls.Add(this.btn_save);
               this.layout_thongtinNCC.Location = new System.Drawing.Point(732, 295);
               this.layout_thongtinNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.layout_thongtinNCC.Name = "layout_thongtinNCC";
               this.layout_thongtinNCC.Root = this.layoutControlGroup1;
               this.layout_thongtinNCC.Size = new System.Drawing.Size(423, 240);
               this.layout_thongtinNCC.TabIndex = 8;
               this.layout_thongtinNCC.Text = "Thông tin nhà cung cấp";
               // 
               // txtTenNCC
               // 
               this.txtTenNCC.Location = new System.Drawing.Point(125, 69);
               this.txtTenNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.txtTenNCC.Name = "txtTenNCC";
               this.txtTenNCC.Size = new System.Drawing.Size(274, 20);
               this.txtTenNCC.StyleController = this.layout_thongtinNCC;
               this.txtTenNCC.TabIndex = 5;
               // 
               // txtMaNCC
               // 
               this.txtMaNCC.Location = new System.Drawing.Point(125, 45);
               this.txtMaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.txtMaNCC.Name = "txtMaNCC";
               this.txtMaNCC.Size = new System.Drawing.Size(274, 20);
               this.txtMaNCC.StyleController = this.layout_thongtinNCC;
               this.txtMaNCC.TabIndex = 4;
               // 
               // txtDiaChi
               // 
               this.txtDiaChi.Location = new System.Drawing.Point(125, 93);
               this.txtDiaChi.Name = "txtDiaChi";
               this.txtDiaChi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
               this.txtDiaChi.Size = new System.Drawing.Size(274, 20);
               this.txtDiaChi.StyleController = this.layout_thongtinNCC;
               this.txtDiaChi.TabIndex = 6;
               // 
               // txtSDT
               // 
               this.txtSDT.Location = new System.Drawing.Point(125, 117);
               this.txtSDT.Name = "txtSDT";
               this.txtSDT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
               this.txtSDT.Size = new System.Drawing.Size(274, 20);
               this.txtSDT.StyleController = this.layout_thongtinNCC;
               this.txtSDT.TabIndex = 7;
               // 
               // layoutControlGroup1
               // 
               this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.layoutControlGroup1.GroupBordersVisible = false;
               this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlGroup2});
               this.layoutControlGroup1.Name = "Root";
               this.layoutControlGroup1.Size = new System.Drawing.Size(423, 240);
               this.layoutControlGroup1.TextVisible = false;
               // 
               // emptySpaceItem2
               // 
               this.emptySpaceItem2.AllowHotTrack = false;
               this.emptySpaceItem2.Location = new System.Drawing.Point(0, 141);
               this.emptySpaceItem2.Name = "emptySpaceItem2";
               this.emptySpaceItem2.Size = new System.Drawing.Size(403, 79);
               this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
               // 
               // layoutControlGroup2
               // 
               this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem4});
               this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
               this.layoutControlGroup2.Name = "layoutControlGroup2";
               this.layoutControlGroup2.Size = new System.Drawing.Size(403, 141);
               this.layoutControlGroup2.Text = "Thông tin nhà cung cấp:";
               // 
               // layoutControlItem3
               // 
               this.layoutControlItem3.Control = this.txtTenNCC;
               this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
               this.layoutControlItem3.Name = "layoutControlItem3";
               this.layoutControlItem3.Size = new System.Drawing.Size(379, 24);
               this.layoutControlItem3.Text = "Tên nhà cung cấp:";
               this.layoutControlItem3.TextSize = new System.Drawing.Size(89, 13);
               // 
               // layoutControlItem2
               // 
               this.layoutControlItem2.Control = this.txtMaNCC;
               this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem2.Name = "layoutControlItem2";
               this.layoutControlItem2.Size = new System.Drawing.Size(379, 24);
               this.layoutControlItem2.Text = "Mã nhà cung cấp:";
               this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.txtDiaChi;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(379, 24);
               this.layoutControlItem1.Text = "Địa chỉ:";
               this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
               // 
               // layoutControlItem4
               // 
               this.layoutControlItem4.Control = this.txtSDT;
               this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
               this.layoutControlItem4.Name = "layoutControlItem4";
               this.layoutControlItem4.Size = new System.Drawing.Size(379, 24);
               this.layoutControlItem4.Text = "Số điện thoại";
               this.layoutControlItem4.TextSize = new System.Drawing.Size(89, 13);
               // 
               // layoutdgv_ncc
               // 
               this.layoutdgv_ncc.Controls.Add(this.dgv_NCC);
               this.layoutdgv_ncc.Location = new System.Drawing.Point(81, 157);
               this.layoutdgv_ncc.Name = "layoutdgv_ncc";
               this.layoutdgv_ncc.Root = this.Root;
               this.layoutdgv_ncc.Size = new System.Drawing.Size(474, 470);
               this.layoutdgv_ncc.TabIndex = 9;
               this.layoutdgv_ncc.Text = "layoutControl1";
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(474, 470);
               this.Root.TextVisible = false;
               // 
               // layoutControlItem5
               // 
               this.layoutControlItem5.Control = this.dgv_NCC;
               this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem5.Name = "layoutControlItem5";
               this.layoutControlItem5.Size = new System.Drawing.Size(454, 450);
               this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
               this.layoutControlItem5.TextVisible = false;
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.searchLookUpEdit1);
               this.layoutControl1.Location = new System.Drawing.Point(110, 68);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.Root = this.layoutControlGroup4;
               this.layoutControl1.Size = new System.Drawing.Size(358, 83);
               this.layoutControl1.TabIndex = 11;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // searchLookUpEdit1
               // 
               this.searchLookUpEdit1.Location = new System.Drawing.Point(68, 12);
               this.searchLookUpEdit1.Name = "searchLookUpEdit1";
               this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.searchLookUpEdit1.Properties.PopupView = this.searchLookUpEdit1View;
               this.searchLookUpEdit1.Size = new System.Drawing.Size(278, 20);
               this.searchLookUpEdit1.StyleController = this.layoutControl1;
               this.searchLookUpEdit1.TabIndex = 5;
               this.searchLookUpEdit1.EditValueChanged += new System.EventHandler(this.searchLookUpEdit1_EditValueChanged);
               // 
               // searchLookUpEdit1View
               // 
               this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
               this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
               this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
               this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
               // 
               // layoutControlGroup4
               // 
               this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.layoutControlGroup4.GroupBordersVisible = false;
               this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem10});
               this.layoutControlGroup4.Name = "layoutControlGroup4";
               this.layoutControlGroup4.Size = new System.Drawing.Size(358, 83);
               this.layoutControlGroup4.TextVisible = false;
               // 
               // layoutControlItem10
               // 
               this.layoutControlItem10.Control = this.searchLookUpEdit1;
               this.layoutControlItem10.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem10.Name = "layoutControlItem10";
               this.layoutControlItem10.Size = new System.Drawing.Size(338, 63);
               this.layoutControlItem10.Text = "Tìm kiếm:";
               this.layoutControlItem10.TextSize = new System.Drawing.Size(44, 13);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1438, 731);
               this.Controls.Add(this.layoutControl1);
               this.Controls.Add(this.layoutControl2);
               this.Controls.Add(this.layoutdgv_ncc);
               this.Controls.Add(this.layout_thongtinNCC);
               this.Name = "Form1";
               this.Text = "FormNCC";
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               this.Load += new System.EventHandler(this.Form1_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgv_NCC)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
               this.layoutControl2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layout_thongtinNCC)).EndInit();
               this.layout_thongtinNCC.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.txtTenNCC.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtMaNCC.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutdgv_ncc)).EndInit();
               this.layoutdgv_ncc.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView dgv_NCC;
          private System.Windows.Forms.DataGridViewTextBoxColumn MaNhaCungCap;
          private System.Windows.Forms.DataGridViewTextBoxColumn TenNhaCungCap;
          private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
          private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
          private DevExpress.XtraEditors.SimpleButton btn_edit;
          private DevExpress.XtraEditors.SimpleButton btn_add;
          private DevExpress.XtraEditors.SimpleButton btn_remove;
          private DevExpress.XtraEditors.SimpleButton btn_save;
          private DevExpress.XtraLayout.LayoutControl layout_thongtinNCC;
          private DevExpress.XtraEditors.TextEdit txtTenNCC;
          private DevExpress.XtraEditors.TextEdit txtMaNCC;
          private DevExpress.XtraEditors.ButtonEdit txtDiaChi;
          private DevExpress.XtraEditors.ButtonEdit txtSDT;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
          private DevExpress.XtraLayout.LayoutControl layoutdgv_ncc;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
          private DevExpress.XtraLayout.LayoutControl layoutControl2;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
          private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
          private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
          private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
     }
}

