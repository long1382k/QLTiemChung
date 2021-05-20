using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLTiemChung.code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXApplication2
{
     public partial class FormTK_ThanhTichNV : UserControl
     {
          private static FormTK_ThanhTichNV _instance;
          public static FormTK_ThanhTichNV Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new FormTK_ThanhTichNV();
                    return _instance;
               }
          }
          public FormTK_ThanhTichNV()
          {
               InitializeComponent();
               dataTKTTNV.ReadOnly = true;
          }
          KetNoi kn = new KetNoi();
          string ma;
          //Xoa cac du lieu cu hien thi tren DataSource, xoa lan luot tung hang
          public void clear()
          {
               for (int i = 0; i < dataTKTTNV.Rows.Count - 1; i++)
               {
                    dataTKTTNV.Rows.RemoveAt(i);
                    i--;
                    while (dataTKTTNV.Rows.Count == 0)
                         continue;
               }
          }
          private void btnTKNV_Click(object sender, EventArgs e)
          {
               //kiem tra xem ngay nhap vao co hop le ko?
               //neu ngayFrom va ngayTo > today thi ko hop le
               if (kn.checkDateWithToday(dateFromNV.Text) == 1 || kn.checkDateWithToday(dateToNV.Text) == 1)
               {
                    XtraMessageBox.Show("Ngày nhập vào không hợp lệ vì vượt quá ngày hiện tại");
                    return;
               }
               else if (kn.checkDateWithDate(dateFromNV.Text, dateToNV.Text) == 1)
               {
                    XtraMessageBox.Show("Ngày nhập vào không hợp lệ vì mốc thời gian trước lớn hơn mốc thời gian sau");
                    return;
               }
               dataTKTTNV.DataSource = kn.LoadDataTK("ThanhTichNV", dateFromNV.Text, dateToNV.Text);
               for (int i = 0; i < dataTKTTNV.Rows.Count - 1; i++)
               {
                    dataTKTTNV.Rows[i].Cells[0].Value = i + 1;
               }
               kn.OpenConnection();
               DataTable dt = kn.LoadDataTK("ThanhTichNV", dateFromNV.Text, dateToNV.Text);
               dt.Columns["MaNV"].ColumnName = "Mã bác sĩ";
               dt.Columns["HoTenNV"].ColumnName = "Họ tên bác sĩ";
               dt.Columns["NgaySinh"].ColumnName = "Ngày sinh";
               dt.Columns["GioiTinh"].ColumnName = "Giới tính";
               dt.Columns["SDT"].ColumnName = "SĐT";
               dt.Columns["TongSoHoaDon"].ColumnName = "Tổng số hóa đơn";
               searchLookUpTTNV.Properties.DataSource = dt;
          }

          private void btnXuatTKNV_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataTK("ThanhTichNV", dateFromNV.Text, dateToNV.Text);
               if (dt.Rows.Count == 0)
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               else
               {
                    kn.OpenConnection();
                    kn.LoadDataSetTK("ThanhTichNV", dateFromNV.Text, dateToNV.Text).WriteXml(@"E:\Danh sách thành tích nhân viên.xls");
                    XtraMessageBox.Show("Xuất thành công");
               }
          }

          private void btnBieuDoNV_Click(object sender, EventArgs e)
          {
               try
               {
                    KetNoi kn = new KetNoi();
                    chartControlNV.DataSource = kn.LoadDataTK("ThanhTichNV", dateFromNV.Text, dateToNV.Text);
                    chartControlNV.Show();
                    chartControlTLNV.DataSource = kn.LoadDataTK("TiLeThanhTichNV", dateFromNV.Text, dateToNV.Text);
                    chartControlTLNV.Show();
                    labelNV.Text = "Hiển thị biểu đồ thành tích lập hóa đơn của nhân viên từ " + dateFromNV.Text + " đến " + dateToNV.Text;
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
               }
          }

          private void btnBCTTNV_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataBCTT("XemThanhTich1NV", "@MaNV", ma, dateFromNV.Text, dateToNV.Text);
               if (dt.Rows.Count == 0)
               {
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               }
               else
               {
                    XtraReportTTNV reportTTNV = new XtraReportTTNV();
                    reportTTNV.DataSource = dt;
                    reportTTNV.ShowPreviewDialog();
               }
          }

          private void dataTKTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int index = dataTKTTNV.CurrentRow.Index;
               ma = dataTKTTNV.Rows[index].Cells[1].Value.ToString();
          }
     }
}