using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BENHVIEN.Report
{
    public partial class ReportBNNgoaiTruTheoThang : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBNNgoaiTruTheoThang(int loai,int thangNgoai,int namThangNgoai)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = loai;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = thangNgoai;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = namThangNgoai;

            this.sqlDataSource1.Fill();
        }

    }
}
