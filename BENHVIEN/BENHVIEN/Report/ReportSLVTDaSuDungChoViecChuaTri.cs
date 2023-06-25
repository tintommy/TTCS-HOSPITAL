using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BENHVIEN.Report
{
    public partial class ReportSLVTDaSuDungChoViecChuaTri : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportSLVTDaSuDungChoViecChuaTri()
        {
            InitializeComponent();
        }
        public ReportSLVTDaSuDungChoViecChuaTri(int ma)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = ma;
            this.sqlDataSource1.Queries[1].Parameters[0].Value = ma;
            this.sqlDataSource1.Fill();
        }

    }
}
