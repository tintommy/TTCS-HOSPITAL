namespace BENHVIEN
{
    partial class FormTaoTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdYTT = new System.Windows.Forms.RadioButton();
            this.rdBS = new System.Windows.Forms.RadioButton();
            this.rdYT = new System.Windows.Forms.RadioButton();
            this.txtYTT = new DevExpress.XtraEditors.TextEdit();
            this.txtBS = new DevExpress.XtraEditors.TextEdit();
            this.txtYT = new DevExpress.XtraEditors.TextEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPASS2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLOGIN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.loginnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_DS_TaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOSPITALDataSet = new BENHVIEN.HOSPITALDataSet();
            this.tableAdapterManager = new BENHVIEN.HOSPITALDataSetTableAdapters.TableAdapterManager();
            this.v_DS_TaiKhoanTableAdapter = new BENHVIEN.HOSPITALDataSetTableAdapters.V_DS_TaiKhoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtYTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYT.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_TaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(821, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(641, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vai trò:";
            // 
            // rdYTT
            // 
            this.rdYTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdYTT.AutoSize = true;
            this.rdYTT.Checked = true;
            this.rdYTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdYTT.Location = new System.Drawing.Point(804, 128);
            this.rdYTT.Name = "rdYTT";
            this.rdYTT.Size = new System.Drawing.Size(111, 24);
            this.rdYTT.TabIndex = 2;
            this.rdYTT.TabStop = true;
            this.rdYTT.Text = "Y tá trưởng";
            this.rdYTT.UseVisualStyleBackColor = true;
            // 
            // rdBS
            // 
            this.rdBS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdBS.AutoSize = true;
            this.rdBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBS.Location = new System.Drawing.Point(804, 174);
            this.rdBS.Name = "rdBS";
            this.rdBS.Size = new System.Drawing.Size(80, 24);
            this.rdBS.TabIndex = 3;
            this.rdBS.Text = "Bác Sĩ";
            this.rdBS.UseVisualStyleBackColor = true;
            // 
            // rdYT
            // 
            this.rdYT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdYT.AutoSize = true;
            this.rdYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdYT.Location = new System.Drawing.Point(804, 222);
            this.rdYT.Name = "rdYT";
            this.rdYT.Size = new System.Drawing.Size(64, 24);
            this.rdYT.TabIndex = 4;
            this.rdYT.Text = "Y tá ";
            this.rdYT.UseVisualStyleBackColor = true;
            // 
            // txtYTT
            // 
            this.txtYTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYTT.Enabled = false;
            this.txtYTT.Location = new System.Drawing.Point(977, 130);
            this.txtYTT.Name = "txtYTT";
            this.txtYTT.Size = new System.Drawing.Size(144, 22);
            this.txtYTT.TabIndex = 5;
            // 
            // txtBS
            // 
            this.txtBS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBS.Enabled = false;
            this.txtBS.Location = new System.Drawing.Point(977, 176);
            this.txtBS.Name = "txtBS";
            this.txtBS.Size = new System.Drawing.Size(144, 22);
            this.txtBS.TabIndex = 6;
            // 
            // txtYT
            // 
            this.txtYT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYT.Enabled = false;
            this.txtYT.Location = new System.Drawing.Point(977, 224);
            this.txtYT.Name = "txtYT";
            this.txtYT.Size = new System.Drawing.Size(144, 22);
            this.txtYT.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1175, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Chọn YTT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1175, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Chọn BS";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1175, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Chọn YT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtPASS2
            // 
            this.txtPASS2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPASS2.Location = new System.Drawing.Point(804, 410);
            this.txtPASS2.Name = "txtPASS2";
            this.txtPASS2.PasswordChar = '*';
            this.txtPASS2.Size = new System.Drawing.Size(181, 22);
            this.txtPASS2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(554, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Xác Nhận Mật Khẩu:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLOGIN
            // 
            this.txtLOGIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLOGIN.Location = new System.Drawing.Point(804, 289);
            this.txtLOGIN.Name = "txtLOGIN";
            this.txtLOGIN.Size = new System.Drawing.Size(181, 22);
            this.txtLOGIN.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tên Đăng Nhập:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPASS
            // 
            this.txtPASS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPASS.Location = new System.Drawing.Point(804, 352);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.PasswordChar = '*';
            this.txtPASS.Size = new System.Drawing.Size(181, 22);
            this.txtPASS.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật Khẩu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(604, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 38);
            this.button4.TabIndex = 18;
            this.button4.Text = "Huỷ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(369, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 38);
            this.button5.TabIndex = 17;
            this.button5.Text = "Xác Nhận Tạo";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rdYTT);
            this.panel1.Controls.Add(this.rdBS);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPASS2);
            this.panel1.Controls.Add(this.rdYT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtYTT);
            this.panel1.Controls.Add(this.txtLOGIN);
            this.panel1.Controls.Add(this.txtBS);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtYT);
            this.panel1.Controls.Add(this.txtPASS);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 603);
            this.panel1.TabIndex = 19;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(1270, 397);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(151, 49);
            this.button7.TabIndex = 18;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Lime;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(1270, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 49);
            this.button6.TabIndex = 17;
            this.button6.Text = "Tạo tài khoản";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 100);
            this.panel2.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(556, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(819, 51);
            this.label6.TabIndex = 1;
            this.label6.Text = "DANH SÁCH CÁC TÀI KHOẢN ĐÃ TẠO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1924, 74);
            this.panel3.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.roleNameDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.v_DS_TaiKhoanBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1924, 74);
            this.dataGridView1.TabIndex = 0;
            // 
            // loginnameDataGridViewTextBoxColumn
            // 
            this.loginnameDataGridViewTextBoxColumn.DataPropertyName = "loginname";
            this.loginnameDataGridViewTextBoxColumn.HeaderText = "loginname";
            this.loginnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginnameDataGridViewTextBoxColumn.Name = "loginnameDataGridViewTextBoxColumn";
            this.loginnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "RoleName";
            this.roleNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            this.roleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // v_DS_TaiKhoanBindingSource
            // 
            this.v_DS_TaiKhoanBindingSource.DataMember = "V_DS_TaiKhoan";
            this.v_DS_TaiKhoanBindingSource.DataSource = this.hOSPITALDataSet;
            // 
            // hOSPITALDataSet
            // 
            this.hOSPITALDataSet.DataSetName = "HOSPITALDataSet";
            this.hOSPITALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // v_DS_TaiKhoanTableAdapter
            // 
            this.v_DS_TaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 777);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "FormTaoTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtYTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYT.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_TaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOSPITALDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdYTT;
        private System.Windows.Forms.RadioButton rdBS;
        private System.Windows.Forms.RadioButton rdYT;
        private DevExpress.XtraEditors.TextEdit txtYTT;
        private DevExpress.XtraEditors.TextEdit txtBS;
        private DevExpress.XtraEditors.TextEdit txtYT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtPASS2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLOGIN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HOSPITALDataSet hOSPITALDataSet;
        private System.Windows.Forms.BindingSource v_DS_TaiKhoanBindingSource;
        private HOSPITALDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private HOSPITALDataSetTableAdapters.V_DS_TaiKhoanTableAdapter v_DS_TaiKhoanTableAdapter;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}