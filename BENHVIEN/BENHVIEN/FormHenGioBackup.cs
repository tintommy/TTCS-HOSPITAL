using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENHVIEN
{
    public partial class FormHenGioBackup : Form
    {
        public FormHenGioBackup()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = "nhấn save để chọn";

            SaveFileDialog sf = new SaveFileDialog();

            sf.FileName = path;

            if (sf.ShowDialog() == DialogResult.OK)
            {

                string savePath = Path.GetDirectoryName(sf.FileName);
                txtPATH.Text = savePath.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPATH.Text == "")
            {
                MessageBox.Show("Hãy chọn nơi lưu file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (txtNAME.Text == "")
            {
                MessageBox.Show("Hãy chọn tên File", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            String time=txtTime.Text.ToString().Replace(":","")+"00";
            MessageBox.Show(time, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            String path = txtPATH.Text.ToString().Trim() + "\\" + txtNAME.Text.ToString().Trim() + ".bak";

            String command = "EXEC BACKUP_DATABASE " + "@PATH= N''" + path + "''";

          
            String query = "EXEC AUTOBACKUP " + "@COMMAND= N'" + command + "', @TIME= "+time ;
           


            Program.loi = 0;
           int n = Program.ExecSqlNonQuery(query);
            if (Program.loi == 1)
            {
                MessageBox.Show("Không thể tạo auto backup do có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.loi = 0;
                return;
            }
            MessageBox.Show("Tạo auto backup thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtTime_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
