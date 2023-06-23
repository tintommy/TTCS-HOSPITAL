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
    public partial class FormChonBenhNhanChuaTri : Form
    {
        public FormChonBenhNhanChuaTri()
        {
            InitializeComponent();
        }

        //private void fillToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.SP_ChonBenhNhanChuaTriTableAdapter.Fill(this.HospitalDS.SP_ChonBenhNhanChuaTri, maBSToolStripTextBox.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}

        private void FormChonBenhNhanChuaTri_Load(object sender, EventArgs e)
        {
            this.SP_ChonBenhNhanChuaTriTableAdapter.Connection.ConnectionString = Program.connstr;
            this.SP_ChonBenhNhanChuaTriTableAdapter.Fill(this.HospitalDS.SP_ChonBenhNhanChuaTri, Program.userName);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.maBNCanChua = ((DataRowView)SP_ChonBenhNhanChuaTriBDS.Current)["MaBenhNhan"].ToString();
            Program.hoTenBNCanChua = ((DataRowView)SP_ChonBenhNhanChuaTriBDS.Current)["HOTEN"].ToString();
            this.Dispose();
            Program.formMain.showFormChuaTriBenhNhan();
        }
    }
}
