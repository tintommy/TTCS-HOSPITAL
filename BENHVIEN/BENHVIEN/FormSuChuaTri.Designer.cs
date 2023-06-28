namespace BENHVIEN
{
    partial class FormSuChuaTri
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
            System.Windows.Forms.Label maSuChuaTriLabel;
            System.Windows.Forms.Label tenSuChuaTriLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuChuaTri));
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.SUCHUATRI_BDS = new System.Windows.Forms.BindingSource(this.components);
            this.HOSPITAL_DS = new BENHVIEN.HOSPITALDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSuChuaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSuChuaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SUCHUATRITableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.SUCHUATRITableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.CT_BACSI_CHUATRI_BENHNHANTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.CT_BACSI_CHUATRI_BENHNHANTableAdapter();
            this.txtMaSCT = new DevExpress.XtraEditors.TextEdit();
            this.txtTenSCT = new DevExpress.XtraEditors.TextEdit();
            this.CT_BACSI_CHUATRI_BENHNHAN_BDS = new System.Windows.Forms.BindingSource(this.components);
            maSuChuaTriLabel = new System.Windows.Forms.Label();
            tenSuChuaTriLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUCHUATRI_BDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOSPITAL_DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_BACSI_CHUATRI_BENHNHAN_BDS)).BeginInit();
            this.SuspendLayout();
            // 
            // maSuChuaTriLabel
            // 
            maSuChuaTriLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            maSuChuaTriLabel.AutoSize = true;
            maSuChuaTriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            maSuChuaTriLabel.Location = new System.Drawing.Point(253, 467);
            maSuChuaTriLabel.Name = "maSuChuaTriLabel";
            maSuChuaTriLabel.Size = new System.Drawing.Size(134, 25);
            maSuChuaTriLabel.TabIndex = 5;
            maSuChuaTriLabel.Text = "Mã sự chữa trị";
            // 
            // tenSuChuaTriLabel
            // 
            tenSuChuaTriLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            tenSuChuaTriLabel.AutoSize = true;
            tenSuChuaTriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tenSuChuaTriLabel.Location = new System.Drawing.Point(244, 534);
            tenSuChuaTriLabel.Name = "tenSuChuaTriLabel";
            tenSuChuaTriLabel.Size = new System.Drawing.Size(141, 25);
            tenSuChuaTriLabel.TabIndex = 7;
            tenSuChuaTriLabel.Text = "Tên sự chữa trị";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1264, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 643);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1264, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 613);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1264, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 613);
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SUCHUATRI_BDS;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 30);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1264, 361);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SUCHUATRI_BDS
            // 
            this.SUCHUATRI_BDS.DataMember = "SUCHUATRI";
            this.SUCHUATRI_BDS.DataSource = this.HOSPITAL_DS;
            // 
            // HOSPITAL_DS
            // 
            this.HOSPITAL_DS.DataSetName = "HOSPITALDataSet";
            this.HOSPITAL_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSuChuaTri,
            this.colTenSuChuaTri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colMaSuChuaTri
            // 
            this.colMaSuChuaTri.FieldName = "MaSuChuaTri";
            this.colMaSuChuaTri.MinWidth = 25;
            this.colMaSuChuaTri.Name = "colMaSuChuaTri";
            this.colMaSuChuaTri.Visible = true;
            this.colMaSuChuaTri.VisibleIndex = 0;
            this.colMaSuChuaTri.Width = 219;
            // 
            // colTenSuChuaTri
            // 
            this.colTenSuChuaTri.FieldName = "TenSuChuaTri";
            this.colTenSuChuaTri.MinWidth = 25;
            this.colTenSuChuaTri.Name = "colTenSuChuaTri";
            this.colTenSuChuaTri.Visible = true;
            this.colTenSuChuaTri.VisibleIndex = 1;
            this.colTenSuChuaTri.Width = 1015;
            // 
            // SUCHUATRITableAdapter
            // 
            this.SUCHUATRITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = null;
            this.tableAdapterManager.CT_BACSI_CHUATRI_BENHNHANTableAdapter = this.CT_BACSI_CHUATRI_BENHNHANTableAdapter;
            this.tableAdapterManager.CT_BENHNHAN_GIUONGTableAdapter = null;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.CT_NV_KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.GIUONGBENHTableAdapter = null;
            this.tableAdapterManager.KHUCHUATRITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = this.SUCHUATRITableAdapter;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // CT_BACSI_CHUATRI_BENHNHANTableAdapter
            // 
            this.CT_BACSI_CHUATRI_BENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // txtMaSCT
            // 
            this.txtMaSCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaSCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SUCHUATRI_BDS, "MaSuChuaTri", true));
            this.txtMaSCT.Enabled = false;
            this.txtMaSCT.Location = new System.Drawing.Point(474, 464);
            this.txtMaSCT.MenuManager = this.barManager1;
            this.txtMaSCT.Name = "txtMaSCT";
            this.txtMaSCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSCT.Properties.Appearance.Options.UseFont = true;
            this.txtMaSCT.Size = new System.Drawing.Size(234, 30);
            this.txtMaSCT.TabIndex = 6;
            // 
            // txtTenSCT
            // 
            this.txtTenSCT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.SUCHUATRI_BDS, "TenSuChuaTri", true));
            this.txtTenSCT.Location = new System.Drawing.Point(474, 528);
            this.txtTenSCT.MenuManager = this.barManager1;
            this.txtTenSCT.Name = "txtTenSCT";
            this.txtTenSCT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSCT.Properties.Appearance.Options.UseFont = true;
            this.txtTenSCT.Size = new System.Drawing.Size(624, 30);
            this.txtTenSCT.TabIndex = 8;
            // 
            // CT_BACSI_CHUATRI_BENHNHAN_BDS
            // 
            this.CT_BACSI_CHUATRI_BENHNHAN_BDS.DataMember = "FK_MaSuChuaTri_CT_BACSI_CHUATRI_BENHNHAN";
            this.CT_BACSI_CHUATRI_BENHNHAN_BDS.DataSource = this.SUCHUATRI_BDS;
            // 
            // FormSuChuaTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 643);
            this.Controls.Add(tenSuChuaTriLabel);
            this.Controls.Add(this.txtTenSCT);
            this.Controls.Add(maSuChuaTriLabel);
            this.Controls.Add(this.txtMaSCT);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormSuChuaTri";
            this.Text = "FormSuChuaTri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSuChuaTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SUCHUATRI_BDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HOSPITAL_DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CT_BACSI_CHUATRI_BENHNHAN_BDS)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private HOSPITALDataSet HOSPITAL_DS;
        private System.Windows.Forms.BindingSource SUCHUATRI_BDS;
        private HOSPITALDataSetTableAdapters.SUCHUATRITableAdapter SUCHUATRITableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSuChuaTri;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSuChuaTri;
        private DevExpress.XtraEditors.TextEdit txtTenSCT;
        private DevExpress.XtraEditors.TextEdit txtMaSCT;
        private HOSPITALDataSetTableAdapters.CT_BACSI_CHUATRI_BENHNHANTableAdapter CT_BACSI_CHUATRI_BENHNHANTableAdapter;
        private System.Windows.Forms.BindingSource CT_BACSI_CHUATRI_BENHNHAN_BDS;
    }
}