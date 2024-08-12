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
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace practiceslidebar
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            form_manager.mainforminstance = this;
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
           
       
          
        }
       
       

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void combouser_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (combouser.Text == "owner")
            {
                loadform(new login2());
                form_manager.employeelogin.changeuser("owner");
            }
            else if (combouser.Text =="admin")
            {
                loadform(new login2());
                form_manager.employeelogin.changeuser("admin");
            }
            else if (combouser.Text == "employee")
            {
                loadform(new login2());
            }


        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
