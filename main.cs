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
    public partial class main : Form
    {
        bool slidebarexpand;
        public main()
        {
            InitializeComponent();
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

    
        private void slidebar_tick(object sender, EventArgs e)
        {
            if(slidebarexpand)
            {
                slidebar.Width -= 58;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    slidebarexpand = false;
                    slidebartimer.Stop();
                }
            }
            else
            { slidebar.Width += 164;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    slidebarexpand = true;
                    slidebartimer.Stop();
                }


            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            loadform(new home());
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            loadform(new setting());
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            loadform(new help());
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            loadform(new about());
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
                slidebartimer.Start();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelmain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
