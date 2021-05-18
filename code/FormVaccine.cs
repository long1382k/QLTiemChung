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
            dtGVLoaiVaccine.DataSource = kn.LoadData("HienThiDSLoaiVaccine");
        }
        public FormVaccine()
        {
            InitializeComponent();
        }

        private void FormVaccine_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void dtGVLoaiVaccine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            KetNoi kn = new KetNoi();
            index = dtGVLoaiVaccine.CurrentCell == null ? -1 : dtGVLoaiVaccine.CurrentCell.RowIndex;
            if (index != -1)
            {
                dtGVVaccine.DataSource = kn.LoadDataDK("HienThiDSVaccine", "@MaLoaiVaccine", dtGVLoaiVaccine.Rows[index].Cells[0].Value.ToString());
            }
        }
    }
}
