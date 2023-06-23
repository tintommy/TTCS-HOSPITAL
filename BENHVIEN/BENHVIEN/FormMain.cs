using BENHVIEN.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BENHVIEN
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {


        public FormMain()
        {
            InitializeComponent();
            btnDANGXUAT.Enabled = false;

            pageNV.Visible=pageBS.Visible=pageYTT.Visible=false;
        }

        public void enableButton() { 
        btnDANGNHAP.Enabled = false;
            btnDANGXUAT.Enabled = true;

            if (Program.role == "YTA")
            { 
            pageNV.Visible=true;
            }
            if (Program.role == "BACSI")
            {
                pageBS.Visible = true;
            }
            if (Program.role == "YTATRUONG")
            {
                pageYTT.Visible = true;
                tkYTT.Visible = true;
                btnTAOTK.Enabled = true;

            }

        }
        public void disableButton()
        {
            btnDANGNHAP.Enabled = true;
            btnDANGXUAT.Enabled = false;

            if (Program.role == "YTA")
            {
                pageNV.Visible = false;
            }
            if (Program.role == "BACSI")
            {
                pageBS.Visible = false;
            }
            if (Program.role == "YTATRUONG")
            {
                pageYTT.Visible = false;
                tkYTT.Visible = false;
                btnTAOTK.Enabled = false;
            }

        }

        public Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void dangXuat()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }

        private void btnDANGNHAP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();
                form.Show();
            }
        }

        private void btnDANGXUAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangXuat();
            disableButton();
            btnDANGNHAP.Enabled = true;
            btnDANGXUAT.Enabled = false;
            Form f = this.CheckExists(typeof(FormDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDangNhap form = new FormDangNhap();

                form.Show();
            }

            Program.formMain.MA.Text = "MÃ: ";
            Program.formMain.HOTEN.Text = "HỌ TÊN: ";
            Program.formMain.QUYEN.Text = "QUYỀN: ";
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormBenhNhan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormBenhNhan form = new FormBenhNhan();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormBenhNhanGiuong));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormBenhNhanGiuong form = new FormBenhNhanGiuong();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormVattu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormVattu form = new FormVattu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormNhanVien form = new FormNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void qlbs_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormBacSi));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormBacSi form = new FormBacSi();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormSuChuaTri)); 
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormSuChuaTri form = new FormSuChuaTri();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void qlyt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormYTa));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormYTa form = new FormYTa();
                form.MdiParent = this;
                form.Show();
            }
        }
        public void showFormChuaTriBenhNhan()
        {
            Form f = CheckExists(typeof(FormChuaTriChoBenhNhan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChuaTriChoBenhNhan form = new FormChuaTriChoBenhNhan();
                form.MdiParent = this;
                form.Activate();
                form.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormCTNV_KCT));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormCTNV_KCT form = new FormCTNV_KCT();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormGiuong));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormGiuong form = new FormGiuong();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormKCT));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormKCT form = new FormKCT();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormChonBenhNhanChuaTri));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonBenhNhanChuaTri form = new FormChonBenhNhanChuaTri();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormReportBenhNhan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormReportBenhNhan form = new FormReportBenhNhan();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnTAOTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = CheckExists(typeof(FormTaoTaiKhoan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTaoTaiKhoan form = new FormTaoTaiKhoan();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
