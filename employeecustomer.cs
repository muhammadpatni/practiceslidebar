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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practiceslidebar
{
    public partial class employeecustomer : Form
    {

        public employeecustomer()
        {
            InitializeComponent();
            form_manager.employeecustomer = this;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");

        void getinventory()
        {
            getdatafromdatabase.getdata("select id,invoice#,name, amount,date from customer", customerview);
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Option";        
            buttonColumn.Name = "invoice";            
            buttonColumn.Text = "invoice";             
            buttonColumn.UseColumnTextForButtonValue = true;
            buttonColumn.FlatStyle=FlatStyle.Flat;
            customerview.Columns.Add(buttonColumn);
        }
        public void interfaceadjustment()
        {
            if (form_manager.employeeview.logic)
            {
                customerview.Columns["id"].Width = 130;
                customerview.Columns["invoice#"].Width = 120;
                customerview.Columns["name"].Width = 160;
                customerview .Columns["amount"].Width = 200;
                customerview .Columns["date"].Width = 220;
                customerview.Columns["invoice"].Width = 160;   
            }
            else
            {
                customerview.Columns["id"].Width = 150;
                customerview.Columns["invoice#"].Width = 140;
                customerview.Columns["name"].Width = 150;
                customerview.Columns["amount"].Width = 230;
                customerview.Columns["date"].Width = 230;
                customerview.Columns["invoice"].Width = 170;
            }
        }
        private void employeecustomer_Load(object sender, EventArgs e)
        {
           getinventory();
            interfaceadjustment();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select id ,invoice#,name, amount,date from customer where cast (id as varchar) like  @id +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@id", txtsearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                customerview.Columns.Remove("invoice");
                customerview.DataSource = dataTable;
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.HeaderText = "";
                buttonColumn.Name = "invoice";
                buttonColumn.Text = "invoice";
                buttonColumn.UseColumnTextForButtonValue = true;
                customerview.Columns.Add(buttonColumn);
                interfaceadjustment();
            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                customerview.DataSource = null;
                //customerview.Columns.Remove("invoice");
            }

        }
    }
}
