using System;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDANGNHAP_Click(object sender, EventArgs e)
        {
            if (txtTAIKHOAN.Text.Trim() == "" || txtMATKHAU.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
    

            Program.loginName = txtTAIKHOAN.Text.Trim();
            Program.loginPassword = txtMATKHAU.Text.Trim();
            if (Program.KetNoi() == 0)
                return;

          

            String statement = "execute sp_DangNhap '" + Program.loginName + "'";

            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;
            // đọc một dòng của myReader - điều này là hiển nhiên vì kết quả chỉ có 1 dùng duy nhất
            Program.myReader.Read();



            Program.userName = Program.myReader.GetString(0);// lấy userName
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }



            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.conn.Close();

            Program.formMain.MA.Text = "Mã: " + Program.userName;
            Program.formMain.HOTEN.Text = "HỌ TÊN: " + Program.staff;
            Program.formMain.QUYEN.Text = "Quyền: " + Program.role;

         /*   if (Program.role == "db_owner")
            {
                Program.formMain.QUYEN.Text = "Quyền: ADMIN ";
            }*/

            this.Visible = false;


            Program.formMain.enableButton();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
