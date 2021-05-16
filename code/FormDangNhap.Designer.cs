
namespace QLTiemChung.code
{
     partial class XtraFormDN
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
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
               this.layoutTaiKhoan = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutTTTK = new DevExpress.XtraLayout.LayoutControlGroup();
               this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
               this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
               this.btnDN = new DevExpress.XtraEditors.SimpleButton();
               this.check = new DevExpress.XtraEditors.CheckEdit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTaiKhoan)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTTTK)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).BeginInit();
               this.SuspendLayout();
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.textEdit1);
               this.layoutControl1.Controls.Add(this.textEdit2);
               this.layoutControl1.Location = new System.Drawing.Point(79, 32);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(460, 123);
               this.layoutControl1.TabIndex = 0;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTTTK});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(460, 123);
               this.Root.TextVisible = false;
               // 
               // textEdit1
               // 
               this.textEdit1.Location = new System.Drawing.Point(134, 50);
               this.textEdit1.Name = "textEdit1";
               this.textEdit1.Size = new System.Drawing.Size(302, 22);
               this.textEdit1.StyleController = this.layoutControl1;
               this.textEdit1.TabIndex = 4;
               // 
               // layoutTaiKhoan
               // 
               this.layoutTaiKhoan.Control = this.textEdit1;
               this.layoutTaiKhoan.Location = new System.Drawing.Point(0, 0);
               this.layoutTaiKhoan.Name = "layoutTaiKhoan";
               this.layoutTaiKhoan.Size = new System.Drawing.Size(416, 26);
               this.layoutTaiKhoan.Text = "Tên đăng nhập:";
               this.layoutTaiKhoan.TextSize = new System.Drawing.Size(98, 17);
               // 
               // layoutTTTK
               // 
               this.layoutTTTK.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutTaiKhoan,
            this.layoutControlItem2});
               this.layoutTTTK.Location = new System.Drawing.Point(0, 0);
               this.layoutTTTK.Name = "layoutTTTK";
               this.layoutTTTK.Size = new System.Drawing.Size(440, 103);
               this.layoutTTTK.Text = "Thông tin tài khoản";
               // 
               // textEdit2
               // 
               this.textEdit2.Location = new System.Drawing.Point(134, 76);
               this.textEdit2.Name = "textEdit2";
               this.textEdit2.Size = new System.Drawing.Size(302, 22);
               this.textEdit2.StyleController = this.layoutControl1;
               this.textEdit2.TabIndex = 5;
               // 
               // layoutControlItem2
               // 
               this.layoutControlItem2.Control = this.textEdit2;
               this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
               this.layoutControlItem2.Name = "layoutControlItem2";
               this.layoutControlItem2.Size = new System.Drawing.Size(416, 27);
               this.layoutControlItem2.Text = "Mật khẩu:";
               this.layoutControlItem2.TextSize = new System.Drawing.Size(98, 17);
               // 
               // btnDN
               // 
               this.btnDN.Location = new System.Drawing.Point(432, 167);
               this.btnDN.Name = "btnDN";
               this.btnDN.Size = new System.Drawing.Size(94, 29);
               this.btnDN.TabIndex = 1;
               this.btnDN.Text = "Đăng nhập";
               // 
               // check
               // 
               this.check.Location = new System.Drawing.Point(91, 171);
               this.check.Name = "check";
               this.check.Properties.Caption = "Hiển thị mật khẩu";
               this.check.Size = new System.Drawing.Size(141, 24);
               this.check.TabIndex = 2;
               // 
               // XtraFormDN
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(632, 268);
               this.Controls.Add(this.check);
               this.Controls.Add(this.btnDN);
               this.Controls.Add(this.layoutControl1);
               this.Name = "XtraFormDN";
               this.Text = "Thông tin đăng nhập";
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTaiKhoan)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutTTTK)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.check.Properties)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraEditors.TextEdit textEdit1;
          private DevExpress.XtraEditors.TextEdit textEdit2;
          private DevExpress.XtraLayout.LayoutControlGroup layoutTTTK;
          private DevExpress.XtraLayout.LayoutControlItem layoutTaiKhoan;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
          private DevExpress.XtraEditors.SimpleButton btnDN;
          private DevExpress.XtraEditors.CheckEdit check;
     }
}