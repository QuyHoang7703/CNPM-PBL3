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
    public partial class FUserControlClock : UserControl
    {
        public FUserControlClock()
        {
            InitializeComponent();
        }
        public byte[] data { get; set; }

        QLHA qLHA = new QLHA();
        public string chiTiet
        {
            get
            {
                return labelChiTiet.Text;

            }
            set
            {
                labelChiTiet.Text = value;

            }
        }
        public string GiaSP
        {
            get
            {
                return labelGiaTri.Text;

            }
            set
            {
                labelGiaTri.Text = value;
            }
        }
        public byte[] hinhAnh
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                PTBHinhAnh.Image = qLHA.ConverByteToTmage(value);
            }
        }
    }
}
