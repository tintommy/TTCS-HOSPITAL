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
    public partial class FormBenhNhanGiuong : Form
    {
        int viTri = 0;
      
        bool dangThemMoi = false;
        Stack undoList = new Stack();

        public FormBenhNhanGiuong()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void cT_BENHNHAN_GIUONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCT_GIUONG.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormBenhNhanGiuong_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;


            this.cT_BENHNHAN_GIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChonGiuong));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonGiuong form = new FormChonGiuong();

                form.ShowDialog();
            }

            txtMAGIUONG.Text = Program.maGiuong;
            Program.maGiuong = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChonBenhNhan));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonBenhNhan form = new FormChonBenhNhan();

                form.ShowDialog();
            }

            txtMABN.Text = Program.maBN;
            Program.maBN = null;
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            viTri = bdsCT_GIUONG.Position;
          
            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsCT_GIUONG.AddNew();

            dteNGAYBD.EditValue = DateTime.Now;
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnCHUYENCHINHANH.Enabled = false;
            this.btnTHOAT.Enabled = false;
           

        }

        private bool kiemTraDuLieuDauVao() {

            if (txtMABN.Text == "" )
            {
                MessageBox.Show("Không bỏ trống mã bệnh nhân ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return false;
            }
            if ( txtMAGIUONG.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã giường ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return true;
        
        
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;



            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
           
            DataRowView drv = ((DataRowView)bdsCT_GIUONG[bdsCT_GIUONG.Position]);
            String maBN = (drv["mabenhnhan"].ToString());
            String maG = (drv["magiuong"].ToString());
            String ngayBD = (drv["ngayBD"].ToString());
            String ngayKT= (drv["ngayKT"].ToString());

          

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
                        btnTHOAT.Enabled = true;

                      
                        this.bdsCT_GIUONG .EndEdit();
                        this.cT_BENHNHAN_GIUONGTableAdapter.Update(this.DS.CT_BENHNHAN_GIUONG);
                    

                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            queryUndo = "" +
                                "DELETE DBO.CT_BENHNHAN_GIUONG " +
                                "WHERE MABENHNHAN = '" + txtMABN.Text.Trim()+ "' AND MAGIUONG = '" + txtMAGIUONG.Text.Trim()+ "' AND ngayBD = '" + dteNGAYBD.Text + "'";
                         
                        }
                        /*trước khi ấn btnGHI là sửa thông tin nhân viên*/
                        else
                        {


                            queryUndo =
                                "UPDATE DBO.CT_BENHNHAN_GIUONG " +
                                "SET " +
                                "MABENHNHAN = '" + maBN + "'," +
                                "MAGIUONG = '" + maG + "'," +
                                "NGAYBD = '" + ngayBD + "' ," +
                                "NGAYKT = '" + ngayKT + "'" +
                                  "WHERE MABENHNHAN = '" + txtMABN.Text.Trim() + "' AND MAGIUONG = '" + txtMAGIUONG.Text.Trim() + "' AND ngayBD = '" + dteNGAYBD.Text + "'";
                        }


                        /*Đưa câu truy vấn hoàn tác vào undoList */

                        undoList.Push(queryUndo);
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsCT_GIUONG.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            DataRowView drv = ((DataRowView)bdsCT_GIUONG[bdsCT_GIUONG.Position]);
            String maG = drv["magiuong"].ToString();
            String maBN = drv["mabenhnhan"].ToString();
    
            String ngayBD = (drv["ngaybd"].ToString());
            String ngayKT = (drv["ngaykt"].ToString());

            string queryUndo =
                string.Format("INSERT INTO DBO.CT_BENHNHAN_GIUONG( magiuong,mabenhnhan,ngaybd,ngaykt)" +
            "VALUES('{0}','{1}','{2}','{3}')", maG, maBN, ngayBD, ngayKT);

         
            undoList.Push(queryUndo);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết này không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsCT_GIUONG.Position;
                    bdsCT_GIUONG.RemoveCurrent();

                    this.cT_BENHNHAN_GIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.cT_BENHNHAN_GIUONGTableAdapter.Update(this.DS.CT_BENHNHAN_GIUONG);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsCT_GIUONG.Position = viTri;
                  
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
                bdsCT_GIUONG.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsCT_GIUONG.Position = viTri;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUNDO.Enabled = false;
                return;
            }
            bdsCT_GIUONG.CancelEdit();
            String queryUndo = undoList.Pop().ToString();
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(queryUndo);

            }
            this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);

        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.cT_BENHNHAN_GIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);
        }
    }
}
