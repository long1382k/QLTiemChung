
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
            this.btnXoaVaccine = new DevExpress.XtraEditors.SimpleButton();
            this.dtGVVaccine = new System.Windows.Forms.DataGridView();
            this.MaVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dtGVLoaiVaccine = new System.Windows.Forms.DataGridView();
            this.MaLoaiVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiVaccine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVVaccine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLoaiVaccine)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnXoaVaccine);
            this.groupControl1.Controls.Add(this.dtGVVaccine);
            this.groupControl1.Location = new System.Drawing.Point(714, 137);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(871, 660);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Thông tin vaccine";
            // 
            // btnXoaVaccine
            // 
            this.btnXoaVaccine.Location = new System.Drawing.Point(373, 367);
            this.btnXoaVaccine.Name = "btnXoaVaccine";
            this.btnXoaVaccine.Size = new System.Drawing.Size(94, 29);
            this.btnXoaVaccine.TabIndex = 2;
            this.btnXoaVaccine.Text = "Tiêu huỷ";
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
            this.HSD});
            this.dtGVVaccine.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtGVVaccine.Location = new System.Drawing.Point(2, 28);
            this.dtGVVaccine.Name = "dtGVVaccine";
            this.dtGVVaccine.RowHeadersWidth = 51;
            this.dtGVVaccine.RowTemplate.Height = 24;
            this.dtGVVaccine.Size = new System.Drawing.Size(867, 304);
            this.dtGVVaccine.TabIndex = 1;
            // 
            // MaVaccine
            // 
            this.MaVaccine.DataPropertyName = "MaVaccine";
            this.MaVaccine.HeaderText = "Mã Vaccine";
            this.MaVaccine.MinimumWidth = 6;
            this.MaVaccine.Name = "MaVaccine";
            this.MaVaccine.Width = 125;
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
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 125;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.MinimumWidth = 6;
            this.NSX.Name = "NSX";
            this.NSX.Width = 125;
            // 
            // HSD
            // 
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "HSD";
            this.HSD.MinimumWidth = 6;
            this.HSD.Name = "HSD";
            this.HSD.Width = 125;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtGVLoaiVaccine);
            this.groupControl2.Location = new System.Drawing.Point(133, 125);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(467, 353);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Thông tin loại vaccine";
            // 
            // dtGVLoaiVaccine
            // 
            this.dtGVLoaiVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVLoaiVaccine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiVaccine,
            this.TenLoaiVaccine});
            this.dtGVLoaiVaccine.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtGVLoaiVaccine.Location = new System.Drawing.Point(2, 28);
            this.dtGVLoaiVaccine.Name = "dtGVLoaiVaccine";
            this.dtGVLoaiVaccine.RowHeadersWidth = 51;
            this.dtGVLoaiVaccine.RowTemplate.Height = 24;
            this.dtGVLoaiVaccine.Size = new System.Drawing.Size(463, 285);
            this.dtGVLoaiVaccine.TabIndex = 0;
            this.dtGVLoaiVaccine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVLoaiVaccine_CellClick);
            // 
            // MaLoaiVaccine
            // 
            this.MaLoaiVaccine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaLoaiVaccine.DataPropertyName = "MaLoaiVaccine";
            this.MaLoaiVaccine.HeaderText = "Mã loại vaccine";
            this.MaLoaiVaccine.MinimumWidth = 6;
            this.MaLoaiVaccine.Name = "MaLoaiVaccine";
            this.MaLoaiVaccine.Width = 117;
            // 
            // TenLoaiVaccine
            // 
            this.TenLoaiVaccine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoaiVaccine.DataPropertyName = "TenLoaiVaccine";
            this.TenLoaiVaccine.HeaderText = "Tên loại vaccine";
            this.TenLoaiVaccine.MinimumWidth = 6;
            this.TenLoaiVaccine.Name = "TenLoaiVaccine";
            // 
            // FormVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormVaccine";
            this.Size = new System.Drawing.Size(2248, 844);
            this.Load += new System.EventHandler(this.FormVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVVaccine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVLoaiVaccine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaVaccine;
        private System.Windows.Forms.DataGridView dtGVVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dtGVLoaiVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiVaccine;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiVaccine;
    }
}
