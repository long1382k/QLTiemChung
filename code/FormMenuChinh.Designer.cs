
namespace DXApplication2
{
     partial class FormMenuChinh
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuChinh));
               this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
               this.barKH = new DevExpress.XtraBars.BarButtonItem();
               this.barBS = new DevExpress.XtraBars.BarButtonItem();
               this.barYTa = new DevExpress.XtraBars.BarButtonItem();
               this.barNV = new DevExpress.XtraBars.BarButtonItem();
               this.barPhieuKTSK = new DevExpress.XtraBars.BarButtonItem();
               this.barPhieuTiem = new DevExpress.XtraBars.BarButtonItem();
               this.barVaccine = new DevExpress.XtraBars.BarButtonItem();
               this.barHD = new DevExpress.XtraBars.BarButtonItem();
               this.barTKVaccine = new DevExpress.XtraBars.BarButtonItem();
               this.barTTNS = new DevExpress.XtraBars.BarButtonItem();
               this.barTKDT = new DevExpress.XtraBars.BarButtonItem();
               this.barNCC = new DevExpress.XtraBars.BarButtonItem();
               this.barGiaoDien = new DevExpress.XtraBars.BarButtonItem();
               this.skinslink = new DevExpress.XtraBars.BarLinkContainerItem();
               this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
               this.barButtonBS = new DevExpress.XtraBars.BarButtonItem();
               this.barButtonYTa = new DevExpress.XtraBars.BarButtonItem();
               this.barButtonNV = new DevExpress.XtraBars.BarButtonItem();
               this.ribbonChucNang = new DevExpress.XtraBars.Ribbon.RibbonPage();
               this.ribbonKhachHang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonNhanSu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonPhieuTiem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonVaccine = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonHoaDon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonThongKe = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonNguonCap = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPage();
               this.ribbonChonGiaoDien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
               this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
               this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
               this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
               this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
               this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
               this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
               ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
               this.SuspendLayout();
               // 
               // ribbon
               // 
               this.ribbon.ExpandCollapseItem.Id = 0;
               this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barKH,
            this.barBS,
            this.barYTa,
            this.barNV,
            this.barPhieuKTSK,
            this.barPhieuTiem,
            this.barVaccine,
            this.barHD,
            this.barTKVaccine,
            this.barTTNS,
            this.barTKDT,
            this.barNCC,
            this.barGiaoDien,
            this.skinslink,
            this.barSubItem1,
            this.barButtonBS,
            this.barButtonYTa,
            this.barButtonNV});
               this.ribbon.Location = new System.Drawing.Point(0, 0);
               this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.ribbon.MaxItemId = 19;
               this.ribbon.Name = "ribbon";
               this.ribbon.OptionsMenuMinWidth = 283;
               this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonChucNang,
            this.ribbonGiaoDien});
               this.ribbon.Size = new System.Drawing.Size(1661, 158);
               this.ribbon.StatusBar = this.ribbonStatusBar;
               // 
               // barKH
               // 
               this.barKH.Caption = "Khách hàng";
               this.barKH.Id = 1;
               this.barKH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barKH.ImageOptions.Image")));
               this.barKH.Name = "barKH";
               this.barKH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barKH_ItemClick);
               // 
               // barBS
               // 
               this.barBS.Caption = "Bác sĩ";
               this.barBS.Id = 2;
               this.barBS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBS.ImageOptions.Image")));
               this.barBS.Name = "barBS";
               this.barBS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barBS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBS_ItemClick);
               // 
               // barYTa
               // 
               this.barYTa.Caption = "Y tá";
               this.barYTa.Id = 3;
               this.barYTa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barYTa.ImageOptions.Image")));
               this.barYTa.Name = "barYTa";
               this.barYTa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barYTa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barYTa_ItemClick);
               // 
               // barNV
               // 
               this.barNV.Caption = "Nhân viên";
               this.barNV.Id = 4;
               this.barNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barNV.ImageOptions.Image")));
               this.barNV.Name = "barNV";
               this.barNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNV_ItemClick);
               // 
               // barPhieuKTSK
               // 
               this.barPhieuKTSK.Caption = "Phiếu KTSK";
               this.barPhieuKTSK.Id = 5;
               this.barPhieuKTSK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barPhieuKTSK.ImageOptions.Image")));
               this.barPhieuKTSK.Name = "barPhieuKTSK";
               this.barPhieuKTSK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barPhieuTiem
               // 
               this.barPhieuTiem.Caption = "Phiếu tiêm";
               this.barPhieuTiem.Id = 6;
               this.barPhieuTiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barPhieuTiem.ImageOptions.Image")));
               this.barPhieuTiem.Name = "barPhieuTiem";
               this.barPhieuTiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barVaccine
               // 
               this.barVaccine.Caption = "Vaccine";
               this.barVaccine.Id = 7;
               this.barVaccine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barVaccine.ImageOptions.Image")));
               this.barVaccine.Name = "barVaccine";
               this.barVaccine.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barHD
               // 
               this.barHD.Caption = "Hóa đơn";
               this.barHD.Id = 8;
               this.barHD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barHD.ImageOptions.Image")));
               this.barHD.Name = "barHD";
               this.barHD.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barTKVaccine
               // 
               this.barTKVaccine.Caption = "Lượng vaccine";
               this.barTKVaccine.Id = 9;
               this.barTKVaccine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTKVaccine.ImageOptions.Image")));
               this.barTKVaccine.Name = "barTKVaccine";
               this.barTKVaccine.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barTTNS
               // 
               this.barTTNS.Caption = "Thành tích nhân sự";
               this.barTTNS.Id = 10;
               this.barTTNS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTTNS.ImageOptions.Image")));
               this.barTTNS.Name = "barTTNS";
               this.barTTNS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barTKDT
               // 
               this.barTKDT.Caption = "Doanh thu";
               this.barTKDT.Id = 11;
               this.barTKDT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barTKDT.ImageOptions.Image")));
               this.barTKDT.Name = "barTKDT";
               this.barTKDT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barNCC
               // 
               this.barNCC.Caption = "Nhà cung cấp";
               this.barNCC.Id = 12;
               this.barNCC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barNCC.ImageOptions.Image")));
               this.barNCC.Name = "barNCC";
               this.barNCC.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barNCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barNCC_ItemClick);
               // 
               // barGiaoDien
               // 
               this.barGiaoDien.Caption = "Giao diện";
               this.barGiaoDien.Id = 13;
               this.barGiaoDien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barGiaoDien.ImageOptions.Image")));
               this.barGiaoDien.Name = "barGiaoDien";
               this.barGiaoDien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // skinslink
               // 
               this.skinslink.Caption = "Giao diện";
               this.skinslink.Id = 14;
               this.skinslink.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("skinslink.ImageOptions.Image")));
               this.skinslink.Name = "skinslink";
               this.skinslink.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barSubItem1
               // 
               this.barSubItem1.Caption = "Thành tích nhân sự";
               this.barSubItem1.Id = 15;
               this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
               this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonBS),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonYTa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonNV)});
               this.barSubItem1.Name = "barSubItem1";
               this.barSubItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               // 
               // barButtonBS
               // 
               this.barButtonBS.Caption = "Thành tích bác sĩ";
               this.barButtonBS.Id = 16;
               this.barButtonBS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonBS.ImageOptions.Image")));
               this.barButtonBS.Name = "barButtonBS";
               this.barButtonBS.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
               this.barButtonBS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBS_ItemClick);
               // 
               // barButtonYTa
               // 
               this.barButtonYTa.Caption = "Thành tích y tá";
               this.barButtonYTa.Id = 17;
               this.barButtonYTa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonYTa.ImageOptions.Image")));
               this.barButtonYTa.Name = "barButtonYTa";
               this.barButtonYTa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
               this.barButtonYTa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonYTa_ItemClick);
               // 
               // barButtonNV
               // 
               this.barButtonNV.Caption = "Thành tích nhân viên";
               this.barButtonNV.Id = 18;
               this.barButtonNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonNV.ImageOptions.Image")));
               this.barButtonNV.Name = "barButtonNV";
               this.barButtonNV.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
               this.barButtonNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNV_ItemClick);
               // 
               // ribbonChucNang
               // 
               this.ribbonChucNang.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonKhachHang,
            this.ribbonNhanSu,
            this.ribbonPhieuTiem,
            this.ribbonVaccine,
            this.ribbonHoaDon,
            this.ribbonThongKe,
            this.ribbonNguonCap});
               this.ribbonChucNang.Name = "ribbonChucNang";
               this.ribbonChucNang.Text = "Chức năng";
               // 
               // ribbonKhachHang
               // 
               this.ribbonKhachHang.ItemLinks.Add(this.barKH);
               this.ribbonKhachHang.Name = "ribbonKhachHang";
               this.ribbonKhachHang.Text = "Khách hàng";
               // 
               // ribbonNhanSu
               // 
               this.ribbonNhanSu.ItemLinks.Add(this.barBS);
               this.ribbonNhanSu.ItemLinks.Add(this.barYTa);
               this.ribbonNhanSu.ItemLinks.Add(this.barNV);
               this.ribbonNhanSu.Name = "ribbonNhanSu";
               this.ribbonNhanSu.Text = "Nhân sự";
               // 
               // ribbonPhieuTiem
               // 
               this.ribbonPhieuTiem.ItemLinks.Add(this.barPhieuKTSK);
               this.ribbonPhieuTiem.ItemLinks.Add(this.barPhieuTiem);
               this.ribbonPhieuTiem.Name = "ribbonPhieuTiem";
               this.ribbonPhieuTiem.Text = "Phiếu tiêm";
               // 
               // ribbonVaccine
               // 
               this.ribbonVaccine.ItemLinks.Add(this.barVaccine);
               this.ribbonVaccine.Name = "ribbonVaccine";
               this.ribbonVaccine.Text = "Vaccine";
               // 
               // ribbonHoaDon
               // 
               this.ribbonHoaDon.ItemLinks.Add(this.barHD);
               this.ribbonHoaDon.Name = "ribbonHoaDon";
               this.ribbonHoaDon.Text = "Hóa đơn";
               // 
               // ribbonThongKe
               // 
               this.ribbonThongKe.ItemLinks.Add(this.barTKVaccine);
               this.ribbonThongKe.ItemLinks.Add(this.barSubItem1);
               this.ribbonThongKe.ItemLinks.Add(this.barTKDT);
               this.ribbonThongKe.Name = "ribbonThongKe";
               this.ribbonThongKe.Text = "Thống kê";
               // 
               // ribbonNguonCap
               // 
               this.ribbonNguonCap.ItemLinks.Add(this.barNCC);
               this.ribbonNguonCap.Name = "ribbonNguonCap";
               this.ribbonNguonCap.Text = "Nguồn cấp";
               // 
               // ribbonGiaoDien
               // 
               this.ribbonGiaoDien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonChonGiaoDien});
               this.ribbonGiaoDien.Name = "ribbonGiaoDien";
               this.ribbonGiaoDien.Text = "Giao diện";
               // 
               // ribbonChonGiaoDien
               // 
               this.ribbonChonGiaoDien.ItemLinks.Add(this.skinslink);
               this.ribbonChonGiaoDien.Name = "ribbonChonGiaoDien";
               this.ribbonChonGiaoDien.Text = "Giao diện";
               // 
               // ribbonStatusBar
               // 
               this.ribbonStatusBar.Location = new System.Drawing.Point(0, 853);
               this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.ribbonStatusBar.Name = "ribbonStatusBar";
               this.ribbonStatusBar.Ribbon = this.ribbon;
               this.ribbonStatusBar.Size = new System.Drawing.Size(1661, 24);
               // 
               // barManager1
               // 
               this.barManager1.DockControls.Add(this.barDockControlTop);
               this.barManager1.DockControls.Add(this.barDockControlBottom);
               this.barManager1.DockControls.Add(this.barDockControlLeft);
               this.barManager1.DockControls.Add(this.barDockControlRight);
               this.barManager1.Form = this;
               // 
               // barDockControlTop
               // 
               this.barDockControlTop.CausesValidation = false;
               this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
               this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
               this.barDockControlTop.Manager = this.barManager1;
               this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.barDockControlTop.Size = new System.Drawing.Size(1661, 0);
               // 
               // barDockControlBottom
               // 
               this.barDockControlBottom.CausesValidation = false;
               this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.barDockControlBottom.Location = new System.Drawing.Point(0, 877);
               this.barDockControlBottom.Manager = this.barManager1;
               this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.barDockControlBottom.Size = new System.Drawing.Size(1661, 0);
               // 
               // barDockControlLeft
               // 
               this.barDockControlLeft.CausesValidation = false;
               this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
               this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
               this.barDockControlLeft.Manager = this.barManager1;
               this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.barDockControlLeft.Size = new System.Drawing.Size(0, 877);
               // 
               // barDockControlRight
               // 
               this.barDockControlRight.CausesValidation = false;
               this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
               this.barDockControlRight.Location = new System.Drawing.Point(1661, 0);
               this.barDockControlRight.Manager = this.barManager1;
               this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.barDockControlRight.Size = new System.Drawing.Size(0, 877);
               // 
               // panelControl1
               // 
               this.panelControl1.Location = new System.Drawing.Point(0, 162);
               this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.panelControl1.Name = "panelControl1";
               this.panelControl1.Size = new System.Drawing.Size(1665, 686);
               this.panelControl1.TabIndex = 6;
               // 
               // FormMenuChinh
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 877);
               this.Controls.Add(this.panelControl1);
               this.Controls.Add(this.ribbonStatusBar);
               this.Controls.Add(this.ribbon);
               this.Controls.Add(this.barDockControlLeft);
               this.Controls.Add(this.barDockControlRight);
               this.Controls.Add(this.barDockControlBottom);
               this.Controls.Add(this.barDockControlTop);
               this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
               this.Name = "FormMenuChinh";
               this.Ribbon = this.ribbon;
               this.StatusBar = this.ribbonStatusBar;
               this.Text = "Trung tâm tiêm chủng";
               this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
               ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
          private DevExpress.XtraBars.Ribbon.RibbonPage ribbonChucNang;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonKhachHang;
          private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
          private DevExpress.XtraBars.Ribbon.RibbonPage ribbonGiaoDien;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonChonGiaoDien;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonNhanSu;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPhieuTiem;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonVaccine;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonHoaDon;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonThongKe;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonNguonCap;
          private DevExpress.XtraBars.BarButtonItem barKH;
          private DevExpress.XtraBars.BarButtonItem barBS;
          private DevExpress.XtraBars.BarButtonItem barYTa;
          private DevExpress.XtraBars.BarButtonItem barNV;
          private DevExpress.XtraBars.BarButtonItem barPhieuKTSK;
          private DevExpress.XtraBars.BarButtonItem barPhieuTiem;
          private DevExpress.XtraBars.BarButtonItem barVaccine;
          private DevExpress.XtraBars.BarButtonItem barHD;
          private DevExpress.XtraBars.BarButtonItem barTKVaccine;
          private DevExpress.XtraBars.BarButtonItem barTTNS;
          private DevExpress.XtraBars.BarButtonItem barTKDT;
          private DevExpress.XtraBars.BarButtonItem barNCC;
          private DevExpress.XtraBars.BarButtonItem barGiaoDien;
          private DevExpress.XtraBars.BarLinkContainerItem skinslink;
          private DevExpress.XtraBars.BarManager barManager1;
          private DevExpress.XtraBars.BarDockControl barDockControlTop;
          private DevExpress.XtraBars.BarDockControl barDockControlBottom;
          private DevExpress.XtraBars.BarDockControl barDockControlLeft;
          private DevExpress.XtraBars.BarDockControl barDockControlRight;
          private DevExpress.XtraEditors.PanelControl panelControl1;
          private DevExpress.XtraBars.BarSubItem barSubItem1;
          private DevExpress.XtraBars.BarButtonItem barButtonBS;
          private DevExpress.XtraBars.BarButtonItem barButtonYTa;
          private DevExpress.XtraBars.BarButtonItem barButtonNV;
     }
}