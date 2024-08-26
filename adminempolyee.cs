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
    public partial class adminempolyee : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public adminempolyee()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        void reset()
        {

            adminemployeeview.ClearSelection();
            txtname.Clear();
            txtmanufacturer.Clear();
            combocategory.SelectedIndex = -1;
            txtquantity.Clear();
            txtunitprice.Clear();
            daterecieved.Value = DateTime.Now;
            expirydate.Value = DateTime.Now;
        }
        private void btneditorclear_Click(object sender, EventArgs e)
        {
            if (btneditoroperator.Text == "Delete")
            {
                txtid.Clear();
            }
            if (btneditoroperator.Text == "Update")
            {
                txtid.Enabled = true;
                txtid.Clear();
                txtid.Enabled = false;

            }
            reset();
        }

        private void btneset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;
        }

        private void paneleditor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btneditorcancel_Click(object sender, EventArgs e)
        {
            btneditoroperator.Text = "";
            paneleditor.Visible = false;
            panel4.Visible = true;
            ppp.Visible = false;
            if (form_manager.adminview.isvalid1)
            {
                panel5.Size = new Size(1063, 400);
            }
            else
            {
                panel5.Size = new Size(1063, 550);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            label16.Visible = false;
            paneleditor.Visible = true;
            label11.Location = new Point(229, 55);
            txtid.Location = new Point(22, 45);
            label8.Location = new Point(36, 25);
            txtid.Size = new Size(195, 39);
            txtmanufacturer.Visible = true;
            txtname.Visible = true;
            txtquantity.Visible = true;
            txtunitprice.Visible = true;
            daterecieved.Visible = true;
            label3.Visible = true;
            expirydate.Visible = true;
            combocategory.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            panel4.Visible = false;
            if (form_manager.adminview.isvalid)
            {
                panel5.Height = 300;
            }
            btneditoroperator.Text = "Add";
            reset();
            SqlCommand cmd = new SqlCommand("select max(id) as id from Inventory2", con);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                int i;
                if (sdr["id"] == DBNull.Value)
                {
                    i = 1;
                    txtid.Text = i.ToString();
                }
                else
                {
                    i = Convert.ToInt32(sdr["id"]) + 1;
                    txtid.Text = i.ToString();
                }
            }
            con.Close();
            txtid.Enabled = false;

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            paneleditor.Visible = true;
            label11.Location = new Point(229, 55);
            txtid.Location = new Point(22, 45);
            label8.Location = new Point(36, 25);
            txtid.Size = new Size(195, 39);
            txtmanufacturer.Visible = true;
            txtname.Visible = true;
            txtquantity.Visible = true;
            txtunitprice.Visible = true;
            daterecieved.Visible = true;
            label3.Visible = true;
            expirydate.Visible = true;
            combocategory.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            panel4.Visible = false;
            if (form_manager.adminview.isvalid)
            {
                panel5.Height = 300;
            }
            btneditoroperator.Text = "Update";
            reset();
            txtid.Clear();
            label16.Visible = true;
            txtid.Enabled = false;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            label16.Visible = false;
            paneleditor.Visible = true;
            label11.Location = new Point(406, 160);
            txtid.Location = new Point(395, 112);
            label8.Location = new Point(406, 90);
            txtid.Size = new Size(195, 39);
            txtmanufacturer.Visible = false;
            txtname.Visible = false;
            txtquantity.Visible = false;
            txtunitprice.Visible = false;
            daterecieved.Visible = false;
            expirydate.Visible = false;
            combocategory.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            panel4.Visible = false;
            txtid.Enabled = true;
            if (form_manager.adminview.isvalid)
            {
                panel5.Height = 300;
            }
            btneditoroperator.Text = "Delete";
            txtid.Clear();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

            if (!int.TryParse(txtid.Text, out _))
            {
                label11.Text = "Numeric value only";
            }
            else
            {
                label11.Text = "";
            }
            if (string.IsNullOrEmpty(txtid.Text))
            {
                label11.Text = "";
            }
        }

        private void adminempolyee_Load(object sender, EventArgs e)
        {
            if (form_manager.adminview.isvalid1)
            {
                panel5.Size = new Size(1063, 400);
            }

            if (form_manager.adminview.isvalid)
            {
                panel5.Size = new Size(1063, 550);
            }

            ppp.Visible = false;
           // getinventoryrecord();
            reset();
            paneleditor.Visible = false;
          // panelfullinventory.Visible = false;
        }

        private void adminemployeeview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

