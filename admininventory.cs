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


        }

        private void getinventoryrecord()
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ownerinventoryview.DataSource = dt;
        }

        private void admininventory_Load(object sender, EventArgs e)
        {
            getinventoryrecord();

        }

        private void btndelete_Click(object sender, EventArgs e)
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
            string query3 =@"INSERT INTO inventory_Temp (id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate)
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

       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ownerinventoryview.ClearSelection();
            txtname.Clear();
            txtmanufacturer.Clear();
            combocategory.SelectedIndex = -1;
            txtquantity.Clear();
            txtunitprice.Clear();
            daterecieved.Value=DateTime.Now;
            expirydate.Value = DateTime.Now;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;

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

        private void expirydate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ownerinventoryview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
