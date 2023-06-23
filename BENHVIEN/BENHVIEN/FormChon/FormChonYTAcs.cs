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
    public partial class FormChonYTAcs : Form
    {
        public FormChonYTAcs()
        {
            InitializeComponent();
        }

        private void yTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tHONGTINYTABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormChonYTAcs_Load(object sender, EventArgs e)
        {
         

            DS.EnforceConstraints = false;

            this.tHONGTINYTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHONGTINYTATableAdapter.Fill(this.DS.THONGTINYTA);


        }

        private void yTABindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.maYT = ((DataRowView)tHONGTINYTABindingSource.Current)["mayt"].ToString();
           
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
