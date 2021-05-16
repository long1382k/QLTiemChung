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
using DevExpress.XtraLayout;

namespace DXApplication2
{
     public partial class FormBacSi : UserControl
     {
          string flag;
          private static FormBacSi _instance;
          public static FormBacSi Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new FormBacSi();
                    return _instance;
               }
          }
          
          public FormBacSi()
          {
               InitializeComponent();
               dataBacSi.ReadOnly = true;
               //gridViewBS.OptionsBehavior.ReadOnly = true;
               /*LayoutControl lc = new LayoutControl();
               lc.Dock = DockStyle.Fill;
               this.Controls.Add(lc);
               this.Dock = DockStyle.Fill;*/
          }
          public void getData()
          {
               KetNoi kn = new KetNoi();
               kn.OpenConnection();
               //gridControl1.DataSource = kn.LoadData("HienThiDSBacSi");
               dataBacSi.DataSource = kn.LoadData("HienThiDSBacSi");
               for (int i = 0; i < dataBacSi.Rows.Count - 1; i++)
               {
                    dataBacSi.Rows[i].Cells[0].Value = i + 1;
                    //gridViewBS.FocusedRowHandle();
               }
          }
          public void getDataTimKiem()
          {
               KetNoi kn = new KetNoi();
               kn.OpenConnection();
               dataBacSi.DataSource = kn.LoadData("TimKiemBS");
               for (int i = 0; i < dataBacSi.Rows.Count - 1; i++)
               {
                    dataBacSi.Rows[i].Cells[0].Value = i + 1;
               }
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
                    if (kn.LoadDataDK("BacSiBietMa", "@MaBS", txtMaBS.Text).Rows.Count == 1)
                         XtraMessageBox.Show("Mã bác sĩ đã có trong danh sách");
                    else
                    {
                         kn.OpenConnection();
                         kn.BacSi("ThemBS", txtMaBS.Text, txtHoTenBS.Text, dateBS.Text, txtGTBS.Text, txtTrinhDo.Text, txtSDTBS.Text);
                    }
               }
               if (flag == "edit")
               {
                    if (kn.LoadDataDK("BacSiBietMa", "@MaBS", txtMaBS.Text).Rows.Count == 0)
                         XtraMessageBox.Show("Không tìm thấy mã bác sĩ để sửa ");
                    else
                    {
                         kn.OpenConnection();
                         kn.BacSi("SuaBS", txtMaBS.Text, txtHoTenBS.Text, dateBS.Text, txtGTBS.Text, txtTrinhDo.Text, txtSDTBS.Text);
                    }
               }
               if (flag == "delete")
               {
                    if (kn.LoadDataDK("BacSiBietMa", "@MaBS", txtMaBS.Text).Rows.Count == 0)
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

          private void btnHuyBS_Click(object sender, EventArgs e)
          {
               khoa();
          }

          private void btnBatDauTKBS_Click(object sender, EventArgs e)
          {
               mo();
               clear();
               btnTimKiemBS.Enabled = true;

          }

          private void btnTimKiemBS_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               kn.OpenConnection();
               dataBacSi.DataSource = kn.LoadDataSearchBS("TimKiemBS", txtMaBS.Text, txtHoTenBS.Text, dateBS.Text, dateBS1.Text, txtGTBS.Text, txtTrinhDo.Text, txtSDTBS.Text);
               for (int i = 0; i < dataBacSi.Rows.Count - 1; i++)
               {
                    dataBacSi.Rows[i].Cells[0].Value = i + 1;
               }

          }

          private void btnBCBS_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataDK("XuatBS", "@MaBS", txtMaBS.Text);
               if (dt.Rows.Count == 0)
               {
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               }
               else
               {
                    XtraReportBS reportBS = new XtraReportBS();
                    reportBS.DataSource = dt;
                    reportBS.ShowPreviewDialog();
               }

          }

          private void btnXuatExcelBN_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadData("HienThiDSBacSi");
               if (dt.Rows.Count == 0)
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               else
               {
                    kn.OpenConnection();
                    kn.LoadDataSet("HienThiDSBacSi").WriteXml(@"E:\Danh sách bác sĩ.xls");
                    XtraMessageBox.Show("Xuất thành công");
               }

          }

          private void FormBacSi_Load(object sender, EventArgs e)
          {
               layoutThongTinBS.Enabled = false;
               btnLuuBS.Enabled = false;
               btnHuyBS.Enabled = false;
               btnTimKiemBS.Enabled = false;
               getData();

          }

          private void dataBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int index = dataBacSi.CurrentRow.Index;
               txtMaBS.Text = dataBacSi.Rows[index].Cells[1].Value.ToString();
               txtHoTenBS.Text = dataBacSi.Rows[index].Cells[2].Value.ToString();
               dateBS.Text = dataBacSi.Rows[index].Cells[4].Value.ToString();
               txtGTBS.Text = dataBacSi.Rows[index].Cells[6].Value.ToString();
               txtTrinhDo.Text = dataBacSi.Rows[index].Cells[5].Value.ToString();
               txtSDTBS.Text = dataBacSi.Rows[index].Cells[3].Value.ToString();

          }

          private void btnBSNghiHuu_Click(object sender, EventArgs e)
          {
               int i = 0;
               KetNoi kn = new KetNoi();
               dataBacSi.DataSource = kn.LoadDataFromFunc("Select * from BSNghiHuu()");
               for (i = 0; i < dataBacSi.Rows.Count - 1; i++)
               {
                    dataBacSi.Rows[i].Cells[0].Value = i + 1;
               }
               if (i == 0)
               {
                    XtraMessageBox.Show("Không có bác sĩ nào nghỉ hưu trong năm nay");
                    getData();
               }
          }

          private void btnThoatBS_Click(object sender, EventArgs e)
          {
               getData();
          }

          private void dateBS_Validating(object sender, CancelEventArgs e)
          {
               string s = dateBS.Text;
               int yy = 0;
               s = s + "/";
               int c = 0, now = 0;
               for (int i = 0; i < s.Length; ++i)
               {
                    if (s[i] == '/')
                    { 
                         if (c == 2) yy = now;
                         c++; now = 0; continue;
                    }
                    now = now * 10 + s[i] - '0';
               }
               if (DateTime.Now.Year - yy < 27 || DateTime.Now.Year - yy > 54)
               {
                    e.Cancel = true;
                    dateBS.Focus();
                    dxErrorProvider1.SetError(dateBS, "Chỉ tuyển dụng bác sĩ từ 27 đến 54 tuổi");
               }
               else
               {
                    e.Cancel = false;
                    dxErrorProvider1.SetError(dateBS, null);
               } 
                    
          }
     }
}