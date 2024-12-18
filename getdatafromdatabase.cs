using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceslidebar
{
    static class getdatafromdatabase
    {
        public static void getdata(string query, DataGridView dataGridView1)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;"))
            { 
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Step 3: Read Data Using SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Step 4: Create a DataTable and define its schema
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }           
            }
        }

        public static void getdata(string query, DataGridView dataGridView1, DataGridView dataGridView2)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;"))
            {
                try
                {
                    SqlDataAdapter ad = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
