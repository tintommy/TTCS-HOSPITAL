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
    public partial class FormBenhNhan : Form
    {
        int viTri=0;
        bool dangThemMoi = false;
        Stack undoList = new Stack();
        int viTriThem=0;
        public FormBenhNhan()
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

        private void bENHNHANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBENHNHAN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void bENHNHANBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBENHNHAN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormBenhNhan_Load(object sender, EventArgs e)
        {
           
            DS.EnforceConstraints = false;

            this.bENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bENHNHANTableAdapter.Fill(this.DS.BENHNHAN);
            this.cT_BENHNHAN_GIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cT_BENHNHAN_GIUONGTableAdapter.Fill(this.DS.CT_BENHNHAN_GIUONG);

            this.txtMABN.Enabled = false;
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bdsBENHNHAN.Position;

            dangThemMoi = true;


            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bdsBENHNHAN.AddNew();

            dteNGAYSINH.EditValue = "2000-01-01";




          
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnLUU.Enabled = true;

            this.btnUNDO.Enabled = true;
            this.btnLAMMOI.Enabled = false;
            this.btnTHOAT.Enabled = false;
            this.cbLOAI.Checked = false;


        }


        private bool kiemTraDuLieuDauVao()
        {

            /*kiem tra txtHO*/
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

            return true;
        }

        private void btnLUU_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;


            viTriThem = bdsBENHNHAN.Position;

            /*Lay du lieu truoc khi chon btnGHI - phuc vu UNDO - sau khi OK thi da la du lieu moi*/
            DataRowView drv = ((DataRowView)bdsBENHNHAN[bdsBENHNHAN.Position]);
         
          
            String ho = txtHO.Text.ToString();
            String ten = txtTEN.Text.ToString();

            String ngaySinh = drv["NgaySinh"].ToString();
  
            int loai = (cbLOAI.Checked == true) ? 1 : 0;
            /*String maBsTiepNhan = txtMABSTIEPNHAN.Text.ToString();
            String maBsTheoDoi =  txtMABSTHEODOI.Text.ToString();*/
            string maBsTiepNhan = string.IsNullOrEmpty(txtMABSTIEPNHAN.Text) ? null : txtMABSTIEPNHAN.Text.ToString();
            string maBsTheoDoi = string.IsNullOrEmpty(txtMABSTHEODOI.Text) ? null : txtMABSTHEODOI.Text.ToString();
          

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


                        this.bdsBENHNHAN.EndEdit();
                      /*  this.bENHNHANTableAdapter.Update(this.DS.BENHNHAN);*/


                        /*lưu câu truy vấn để hoàn tác*/
                        String queryUndo = "";
                        /*trước khi ấn btnGHI là btnTHEM*/
                        if (dangThemMoi == true)
                        {
                            /*queryUndo = "" +
                                "DELETE DBO.BENHNHAN " +
                                "WHERE MaBenhNhan = " + txtMABN.Text.Trim();
*/
                            this.bdsBENHNHAN.RemoveCurrent();
                            string query;

                            if (maBsTheoDoi == null && maBsTiepNhan == null)
                            {
                                query =
               string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai)" +
           "VALUES(N'{0}',N'{1}','{2}',{3})", ho, ten, ngaySinh, loai);
                            }
                            else if (maBsTheoDoi == null)
                            {
                                query =
                 string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai,MaBacSiTiepNhan)" +
             "VALUES(N'{0}',N'{1}','{2}',{3},'{4}')", ho, ten, ngaySinh, loai, maBsTiepNhan);
                            }
                            else if (maBsTiepNhan == null)
                            {
                                query =
                 string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai,MaBacSiTheoDoi)" +
             "VALUES(N'{0}',N'{1}','{2}',{3},'{4}')", ho, ten, ngaySinh, loai, maBsTheoDoi);
                            }
                            else
                            {
                                query =
           string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai,MaBacSiTheoDoi,MaBacSiTiepNhan)" +
       "VALUES(N'{0}',N'{1}','{2}',{3},'{4}', '{5}')", ho, ten, ngaySinh, loai, maBsTheoDoi, maBsTiepNhan);
                            }
                           
                            int n = Program.ExecSqlNonQuery(query);

                        }

                        else
                        {
                         
                            String maBN = drv["MaBenhNhan"].ToString().Trim();// Trim() de loai bo khoang trang thua
                          

                             ho = drv["HO"].ToString();
                             ten = drv["TEN"].ToString();

                            ngaySinh = drv["NgaySinh"].ToString();

                            loai = (cbLOAI.Checked == true) ? 1 : 0;
                           
                             maBsTiepNhan = string.IsNullOrEmpty(drv["MaBacSiTiepNhan"].ToString()) ? null : drv["MaBacSiTiepNhan"].ToString();
                             maBsTheoDoi = string.IsNullOrEmpty(drv["MaBacSiTheoDoi"].ToString()) ? null : drv["MaBacSiTheoDoi"].ToString();
                            if (maBsTheoDoi == null && maBsTiepNhan == null)
                            {
                                queryUndo =
                               "UPDATE DBO.BENHNHAN " +
                               "SET " +
                               "HO = '" + ho + "'," +
                               "TEN = '" + ten + "'," +
                               "NGAYSINH = '" + ngaySinh + "'," +
                               "MaLoai = " + loai + 
                               "WHERE MaBenhNhan = '" + maBN + "'";
                            }
                            else if (maBsTheoDoi == null)
                            {
                                queryUndo =
                               "UPDATE DBO.BENHNHAN " +
                               "SET " +
                               "HO = '" + ho + "'," +
                               "TEN = '" + ten + "'," +
                               "NGAYSINH = '" + ngaySinh + "'," +
                               "MaLoai = " + loai + "," +
         
                                "MaBacSiTiepNhan = '" + maBsTiepNhan + "'" +
                               "WHERE MaBenhNhan = '" + maBN + "'";
                            }
                            else if (maBsTiepNhan == null)
                            {
                                queryUndo =
                                "UPDATE DBO.BENHNHAN " +
                                "SET " +
                                "HO = '" + ho + "'," +
                                "TEN = '" + ten + "'," +
                                "NGAYSINH = '" + ngaySinh + "'," +
                                "MaLoai = " + loai + "," +
                                "MaBacSiTheoDoi = '" + maBsTheoDoi + "'" +
                                
                                "WHERE MaBenhNhan = '" + maBN + "'";
                            }
                            else
                            {
                                queryUndo =
                                "UPDATE DBO.BENHNHAN " +
                                "SET " +
                                "HO = '" + ho + "'," +
                                "TEN = '" + ten + "'," +
                                "NGAYSINH = '" + ngaySinh + "'," +
                                "MaLoai = " + loai + "," +
                                "MaBacSiTheoDoi = '" + maBsTheoDoi + "'," +
                                 "MaBacSiTiepNhan = '" + maBsTiepNhan + "'" +
                                "WHERE MaBenhNhan = '" + maBN + "'";
                            }




                            this.bdsBENHNHAN.EndEdit();
                            this.bENHNHANTableAdapter.Update(this.DS.BENHNHAN);
                            undoList.Push(queryUndo);
                        }


                      

                      
                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {

                        bdsBENHNHAN.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.bENHNHANTableAdapter.Fill(this.DS.BENHNHAN);
                    bdsBENHNHAN.Position = viTriThem;
                }
            }
           
        }

        private void btnLAMMOI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.bENHNHANTableAdapter.Fill(this.DS.BENHNHAN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String maBN = txtMABN.Text.Trim();// Trim() de loai bo khoang trang thua
            DataRowView drv = ((DataRowView)bdsBENHNHAN[bdsBENHNHAN.Position]);

            String ho = txtHO.Text.ToString();
            String ten = txtTEN.Text.ToString();
        
            DateTime ngaySinh = ((DateTime)drv["NgaySinh"]);

            int loai = (cbLOAI.Checked == true) ? 1 : 0;
            string maBsTiepNhan = string.IsNullOrEmpty(txtMABSTIEPNHAN.Text) ? null : txtMABSTIEPNHAN.Text.ToString();
            string maBsTheoDoi = string.IsNullOrEmpty(txtMABSTHEODOI.Text) ? null : txtMABSTHEODOI.Text.ToString();


            if (bdsBENHNHAN.Count == 0)
            {
                btnXOA.Enabled = false;
            }

            if (bdsCT_BS_CHUATRI.Count > 0)
            {
                MessageBox.Show("Không thể xoá bệnh nhân này vì đã lập chi tiết chữa trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (bdsCT_BN_GIUONG.Count > 0)
            {
                MessageBox.Show("Không thể xoá bệnh nhân này vì đã lập chi tiết giường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string queryUndo = null;




            if (maBsTheoDoi == null && maBsTiepNhan == null)
            {
                queryUndo =
string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai)" +
"VALUES(N'{0}',N'{1}','{2}',{3})", ho, ten, ngaySinh, loai);
            }
            else if (maBsTheoDoi == null)
            {
                queryUndo =
 string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai,MaBacSiTiepNhan)" +
"VALUES(N'{0}',N'{1}','{2}',{3},'{4}')", ho, ten, ngaySinh, loai, maBsTiepNhan);
            }
            else if (maBsTiepNhan == null)
            {
                queryUndo =
 string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai,MaBacSiTheoDoi)" +
"VALUES(N'{0}',N'{1}','{2}',{3},'{4}')", ho, ten, ngaySinh, loai, maBsTheoDoi);
            }
            else
            {
                queryUndo =
string.Format("INSERT INTO DBO.BENHNHAN( Ho,Ten,NgaySinh,MaLoai,MaBacSiTheoDoi,MaBacSiTiepNhan)" +
"VALUES(N'{0}',N'{1}','{2}',{3},'{4}', '{5}')", ho, ten, ngaySinh, loai, maBsTheoDoi, maBsTiepNhan);
            }


            undoList.Push(queryUndo);



            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?", "Thông báo",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    viTri = bdsBENHNHAN.Position;
                    bdsBENHNHAN.RemoveCurrent();

                    this.bENHNHANTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.bENHNHANTableAdapter.Update(this.DS.BENHNHAN);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUNDO.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.bENHNHANTableAdapter.Fill(this.DS.BENHNHAN);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bdsBENHNHAN.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void btnCHONBSTHEODOI_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChonBacSi));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonBacSi form = new FormChonBacSi();

                form.ShowDialog();
            }

            txtMABSTHEODOI.Text = Program.maBS;
            Program.maBS = "";
        }

        private void btnCHONBSTIEPNHAN_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChonBacSi));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonBacSi form = new FormChonBacSi();

                form.ShowDialog();
            }

            txtMABSTIEPNHAN.Text = Program.maBS;
            Program.maBS = "";
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
                bdsBENHNHAN.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsBENHNHAN.Position = viTri;

               
                return;
            }


            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUNDO.Enabled = false;
                return;
            }


            bdsBENHNHAN.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.bENHNHANTableAdapter.Fill(this.DS.BENHNHAN);
            


            
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void bENHNHANBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsBENHNHAN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void cbLOAI_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }
