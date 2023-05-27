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
    public partial class FormYTa : Form
    {
        public FormYTa()
        {
            InitializeComponent();
        }

        private void yTABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsYTA.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormYTa_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.yTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.yTATableAdapter.Fill(this.DS.YTA);

            this.tHONGTINYTATableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHONGTINYTATableAdapter.Fill(this.DS.THONGTINYTA);

        }
    }
}
