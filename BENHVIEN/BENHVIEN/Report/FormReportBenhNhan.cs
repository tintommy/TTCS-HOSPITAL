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
            if (txtPATH.Text == "") {
                DialogResult dr = MessageBox.Show("Hãy chọn nơi lưu file",
                               "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdNGOAITHEOTHANG.Checked == true)
            {
                String fileName = txtPATH.Text.ToString() + "\\ReportBNNgoaiTruTheoThang.pdf";
                try
                {
                    ReportBNNgoaiTruTheoThang report = new ReportBNNgoaiTruTheoThang(0, thangNgoai, namThangNgoai);

                    report.thang.Text = thangNgoai.ToString();
                    report.nam.Text = namThangNgoai.ToString();
                    if (File.Exists(fileName))
                    {
                        DialogResult dr = MessageBox.Show("File ReportBNNgoaiTruTheoThang.pdf đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            report.ExportToPdf(fileName);
                            MessageBox.Show("File ReportBNNgoaiTruTheoThang.pdf đã được ghi thành công tại"+ txtPATH.Text.ToString(),
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        report.ExportToPdf(fileName);
                        MessageBox.Show("File ReportBNNgoaiTruTheoThang.pdf đã được ghi thành công tại " + txtPATH.Text.ToString(),
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
                String fileName = txtPATH.Text.ToString() + "\\ReportBNNgoaiTruTheoNam.pdf";
                try
                {
                    ReportBNNgoaiTruTheoNam report = new ReportBNNgoaiTruTheoNam(0, namNgoai);
                    report.nam.Text = namNgoai.ToString();
                    if (File.Exists(fileName))
                    {
                        DialogResult dr = MessageBox.Show("File ReportBNNgoaiTruTheoNam.pdf đã có!\nBạn có muốn tạo lại?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            report.ExportToPdf(fileName);
                            MessageBox.Show("File ReportBNNgoaiTruTheoNam.pdf đã được ghi thành công tại" + txtPATH.Text.ToString(),
                    "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        report.ExportToPdf(fileName);
                        MessageBox.Show("File ReportBNNgoaiTruTheoNam.pdf đã được ghi thành công tại "+txtPATH.Text.ToString(),
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

                    report.thang.Text = thangNoi.ToString();
                    report.nam.Text = namThangNoi.ToString();

                    ReportPrintTool printTool = new ReportPrintTool(report);
                    printTool.ShowPreviewDialog();


                }
                else
                {
                    ReportBNNoiTruTheoNam report = new ReportBNNoiTruTheoNam(1, namNoi);
                    report.nam.Text = namNoi.ToString();
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

                    report.thang.Text = thangNoi.ToString();
                    report.nam.Text = namThangNoi.ToString();
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
            if (txtPATH2.Text == "")
            {
                DialogResult dr = MessageBox.Show("Hãy chọn nơi lưu file",
                               "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                if (!checkKHU.Checked)
            {
                if (rdNOITHEOTHANG.Checked == true)
                {

                    String fileName = txtPATH2.Text.ToString() + "\\ReportBNNoiTruTheoThang.pdf";

                    try
                    {
                        ReportBNNoiTruTheoThang report = new ReportBNNoiTruTheoThang(1, thangNoi, namThangNoi);

                        report.thang.Text = thangNoi.ToString();
                        report.nam.Text = namThangNoi.ToString();
                        if (File.Exists(fileName))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoThang.pdf đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(fileName);
                                MessageBox.Show("File ReportBNNoiTruTheoThang.pdf đã được ghi thành công tại "+txtPATH2.Text.ToString(),
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(fileName);
                            MessageBox.Show("File ReportBNNoiTruTheoThang.pdf đã được ghi thành công tại "+ txtPATH2.Text.ToString(),
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
                    String fileName = txtPATH.Text.ToString() + "\\ReportBNNoiTruTheoNam.pdf";
                    try
                    {
                        ReportBNNoiTruTheoNam report = new ReportBNNoiTruTheoNam(1, namNoi);
                        report.nam.Text = namNoi.ToString();
                        if (File.Exists(fileName))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoNam.pdf đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(fileName);
                                MessageBox.Show("File ReportBNNoiTruTheoNam.pdf đã được ghi thành công tại "+ txtPATH2.Text.ToString(),
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(fileName);
                            MessageBox.Show("File ReportBNNoiTruTheoNam.pdf đã được ghi thành công tại " + txtPATH2.Text.ToString(),
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

                    String fileName = txtPATH.Text.ToString() + "\\ReportBNNgoaiTruTheoThangTheoKhu.pdf";
                    try
                    {
                        ReportBNNoiTruTheoThangTheoKhu report = new ReportBNNoiTruTheoThangTheoKhu(thangNoi, namThangNoi, soKhu);

                        report.thang.Text = thangNoi.ToString();
                        report.nam.Text = namThangNoi.ToString();
                        report.khu.Text = Program.tenKhu.ToString();
                        if (File.Exists(fileName))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoThangTheoKhu.pdf đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(fileName);
                                MessageBox.Show("File ReportBNNoiTruTheoThangTheoKhu.pdf đã được ghi thành công tại " + txtPATH2.Text.ToString(),
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(fileName);
                            MessageBox.Show("File ReportBNNoiTruTheoThangTheoKhu.pdf đã được ghi thành công tại " + txtPATH2.Text.ToString(),
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
                    String fileName = txtPATH.Text.ToString() + "\\ReportBNNgoaiTruTheoNamTheoKhu.pdf";
                    try
                    {
                        ReportBNNoiTruTheoNamTheoKhu report = new ReportBNNoiTruTheoNamTheoKhu(namNoi, soKhu);

                        report.khu.Text = Program.tenKhu.ToString();
                        report.nam.Text = namNoi.ToString();
                        if (File.Exists(fileName))
                        {
                            DialogResult dr = MessageBox.Show("File ReportBNNoiTruTheoNamTheoKhu.pdf đã có!\nBạn có muốn tạo lại?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                report.ExportToPdf(fileName);
                                MessageBox.Show("File ReportBNNoiTruTheoNamTheoKhu.pdf đã được ghi thành công tại " +txtPATH2.Text.ToString(),
                        "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            report.ExportToPdf(fileName);
                            MessageBox.Show("File ReportBNNoiTruTheoNamTheoKhu.pdf đã được ghi thành công tại " + txtPATH2.Text.ToString(),
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

        private void button6_Click(object sender, EventArgs e)
        {
            string path = "nhấn save để chọn";

            SaveFileDialog sf = new SaveFileDialog();

            sf.FileName = path;

            if (sf.ShowDialog() == DialogResult.OK)
            {

                string savePath = Path.GetDirectoryName(sf.FileName);
                txtPATH.Text = savePath.ToString();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string path = "nhấn save để chọn";

            SaveFileDialog sf = new SaveFileDialog();

            sf.FileName = path;

            if (sf.ShowDialog() == DialogResult.OK)
            {

                string savePath = Path.GetDirectoryName(sf.FileName);
                txtPATH2.Text = savePath.ToString();

            }
        }
    }
}
