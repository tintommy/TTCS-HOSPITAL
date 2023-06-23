using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENHVIEN.FormChon
{
    public partial class FormChonKhu : Form
    {
        public FormChonKhu()
        {
            InitializeComponent();
        }

        private void kHUCHUATRIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUCHUATRIBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonKhu_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.kHUCHUATRITableAdapter.Connection.ConnectionString = Program.connstr;

            this.kHUCHUATRITableAdapter.Fill(this.DS.KHUCHUATRI);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string maKhu = ((DataRowView)kHUCHUATRIBindingSource.Current)["sokhu"].ToString();
            Program.maKhu = maKhu;
            string tenKhu = ((DataRowView)kHUCHUATRIBindingSource.Current)["ten"].ToString();
            Program.tenKhu = tenKhu;
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
