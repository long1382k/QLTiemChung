using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication2
{
     public partial class Form1 : DevExpress.XtraEditors.XtraForm
     {
          public static int kt = 0;//biến kiểm tra lưu, sửa , xóa
          public Form1()
          {
               InitializeComponent();
               DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Xmas 2008 Blue");
               dgv_NCC.ReadOnly = true;
          }
          public void getData()
          {
               KetNoi kn = new KetNoi();
               kn.OpenConnection();
               DataTable dt = new DataTable();
               dt = kn.LoadData("dsNhaCungCap");
               dgv_NCC.DataSource = dt;
               dt.Columns["MaNhaCungCap"].ColumnName = "Mã Nhà Cung Cấp";
               dt.Columns["TenNhaCungCap"].ColumnName = "Tên Nhà Cung Cấp";
               dt.Columns["DiaChi"].ColumnName = "Địa chỉ";
               dt.Columns["SDT"].ColumnName = "SĐT";
               searchLookUpEdit1.Properties.DataSource = dt;
               searchLookUpEdit1.Properties.DisplayMember = "Mã Nhà Cung Cấp";
               
          }

          private void Form1_Load(object sender, EventArgs e)
          {
               
               layout_thongtinNCC.Enabled = false;
               btn_save.Enabled = false;
               getData();
          }
          public bool kiemtra()
          {
               if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtSDT.Text == "" || txtDiaChi.Text =="")
                    return false;
               return true;
          }
          public void clear()
          {
               txtMaNCC.Text = "";
               txtTenNCC.Text = "";
               txtDiaChi.Text = "";
               txtSDT.Text = "";
          }
          public void MaNCCMoi()
          {
               KetNoi kn = new KetNoi();
               DataTable dt = kn.LoadData("dsNhaCungCap");
               int count = 0;
               count = dt.Rows.Count;
               string s1 = "";
               int s2 = 0;
               s1 = Convert.ToString(dt.Rows[0][0].ToString());
               s2 = Convert.ToInt32((s1.Remove(0, 3)));
               if (s2 != 99)
                    txtMaNCC.Text = "NCC" + (s2 + 1).ToString();
               else
                    txtMaNCC.Text = "";
          }

          private void btn_add_Click(object sender, EventArgs e)
          {
               kt = 1;
               layout_thongtinNCC.Enabled = true;
               btn_save.Enabled = true;
               txtMaNCC.Enabled = false;
               clear();
               MaNCCMoi();
               btn_add.ForeColor = Color.White;
               btn_edit.ForeColor = Color.Black;
               btn_remove.ForeColor = Color.Black;
          }

          private void btn_edit_Click(object sender, EventArgs e)
          {
               kt = 2;
               layout_thongtinNCC.Enabled = true;
               btn_save.Enabled = true;
               txtMaNCC.Enabled = false;
               btn_add.ForeColor = Color.Black;
               btn_edit.ForeColor = Color.White;
               btn_remove.ForeColor = Color.Black;

          }

          

          private void btn_remove_Click(object sender, EventArgs e)
          {
               kt = 3;
               layout_thongtinNCC.Enabled = true;
               btn_save.Enabled = true;
               btn_add.ForeColor = Color.Black;
               btn_edit.ForeColor = Color.Black;
               btn_remove.ForeColor = Color.White;
               
          }

          private void btn_save_Click(object sender, EventArgs e)
          {
               //if (kiemtra() == false)
               //{
               //     XtraMessageBox.Show("Bạn điền thông tin chưa đầy đủ");
               //     return;
               //}
               //KetNoi kn = new KetNoi();
               //if (kt == 1)
               //{
               //     if (kn.LoadDataWithParameter("TimMaNhaCungCap", "@MaNCC", txtMaNCC.Text).Rows.Count == 1)
               //          XtraMessageBox.Show("Mã nhà cung cấp đã có trong danh sách");
               //     else
               //     {
               //          kn.OpenConnection();
               //          kn.proc_NhaCungCap("ThemNCC", "@MaNCC", "@TenNCC","@DC","@SDT" ,txtMaNCC.Text, txtTenNCC.Text,txtDiaChi.Text,txtSDT.Text);
               //     }
               //}
               //else if (kt == 2)
               //{
               //     if (kn.LoadDataWithParameter("TimMaNhaCungCap", "@MaNCC", txtMaNCC.Text).Rows.Count == 0)
               //          XtraMessageBox.Show("Không tìm thấy nhà cung cấp để sửa ");
               //     else
               //     {
               //          kn.OpenConnection();
               //          kn.proc_NhaCungCap("SuaNCC", "@MaNCC", "@TenNCC", "@DC", "@SDT", txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text);
               //     }
               //}
               //else if (kt == 3)
               //{
               //     try
               //     {
               //          if (kn.LoadDataWithParameter("TimMaNhaCungCap", "@MaNCC", txtMaNCC.Text).Rows.Count == 0)
               //               XtraMessageBox.Show("Không tìm thấy mã nhà cung cấp để xóa ");
               //          else
               //          {
               //               kn.OpenConnection();
               //               kn.Xoa("XoaNCC", "@MaNCC", txtMaNCC.Text);
               //               clear();
               //          }
               //     }
               //     catch
               //     {
               //          XtraMessageBox.Show("Không thực hiện xóa các bác sỹ đang làm việc");
               //          kn.connection.Close();
               //     }

               //}
               //getData();
               //kt = 0;
               //btn_add.ForeColor = Color.Black;
               //btn_edit.ForeColor = Color.Black;
               //btn_remove.ForeColor = Color.Black;
          }

          private void dgv_NCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
          {
               try
               {
                    DataGridViewRow row = new DataGridViewRow();
                    row = dgv_NCC.Rows[e.RowIndex];
                    txtMaNCC.Text = row.Cells[0].Value.ToString();
                    txtTenNCC.Text = row.Cells[1].Value.ToString();
                    txtDiaChi.Text = row.Cells[2].Value.ToString();
                    txtSDT.Text = row.Cells[3].Value.ToString();
               }
               catch (Exception ex)
               {
                   
                    XtraMessageBox.Show(ex.Message);
               }
          }

          private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
          {
               var view = searchLookUpEdit1.Properties.View;
               int rowHandle = view.FocusedRowHandle;
               string fieldName1 = "Mã Nhà Cung Cấp";
               string fieldName2 = "Tên Nhà Cung Cấp";
               string fieldName3 = "Địa chỉ";
               string fieldName4 = "SĐT";
               
               object value1 = view.GetRowCellValue(rowHandle, fieldName1);
               object value2 = view.GetRowCellValue(rowHandle, fieldName2);
               object value3 = view.GetRowCellValue(rowHandle, fieldName3);
               object value4 = view.GetRowCellValue(rowHandle, fieldName4);
               txtMaNCC.Text = value1.ToString();
               txtTenNCC.Text = value2.ToString();
               txtDiaChi.Text = value3.ToString();
               txtSDT.Text = value4.ToString();
          }
     }
}
