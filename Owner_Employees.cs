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
    public partial class Owner_Employees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public Owner_Employees()
        {
            InitializeComponent();
            form_manager.Owner_Employees=this;
        }

        private void Owner_Employees_Load(object sender, EventArgs e)
        {
            getinventoryrecord();
            interfaceadjustment();
        }

        private void getinventoryrecord()
        {
            string query = "select id,name,email,contact,position,salary from employee where position !='owner'; ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            owneremployeeview.DataSource = dt;
            owneremployeeview.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            owneremployeeview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public void interfaceadjustment()
        {
            if (form_manager.ownerview.logic)
            {
                owneremployeeview.Columns["id"].Width = 120;
                owneremployeeview.Columns["name"].Width = 210;
                owneremployeeview.Columns["email"].Width = 230;
                owneremployeeview.Columns["contact"].Width = 150;
                owneremployeeview.Columns["position"].Width = 130;
                owneremployeeview.Columns["salary"].Width = 150;
            }
            else
            {
                owneremployeeview.Columns["id"].Width = 130;
                owneremployeeview.Columns["name"].Width = 230;
                owneremployeeview.Columns["email"].Width = 240;
                owneremployeeview.Columns["contact"].Width = 160;
                owneremployeeview.Columns["position"].Width = 150;
                owneremployeeview.Columns["salary"].Width = 160;
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,name,email,contact,position,salary from employee where cast (id as varchar) like  @id +'%' and  position !='owner'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", txtsearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                owneremployeeview.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                owneremployeeview.DataSource = null;
            }
        }

        private void combosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select id,name,email,contact,position,salary from employee where position like  @position +'%' and  position !='owner'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@position", combosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                owneremployeeview.DataSource = dataTable;
                interfaceadjustment();
            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                owneremployeeview.DataSource = null;
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void owneremployeeview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ownerinventoryview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
