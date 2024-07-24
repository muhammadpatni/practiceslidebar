using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceslidebar
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        { 
            

            if (this.panelmain.Controls.Count > 0)
            {
                this.panelmain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelmain.Controls.Add(f);
            this.panelmain.Tag = f;
            f.Show();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void employee_Click(object sender, EventArgs e)
        {
            btnemployee.BaseColor = Color.Gray;
            btnadmin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            btnonwer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            loadform(new employeelogin());
        }
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnonwer_Click(object sender, EventArgs e)
        {
            btnonwer.BaseColor=Color.Gray;
            btnadmin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            btnemployee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            loadform(new ownerlogin());
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            btnadmin.BaseColor=Color.Gray;
          btnonwer.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
           btnemployee.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            loadform(new adminlogin());
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }

    }

}
