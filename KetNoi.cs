using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DevExpress.XtraEditors;
using System.Configuration;

namespace DXApplication2
{
     class KetNoi
     {

          public SqlConnection connection = new SqlConnection();
          public void OpenConnection()
          {
               if (connection.State == ConnectionState.Closed)
                    connection.Open();
          }
          public KetNoi()
          {
               try
               {
                    connection.ConnectionString = "Data Source=DESKTOP-LKSP5F9\\SQLEXPRESS;Initial Catalog=TiemChung;Integrated Security=True";
                    connection.Open();
               }
               catch (Exception ex)
               {    
                    XtraMessageBox.Show(ex.Message);
               }
          }


          public DataTable LoadDataUser(string name, string pass)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = "DangNhap";
               command.Parameters.AddWithValue("@userName", SqlDbType.VarChar).Value = name;
               command.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = pass;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }

          // tra ve dataset de xuat excel
          public DataSet LoadDataSet(string proc)
          {
               DataSet data = new DataSet();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(data);
               connection.Close();
               return data;
          }
          // tra ve dataset de xuat excel doi voi phan thong ke
          public DataSet LoadDataSetTK(string proc, string dayFrom, string dayTo)
          {
               DataSet data = new DataSet();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               command.Parameters.AddWithValue("@dayFrom", SqlDbType.Date).Value = dayFrom;
               command.Parameters.AddWithValue("@dayTo", SqlDbType.Date).Value = dayTo;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(data);
               connection.Close();
               return data;
          }

