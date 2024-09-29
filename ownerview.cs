using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            form_manager.ownerview = this;
        }
        public bool logic = true;
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
        void interfacedesign()
        {

            if (btnonwer_dash.BaseColor == Color.Snow)
            {
                btnonwer_dash.OnHoverBaseColor = Color.Snow;
                btnonwer_dash.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnonwer_dash.OnHoverBaseColor = Color.DimGray;
                btnonwer_dash.OnHoverForeColor = Color.White;
            }
            if (btnownwe_inventory.BaseColor == Color.Snow)
            {
                btnownwe_inventory.OnHoverBaseColor = Color.Snow;
                btnownwe_inventory.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnownwe_inventory.OnHoverBaseColor = Color.DimGray;
                btnownwe_inventory.OnHoverForeColor = Color.White;
            }
            if (btnownwe_employee.BaseColor == Color.Snow)
            {
                btnownwe_employee.OnHoverBaseColor = Color.Snow;
                btnownwe_employee.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnownwe_employee.OnHoverBaseColor = Color.DimGray;
                btnownwe_employee.OnHoverForeColor = Color.White;
            }
        }
        private void btnonwer_dash_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            btnonwer_dash.BaseColor = Color.Snow;
            btnonwer_dash.Radius = 24;
            btnonwer_dash.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnownwe_inventory.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnownwe_inventory.Radius = 0;
            btnownwe_inventory.ForeColor = Color.White;
            btnownwe_employee.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnownwe_employee.Radius = 0;
            btnownwe_employee.ForeColor = Color.White;
            interfacedesign();
            loadform(new Ownerdash());
        }

        private void btnownwe_inventory_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel5.Visible = false;
            panel7.Visible = false;
            btnownwe_inventory.BaseColor = Color.Snow;
            btnownwe_inventory.Radius = 24;
            btnownwe_inventory.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnonwer_dash.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnonwer_dash.Radius = 0;
            btnonwer_dash.ForeColor = Color.White;
            btnownwe_employee.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnownwe_employee.Radius = 0;
            btnownwe_employee.ForeColor = Color.White;
            interfacedesign();
            loadform(new ownerInventory());
        }

        private void btnownwe_employee_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel5.Visible = false;
            panel8.Visible = false;
            btnownwe_employee.BaseColor = Color.Snow;
            btnownwe_employee.Radius = 24;
            btnownwe_employee.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnownwe_inventory.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnownwe_inventory.Radius = 0;
            btnownwe_inventory.ForeColor = Color.White;
            btnonwer_dash.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnonwer_dash.Radius = 0;
            btnonwer_dash.ForeColor = Color.White;
            interfacedesign();
            loadform(new Owner_Employees());
        }
        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Normal)
            {
                WindowState=FormWindowState.Maximized;
                logic = false;
                if(form_manager.ownerInventory!=null)
                {
                    form_manager.ownerInventory.interfaceadjustment();
                }
                if (form_manager.Owner_Employees != null)
                {
                    form_manager.Owner_Employees.interfaceadjustment();
                }
            }
            else 
            {
                     WindowState = FormWindowState.Normal;
                logic = true;
                if (form_manager.ownerInventory != null)
                {
                    form_manager.ownerInventory.interfaceadjustment();
                }
                if (form_manager.Owner_Employees != null)
                {
                    form_manager.Owner_Employees.interfaceadjustment();
                }
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
