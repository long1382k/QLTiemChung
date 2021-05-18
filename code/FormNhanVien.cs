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
     public partial class FormNhanVien : UserControl
     {
          string flag;
          private static FormNhanVien _instance;
          public static FormNhanVien Instance
          {
               get
               {
                    if (_instance == null)
                         _instance = new FormNhanVien();
                    return _instance;
               }
          }
          public FormNhanVien()
          {
               InitializeComponent();
               dataNV.ReadOnly = true;
               getData();
          }

          private void FormNhanVien_Load(object sender, EventArgs e)
          {
               layoutThongTinNV.Enabled = false;
               btnLuuNV.Enabled = false;
               btnHuyNV.Enabled = false;
               btnTKNV.Enabled = false;
          }
          public void getData()
          {
               KetNoi kn = new KetNoi();
               dataNV.DataSource = kn.LoadData("HienThiDSNhanVien");
               for (int i = 0; i < dataNV.Rows.Count - 1; i++)
               {
                    dataNV.Rows[i].Cells[0].Value = i + 1;
                    
               }
               dataNV.Refresh();
          }
          public void getDataTimKiem()
          {
               KetNoi kn = new KetNoi();
               dataNV.DataSource = kn.LoadData("TimKiemNV");
               for (int i = 0; i < dataNV.Rows.Count - 1; i++)
               {
                    dataNV.Rows[i].Cells[0].Value = i + 1;
               }
          }
          public void TaoMaNVMoi()
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadData("HienThiDSNhanVien");
               int count = 0;
               count = dt.Rows.Count;
               string s1 = "";
               int s2 = 0;
               s1 = Convert.ToString(dt.Rows[count - 1][0].ToString());
               s2 = Convert.ToInt32((s1.Remove(0, 2)));
               if (s2 + 1 < 10)
                    txtMaNV.Text = "NV00" + (s2 + 1).ToString();
               else if (s2 + 1 < 100)
                    txtMaNV.Text = "NV0" + (s2 + 1).ToString();
               else if (s2 + 1 < 1000)
                    txtMaNV.Text = "NV" + (s2 + 1).ToString();
               else
                    txtMaNV.Text = "";
          }
          public void khoa()
          {
               btnThemNV.Enabled = true;
               btnSuaNV.Enabled = true;
               btnXoaNV.Enabled = true;
               btnLuuNV.Enabled = false;
               btnHuyNV.Enabled = false;
               layoutThongTinNV.Enabled = false;
          }



          public void mo()
          {
               btnThemNV.Enabled = false;
               btnSuaNV.Enabled = false;
               btnXoaNV.Enabled = false;
               btnLuuNV.Enabled = true;
               btnHuyNV.Enabled = true;
               layoutThongTinNV.Enabled = true;
               txtMaNV.Focus();
          }
          public bool check()
          {
               if (string.IsNullOrEmpty(txtHoTenNV.Text))
               {
                    MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtHoTenNV.Focus();
                    return false;
               }

               if (string.IsNullOrEmpty(dateNV.Text))
               {
                    MessageBox.Show("Bạn chưa nhập ngày tháng năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateNV.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtGTNV.Text))
               {
                    MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGTNV.Focus();
                    return false;
               }
               if (string.IsNullOrEmpty(txtSDTNV.Text))
               {
                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSDTNV.Focus();
                    return false;
               }
               return true;
          }
          public void clear()
          {
               txtMaNV.Text = "";
               txtHoTenNV.Text = "";
               txtGTNV.Text = "";
               dateNV.Text = "";
               dateNV1.Text = "";
               txtSDTNV.Text = "";
          }


          private void btnThemNV_Click(object sender, EventArgs e)
          {
               mo();
               flag = "add";
               clear();
               TaoMaNVMoi();

          }

          private void btnSuaNV_Click(object sender, EventArgs e)
          {
               mo();
               txtMaNV.ReadOnly = true;
               flag = "edit";

          }

          private void btnXoaNV_Click(object sender, EventArgs e)
          {
               mo();
               flag = "delete";
               layoutThongTinNV.Enabled = false;

          }

          private void btnLuuNV_Click(object sender, EventArgs e)
          {
               if (check() == false)
               {
                    XtraMessageBox.Show("Bạn điền thông tin chưa đầy đủ");
                    return;
               }
               KetNoi kn = new KetNoi();
               if (flag == "add")
               {
                    if (kn.LoadDataDK("NhanVienBietMa", "@MaNV", txtMaNV.Text).Rows.Count == 1)
                         XtraMessageBox.Show("Mã nhân viên đã có trong danh sách");
                    else
                    {
                         kn.OpenConnection();
                         kn.Yta_NV("ThemNV", "@MaNV", "@HoTenNV", "@NgaySinhNV", "@GioiTinhNV", "@SDTNV", txtMaNV.Text, txtHoTenNV.Text, dateNV.Text, txtGTNV.Text, txtSDTNV.Text);
                    }
               }
               if (flag == "edit")
               {
                    if (kn.LoadDataDK("NhanVienBietMa", "@MaNV", txtMaNV.Text).Rows.Count == 0)
                         XtraMessageBox.Show("Không tìm thấy mã nhân viên để sửa ");
                    else
                    {
                         kn.OpenConnection();
                         kn.Yta_NV("SuaNV", "@MaNV", "@HoTenNV", "@NgaySinhNV", "@GioiTinhNV", "@SDTNV", txtMaNV.Text, txtHoTenNV.Text, dateNV.Text, txtGTNV.Text, txtSDTNV.Text);
                    }
               }
               if (flag == "delete")
               {
                    if (kn.LoadDataDK("NhanVienBietMa", "@MaNV", txtMaNV.Text).Rows.Count == 0)
                         XtraMessageBox.Show("Không tìm thấy mã nhân viên để xóa ");
                    else
                    {
                         kn.OpenConnection();
                         kn.Xoa("XoaNV", "@MaNV", txtMaNV.Text);
                         clear();
                    }
               }
               getData();
               khoa();
               flag = "";
               txtMaNV.ReadOnly = false;
          }

          private void btnHuyNV_Click(object sender, EventArgs e)
          {
               khoa();
          }

          private void btnBDTKNV_Click(object sender, EventArgs e)
          {
               mo();
               clear();
               btnTKNV.Enabled = true;

          }

          private void btnTKNV_Click(object sender, EventArgs e)
          {
               int i = 0;
               KetNoi kn = new KetNoi();
               kn.OpenConnection();
               dataNV.DataSource = kn.LoadDataSearchYTa_NV("TimKiemNV", "@MaNV", "@HoTenNV", "@NgaySinhNV1", "@NgaySinhNV2", "@GioiTinhNV", "@SDTNV", txtMaNV.Text, txtHoTenNV.Text, dateNV.Text, dateNV1.Text, txtGTNV.Text, txtSDTNV.Text);
               for (i = 0; i < dataNV.Rows.Count - 1; i++)
               {
                    dataNV.Rows[i].Cells[0].Value = i + 1;
               }
               if (i == 0)
               {
                    if (dateNV.Text == "" || dateNV1.Text == "")
                         XtraMessageBox.Show("Không có nhân viên bạn muốn tìm trong danh sách nhân viên của trung tâm vì bạn chưa nhập khoảng ngày sinh của nhân viên");
                    else 
                         XtraMessageBox.Show("Không có nhân viên bạn muốn tìm trong danh sách nhân viên của trung tâm");
                    getData();
               }
          }

          private void btnXuatBCNV_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataDK("", "@MaNV", txtMaNV.Text);
               if (dt.Rows.Count == 0)
               {
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               }
               else
               {
                    XtraReportNV reportNV = new XtraReportNV();
                    reportNV.DataSource = dt;
                    reportNV.ShowPreviewDialog();
               }

          }

          private void btnXuatNV_Click(object sender, EventArgs e)
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadDataDK("NhanVienBietMa", "@MaBS", txtMaNV.Text);
               if (dt.Rows.Count == 0)
               {
                    XtraMessageBox.Show("Không có dữ liệu để xuất");
               }
               else
               {
                    XtraReportNV reportNV = new XtraReportNV();
                    reportNV.DataSource = dt;
                    reportNV.ShowPreviewDialog();
               }
          }

          private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int index = dataNV.CurrentRow.Index;
               txtMaNV.Text = dataNV.Rows[index].Cells[1].Value.ToString();
               txtHoTenNV.Text = dataNV.Rows[index].Cells[2].Value.ToString();
               dateNV.Text = dataNV.Rows[index].Cells[3].Value.ToString();
               txtGTNV.Text = dataNV.Rows[index].Cells[4].Value.ToString();
               txtSDTNV.Text = dataNV.Rows[index].Cells[5].Value.ToString();

          }

          private void btnNVNghiHuu_Click(object sender, EventArgs e)
          {
               int i = 0;
               KetNoi kn = new KetNoi();
               dataNV.DataSource = kn.LoadDataFromFunc("Select * from NVNghiHuu()");
               for (i = 0; i < dataNV.Rows.Count - 1; i++)
               {
                    dataNV.Rows[i].Cells[0].Value = i + 1;
               }
               if (i==0)
               {
                    XtraMessageBox.Show("Không có nhân viên nào nghỉ hưu trong năm nay");
                    getData();
               }
               
          }

          private void btnThoatNV_Click(object sender, EventArgs e)
          {
               getData();
          }

          private void dateNV_Properties_Validating(object sender, CancelEventArgs e)
          {
               string s = dateNV.Text;
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
               if (flag == "add")
               {
                    if (DateTime.Now.Year - yy < 18 || DateTime.Now.Year - yy > 54)
                    {
                         e.Cancel = true;
                         dxErrorProvider1.SetError(dateNV, "Chỉ tuyển dụng nhân viên từ 18 đến 54 tuổi");
                    }
                    else
                    {
                         e.Cancel = false;
                         dxErrorProvider1.SetError(dateNV, null);
                    }
               }
               if (flag == "edit")
               {
                    if (DateTime.Now.Year - yy < 18 || DateTime.Now.Year - yy > 54)
                    {
                         e.Cancel = true;
                         dxErrorProvider1.SetError(dateNV, "Chỉ được sửa thành ngày sinh mới trong khoảng từ 18 đến 54 tuổi");
                    }
                    else
                    {
                         e.Cancel = false;
                         dxErrorProvider1.SetError(dateNV, null);
                    }
               }
          }
     }
}