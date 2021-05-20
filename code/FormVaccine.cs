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

namespace DXApplication2
{
    public partial class FormVaccine : DevExpress.XtraEditors.XtraUserControl
    {
        string flag;
        int index;
        private static FormVaccine _instance;
        public static FormVaccine Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormVaccine();
                return _instance;
            }
        }
        public void getData()
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            //dtGVLoaiVaccine.DataSource = kn.LoadData("HienThiDSLoaiVaccine");
            dtGVVaccine.DataSource = kn.LoadData("proc_HienThiDSVaccine");
        }
        public FormVaccine()
        {
            InitializeComponent();
        }

        private void FormVaccine_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dtGVVaccine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KetNoi kn = new KetNoi();
            index = dtGVVaccine.CurrentCell == null ? -1 : dtGVVaccine.CurrentCell.RowIndex;
            if (index != -1)
            {
                txtMaVaccine.Text = dtGVVaccine.Rows[index].Cells[0].Value.ToString();
                txtTenVaccine.Text = dtGVVaccine.Rows[index].Cells[1].Value.ToString();
                txtSoLuongConLai.Text = dtGVVaccine.Rows[index].Cells[2].Value.ToString();
                txtDonGia.Text = dtGVVaccine.Rows[index].Cells[3].Value.ToString();
                dtpNSX.Value = Convert.ToDateTime(dtGVVaccine.Rows[index].Cells[4].Value.ToString());
                dtpHSD.Value = Convert.ToDateTime(dtGVVaccine.Rows[index].Cells[5].Value.ToString());
                txtTenLoaiVaccine.Text = dtGVVaccine.Rows[index].Cells[6].Value.ToString();
                txtNCC.Text = dtGVVaccine.Rows[index].Cells[7].Value.ToString();
                txtKhoChua.Text = dtGVVaccine.Rows[index].Cells[8].Value.ToString();

            }
        }

        private void cbbLoaiVaccine_SelectedIndexChanged(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            dtGVVaccine.DataSource = kn.LoadDataVaccineDK("proc_VaccineTheoTenLoai", "@TenLoaiVaccine", cbbLoaiVaccine.Text);
        }


        private void btnXoaVaccine_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            kn.HuyVaccine("proc_HuyVaccine", txtMaVaccine.Text);
        }

        private void btnVaccineHetHSD_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            dtGVVaccine.DataSource = kn.LoadData("proc_VaccineHetHSD");
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            DataTable dt = kn.LoadData("proc_HienThiDSVaccine");
            if (dt.Rows.Count == 0)
                XtraMessageBox.Show("Không có dữ liệu để xuất");
            else
            {
                kn.OpenConnection();
                kn.LoadDataSet("proc_HienThiDSVaccine").WriteXml(@"E:\Danh sách vaccine.xlsx");
                XtraMessageBox.Show("Xuất excel thành công");
            }
        }

        /*private void dtGVLoaiVaccine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KetNoi kn = new KetNoi();
            index = dtGVLoaiVaccine.CurrentCell == null ? -1 : dtGVLoaiVaccine.CurrentCell.RowIndex;
            if (index != -1)
            {
                dtGVVaccine.DataSource = kn.LoadDataDK("VaccineTheoMaLoai", "@MaLoaiVaccine", dtGVLoaiVaccine.Rows[index].Cells[0].Value.ToString());
            }
        }*/
    }
}
