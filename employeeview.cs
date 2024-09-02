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
    public partial class employeeview : Form
    {
        public employeeview()
        {
            InitializeComponent();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadmin_inventory_Click(object sender, EventArgs e)
        {
            btnemployee_customer.Location = new Point(10, 0);
            btnemployee_customer.Size = new Size(204, 48);
            btnemployee_bills.Location = new Point(0, 96);
            btnemployee_invoices.Location = new Point(0, 48);
            btnemployee_bills.Size = new Size(214, 48);
            btnemployee_invoices.Size = new Size(214, 48);
        }

        private void btnadmin_stock_Click(object sender, EventArgs e)
        {
            btnemployee_invoices.Location = new Point(10, 48);
            btnemployee_invoices.Size = new Size(204, 48);
            btnemployee_customer.Location = new Point(0, 0);
            btnemployee_bills.Location = new Point(0, 96);
            btnemployee_bills.Size = new Size(214, 48);
            btnemployee_customer.Size = new Size(214, 48);
        }

        private void btnadmin_employee_Click(object sender, EventArgs e)
        {
            btnemployee_bills.Location = new Point(10, 96);
            btnemployee_bills.Size = new Size(204, 48);
            btnemployee_customer.Location = new Point(0, 0);
            btnemployee_invoices.Location = new Point(0, 48);
            btnemployee_invoices.Size = new Size(214, 48);
            btnemployee_customer.Size = new Size(214, 48);
        }
    }
}
