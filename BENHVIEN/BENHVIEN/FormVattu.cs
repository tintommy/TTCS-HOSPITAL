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
    public partial class FormVattu : Form
    {

        int viTri = 0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem = 0;

        public FormVattu()
        {
            InitializeComponent();
        }

        private void vATTUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVATTU.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormVattu_Load(object sender, EventArgs e)
        {
           
            DS.EnforceConstraints = false;

            this.vATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vATTUTableAdapter.Fill(this.DS.VATTU);
            this.cT_HOADONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_HOADONTableAdapter.Fill(this.DS.CT_HOADON);
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsVATTU.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsVATTU.AddNew();

            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
          
        }

        private bool kiemTraDuLieuDauVao()
        {

           
            if (txtMOTA.Text == "")
            {
                MessageBox.Show("Không bỏ trống mô tả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
                return false;
            }
            if (txtDONGIA.Text == "")
            {
                MessageBox.Show("Không bỏ trống đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }



            return true;
        }


        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = bdsVATTU.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)bdsVATTU[bdsVATTU.Position]);


        
            String moTa = txtMOTA.Text.ToString();
            String donGia = txtDONGIA.Text.ToString();
        

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


                        this.bdsVATTU.EndEdit();
                      


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                           
                            this.bdsVATTU.RemoveCurrent();
                            string query =
              string.Format("INSERT INTO DBO.VATTU(MOTA,DONGIA)" +
          "VALUES(N'{0}','{1}')", moTa, donGia);
                            int n = Program.ExecSqlNonQuery(query);

                        }

                        else
                        {

                            String maVT = drv["MAVT"].ToString();// Trim() de loai bo khoang trang thua


                            moTa = drv["mota"].ToString();
                            donGia = drv["dongia"].ToString();

                       

                            queryUndo =
                                "UPDATE DBO.VATTU " +
                                "SET " +
                                "MOTA = N'" + moTa + "'," +
                                "DonGia = " + donGia +
                                "WHERE MAVT = '" + maVT + "'";

                            this.bdsVATTU.EndEdit();
                            this.vATTUTableAdapter.Update(this.DS.VATTU);
                            undoList.Push(queryUndo);
                        }

                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsVATTU.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.vATTUTableAdapter.Fill(this.DS.VATTU);
                    bdsVATTU.Position = viTriThem;
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


                this.btnLAMMOI.Enabled = true;

                this.btnTHOAT.Enabled = true;



                /*  bds.CancelEdit();*/
                /*xoa dong hien tai*/
                bdsVATTU.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsVATTU.Position = viTri;


                return;
            }


            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUNDO.Enabled = false;
                return;
            }


            bdsVATTU.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.vATTUTableAdapter.Fill(this.DS.VATTU);



        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maVT = txtMAVT.Text.Trim();// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)bdsVATTU[bdsVATTU.Position]);

            String moTa = txtMOTA.Text.ToString();
            String donGia = txtDONGIA.Text.ToString();

       


            if (bdsVATTU.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (bdsHOADON.Count > 0)
            {
                MessageBox.Show("Không thể xoá vật tư này vì đã lập chi tiết hoá đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string queryUndo =
             string.Format("INSERT INTO DBO.VATTU(MOTA,DONGIA)" +
         "VALUES(N'{0}','{1}')", moTa, donGia);

            undoList.Push(queryUndo);



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsVATTU.Position;
                    bdsVATTU.RemoveCurrent();

                    this.vATTUTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vATTUTableAdapter.Update(this.DS.VATTU);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.vATTUTableAdapter.Fill(this.DS.VATTU);
                  
                    bdsVATTU.Position = viTri;
                   
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.vATTUTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vATTUTableAdapter.Fill(this.DS.VATTU);

        }
    }
}
