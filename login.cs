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
            form_manager.MainFormInstance = this;
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
            btnemployee.Location = new Point(10, 92);
            btnemployee.Size = new Size(165, 48);
            btnonwer.Location = new Point(0,0);
            btnadmin.Location = new Point(0,45);
            btnadmin.Size = new Size(175, 50);
            btnonwer.Size = new Size(175, 50);
       
           
            loadform(new employeelogin());
        }
        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnonwer_Click(object sender, EventArgs e)
        {
            btnonwer.Location = new Point(10, 0);
            btnonwer.Size=new Size(165,48);
            btnadmin.Location = new Point(0,45);
            btnemployee.Location = new Point(0,92);
            btnemployee.Size = new Size(175, 50);
            btnadmin.Size = new Size(175, 50);
          
          
            loadform(new ownerlogin());
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            btnadmin.Location = new Point(10, 45);
            btnadmin.Size = new Size(165, 48);
            btnemployee.Location = new Point(0,92);
            btnonwer.Location = new Point(0,0);
            btnonwer.Size = new Size(175, 50);
            btnemployee.Size = new Size(175, 50);
           
            
            loadform(new adminlogin());
        }

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
