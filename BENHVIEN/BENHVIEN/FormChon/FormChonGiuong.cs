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
    public partial class FormChonGiuong : Form
    {
        public FormChonGiuong()
        {
            InitializeComponent();
        }

        private void FormChonGiuong_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.gIUONGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIUONGTableAdapter.FillByDaChon(this.DS.GIUONG);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maGiuong = ((DataRowView)gIUONGBindingSource.Current)["magiuong"].ToString();
            Program.maGiuong = maGiuong;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
