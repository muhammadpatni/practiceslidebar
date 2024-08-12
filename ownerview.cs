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
    public partial class ownerview : Form
    {
        public ownerview()
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
       

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnonwer_dash_Click(object sender, EventArgs e)
        {
            btnonwer_dash.Location = new Point(10, 0);
            btnonwer_dash.Size = new Size(186, 48);
            btnownwe_employee.Location = new Point(0, 96);
            btnownwe_inventory.Location = new Point(0,48);
            btnownwe_employee.Size = new Size(196, 48);
            btnownwe_inventory.Size = new Size(196, 48);

            loadform(new Ownerdash());
        }

        private void btnownwe_inventory_Click(object sender, EventArgs e)
        {
            btnownwe_inventory.Location = new Point(10, 48);
            btnownwe_inventory.Size = new Size(186, 48);
            btnonwer_dash.Location = new Point(0, 0);
            btnownwe_employee.Location = new Point(0, 96);
            btnownwe_employee.Size = new Size(196, 48);
            btnonwer_dash.Size = new Size(196, 48);

            loadform(new ownerInventory());
        }



        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnownwe_employee_Click(object sender, EventArgs e)
        {
            btnownwe_employee.Location = new Point(10, 96);
            btnownwe_employee.Size = new Size(186, 48);
            btnownwe_inventory.Location = new Point(0, 48);
            btnonwer_dash.Location = new Point(0, 0);
            btnonwer_dash.Size = new Size(196, 48);
            btnownwe_inventory.Size = new Size(196, 48);

            loadform(new Owner_Employees());
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState=FormWindowState.Maximized;
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

        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
