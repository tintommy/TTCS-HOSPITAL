using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BENHVIEN.Report
{
    public partial class ReportBNNoiTruTheoThangTheoKhu : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBNNoiTruTheoThangTheoKhu(int thang, int nam,string khu)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = thang;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nam;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = khu;

            this.sqlDataSource1.Fill();
        }

    }
}
