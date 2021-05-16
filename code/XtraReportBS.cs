using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTiemChung.code
{
     public partial class XtraReportBS : DevExpress.XtraReports.UI.XtraReport
     {
          public XtraReportBS()
          {
               InitializeComponent();
          }
          private void xrPictureBoxBS_BeforePrint_1(object sender, System.Drawing.Printing.PrintEventArgs e)
          {
               if (xrLabelGTBS.Value.ToString() == "Nam")
                    xrPictureBoxBS.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\background\bacsi1.png");
               else
                    xrPictureBoxBS.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\background\41.png");
          }
     }
}
