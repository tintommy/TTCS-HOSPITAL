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
    public partial class FormNhanVien : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNHANVIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
           
           
            DS.EnforceConstraints = false;

            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            // TODO: This line of code loads data into the 'DS.YTA' table. You can move, or remove it, as needed.
            this.yTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.yTATableAdapter.Fill(this.DS.YTA);
            // TODO: This line of code loads data into the 'DS.BACSI' table. You can move, or remove it, as needed.
            this.bACSITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bACSITableAdapter.Fill(this.DS.BACSI);


        }

        private void maNVLabel_Click(object sender, EventArgs e)
        {

        }

        private void hoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsNHANVIEN.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsNHANVIEN.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
          
        }

        private bool kiemTraDuLieuDauVao()
        {

         
            if (txtHO.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHO.Focus();
                return false;
            }


            foreach (char c in txtHO.Text)
            {
                if (Char.IsDigit(c))
                {
                    MessageBox.Show("Họ người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtHO.Focus();
                    return false;
                }

            }

            if (txtHO.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHO.Focus();
                return false;
            }
            /*kiem tra txtTEN*/
            if (txtTEN.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTEN.Focus();
                return false;
            }

            foreach (char c in txtTEN.Text)
            {
                if (Char.IsDigit(c))
                {
                    MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTEN.Focus();
                    return false;
                }

            }


            if (txtTEN.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTEN.Focus();
                return false;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Không bỏ trống số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return false;
            }

            if (txtSDT.Text.Length !=10 && txtSDT.Text.Length != 11)

            {
                MessageBox.Show("Số điện thoại phải 10 hoặc 11 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
              
                return false;
            }
            return true;
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = bdsNHANVIEN.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)bdsNHANVIEN[bdsNHANVIEN.Position]);


            String ho = txtHO.Text.ToString();
            String ten = txtTEN.Text.ToString();
            String sdt = txtSDT.Text.ToString();
         
            int phai = (cbPHAI.Checked == true) ? 1 : 0;
         


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


                        this.bdsNHANVIEN.EndEdit();
                    


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            

                            this.bdsNHANVIEN.RemoveCurrent();
                            string query =
              string.Format("INSERT INTO DBO.NHANVIEN( Ho,Ten,sdt,Phai)" +
          "VALUES(N'{0}',N'{1}','{2}',{3})", ho, ten, sdt, phai);
                            int n = Program.ExecSqlNonQuery(query);

                        }

                        else
                        {

                            String maNV = drv["MaNV"].ToString().Trim();// Trim() de loai bo khoang trang thua


                            ho = drv["HO"].ToString();
                            ten = drv["TEN"].ToString();
                            sdt= drv["SDT"].ToString() ;
                          
                            phai = (cbPHAI.Checked == true) ? 1 : 0;
                        

                            queryUndo =
                                "UPDATE DBO.NHAMVIEN " +
                                "SET " +
                                "HO = '" + ho + "'," +
                                "TEN = '" + ten + "'," +
                                "SDT = '" + sdt + "'," +
                                "Phai = " + phai + "," +
                             
                                "WHERE MaBenhNhan = '" + maNV + "'";




                            this.bdsNHANVIEN.EndEdit();
                            this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);
                            undoList.Push(queryUndo);
                        }





                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsNHANVIEN.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                    bdsNHANVIEN.Position = viTriThem;
                }
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maNV = txtMANV.Text.Trim();// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)bdsNHANVIEN[bdsNHANVIEN.Position]);

            String ho = txtHO.Text.ToString();
            String ten = txtTEN.Text.ToString();
            String sdt = txtSDT.Text.ToString();


            int phai = (cbPHAI.Checked == true) ? 1 : 0;
          


            if (bdsNHANVIEN.Count == 0)
            {
                btnXOA.Enabled = false;
            }
           

            if (bdsBACSI.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên này vì còn là bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bdsYTA.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên này vì còn là y tá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryUndo =
             string.Format("INSERT INTO DBO.NHANVIEN(MaNV ,Ho,Ten,sdt,Phai)" +
         "VALUES('{0}',N'{1}',N'{2}','{3}',{4})",maNV, ho, ten, sdt, phai);
           

            undoList.Push(queryUndo);



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsNHANVIEN.Position;
                    bdsNHANVIEN.RemoveCurrent();

                    this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nHANVIENTableAdapter.Update(this.DS.NHANVIEN);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                    
                    bdsNHANVIEN.Position = viTri;
                 
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DS.EnforceConstraints = false;

            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
        }

        private void btnUNDO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnTHEM.Enabled == false)
            {
                dangThemMoi = false;



                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnLUU.Enabled = true;


                this.btnLAMMOI.Enabled = true;

                this.btnTHOAT.Enabled = true;



                /*  bds.CancelEdit();*/
                /*xoa dong hien tai*/
                bdsNHANVIEN.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsNHANVIEN.Position = viTri;


                return;
            }


            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUNDO.Enabled = false;
                return;
            }


            bdsNHANVIEN.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.nHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
        }
    }
}
