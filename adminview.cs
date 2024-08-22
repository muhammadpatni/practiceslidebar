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
                isvalid1 = false;
                WindowState = FormWindowState.Maximized; 
            }
            else
            {
                isvalid = false;
                isvalid1 = true;
                WindowState = FormWindowState.Normal;
            }
            if (form_manager.adminInventory != null)
            { form_manager.adminInventory.changes(); }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

       

        

        private void btnadmin_stock_Click(object sender, EventArgs e)
        {   
            btnadmin_stock.Location = new Point(10, 48);
            btnadmin_stock.Size = new Size(204, 48);
            btnadmin_inventory.Location = new Point(0, 0);
            btnadmin_employee.Location = new Point(0, 96);
            btnadmin_employee.Size = new Size(214, 48);
            btnadmin_inventory.Size = new Size(214, 48);

        }

        private void btnadmin_employee_Click(object sender, EventArgs e)
        {
            btnadmin_employee.Location = new Point(10, 96);
            btnadmin_employee.Size = new Size(204, 48);
            btnadmin_inventory.Location = new Point(0, 0);
            btnadmin_stock.Location = new Point(0, 48);
            btnadmin_stock.Size = new Size(214, 48);
            btnadmin_inventory.Size = new Size(214, 48);
        }

        private void btnadmin_inventory_Click(object sender, EventArgs e)
        {
            btnadmin_inventory.Location = new Point(10, 0);
            btnadmin_inventory.Size = new Size(204, 48);
            btnadmin_employee.Location = new Point(0, 96);
            btnadmin_stock.Location = new Point(0, 48);
            btnadmin_employee.Size = new Size(214, 48);
            btnadmin_stock.Size = new Size(214, 48);

            loadform(new admininventory());
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
