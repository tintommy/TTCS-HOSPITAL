using BENHVIEN.FormChon;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENHVIEN.Report
{
    public partial class FormReportBenhNhan : Form
    {
        int namNgoai;
        int thangNgoai;
        int namThangNgoai;

        int namNoi;
        int thangNoi;
        int namThangNoi;
        string tenKhu ="";
        string soKhu;

        public FormReportBenhNhan()
        {
            InitializeComponent();
        }

        private void FormReportBenhNhan_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);

            for (int i = 1; i <= 12; i++)
            {
                cmbTHANGTK.Items.Add(i);
                cmbTHANGNOI.Items.Add(i);
                
            }

            int currentYear = DateTime.Now.Year;
            for (int  year = currentYear; year >= 2000; year--)
            {
                cmbNAMTK0.Items.Add(year);
                cmbNAMCUATHANGNOI.Items.Add(year);
            }
            for (int year = currentYear; year >= 2000; year--)
            {
                cmbNAMTK.Items.Add(year);
                cmbNAMNOI.Items.Add(year);
                
            }



            cmbTHANGTK.SelectedIndex = 0;
            cmbNAMTK0.SelectedIndex = 0;
            cmbNAMTK.SelectedIndex = 0;
            cmbTHANGNOI.SelectedIndex = 0;
            cmbNAMCUATHANGNOI.SelectedIndex = 0;
            cmbNAMNOI.SelectedIndex = 0;
        }

        private void cmbTHANGTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            thangNgoai = Convert.ToInt32(cmbTHANGTK.Text);
        }

        private void cmbNAMTK0_SelectedIndexChanged(object sender, EventArgs e)
        {
            namThangNgoai= Convert.ToInt32(cmbNAMTK0.Text);
        }

        private void cmbNAMTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            namNgoai = Convert.ToInt32(cmbNAMTK.Text);
        }


        private void cmbTHANGNOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            thangNoi = Convert.ToInt32(cmbTHANGNOI.Text);
        }

        private void cmbNAMCUATHANGNOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            namThangNoi = Convert.ToInt32(cmbNAMCUATHANGNOI.Text);
        }

        private void cmbNAMNOI_SelectedIndexChanged(object sender, EventArgs e)
        {
            namNoi = Convert.ToInt32(cmbNAMNOI.Text);
        }

   



        private void button1_Click(object sender, EventArgs e)
        {
            if (rdNGOAITHEOTHANG.Checked == true)
            {

                ReportBNNgoaiTruTheoThang report = new ReportBNNgoaiTruTheoThang( 0,thangNgoai, namThangNgoai);
               
                report.thang.Text = thangNgoai.ToString();
                report.nam.Text = namThangNgoai.ToString();
  
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();


            }
            else
            {
                ReportBNNgoaiTruTheoNam report = new ReportBNNgoaiTruTheoNam(0,namNgoai);
                report.nam.Text = namNgoai.ToString();
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rdNGOAITHEOTHANG.Checked == true)
            {

                try
                {
                    ReportBNNgoaiTruTheoThang report = new ReportBNNgoaiTruTheoThang(0, thangNgoai, namThangNgoai);

                    report.thang.Text = thangNgoai.ToString();
                    report.nam.Text = namThangNgoai.ToString();
                    if (File.Exists(@"D:\ReportBNNgoaiTruTheoThang.pdf"))
                    {
                        DialogResult dr = MessageBox.Show("File ReportBNNgoaiTruTheoThang.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            report.ExportToPdf(@"D:\ReportBNNgoaiTruTheoThang.pdf");
                            MessageBox.Show("File ReportBNNgoaiTruTheoThang.pdf đã được ghi thành công tại ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        report.ExportToPdf(@"D:\ReportBNNgoaiTruTheoThang.pdf");
                        MessageBox.Show("File ReportBNNgoaiTruTheoThang.pdf đã được ghi thành công tại ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Vui lòng đóng file ReportBNNgoaiTruTheoThang.pdf",
                        "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }


            }
            else
            {
                try
                {
                    ReportBNNgoaiTruTheoNam report = new ReportBNNgoaiTruTheoNam(0, namNgoai);
                    report.nam.Text = namNgoai.ToString();
                    if (File.Exists(@"D:\ReportBNNgoaiTruTheoNam.pdf"))
                    {
                        DialogResult dr = MessageBox.Show("File ReportBNNgoaiTruTheoNam.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            report.ExportToPdf(@"D:\ReportBNNgoaiTruTheoNam.pdf");
                            MessageBox.Show("File ReportBNNgoaiTruTheoNam.pdf đã được ghi thành công tại ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        report.ExportToPdf(@"D:\ReportBNNgoaiTruTheoNam.pdf");
                        MessageBox.Show("File ReportBNNgoaiTruTheoNam.pdf đã được ghi thành công tại ổ D",
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Vui lòng đóng file ReportBNNgoaiTruTheoNam.pdf",
                        "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void kHUCHUATRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUCHUATRIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkKHU.Checked)
            {
                if (rdNOITHEOTHANG.Checked == true)
                {

                    ReportBNNoiTruTheoThang report = new ReportBNNoiTruTheoThang(1, thangNoi, namThangNoi);

                    report.thang.Text = thangNgoai.ToString();
                    report.nam.Text = namThangNgoai.ToString();

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();


                }
                else
                {
                    ReportBNNoiTruTheoNam report = new ReportBNNoiTruTheoNam(1, namNoi);
                    report.nam.Text = namNgoai.ToString();
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();
                }
            }
            else {
                if (txtKHU.Text == "")
                {
                    MessageBox.Show("Hãy chọn khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rdNOITHEOTHANG.Checked == true)
                {

                    ReportBNNoiTruTheoThangTheoKhu report = new ReportBNNoiTruTheoThangTheoKhu(thangNoi, namThangNoi,soKhu);

                    report.thang.Text = thangNgoai.ToString();
                    report.nam.Text = namThangNgoai.ToString();
                    report.khu.Text = Program.tenKhu.ToString();
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();


                }
                else
                {
                    ReportBNNoiTruTheoNamTheoKhu report = new ReportBNNoiTruTheoNamTheoKhu(namNoi, soKhu);

                    report.khu.Text = Program.tenKhu.ToString();
                    report.nam.Text = namNoi.ToString();
                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkKHU.Checked)
            {
                if (rdNOITHEOTHANG.Checked == true)
                {



                    try
                    {
                        ReportBNNoiTruTheoThang report = new ReportBNNoiTruTheoThang(1, thangNoi, namThangNoi);

                        report.thang.Text = thangNgoai.ToString();
                        report.nam.Text = namThangNgoai.ToString();
                        if (File.Exists(@"D:\ReportBNNoiTruTheoThang.pdf"))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoThang.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(@"D:\ReportBNNoiTruTheoThang.pdf");
                                MessageBox.Show("File ReportBNNoiTruTheoThang.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(@"D:\ReportBNNoiTruTheoThang.pdf");
                            MessageBox.Show("File ReportBNNoiTruTheoThang.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Vui lòng đóng file ReportBNNoiTruTheoThang.pdf",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }



                }
                else
                {
                    try
                    {
                        ReportBNNoiTruTheoNam report = new ReportBNNoiTruTheoNam(1, namNoi);
                        report.nam.Text = namNgoai.ToString();
                        if (File.Exists(@"D:\ReportBNNoiTruTheoNam.pdf"))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoNam.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(@"D:\ReportBNNoiTruTheoNam.pdf");
                                MessageBox.Show("File ReportBNNoiTruTheoNam.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(@"D:\ReportBNNoiTruTheoNam.pdf");
                            MessageBox.Show("File ReportBNNoiTruTheoNam.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Vui lòng đóng file ReportBNNoiTruTheoNam.pdf",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            else
            {
                if (txtKHU.Text == "")
                {
                    MessageBox.Show("Hãy chọn khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (rdNOITHEOTHANG.Checked == true)
                {

                   
                    try
                    {
                        ReportBNNoiTruTheoThangTheoKhu report = new ReportBNNoiTruTheoThangTheoKhu(thangNoi, namThangNoi, soKhu);

                        report.thang.Text = thangNgoai.ToString();
                        report.nam.Text = namThangNgoai.ToString();
                        report.khu.Text = Program.tenKhu.ToString();
                        if (File.Exists(@"D:\ReportBNNoiTruTheoThangTheoKhu.pdf"))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoThangTheoKhu.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(@"D:\ReportBNNoiTruTheoThangTheoKhu.pdf");
                                MessageBox.Show("File ReportBNNoiTruTheoThangTheoKhu.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(@"D:\ReportBNNoiTruTheoThangTheoKhu.pdf");
                            MessageBox.Show("File ReportBNNoiTruTheoThangTheoKhu.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Vui lòng đóng file ReportBNNoiTruTheoThangTheoKhu.pdf",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }


                }
                else
                {
                  
                    try
                    {
                        ReportBNNoiTruTheoNamTheoKhu report = new ReportBNNoiTruTheoNamTheoKhu(namNoi, soKhu);

                        report.khu.Text = Program.tenKhu.ToString();
                        report.nam.Text = namNoi.ToString();
                        if (File.Exists(@"D:\ReportBNNoiTruTheoNamTheoKhu.pdf"))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoNamTheoKhu.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(@"D:\ReportBNNoiTruTheoNamTheoKhu.pdf");
                                MessageBox.Show("File ReportBNNoiTruTheoNamTheoKhu.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(@"D:\ReportBNNoiTruTheoNamTheoKhu.pdf");
                            MessageBox.Show("File ReportBNNoiTruTheoNamTheoKhu.pdf đã được ghi thành công tại ổ D",
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Vui lòng đóng file ReportBNNoiTruTheoNamTheoKhu.pdf",
                            "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        return;
                    }
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new FormChonKhu();
            f.ShowDialog();
            txtKHU.Text = Program.tenKhu;
            soKhu = Program.maKhu;
        }
    }
}
