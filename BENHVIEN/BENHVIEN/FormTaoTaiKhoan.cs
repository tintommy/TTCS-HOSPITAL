using BENHVIEN.FormChon;
using System;
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
    public partial class FormTaoTaiKhoan : Form
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChonYTAcs));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonYTAcs form = new FormChonYTAcs();

                form.ShowDialog();
            }

            txtYTT.Text = Program.maYT;
            Program.maYT = "";
        }

        private void button2_Click(object sender, EventArgs e)
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

            txtBS.Text = Program.maBS;
            Program.maBS = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChonYTAcs));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChonYTAcs form = new FormChonYTAcs();

                form.ShowDialog();
            }

            txtYT.Text = Program.maYT;
            Program.maYT = "";
        }
        private bool kiemTraDuLieuDauVao()
        {
          
            if (txtLOGIN.Text == "")
            {
                MessageBox.Show("Thiếu tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtPASS.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPASS.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPASS.Text != txtPASS2.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            hOSPITALDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'hOSPITALDataSet.V_DS_TaiKhoan' table. You can move, or remove it, as needed.
            this.v_DS_TaiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_TaiKhoanTableAdapter.Fill(this.hOSPITALDataSet.V_DS_TaiKhoan);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            string taiKhoan;
            string matKhau;
            string maNhanVien = "";
            string vaiTro = "";


            if (rdYTT.Checked)
            {
                if (txtYTT.Text == "")
                {
                    MessageBox.Show("Hãy chọn y tá trưởng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                maNhanVien = txtYTT.Text.ToString();
                vaiTro = "YTATRUONG";

            }
            if (rdBS.Checked)
            {
                if (txtBS.Text == "")
                {
                    MessageBox.Show("Hãy chọn bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                maNhanVien = txtBS.Text.ToString();
                vaiTro = "BACSI";
            }
            if (rdYT.Checked)
            {
                if (txtYT.Text == "")
                {
                    MessageBox.Show("Hãy chọn y tá ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                maNhanVien = txtYT.Text.ToString();
                vaiTro = "YTA";
            }
            taiKhoan = txtLOGIN.Text;
            matKhau = txtPASS.Text;

            String cauTruyVan = "EXECUTE sp_TaoTaiKhoan @LGNAME='" + taiKhoan + "' , @PASS='" + matKhau + "', @USERNAME='" + maNhanVien + "', @ROLE='" + vaiTro + "'";



            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {


                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);

                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\n Mã Nhân Viên: " + maNhanVien + "\n Vai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
