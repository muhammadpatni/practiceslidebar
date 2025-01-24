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
    public partial class adminview : Form
    {
        public bool isvalid =false,isvalid1=true;
        public adminview()
        {
            InitializeComponent();
            form_manager.adminview=this;
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

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                isvalid = true;
                logic = false;
                if (form_manager.adminInventory != null)
                {
                    form_manager.adminInventory.interfaceadjustment();
                    form_manager.adminInventory.interfaceadjustment1();
                }
                if (form_manager.adminempolyee != null)
                {
                    form_manager.adminempolyee.interfaceadjustment();
                    form_manager.adminempolyee.interfaceadjustment1();
                }
                if (form_manager.adminoutofstock != null)
                {
                    form_manager.adminoutofstock.interfaceadjustment();
                }
                if (form_manager.adminexpireproducts != null)
                {
                    form_manager.adminexpireproducts.interfaceadjustment();
                }
                isvalid1 = false;
                WindowState = FormWindowState.Maximized; 
            }
            else
            {
                logic = true;
                if (form_manager.adminInventory != null)
                {
                    form_manager.adminInventory.interfaceadjustment();
                    form_manager.adminInventory.interfaceadjustment1();
                }
                if (form_manager.adminempolyee != null)
                {
                    form_manager.adminempolyee.interfaceadjustment();
                    form_manager.adminempolyee.interfaceadjustment1();
                }
                if (form_manager.adminoutofstock != null)
                {
                    form_manager.adminoutofstock.interfaceadjustment();
                }
                if (form_manager.adminexpireproducts != null)
                {
                    form_manager.adminexpireproducts.interfaceadjustment();
                }
                isvalid = false;
                isvalid1 = true;
                WindowState = FormWindowState.Normal;
            }
            if (form_manager.adminInventory != null)
            { form_manager.adminInventory.changes(); }
            if (form_manager.adminempolyee != null)
            { form_manager.adminempolyee.changes(); }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void interfacedesign()
        {

            if (btnadmin_inventory.BaseColor == Color.Snow)
            {
                btnadmin_inventory.OnHoverBaseColor = Color.Snow;
                btnadmin_inventory.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnadmin_inventory.OnHoverBaseColor = Color.DimGray;
                btnadmin_inventory.OnHoverForeColor = Color.White;
            }
            if (btnadmin_employee.BaseColor == Color.Snow)
            {
                btnadmin_employee.OnHoverBaseColor = Color.Snow;
                btnadmin_employee.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnadmin_employee.OnHoverBaseColor = Color.DimGray;
                btnadmin_employee.OnHoverForeColor = Color.White;
            }
            if (btnadmin_stock.BaseColor == Color.Snow)
            {
                btnadmin_stock.OnHoverBaseColor = Color.Snow;
                btnadmin_stock.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnadmin_stock.OnHoverBaseColor = Color.DimGray;
                btnadmin_stock.OnHoverForeColor = Color.White;
            }
            if (btnadmin_expireproduct.BaseColor == Color.Snow)
            {
                btnadmin_expireproduct.OnHoverBaseColor = Color.Snow;
                btnadmin_expireproduct.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnadmin_expireproduct.OnHoverBaseColor = Color.DimGray;

            }
        }
        private void btnadmin_stock_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel5.Visible = false;
            panel7.Visible = false;
            panel4.Visible = false;
            btnadmin_stock.BaseColor = Color.Snow;
            btnadmin_stock.Radius = 24;
            btnadmin_stock.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_employee.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_employee.Radius = 0;
            btnadmin_employee.ForeColor = Color.White;
            btnadmin_expireproduct.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_expireproduct.Radius = 0;
            btnadmin_expireproduct.ForeColor = Color.White;
            btnadmin_inventory.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_inventory.Radius = 0;
            btnadmin_inventory.ForeColor = Color.White;
            interfacedesign();
            loadform(new adminoutofstock());
        }

        private void btnadmin_employee_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            panel5.Visible = false;
            panel8.Visible = false;
            panel4.Visible = false;
            btnadmin_employee.BaseColor = Color.Snow;
            btnadmin_employee.Radius = 24;
            btnadmin_employee.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_stock.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_stock.Radius = 0;
            btnadmin_stock.ForeColor = Color.White;
            btnadmin_expireproduct.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_expireproduct.Radius = 0;
            btnadmin_expireproduct.ForeColor = Color.White;
            btnadmin_inventory.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_inventory.Radius = 0;
            btnadmin_inventory.ForeColor = Color.White;
            interfacedesign();
            loadform(new adminempolyee());
        }

        private void btnadmin_expireproduct_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel5.Visible = false;
            panel8.Visible = false;
            panel4.Visible = true;
            btnadmin_expireproduct.BaseColor = Color.Snow;
            btnadmin_expireproduct.Radius = 24;
            btnadmin_expireproduct.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_stock.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_stock.Radius = 0;
            btnadmin_stock.ForeColor = Color.White;
            btnadmin_inventory.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_inventory.Radius = 0;
            btnadmin_inventory.ForeColor = Color.White;
            btnadmin_employee.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_employee.Radius = 0;
            btnadmin_employee.ForeColor = Color.White;
            interfacedesign();
            loadform(new adminexpireproducts());
        }


        private void btnadmin_inventory_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel4.Visible = false;
            btnadmin_inventory.BaseColor = Color.Snow;
            btnadmin_inventory.Radius = 24;
            btnadmin_inventory.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_employee.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_employee.Radius = 0;
            btnadmin_employee.ForeColor = Color.White;
            btnadmin_expireproduct.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_expireproduct.Radius = 0;
            btnadmin_expireproduct.ForeColor = Color.White;
            btnadmin_stock.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnadmin_stock.Radius = 0;
            btnadmin_stock.ForeColor = Color.White;
            interfacedesign();
            loadform(new admininventory());
        }

    }
}
