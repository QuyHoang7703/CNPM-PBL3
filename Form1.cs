using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_PBL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button_quenMK_Click(object sender, EventArgs e)
        {
            panel_login.Visible = false;
        }

        private void guna2Button_Login_Click(object sender, EventArgs e)
        {
            panel_login.Visible = true;
        }

        private void picture_hien_Click(object sender, EventArgs e)
        {
            if (guna2TextBox_pasword.PasswordChar == '\0')
            {
                picture_an.BringToFront();
                guna2TextBox_pasword.PasswordChar = '•';
            }
        }

        private void picture_an_Click_1(object sender, EventArgs e)
        {
            if (guna2TextBox_pasword.PasswordChar == '•')
            {
                picture_hien.BringToFront();
                guna2TextBox_pasword.PasswordChar = '\0';
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
