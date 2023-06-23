namespace BENHVIEN.FormChon
{
    partial class FormChonSuChuaTri
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
            this.SuChuatriBDS = new System.Windows.Forms.BindingSource(this.components);
            this.HospitalDS = new BENHVIEN.HOSPITALDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSuChuaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSuChuaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuChuaTriTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.SUCHUATRITableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuChuatriBDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.SuChuatriBDS;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(813, 339);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // SuChuatriBDS
            // 
            this.SuChuatriBDS.DataMember = "SUCHUATRI";
            this.SuChuatriBDS.DataSource = this.HospitalDS;
            // 
            // HospitalDS
            // 
            this.HospitalDS.DataSetName = "HOSPITALDataSet";
            this.HospitalDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSuChuaTri,
            this.colTenSuChuaTri});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaSuChuaTri
            // 
            this.colMaSuChuaTri.FieldName = "MaSuChuaTri";
            this.colMaSuChuaTri.MinWidth = 25;
            this.colMaSuChuaTri.Name = "colMaSuChuaTri";
            this.colMaSuChuaTri.Visible = true;
            this.colMaSuChuaTri.VisibleIndex = 0;
            this.colMaSuChuaTri.Width = 94;
            // 
            // colTenSuChuaTri
            // 
            this.colTenSuChuaTri.FieldName = "TenSuChuaTri";
            this.colTenSuChuaTri.MinWidth = 25;
            this.colTenSuChuaTri.Name = "colTenSuChuaTri";
            this.colTenSuChuaTri.Visible = true;
            this.colTenSuChuaTri.VisibleIndex = 1;
            this.colTenSuChuaTri.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SuChuaTriTableAdapter
            // 
            this.SuChuaTriTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SUCHUATRITableAdapter = this.SuChuaTriTableAdapter;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // FormChonSuChuaTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormChonSuChuaTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonSuChuaTri";
            this.Load += new System.EventHandler(this.FormChonSuChuaTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuChuatriBDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private HOSPITALDataSet HospitalDS;
        private System.Windows.Forms.BindingSource SuChuatriBDS;
        private HOSPITALDataSetTableAdapters.SUCHUATRITableAdapter SuChuaTriTableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSuChuaTri;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSuChuaTri;
    }
}