          // load du lieu khong dieu kien
          public DataTable LoadData(string TT)
          {
               DataTable data = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = TT;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(data);
               connection.Close();
               return data;
          }
          // load du lieu co dieu kien 1 tham so(mã BN, mã BS...)
          public DataTable LoadDataDK(string proc, string param, string value)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               command.Parameters.AddWithValue(param, SqlDbType.VarChar).Value = value;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }

          // load du lieu 1 chi tiet toa thuoc bat ki
          public DataTable LoadDataCTDK(string MaToa, string MaThuoc)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = "ChiTietDK";
               command.Parameters.AddWithValue("@MaToa", SqlDbType.VarChar).Value = MaToa;
               command.Parameters.AddWithValue("@MaThuoc", SqlDbType.VarChar).Value = MaThuoc;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }

          // load data theo ngay kham
          public DataTable LoadData_Ngay(string proc, string day)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               command.Parameters.AddWithValue("@ngayBan", SqlDbType.Date).Value = day;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }
          // load du lieu toa thuoc benh nhan theo tung hoa don(ngay kham)
          public DataTable LoadDataDK2(string proc, string MaBN, string day)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               command.Parameters.AddWithValue("@MaBN", SqlDbType.VarChar).Value = MaBN;
               command.Parameters.AddWithValue("@ngayBan", SqlDbType.Date).Value = day;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }
          // load data thong ke from-to
          public DataTable LoadDataTK(string proc, string dayFrom, string dayTo)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               command.Parameters.AddWithValue("@dayFrom", SqlDbType.Date).Value = dayFrom;
               command.Parameters.AddWithValue("@dayTo", SqlDbType.Date).Value = dayTo;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }


          // Them, sua Benh Nhan
          public void BenhNhan(string pro, string MaBN, string HoTen, string GioiTinh, string NgaySinh, string DiaChi, string SDT)
          {
               try
               {
                    SqlCommand command = new SqlCommand(pro, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaBN", SqlDbType.VarChar).Value = MaBN;
                    command.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = HoTen;
                    command.Parameters.AddWithValue("@GioiTinh", SqlDbType.Char).Value = GioiTinh;
                    command.Parameters.AddWithValue("@NgaySinh", SqlDbType.Date).Value = NgaySinh;
                    command.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = DiaChi;
                    command.Parameters.AddWithValue("@SDT", SqlDbType.VarChar).Value = SDT;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }

          // Xoa benh nhan, bac sy, duoc sy,phieu kham,toathuoc,hoadon
          public void Xoa(string proc, string paramMa, string ma)
          {
               try
               {
                    SqlCommand command = new SqlCommand(proc, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(paramMa, SqlDbType.VarChar).Value = ma;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }

          // Them, sua BacSy, duoc sy
          public void Bac_DuocSy(string proc, string paramMa, string paramTen, string ma, string ten)
          {
               try
               {
                    SqlCommand command = new SqlCommand(proc, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(paramMa, SqlDbType.VarChar).Value = ma;
                    command.Parameters.AddWithValue(paramTen, SqlDbType.NVarChar).Value = ten;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }

          // Them,sua Phieu Kham
          public void PhieuKham(string proc, string MaPK, string MaBN, string MaBS, string NgayKham, string TrieuChung, string KetLuan)
          {
               try
               {
                    SqlCommand command = new SqlCommand(proc, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaPK", SqlDbType.VarChar).Value = MaPK;
                    command.Parameters.AddWithValue("@MaBN", SqlDbType.VarChar).Value = MaBN;
                    command.Parameters.AddWithValue("@MaBS", SqlDbType.VarChar).Value = MaBS;
                    command.Parameters.AddWithValue("@NgayKham", SqlDbType.Date).Value = NgayKham;
                    command.Parameters.AddWithValue("@TrieuChung", SqlDbType.NVarChar).Value = TrieuChung;
                    command.Parameters.AddWithValue("@KetLuan", SqlDbType.NVarChar).Value = KetLuan;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }


          // them, sua thuoc
          public void Thuoc(string proc, string MaThuoc, string TenThuoc, string DonVi, string DonGia, string NSX, string HSD)
          {
               try
               {
                    SqlCommand command = new SqlCommand(proc, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaThuoc", SqlDbType.VarChar).Value = MaThuoc;
                    command.Parameters.AddWithValue("@TenThuoc", SqlDbType.NVarChar).Value = TenThuoc;
                    command.Parameters.AddWithValue("@DonVi", SqlDbType.NVarChar).Value = DonVi;
                    command.Parameters.AddWithValue("@DonGia", SqlDbType.Int).Value = DonGia;
                    command.Parameters.AddWithValue("@NSX", SqlDbType.Date).Value = NSX;
                    command.Parameters.AddWithValue("@HSD", SqlDbType.Date).Value = HSD;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }
          // them, sua hoa don thuoc
          public void HoaDon(string proc, string MaHD, string MaDS, string NgayBan, string TienHD)
          {
               try
               {
                    SqlCommand command = new SqlCommand(proc, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHD", SqlDbType.VarChar).Value = MaHD;
                    command.Parameters.AddWithValue("@MaDS", SqlDbType.VarChar).Value = MaDS;
                    command.Parameters.AddWithValue("@NgayBan", SqlDbType.Date).Value = NgayBan;
                    command.Parameters.AddWithValue("@TienHD", SqlDbType.Int).Value = TienHD;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }
          // sua mahd cua toa thuoc
          public void SuaMaHDToaThuoc(string MaHD, string MaToa)
          {
               try
               {
                    SqlCommand command = new SqlCommand("SuaMaHDToaThuoc", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaHD", SqlDbType.VarChar).Value = MaHD;
                    command.Parameters.AddWithValue("@MaToa", SqlDbType.VarChar).Value = MaToa;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }
          // sua ma hd cua toa thuoc la null
          public void SuaMaHDToaThuocNull(string MaToa)
          {
               try
               {
                    SqlCommand command = new SqlCommand("MaHDToaThuocNull", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaToa", SqlDbType.VarChar).Value = MaToa;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }
          // them , sua toa thuoc
          public void ToaThuoc(string proc, string MaToa, string MaPK)
          {
               try
               {
                    SqlCommand command = new SqlCommand(proc, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaToa", SqlDbType.VarChar).Value = MaToa;
                    command.Parameters.AddWithValue("@MaPK", SqlDbType.VarChar).Value = MaPK;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }
          // load data thuoc trong ct
          public DataTable loadDataCTToaThuoc(string MaToa, string MaThuoc)
          {

               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = "KTThuocInToa";
               command.Parameters.AddWithValue("@MaToa", SqlDbType.VarChar).Value = MaToa;
               command.Parameters.AddWithValue("@MaThuoc", SqlDbType.VarChar).Value = MaThuoc;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }

          //Them,sua CT
          public void CTToaThuoc(string proc, string MaToa, string MaThuoc, string SoLuong, string CachDung)
          {
               try
               {
                    SqlCommand command = new SqlCommand(proc, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaToa", SqlDbType.VarChar).Value = MaToa;
                    command.Parameters.AddWithValue("@MaThuoc", SqlDbType.VarChar).Value = MaThuoc;
                    command.Parameters.AddWithValue("@SoLuong", SqlDbType.Int).Value = SoLuong;
                    command.Parameters.AddWithValue("@CachDung", SqlDbType.NVarChar).Value = CachDung;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }

          }
          // xoa ct
          public void XoaCT(string MaToa, string MaThuoc)
          {
               try
               {
                    SqlCommand command = new SqlCommand("CapNhatXoaChiTiet", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MaToa", SqlDbType.VarChar).Value = MaToa;
                    command.Parameters.AddWithValue("@MaThuoc", SqlDbType.VarChar).Value = MaThuoc;
                    command.ExecuteNonQuery();
                    connection.Close();
               }
               catch (Exception ex)
               {
                    XtraMessageBox.Show(ex.Message);
                    connection.Close();
               }
          }

          public DataTable loadTkCacThang(string nam)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = "TkDoanhThuCacThang";
               command.Parameters.AddWithValue("@nam", SqlDbType.Int).Value = nam;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }

          public DataTable TaiKhoan(string proc, string Ten, string MK, string quyen)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               command.Parameters.AddWithValue("@TenTK", SqlDbType.VarChar).Value = Ten;
               command.Parameters.AddWithValue("@MK", SqlDbType.VarChar).Value = MK;
               command.Parameters.AddWithValue("@Quyen", SqlDbType.Char).Value = quyen;
               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }
          public DataTable Top5Benh(string proc, string thang, string nam, string loai)
          {
               DataTable table = new DataTable();
               SqlCommand command = new SqlCommand();
               command.Connection = connection;
               command.CommandType = CommandType.StoredProcedure;
               command.CommandText = proc;
               if (loai.CompareTo("thang") == 0)
               {
                    command.Parameters.AddWithValue("@thang", SqlDbType.Int).Value = thang;
                    command.Parameters.AddWithValue("@nam", SqlDbType.Int).Value = nam;
               }
               else
               {
                    command.Parameters.AddWithValue("@nam", SqlDbType.Int).Value = nam;
               }

               SqlDataAdapter adapter = new SqlDataAdapter(command);
               adapter.Fill(table);
               connection.Close();
               return table;
          }
     }
}
