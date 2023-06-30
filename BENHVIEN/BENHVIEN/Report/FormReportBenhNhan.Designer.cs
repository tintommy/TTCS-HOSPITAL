namespace BENHVIEN.Report
{
    partial class FormReportBenhNhan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbNAMTK = new System.Windows.Forms.ComboBox();
            this.cmbNAMTK0 = new System.Windows.Forms.ComboBox();
            this.cmbTHANGTK = new System.Windows.Forms.ComboBox();
            this.rdNGOAITHEONAM = new System.Windows.Forms.RadioButton();
            this.rdNGOAITHEOTHANG = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.txtKHU = new DevExpress.XtraEditors.TextEdit();
            this.checkKHU = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNAMNOI = new System.Windows.Forms.ComboBox();
            this.rdNOITHEOTHANG = new System.Windows.Forms.RadioButton();
            this.cmbNAMCUATHANGNOI = new System.Windows.Forms.ComboBox();
            this.rdNOITHEONAM = new System.Windows.Forms.RadioButton();
            this.cmbTHANGNOI = new System.Windows.Forms.ComboBox();
            this.DS = new BENHVIEN.HOSPITALDataSet();
            this.kHUCHUATRIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHUCHUATRITableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.KHUCHUATRITableAdapter();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.txtPATH = new DevExpress.XtraEditors.TextEdit();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtPATH2 = new DevExpress.XtraEditors.TextEdit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPATH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPATH2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.txtPATH);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cmbNAMTK);
            this.panel1.Controls.Add(this.cmbNAMTK0);
            this.panel1.Controls.Add(this.cmbTHANGTK);
            this.panel1.Controls.Add(this.rdNGOAITHEONAM);
            this.panel1.Controls.Add(this.rdNGOAITHEOTHANG);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1757, 386);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1025, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xuất File PDF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(793, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Xem Thống Kê";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNAMTK
            // 
            this.cmbNAMTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNAMTK.FormattingEnabled = true;
            this.cmbNAMTK.Location = new System.Drawing.Point(855, 138);
            this.cmbNAMTK.Name = "cmbNAMTK";
            this.cmbNAMTK.Size = new System.Drawing.Size(121, 24);
            this.cmbNAMTK.TabIndex = 5;
            this.cmbNAMTK.SelectedIndexChanged += new System.EventHandler(this.cmbNAMTK_SelectedIndexChanged);
            // 
            // cmbNAMTK0
            // 
            this.cmbNAMTK0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNAMTK0.FormattingEnabled = true;
            this.cmbNAMTK0.Location = new System.Drawing.Point(1010, 94);
            this.cmbNAMTK0.Name = "cmbNAMTK0";
            this.cmbNAMTK0.Size = new System.Drawing.Size(121, 24);
            this.cmbNAMTK0.TabIndex = 4;
            this.cmbNAMTK0.SelectedIndexChanged += new System.EventHandler(this.cmbNAMTK0_SelectedIndexChanged);
            // 
            // cmbTHANGTK
            // 
            this.cmbTHANGTK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTHANGTK.FormattingEnabled = true;
            this.cmbTHANGTK.Location = new System.Drawing.Point(855, 94);
            this.cmbTHANGTK.Name = "cmbTHANGTK";
            this.cmbTHANGTK.Size = new System.Drawing.Size(121, 24);
            this.cmbTHANGTK.TabIndex = 3;
            this.cmbTHANGTK.SelectedIndexChanged += new System.EventHandler(this.cmbTHANGTK_SelectedIndexChanged);
            // 
            // rdNGOAITHEONAM
            // 
            this.rdNGOAITHEONAM.AutoSize = true;
            this.rdNGOAITHEONAM.Location = new System.Drawing.Point(631, 143);
            this.rdNGOAITHEONAM.Name = "rdNGOAITHEONAM";
            this.rdNGOAITHEONAM.Size = new System.Drawing.Size(143, 20);
            this.rdNGOAITHEONAM.TabIndex = 2;
            this.rdNGOAITHEONAM.TabStop = true;
            this.rdNGOAITHEONAM.Text = "Thống kê theo năm";
            this.rdNGOAITHEONAM.UseVisualStyleBackColor = true;
            // 
            // rdNGOAITHEOTHANG
            // 
            this.rdNGOAITHEOTHANG.AutoSize = true;
            this.rdNGOAITHEOTHANG.Location = new System.Drawing.Point(631, 94);
            this.rdNGOAITHEOTHANG.Name = "rdNGOAITHEOTHANG";
            this.rdNGOAITHEOTHANG.Size = new System.Drawing.Size(150, 20);
            this.rdNGOAITHEOTHANG.TabIndex = 1;
            this.rdNGOAITHEOTHANG.TabStop = true;
            this.rdNGOAITHEOTHANG.Text = "Thống kê theo tháng";
            this.rdNGOAITHEOTHANG.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(709, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ BỆNH NHÂN NGOẠI TRÚ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.txtPATH2);
            this.panel2.Controls.Add(this.txtKHU);
            this.panel2.Controls.Add(this.checkKHU);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbNAMNOI);
            this.panel2.Controls.Add(this.rdNOITHEOTHANG);
            this.panel2.Controls.Add(this.cmbNAMCUATHANGNOI);
            this.panel2.Controls.Add(this.rdNOITHEONAM);
            this.panel2.Controls.Add(this.cmbTHANGNOI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1757, 423);
            this.panel2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(1181, 181);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 56);
            this.button5.TabIndex = 18;
            this.button5.Text = "Chọn Khu";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtKHU
            // 
            this.txtKHU.Enabled = false;
            this.txtKHU.Location = new System.Drawing.Point(855, 197);
            this.txtKHU.Name = "txtKHU";
            this.txtKHU.Size = new System.Drawing.Size(276, 22);
            this.txtKHU.TabIndex = 17;
            // 
            // checkKHU
            // 
            this.checkKHU.AutoSize = true;
            this.checkKHU.Location = new System.Drawing.Point(631, 197);
            this.checkKHU.Name = "checkKHU";
            this.checkKHU.Size = new System.Drawing.Size(139, 20);
            this.checkKHU.TabIndex = 16;
            this.checkKHU.Text = "Thống kê theo khu";
            this.checkKHU.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(1025, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 48);
            this.button3.TabIndex = 15;
            this.button3.Text = "Xuất File PDF";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(793, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 48);
            this.button4.TabIndex = 14;
            this.button4.Text = "Xem Thống Kê";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(709, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "THỐNG KÊ BỆNH NHÂN NỘI TRÚ";
            // 
            // cmbNAMNOI
            // 
            this.cmbNAMNOI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNAMNOI.FormattingEnabled = true;
            this.cmbNAMNOI.Location = new System.Drawing.Point(855, 133);
            this.cmbNAMNOI.Name = "cmbNAMNOI";
            this.cmbNAMNOI.Size = new System.Drawing.Size(121, 24);
            this.cmbNAMNOI.TabIndex = 13;
            this.cmbNAMNOI.SelectedIndexChanged += new System.EventHandler(this.cmbNAMNOI_SelectedIndexChanged);
            // 
            // rdNOITHEOTHANG
            // 
            this.rdNOITHEOTHANG.AutoSize = true;
            this.rdNOITHEOTHANG.Checked = true;
            this.rdNOITHEOTHANG.Location = new System.Drawing.Point(631, 89);
            this.rdNOITHEOTHANG.Name = "rdNOITHEOTHANG";
            this.rdNOITHEOTHANG.Size = new System.Drawing.Size(150, 20);
            this.rdNOITHEOTHANG.TabIndex = 9;
            this.rdNOITHEOTHANG.TabStop = true;
            this.rdNOITHEOTHANG.Text = "Thống kê theo tháng";
            this.rdNOITHEOTHANG.UseVisualStyleBackColor = true;
            // 
            // cmbNAMCUATHANGNOI
            // 
            this.cmbNAMCUATHANGNOI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNAMCUATHANGNOI.FormattingEnabled = true;
            this.cmbNAMCUATHANGNOI.Location = new System.Drawing.Point(1010, 89);
            this.cmbNAMCUATHANGNOI.Name = "cmbNAMCUATHANGNOI";
            this.cmbNAMCUATHANGNOI.Size = new System.Drawing.Size(121, 24);
            this.cmbNAMCUATHANGNOI.TabIndex = 12;
            this.cmbNAMCUATHANGNOI.SelectedIndexChanged += new System.EventHandler(this.cmbNAMCUATHANGNOI_SelectedIndexChanged);
            // 
            // rdNOITHEONAM
            // 
            this.rdNOITHEONAM.AutoSize = true;
            this.rdNOITHEONAM.Location = new System.Drawing.Point(631, 138);
            this.rdNOITHEONAM.Name = "rdNOITHEONAM";
            this.rdNOITHEONAM.Size = new System.Drawing.Size(143, 20);
            this.rdNOITHEONAM.TabIndex = 10;
            this.rdNOITHEONAM.TabStop = true;
            this.rdNOITHEONAM.Text = "Thống kê theo năm";
            this.rdNOITHEONAM.UseVisualStyleBackColor = true;
            // 
            // cmbTHANGNOI
            // 
            this.cmbTHANGNOI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTHANGNOI.FormattingEnabled = true;
            this.cmbTHANGNOI.Location = new System.Drawing.Point(855, 89);
            this.cmbTHANGNOI.Name = "cmbTHANGNOI";
            this.cmbTHANGNOI.Size = new System.Drawing.Size(121, 24);
            this.cmbTHANGNOI.TabIndex = 11;
            this.cmbTHANGNOI.SelectedIndexChanged += new System.EventHandler(this.cmbTHANGNOI_SelectedIndexChanged);
            // 
            // DS
            // 
            this.DS.DataSetName = "HOSPITALDataSet";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHUCHUATRIBindingSource
            // 
            this.kHUCHUATRIBindingSource.DataMember = "KHUCHUATRI";
            this.kHUCHUATRIBindingSource.DataSource = this.DS;
            // 
            // kHUCHUATRITableAdapter
            // 
            this.kHUCHUATRITableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHUCHUATRITableAdapter = this.kHUCHUATRITableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SUCHUATRITableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VATTUTableAdapter = null;
            this.tableAdapterManager.YTATableAdapter = null;
            // 
            // txtPATH
            // 
            this.txtPATH.Location = new System.Drawing.Point(730, 321);
            this.txtPATH.Name = "txtPATH";
            this.txtPATH.Size = new System.Drawing.Size(373, 22);
            this.txtPATH.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1141, 315);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 34);
            this.button6.TabIndex = 9;
            this.button6.Text = "chọn thư mục";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1141, 354);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "chọn thư mục";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtPATH2
            // 
            this.txtPATH2.Location = new System.Drawing.Point(730, 360);
            this.txtPATH2.Name = "txtPATH2";
            this.txtPATH2.Size = new System.Drawing.Size(373, 22);
            this.txtPATH2.TabIndex = 10;
            // 
            // FormReportBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1757, 809);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormReportBenhNhan";
            this.Text = "FormReportBenhNhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormReportBenhNhan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKHU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUCHUATRIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPATH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPATH2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNAMTK;
        private System.Windows.Forms.ComboBox cmbNAMTK0;
        private System.Windows.Forms.ComboBox cmbTHANGTK;
        private System.Windows.Forms.RadioButton rdNGOAITHEONAM;
        private System.Windows.Forms.RadioButton rdNGOAITHEOTHANG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNAMNOI;
        private System.Windows.Forms.RadioButton rdNOITHEOTHANG;
        private System.Windows.Forms.ComboBox cmbNAMCUATHANGNOI;
        private System.Windows.Forms.RadioButton rdNOITHEONAM;
        private System.Windows.Forms.ComboBox cmbTHANGNOI;
        private System.Windows.Forms.CheckBox checkKHU;
        private HOSPITALDataSet DS;
        private System.Windows.Forms.BindingSource kHUCHUATRIBindingSource;
        private HOSPITALDataSetTableAdapters.KHUCHUATRITableAdapter kHUCHUATRITableAdapter;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button5;
        private DevExpress.XtraEditors.TextEdit txtKHU;
        private System.Windows.Forms.Button button6;
        private DevExpress.XtraEditors.TextEdit txtPATH;
        private System.Windows.Forms.Button button7;
        private DevExpress.XtraEditors.TextEdit txtPATH2;
    }
}