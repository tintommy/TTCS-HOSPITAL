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
    public partial class FormChonBacSi : Form
    {
        public FormChonBacSi()
        {
            InitializeComponent();
        }

        private void FormChonBacSi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hOSPITALDataSet.THONGTINBACSI' table. You can move, or remove it, as needed.
           
            DS.EnforceConstraints = false;
            this.bACSITableAdapter.Connection.ConnectionString = Program.connstr;
            this.bACSITableAdapter.Fill(this.DS.THONGTINBACSI);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maBS = ((DataRowView)bdsBACSI.Current)["mabacsi"].ToString();
            Program.maBS=maBS;
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string maBS = ((DataRowView)bdsBACSI.Current)["mabacsi"].ToString();
            Program.maBS = maBS;
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.maBS = null;
            this.Dispose();
        }
    }
}
