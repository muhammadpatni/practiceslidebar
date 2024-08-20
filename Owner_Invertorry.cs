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
    public partial class ownerInventory : Form
    { SqlConnection con=new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public ownerInventory()
        {
            InitializeComponent();
            form_manager.ownerInventory = this;
        }

        private void getinventoryrecord()
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            ownerinventoryview.DataSource = dt;
        }

        private void ownerInventory_Load(object sender, EventArgs e)
        {
            getinventoryrecord();
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
            dataAdapter.SelectCommand.Parameters.AddWithValue("@category",combosort.Text.Trim());
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ownerinventoryview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
