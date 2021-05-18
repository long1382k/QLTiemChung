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
    public partial class FormKho : DevExpress.XtraEditors.XtraUserControl
    {
        string flag;
        int index;
        private static FormKho _instance;
        public static FormKho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormKho();
                return _instance;
            }
        }
        public void getData()
        {
            KetNoi kn = new KetNoi();
            kn.OpenConnection();
            dtGVKho.DataSource = kn.LoadData("HienThiKho");
            /*for (int i = 0; i < dtGVKho.Rows.Count - 1; i++)
            {
                dtGVKho.Rows[i].Cells[0].Value = i + 1;
                //gridViewBS.FocusedRowHandle();
            }*/
            
        }
        public FormKho()
        {
            InitializeComponent();
        }
        private void FormKho_Load(object sender, EventArgs e)
        {
            getData();
            LockControl();
        }
        private void LockControl()
        {
            btnLuuKho.Enabled = false;
            btnHuyKho.Enabled = false;
            btnThemKho.Enabled = true;
            btnSuaKho.Enabled = true;
            btnXoaKho.Enabled = true;

            txtMaKho.ReadOnly = true;
            txtTenKho.ReadOnly = true;
            txtDiaDiemKho.ReadOnly = true;
        }
        private void Unlock()
        {
            btnLuuKho.Enabled = true;
            btnHuyKho.Enabled = true;
            btnThemKho.Enabled = false;
            btnSuaKho.Enabled = false;
            btnXoaKho.Enabled = false;

            txtMaKho.ReadOnly = false;
            txtTenKho.ReadOnly = false;
            txtDiaDiemKho.ReadOnly = false;
        }
        private void Clear()
        {
            txtMaKho.Text = "";
            txtTenKho.Text = "";
            txtDiaDiemKho.Text = "";
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            flag = "them";
            Unlock();
            Clear();
            TaoMaKhoMoi();
        }

        private void btnSuaKho_Click(object sender, EventArgs e)
        {
            flag = "sua";
            Unlock();
        }
        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            flag = "xoa";
            Unlock();
            txtMaKho.ReadOnly = false;
        }
        private void btnLuuKho_Click(object sender, EventArgs e)
        {
            KetNoi kn = new KetNoi();
            if (flag == "them")
            {
                if (kn.LoadDataDK("KhoBietMa", "@MaKho", txtMaKho.Text).Rows.Count == 1)
                    XtraMessageBox.Show("Mã kho đã có trong danh sách");
                else
                {
                    kn.OpenConnection();
                    kn.Kho("ThemKho", txtMaKho.Text, txtTenKho.Text, txtDiaDiemKho.Text);
                    MessageBox.Show("Thêm thành công");
                }
            }
            if (flag == "sua")
            {
                if (kn.LoadDataDK("KhoBietMa", "@MaKho", txtMaKho.Text).Rows.Count == 0)
                    XtraMessageBox.Show("Không tìm thấy mã kho để sửa ");
                else
                {
                    kn.OpenConnection();
                    kn.Kho("SuaKho", txtMaKho.Text, txtTenKho.Text, txtDiaDiemKho.Text);
                    MessageBox.Show("Sửa thành công");
                }
            }
            if (flag == "xoa")
            {
                if (kn.LoadDataDK("KhoBietMa", "@MaKho", txtMaKho.Text).Rows.Count == 0)
                    XtraMessageBox.Show("Không tìm thấy mã kho để xóa ");
                else
                {
                    if (MessageBox.Show("Bạn có muốn xóa kho này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        kn.OpenConnection();
                        kn.Xoa("XoaKho", "@MaKho", txtMaKho.Text);
                        Clear();
                    }
                }
            }
            getData();
            LockControl();
        }
        private void btnHuyKho_Click(object sender, EventArgs e)
        {
            Clear();
            LockControl();
        }
        public void TaoMaKhoMoi()
        {
            KetNoi kn = new KetNoi();
            DataTable dt = kn.LoadData("HienThiKho");
            int count = 0;
            count = dt.Rows.Count;
            string s1 = "";
            int s2 = 0;
            s1 = Convert.ToString(dt.Rows[count - 1][0].ToString());
            s2 = Convert.ToInt32((s1.Remove(0, 2)));
            if (s2 + 1 < 10)
                txtMaKho.Text = "K0" + (s2 + 1).ToString();
            else if (s2 + 1 < 100)
                txtMaKho.Text = "K" + (s2 + 1).ToString();
            else
                txtMaKho.Text = "";
        }
        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtMaKho.Text) || string.IsNullOrWhiteSpace(txtTenKho.Text) || string.IsNullOrWhiteSpace(txtDiaDiemKho.Text))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void dtGVKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KetNoi kn = new KetNoi();
            index = dtGVKho.CurrentCell == null ? -1 : dtGVKho.CurrentCell.RowIndex;
            if (index != -1)
            {
                txtMaKho.Text = dtGVKho.Rows[index].Cells[0].Value.ToString();
                txtTenKho.Text = dtGVKho.Rows[index].Cells[1].Value.ToString();
                txtDiaDiemKho.Text = dtGVKho.Rows[index].Cells[2].Value.ToString();

                LockControl();

                dtGVLoaiVacineTrongKho.DataSource = kn.LoadDataDK("HienThiLoaiVaccineTrongKho", "@MaKho", dtGVKho.Rows[index].Cells[0].Value.ToString());
                //ShowDetail(dataset, index);
            }
        }

        
    }
}
