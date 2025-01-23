using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Resources;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Image = System.Drawing.Image;
using Font = System.Drawing.Font;
using System.Numerics;

namespace practiceslidebar
{
    public partial class employeebill : Form
    {
        private MemoryStream memoryStream;
        public employeebill()
        {
            InitializeComponent();
            form_manager.employeebill=this;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        string name;
        float price;
            decimal grandt = 0;
        int qty,numberofitemsperpage=0,numberofitemprintedsofar,ii=0, quan, i;
        public void interfaceadjustment()
        {
            inventory.Columns["name"].Width = 120;
            inventory.Columns["quantity"].Width = 80;
            inventory.Columns["category"].Width = 140;
            inventory.Columns["unitprice"].Width = 80;
            inventory.Columns["manufacturer"].Width = 120;
            inventory.Columns["status"].Width = 120;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Properties.Resources.logo2;
            e.Graphics.DrawImage(image, 35, 20, image.Width, image.Height);
              //e.Graphics.DrawString(" CHASE UP  ", new Font("Arial",15, FontStyle.Bold), Brushes.Black, new Point(140, 20));
            e.Graphics.DrawString(" Sell Receipt  ", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(130,80));
            e.Graphics.DrawString("Invoice# : pms" + txtinnumber.Text , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Inv Date/Time : "+ DateTime.Now.ToShortDateString()+"  "+DateTime.Now.ToShortTimeString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10,145));
            e.Graphics.DrawString("Customer# :  " + txtcusid.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString("Customer Name :  " + txtcusname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 195));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 225));
            e.Graphics.DrawString("Item Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0,240));
            e.Graphics.DrawString("Qty", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, 240));
            e.Graphics.DrawString("Rate", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 240));
            e.Graphics.DrawString("Amount", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(330, 240));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 255));
            int y = 275;
            for(int i=numberofitemprintedsofar;i<billitem.Rows.Count;i++)    
            {
                numberofitemsperpage++;
                if(numberofitemsperpage<=7)
                {
                    numberofitemprintedsofar++;
                    if (numberofitemprintedsofar<= billitem.Rows.Count)
                    {
                        e.Graphics.DrawString(billitem.Rows[i].Cells["itemname"].Value.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, y));
                        e.Graphics.DrawString(billitem.Rows[i].Cells["quantity"].Value.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(210, y));
                        e.Graphics.DrawString(billitem.Rows[i].Cells["rate"].Value.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(270, y));
                        e.Graphics.DrawString(billitem.Rows[i].Cells["amount"].Value.ToString(), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, y));
                        if (numberofitemprintedsofar<billitem.Rows.Count)
                        { e.Graphics.DrawString("..........................................................................................", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 10));
                        }
                        y += 30;
                        ii++;
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    numberofitemsperpage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0,y-10));
            e.Graphics.DrawString("# OF ITEMS : "+ii.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0,y+20)); 
            e.Graphics.DrawString("TOTAL : " + grandt.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 20));
            e.Graphics.DrawString("OLD BALANCE : - ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 40));
            e.Graphics.DrawString("TOTAL BALANCE : " + grandt.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 60));
            e.Graphics.DrawString("CASH RECEICED : " + grandt.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 80));
            e.Graphics.DrawString("NET BALANCE : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 100));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, y+120));
            e.Graphics.DrawString("Please check goods & expiry date.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 140));
            e.Graphics.DrawString("No responsibility after delivery.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 160));
            e.Graphics.DrawString("THANKS", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, y + 180));
          //  e.Graphics.DrawString("Software By MUHAMMAD PATNI 0316-2406968 Muhammad.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, y + 200));
            e.Graphics.DrawString("SHOP PTCL        32435482        32446329", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 240));

            numberofitemprintedsofar = numberofitemsperpage=ii=0;

        }
        void order()
        {
            if (billitem.Rows.Count!=0)
            {
                for (int i = 0; i < billitem.Rows.Count; i++)
                {
                    if (billitem.Rows[i].Cells["itemname"].Value.ToString()==name )
                    {
                        int quantitytobeupdate = int.Parse(billitem.Rows[i].Cells["Quantity"].Value.ToString());
                        if (int.TryParse(txtquan.Text, out int additionalQuantity))
                        {
                            grandt -= decimal.Parse(billitem.Rows[i].Cells["amount"].Value.ToString());
                            int tquantity = quantitytobeupdate + additionalQuantity;
                            billitem.Rows[i].Cells["Quantity"].Value = tquantity;
                            billitem.Rows[i].Cells["amount"].Value = tquantity * price;
                            grandt += decimal.Parse(billitem.Rows[i].Cells["amount"].Value.ToString());
                            txtgrandtotal.Text = "RS " + grandt.ToString();
                            tquantity = 0;
                            break;
                        }
                    }
                    else 
                    {
                        if (i==billitem.Rows.Count-1)
                        {
                            billitem.Rows.Add(txtquan.Text, name, price, txtamount.Text);
                            grandt += decimal.Parse(txtamount.Text);
                            txtgrandtotal.Text = "RS " + grandt.ToString();
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    
                }
            }
            else
            {    
                billitem.Rows.Add(txtquan.Text, name, price, txtamount.Text);
                grandt += decimal.Parse(txtamount.Text);
                txtgrandtotal.Text = "RS " + grandt.ToString();
            }
        }

            private void employeeinvoice_Load(object sender, EventArgs e)
            {
            getdatafromdatabase.getdata("select name,quantity,category,unitprice,manufacturer,status from Inventory2 where status!='out of stock' ", inventory);
            billitem.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Bold);
            billitem.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            txtinnumber.Text =i.ToString();
            interfaceadjustment();
                PaperSize paperSize = new PaperSize("Custom", 410, 800); // 58mm = ~2.28 inches, 200 = ~2.28 * 100 (100th of an inch units)
                printDocument1.DefaultPageSettings.PaperSize = paperSize;
                printDocument1.DefaultPageSettings.Margins = new Margins(0, 0, 0,0);
            }

        private void txtcusname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select  name,quantity,category,unitprice,manufacturer,status from Inventory2 where status!='out of stock' and name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", txtsearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
               inventory.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                inventory.DataSource = null;
            }
        }

        private void txtcusname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtsearch.Focus();
            }
        }

      private void inventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = inventory.Rows[e.RowIndex];

                name = selectedRow.Cells[0].Value.ToString();
                price =float.Parse( selectedRow.Cells[3].Value.ToString());
                qty = int.Parse(selectedRow.Cells[1].Value.ToString());     
            }
            txtquan.Visible = true;
            label5.Visible = true;
            txtquan.Focus();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (billitem.Rows.Count != 0)
            {
               
            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Error";
                form_manager.messagebox.message.Text = "Add Items ..";
            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {  
            if(billitem.Rows.Count!=0)
            {
                printDocument1.Print();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Error";
                form_manager.messagebox.message.Text = "Add Items ..";
            }
        }

        private void AddContentToPDF(Document pdfDoc)
        {
            // Use iTextSharp.text.Image for PDF images

            // Add text content with iTextSharp fonts
            iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            iTextSharp.text.Font regularFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            iTextSharp.text.Font regularFont1 = FontFactory.GetFont(FontFactory.HELVETICA, 8);
            Paragraph header1 = new Paragraph("PATNI MEDICAL STORE", headerFont);
            header1.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(header1);

            Paragraph header2 = new Paragraph("Sell Receipt", headerFont);
            header2.Alignment = Element.ALIGN_CENTER;
            header2.SpacingAfter = 24f; // 2 lines of space after the header
            pdfDoc.Add(header2);

            // Invoice details
            pdfDoc.Add(new Paragraph("Invoice#: pms" + txtinnumber.Text, regularFont));
            pdfDoc.Add(new Paragraph("Inv Date/Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"), regularFont));
            pdfDoc.Add(new Paragraph("Customer#: " + txtcusid.Text, regularFont));
            pdfDoc.Add(new Paragraph("Customer Name: " + txtcusname.Text, regularFont));
            pdfDoc.Add(new Paragraph("", regularFont));
            pdfDoc.Add(new Paragraph("", regularFont));
            Paragraph spacer = new Paragraph(" ", regularFont);
            spacer.SpacingAfter = 24f; // 2 lines of space (assuming 12 points per line)
            pdfDoc.Add(spacer);
            // Table for items
            PdfPTable table = new PdfPTable(4);
            table.AddCell(new PdfPCell(new Phrase("Item Name", headerFont)));
            table.AddCell(new PdfPCell(new Phrase("Qty", headerFont)));
            table.AddCell(new PdfPCell(new Phrase("Rate", headerFont)));
            table.AddCell(new PdfPCell(new Phrase("Amount", headerFont)));

            // Populate the table with data from billitem DataGridView
            for (int i = 0; i < billitem.Rows.Count; i++)
            {
                table.AddCell(new PdfPCell(new Phrase(billitem.Rows[i].Cells["itemname"].Value.ToString(), regularFont)));
                table.AddCell(new PdfPCell(new Phrase(billitem.Rows[i].Cells["quantity"].Value.ToString(), regularFont)));
                table.AddCell(new PdfPCell(new Phrase(billitem.Rows[i].Cells["rate"].Value.ToString(), regularFont)));
                table.AddCell(new PdfPCell(new Phrase(billitem.Rows[i].Cells["amount"].Value.ToString(), regularFont)));
                ii++;
            }

            pdfDoc.Add(table);
            spacer.SpacingAfter = 12f; // 2 lines of space (assuming 12 points per line)
            pdfDoc.Add(spacer);
            pdfDoc.Add(new Paragraph("# OF ITEMS : " + ii.ToString(), regularFont));
            Paragraph totalParagraph = new Paragraph("          TOTAL : " + grandt.ToString(), regularFont);
            totalParagraph.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(totalParagraph);

            Paragraph oldBalanceParagraph = new Paragraph("          OLD BALANCE : - ", regularFont);
            oldBalanceParagraph.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(oldBalanceParagraph);

            Paragraph totalBalanceParagraph = new Paragraph("          TOTAL BALANCE : " + grandt.ToString(), regularFont);
            totalBalanceParagraph.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(totalBalanceParagraph);

            Paragraph cashReceivedParagraph = new Paragraph("          CASH RECEIVED : " + grandt.ToString(), regularFont);
            cashReceivedParagraph.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(cashReceivedParagraph);

            Paragraph netBalanceParagraph = new Paragraph("          NET BALANCE : ", regularFont);
            netBalanceParagraph.Alignment = Element.ALIGN_RIGHT;
            pdfDoc.Add(netBalanceParagraph);

            // Footer details
            pdfDoc.Add(new Paragraph("---------------------------------------------------------------------------------------------------------------------------------", headerFont));
            pdfDoc.Add(new Paragraph("@Patni Medical Store", regularFont1));
            ii = 0;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (billitem.Rows.Count !=0)
            {
                memoryStream = new MemoryStream();

                // Initialize iTextSharp's Document for PDF creation
                Document pdfDoc = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                pdfDoc.Open();

                try
                {
                    // Start the PDF generation by adding content
                    AddContentToPDF(pdfDoc);

                    // Close the PDF document and get the PDF data as bytes
                    pdfDoc.Close();

                    // Retrieve the generated PDF data
                    byte[] pdfBytes = memoryStream.ToArray();

                    // Save the PDF to the database
                    SavePDFToDatabase(pdfBytes);
                   
                    SqlCommand cmd = new SqlCommand("select max(id) as id from customer", con);
                    con.Open();
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        if (sdr["id"] == DBNull.Value)
                        {
                            i = 1;
                            txtcusid.Text = i.ToString();
                            txtinnumber.Text = i.ToString();    
                        }
                        else
                        {
                            i = Convert.ToInt32(sdr["id"]) + 1;

                            txtcusid.Text = i.ToString();
                            txtinnumber.Text = i.ToString();
                        }
                    }
                    con.Close();
                    txtsearch.Clear();
                    txtcusname.Focus();
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                    billitem.Rows.Clear();
                    txtcusname.Focus();
                    grandt = 0;
                    txtgrandtotal.Text = "RS";
                    billitem.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message);
                }
                finally
                {
                    pdfDoc.Close();
                    memoryStream.Dispose();
                    txtcusname.Clear();
                }
            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Error";
                form_manager.messagebox.message.Text = "Add Items ..";
            }
        }
        private void SavePDFToDatabase(byte[] pdfBytes)
        {
            string connectionString = "Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;"; // Update this with your actual connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO customer (id,name,amount,invoice,date) VALUES (@id,@name,@amount,@invoice,@date)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@invoice", System.Data.SqlDbType.VarBinary).Value = pdfBytes;
                    cmd.Parameters.AddWithValue("@id",int.Parse(txtcusid.Text));
                    cmd.Parameters.AddWithValue("@name",txtcusname.Text);
                    cmd.Parameters.AddWithValue("@amount",grandt);
                    cmd.Parameters.AddWithValue("@date",DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row  in billitem.Rows)
            {
                SqlCommand cmd = new SqlCommand("select quantity as qty from Inventory2 where name=@name", con);
                cmd.Parameters.AddWithValue("@name", row.Cells[1].Value.ToString());
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    quan = int.Parse(sdr["qty"].ToString());
                }
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update Inventory2 set quantity=@quantity where name=@name", con);
                cmd1.Parameters.AddWithValue("@quantity", quan + int.Parse(row.Cells[0].Value.ToString()));
                cmd1.Parameters.AddWithValue("@name", row.Cells[1].Value);
                cmd1.ExecuteNonQuery();
                con.Close();
            }
            inventory.ClearSelection();
            txtsearch.Clear();
            txtquan.Clear();
            txtcusname.Clear();
            txtcusname.Focus();
            label5.Visible=false;
            txtquan.Visible=false;
            billitem.Rows.Clear();
            grandt = 0;
            txtgrandtotal.Text = "RS " +grandt.ToString();
            getdatafromdatabase.getdata("select name,quantity,category,unitprice,manufacturer,status from Inventory2 where status!='out of stock' ", inventory);

        }

        private void txtquan_TextChanged(object sender, EventArgs e)
        {
            int quantity=0;
            try
            {   if (qty < int.Parse(txtquan.Text))
                {
                    messagebox m = new messagebox();
                    m.Show();
                    form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                    form_manager.messagebox.tittle.Text = "Oops..";
                    form_manager.messagebox.message.Text = $"{qty} item in stock";
                }
                else
                {
                    quantity = int.Parse(txtquan.Text);
                }
            }
            catch
            {
                if (txtquan.Text != string.Empty)
                {
                    messagebox m = new messagebox();
                    m.Show();
                    form_manager.messagebox.tittle.Text = "Error";
                    form_manager.messagebox.message.Text = "Please Enter Valid Quantity";
                }
            }
           
            float amount =  price* quantity;
            txtamount.Text=amount.ToString();
        }
        private void billitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == billitem.Columns["delete"].Index && e.RowIndex >= 0)
            {
                SqlCommand cmd = new SqlCommand("select quantity as qty from Inventory2 where name=@name", con);
                cmd.Parameters.AddWithValue("@name", billitem.Rows[e.RowIndex].Cells[1].Value.ToString());
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                     quan = int.Parse(sdr["qty"].ToString());
                }
                con.Close();
                con.Open();
                SqlCommand cmd1 = new SqlCommand("update Inventory2 set quantity=@quantity where name=@name", con);
                cmd1.Parameters.AddWithValue("@quantity", quan + int.Parse(billitem.Rows[e.RowIndex].Cells[0].Value.ToString()));
                cmd1.Parameters.AddWithValue("@name", billitem.Rows[e.RowIndex].Cells[1].Value);
                cmd1.ExecuteNonQuery();
                con.Close();
                getdatafromdatabase.getdata("select name,quantity,category,unitprice,manufacturer,status from Inventory2 where status!='out of stock' ", inventory);
                grandt -=  Convert.ToDecimal(billitem.Rows[e.RowIndex].Cells[3].Value);
                txtgrandtotal .Text = "RS " +grandt.ToString();
                billitem.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (txtcusname.Text != string.Empty)
            {
                if (txtquan.Text != string.Empty)
                {
                    order();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Inventory2 set quantity=@quantity where name=@name", con);
                    cmd.Parameters.AddWithValue("@quantity", qty - int.Parse(txtquan.Text));
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtquan.Clear();
                    getdatafromdatabase.getdata("select name,quantity,category,unitprice,manufacturer,status from Inventory2 where status!='out of stock' ", inventory);
                    inventory.ClearSelection();
                    txtsearch.Clear();
                    txtsearch.Focus();
                }
                else
                {
                    messagebox m = new messagebox();
                    m.Show();
                    form_manager.messagebox.tittle.Text = "Error";
                    form_manager.messagebox.message.Text = "please enter quantity\n                 or\nplease select a record";
                    form_manager.messagebox.ok.Location = new Point(112, 131);
                }
            }
            else
            {
                txtcusname.Focus();
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Error";
                form_manager.messagebox.message.Text = " enter customer name";
            }
            
        }

    }
    }