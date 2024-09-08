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

namespace practiceslidebar
{
    public partial class employeebill : Form
    {
        public employeebill()
        {
            InitializeComponent();
            form_manager.employeebill=this;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        int invoice = 1;
        string name;
        float price;
            decimal grandt = 0;
        int qty,numberofitemsperpage=0,numberofitemprintedsofar=0;
        void getinventory()
        {
            string query = "select name,quantity,category,unitprice,manufacturer,status from Inventory2 where status!='out of stock' ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            inventory.DataSource = dt;
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Image.FromFile("C:\\Users\\HP\\Downloads\\LOGO.png");
            e.Graphics.DrawImage(image, 50, 20, image.Width, image.Height);
            //  e.Graphics.DrawString("PATNI MEDICAL STORE ", new Font("Arial",15, FontStyle.Bold), Brushes.Black, new Point(85, 30));
            e.Graphics.DrawString(" Sell Receipt ", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(140,80));
            e.Graphics.DrawString("Invoice# :  pms" + txtinnumber.Text , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Inv Date/Time : "+ DateTime.Now.ToShortDateString()+"  "+DateTime.Now.ToShortTimeString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10,145));
            e.Graphics.DrawString("Customer# :  " + txtcusid.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString("Customer Name :  " + txtcusname.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 195));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 225));
            e.Graphics.DrawString("Item Name", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0,240));
            e.Graphics.DrawString("Qty", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(200, 240));
            e.Graphics.DrawString("Rate", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(260, 240));
            e.Graphics.DrawString("Amount", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(330, 240));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 255));
            int y = 275,ii=0;
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
            e.Graphics.DrawString("OLD BALANCE : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 40));
            e.Graphics.DrawString("TOTAL BALANCE : " + grandt.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 60));
            e.Graphics.DrawString("CASH RECEICED : " + grandt.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 80));
            e.Graphics.DrawString("NET BALANCE : ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(190, y + 100));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, y+120));
            e.Graphics.DrawString("Please check goods & expiry date.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 140));
            e.Graphics.DrawString("No responsibility after delivery.", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 160));
            e.Graphics.DrawString("THANKS", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(330, y + 160));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, y + 180));
            e.Graphics.DrawString("Software By MUHAMMAD PATNI 0316-2406968 Muhammad.", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, y + 200));
            e.Graphics.DrawString("SHOP PTCL        32435482        32446329", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 240));

            numberofitemprintedsofar = numberofitemsperpage=0;

        }
        void order()
        {
            billitem.Rows.Add(txtquan.Text, name, price, txtamount.Text,"Delete");
            grandt += decimal.Parse(txtamount.Text);
            lbgt.Text = grandt.ToString();
        }

            private void employeeinvoice_Load(object sender, EventArgs e)
            {
                getinventory();
                txtinnumber.Text = invoice.ToString();
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

        private void btncancel_Click(object sender, EventArgs e)
        { 
            inventory.ClearSelection();
            txtsearch.Clear();
            txtquan.Clear();
            txtcusname.Clear();
            txtcusname.Focus();
            label5.Visible=false;
            txtquan.Visible=false;
            billitem.Rows.Clear();
            grandt = 0;
            lbgt.Text=grandt.ToString();
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
            int selectedRowIndex = billitem.CurrentCell.RowIndex;
            if (e.ColumnIndex == billitem.Columns["delete"].Index && e.RowIndex >= 0)
            {
                grandt -=  Convert.ToDecimal(billitem.Rows[e.RowIndex].Cells[3].Value);
                lbgt.Text = grandt.ToString();
                billitem.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void inventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {   
            if (txtquan.Text != string.Empty)
            {
                order();
                //con.Open();
                //SqlCommand cmd = new SqlCommand("update Inventory2 set quantity=@quantity where name=@name",con);
                //cmd.Parameters.AddWithValue("@quantity",qty-int.Parse(txtquan.Text));
                //cmd.Parameters.AddWithValue("@name", name);
                //cmd.ExecuteNonQuery();
                //con.Close();
                txtquan.Clear();
                getinventory();
                inventory.ClearSelection();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbgt_Click(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
    }