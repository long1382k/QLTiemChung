
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
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
               this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
               this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
               this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
               this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
               this.layoutControl1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
               this.SuspendLayout();
               // 
               // dataGridView1
               // 
               this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
               this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
               this.dataGridView1.Location = new System.Drawing.Point(60, 61);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowHeadersWidth = 51;
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.Size = new System.Drawing.Size(927, 927);
               this.dataGridView1.TabIndex = 0;
               // 
               // Column1
               // 
               this.Column1.HeaderText = "STT";
               this.Column1.MinimumWidth = 6;
               this.Column1.Name = "Column1";
               this.Column1.Width = 75;
               // 
               // Column2
               // 
               this.Column2.HeaderText = "Mã y tá";
               this.Column2.MinimumWidth = 6;
               this.Column2.Name = "Column2";
               this.Column2.Width = 105;
               // 
               // Column3
               // 
               this.Column3.HeaderText = "Họ tên y tá";
               this.Column3.MinimumWidth = 6;
               this.Column3.Name = "Column3";
               this.Column3.Width = 185;
               // 
               // Column4
               // 
               this.Column4.HeaderText = "Ngày sinh";
               this.Column4.MinimumWidth = 6;
               this.Column4.Name = "Column4";
               this.Column4.Width = 105;
               // 
               // Column5
               // 
               this.Column5.HeaderText = "Giới tính";
               this.Column5.MinimumWidth = 6;
               this.Column5.Name = "Column5";
               this.Column5.Width = 95;
               // 
               // Column6
               // 
               this.Column6.HeaderText = "SĐT";
               this.Column6.MinimumWidth = 6;
               this.Column6.Name = "Column6";
               this.Column6.Width = 87;
               // 
               // layoutControl1
               // 
               this.layoutControl1.Controls.Add(this.textEdit1);
               this.layoutControl1.Location = new System.Drawing.Point(1113, 597);
               this.layoutControl1.Name = "layoutControl1";
               this.layoutControl1.Root = this.Root;
               this.layoutControl1.Size = new System.Drawing.Size(778, 245);
               this.layoutControl1.TabIndex = 1;
               this.layoutControl1.Text = "layoutControl1";
               // 
               // Root
               // 
               this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
               this.Root.GroupBordersVisible = false;
               this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
               this.Root.Name = "Root";
               this.Root.Size = new System.Drawing.Size(778, 245);
               // 
               // textEdit1
               // 
               this.textEdit1.Location = new System.Drawing.Point(144, 50);
               this.textEdit1.Name = "textEdit1";
               this.textEdit1.Size = new System.Drawing.Size(610, 22);
               this.textEdit1.StyleController = this.layoutControl1;
               this.textEdit1.TabIndex = 4;
               // 
               // layoutControlItem1
               // 
               this.layoutControlItem1.Control = this.textEdit1;
               this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlItem1.Name = "layoutControlItem1";
               this.layoutControlItem1.Size = new System.Drawing.Size(734, 175);
               this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 16);
               // 
               // layoutControlGroup1
               // 
               this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
               this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
               this.layoutControlGroup1.Name = "layoutControlGroup1";
               this.layoutControlGroup1.Size = new System.Drawing.Size(758, 225);
               // 
               // FormYTa
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1902, 1033);
               this.Controls.Add(this.layoutControl1);
               this.Controls.Add(this.dataGridView1);
               this.Name = "FormYTa";
               this.Text = "FormYTa";
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
               this.layoutControl1.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.DataGridView dataGridView1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
          private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
          private DevExpress.XtraLayout.LayoutControl layoutControl1;
          private DevExpress.XtraLayout.LayoutControlGroup Root;
          private DevExpress.XtraEditors.TextEdit textEdit1;
          private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
          private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
     }
}