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
using System.Windows.Forms.DataVisualization.Charting;

namespace practiceslidebar
{
    public partial class Ownerdash : Form
    {
        public Ownerdash()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");


        private void Ownerdash_Load(object sender, EventArgs e)
        {
            GetNumberOfItems();
            GetNumberOfItemsOutOfStock();
            GetNumberOfEployees();
            GetTotalSalesThisMonth();
            GetTotalSalesPreviousMonth();
        }
        
        private double GetSalesForMonth(int month)
        {
            double totalSales = 0;
            string query = @"
                SELECT SUM(amount) AS TotalSales
                FROM customer
                WHERE MONTH(date) = @Month AND YEAR(date) = YEAR(GETDATE())";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Month", month);

            con.Open();
            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                totalSales = Convert.ToDouble(result);
            }
            con.Close();

            return totalSales;
        }

        void GetTotalSalesPreviousMonth()
        {
            double totalSales = 0;
            string query = @"SELECT SUM(amount) AS totalSales 
                     FROM customer 
                     WHERE DATEPART(MONTH, date) = DATEPART(MONTH, DATEADD(MONTH, -1, GETDATE())) 
                     AND DATEPART(YEAR, date) = DATEPART(YEAR, DATEADD(MONTH, -1, GETDATE()))";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                totalSales = Convert.ToDouble(result);
            }
            lbsaleprevmonth.Text = "Rs " + totalSales.ToString();
            con.Close();
        }

        void GetTotalSalesThisMonth()
        {
            double totalSales = 0;
            string query = @"SELECT SUM(amount) AS totalSales 
                     FROM customer 
                     WHERE DATEPART(MONTH, date) = DATEPART(MONTH, GETDATE()) 
                     AND DATEPART(YEAR, date) = DATEPART(YEAR, GETDATE())";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            object result = cmd.ExecuteScalar();
            if (result != DBNull.Value)
            {
                totalSales = Convert.ToDouble(result);
            }
            lbsalesthismonth.Text = "Rs " + totalSales.ToString();
            con.Close();
        }

        void GetNumberOfItems()
        {
            int numberOfItems = 0;
            string query = "select count(*) from Inventory2";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            numberOfItems = Convert.ToInt16(cmd.ExecuteScalar());
            lbnumberofitems.Text=numberOfItems.ToString();
            con.Close();
        }
        void GetNumberOfItemsOutOfStock()
        {
            int GetNumberOfItemsOutOfStock = 0;
            string query = "select count(*) from Inventory2 where quantity=0";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            GetNumberOfItemsOutOfStock = Convert.ToInt16(cmd.ExecuteScalar());
            lbproductoutofstock.Text = GetNumberOfItemsOutOfStock.ToString();
            con.Close();
        }
        void GetNumberOfEployees()
        {
            int GetNumberOfemployee = 0;
            string query = "select count(*) from employee";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            GetNumberOfemployee = Convert.ToInt16(cmd.ExecuteScalar());
            lbnumberofemployees.Text = GetNumberOfemployee.ToString();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
