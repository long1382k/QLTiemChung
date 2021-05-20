using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
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
     public partial class FormMenuChinh : DevExpress.XtraBars.Ribbon.RibbonForm
     {
          public FormMenuChinh()
          {
               InitializeComponent();
               SkinHelper.InitSkinPopupMenu(skinslink);
          }

          private void barKH_ItemClick(object sender, ItemClickEventArgs e)
          {

          }

          private void barYTa_ItemClick(object sender, ItemClickEventArgs e)
          {
               panelControl1.Controls.Clear();
               panelControl1.Controls.Add(FormYTa.Instance);
          }

          private void barBS_ItemClick(object sender, ItemClickEventArgs e)
          {
               panelControl1.Controls.Clear();
               panelControl1.Controls.Add(FormBacSi.Instance);
               //FormBacSi frm = new FormBacSi();
               //DevExpress.XtraEditors.XtraDialog.Show(frm);
          }

          private void barNV_ItemClick(object sender, ItemClickEventArgs e)
          {
               panelControl1.Controls.Clear();
               panelControl1.Controls.Add(FormNhanVien.Instance);
          }

          private void barButtonBS_ItemClick(object sender, ItemClickEventArgs e)
          {
               panelControl1.Controls.Clear();
               panelControl1.Controls.Add(FormTK_ThanhTichBS.Instance);
          }

          private void barButtonYTa_ItemClick(object sender, ItemClickEventArgs e)
          {
               panelControl1.Controls.Clear();
               panelControl1.Controls.Add(FormTK_ThanhTichYTa.Instance);
          }

          private void barButtonNV_ItemClick(object sender, ItemClickEventArgs e)
          {
               panelControl1.Controls.Clear();
               panelControl1.Controls.Add(FormTK_ThanhTichNV.Instance);
          }

          private void barNCC_ItemClick(object sender, ItemClickEventArgs e)
          {
               panelControl1.Controls.Clear();
               panelControl1.Controls.Add(FormNhaCungCap.Instance);

          }

        private void barKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            panelControl1.Controls.Add(FormKho.Instance);
        }

        private void barVaccine_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            panelControl1.Controls.Add(FormVaccine.Instance);
        }

        private void barLoaiVaccineStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {
            panelControl1.Controls.Clear();
            panelControl1.Controls.Add(FormTK_LoaiVaccine.Instance);
        }

        private void barKhoStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}