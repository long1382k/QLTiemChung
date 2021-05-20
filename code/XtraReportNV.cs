using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTiemChung.code
{
     public partial class XtraReportNV : DevExpress.XtraReports.UI.XtraReport
     {
          public XtraReportNV()
          {
               InitializeComponent();
          }
          
private void xrPictureBoxNV_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
          {
               if (txtNSNV.Value.ToString() == "Nam")
                   xrPictureBoxNV.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\background\n1.jpg");
               else
                   xrPictureBoxNV.Image = Image.FromFile(@"C:\Users\ASUS\Desktop\background\nu3.jpg");
          }
     }
}
