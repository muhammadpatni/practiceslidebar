﻿using System;
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
        void Btnlogin()
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
                {
                    messagebox m = new messagebox();
                    m.Show();
                    form_manager.messagebox.tittle.Text = "Error";
                    form_manager.messagebox.message.Text = "invalid password";
                }
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
                {
                    messagebox m = new messagebox();
                    m.Show();
                    form_manager.messagebox.tittle.Text = "Error";
                    form_manager.messagebox.message.Text = "invalid password";
                }
            }
            else
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from employee where password = '" + txtpassword.Text + "' and username = '" + txtusername.Text + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    employeeview o = new employeeview();
                    o.Show();
                    form_manager.mainforminstance.Hide();

                }
                else
                {
                    messagebox m = new messagebox();
                    m.Show();
                    form_manager.messagebox.tittle.Text = "Error";
                    form_manager.messagebox.message.Text = "invalid login details";
                }
            }

        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            Btnlogin();
        }
        

        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                txtpassword.Focus();
            }

        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btnlogin();
            }
        }
    }
}
