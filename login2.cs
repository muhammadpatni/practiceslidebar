using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;

namespace practiceslidebar
{
   
    public partial class login2 : Form
    {
        string temp;
        public login2()
        {
            InitializeComponent();
            form_manager.employeelogin = this;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");

        private void employee_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (showpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        public void changeuser( string ptemp)
        {
            txtusername.Visible = false;
            label2.Visible= false;
            pictureBox1.Location=new Point(154, 61);
            label1.Location = new Point(95, 221);
            txtpassword.Location = new Point(90, 251);
            showpassword.Location = new Point(245, 295);
            btnlogin.Location = new Point(166, 339);
           this.temp = ptemp;



        }
        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (temp == "owner")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from employee where password = '" + txtpassword.Text + "' and position = '" + temp + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    ownerview o = new ownerview();
                    o.Show();
                    form_manager.mainforminstance.Hide();

                }
                else
                { MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        else if (temp == "admin")
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from employee where password = '" + txtpassword.Text + "' and position = '" + temp + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    adminview o = new adminview();
                    o.Show();
                    form_manager.mainforminstance.Hide();

                }
                else
                { MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
          else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from employee where password = '" + txtpassword.Text + "' and username = '" + txtusername.Text+ "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    employeeview o = new employeeview();
                    o.Show();
                    form_manager.mainforminstance.Hide();

                }
                else
                { MessageBox.Show("Invalid Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
