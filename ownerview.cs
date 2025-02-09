﻿using Guna.UI.WinForms;
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
        void UpdateButtonStyles(GunaButton activeButton)
        {
            GunaButton[] buttons = { btnonwer_dash, btnownwe_inventory, btnownwe_employee };

            foreach (var button in buttons)
            {
                if (button == activeButton)
                {
                    button.BaseColor = Color.Snow;
                    button.Radius = 24;
                    button.ForeColor = Color.FromArgb(35, 40, 45);
                    button.OnHoverBaseColor = Color.Snow;
                    button.OnHoverForeColor = Color.FromArgb(35, 40, 45);
                }
                else
                {
                    button.BaseColor = Color.FromArgb(35, 40, 45);
                    button.Radius = 0;
                    button.ForeColor = Color.White;
                    button.OnHoverBaseColor = Color.FromArgb(35, 40, 45);
                    button.OnHoverForeColor = Color.White;
                }
            }
        }
      
        public void loadform(Form form)
        {
            if (this.panelmain.Controls.Count > 0)
            {
                this.panelmain.Controls.RemoveAt(0); // Remove the existing form
            }
            form.TopLevel = false; // Set the form as a child control
            form.Dock = DockStyle.Fill; // Fill the panel with the form
            this.panelmain.Controls.Add(form); // Add the form to the panel
            this.panelmain.Tag = form; // Keep track of the current form
            form.Show(); // Show the form
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
            panel7.Visible = false;
            panel8.Visible = false;
            UpdateButtonStyles(btnonwer_dash);
            loadform(new Ownerdash());
            panel5.Visible = true;
        }

        private void btnownwe_inventory_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel7.Visible = false;
            UpdateButtonStyles(btnownwe_inventory);
            loadform( new ownerInventory());
            panel8.Visible = true;
        }

        private void btnownwe_employee_Click(object sender, EventArgs e)
        {
            
            panel5.Visible = false;
            panel8.Visible = false;
            UpdateButtonStyles(btnownwe_employee);
            loadform(new Owner_Employees());
            panel7.Visible = true;
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
                if (form_manager.Ownerdash != null)
                { 
                   form_manager.Ownerdash.interfaceadjusment();
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
                if (form_manager.Ownerdash != null)
                {
                    form_manager.Ownerdash.interfaceadjusment();
                }
            }
        }

        private void btnminimize_Click(object sender, EventArgs e)
        {
                WindowState = FormWindowState.Minimized;
        }
        private void ownerview_Load(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel8.Visible = false;
            UpdateButtonStyles(btnonwer_dash);
            loadform(new Ownerdash());
            panel5.Visible = true;
            lbname.Text = form_manager.employeelogin.name;
        }

    }
}
