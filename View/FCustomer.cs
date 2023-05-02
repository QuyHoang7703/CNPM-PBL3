using CNPM_PBL3.BLL;
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
    public partial class FCustomer : Form
    {
        public FCustomer()
        {
            InitializeComponent();
            ShowDTGVKH(qLKH_BLL.GetAllKH_BLL());
        }
        QLKH_BLL qLKH_BLL = new QLKH_BLL();
        public void ShowDTGVKH(dynamic list)
        {
            dataGridViewKhachHang.DataSource = list;
        }

        private void ButXem_Click(object sender, EventArgs e)
        {
            DataGridViewColumnCollection l = dataGridViewKhachHang.Columns;
           foreach(DataGridViewColumn col in l)
            {
                string s = col.Name;
                MessageBox.Show(s);
            }
          
        }
    }
}
