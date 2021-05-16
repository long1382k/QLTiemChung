using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication2
{
     public partial class FormTK_ThanhTichBS : UserControl
     {
          private static FormTK_ThanhTichBS _instance;
          public static FormTK_ThanhTichBS Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new FormTK_ThanhTichBS();
                    return _instance;
               }
          }
          public FormTK_ThanhTichBS()
          {
               InitializeComponent();
               dataTKTTBS.ReadOnly = true;
          }
          KetNoi kn = new KetNoi();
          //Xoa cac du lieu cu hien thi tren DataSource, xoa lan luot tung hang
          public void clear()
          {
               for (int i = 0; i < dataTKTTBS.Rows.Count - 1; i++)
               {
                    dataTKTTBS.Rows.RemoveAt(i);
                    i--;
                    while (dataTKTTBS.Rows.Count == 0)
                         continue;
               }
          }

          private void btnTKBS_Click(object sender, EventArgs e)
          {
               //kiem tra xem ngay nhap vao co hop le ko?
               //neu ngayFrom va ngayTo > today thi ko hop le
               if (kn.checkDateWithToday(dateFromBS.Text) == 1 || kn.checkDateWithToday(dateToBS.Text) == 1)
               {
                    XtraMessageBox.Show("Ngày nhập vào không hợp lệ vì vượt quá ngày hiện tại");
                    return;
               }
               else if (kn.checkDateWithDate(dateFromBS.Text, dateToBS.Text) == 1)
               {
                    XtraMessageBox.Show("Ngày nhập vào không hợp lệ vì mốc thời gian trước lớn hơn mốc thời gian sau");
                    return;
               }
               dataTKTTBS.DataSource = kn.LoadDataTK("ThanhTichBS", dateFromBS.Text, dateToBS.Text);
               for (int i = 0; i < dataTKTTBS.Rows.Count - 1; i++)
               {
                    dataTKTTBS.Rows[i].Cells[0].Value = i + 1;
               }
               kn.OpenConnection();
               DataTable dt = kn.LoadDataTK("ThanhTichBS", dateFromBS.Text, dateToBS.Text);
               dt.Columns["MaBS"].ColumnName = "Mã bác sĩ";
               dt.Columns["HoTenBS"].ColumnName = "Họ tên bác sĩ";
               dt.Columns["NgaySinh"].ColumnName = "Ngày sinh";
               dt.Columns["GioiTinh"].ColumnName = "Giới tính";
               dt.Columns["TrinhDo"].ColumnName = "Trình độ";
               dt.Columns["SDT"].ColumnName = "SĐT";
               dt.Columns["TongSoPhieuKTSK"].ColumnName = "Tổng số phiếu KTSK";
               searchLookUpTTBS.Properties.DataSource = dt;
               if (dt == null) XtraMessageBox.Show("Không có bác sĩ nào lập được phiếu kiểm tra sức khỏe từ " + dateFromBS.Text + " đến " + dateToBS.Text);
          }

          private void btnBieuDoTTBS_Click(object sender, EventArgs e)
          {
               try
               {
                    KetNoi kn = new KetNoi();
                    chartControlBS.DataSource = kn.LoadDataTK("ThanhTichBS", dateFromBS.Text, dateToBS.Text);
                    chartControlBS.Show();
                    labelTTBS.Text = "Hiển thị biểu đồ thành tích kiểm tra sức khỏe của bác sĩ từ " + dateFromBS.Text + " đến " + dateToBS.Text;                      //hiển thị năm trên label
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
               }
               
          }

          private void btnXuatTKBS_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataTK("ThanhTichBS", dateFromBS.Text, dateToBS.Text);
               if (dt.Rows.Count == 0)
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               else
               {
                    kn.OpenConnection();
                    kn.LoadDataSetTK("ThanhTichBS", dateFromBS.Text, dateToBS.Text).WriteXml(@"E:\Danh sách thành tích bác sĩ.xls");
                    XtraMessageBox.Show("Xuất thành công");
               }
          }

     }
}