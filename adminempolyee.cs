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
            form_manager.adminempolyee = this;
        }
        void reset()
        {
            ownerinventoryview.ClearSelection();
            txtname.Clear();
            txtsalary.Clear();
            combocategory.SelectedIndex = -1;
            txtemail.Clear();
            txtcontact.Clear();
            txtusername.Clear();
            txtpassword.Clear();
        }
        private void getinventoryrecord()
        {
            string query = "select id,name,email,contact,position,salary,username,password from employee where position!='owner'; ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ownerinventoryview.DataSource = dt;
            fullinventoryview.DataSource = dt;
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
            getinventoryrecord();
            reset();
            paneleditor.Visible = false;
            panelfullinventory.Visible = false;
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
            txtsalary.Visible = true;
            txtusername.Visible = true;
            txtpassword.Visible = true;
            txtname.Visible = true;
            txtemail.Visible = true;
            txtcontact.Visible = true;
            label3.Visible = true;
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
            SqlCommand cmd = new SqlCommand("select max(id) as id from employee", con);
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
            txtsalary.Visible = true;
            txtname.Visible = true;
            txtemail.Visible = true;
            txtcontact.Visible = true;
            txtusername.Visible = true;
            txtpassword.Visible = true;
            label3.Visible = true;
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
            txtsalary.Visible = false;
            txtname.Visible = false;
            txtemail.Visible = false;
            txtcontact.Visible = false;
            combocategory.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txtusername.Visible = false;
            txtpassword.Visible = false;
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
        private void btnfullinventory_Click(object sender, EventArgs e)
        {
            ppp.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panelfullinventory.Visible = true;
            panelfullinventory.Dock = DockStyle.Fill;
            reset();
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
            reset();
        }
        private void btnfullinventorycancel_Click(object sender, EventArgs e)
        {
            panelfullinventory.Visible = false;
            panel1.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
            ppp.Visible = false;
        }
        private void btnreset_Click(object sender, EventArgs e)

        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;
        }
        public void changes()
        {
            if (form_manager.adminview.isvalid1)
            {
                if (btneditoroperator.Text == "Delete" || btneditoroperator.Text == "Update" || btneditoroperator.Text == "Add")
                { panel5.Size = new Size(1063, 215); }
                else
                { panel5.Size = new Size(1063, 400); }
            }
            else
            {
                if (btneditoroperator.Text == "Delete" || btneditoroperator.Text == "Update" || btneditoroperator.Text == "Add")
                { panel5.Size = new Size(1063, 300); }
                else { panel5.Size = new Size(1063, 550); }
            }
        }
        private void paneleditor_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from employee where cast (id as varchar) like  @id +'%' and  position !='owner'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", txtsearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                ownerinventoryview.DataSource = dataTable;
            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                ownerinventoryview.DataSource = null;
            }
        }
        private void combosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from employee where position like  @position +'%' and  position !='owner'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@position", combosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                ownerinventoryview.DataSource = dataTable;

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                ownerinventoryview.DataSource = null;
            }
        }
        private void fireset_Click(object sender, EventArgs e)
        {
            fisearch.Clear();
            ficombosort.SelectedIndex = -1;
        }
        private void fisearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from employee where cast (id as varchar) like  @id +'%' and  position !='owner'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", fisearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                fullinventoryview.DataSource = dataTable;

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                fullinventoryview.DataSource = null;
            }
        }
        private void ficombosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from employee where position like  @position +'%' and  position !='owner'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@position", ficombosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                fullinventoryview.DataSource = dataTable;

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                fullinventoryview.DataSource = null;
            }
        }

        private void ownerinventoryview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ownerinventoryview.Rows[e.RowIndex];
                if (btneditoroperator.Text != "Add")
                { txtid.Text = selectedRow.Cells[0].Value.ToString(); }
                txtname.Text = selectedRow.Cells[1].Value.ToString();
                txtemail.Text = selectedRow.Cells[2].Value.ToString();
                txtcontact.Text = selectedRow.Cells[3].Value.ToString();
                combocategory.SelectedItem = selectedRow.Cells[4].Value.ToString();
                txtsalary.Text = selectedRow.Cells[5].Value.ToString();
                txtusername.Text = selectedRow.Cells[6].Value.ToString();
                txtpassword.Text = selectedRow.Cells[7].Value.ToString();
            }
        }

        private void combocategory_TextChanged(object sender, EventArgs e)
        {
            if (btneditoroperator.Text != "Delete")
            {
                if (combocategory.Text == "admin")
                {
                    txtusername.Visible = false;
                    label10.Visible = false;
                }
                else
                {
                    txtusername.Visible = true;
                    label10.Visible = true;
                }
            }
        }

        private void combocategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btneditoroperator.Text!="Delete")
            {
                if (combocategory.Text == "admin")
                {
                    txtusername.Visible = false;
                    label10.Visible = false;
                }
                else
                {
                    txtusername.Visible = true;
                    label10.Visible = true;
                }
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtid.Text))
            {
                if (btneditoroperator.Text == "Update")
                { label16.Visible = true; }
            }
            else
            {
               label16.Visible=false;
            }

        }
    }
}
