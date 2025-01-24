﻿using System;
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
    public partial class messagebox : Form
    {
        public messagebox()
        {
            InitializeComponent();
            form_manager.messagebox = this; 
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ok_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Hide();
            }
        }
    }
}
