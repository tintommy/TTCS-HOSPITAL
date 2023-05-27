namespace BENHVIEN
{
    partial class FormYTa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYTa));
            System.Windows.Forms.Label maYTLabel;
            System.Windows.Forms.Label congViecLabel;
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
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
            this.DS = new BENHVIEN.HOSPITALDataSet();
            this.bdsYTA = new System.Windows.Forms.BindingSource(this.components);
            this.yTATableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.YTATableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.yTAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaYT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongViec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsTTYTA = new System.Windows.Forms.BindingSource(this.components);
            this.tHONGTINYTATableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.THONGTINYTATableAdapter();
            this.tHONGTINYTAGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaYT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maYTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.congViecTextEdit = new DevExpress.XtraEditors.TextEdit();
            maYTLabel = new System.Windows.Forms.Label();
            congViecLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsYTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTYTA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINYTAGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maYTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
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
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 10;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(868, 377);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHEM, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXOA, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLUU, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUNDO, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLAMMOI, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnTHOAT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnTHEM.Caption = "Thêm";
            this.btnTHEM.Id = 2;
            this.btnTHEM.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHEM.ImageOptions.SvgImage")));
            this.btnTHEM.Name = "btnTHEM";
            // 
            // btnXOA
            // 
            this.btnXOA.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnXOA.Caption = "Xoá";
            this.btnXOA.Id = 3;
            this.btnXOA.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXOA.ImageOptions.SvgImage")));
            this.btnXOA.Name = "btnXOA";
            // 
            // btnLUU
            // 
            this.btnLUU.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnLUU.Caption = "Lưu";
            this.btnLUU.Id = 4;
            this.btnLUU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLUU.ImageOptions.SvgImage")));
            this.btnLUU.Name = "btnLUU";
            // 
            // btnUNDO
            // 
            this.btnUNDO.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnUNDO.Caption = "Undo";
            this.btnUNDO.Id = 5;
            this.btnUNDO.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUNDO.ImageOptions.SvgImage")));
            this.btnUNDO.Name = "btnUNDO";
            // 
            // btnLAMMOI
            // 
            this.btnLAMMOI.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.btnLAMMOI.Caption = "Refresh";
            this.btnLAMMOI.Id = 7;
            this.btnLAMMOI.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLAMMOI.ImageOptions.SvgImage")));
            this.btnLAMMOI.Name = "btnLAMMOI";
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Caption = "Thoát";
            this.btnTHOAT.Id = 9;
            this.btnTHOAT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTHOAT.ImageOptions.SvgImage")));
            this.btnTHOAT.Name = "btnTHOAT";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1046, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 598);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1046, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 568);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1046, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 568);
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
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsYTA
            // 
            this.bdsYTA.DataMember = "YTA";
            this.bdsYTA.DataSource = this.DS;
            // 
            // yTATableAdapter
            // 
            this.yTATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
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
            this.tableAdapterManager.YTATableAdapter = this.yTATableAdapter;
            // 
            // yTAGridControl
            // 
            this.yTAGridControl.DataSource = this.bdsYTA;
            this.yTAGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.yTAGridControl.Location = new System.Drawing.Point(0, 30);
            this.yTAGridControl.MainView = this.gridView1;
            this.yTAGridControl.MenuManager = this.barManager1;
            this.yTAGridControl.Name = "yTAGridControl";
            this.yTAGridControl.Size = new System.Drawing.Size(1046, 220);
            this.yTAGridControl.TabIndex = 5;
            this.yTAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaYT,
            this.colCongViec});
            this.gridView1.GridControl = this.yTAGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaYT
            // 
            this.colMaYT.FieldName = "MaYT";
            this.colMaYT.MinWidth = 25;
            this.colMaYT.Name = "colMaYT";
            this.colMaYT.Visible = true;
            this.colMaYT.VisibleIndex = 0;
            this.colMaYT.Width = 94;
            // 
            // colCongViec
            // 
            this.colCongViec.FieldName = "CongViec";
            this.colCongViec.MinWidth = 25;
            this.colCongViec.Name = "colCongViec";
            this.colCongViec.Visible = true;
            this.colCongViec.VisibleIndex = 1;
            this.colCongViec.Width = 94;
            // 
            // bdsTTYTA
            // 
            this.bdsTTYTA.DataMember = "FK_YTA_THONGTINYTA";
            this.bdsTTYTA.DataSource = this.bdsYTA;
            // 
            // tHONGTINYTATableAdapter
            // 
            this.tHONGTINYTATableAdapter.ClearBeforeFill = true;
            // 
            // tHONGTINYTAGridControl
            // 
            this.tHONGTINYTAGridControl.DataSource = this.bdsTTYTA;
            this.tHONGTINYTAGridControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tHONGTINYTAGridControl.Location = new System.Drawing.Point(577, 250);
            this.tHONGTINYTAGridControl.MainView = this.gridView2;
            this.tHONGTINYTAGridControl.MenuManager = this.barManager1;
            this.tHONGTINYTAGridControl.Name = "tHONGTINYTAGridControl";
            this.tHONGTINYTAGridControl.Size = new System.Drawing.Size(469, 348);
            this.tHONGTINYTAGridControl.TabIndex = 9;
            this.tHONGTINYTAGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaYT1,
            this.colHo,
            this.colTen,
            this.colPhai,
            this.colSDT});
            this.gridView2.GridControl = this.tHONGTINYTAGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.ReadOnly = true;
            // 
            // colMaYT1
            // 
            this.colMaYT1.FieldName = "MaYT";
            this.colMaYT1.MinWidth = 25;
            this.colMaYT1.Name = "colMaYT1";
            this.colMaYT1.Visible = true;
            this.colMaYT1.VisibleIndex = 0;
            this.colMaYT1.Width = 94;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 94;
            // 
            // colPhai
            // 
            this.colPhai.FieldName = "Phai";
            this.colPhai.MinWidth = 25;
            this.colPhai.Name = "colPhai";
            this.colPhai.Visible = true;
            this.colPhai.VisibleIndex = 3;
            this.colPhai.Width = 94;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.MinWidth = 25;
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            this.colSDT.Width = 94;
            // 
            // maYTLabel
            // 
            maYTLabel.AutoSize = true;
            maYTLabel.Location = new System.Drawing.Point(48, 344);
            maYTLabel.Name = "maYTLabel";
            maYTLabel.Size = new System.Drawing.Size(50, 16);
            maYTLabel.TabIndex = 9;
            maYTLabel.Text = "Ma YT:";
            // 
            // maYTTextEdit
            // 
            this.maYTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsYTA, "MaYT", true));
            this.maYTTextEdit.Location = new System.Drawing.Point(166, 341);
            this.maYTTextEdit.MenuManager = this.barManager1;
            this.maYTTextEdit.Name = "maYTTextEdit";
            this.maYTTextEdit.Size = new System.Drawing.Size(125, 22);
            this.maYTTextEdit.TabIndex = 10;
            // 
            // congViecLabel
            // 
            congViecLabel.AutoSize = true;
            congViecLabel.Location = new System.Drawing.Point(26, 426);
            congViecLabel.Name = "congViecLabel";
            congViecLabel.Size = new System.Drawing.Size(72, 16);
            congViecLabel.TabIndex = 10;
            congViecLabel.Text = "Cong Viec:";
            // 
            // congViecTextEdit
            // 
            this.congViecTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsYTA, "CongViec", true));
            this.congViecTextEdit.Location = new System.Drawing.Point(166, 423);
            this.congViecTextEdit.MenuManager = this.barManager1;
            this.congViecTextEdit.Name = "congViecTextEdit";
            this.congViecTextEdit.Size = new System.Drawing.Size(125, 22);
            this.congViecTextEdit.TabIndex = 11;
            // 
            // FormYTa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 598);
            this.Controls.Add(congViecLabel);
            this.Controls.Add(this.congViecTextEdit);
            this.Controls.Add(maYTLabel);
            this.Controls.Add(this.maYTTextEdit);
            this.Controls.Add(this.tHONGTINYTAGridControl);
            this.Controls.Add(this.yTAGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormYTa";
            this.Text = "FormYTa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormYTa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsYTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTYTA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHONGTINYTAGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maYTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.congViecTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
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
        private System.Windows.Forms.BindingSource bdsYTA;
        private HOSPITALDataSet DS;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private HOSPITALDataSetTableAdapters.YTATableAdapter yTATableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl yTAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaYT;
        private DevExpress.XtraGrid.Columns.GridColumn colCongViec;
        private System.Windows.Forms.BindingSource bdsTTYTA;
        private HOSPITALDataSetTableAdapters.THONGTINYTATableAdapter tHONGTINYTATableAdapter;
        private DevExpress.XtraEditors.TextEdit congViecTextEdit;
        private DevExpress.XtraEditors.TextEdit maYTTextEdit;
        private DevExpress.XtraGrid.GridControl tHONGTINYTAGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMaYT1;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colPhai;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
    }
}