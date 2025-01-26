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
                if (form_manager.employeebill != null)
                {
                    form_manager.employeebill.interfaceadjustmaxmin();
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
                if (form_manager.employeebill != null)
                {
                    form_manager.employeebill.interfaceadjustmaxmin();
                }

                WindowState = FormWindowState.Normal;
                
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void interfacedesign()
        {

            if (btnemployeebill.BaseColor == Color.Snow)
            {
                btnemployeebill.OnHoverBaseColor = Color.Snow;
                btnemployeebill.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnemployeebill.OnHoverBaseColor = Color.DimGray;
                btnemployeebill.OnHoverForeColor = Color.White;
            }
            if (btnemployeecustomer.BaseColor == Color.Snow)
            {
                btnemployeecustomer.OnHoverBaseColor = Color.Snow;
                btnemployeecustomer.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnemployeecustomer.OnHoverBaseColor = Color.DimGray;
                btnemployeecustomer.OnHoverForeColor = Color.White;
            }
            if (btnemployeeclaim.BaseColor == Color.Snow)
            {
                btnemployeeclaim.OnHoverBaseColor = Color.Snow;
                btnemployeeclaim.OnHoverForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            }
            else
            {
                btnemployeeclaim.OnHoverBaseColor = Color.DimGray;
                btnemployeeclaim.OnHoverForeColor = Color.White;
            }
        }
        private void btnadmin_inventory_Click(object sender, EventArgs e)
        {
            loadform(new employeebill());
            panel8.Visible = false;
            panel4.Visible=false;
            panel5.Visible = true;
            btnemployeebill.BaseColor = Color.Snow;
            btnemployeebill.Radius = 24;
            btnemployeebill.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeecustomer.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeecustomer.Radius = 0;
            btnemployeecustomer.ForeColor = Color.White;
            btnemployeeclaim.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeeclaim.Radius = 0;
            btnemployeeclaim.ForeColor = Color.White;
            interfacedesign();
           
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

        private void btnemployeecustomer_Click(object sender, EventArgs e)
        {
            loadform(new employeecustomer());
            panel8.Visible = true;
            panel5.Visible = false;
            panel4.Visible = false;
            btnemployeecustomer.BaseColor = Color.Snow;
            btnemployeecustomer.Radius = 24;
            btnemployeecustomer.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeebill.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeebill.Radius = 0;
            btnemployeebill.ForeColor = Color.White;
            btnemployeeclaim.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeeclaim.Radius = 0;
            btnemployeeclaim.ForeColor = Color.White;
            interfacedesign();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnemployeeclaim_Click(object sender, EventArgs e)
        {
            loadform(new employeeclaim());
            panel8.Visible = false;
            panel5.Visible = false;
            panel4.Visible = true;
            btnemployeeclaim.BaseColor = Color.Snow;
            btnemployeeclaim.Radius = 24;
            btnemployeeclaim.ForeColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeebill.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeebill.Radius = 0;
            btnemployeebill.ForeColor = Color.White;
            btnemployeecustomer.BaseColor = System.Drawing.Color.FromArgb(35, 40, 45);
            btnemployeecustomer.Radius = 0;
            btnemployeecustomer.ForeColor = Color.White;
            interfacedesign();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
