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
            getinventoryrecord();
            reset();
            paneleditor.Visible = false;
            panelfullinventory.Visible=false;
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;

        }
        private void txtunitprice_TextChanged(object sender, EventArgs e)
        { 
            if (!float.TryParse(txtunitprice.Text, out _ ))
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
            string query = "select * from Inventory2 where name like @name +'%'";
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
            string query = "select * from Inventory2 where category like @category +'%'";
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
            paneleditor.Visible = true;
            label11.Location = new Point(406, 139);
            txtid.Location = new Point(293, 93);
            label8.Location = new Point(323, 71);
            txtid.Size = new Size(439, 39);
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
            btneditoroperator.Text = "Delete";   
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
            reset();
        }

        private void btneditorcancel_Click(object sender, EventArgs e)
        {
            paneleditor.Visible = false;
            panel4.Visible = true;
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
            paneleditor.Visible = true;
            label11.Location = new Point(229,55);
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
            btneditoroperator.Text = "Update";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            paneleditor.Visible = true;
            label11.Location = new Point(229, 55);
            txtid.Location = new Point(22, 45);
            label8.Location = new Point(36,25);
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
            btneditoroperator.Text = "Add";
        }

        private void btnfullinventory_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible=false;
            panelfullinventory.Visible = true;
            panelfullinventory.Dock = DockStyle.Fill;

        }
        private void btnfullinventorycancel_Click(object sender, EventArgs e)
        {
            panelfullinventory.Visible = false;
            panel1.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
        }

        private void fullinventorysearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Inventory2 where name like @name +'%'";
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

        private void fullinventorycombosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Inventory2 where category like @category +'%'";
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
    }
}
