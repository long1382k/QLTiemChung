using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using QLTiemChung.code;
namespace DXApplication2
{
     public partial class FormTK_ThanhTichYTa : UserControl
     {
          private static FormTK_ThanhTichYTa _instance;
          public static FormTK_ThanhTichYTa Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new FormTK_ThanhTichYTa();
                    return _instance;
               }
          }
          public FormTK_ThanhTichYTa()
          {
               InitializeComponent();
               dataTKTTYTa.ReadOnly = true;
          }
          KetNoi kn = new KetNoi();
          //Xoa cac du lieu cu hien thi tren DataSource, xoa lan luot tung hang
          public void clear()
          {
               for (int i = 0; i < dataTKTTYTa.Rows.Count - 1; i++)
               {
                    dataTKTTYTa.Rows.RemoveAt(i);
                    i--;
                    while (dataTKTTYTa.Rows.Count == 0)
                         continue;
               }
          }
          private void btnTKYTa_Click(object sender, EventArgs e)
          {
               if (kn.checkDateWithToday(dateFromYTa.Text) == 1 || kn.checkDateWithToday(dateToYTa.Text) == 1)
               {
                    XtraMessageBox.Show("Ngày nhập vào không hợp lệ vì vượt quá ngày hiện tại");
                    return;
               }
               else if (kn.checkDateWithDate(dateFromYTa.Text, dateToYTa.Text) == 1)
               {
                    XtraMessageBox.Show("Ngày nhập vào không hợp lệ vì mốc thời gian trước lớn hơn mốc thời gian sau");
                    return;
               }
               dataTKTTYTa.DataSource = kn.LoadDataTK("ThanhTichYTa", dateFromYTa.Text, dateToYTa.Text);
               for (int i = 0; i < dataTKTTYTa.Rows.Count - 1; i++)
               {
                    dataTKTTYTa.Rows[i].Cells[0].Value = i + 1;
               }
               kn.OpenConnection();
               DataTable dt = kn.LoadDataTK("ThanhTichYTa", dateFromYTa.Text, dateToYTa.Text);
               dt.Columns["MaYTa"].ColumnName = "Mã y tá";
               dt.Columns["HoTenYTa"].ColumnName = "Họ tên y tá";
               dt.Columns["NgaySinh"].ColumnName = "Ngày sinh";
               dt.Columns["GioiTinh"].ColumnName = "Giới tính";
               dt.Columns["SDT"].ColumnName = "SĐT";
               dt.Columns["TongSoPhieuTiem"].ColumnName = "Tổng số phiếu tiêm";
               searchLookUpTTYTa.Properties.DataSource = dt;
          }

          private void btnXuatTTYTa_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataTK("ThanhTichYTa", dateFromYTa.Text, dateToYTa.Text);
               if (dt.Rows.Count == 0)
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               else
               {
                    kn.OpenConnection();
                    kn.LoadDataSetTK("ThanhTichYTa", dateFromYTa.Text, dateToYTa.Text).WriteXml(@"E:\Danh sách thành tích y tá.xls");
                    XtraMessageBox.Show("Xuất thành công");
               }
          }

          private void btnBieuDoYTa_Click(object sender, EventArgs e)
          {
               try
               {
                    KetNoi kn = new KetNoi();
                    chartControlYTa.DataSource = kn.LoadDataTK("ThanhTichYta", dateFromYTa.Text, dateToYTa.Text);
                    chartControlYTa.Show();
                    labelTTYTa.Text = "Hiển thị biểu đồ thành tích lập hóa đơn của nhân viên từ " + dateFromYTa.Text + " đến " + dateToYTa.Text;
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
               }
          }
    }
}
          
