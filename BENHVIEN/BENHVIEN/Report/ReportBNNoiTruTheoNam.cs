using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace BENHVIEN.Report
{
    public partial class ReportBNNoiTruTheoNam : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBNNoiTruTheoNam(int loai, int nam)
        {
           
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = loai;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nam;
            this.sqlDataSource1.Fill();
        }

    }
}
