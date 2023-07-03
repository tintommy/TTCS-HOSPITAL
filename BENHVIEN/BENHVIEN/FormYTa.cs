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
    public partial class FormYTa : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;

        public FormYTa()
        {
            InitializeComponent();
        }

        private void yTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsYTA.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormYTa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.KHUCHUATRI' table. You can move, or remove it, as needed.
          
            DS.EnforceConstraints = false;

            this.yTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.yTATableAdapter.Fill(this.DS.YTA);

            this.tHONGTINYTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHONGTINYTATableAdapter.Fill(this.DS.THONGTINYTA);
            this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);

        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DS.EnforceConstraints = false;

            this.yTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.yTATableAdapter.Fill(this.DS.YTA);

            this.tHONGTINYTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHONGTINYTATableAdapter.Fill(this.DS.THONGTINYTA);
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsYTA.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsYTA.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
        }
        private bool kiemTraDuLieuDauVao()
        {


            if (txtMAYTA.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã Y tá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtCV.Text == "")
            {
                MessageBox.Show("Không bỏ trống công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }



            return true;
        }


        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = bdsYTA.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)bdsYTA[bdsYTA.Position]);



            String maYt = drv["mayt"].ToString();
            String congViec = drv["congviec"].ToString();


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


                        this.bdsYTA.EndEdit();
                        this.yTATableAdapter.Update(this.DS.YTA);


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {


                            queryUndo = "" +
                               "DELETE DBO.Yta " +
                               "WHERE maYT = '" + txtMAYTA.Text.Trim() + "'";


                        }
                        else
                        {


                            queryUndo =
                                "UPDATE DBO.Yta " +
                                "SET " +
                                "congviec = N'" + congViec + "', " +
                                "mayt = N'" + maYt + "' " +
                                "WHERE mayt = '" + txtMAYTA.Text + "'";
                        }


                        /*Đưa câu truy vấn hoàn tác vào undoList */

                        undoList.Push(queryUndo);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                        btnUNDO.Enabled = true;
                    }
                    catch (Exception ex)
                    {

                        bdsYTA.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.yTATableAdapter.Fill(this.DS.YTA);
                    bdsYTA.Position = viTriThem;

                    this.tHONGTINYTATableAdapter.Fill(this.DS.THONGTINYTA);
                }
            }
        }

        private void btnCHONNV_Click(object sender, EventArgs e)
        {
            Form f = new FormChonNhanVien();
            f.ShowDialog();
            txtMAYTA.Text = Program.maNV;
            Program.maNV = "";
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsYTA.Count == 0)
            {
                btnXOA.Enabled = false;
            }


            if (bdsKCT.Count > 0)
            {
                MessageBox.Show("Không thể xoá y tá này vì là y tá trưởng của khu chữa trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRowView drv = ((DataRowView)bdsYTA[bdsYTA.Position]);
            String maYt = drv["mayt"].ToString();
            String congViec = drv["congviec"].ToString();


            string queryUndo =
                string.Format("INSERT INTO DBO.YTA( mayt,congviec)" +
            "VALUES('{0}',N'{1}')", maYt, congViec);


            undoList.Push(queryUndo);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bác sĩ này không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsYTA.Position;
                    bdsYTA.RemoveCurrent();

                    this.yTATableAdapter.Connection.ConnectionString = Program.connstr;
                    this.yTATableAdapter.Update(this.DS.YTA);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.yTATableAdapter.Fill(this.DS.YTA);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsYTA.Position = viTri;

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
                bdsYTA.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsYTA.Position = viTri;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUNDO.Enabled = false;
                return;
            }
            bdsYTA.CancelEdit();
            String queryUndo = undoList.Pop().ToString();
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(queryUndo);

            }
            this.yTATableAdapter.Fill(this.DS.YTA);
        }
    }
    
}
