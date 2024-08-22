using System;
using System.Collections;
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
    public partial class admininventory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public admininventory()
        {
            InitializeComponent();
            form_manager.adminInventory = this;
        }


        void reset()
        {

            ownerinventoryview.ClearSelection();
            txtname.Clear();
            txtmanufacturer.Clear();
            combocategory.SelectedIndex = -1;
            txtquantity.Clear();
            txtunitprice.Clear();
            daterecieved.Value = DateTime.Now;
            expirydate.Value = DateTime.Now;
        }

        private void getinventoryrecord()
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ownerinventoryview.DataSource = dt;
            fullinventoryview.DataSource = dt;
        }

        private void admininventory_Load(object sender, EventArgs e)
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
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;

        }
        private void txtunitprice_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtunitprice.Text, out _))
            {
                label12.Text = "Numeric value only";
            }
            else
            {
                label12.Text = "";
            }
            if (string.IsNullOrEmpty(txtunitprice.Text))
            {
                label12.Text = "";
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", txtsearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                ownerinventoryview.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("!!! no record found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ownerinventoryview.DataSource = null;
            }
        }

        private void combosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where category like @category +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@category", combosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                ownerinventoryview.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("!!! no record found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ownerinventoryview.DataSource = null;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            label16.Visible = false;
            paneleditor.Visible = true;
            label11.Location = new Point(406, 160 );
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





        private void btneditoroperator_Click(object sender, EventArgs e)
        {
            if (btneditoroperator.Text == "Delete")
            {
                bool test = false;
                string query1 = @"

          CREATE TABLE inventory_Temp (
          id int primary key ,
          quantity int,
          category varchar(50),
          unitprice decimal(10,2),
          manufacturer varchar(255),
          daterecieved date ,
          name varchar(255),
          expirydate date  
          );
          ALTER TABLE inventory_Temp
          ADD status AS 
              CASE 
                  WHEN quantity = 0 THEN 'Out of Stock'
                  ELSE 'In Stock'
              END;";
                string query2 = "delete from Inventory2 where id =@id";
                string query3 = @"INSERT INTO inventory_Temp (id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate)
          SELECT ROW_NUMBER() OVER (ORDER BY id) AS id, name,quantity,category,unitprice,manufacturer,daterecieved,expirydate
          FROM Inventory2;
          drop table Inventory2;
          EXEC sp_rename 'inventory_Temp', 'Inventory2';
          ";
                try
                {
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
                    con.Open();
                    int i = cmd2.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("data deleted succesfully");
                        reset();
                        test = true;
                        txtid.Clear();
                    }
                    else
                    { MessageBox.Show("productID not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch
                { MessageBox.Show("ProductID is required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { con.Close(); }
                if (test)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                }
                if(btneditoroperator.Text == "Update")
                {
                    


                }
                getinventoryrecord();
            }

        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;
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
            paneleditor.Visible = false;
            panel5.Size = new Size(1063, 400);
            panel4.Visible = true;
            ppp.Visible = false;
            if (form_manager.adminview.isvalid && panel5.Height == 400)
            {
                panel5.Height = 550;
            }
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

        private void txtunitprice_TextChanged_1(object sender, EventArgs e)
        {
            if (!float.TryParse(txtunitprice.Text, out _))
            {
                label12.Text = "Numeric value only";
            }
            else
            {
                label12.Text = "";
            }
            if (string.IsNullOrEmpty(txtunitprice.Text))
            {
                label12.Text = "";
                if (btneditoroperator.Text == "Update")
                {label16.Visible = true; }

            }
            else { 
            label16.Visible=false;
                }

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
                else { panel5.Size = new Size(1063,550); }


            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtquantity.Text, out _))
            {
                label13.Text = "Numeric value only";
            }
            else
            {
                label13.Text = "";
            }
            if (string.IsNullOrEmpty(txtquantity.Text))
            {
                label13.Text = "";
            }
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
            txtid.Enabled=false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            label16.Visible=false;
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
            SqlDataReader sdr=cmd.ExecuteReader();
         if (sdr.Read())
                { int i;
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
        private void btnfullinventorycancel_Click(object sender, EventArgs e)
        {
            panelfullinventory.Visible = false;
            panel1.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
            ppp.Visible = false;
        }

        private void fireset_Click(object sender, EventArgs e)
        {
            fisearch.Clear();
            ficombosort.SelectedIndex = -1;
        }

        private void fisearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", fisearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                fullinventoryview.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("!!! no record found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fullinventoryview.DataSource = null;
            }
        }

        private void ficombosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where category like @category +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@category", ficombosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                fullinventoryview.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("!!! no record found", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                fullinventoryview.DataSource = null;
            }
        }

        private bool is_valid()
        {
            if (txtid.Text == string.Empty)
            {
                MessageBox.Show("please select a recorf ", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtname.Text == string.Empty)
            {
                MessageBox.Show("product name  is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (combocategory.Text == string.Empty)
            {
                MessageBox.Show("category  is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtmanufacturer.Text == string.Empty)
            {
                MessageBox.Show("company  is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtunitprice.Text == string.Empty)
            {
                MessageBox.Show("price  is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtquantity.Text == string.Empty)
            {
                MessageBox.Show("quantity is required", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void ownerinventoryview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ownerinventoryview.Rows[e.RowIndex];

                if (btneditoroperator.Text != "Add")
                { txtid.Text = selectedRow.Cells[0].Value.ToString(); }
                txtname.Text = selectedRow.Cells[1].Value.ToString();
                txtquantity.Text = selectedRow.Cells[2].Value.ToString();
                combocategory.SelectedItem = selectedRow.Cells[3].Value.ToString();
                txtunitprice.Text = selectedRow.Cells[4].Value.ToString();
                txtmanufacturer.Text = selectedRow.Cells[5].Value.ToString();
                string dateRecieved = selectedRow.Cells[6].Value.ToString();
                string ExpiryDate = selectedRow.Cells[7].Value.ToString();
                if (DateTime.TryParse(ExpiryDate, out DateTime expiryDate))
                {
                    expirydate.Value = expiryDate;
                }
                if (DateTime.TryParse(dateRecieved, out DateTime Daterecieved))
                {
                    daterecieved.Value = Daterecieved;
                }

            }
        }

        private void ownerinventoryview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void paneleditor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 
