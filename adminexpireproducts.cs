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
    public partial class adminexpireproducts : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public adminexpireproducts()
        {
            InitializeComponent();
            form_manager.adminexpireproducts = this;

        }

        private void btneset_Click(object sender, EventArgs e)
        {
            search.Clear();
            combosort.SelectedIndex = -1;
        }

        public void interfaceadjustment()
        {
            if (form_manager.adminview.logic)
            {
                expireproducts.Columns["id"].Width = 60;
                expireproducts.Columns["name"].Width = 130;
                expireproducts.Columns["quantity"].Width = 100;
                expireproducts.Columns["category"].Width = 130;
                expireproducts.Columns["unitprice"].Width = 90;
                expireproducts.Columns["manufacturer"].Width = 130;
                expireproducts.Columns["daterecieved"].Width = 130;
                expireproducts.Columns["expirydate"].Width = 130;
                expireproducts.Columns["status"].Width = 110;
            }
            else
            {
                expireproducts.Columns["id"].Width = 70;
                expireproducts.Columns["name"].Width = 140;
                expireproducts.Columns["quantity"].Width = 100;
                expireproducts.Columns["category"].Width = 140;
                expireproducts.Columns["unitprice"].Width = 100;
                expireproducts.Columns["manufacturer"].Width = 140;
                expireproducts.Columns["daterecieved"].Width = 140;
                expireproducts.Columns["expirydate"].Width = 140;
                expireproducts.Columns["status"].Width = 120;
            }
        }

        private async void adminexpireproducts_Load(object sender, EventArgs e)
        {
         await  getdatafromdatabase.getdata("SELECT id, name, quantity, category, unitprice, manufacturer, daterecieved, expirydate, status FROM Inventory2 WHERE expirydate < GETDATE()", expireproducts);
            interfaceadjustment();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where expirydate < GETDATE() and name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", search.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                expireproducts.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {

                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                expireproducts.DataSource = null;
            }
        }

        private void combosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where  expirydate < GETDATE() and  category like @category +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@category", combosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                expireproducts.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                expireproducts.DataSource = null;
            }
        }
    }
}
