using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceslidebar
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void adminlogin_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
