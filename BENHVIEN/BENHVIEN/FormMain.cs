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
            }

        }

        private Form CheckExists(Type ftype)
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

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormYTa));
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
    }
}
