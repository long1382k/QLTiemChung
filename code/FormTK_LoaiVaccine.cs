using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
using QLTiemChung.code;

namespace DXApplication2
{
    public partial class FormTK_LoaiVaccine : DevExpress.XtraEditors.XtraUserControl
    {
        private static FormTK_LoaiVaccine _instance;
        public static FormTK_LoaiVaccine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormTK_LoaiVaccine();
                return _instance;
            }
        }
        public FormTK_LoaiVaccine()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();
        //Xoa cac du lieu cu hien thi tren DataSource, xoa lan luot tung hang
        public void clear()
        {
            for (int i = 0; i < dtGVLoaiVaccine.Rows.Count - 1; i++)
            {
                dtGVLoaiVaccine.Rows.RemoveAt(i);
                i--;
                while (dtGVLoaiVaccine.Rows.Count == 0)
                    continue;
            }
        }
        private void btnLoaiVaccine_Click(object sender, EventArgs e)
        {
            dtGVLoaiVaccine.DataSource = kn.LoadData("proc_TKLoaiVaccine");
            for (int i = 0; i < dtGVLoaiVaccine.Rows.Count - 1; i++)
            {
                dtGVLoaiVaccine.Rows[i].Cells[0].Value = i + 1;
            }
            kn.OpenConnection();
            DataTable dt = kn.LoadData("proc_TKLoaiVaccine");
            dt.Columns["MaLoaiVaccine"].ColumnName = "Mã loại vaccine";
            dt.Columns["TenLoaiVaccine"].ColumnName = "Tên loại vaccine";
            dt.Columns["TongSoLuong"].ColumnName = "Tổng số lượng";
            searchLookUpLoaiVaccine.Properties.DataSource = dt;
        }

        private void btnXemBieuDo_Click(object sender, EventArgs e)
        {
            try
            {
                KetNoi kn = new KetNoi();
                chartControlLoaiVaccine.DataSource = kn.LoadData("proc_TKLoaiVaccine");
                chartControlLoaiVaccine.Show();
                //labelTTYTa.Text = "Hiển thị biểu đồ thành tích lập hóa đơn của nhân viên từ " + dateFromYTa.Text + " đến " + dateToYTa.Text;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
