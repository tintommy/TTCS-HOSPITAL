namespace BENHVIEN
{
    partial class FormHoaDon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SP_ChuaTriBenhNhanTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.SP_ChuaTriBenhNhanTableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ChuaTriBenhNhanBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SP_ChuaTriBenhNhanBDS;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(844, 238);
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
            this.colMaBenhNhan.Visible = true;
            this.colMaBenhNhan.VisibleIndex = 2;
            this.colMaBenhNhan.Width = 94;
            // 
            // colMaSuChuaTri
            // 
            this.colMaSuChuaTri.FieldName = "MaSuChuaTri";
            this.colMaSuChuaTri.MinWidth = 25;
            this.colMaSuChuaTri.Name = "colMaSuChuaTri";
            this.colMaSuChuaTri.OptionsColumn.ReadOnly = true;
            this.colMaSuChuaTri.Visible = true;
            this.colMaSuChuaTri.VisibleIndex = 3;
            this.colMaSuChuaTri.Width = 94;
            // 
            // colNgayChuaTri
            // 
            this.colNgayChuaTri.FieldName = "NgayChuaTri";
            this.colNgayChuaTri.MinWidth = 25;
            this.colNgayChuaTri.Name = "colNgayChuaTri";
            this.colNgayChuaTri.OptionsColumn.ReadOnly = true;
            this.colNgayChuaTri.Visible = true;
            this.colNgayChuaTri.VisibleIndex = 4;
            this.colNgayChuaTri.Width = 94;
            // 
            // colThoiGianChuaTri
            // 
            this.colThoiGianChuaTri.FieldName = "ThoiGianChuaTri";
            this.colThoiGianChuaTri.MinWidth = 25;
            this.colThoiGianChuaTri.Name = "colThoiGianChuaTri";
            this.colThoiGianChuaTri.OptionsColumn.ReadOnly = true;
            this.colThoiGianChuaTri.Visible = true;
            this.colThoiGianChuaTri.VisibleIndex = 5;
            this.colThoiGianChuaTri.Width = 94;
            // 
            // colKetQua
            // 
            this.colKetQua.FieldName = "KetQua";
            this.colKetQua.MinWidth = 25;
            this.colKetQua.Name = "colKetQua";
            this.colKetQua.OptionsColumn.ReadOnly = true;
            this.colKetQua.Visible = true;
            this.colKetQua.VisibleIndex = 6;
            this.colKetQua.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 139);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.txtHoTen);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(254, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 42);
            this.panel4.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(86, 16);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Properties.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(238, 22);
            this.txtHoTen.TabIndex = 3;
            this.txtHoTen.EditValueChanged += new System.EventHandler(this.txtHoTen_EditValueChanged);
            this.txtHoTen.Click += new System.EventHandler(this.txtHoTen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anh/Chị:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(844, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "In thông tin hóa đơn cho bệnh nhân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 103);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(288, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(273, 56);
            this.panel5.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 238);
            this.panel3.TabIndex = 3;
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
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_ChuaTriBenhNhanBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}