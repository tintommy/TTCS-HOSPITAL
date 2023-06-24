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
    public partial class FormChonBenhNhanInHoaDon : Form
    {
        public FormChonBenhNhanInHoaDon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FormChonBenhNhanInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALDataSet.BENHNHAN' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.BenhNhanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.BenhNhanTableAdapter.Fill(this.DS.BENHNHAN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)BenhNhanBDS[BenhNhanBDS.Position]);
            Program.maBNCanInHD = drv["MaBenhNhan"].ToString();
            Program.hoTenBNCanInHD = drv["Ho"].ToString() + " " + drv["Ten"].ToString();
            this.Dispose();
        }
    }
}
