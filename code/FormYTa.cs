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
     public partial class FormYTa : UserControl
     {
          string flag;
          private static FormYTa _instance;
          public static FormYTa Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new FormYTa();
                    return _instance;
               }
          }
          public FormYTa()
          {
               InitializeComponent();
               DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Xmas 2008 Blue");
               dataYTa.ReadOnly = true;
          }
          public void getData()
          {
               KetNoi kn = new KetNoi();
               dataYTa.DataSource = kn.LoadData("HienThiDSYTa");
               for (int i = 0; i < dataYTa.Rows.Count - 1; i++)
               {
                    dataYTa.Rows[i].Cells[0].Value = i + 1;
               }
               kn.OpenConnection();
          }
          public void getDataTimKiem()
          {
               KetNoi kn = new KetNoi();
               dataYTa.DataSource = kn.LoadData("TimKiemYTa");
               for (int i = 0; i < dataYTa.Rows.Count - 1; i++)
               {
                    dataYTa.Rows[i].Cells[0].Value = i + 1;
               }
               kn.OpenConnection();
          }
          public void TaoMaYTaMoi()
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadData("HienThiDSYTa");
               int count = 0;
               count = dt.Rows.Count;
               string s1 = "";
               int s2 = 0;
               s1 = Convert.ToString(dt.Rows[count - 1][0].ToString());
               s2 = Convert.ToInt32((s1.Remove(0, 2)));
               if (s2 + 1 < 10)
                    txtMaYTa.Text = "YTa00" + (s2 + 1).ToString();
               else if (s2 + 1 < 100)
                    txtMaYTa.Text = "YTa0" + (s2 + 1).ToString();
               else if (s2 + 1 < 1000)
                    txtMaYTa.Text = "YTa" + (s2 + 1).ToString();
               else
                    txtMaYTa.Text = "";
          }
          public void khoa()

          {
               btnThemYTa.Enabled = true;
               btnSuaYTa.Enabled = true;
               btnXoaYTa.Enabled = true;
               btnLuuYTa.Enabled = false;
               btnHuyYTa.Enabled = false;
               layoutThongTinYTa.Enabled = false;
          }



          public void mo()
          {
               btnThemYTa.Enabled = false;
               btnSuaYTa.Enabled = false;
               btnXoaYTa.Enabled = false;
               btnLuuYTa.Enabled = true;
               btnHuyYTa.Enabled = true;
               layoutThongTinYTa.Enabled = true;
               txtMaYTa.Focus();
          }
          public bool check()
          {
               if (string.IsNullOrWhiteSpace(txtMaYTa.Text))
               {
                    MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaYTa.Focus();
                    return false;
               }

               if (string.IsNullOrEmpty(txtHoTenYTa.Text))
               {
                    MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTenYTa.Focus();
                    return false;
               }

               if (string.IsNullOrEmpty(dateYTa.Text))
               {
                    MessageBox.Show("Bạn chưa nhập ngày tháng năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateYTa.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtGTYTa.Text))
               {
                    MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGTYTa.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtSDTYTa.Text))
               {
                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSDTYTa.Focus();
                    return false;
               }
               return true;
          }
          public void clear()
          {
               txtMaYTa.Text = "";
               txtHoTenYTa.Text = "";
               txtGTYTa.Text = "";
               dateYTa.Text = "";
               dateYTa1.Text = "";
               txtSDTYTa.Text = "";
          }

          private void btnThemYTa_Click(object sender, System.EventArgs e)
          {
               mo();
               flag = "add";
               clear();
               TaoMaYTaMoi();

          }

          private void btnSuaYTa_Click(object sender, System.EventArgs e)
          {
               mo();
               txtMaYTa.ReadOnly = true;
               flag = "edit";
          }

          private void btnXoaYTa_Click(object sender, System.EventArgs e)
          {
               mo();
               flag = "delete";
               layoutThongTinYTa.Enabled = false;

          }

          private void btnLuuYTa_Click(object sender, System.EventArgs e)
          {
               if (check() == false)
               {
                    XtraMessageBox.Show("Bạn điền thông tin chưa đầy đủ");
                    return;
               }
               KetNoi kn = new KetNoi();
               if (flag == "add")
               {
                    if (kn.LoadDataDK("YTaBietMa", "@MaYTa", txtMaYTa.Text).Rows.Count == 1)
                         XtraMessageBox.Show("Mã y tá đã có trong danh sách");
                    else
                    {
                         kn.OpenConnection();
                         kn.Yta_NV("ThemYTa", "@MaYTa", "@HoTenYTa", "@NgaySinhYTa", "@GioiTinhYTa", "@SDTYTa", txtMaYTa.Text, txtHoTenYTa.Text, dateYTa.Text, txtGTYTa.Text, txtSDTYTa.Text);
                    }
               }
               if (flag == "edit")
               {
                    if (kn.LoadDataDK("YTaBietMa", "@MaYTa", txtMaYTa.Text).Rows.Count == 0)
                         XtraMessageBox.Show("Không tìm thấy mã y tá để sửa ");
                    else
                    {
                         kn.OpenConnection();
                         kn.Yta_NV("SuaYTa", "@MaYTa", "@HoTenYTa", "@NgaySinhYTa", "@GioiTinhYTa", "@SDTYTa", txtMaYTa.Text, txtHoTenYTa.Text, dateYTa.Text, txtGTYTa.Text, txtSDTYTa.Text);
                    }
               }
               if (flag == "delete")
               {
                    if (kn.LoadDataDK("YTaBietMa", "@MaYTa", txtMaYTa.Text).Rows.Count == 0)
                         XtraMessageBox.Show("Không tìm thấy mã y tá để xóa ");
                    else
                    {
                         kn.OpenConnection();
                         kn.Xoa("XoaYTa", "@MaYTa", txtMaYTa.Text);
                         clear();
                    }
               }
               getData();

          }

          private void btnHuyYTa_Click(object sender, System.EventArgs e)
          {
               khoa();
          }

          private void btnBDTKYT_Click(object sender, System.EventArgs e)
          {
               mo();
               clear();
               btnTKYT.Enabled = true;

          }

          private void btnTKYT_Click(object sender, System.EventArgs e)
          {
               KetNoi kn = new KetNoi();
               kn.OpenConnection();
               dataYTa.DataSource = kn.LoadDataSearchYTa_NV("TimKiemYTa", "@MaYTa", "@HoTenYTa", "@NgaySinhYTa1", "@NgaySinhYTa2", "@GioiTinhYTa", "@SDTYTa", txtMaYTa.Text, txtHoTenYTa.Text, dateYTa.Text, dateYTa1.Text, txtGTYTa.Text, txtSDTYTa.Text);
               for (int i = 0; i < dataYTa.Rows.Count - 1; i++)
               {
                    dataYTa.Rows[i].Cells[0].Value = i + 1;
               }

          }

          private void btnXuatYTa_Click(object sender, System.EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataDK("XuatYTa", "@MaYTa", txtMaYTa.Text);
               if (dt.Rows.Count == 0)
               {
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               }
               else
               {
                    XtraReportYTa reportYTa = new XtraReportYTa();
                    reportYTa.DataSource = dt;
                    reportYTa.ShowPreviewDialog();
               }

          }

          private void btnXuatExcelYTa_Click(object sender, System.EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadData("HienThiDSYTa");
               if (dt.Rows.Count == 0)
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               else
               {
                    kn.OpenConnection();
                    kn.LoadDataSet("HienThiDSYTa").WriteXml(@"E:\Danh sách y tá.xls");
                    XtraMessageBox.Show("Xuất thành công");
               }

          }

          private void FormYTa_Load(object sender, System.EventArgs e)
          {
               layoutThongTinYTa.Enabled = false;
               btnLuuYTa.Enabled = false;
               btnHuyYTa.Enabled = false;
               btnTKYT.Enabled = false;
               getData();

          }

          private void dataYTa_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
          {
               int index = dataYTa.CurrentRow.Index;
               txtMaYTa.Text = dataYTa.Rows[index].Cells[1].Value.ToString();
               txtHoTenYTa.Text = dataYTa.Rows[index].Cells[2].Value.ToString();
               dateYTa.Text = dataYTa.Rows[index].Cells[3].Value.ToString();
               txtGTYTa.Text = dataYTa.Rows[index].Cells[4].Value.ToString();
               txtSDTYTa.Text = dataYTa.Rows[index].Cells[5].Value.ToString();

          }

          private void btnYTaNghiHuu_Click(object sender, EventArgs e)
          {
               int i = 0;
               KetNoi kn = new KetNoi();
               dataYTa.DataSource = kn.LoadDataFromFunc("Select * from YTaNghiHuu()");
               for (i = 0; i < dataYTa.Rows.Count - 1; i++)
               {
                    dataYTa.Rows[i].Cells[0].Value = i + 1;
               }
               if (i == 0)
               {
                    XtraMessageBox.Show("Không có y tá nào nghỉ hưu trong năm nay");
                    getData();
               }
          }

          private void btnThoatNV_Click(object sender, EventArgs e)
          {
               getData();
          }

          private void dateYTa_Properties_Validating(object sender, CancelEventArgs e)
          {
               string s = dateYTa.Text;
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
               if (DateTime.Now.Year - yy < 22 || DateTime.Now.Year - yy > 54)
               {
                    e.Cancel = true;
                    dateYTa.Focus();
                    dxErrorProvider1.SetError(dateYTa, "Chỉ tuyển dụng y tá từ 22 đến 54 tuổi");
               }
               else
               {
                    e.Cancel = false;
                    dxErrorProvider1.SetError(dateYTa, null);
               }
          }
     }
}