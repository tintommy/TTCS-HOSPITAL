using BENHVIEN.FormChon;
using BENHVIEN.Report;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENHVIEN
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {

            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.SP_ChuaTriBenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_ChuaTriBenhNhanTableAdapter.Fill(DS.SP_ChuaTriBenhNhan, Program.maBNCanInHD);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtHoTen_Click(object sender, EventArgs e)
        {
            Form f = Program.formMain.CheckExists(typeof(FormChonBenhNhanInHoaDon));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonBenhNhanInHoaDon form = new FormChonBenhNhanInHoaDon();
                form.ShowDialog();
                txtHoTen.Text = Program.hoTenBNCanInHD;
                this.SP_ChuaTriBenhNhanTableAdapter.Fill(DS.SP_ChuaTriBenhNhan, Program.maBNCanInHD);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)SP_ChuaTriBenhNhanBDS[SP_ChuaTriBenhNhanBDS.Position]);
            int maCTBSCTBN =int.Parse(drv["MaCTBSCTBN"].ToString());
            ReportSLVTDaSuDungChoViecChuaTri report = new ReportSLVTDaSuDungChoViecChuaTri(maCTBSCTBN);
            report.xrLabel2.Text = maCTBSCTBN.ToString();

            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void txtHoTen_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
