using BENHVIEN.FormChon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENHVIEN
{
    public partial class FormGiuong : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;

        public FormGiuong()
        {
            InitializeComponent();
        }

        private void FormGiuong_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.gIUONGBENHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGBENHTableAdapter.Fill(this.DS.GIUONGBENH);

            this.cT_BENHNHAN_GIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);
        }

        private void gIUONGBENHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGUONG.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsGUONG.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsGUONG.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
        }

        private bool kiemTraDuLieuDauVao()
        {


          
            if (txtSOGIUONG.Text == "")
            {
                MessageBox.Show("Không bỏ trống số giường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtSOPHONG.Text == "")
            {
                MessageBox.Show("Không bỏ trống số phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            if (txtSOKHU.Text == "")
            {
                MessageBox.Show("Không bỏ trống số khu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return true;
        }

        private int kiemTraPhongCoGiuong(String soGiuong,String soPhong,String soKhu)
        {


            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraPhongCoGiuong " +
                    soGiuong + ", " + soPhong + ", " + soKhu+
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
         
            Program.myReader.Close();

            return result;
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;
            if (kiemTraPhongCoGiuong(txtSOGIUONG.Text.ToString(), txtSOPHONG.Text.ToString(), txtSOKHU.Text.ToString()) == 1)
            {
                MessageBox.Show("Giường này đã có", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            viTriThem = bdsGUONG.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)bdsGUONG[bdsGUONG.Position]);



            String maGiuong = txtMAGIUONG.Text.ToString();
            String soGiuong = txtSOGIUONG.Text.ToString();
            String soPhong = txtSOPHONG.Text.ToString();
            String soKhu = txtSOKHU.Text.ToString();

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


                        this.bdsGUONG.EndEdit();



                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {

                            this.bdsGUONG.RemoveCurrent();
                            string query =
              string.Format("INSERT INTO DBO.GIUONGBENH(sogiuong,sophong,sokhu) " +
          "VALUES({0},{1},{2})", soGiuong,soPhong,soKhu);
                            int n = Program.ExecSqlNonQuery(query);

                            queryUndo = "DELETE DBO.GIUONGBENH " +
                                "WHERE sogiuong = " + soGiuong+" and sophong= "+soPhong+ " and sokhu= "+soKhu;
                            undoList.Push(queryUndo);
                        }
                        else
                        {
                             maGiuong = drv["maGiuong"].ToString();
                             soGiuong = drv["soGiuong"].ToString();
                             soPhong = drv["soPhong"].ToString();
                             soKhu = drv["soKHu"].ToString();

                            queryUndo =
                                "UPDATE DBO.GIUONGBENH " +
                                "SET " +
                                  "sogiuong = " + soGiuong +", "+
                                "sophong = " + soPhong +", "+
                                  "sokhu = " + soKhu + " "+
                                "WHERE magiuong = '" + maGiuong + "'";

                            this.bdsGUONG.EndEdit();
                            this.gIUONGBENHTableAdapter.Update(this.DS.GIUONGBENH);
                            undoList.Push(queryUndo);
                        }

                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                        btnXOA.Enabled = true;
                    }
                    catch (Exception ex)
                    {

                        bdsGUONG.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        undoList.Pop();
                    }
                    this.gIUONGBENHTableAdapter.Fill(this.DS.GIUONGBENH);
                    bdsGUONG.Position = viTriThem;
                }
            }
        }

        private void buttonCHONKHU_Click(object sender, EventArgs e)
        {
            Form f = new FormChonKhu();
            f.ShowDialog();
            txtSOKHU.Text = Program.maKhu;
            Program.maKhu = "";
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DS.EnforceConstraints = false;

            this.gIUONGBENHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGBENHTableAdapter.Fill(this.DS.GIUONGBENH);

            this.cT_BENHNHAN_GIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsGUONG.Count == 0)
            {
                btnXOA.Enabled = false;
            }


            if (cT_BENHNHAN_GIUONGBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xoá giường này vì có chi tiết bệnh nhân nằm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DataRowView drv = ((DataRowView)bdsGUONG[bdsGUONG.Position]);
           String maGiuong = drv["maGiuong"].ToString();
            String soGiuong = drv["soGiuong"].ToString();
            String soPhong = drv["soPhong"].ToString();
            String soKhu = drv["soKHu"].ToString();


            string queryUndo =
              string.Format("INSERT INTO DBO.GIUONGBENH(magiuong,sogiuong,sophong,sokhu) " +
          "VALUES('{0}',{1},{2},{3})",maGiuong, soGiuong, soPhong, soKhu);


            undoList.Push(queryUndo);


            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bác sĩ này không ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsGUONG.Position;
                    bdsGUONG.RemoveCurrent();

                    this.gIUONGBENHTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIUONGBENHTableAdapter.Update(this.DS.GIUONGBENH);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.gIUONGBENHTableAdapter.Fill(this.DS.GIUONGBENH);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsGUONG.Position = viTri;

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
                bdsGUONG.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsGUONG.Position = viTri;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUNDO.Enabled = false;
                return;
            }
            bdsGUONG.CancelEdit();
            String queryUndo = undoList.Pop().ToString();
            {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(queryUndo);

            }
            this.gIUONGBENHTableAdapter.Fill(this.DS.GIUONGBENH);
        }
    }
    
}
