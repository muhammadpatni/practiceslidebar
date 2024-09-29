using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceslidebar
{
    public partial class employeeview : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public employeeview()
        {
            InitializeComponent();
            form_manager.employeeview=this;
        }
        public bool logic = true;
        private void btnlogout_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
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
        private void btnminimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnmaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                logic = false;
                if (form_manager.employeecustomer != null)
                {
                    form_manager.employeecustomer.interfaceadjustment();
                }
                WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                logic = true;
                if (form_manager.employeecustomer != null)
                {
                    form_manager.employeecustomer.interfaceadjustment();
                }
                WindowState = FormWindowState.Normal;
                
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnadmin_inventory_Click(object sender, EventArgs e)
        {
            loadform(new employeebill());
            btnemployee_customer.Location = new Point(10, 0);
            btnemployee_customer.Size = new Size(204, 48);
            btnemployee_invoices.Location = new Point(0, 48);
            btnemployee_invoices.Size = new Size(214, 48);

            SqlCommand cmd = new SqlCommand("select max(id) as id from customer", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                int i;
                if (sdr["id"] == DBNull.Value)
                {
                    i = 1;
                    form_manager.employeebill.txtcusid.Text= i.ToString();
                    form_manager.employeebill.txtinnumber.Text = i.ToString();
                }
                else
                {
                    i = Convert.ToInt32(sdr["id"]) + 1;

                    form_manager.employeebill.txtcusid.Text = i.ToString();
                    form_manager.employeebill.txtinnumber.Text = i.ToString();
                }
            }
            con.Close();
            form_manager.employeebill.txtcusname.Focus();
           
        }

        private void btnadmin_stock_Click(object sender, EventArgs e)
        {
            loadform(new employeecustomer());
            btnemployee_invoices.Location = new Point(10, 48);
            btnemployee_invoices.Size = new Size(204, 48);
            btnemployee_customer.Location = new Point(0, 0);
            btnemployee_customer.Size = new Size(214, 48);
        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
