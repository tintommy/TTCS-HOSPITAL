using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace BENHVIEN
{
    internal static class Program
    {
        /**********************************************
         * conn: biến để kết nối tới cơ sở dữ liệu
         * connstr: connection String , chuỗi kết nối động
         * dataReader: 
         **********************************************/
        public static SqlConnection conn = new SqlConnection();//conn
        public static String connstr = "";//connstr
        public static String connstrPublisher = "Data Source=DESKTOP-4EAOBVB;Initial Catalog=HOSPITAL;Integrated Security=true;TrustServerCertificate=True";
        public static SqlDataReader myReader;//myReader



        /**********************************************
         * servername: tên server(phân mảnh) sẽ kết nối tới
         * 
       
         * 
         * username: tên username trong database sẽ kết nối.
         *
         * 
         * loginName & loginPassword: tài khoản & mật khẩu dùng để 
         * đăng nhập vào server(phân mảnh)
         ***********************************************/
        public static String serverName = "DESKTOP-4EAOBVB";//servername
       
        public static String userName = "";//username

        public static String loginName = "";//mlogin
        public static String loginPassword = "";//password




        /**********************************************
         *database: cơ sở dữ liệu mà ta muốn làm việc
         *
         *remoteLogin & currentLogin: Dùng 2 biến này bởi
         *đi từ server hiện tại sang server 2 => remoteLogin
         *đi từ server 2 về lại server hiện tại => currentLogin
         * 
         *Note: currentLogin & currentPassword chứa loginName & loginPassword 
         *khi từ phân mảnh khác về phân mảnh hiện tại
         *
         *Ví dụ: LT là loginName của server 1 thì qua server 2 dùng HTKN.
         *Quay về server 1 thì dùng currentLogin
         ***********************************************/
        public static String database = "HOSPITAL";

   

        public static String currentLogin = "";//mloginDN
        public static String currentPassword = "";//passwordDN




       
        public static String role = "";// mGroup
        public static String staff = "";//mHoten

        public static String maBS = "";
        public static String maYT = "";
        public static String maGiuong = "";
        public static String maBN = "";
        public static String maNV = "";
        public static String maKhu = "";
        /*
         biến dùng để tương tác với các form của bác sĩ
         */
        //-------------------------------
        public static String maBNCanChua = "";
        public static String hoTenBNCanChua = "";
        public static String maSCTApDung = "";
        public static String maVTApDung = "";
        public static String donGiaVTApDUng = "";
        /*
         * mở kết nối tới server 
         * @return trả về 1 nếu thành công
         *         trả về 0 nếu thất bại
      */
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.loginName + ";password=" + Program.loginPassword + ";TrustServerCertificate=True";
                Program.conn.ConnectionString = Program.connstr;

                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " + e.Message, "", MessageBoxButtons.OK);

                return 0;
            }
        }
        public static String convertToSqlDate(String date)
        {//01-01-2902
            string[] result = date.Split(' ');
            string d = result[0];
            string[] temp = d.Split('/');

            string dd =temp[0];
            string mm =temp[1];
            string yyyy =temp[2];

            return mm+'/'+dd+'/'+yyyy;
        }
        public static String formatSpinEdit(String num)
        {
            if (num[num.Length-1] == ',')
            {
                num =num.Replace(',', ' ');
            }
            else
            {
                num = num.Replace(',', '.');
            }
            return num;
        }


        /**********************************************
         *  ExecSqlDataReader thực hiện câu lệnh mà dữ liệu trả về chỉ dùng
         *  để xem & không thao tác với nó.
         *
         *  Ví dụ: SELECT * FROM view_DanhSachPhanManh
         **********************************************/
        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }



        /**********************************************
         * Cập nhật trên một stored procedure và không trả về giá trị
         **********************************************/
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }



        public static FormMain formMain;
        public static FormDangNhap formDangNhap;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}
