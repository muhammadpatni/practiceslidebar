using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace practiceslidebar
{
    public partial class employeeclaim : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public employeeclaim()
        {
            InitializeComponent();
        }

        public void LoadInvoiceToGrid(DataGridView gridView, DataTable dt)
        {
            if (dt.Rows.Count > 0 && dt.Columns.Contains("invoice"))
            {
                byte[] pdfData = (byte[])dt.Rows[0]["invoice"];
                gridView.DataSource = ExtractTableFromPDF(pdfData);
                interfaceadjustment();
            }
        }
        private DataTable ExtractTableFromPDF(byte[] pdfBytes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item Name");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Rate");
            dt.Columns.Add("Amount");

            string tempFile = System.IO.Path.GetTempFileName() + ".pdf";
            File.WriteAllBytes(tempFile, pdfBytes);

            using (PdfReader reader = new PdfReader(tempFile))
            {
                List<string> textLines = new List<string>();

                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    string pageText = PdfTextExtractor.GetTextFromPage(reader, i);
                    textLines.AddRange(pageText.Split('\n'));
                }

                string itemName = "";
                string qty = "", rate = "", amount = "";
                bool capturingItem = false;

                foreach (string line in textLines)
                {
                    string cleanLine = line.Trim();
                    if (string.IsNullOrWhiteSpace(cleanLine) || cleanLine.Contains("Patni Medical Store") || cleanLine.Contains("Invoice#"))
                        continue; // Ignore extra text

                    if (cleanLine.Contains("TOTAL") || cleanLine.Contains("BALANCE") || cleanLine.Contains("CASH RECEIVED") || cleanLine.Contains("# OF ITEMS"))
                        break; // Stop processing if totals section starts

                    var match = Regex.Match(cleanLine, @"^(?<itemName>.+?)\s+(?<qty>\d+)\s+(?<rate>\d+(\.\d+)?)\s+(?<amount>\d+(\.\d+)?)$");

                    if (match.Success)
                    {
                        if (capturingItem)
                        {
                            dt.Rows.Add(itemName.Trim(), qty, rate, amount);
                            capturingItem = false;
                        }
                        itemName = match.Groups["itemName"].Value;
                        qty = match.Groups["qty"].Value;
                        rate = match.Groups["rate"].Value;
                        amount = match.Groups["amount"].Value;
                        capturingItem = true;
                    }
                    else if (capturingItem)
                    {
                        itemName += " " + cleanLine; // Append multi-line names
                    }
                }

                if (capturingItem)
                {
                    dt.Rows.Add(itemName.Trim(), qty, rate, amount);
                }
            }

            File.Delete(tempFile);
            return dt;
        }

        public void getdataofcustomer(int invoice)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from customer where invoice# = '" + txtinnumber.Text + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                label5.Text = "Invalid Invoice number";
                txtinnumber.Focus();
            }
            else
            {
                label5.Text = "";
                txtcusid.Text = dt.Rows[0]["id"].ToString();
                txtcusname.Text = dt.Rows[0]["name"].ToString();
                txtdate.Text = DateTime.Now.ToString("dd-MM-yyyy"); 
                txtbilldate.Text = Convert.ToDateTime(dt.Rows[0]["date"]).ToString("dd-MM-yyyy");
                txtamount.Text = dt.Rows[0]["amount"].ToString();

                LoadInvoiceToGrid(claimview, dt);

            }
        }
        private void txtinnumber_TextChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            if (!int.TryParse(txtinnumber.Text, out _))
            {
                label5.Text = "Numeric value only";
            }
            else
            {
                label5.Text = "";
            }
            if (string.IsNullOrEmpty(txtinnumber.Text))
            {
                label5.Text = "";
                label4.Visible = true;
            }

        }
        public void performsearch()
        {
            if (label4.Visible == true || label5.Text != "")
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Error";
                form_manager.messagebox.message.Text = "invalid invoice number";
                return;

            }
            getdataofcustomer(int.Parse(txtinnumber.Text));
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            performsearch();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        { 
          txtinnumber.Clear();
            txtcusid.Clear();
            txtcusname.Clear();
            txtdate.Clear();
            txtbilldate.Clear();
            txtamount.Clear();
            claimview.DataSource = null;
           
        }

        public void interfaceadjustment()
        {
            claimview.Columns["Item Name"].Width = 170;
            claimview.Columns["Qty"].Width = 80;
            claimview.Columns["Rate"].Width = 80;
             claimview.Columns["Amount"].Width = 120;

        }
        private void txtinnumber_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                performsearch();
            }
        }

        private void employeeclaim_Load(object sender, EventArgs e)
        {

            txtinnumber.Focus();
        }
    }
}
