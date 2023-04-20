using CNPM_PBL3.BLL;
using CNPM_PBL3.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3.View
{
    public partial class FStaff : Form
    {
        public FStaff()
        {
            InitializeComponent();
            showDGV();
        }
        public void showDGV()
        {
            QLNVDAL dal = new QLNVDAL();    
            dataGridView1.DataSource= dal.GetAllNV();
          // guna2DataGridView1.DataSource= dal.GetAllNV();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            //QLForm.Instance.OpenChildForm(, new FDetailStaff());
            this.Close();
            FDetailStaff f = new FDetailStaff();

            f.Show();
        }
    }
}
