﻿using System;
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
        public static async Task getdata (string query, DataGridView dataGridView1)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;"))
            {
                await con.OpenAsync(); // Open connection asynchronously
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Step 3: Read Data Using SqlDataReader
                    using (SqlDataReader reader = await command.ExecuteReaderAsync()) // ExecuteReaderAsync
                    {
                        // Step 4: Create a DataTable and define its schema
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader); // Load data synchronously as DataTable.Load doesn't support async
                        dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.DataSource = dataTable));
                    }
                }
            }
        }
        public static async Task getdata(string query, DataGridView dataGridView1, DataGridView dataGridView2)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;"))
            {
                try
                {
                    await con.OpenAsync(); // Asynchronous connection open
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dataTable = new DataTable();

                    // Run the Fill operation in a separate thread
                    await Task.Run(() => adapter.Fill(dataTable));

                    // Update the DataGridView on the UI thread
                    dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.DataSource = dataTable));
                    dataGridView2.Invoke((MethodInvoker)(() => dataGridView2.DataSource = dataTable));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }

}
