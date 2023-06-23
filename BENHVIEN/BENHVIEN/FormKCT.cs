using BENHVIEN.FormChon;
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
    public partial class FormKCT : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;
        public FormKCT()
        {
            InitializeComponent();
        }

        private void kHUCHUATRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKCT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormKCT_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;

            this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);

            this.cT_NV_KHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NV_KHUCHUATRITableAdapter.Fill(this.DS.CT_NV_KHUCHUATRI);

            this.gIUONGBENHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGBENHTableAdapter.Fill(this.DS.GIUONGBENH);

        }

        private void tenTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void soKhuTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void maYTaTruongTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsKCT.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsKCT.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
        }

        private bool kiemTraDuLieuDauVao()
        {


            if (txtSOKHU.Text == "")
            {
                MessageBox.Show("Không bỏ trống số khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtSOKHU.Text.Length >3)
            {
                MessageBox.Show("Số Khu chỉ tối đa 3 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtTENKHU.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtYTT.Text == "")
            {
                MessageBox.Show("Không bỏ trống Y tá trưởng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }



            return true;
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = bdsKCT.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)bdsKCT[bdsKCT.Position]);



            String soKhu = drv["sokhu"].ToString();
            String tenKhu = drv["ten"].ToString();
            String maytt = drv["maytatruong"].ToString();

            /*them moi | sua nhan vien*/
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


                        this.bdsKCT.EndEdit();
                        this.kHUCHUATRITableAdapter.Update(this.DS.KHUCHUATRI);


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {


                            queryUndo = "" +
                               "DELETE DBO.KHUCHUATRI " +
                               "WHERE soKhu = '" + txtSOKHU.Text.Trim() + "'";


                        }
                        else
                        {


                            queryUndo =
                                "UPDATE DBO.KHUCHUATRI " +
                                "SET " +
                                "ten = N'" + tenKhu + "', " +
                                "maytatruong = N'" + maytt + "', " +
                                 "soKhu = N'" + soKhu + "' " +
                                "WHERE sokhu = '" + txtSOKHU.Text.Trim() + "'";
                        }


                        /*Đưa câu truy vấn hoàn tác vào undoList */

                        undoList.Push(queryUndo);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsKCT.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);
                    bdsKCT.Position = viTriThem;

                    this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);
                }
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DS.EnforceConstraints = false;

            this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);

            this.cT_NV_KHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_NV_KHUCHUATRITableAdapter.Fill(this.DS.CT_NV_KHUCHUATRI);

            this.gIUONGBENHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGBENHTableAdapter.Fill(this.DS.GIUONGBENH);
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsKCT.Count == 0)
            {
                btnXOA.Enabled = false;
            }


            if (cT_NV_KHUCHUATRIBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá KCT này vì có chi tiết nhân viên - KCT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gIUONGBENHBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá KCT vì có chi tiết giường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataRowView drv = ((DataRowView)bdsKCT[bdsKCT.Position]);
            String soKhu = drv["sokhu"].ToString();
            String tenKhu = drv["ten"].ToString();
            String maytt = drv["maytatruong"].ToString();


            string queryUndo =
                string.Format("INSERT INTO DBO.KHUCHUATRI(sokhu,ten,maytatruong)" +
            "VALUES('{0}',N'{1}',N'{2}')", soKhu, tenKhu,maytt);


            undoList.Push(queryUndo);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa KCT này không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsKCT.Position;
                    bdsKCT.RemoveCurrent();

                    this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
                    this.kHUCHUATRITableAdapter.Update(this.DS.KHUCHUATRI);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsKCT.Position = viTri;

                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void btnUNDO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnLUU.Enabled = true;

                this.btnUNDO.Enabled = false;
                this.btnLAMMOI.Enabled = true;
                this.btnCHUYENCHINHANH.Enabled = true;
                this.btnTHOAT.Enabled = true;


                dangThemMoi = false;

                /*xoa dong hien tai*/
                bdsKCT.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsKCT.Position = viTri;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUNDO.Enabled = false;
                return;
            }
            bdsKCT.CancelEdit();
            String queryUndo = undoList.Pop().ToString();
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(queryUndo);

            }
            this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FormChonYTAcs();
            f.ShowDialog();
            txtYTT.Text = Program.maYT;
            Program.maYT = "";
        }
    }
}
