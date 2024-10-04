using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceslidebar
{
    public partial class ownerInventory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public ownerInventory()
        {
            InitializeComponent();
            form_manager.ownerInventory = this;
        }
        public void interfaceadjustment()
        {
            if (form_manager.ownerview.logic)
            {
                ownerinventoryview.Columns["id"].Width = 60;
                ownerinventoryview.Columns["name"].Width = 130;
                ownerinventoryview.Columns["quantity"].Width = 90;
                ownerinventoryview.Columns["category"].Width = 130;
                ownerinventoryview.Columns["unitprice"].Width = 90;
                ownerinventoryview.Columns["manufacturer"].Width = 130;
                ownerinventoryview.Columns["daterecieved"].Width = 120;
                ownerinventoryview.Columns["expirydate"].Width = 120;
                ownerinventoryview.Columns["status"].Width = 130;
            }
            else
            {
                ownerinventoryview.Columns["id"].Width = 70;
                ownerinventoryview.Columns["name"].Width = 140;
                ownerinventoryview.Columns["quantity"].Width = 110;
                ownerinventoryview.Columns["category"].Width = 140;
                ownerinventoryview.Columns["unitprice"].Width = 100;
                ownerinventoryview.Columns["manufacturer"].Width = 140;
                ownerinventoryview.Columns["daterecieved"].Width = 130;
                ownerinventoryview.Columns["expirydate"].Width = 130;
                ownerinventoryview.Columns["status"].Width = 130;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {

            txtsearch.Clear();
            combosort.SelectedIndex = -1;
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
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                ownerinventoryview.DataSource = null;
            }
        }

        private void txtsearch_TextChanged_1(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where  name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", txtsearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                ownerinventoryview.DataSource = dataTable;
                interfaceadjustment();
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

        private void ownerInventory_Load_1(object sender, EventArgs e)
        {
            getdatafromdatabase.getdata("select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2", ownerinventoryview);
            ownerinventoryview.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            ownerinventoryview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            interfaceadjustment();

        }
    }
}
