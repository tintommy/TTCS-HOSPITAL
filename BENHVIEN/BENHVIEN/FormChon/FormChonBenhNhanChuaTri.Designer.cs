namespace BENHVIEN
{
    partial class FormChonBenhNhanChuaTri
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
            this.SP_ChonBenhNhanChuaTriBDS = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDS = new BENHVIEN.HOSPITALDataSet();
            this.SP_ChonBenhNhanChuaTriTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.SP_ChonBenhNhanChuaTriTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaBacSiTheoDoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChonBenhNhanChuaTri = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ChonBenhNhanChuaTriBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChonBenhNhanChuaTri)).BeginInit();
            this.SuspendLayout();
            // 
            // SP_ChonBenhNhanChuaTriBDS
            // 
            this.SP_ChonBenhNhanChuaTriBDS.DataMember = "SP_ChonBenhNhanChuaTri";
            this.SP_ChonBenhNhanChuaTriBDS.DataSource = this.HospitalDS;
            // 
            // HospitalDS
            // 
            this.HospitalDS.DataSetName = "HOSPITALDataSet";
            this.HospitalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_ChonBenhNhanChuaTriTableAdapter
            // 
            this.SP_ChonBenhNhanChuaTriTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Chữa trị cho bệnh nhân này";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(444, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Trở về";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaBenhNhan,
            this.colHOTEN,
            this.colNgaySinh,
            this.colMaLoai,
            this.colMaBacSiTheoDoi});
            this.gridView1.DetailHeight = 546;
            this.gridView1.GridControl = this.gcChonBenhNhanChuaTri;
            this.gridView1.Name = "gridView1";
            // 
            // colMaBenhNhan
            // 
            this.colMaBenhNhan.FieldName = "MaBenhNhan";
            this.colMaBenhNhan.MinWidth = 39;
            this.colMaBenhNhan.Name = "colMaBenhNhan";
            this.colMaBenhNhan.OptionsColumn.ReadOnly = true;
            this.colMaBenhNhan.Visible = true;
            this.colMaBenhNhan.VisibleIndex = 0;
            this.colMaBenhNhan.Width = 146;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 39;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 146;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 39;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.OptionsColumn.ReadOnly = true;
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            this.colNgaySinh.Width = 146;
            // 
            // colMaLoai
            // 
            this.colMaLoai.FieldName = "MaLoai";
            this.colMaLoai.MinWidth = 39;
            this.colMaLoai.Name = "colMaLoai";
            this.colMaLoai.OptionsColumn.ReadOnly = true;
            this.colMaLoai.Visible = true;
            this.colMaLoai.VisibleIndex = 3;
            this.colMaLoai.Width = 146;
            // 
            // colMaBacSiTheoDoi
            // 
            this.colMaBacSiTheoDoi.FieldName = "MaBacSiTheoDoi";
            this.colMaBacSiTheoDoi.MinWidth = 39;
            this.colMaBacSiTheoDoi.Name = "colMaBacSiTheoDoi";
            this.colMaBacSiTheoDoi.OptionsColumn.ReadOnly = true;
            this.colMaBacSiTheoDoi.Visible = true;
            this.colMaBacSiTheoDoi.VisibleIndex = 4;
            this.colMaBacSiTheoDoi.Width = 146;
            // 
            // gcChonBenhNhanChuaTri
            // 
            this.gcChonBenhNhanChuaTri.DataSource = this.SP_ChonBenhNhanChuaTriBDS;
            this.gcChonBenhNhanChuaTri.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcChonBenhNhanChuaTri.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcChonBenhNhanChuaTri.Location = new System.Drawing.Point(0, 0);
            this.gcChonBenhNhanChuaTri.MainView = this.gridView1;
            this.gcChonBenhNhanChuaTri.Margin = new System.Windows.Forms.Padding(6);
            this.gcChonBenhNhanChuaTri.Name = "gcChonBenhNhanChuaTri";
            this.gcChonBenhNhanChuaTri.Size = new System.Drawing.Size(757, 312);
            this.gcChonBenhNhanChuaTri.TabIndex = 0;
            this.gcChonBenhNhanChuaTri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // FormChonBenhNhanChuaTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gcChonBenhNhanChuaTri);
            this.Name = "FormChonBenhNhanChuaTri";
            this.Text = "FormChonBenhNhanChuaTri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChonBenhNhanChuaTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SP_ChonBenhNhanChuaTriBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChonBenhNhanChuaTri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HOSPITALDataSet HospitalDS;
        private System.Windows.Forms.BindingSource SP_ChonBenhNhanChuaTriBDS;
        private HOSPITALDataSetTableAdapters.SP_ChonBenhNhanChuaTriTableAdapter SP_ChonBenhNhanChuaTriTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBenhNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaBacSiTheoDoi;
        private DevExpress.XtraGrid.GridControl gcChonBenhNhanChuaTri;
    }
}