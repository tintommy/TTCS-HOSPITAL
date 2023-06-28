namespace BENHVIEN
{
    partial class FormChuaTriChoBenhNhan
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
            System.Windows.Forms.Label maCTBSCTBNLabel;
            System.Windows.Forms.Label maBacSiLabel;
            System.Windows.Forms.Label maBenhNhanLabel;
            System.Windows.Forms.Label maSuChuaTriLabel;
            System.Windows.Forms.Label ngayChuaTriLabel;
            System.Windows.Forms.Label thoiGianChuaTriLabel;
            System.Windows.Forms.Label ketQuaLabel;
            System.Windows.Forms.Label maVTLabel;
            System.Windows.Forms.Label maCTBSCTBNLabel1;
            System.Windows.Forms.Label soLuongLabel;
            System.Windows.Forms.Label donGiaLabel;
            System.Windows.Forms.Label thoiGianLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChuaTriChoBenhNhan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnTHEM = new DevExpress.XtraBars.BarButtonItem();
            this.btnXOA = new DevExpress.XtraBars.BarButtonItem();
            this.btnLUU = new DevExpress.XtraBars.BarButtonItem();
            this.btnUNDO = new DevExpress.XtraBars.BarButtonItem();
            this.btnLAMMOI = new DevExpress.XtraBars.BarButtonItem();
            this.btnTHOAT = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SP_ChuaTriBenhNhanBDS = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new BENHVIEN.HOSPITALDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCTBSCTBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBacSi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSuChuaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayChuaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianChuaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQ = new DevExpress.XtraEditors.TextEdit();
            this.thoiGianChuaTriSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.ngayChuaTriDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.txtMaSCT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaBN = new DevExpress.XtraEditors.TextEdit();
            this.txtMaBS = new DevExpress.XtraEditors.TextEdit();
            this.maCTBSCTBNSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnGhiVT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaVT = new DevExpress.XtraEditors.TextEdit();
            this.CT_HoaDonBDS = new System.Windows.Forms.BindingSource(this.components);
            this.thoiGianDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.maCTBSCTBNSpinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.donGiaSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.soLuongSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvCT_HoaDon = new System.Windows.Forms.DataGridView();
            this.maVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCTBSCTBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.SP_ChuaTriBenhNhanTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.SP_ChuaTriBenhNhanTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.CT_HoaDonTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_HOADONTableAdapter();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVatTu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVatTu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHieuChinhVatTu = new System.Windows.Forms.ToolStripMenuItem();
            maCTBSCTBNLabel = new System.Windows.Forms.Label();
            maBacSiLabel = new System.Windows.Forms.Label();
            maBenhNhanLabel = new System.Windows.Forms.Label();
            maSuChuaTriLabel = new System.Windows.Forms.Label();
            ngayChuaTriLabel = new System.Windows.Forms.Label();
            thoiGianChuaTriLabel = new System.Windows.Forms.Label();
            ketQuaLabel = new System.Windows.Forms.Label();
            maVTLabel = new System.Windows.Forms.Label();
            maCTBSCTBNLabel1 = new System.Windows.Forms.Label();
            soLuongLabel = new System.Windows.Forms.Label();
            donGiaLabel = new System.Windows.Forms.Label();
            thoiGianLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ChuaTriBenhNhanBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKQ.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianChuaTriSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayChuaTriDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayChuaTriDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCTBSCTBNSpinEdit.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HoaDonBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCTBSCTBNSpinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongSpinEdit.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HoaDon)).BeginInit();
            this.panel6.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // maCTBSCTBNLabel
            // 
            maCTBSCTBNLabel.AutoSize = true;
            maCTBSCTBNLabel.Location = new System.Drawing.Point(1289, 123);
            maCTBSCTBNLabel.Name = "maCTBSCTBNLabel";
            maCTBSCTBNLabel.Size = new System.Drawing.Size(105, 16);
            maCTBSCTBNLabel.TabIndex = 2;
            maCTBSCTBNLabel.Text = "Mã CTBSCTBN:";
            // 
            // maBacSiLabel
            // 
            maBacSiLabel.AutoSize = true;
            maBacSiLabel.Location = new System.Drawing.Point(1663, 127);
            maBacSiLabel.Name = "maBacSiLabel";
            maBacSiLabel.Size = new System.Drawing.Size(70, 16);
            maBacSiLabel.TabIndex = 4;
            maBacSiLabel.Text = "Mã bác sĩ:";
            // 
            // maBenhNhanLabel
            // 
            maBenhNhanLabel.AutoSize = true;
            maBenhNhanLabel.Location = new System.Drawing.Point(1296, 165);
            maBenhNhanLabel.Name = "maBenhNhanLabel";
            maBenhNhanLabel.Size = new System.Drawing.Size(94, 16);
            maBenhNhanLabel.TabIndex = 6;
            maBenhNhanLabel.Text = "Mã bệnh nhân:";
            // 
            // maSuChuaTriLabel
            // 
            maSuChuaTriLabel.AutoSize = true;
            maSuChuaTriLabel.Location = new System.Drawing.Point(1633, 164);
            maSuChuaTriLabel.Name = "maSuChuaTriLabel";
            maSuChuaTriLabel.Size = new System.Drawing.Size(91, 16);
            maSuChuaTriLabel.TabIndex = 8;
            maSuChuaTriLabel.Text = "Mã sự chữa trị:";
            // 
            // ngayChuaTriLabel
            // 
            ngayChuaTriLabel.AutoSize = true;
            ngayChuaTriLabel.Location = new System.Drawing.Point(1298, 205);
            ngayChuaTriLabel.Name = "ngayChuaTriLabel";
            ngayChuaTriLabel.Size = new System.Drawing.Size(88, 16);
            ngayChuaTriLabel.TabIndex = 10;
            ngayChuaTriLabel.Text = "Ngày chữa trị:";
            // 
            // thoiGianChuaTriLabel
            // 
            thoiGianChuaTriLabel.AutoSize = true;
            thoiGianChuaTriLabel.Location = new System.Drawing.Point(1613, 203);
            thoiGianChuaTriLabel.Name = "thoiGianChuaTriLabel";
            thoiGianChuaTriLabel.Size = new System.Drawing.Size(111, 16);
            thoiGianChuaTriLabel.TabIndex = 12;
            thoiGianChuaTriLabel.Text = "Thời gian chữa trị:";
            // 
            // ketQuaLabel
            // 
            ketQuaLabel.AutoSize = true;
            ketQuaLabel.Location = new System.Drawing.Point(1337, 248);
            ketQuaLabel.Name = "ketQuaLabel";
            ketQuaLabel.Size = new System.Drawing.Size(55, 16);
            ketQuaLabel.TabIndex = 14;
            ketQuaLabel.Text = "Kết quả:";
            // 
            // maVTLabel
            // 
            maVTLabel.AutoSize = true;
            maVTLabel.Location = new System.Drawing.Point(51, 110);
            maVTLabel.Name = "maVTLabel";
            maVTLabel.Size = new System.Drawing.Size(60, 16);
            maVTLabel.TabIndex = 2;
            maVTLabel.Text = "Mã vật tư";
            // 
            // maCTBSCTBNLabel1
            // 
            maCTBSCTBNLabel1.AutoSize = true;
            maCTBSCTBNLabel1.Location = new System.Drawing.Point(352, 110);
            maCTBSCTBNLabel1.Name = "maCTBSCTBNLabel1";
            maCTBSCTBNLabel1.Size = new System.Drawing.Size(105, 16);
            maCTBSCTBNLabel1.TabIndex = 4;
            maCTBSCTBNLabel1.Text = "Mã CTBSCTBN:";
            // 
            // soLuongLabel
            // 
            soLuongLabel.AutoSize = true;
            soLuongLabel.Location = new System.Drawing.Point(51, 169);
            soLuongLabel.Name = "soLuongLabel";
            soLuongLabel.Size = new System.Drawing.Size(66, 16);
            soLuongLabel.TabIndex = 6;
            soLuongLabel.Text = "Số lượng: ";
            // 
            // donGiaLabel
            // 
            donGiaLabel.AutoSize = true;
            donGiaLabel.Location = new System.Drawing.Point(354, 169);
            donGiaLabel.Name = "donGiaLabel";
            donGiaLabel.Size = new System.Drawing.Size(56, 16);
            donGiaLabel.TabIndex = 8;
            donGiaLabel.Text = "Đơn giá:";
            // 
            // thoiGianLabel
            // 
            thoiGianLabel.AutoSize = true;
            thoiGianLabel.Location = new System.Drawing.Point(55, 219);
            thoiGianLabel.Name = "thoiGianLabel";
            thoiGianLabel.Size = new System.Drawing.Size(69, 16);
            thoiGianLabel.TabIndex = 10;
            thoiGianLabel.Text = "Thời gian: ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnTHEM,
            this.btnXOA,
            this.btnLUU,
            this.btnUNDO,
            this.barButtonItem2,
            this.btnLAMMOI,
            this.btnCHUYENCHINHANH,
            this.btnTHOAT});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(868, 377);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLUU, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUNDO, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 2;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHEM_ItemClick);
            // 
            // btnXOA
            // 
            this.btnXOA.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnXOA.Caption = "Xoá";
            this.btnXOA.Id = 3;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXOA_ItemClick);
            // 
            // btnLUU
            // 
            this.btnLUU.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnLUU.Caption = "Lưu";
            this.btnLUU.Id = 4;
            this.btnLUU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLUU.ImageOptions.SvgImage")));
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLUU_ItemClick);
            // 
            // btnUNDO
            // 
            this.btnUNDO.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnUNDO.Caption = "Undo";
            this.btnUNDO.Id = 5;
            this.btnUNDO.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUNDO.ImageOptions.SvgImage")));
            this.btnUNDO.Name = "btnUNDO";
            this.btnUNDO.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUNDO_ItemClick);
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnLAMMOI.Caption = "Refresh";
            this.btnLAMMOI.Id = 7;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            this.btnLAMMOI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLAMMOI_ItemClick);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 9;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1055);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1025);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1025);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.barButtonItem2.Caption = "Redo";
            this.barButtonItem2.Id = 6;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 8;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(ketQuaLabel);
            this.panel1.Controls.Add(this.txtKQ);
            this.panel1.Controls.Add(thoiGianChuaTriLabel);
            this.panel1.Controls.Add(this.thoiGianChuaTriSpinEdit);
            this.panel1.Controls.Add(ngayChuaTriLabel);
            this.panel1.Controls.Add(this.ngayChuaTriDateEdit);
            this.panel1.Controls.Add(maSuChuaTriLabel);
            this.panel1.Controls.Add(this.txtMaSCT);
            this.panel1.Controls.Add(maBenhNhanLabel);
            this.panel1.Controls.Add(this.txtMaBN);
            this.panel1.Controls.Add(maBacSiLabel);
            this.panel1.Controls.Add(this.txtMaBS);
            this.panel1.Controls.Add(maCTBSCTBNLabel);
            this.panel1.Controls.Add(this.maCTBSCTBNSpinEdit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 312);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelControl1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1271, 312);
            this.panel3.TabIndex = 17;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1271, 261);
            this.panelControl1.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SP_ChuaTriBenhNhanBDS;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1267, 257);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SP_ChuaTriBenhNhanBDS
            // 
            this.SP_ChuaTriBenhNhanBDS.DataMember = "SP_ChuaTriBenhNhan";
            this.SP_ChuaTriBenhNhanBDS.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCTBSCTBN,
            this.colMaBacSi,
            this.colMaBenhNhan,
            this.colMaSuChuaTri,
            this.colNgayChuaTri,
            this.colThoiGianChuaTri,
            this.colKetQua});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaCTBSCTBN
            // 
            this.colMaCTBSCTBN.FieldName = "MaCTBSCTBN";
            this.colMaCTBSCTBN.MinWidth = 25;
            this.colMaCTBSCTBN.Name = "colMaCTBSCTBN";
            this.colMaCTBSCTBN.OptionsColumn.ReadOnly = true;
            this.colMaCTBSCTBN.Visible = true;
            this.colMaCTBSCTBN.VisibleIndex = 0;
            this.colMaCTBSCTBN.Width = 94;
            // 
            // colMaBacSi
            // 
            this.colMaBacSi.FieldName = "MaBacSi";
            this.colMaBacSi.MinWidth = 25;
            this.colMaBacSi.Name = "colMaBacSi";
            this.colMaBacSi.OptionsColumn.ReadOnly = true;
            this.colMaBacSi.Visible = true;
            this.colMaBacSi.VisibleIndex = 1;
            this.colMaBacSi.Width = 94;
            // 
            // colMaBenhNhan
            // 
            this.colMaBenhNhan.FieldName = "MaBenhNhan";
            this.colMaBenhNhan.MinWidth = 25;
            this.colMaBenhNhan.Name = "colMaBenhNhan";
            this.colMaBenhNhan.OptionsColumn.ReadOnly = true;
            this.colMaBenhNhan.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colMaBenhNhan.Width = 94;
            // 
            // colMaSuChuaTri
            // 
            this.colMaSuChuaTri.FieldName = "MaSuChuaTri";
            this.colMaSuChuaTri.MinWidth = 25;
            this.colMaSuChuaTri.Name = "colMaSuChuaTri";
            this.colMaSuChuaTri.OptionsColumn.ReadOnly = true;
            this.colMaSuChuaTri.Visible = true;
            this.colMaSuChuaTri.VisibleIndex = 2;
            this.colMaSuChuaTri.Width = 94;
            // 
            // colNgayChuaTri
            // 
            this.colNgayChuaTri.FieldName = "NgayChuaTri";
            this.colNgayChuaTri.MinWidth = 25;
            this.colNgayChuaTri.Name = "colNgayChuaTri";
            this.colNgayChuaTri.OptionsColumn.ReadOnly = true;
            this.colNgayChuaTri.Visible = true;
            this.colNgayChuaTri.VisibleIndex = 3;
            this.colNgayChuaTri.Width = 94;
            // 
            // colThoiGianChuaTri
            // 
            this.colThoiGianChuaTri.FieldName = "ThoiGianChuaTri";
            this.colThoiGianChuaTri.MinWidth = 25;
            this.colThoiGianChuaTri.Name = "colThoiGianChuaTri";
            this.colThoiGianChuaTri.OptionsColumn.ReadOnly = true;
            this.colThoiGianChuaTri.Visible = true;
            this.colThoiGianChuaTri.VisibleIndex = 4;
            this.colThoiGianChuaTri.Width = 94;
            // 
            // colKetQua
            // 
            this.colKetQua.FieldName = "KetQua";
            this.colKetQua.MinWidth = 25;
            this.colKetQua.Name = "colKetQua";
            this.colKetQua.OptionsColumn.ReadOnly = true;
            this.colKetQua.Visible = true;
            this.colKetQua.VisibleIndex = 5;
            this.colKetQua.Width = 94;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1271, 51);
            this.panel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(880, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách các phương pháp đã được áp dụng điều trị cho bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1521, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Anh/Chị: ";
            // 
            // txtKQ
            // 
            this.txtKQ.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SP_ChuaTriBenhNhanBDS, "KetQua", true));
            this.txtKQ.Location = new System.Drawing.Point(1419, 244);
            this.txtKQ.MenuManager = this.barManager1;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(125, 22);
            this.txtKQ.TabIndex = 15;
            // 
            // thoiGianChuaTriSpinEdit
            // 
            this.thoiGianChuaTriSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SP_ChuaTriBenhNhanBDS, "ThoiGianChuaTri", true));
            this.thoiGianChuaTriSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.thoiGianChuaTriSpinEdit.Location = new System.Drawing.Point(1757, 200);
            this.thoiGianChuaTriSpinEdit.MenuManager = this.barManager1;
            this.thoiGianChuaTriSpinEdit.Name = "thoiGianChuaTriSpinEdit";
            this.thoiGianChuaTriSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thoiGianChuaTriSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.thoiGianChuaTriSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.thoiGianChuaTriSpinEdit.TabIndex = 13;
            // 
            // ngayChuaTriDateEdit
            // 
            this.ngayChuaTriDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SP_ChuaTriBenhNhanBDS, "NgayChuaTri", true));
            this.ngayChuaTriDateEdit.EditValue = null;
            this.ngayChuaTriDateEdit.Location = new System.Drawing.Point(1419, 201);
            this.ngayChuaTriDateEdit.MenuManager = this.barManager1;
            this.ngayChuaTriDateEdit.Name = "ngayChuaTriDateEdit";
            this.ngayChuaTriDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayChuaTriDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayChuaTriDateEdit.Size = new System.Drawing.Size(125, 22);
            this.ngayChuaTriDateEdit.TabIndex = 11;
            // 
            // txtMaSCT
            // 
            this.txtMaSCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SP_ChuaTriBenhNhanBDS, "MaSuChuaTri", true));
            this.txtMaSCT.Location = new System.Drawing.Point(1757, 161);
            this.txtMaSCT.MenuManager = this.barManager1;
            this.txtMaSCT.Name = "txtMaSCT";
            this.txtMaSCT.Size = new System.Drawing.Size(125, 22);
            this.txtMaSCT.TabIndex = 9;
            this.txtMaSCT.Click += new System.EventHandler(this.txtMaSCT_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SP_ChuaTriBenhNhanBDS, "MaBenhNhan", true));
            this.txtMaBN.Location = new System.Drawing.Point(1419, 161);
            this.txtMaBN.MenuManager = this.barManager1;
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Properties.ReadOnly = true;
            this.txtMaBN.Size = new System.Drawing.Size(125, 22);
            this.txtMaBN.TabIndex = 7;
            // 
            // txtMaBS
            // 
            this.txtMaBS.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SP_ChuaTriBenhNhanBDS, "MaBacSi", true));
            this.txtMaBS.Location = new System.Drawing.Point(1757, 124);
            this.txtMaBS.MenuManager = this.barManager1;
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Properties.ReadOnly = true;
            this.txtMaBS.Size = new System.Drawing.Size(125, 22);
            this.txtMaBS.TabIndex = 5;
            this.txtMaBS.EditValueChanged += new System.EventHandler(this.txtMaBS_EditValueChanged);
            // 
            // maCTBSCTBNSpinEdit
            // 
            this.maCTBSCTBNSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SP_ChuaTriBenhNhanBDS, "MaCTBSCTBN", true));
            this.maCTBSCTBNSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maCTBSCTBNSpinEdit.Location = new System.Drawing.Point(1419, 119);
            this.maCTBSCTBNSpinEdit.MenuManager = this.barManager1;
            this.maCTBSCTBNSpinEdit.Name = "maCTBSCTBNSpinEdit";
            this.maCTBSCTBNSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maCTBSCTBNSpinEdit.Properties.ReadOnly = true;
            this.maCTBSCTBNSpinEdit.Size = new System.Drawing.Size(94, 24);
            this.maCTBSCTBNSpinEdit.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1507, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin sự chữa trị của bệnh nhân";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 713);
            this.panel2.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHuy);
            this.panel7.Controls.Add(this.btnGhiVT);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(thoiGianLabel);
            this.panel7.Controls.Add(this.txtMaVT);
            this.panel7.Controls.Add(this.thoiGianDateEdit);
            this.panel7.Controls.Add(maVTLabel);
            this.panel7.Controls.Add(donGiaLabel);
            this.panel7.Controls.Add(this.maCTBSCTBNSpinEdit1);
            this.panel7.Controls.Add(this.donGiaSpinEdit);
            this.panel7.Controls.Add(maCTBSCTBNLabel1);
            this.panel7.Controls.Add(soLuongLabel);
            this.panel7.Controls.Add(this.soLuongSpinEdit);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(1271, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(653, 713);
            this.panel7.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(228, 290);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(128, 40);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Location = new System.Drawing.Point(474, 290);
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.Size = new System.Drawing.Size(128, 40);
            this.btnGhiVT.TabIndex = 12;
            this.btnGhiVT.Text = "Ghi";
            this.btnGhiVT.UseVisualStyleBackColor = true;
            this.btnGhiVT.Visible = false;
            this.btnGhiVT.Click += new System.EventHandler(this.btnGhiVT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin vật tư sử dụng cho đợt chữa trị";
            // 
            // txtMaVT
            // 
            this.txtMaVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.CT_HoaDonBDS, "MaVT", true));
            this.txtMaVT.Location = new System.Drawing.Point(136, 109);
            this.txtMaVT.MenuManager = this.barManager1;
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(125, 22);
            this.txtMaVT.TabIndex = 3;
            this.txtMaVT.Click += new System.EventHandler(this.maVTTextEdit_Click);
            // 
            // CT_HoaDonBDS
            // 
            this.CT_HoaDonBDS.DataMember = "FK_SP_ChuaTriBenhNhan_CT_HOADON";
            this.CT_HoaDonBDS.DataSource = this.SP_ChuaTriBenhNhanBDS;
            // 
            // thoiGianDateEdit
            // 
            this.thoiGianDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.CT_HoaDonBDS, "ThoiGian", true));
            this.thoiGianDateEdit.EditValue = null;
            this.thoiGianDateEdit.Location = new System.Drawing.Point(136, 217);
            this.thoiGianDateEdit.MenuManager = this.barManager1;
            this.thoiGianDateEdit.Name = "thoiGianDateEdit";
            this.thoiGianDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thoiGianDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thoiGianDateEdit.Size = new System.Drawing.Size(125, 22);
            this.thoiGianDateEdit.TabIndex = 11;
            // 
            // maCTBSCTBNSpinEdit1
            // 
            this.maCTBSCTBNSpinEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.CT_HoaDonBDS, "MaCTBSCTBN", true));
            this.maCTBSCTBNSpinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maCTBSCTBNSpinEdit1.Location = new System.Drawing.Point(474, 107);
            this.maCTBSCTBNSpinEdit1.MenuManager = this.barManager1;
            this.maCTBSCTBNSpinEdit1.Name = "maCTBSCTBNSpinEdit1";
            this.maCTBSCTBNSpinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maCTBSCTBNSpinEdit1.Properties.ReadOnly = true;
            this.maCTBSCTBNSpinEdit1.Size = new System.Drawing.Size(125, 24);
            this.maCTBSCTBNSpinEdit1.TabIndex = 5;
            // 
            // donGiaSpinEdit
            // 
            this.donGiaSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.CT_HoaDonBDS, "DonGia", true));
            this.donGiaSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.donGiaSpinEdit.Location = new System.Drawing.Point(474, 165);
            this.donGiaSpinEdit.MenuManager = this.barManager1;
            this.donGiaSpinEdit.Name = "donGiaSpinEdit";
            this.donGiaSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.donGiaSpinEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.donGiaSpinEdit.Properties.ReadOnly = true;
            this.donGiaSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.donGiaSpinEdit.TabIndex = 9;
            // 
            // soLuongSpinEdit
            // 
            this.soLuongSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.CT_HoaDonBDS, "SoLuong", true));
            this.soLuongSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.soLuongSpinEdit.Location = new System.Drawing.Point(136, 165);
            this.soLuongSpinEdit.MenuManager = this.barManager1;
            this.soLuongSpinEdit.Name = "soLuongSpinEdit";
            this.soLuongSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.soLuongSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.soLuongSpinEdit.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.panelControl2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1271, 713);
            this.panel5.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvCT_HoaDon);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 51);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1271, 662);
            this.panelControl2.TabIndex = 2;
            // 
            // dgvCT_HoaDon
            // 
            this.dgvCT_HoaDon.AutoGenerateColumns = false;
            this.dgvCT_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVTDataGridViewTextBoxColumn,
            this.maCTBSCTBNDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.thoiGianDataGridViewTextBoxColumn});
            this.dgvCT_HoaDon.DataSource = this.CT_HoaDonBDS;
            this.dgvCT_HoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCT_HoaDon.Location = new System.Drawing.Point(2, 2);
            this.dgvCT_HoaDon.Name = "dgvCT_HoaDon";
            this.dgvCT_HoaDon.ReadOnly = true;
            this.dgvCT_HoaDon.RowHeadersWidth = 51;
            this.dgvCT_HoaDon.RowTemplate.Height = 24;
            this.dgvCT_HoaDon.Size = new System.Drawing.Size(1267, 658);
            this.dgvCT_HoaDon.TabIndex = 0;
            // 
            // maVTDataGridViewTextBoxColumn
            // 
            this.maVTDataGridViewTextBoxColumn.DataPropertyName = "MaVT";
            this.maVTDataGridViewTextBoxColumn.HeaderText = "MaVT";
            this.maVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maVTDataGridViewTextBoxColumn.Name = "maVTDataGridViewTextBoxColumn";
            this.maVTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maCTBSCTBNDataGridViewTextBoxColumn
            // 
            this.maCTBSCTBNDataGridViewTextBoxColumn.DataPropertyName = "MaCTBSCTBN";
            this.maCTBSCTBNDataGridViewTextBoxColumn.HeaderText = "MaCTBSCTBN";
            this.maCTBSCTBNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCTBSCTBNDataGridViewTextBoxColumn.Name = "maCTBSCTBNDataGridViewTextBoxColumn";
            this.maCTBSCTBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thoiGianDataGridViewTextBoxColumn
            // 
            this.thoiGianDataGridViewTextBoxColumn.DataPropertyName = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.HeaderText = "ThoiGian";
            this.thoiGianDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thoiGianDataGridViewTextBoxColumn.Name = "thoiGianDataGridViewTextBoxColumn";
            this.thoiGianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1271, 51);
            this.panel6.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(523, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách các vật tư đã được áp dụng";
            // 
            // SP_ChuaTriBenhNhanTableAdapter
            // 
            this.SP_ChuaTriBenhNhanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_BACSI_CHUATRI_BENHNHANTableAdapter = null;
            this.tableAdapterManager.CT_BENHNHAN_GIUONGTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NV_KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.GIUONGBENHTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // CT_HoaDonTableAdapter
            // 
            this.CT_HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemVatTu,
            this.btnXoaVatTu,
            this.btnHieuChinhVatTu});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 104);
            // 
            // btnThemVatTu
            // 
            this.btnThemVatTu.Name = "btnThemVatTu";
            this.btnThemVatTu.Size = new System.Drawing.Size(210, 24);
            this.btnThemVatTu.Text = "Thêm vật tư";
            this.btnThemVatTu.Click += new System.EventHandler(this.btnThemVatTu_Click);
            // 
            // btnXoaVatTu
            // 
            this.btnXoaVatTu.Name = "btnXoaVatTu";
            this.btnXoaVatTu.Size = new System.Drawing.Size(210, 24);
            this.btnXoaVatTu.Text = "Xóa vật tư";
            this.btnXoaVatTu.Click += new System.EventHandler(this.btnXoaVatTu_Click);
            // 
            // btnHieuChinhVatTu
            // 
            this.btnHieuChinhVatTu.Name = "btnHieuChinhVatTu";
            this.btnHieuChinhVatTu.Size = new System.Drawing.Size(210, 24);
            this.btnHieuChinhVatTu.Text = "Hiệu chỉnh";
            this.btnHieuChinhVatTu.Click += new System.EventHandler(this.btnHieuChinhVatTu_Click);
            // 
            // FormChuaTriChoBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormChuaTriChoBenhNhan";
            this.Text = "FormChuaTriChoBenhNhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChuaTriChoBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ChuaTriBenhNhanBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKQ.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianChuaTriSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayChuaTriDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayChuaTriDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCTBSCTBNSpinEdit.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_HoaDonBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoiGianDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCTBSCTBNSpinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongSpinEdit.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HoaDon)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnTHEM;
        private DevExpress.XtraBars.BarButtonItem btnXOA;
        private DevExpress.XtraBars.BarButtonItem btnLUU;
        private DevExpress.XtraBars.BarButtonItem btnUNDO;
        private DevExpress.XtraBars.BarButtonItem btnLAMMOI;
        private DevExpress.XtraBars.BarButtonItem btnTHOAT;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DataGridView dgvCT_HoaDon;
        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource SP_ChuaTriBenhNhanBDS;
        private HOSPITALDataSetTableAdapters.SP_ChuaTriBenhNhanTableAdapter SP_ChuaTriBenhNhanTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCTBSCTBN;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBacSi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSuChuaTri;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayChuaTri;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianChuaTri;
        private DevExpress.XtraGrid.Columns.GridColumn colKetQua;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtKQ;
        private DevExpress.XtraEditors.SpinEdit thoiGianChuaTriSpinEdit;
        private DevExpress.XtraEditors.DateEdit ngayChuaTriDateEdit;
        private DevExpress.XtraEditors.TextEdit txtMaSCT;
        private DevExpress.XtraEditors.TextEdit txtMaBN;
        private DevExpress.XtraEditors.TextEdit txtMaBS;
        private DevExpress.XtraEditors.SpinEdit maCTBSCTBNSpinEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource CT_HoaDonBDS;
        private HOSPITALDataSetTableAdapters.CT_HOADONTableAdapter CT_HoaDonTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit thoiGianDateEdit;
        private DevExpress.XtraEditors.SpinEdit donGiaSpinEdit;
        private DevExpress.XtraEditors.SpinEdit soLuongSpinEdit;
        private DevExpress.XtraEditors.SpinEdit maCTBSCTBNSpinEdit1;
        private DevExpress.XtraEditors.TextEdit txtMaVT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ToolStripMenuItem btnThemVatTu;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVatTu;
        private System.Windows.Forms.ToolStripMenuItem btnHieuChinhVatTu;
        private System.Windows.Forms.Button btnGhiVT;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCTBSCTBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGianDataGridViewTextBoxColumn;
    }
}