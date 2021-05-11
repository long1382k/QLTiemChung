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

namespace DXApplication2
{
     public partial class FormBacSi : Form
     {
          string flag;
          public FormBacSi()
          {
               InitializeComponent();
               dataBacSi.ReadOnly = true;
          }

          private void FormBacSi_Load(object sender, EventArgs e)
          {
               layoutThongTinBS.Enabled = false;
               btnLuuBS.Enabled = false;
               getData();
          }
         
          public void getData()
          {
               KetNoi kn = new KetNoi();
               dataBacSi.DataSource = kn.LoadData("HienThiDSBacSi");
               for (int i = 0; i < dataBacSi.Rows.Count - 1; i++)
               {
                    dataBacSi.Rows[i].Cells[0].Value = i + 1;
               }
               kn.OpenConnection();
          }
          public void getDataTimKiem()
          {
               KetNoi kn = new KetNoi();
               dataBacSi.DataSource = kn.LoadData("TimKiemBS");
               for (int i = 0; i < dataBacSi.Rows.Count - 1; i++)
               {
                    dataBacSi.Rows[i].Cells[0].Value = i + 1;
               }
               kn.OpenConnection();
          }
          public void TaoMaBSMoi()
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadData("HienThiDSBacSi");
               int count = 0;
               count = dt.Rows.Count;
               string s1 = "";
               int s2 = 0;
               s1 = Convert.ToString(dt.Rows[count - 1][0].ToString());
               s2 = Convert.ToInt32((s1.Remove(0, 2)));
               if (s2 + 1 < 10)
                    txtMaBS.Text = "BS00" + (s2 + 1).ToString();
               else if (s2 + 1 < 100)
                    txtMaBS.Text = "BS0" + (s2 + 1).ToString();
               else if (s2 + 1 < 1000)
                    txtMaBS.Text = "BS" + (s2 + 1).ToString();
               else
                    txtMaBS.Text = "";
          }
          public void khoa()

          {
               btnThemBS.Enabled = true;
               btnSuaBS.Enabled = true;
               btnXoaBS.Enabled = true;
               btnLuuBS.Enabled = false;
               btnHuyBS.Enabled = false;
               layoutThongTinBS.Enabled = false;
          }



