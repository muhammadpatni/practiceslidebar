using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace practiceslidebar
{
    public partial class ownerlogin : Form
    {
        public ownerlogin()
        {
            InitializeComponent();
        }
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");

        private void ownerlogin_Load(object sender, EventArgs e)
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

        private void btnlogin_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from ownerlogin where password= '" + txtpassword.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                ownerview o = new ownerview();
                o.Show();
                form_manager.MainFormInstance.Hide();

            }
            else
            { MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }  
    } 
}

