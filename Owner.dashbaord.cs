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
            piechartdataload();
            GetNumberOfItems();
            GetNumberOfItemsOutOfStock();
            GetNumberOfEployees();
            GetTotalSalesThisMonth();
            GetTotalSalesPreviousMonth();
            GetExpireProducts();
            interfaceadjusment();
        }
     public void interfaceadjusment()
        {
            if (!form_manager.ownerview.logic)
            {
                panel7.Location = new Point(992, 14);
                panel6.Location = new Point(383, 14);
                panel2.Location = new Point(686, 14);
                panel3.Location = new Point(384, 152);
                panel4.Location = new Point(687, 152);
                panel5.Location = new Point(82, 152);
            }
            else
            {
                panel7.Location = new Point(22, 14);
                panel6.Location = new Point(323, 14);
                panel2.Location = new Point(626, 14);
                panel3.Location = new Point(324, 152);
                panel4.Location = new Point(627, 152);
                panel5.Location = new Point(22, 152); 
            }
        }

        void piechartdataload()
        {
            string connectionString = "Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;";

            string query = @"
        WITH Months AS (
            SELECT 1 AS Month
            UNION ALL
            SELECT 2 UNION ALL
            SELECT 3 UNION ALL
            SELECT 4 UNION ALL
            SELECT 5 UNION ALL
            SELECT 6 UNION ALL
            SELECT 7 UNION ALL
            SELECT 8 UNION ALL
            SELECT 9 UNION ALL
            SELECT 10 UNION ALL
            SELECT 11 UNION ALL
            SELECT 12
        )
        SELECT 
            m.Month,
            ISNULL(SUM(CASE WHEN DATEPART(MONTH, c.date) = m.Month THEN c.amount ELSE 0 END), 0) AS TotalAmount
        FROM 
            Months m
        LEFT JOIN 
            customer c ON DATEPART(MONTH, c.date) = m.Month
        GROUP BY 
            m.Month
        ORDER BY 
            m.Month;
        ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                decimal[] totalSales = new decimal[12];
                string[] months = { "Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec" };

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    int month = Convert.ToInt32(dataTable.Rows[i]["Month"]) - 1; 
                    totalSales[month] = Convert.ToDecimal(dataTable.Rows[i]["TotalAmount"]);
                }
                for (int i = 0; i < totalSales.Length; i++)
                {
                    chart1.Series["sale"].Points.AddXY(months[i], totalSales[i]);
                }
            }
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

        void GetExpireProducts()
        {
            int GetExpireProducts = 0;
            string query = "select count(*) from Inventory2 where expirydate < GETDATE()";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            GetExpireProducts = Convert.ToInt16(cmd.ExecuteScalar());
            lbexpireproducts.Text = GetExpireProducts.ToString();
            con.Close();
        }

    }
}
