using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceslidebar
{
    public partial class employeecustomer : Form
    {

        public employeecustomer()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");

        void getinventory()
        {
            string query = "select id ,name, amount,date from customer";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            customerview.DataSource = dt;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "";        
            buttonColumn.Name = "invoice";            
            buttonColumn.Text = "invoice";             
            buttonColumn.UseColumnTextForButtonValue = true;
            customerview.Columns.Add(buttonColumn);

        }
        private void employeecustomer_Load(object sender, EventArgs e)
        {
           getinventory();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == customerview.Columns["invoice"].Index && e.RowIndex >= 0)
            {

                int invoiceId = Convert.ToInt32(customerview.Rows[e.RowIndex].Cells["id"].Value);

                // Call method to retrieve and display PDF
                RetrieveAndDisplayPDF(invoiceId);
            }
        }
        private void DisplayPDF(byte[] pdfBytes)
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "tempInvoice.pdf");

            // Write the bytes to a temporary file
            File.WriteAllBytes(tempFilePath, pdfBytes);

            // Open the file with the default PDF viewer
            System.Diagnostics.Process.Start(tempFilePath);
        }

        private void RetrieveAndDisplayPDF(int invoiceId)
        {
            // Connection string to your database
            string connectionString = "Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT invoice FROM customer WHERE id = @InvoiceID"; // Replace 'InvoiceTable' and 'PdfData' accordingly

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@InvoiceID", invoiceId);
                    connection.Open();

                    // Retrieve the PDF from the database
                    byte[] pdfBytes = (byte[])command.ExecuteScalar();

                    // Show the PDF in a PDF viewer or WebBrowser control
                    if (pdfBytes != null)
                    {
                        DisplayPDF(pdfBytes);
                    }
                    else
                    {
                        MessageBox.Show("No PDF found for the selected record.");
                    }
                }
            }
        }

    }
}