          public void mo()
          {
               btnThemBS.Enabled = false;
               btnSuaBS.Enabled = false;
               btnXoaBS.Enabled = false;
               btnLuuBS.Enabled = true;
               btnHuyBS.Enabled = true;
               layoutThongTinBS.Enabled = true;
               txtMaBS.Focus();
          }
          public bool check()
          {
               if (string.IsNullOrWhiteSpace(txtMaBS.Text))
               {
                    MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaBS.Focus();
                    return false;
               }

               if (string.IsNullOrEmpty(txtHoTenBS.Text))
               {
                    MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTenBS.Focus();
                    return false;
               }

               if (string.IsNullOrEmpty(dateBS.Text))
               {
                    MessageBox.Show("Bạn chưa nhập ngày tháng năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateBS.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtGTBS.Text))
               {
                    MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGTBS.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtTrinhDo.Text))
               {
                    MessageBox.Show("Bạn chưa nhập trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTrinhDo.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtSDTBS.Text))
               {
                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSDTBS.Focus();
                    return false;
               }
               return true;
          }
          public void clear()
          {
               txtMaBS.Text = "";
               txtHoTenBS.Text = "";
               txtGTBS.Text = "";
               dateBS.Text = "";
               dateBS1.Text = "";
               txtTrinhDo.Text = "";
               txtSDTBS.Text = "";
          }
          private void btnThemBS_Click(object sender, EventArgs e)
          {
               mo();
               flag = "add";
               clear();
               TaoMaBSMoi();
          }

          private void btnSuaBS_Click(object sender, EventArgs e)
          {
               mo();
               txtMaBS.ReadOnly = true;
               flag = "edit";
          }

          private void btnXoaBS_Click(object sender, EventArgs e)
          {
               mo();
               flag = "delete";
               layoutThongTinBS.Enabled = false;
          }

          private void btnLuuBS_Click(object sender, EventArgs e)
          {
               if (check() == false)
               {
                    XtraMessageBox.Show("Bạn điền thông tin chưa đầy đủ");
                    return;
               }
               KetNoi kn = new KetNoi();
               if (flag == "add")
               {
                    if (kn.LoadDataHaveID("BacSiBietMa", "@MaBS", txtMaBS.Text).Rows.Count == 1)
                         XtraMessageBox.Show("Mã bác sĩ đã có trong danh sách");
                    else
                    {
                         kn.OpenConnection();
                         kn.BacSi("ThemBS", txtMaBS.Text, txtHoTenBS.Text, dateBS.Text, txtGTBS.Text, txtTrinhDo.Text, txtSDTBS.Text);
                    }
               }
               if (flag == "edit")
               {
                    if (kn.LoadDataHaveID("BacSiBietMa", "@MaBS", txtMaBS.Text).Rows.Count == 0)
                         XtraMessageBox.Show("Không tìm thấy mã bác sĩ để sửa ");
                    else
                    {
                         kn.OpenConnection();
                         kn.BacSi("SuaBS", txtMaBS.Text, txtHoTenBS.Text, dateBS.Text, txtGTBS.Text, txtTrinhDo.Text, txtSDTBS.Text);
                    }
               }
               if (flag == "delete")
               {
                    if (kn.LoadDataHaveID("BacSiBietMa", "@MaBS", txtMaBS.Text).Rows.Count == 0)
                         XtraMessageBox.Show("Không tìm thấy mã bác sĩ để xóa ");
                    else
                    {
                         kn.OpenConnection();
                         kn.Xoa("XoaBS", "@MaBS", txtMaBS.Text);
                         clear();
                    }
               }
               getData();
          }

          private void dataBacSi_MouseClick(object sender, MouseEventArgs e)
          {
               
                    int index = dataBacSi.CurrentRow.Index;
                    txtMaBS.Text = dataBacSi.Rows[index].Cells[1].Value.ToString();
                    txtHoTenBS.Text = dataBacSi.Rows[index].Cells[2].Value.ToString();
                    dateBS.Text = dataBacSi.Rows[index].Cells[4].Value.ToString();
                    txtGTBS.Text = dataBacSi.Rows[index].Cells[6].Value.ToString();
                    txtTrinhDo.Text = dataBacSi.Rows[index].Cells[5].Value.ToString();
                    txtSDTBS.Text = dataBacSi.Rows[index].Cells[3].Value.ToString();
          }

          private void btnBatDauTKBS_Click(object sender, EventArgs e)
          {
               mo();
               clear();
          }

          private void btnTimKiemBS_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               kn.OpenConnection();
               dataBacSi.DataSource = kn.LoadDataSearch("TimKiemBS", txtMaBS.Text, txtHoTenBS.Text, dateBS.Text, dateBS1.Text, txtGTBS.Text, txtTrinhDo.Text, txtSDTBS.Text);
               for (int i = 0; i < dataBacSi.Rows.Count - 1; i++)
               {
                    dataBacSi.Rows[i].Cells[0].Value = i + 1;
               }
          }

          private void btnHuyBS_Click(object sender, EventArgs e)
          {
               khoa();
          }

          private void btnXuatExcelBN_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadData("XuatDanhSachBS");
               if (dt.Rows.Count == 0)
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               else
               {
                    kn.OpenConnection();
                    kn.LoadDataSet("XuatDanhSachBS").WriteXml(@"E:\Danh sách bác sĩ.xls");
                    XtraMessageBox.Show("Xuất thành công");
               }
          }

          private void btnXuatBCBS_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataHaveID("XuatBS","@MaBS",txtMaBS.Text);
               if (dt.Rows.Count == 0)
               {
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               }
               //else
               //{
               //     XtraReportBS reportBS = new XtraReportBS();
               //     reportBS.DataSource = dt;
               //     reportBS.ShowPreviewDialog();
               //}
          }
     }
}
