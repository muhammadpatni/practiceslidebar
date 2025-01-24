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
    public partial class adminoutofstock : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public adminoutofstock()
        {
            InitializeComponent();
            form_manager.adminoutofstock = this;
        }
        public void interfaceadjustment()
        {
            if (form_manager.adminview.logic)
            {
                inventoryoutofstock.Columns["id"].Width = 60;
                inventoryoutofstock.Columns["name"].Width = 130;
                inventoryoutofstock.Columns["quantity"].Width = 100;
                inventoryoutofstock.Columns["category"].Width = 130;
                inventoryoutofstock.Columns["unitprice"].Width = 90;
                inventoryoutofstock.Columns["manufacturer"].Width = 130;
                inventoryoutofstock.Columns["daterecieved"].Width = 130;
                inventoryoutofstock.Columns["expirydate"].Width = 130;
                inventoryoutofstock.Columns["status"].Width = 110;
            }
            else
            {
                inventoryoutofstock.Columns["id"].Width = 70;
                inventoryoutofstock.Columns["name"].Width = 140;
                inventoryoutofstock.Columns["quantity"].Width = 100;
                inventoryoutofstock.Columns["category"].Width = 140;
                inventoryoutofstock.Columns["unitprice"].Width = 100;
                inventoryoutofstock.Columns["manufacturer"].Width = 140;
                inventoryoutofstock.Columns["daterecieved"].Width = 140;
                inventoryoutofstock.Columns["expirydate"].Width = 140;
                inventoryoutofstock.Columns["status"].Width = 120;
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where quantity=0 and name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", search.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                inventoryoutofstock.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {

                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                inventoryoutofstock.DataSource = null;
            }
        }

        private void btneset_Click(object sender, EventArgs e)
        {
            search.Clear();
            combosort.SelectedIndex = -1;
        }

        private void adminoutofstock_Load(object sender, EventArgs e)
        {
            getdatafromdatabase.getdata("select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where quantity=0;", inventoryoutofstock);
            interfaceadjustment();
        }

        private void combosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where quantity=0 and  category like @category +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@category", combosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                inventoryoutofstock.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                inventoryoutofstock.DataSource = null;
            }
        }

    }
}
