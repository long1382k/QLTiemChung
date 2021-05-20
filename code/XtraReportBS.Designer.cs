
namespace QLTiemChung.code
{
     partial class XtraReportBS
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

          #region Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
               DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReportBS));
               this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
               this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
               this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
               this.Detail = new DevExpress.XtraReports.UI.DetailBand();
               this.xrPictureBoxBS = new DevExpress.XtraReports.UI.XRPictureBox();
               this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabelGTBS = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
               this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
               this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
               ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
               // 
               // TopMargin
               // 
               this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
               this.TopMargin.HeightF = 165F;
               this.TopMargin.Name = "TopMargin";
               // 
               // xrLabel4
               // 
               this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
               this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(284.1667F, 94.66667F);
               this.xrLabel4.Multiline = true;
               this.xrLabel4.Name = "xrLabel4";
               this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel4.SizeF = new System.Drawing.SizeF(355.8333F, 23F);
               this.xrLabel4.StylePriority.UseFont = false;
               this.xrLabel4.StylePriority.UseTextAlignment = false;
               this.xrLabel4.Text = "Độc lập - Tự do - Hạnh phúc";
               this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
               // 
               // xrLabel3
               // 
               this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
               this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(284.1667F, 71.66666F);
               this.xrLabel3.Multiline = true;
               this.xrLabel3.Name = "xrLabel3";
               this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel3.SizeF = new System.Drawing.SizeF(355.8333F, 23F);
               this.xrLabel3.StylePriority.UseFont = false;
               this.xrLabel3.StylePriority.UseTextAlignment = false;
               this.xrLabel3.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM";
               this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
               // 
               // xrLabel2
               // 
               this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
               this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 94.66667F);
               this.xrLabel2.Multiline = true;
               this.xrLabel2.Name = "xrLabel2";
               this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel2.SizeF = new System.Drawing.SizeF(229.1667F, 23F);
               this.xrLabel2.StylePriority.UseFont = false;
               this.xrLabel2.StylePriority.UseTextAlignment = false;
               this.xrLabel2.Text = "PHÒNG TỔ CHỨC NHÂN SỰ";
               this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
               // 
               // xrLabel1
               // 
               this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 71.66666F);
               this.xrLabel1.Multiline = true;
               this.xrLabel1.Name = "xrLabel1";
               this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel1.SizeF = new System.Drawing.SizeF(229.1667F, 23F);
               this.xrLabel1.StylePriority.UseFont = false;
               this.xrLabel1.StylePriority.UseTextAlignment = false;
               this.xrLabel1.Text = "TRUNG TÂM TIÊM CHỦNG";
               this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
               // 
               // BottomMargin
               // 
               this.BottomMargin.HeightF = 136.6664F;
               this.BottomMargin.Name = "BottomMargin";
               // 
               // Detail
               // 
               this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBoxBS,
            this.xrLabel6,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLabel9,
            this.xrLabel10,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabelGTBS,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel5});
               this.Detail.HeightF = 543.3336F;
               this.Detail.Name = "Detail";
               // 
               // xrPictureBoxBS
               // 
               this.xrPictureBoxBS.LocationFloat = new DevExpress.Utils.PointFloat(51.66667F, 165.8334F);
               this.xrPictureBoxBS.Name = "xrPictureBoxBS";
               this.xrPictureBoxBS.SizeF = new System.Drawing.SizeF(168.33F, 203.33F);
               this.xrPictureBoxBS.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPictureBoxBS_BeforePrint_1);
               // 
               // xrLabel6
               // 
               this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(304.1668F, 134.1667F);
               this.xrLabel6.Multiline = true;
               this.xrLabel6.Name = "xrLabel6";
               this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
               this.xrLabel6.StylePriority.UseFont = false;
               this.xrLabel6.Text = "Mã bác sĩ:";
               // 
               // xrLabel7
               // 
               this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MaBS]")});
               this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(404.1668F, 134.1667F);
               this.xrLabel7.Multiline = true;
               this.xrLabel7.Name = "xrLabel7";
               this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel7.SizeF = new System.Drawing.SizeF(239.1666F, 23F);
               this.xrLabel7.StylePriority.UseFont = false;
               this.xrLabel7.Text = "xrLabel7";
               // 
               // xrLabel8
               // 
               this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(304.1667F, 185F);
               this.xrLabel8.Multiline = true;
               this.xrLabel8.Name = "xrLabel8";
               this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 23F);
               this.xrLabel8.StylePriority.UseFont = false;
               this.xrLabel8.Text = "Họ tên bác sĩ:";
               // 
               // xrLabel9
               // 
               this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HoTenBS]")});
               this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(404.1668F, 185F);
               this.xrLabel9.Multiline = true;
               this.xrLabel9.Name = "xrLabel9";
               this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel9.SizeF = new System.Drawing.SizeF(239.1666F, 23F);
               this.xrLabel9.StylePriority.UseFont = false;
               this.xrLabel9.Text = "xrLabel9";
               // 
               // xrLabel10
               // 
               this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(304.1668F, 232.5001F);
               this.xrLabel10.Multiline = true;
               this.xrLabel10.Name = "xrLabel10";
               this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel10.SizeF = new System.Drawing.SizeF(100F, 23F);
               this.xrLabel10.StylePriority.UseFont = false;
               this.xrLabel10.Text = "Ngày sinh:";
               // 
               // xrLabel11
               // 
               this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "GetDay([NgaySinh])+\'/\'+GetMonth([NgaySinh])+\'/\'+GetYear([NgaySinh])\n")});
               this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(404.1667F, 232.5001F);
               this.xrLabel11.Multiline = true;
               this.xrLabel11.Name = "xrLabel11";
               this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel11.SizeF = new System.Drawing.SizeF(239.1667F, 22.99999F);
               this.xrLabel11.StylePriority.UseFont = false;
               this.xrLabel11.Text = "xrLabel11";
               // 
               // xrLabel12
               // 
               this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(304.1668F, 288.6668F);
               this.xrLabel12.Multiline = true;
               this.xrLabel12.Name = "xrLabel12";
               this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel12.SizeF = new System.Drawing.SizeF(100F, 23F);
               this.xrLabel12.StylePriority.UseFont = false;
               this.xrLabel12.Text = "Giới tính:";
               // 
               // xrLabelGTBS
               // 
               this.xrLabelGTBS.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[GioiTinh]")});
               this.xrLabelGTBS.LocationFloat = new DevExpress.Utils.PointFloat(404.1667F, 288.6668F);
               this.xrLabelGTBS.Multiline = true;
               this.xrLabelGTBS.Name = "xrLabelGTBS";
               this.xrLabelGTBS.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabelGTBS.SizeF = new System.Drawing.SizeF(239.1667F, 23F);
               this.xrLabelGTBS.Text = "xrLabelGT";
               // 
               // xrLabel14
               // 
               this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(304.1668F, 333.3334F);
               this.xrLabel14.Multiline = true;
               this.xrLabel14.Name = "xrLabel14";
               this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel14.SizeF = new System.Drawing.SizeF(100F, 23F);
               this.xrLabel14.StylePriority.UseFont = false;
               this.xrLabel14.Text = "Trình độ:";
               // 
               // xrLabel15
               // 
               this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TrinhDo]")});
               this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(404.1667F, 333.3334F);
               this.xrLabel15.Multiline = true;
               this.xrLabel15.Name = "xrLabel15";
               this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel15.SizeF = new System.Drawing.SizeF(239.1667F, 23F);
               this.xrLabel15.StylePriority.UseFont = false;
               this.xrLabel15.Text = "xrLabel15";
               // 
               // xrLabel16
               // 
               this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(304.1668F, 380.8334F);
               this.xrLabel16.Multiline = true;
               this.xrLabel16.Name = "xrLabel16";
               this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel16.SizeF = new System.Drawing.SizeF(100F, 23F);
               this.xrLabel16.StylePriority.UseFont = false;
               this.xrLabel16.Text = "Số điện thoại:";
               // 
               // xrLabel17
               // 
               this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SDT]")});
               this.xrLabel17.Font = new System.Drawing.Font("Times New Roman", 12F);
               this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(404.1667F, 380.8334F);
               this.xrLabel17.Multiline = true;
               this.xrLabel17.Name = "xrLabel17";
               this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel17.SizeF = new System.Drawing.SizeF(239.1667F, 23F);
               this.xrLabel17.StylePriority.UseFont = false;
               this.xrLabel17.Text = "xrLabel17";
               // 
               // xrLabel5
               // 
               this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
               this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(199.1667F, 10F);
               this.xrLabel5.Multiline = true;
               this.xrLabel5.Name = "xrLabel5";
               this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
               this.xrLabel5.SizeF = new System.Drawing.SizeF(249.1667F, 48F);
               this.xrLabel5.StylePriority.UseFont = false;
               this.xrLabel5.StylePriority.UseTextAlignment = false;
               this.xrLabel5.Text = "HỒ SƠ BÁC SĨ";
               this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
               // 
               // sqlDataSource1
               // 
               this.sqlDataSource1.ConnectionName = "localhost_TiemChung_Connection 3";
               this.sqlDataSource1.Name = "sqlDataSource1";
               storedProcQuery1.Name = "XuatBS";
               queryParameter1.Name = "@MaBS";
               queryParameter1.Type = typeof(string);
               storedProcQuery1.Parameters.Add(queryParameter1);
               storedProcQuery1.StoredProcName = "XuatBS";
               this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
               this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
               // 
               // XtraReportBS
               // 
               this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail});
               this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
               this.DataMember = "XuatBS";
               this.DataSource = this.sqlDataSource1;
               this.Font = new System.Drawing.Font("Arial", 9.75F);
               this.Margins = new System.Drawing.Printing.Margins(100, 100, 165, 137);
               this.Version = "20.2";
               ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

          }

          #endregion

          private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
          private DevExpress.XtraReports.UI.XRLabel xrLabel3;
          private DevExpress.XtraReports.UI.XRLabel xrLabel2;
          private DevExpress.XtraReports.UI.XRLabel xrLabel1;
          private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
          private DevExpress.XtraReports.UI.DetailBand Detail;
          private DevExpress.XtraReports.UI.XRLabel xrLabel5;
          private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
          private DevExpress.XtraReports.UI.XRLabel xrLabel4;
          private DevExpress.XtraReports.UI.XRPictureBox xrPictureBoxBS;
          private DevExpress.XtraReports.UI.XRLabel xrLabel6;
          private DevExpress.XtraReports.UI.XRLabel xrLabel7;
          private DevExpress.XtraReports.UI.XRLabel xrLabel8;
          private DevExpress.XtraReports.UI.XRLabel xrLabel9;
          private DevExpress.XtraReports.UI.XRLabel xrLabel10;
          private DevExpress.XtraReports.UI.XRLabel xrLabel11;
          private DevExpress.XtraReports.UI.XRLabel xrLabel12;
          private DevExpress.XtraReports.UI.XRLabel xrLabelGTBS;
          private DevExpress.XtraReports.UI.XRLabel xrLabel14;
          private DevExpress.XtraReports.UI.XRLabel xrLabel15;
          private DevExpress.XtraReports.UI.XRLabel xrLabel16;
          private DevExpress.XtraReports.UI.XRLabel xrLabel17;
     }
}
