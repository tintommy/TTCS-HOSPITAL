using BENHVIEN.FormChon;
using DevExpress.Office.Utils;
using System;
using System.Collections;
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
    public partial class FormChuaTriChoBenhNhan : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        bool dangThemMoiCTHD = false;
        Stack undoList = new Stack();
        int viTriThem = 0;
        int viTriThem1 = 0;
        bool daChonSCTKhiThem = false;
        string soLuongCu = "";
        string thoiGianCu = "";
        public FormChuaTriChoBenhNhan()
        {
            InitializeComponent();
        }


        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void FormChuaTriChoBenhNhan_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;
            this.SP_ChuaTriBenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_ChuaTriBenhNhanTableAdapter.Fill(DS.SP_ChuaTriBenhNhan, Program.maBNCanChua);
            this.label2.Text = "Anh/Chị: " + Program.hoTenBNCanChua;
            if (txtMaBS.Text == Program.userName)
            {
                ngayChuaTriDateEdit.ReadOnly = false;
                thoiGianChuaTriSpinEdit.ReadOnly = false;
                txtKQ.ReadOnly = false;
                dgvCT_HoaDon.ReadOnly = false;
                panel7.Enabled = false;
            }

            // TODO: This line of code loads data into the 'DS.CT_HOADON' table. You can move, or remove it, as needed.
            this.CT_HoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CT_HoaDonTableAdapter.Fill(this.DS.CT_HOADON);
            dgvCT_HoaDon.ContextMenuStrip = contextMenuStrip;
            // Đặt cột thứ nhất là chỉ đọc
            dgvCT_HoaDon.Columns[0].ReadOnly = true;
            dgvCT_HoaDon.Columns[1].ReadOnly = true;
            dgvCT_HoaDon.Columns[2].ReadOnly = true;
            dgvCT_HoaDon.Columns[3].ReadOnly = true;
            dgvCT_HoaDon.Columns[4].ReadOnly = true;

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = SP_ChuaTriBenhNhanBDS.Position;
            dangThemMoi = true;
            daChonSCTKhiThem = false;
            SP_ChuaTriBenhNhanBDS.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
            this.panel2.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.txtMaBN.Text = Program.maBNCanChua;
            this.txtMaBS.Text = Program.userName;
            this.txtMaBS.ReadOnly = true;
            this.ngayChuaTriDateEdit.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.SP_ChuaTriBenhNhanTableAdapter.Fill(this.DS.SP_ChuaTriBenhNhan, Program.maBNCanChua);
                this.CT_HoaDonTableAdapter.Fill(this.DS.CT_HOADON);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtMaSCT_Click(object sender, EventArgs e)
        {
            Program.maSCTApDung = txtMaSCT.Text;
            Form f = Program.formMain.CheckExists(typeof(FormChonSuChuaTri));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonSuChuaTri form = new FormChonSuChuaTri();
                form.ShowDialog();
                txtMaSCT.Text = Program.maSCTApDung;
            }
            if (txtMaSCT.Text == "")
            {
                ngayChuaTriDateEdit.ReadOnly = true;
                thoiGianChuaTriSpinEdit.ReadOnly = true;
                txtKQ.ReadOnly = true;
            }
            else
            {
                if (txtMaBS.Text == Program.userName)
                {
                    ngayChuaTriDateEdit.ReadOnly = false;
                    thoiGianChuaTriSpinEdit.ReadOnly = false;
                    txtKQ.ReadOnly = false;
                }
                txtMaSCT.Text = Program.maSCTApDung;
            }
        }
        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaSCT.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã sự chữa trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }




            return true;
        }
        private bool kiemTraDuLieuDauVao1()
        {
            if (txtMaVT.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (soLuongSpinEdit.Text == "" || float.Parse(Program.formatSpinEdit(soLuongSpinEdit.Text)) <= 0)
            {
                MessageBox.Show("Không bỏ trống số lượng và số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = SP_ChuaTriBenhNhanBDS.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)SP_ChuaTriBenhNhanBDS[SP_ChuaTriBenhNhanBDS.Position]);
            String MaCTBSCTBNCu = drv["MaCTBSCTBN"].ToString();
            String MaSCTCu = drv["MaSuChuaTri"].ToString();
            String NgayChuaTriCu = drv["NgayChuaTri"].ToString();
            String ThoiGianChuaTriCu = drv["ThoiGianChuaTri"].ToString();
            String KetQuaCu = drv["KetQua"].ToString();



            /*them moi | sua chi tiet bac si chua tri benh nhan*/
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /*bật các nút về ban đầu*/
                        btnTHEM.Enabled = true;
                        btnXOA.Enabled = true;
                        btnLUU.Enabled = true;
                        btnUNDO.Enabled = true;

                        btnLAMMOI.Enabled = true;
                        btnCHUYENCHINHANH.Enabled = true;
                        btnTHOAT.Enabled = true;
                        panel2.Enabled = true;

                        this.SP_ChuaTriBenhNhanBDS.EndEdit();



                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {


                            string query =
                                string.Format("EXEC SP_ThemCTBSCTBN '{0}', '{1}', '{2}', '{3}', {4}, N'{5}'", Program.userName,
                                Program.maBNCanChua, txtMaSCT.Text, ngayChuaTriDateEdit.Text, thoiGianChuaTriSpinEdit.Text, txtKQ.Text);
                            if (thoiGianChuaTriSpinEdit.Text == "" && txtKQ.Text == "")
                            {
                                query =
                                    string.Format("EXEC SP_ThemCTBSCTBN '{0}', '{1}', '{2}', '{3}', NULL, NULL", Program.userName,
                                    Program.maBNCanChua, txtMaSCT.Text, ngayChuaTriDateEdit.Text);

                            }
                            else if (thoiGianChuaTriSpinEdit.Text == "")
                            {
                                query =
                                string.Format("EXEC SP_ThemCTBSCTBN '{0}', '{1}', '{2}', '{3}', NULL, N'{4}'", Program.userName,
                                Program.maBNCanChua, txtMaSCT.Text, ngayChuaTriDateEdit.Text, txtKQ.Text);

                            }
                            else if (txtKQ.Text == "")
                            {
                                query =
                                string.Format("EXEC SP_ThemCTBSCTBN '{0}', '{1}', '{2}', '{3}', {4}, NULL", Program.userName,
                                Program.maBNCanChua, txtMaSCT.Text, ngayChuaTriDateEdit.Text, thoiGianChuaTriSpinEdit.Text);

                            }
                            int n = Program.ExecSqlNonQuery(query);
                            this.SP_ChuaTriBenhNhanBDS.RemoveCurrent();
                            queryUndo = string.Format("EXEC SP_XoaCTBSCTBN '{0}'", MaCTBSCTBNCu);
                            undoList.Push(queryUndo);
                        }

                        else
                        {
                            string query = "";
                            if (ThoiGianChuaTriCu == "")
                            {
                                queryUndo = string.Format("UPDATE DBO.CT_BACSI_CHUATRI_BENHNHAN " +
                                "SET MaSuChuaTri = '{0}', NgayChuaTri = '{1}', ThoiGianChuaTri = NULL, KetQua = N'{2}' WHERE MaCTBSCTBN = '{3}'",
                                MaSCTCu, NgayChuaTriCu, KetQuaCu, MaCTBSCTBNCu);
                            }
                            else
                            {
                                queryUndo = string.Format("UPDATE DBO.CT_BACSI_CHUATRI_BENHNHAN " +
                                "SET MaSuChuaTri = '{0}', NgayChuaTri = '{1}', ThoiGianChuaTri = {2}, KetQua = N'{3}' WHERE MaCTBSCTBN = '{4}'",
                                MaSCTCu, NgayChuaTriCu, Program.formatSpinEdit(ThoiGianChuaTriCu), KetQuaCu, MaCTBSCTBNCu);
                            }
                            if (thoiGianChuaTriSpinEdit.Text == "")
                            {
                                query = string.Format("UPDATE DBO.CT_BACSI_CHUATRI_BENHNHAN " +
                               "SET MaSuChuaTri = '{0}', NgayChuaTri = '{1}', ThoiGianChuaTri = NULL, KetQua = N'{2}' WHERE MaCTBSCTBN = '{3}'",
                               txtMaSCT.Text, NgayChuaTriCu, txtKQ.Text, maCTBSCTBNSpinEdit.Text);
                            }
                            else
                            {
                                query = string.Format("UPDATE DBO.CT_BACSI_CHUATRI_BENHNHAN " +
                               "SET MaSuChuaTri = '{0}', NgayChuaTri = '{1}', ThoiGianChuaTri = {2}, KetQua = N'{3}' WHERE MaCTBSCTBN = '{4}'",
                               txtMaSCT.Text, NgayChuaTriCu, Program.formatSpinEdit(thoiGianChuaTriSpinEdit.Text), txtKQ.Text, maCTBSCTBNSpinEdit.Text);
                            }

                            int n = Program.ExecSqlNonQuery(query);
                            this.SP_ChuaTriBenhNhanBDS.EndEdit();
                            undoList.Push(queryUndo);
                        }





                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        SP_ChuaTriBenhNhanBDS.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.SP_ChuaTriBenhNhanTableAdapter.Fill(this.DS.SP_ChuaTriBenhNhan, Program.maBNCanChua);
                    SP_ChuaTriBenhNhanBDS.Position = viTriThem;
                }
            }
        }

        private void btnUNDO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;



                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnLUU.Enabled = true;
                this.panel2.Enabled = true;

                this.btnLAMMOI.Enabled = true;

                this.btnTHOAT.Enabled = true;



                /*  bds.CancelEdit();*/
                /*xoa dong hien tai*/
                SP_ChuaTriBenhNhanBDS.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                SP_ChuaTriBenhNhanBDS.Position = viTri;


                return;
            }


            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUNDO.Enabled = false;
                return;
            }


            SP_ChuaTriBenhNhanBDS.CancelEdit();
            CT_HoaDonBDS.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            //Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            if (cauTruyVanHoanTac.Contains("CT_HOADON"))
            {
                if (cauTruyVanHoanTac.Contains("CT_BACSI_CHUATRI_BENHNHAN"))
                {
                    this.SP_ChuaTriBenhNhanTableAdapter.Fill(this.DS.SP_ChuaTriBenhNhan, Program.maBNCanChua);

                }
            }
            else
            {
                this.SP_ChuaTriBenhNhanTableAdapter.Fill(this.DS.SP_ChuaTriBenhNhan, Program.maBNCanChua);
            }
            this.CT_HoaDonTableAdapter.Fill(this.DS.CT_HOADON);
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DataRowView drv = ((DataRowView)SP_ChuaTriBenhNhanBDS[SP_ChuaTriBenhNhanBDS.Position]);
            String MaCTBSCTBNCu = drv["MaCTBSCTBN"].ToString();
            String MaSCTCu = drv["MaSuChuaTri"].ToString();
            String NgayChuaTriCu = drv["NgayChuaTri"].ToString();
            String ThoiGianChuaTriCu = drv["ThoiGianChuaTri"].ToString();
            String KetQuaCu = drv["KetQua"].ToString();
            if (SP_ChuaTriBenhNhanBDS.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (CT_HoaDonBDS.Count > 0)
            {
                MessageBox.Show("Không thể xoá sự chữa trị này vì đã thêm các vật tư cho chi tiết chữa trị bệnh nhân.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            String queryUndo = "";
            if (ThoiGianChuaTriCu == "")
            {
                queryUndo =
                    string.Format("INSERT INTO DBO.CT_BACSI_CHUATRI_BENHNHAN(MaBacSi, MaBenhNhan, MaSuChuaTri, NgayChuaTri, ThoiGianChuaTri, KetQua) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', NULL, N'{4}')",
                 Program.userName, Program.maBNCanChua, MaSCTCu, NgayChuaTriCu, KetQuaCu);
            }
            else
            {
                queryUndo =
                    string.Format("INSERT INTO DBO.CT_BACSI_CHUATRI_BENHNHAN(MaBacSi, MaBenhNhan, MaSuChuaTri, NgayChuaTri, ThoiGianChuaTri, KetQua) " +
                    "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', N'{5}')",
                     Program.userName, Program.maBNCanChua, MaSCTCu, NgayChuaTriCu, Program.formatSpinEdit(ThoiGianChuaTriCu), KetQuaCu);
            }
            undoList.Push(queryUndo);
            String query = string.Format("DELETE FROM CT_BACSI_CHUATRI_BENHNHAN WHERE MaCTBSCTBN = {0}", MaCTBSCTBNCu);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    int n = Program.ExecSqlNonQuery(query);
                    this.SP_ChuaTriBenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.SP_ChuaTriBenhNhanTableAdapter.Fill(this.DS.SP_ChuaTriBenhNhan, Program.maBNCanChua);
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.SP_ChuaTriBenhNhanTableAdapter.Fill(this.DS.SP_ChuaTriBenhNhan, Program.maBNCanChua);
                    // tro ve vi tri cua nhan vien dang bi loi
                    SP_ChuaTriBenhNhanBDS.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }

            if (SP_ChuaTriBenhNhanBDS.Count == 0)
            {
                btnXOA.Enabled = false;
            }

        }

        private void btnThemVatTu_Click(object sender, EventArgs e)
        {
            dgvCT_HoaDon.Enabled = false;
            panel7.Enabled = true;
            gridControl1.Enabled = false;
            panel1.Enabled = false;
            btnHuy.Visible = true;
            btnGhiVT.Visible = true;
            btnLAMMOI.Enabled = false;
            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnLUU.Enabled = false;
            btnUNDO.Enabled = false;
            dangThemMoiCTHD = true;
            CT_HoaDonBDS.AddNew();

            this.thoiGianDateEdit.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void txtMaBS_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMaBS.Text == Program.userName)
            {
                ngayChuaTriDateEdit.ReadOnly = false;
                thoiGianChuaTriSpinEdit.ReadOnly = false;
                txtKQ.ReadOnly = false;
            }
        }

        private void maVTTextEdit_Click(object sender, EventArgs e)
        {
            Form f = Program.formMain.CheckExists(typeof(FormChonVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonVatTu form = new FormChonVatTu();
                form.ShowDialog();
                txtMaVT.Text = Program.maVTApDung;
                donGiaSpinEdit.Text = Program.donGiaVTApDUng;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            dgvCT_HoaDon.Enabled = true;
            panel7.Enabled = false;
            gridControl1.Enabled = true;
            panel1.Enabled = true;
            btnHuy.Visible = false;
            btnGhiVT.Visible = false;
            btnLAMMOI.Enabled = true;
            btnTHEM.Enabled = true;
            btnXOA.Enabled = true;
            btnLUU.Enabled = true;
            btnUNDO.Enabled = true;
            dangThemMoiCTHD = false;
            CT_HoaDonBDS.CancelEdit();
            CT_HoaDonTableAdapter.Fill(DS.CT_HOADON);
        }

        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao1();
            if (ketQua == false)
                return;


            viTriThem1 = CT_HoaDonBDS.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv1 = ((DataRowView)SP_ChuaTriBenhNhanBDS[SP_ChuaTriBenhNhanBDS.Position]);
            //ma bac si la ma nv hien tai
            //ma benh nhan la ma benh nhan can chua tri
            String MaSCTCu = drv1["MaSuChuaTri"].ToString();
            String NgayChuaTriCu = drv1["NgayChuaTri"].ToString();



            DataRowView drv = ((DataRowView)CT_HoaDonBDS[CT_HoaDonBDS.Position]);
            String MaVTCu = drv["MaVT"].ToString();
            String SoLuongCu = soLuongCu;
            String DonGiaCu = drv["DonGia"].ToString();
            String ThoiGianCu = thoiGianCu;


            /*them moi | sua chi tiet bac si chua tri benh nhan*/
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {




                        //this.CT_HoaDonBDS.EndEdit();



                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoiCTHD == true)
                        {

                            string query =
                                string.Format("INSERT INTO DBO.CT_HOADON(MaVT, MaCTBSCTBN, SoLuong, DonGia, ThoiGian) " +
                                "VALUES('{0}', {1}, {2}, {3}, '{4}')",
                                txtMaVT.Text, maCTBSCTBNSpinEdit.Text, Program.formatSpinEdit(soLuongSpinEdit.Text), donGiaSpinEdit.Text, thoiGianDateEdit.Text);

                            int n = Program.ExecSqlNonQuery(query);
                            Console.WriteLine(n);
                            queryUndo = string.Format("DELETE FROM DBO.CT_HOADON WHERE MaCTBSCTBN = (SELECT MaCTBSCTBN FROM CT_BACSI_CHUATRI_BENHNHAN WHERE MaBenhNhan = '{0}' AND MaBacSi = '{1}' AND MaSuChuaTri = '{2}' AND NgayChuaTri = '{3}')" +
                                " AND MaVT = '{4}'", Program.maBNCanChua, Program.userName, MaSCTCu, NgayChuaTriCu, txtMaVT.Text);
                            if (n == 0)
                            {
                                this.CT_HoaDonBDS.EndEdit();

                                undoList.Push(queryUndo);
                                dangThemMoiCTHD = false;
                                this.CT_HoaDonTableAdapter.Fill(this.DS.CT_HOADON);
                                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                                /*bật các nút về ban đầu*/
                                btnTHEM.Enabled = true;
                                btnXOA.Enabled = true;
                                btnLUU.Enabled = true;
                                btnUNDO.Enabled = true;
                                btnLAMMOI.Enabled = true;
                                gridControl1.Enabled = true;
                                panel1.Enabled = true;
                                dgvCT_HoaDon.Enabled = true;
                                panel7.Enabled = false;
                                btnGhiVT.Visible = false;
                                btnHuy.Visible = false;
                            }
                        }

                        else
                        {
                            string query = string.Format("UPDATE DBO.CT_HOADON " +
                                "SET ThoiGian = '{0}', SoLuong = {1} WHERE MaCTBSCTBN = {2} AND MaVT = '{3}'",
                               thoiGianDateEdit.Text, Program.formatSpinEdit(soLuongSpinEdit.Text), Program.formatSpinEdit(maCTBSCTBNSpinEdit1.Text), txtMaVT.Text);
                            queryUndo = string.Format("UPDATE DBO.CT_HOADON " +
                                "SET ThoiGian = '{0}', SoLuong = {1} WHERE MaCTBSCTBN = (SELECT MaCTBSCTBN FROM CT_BACSI_CHUATRI_BENHNHAN WHERE MaBacSi = '{2}' AND " +
                                "MaBenhNhan = '{3}' AND MaSuChuaTri = '{4}' AND NgayChuaTri = '{5}') AND MaVT = '{6}'",
                                ThoiGianCu, Program.formatSpinEdit(SoLuongCu), Program.userName, Program.maBNCanChua, MaSCTCu, NgayChuaTriCu, txtMaVT.Text);




                            int n = Program.ExecSqlNonQuery(query);
                            if (n == 0)
                            {
                                this.CT_HoaDonBDS.EndEdit();
                                undoList.Push(queryUndo);
                                this.CT_HoaDonTableAdapter.Fill(this.DS.CT_HOADON);
                                MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                                /*bật các nút về ban đầu*/
                                btnTHEM.Enabled = true;
                                btnXOA.Enabled = true;
                                btnLUU.Enabled = true;
                                btnUNDO.Enabled = true;
                                btnLAMMOI.Enabled = true;
                                gridControl1.Enabled = true;
                                panel1.Enabled = true;
                                dgvCT_HoaDon.Enabled = true;
                                panel7.Enabled = false;
                                btnGhiVT.Visible = false;
                                btnHuy.Visible = false;
                                txtMaVT.Enabled = true;
                            }
                        }



                    }
                    catch (Exception ex)
                    {

                        //SP_ChuaTriBenhNhanBDS.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    CT_HoaDonBDS.Position = viTriThem1;
                }
            }

        }

        private void btnHieuChinhVatTu_Click(object sender, EventArgs e)
        {
            dgvCT_HoaDon.Enabled = false;
            panel7.Enabled = true;
            gridControl1.Enabled = false;
            panel1.Enabled = false;
            btnHuy.Visible = true;
            btnGhiVT.Visible = true;
            btnLAMMOI.Enabled = false;
            btnTHEM.Enabled = false;
            btnXOA.Enabled = false;
            btnLUU.Enabled = false;
            btnUNDO.Enabled = false;
            soLuongCu = soLuongSpinEdit.Text;
            thoiGianCu = thoiGianDateEdit.Text;
            txtMaVT.Enabled = false;
        }

        private void btnXoaVatTu_Click(object sender, EventArgs e)
        {
            string queryUndo = string.Format("INSERT INTO DBO.CT_HOADON VALUES('{0}', (SELECT MaCTBSCTBN FROM CT_BACSI_CHUATRI_BENHNHAN WHERE MaBacSi = '{1}' " +
                "AND MaBenhNhan = '{2}' AND MaSuChuaTri = '{3}' AND NgayChuaTri = '{4}'), " +
                "{5}, {6}, '{7}')",
                txtMaVT.Text, Program.userName, Program.maBNCanChua, txtMaSCT.Text, ngayChuaTriDateEdit.Text, Program.formatSpinEdit(soLuongSpinEdit.Text), Program.formatSpinEdit(donGiaSpinEdit.Text),thoiGianDateEdit.Text);
            CT_HoaDonBDS.RemoveCurrent();

            CT_HoaDonTableAdapter.Update(DS.CT_HOADON);
            undoList.Push(queryUndo);
            btnXOA.Enabled = true;
        }
    }
}
