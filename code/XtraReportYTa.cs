using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTiemChung.code
{
     public partial class XtraReportYTa : DevExpress.XtraReports.UI.XtraReport
     {
          public XtraReportYTa()
          {
               InitializeComponent();
          }

          private void xrPictureBox1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
          {
               if (xrLabelYTa.Value.ToString() == "Nam")
                    xrPictureYTa.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\background\ytanam1.jpg");
               else
                    xrPictureYTa.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\background\nurse.jpg");
          }
     }
}
