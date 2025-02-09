﻿using System;
using System.Collections;
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
    public partial class admininventory : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public admininventory()
        {
            InitializeComponent();
            form_manager.adminInventory = this;
        }
        public void interfaceadjustment()
        {
            if (form_manager.adminview.logic)
            {
                ownerinventoryview.Columns["id"].Width = 60;
                ownerinventoryview.Columns["name"].Width = 130;
                ownerinventoryview.Columns["quantity"].Width = 80;
                ownerinventoryview.Columns["category"].Width = 130;
                ownerinventoryview.Columns["unitprice"].Width = 90;
                ownerinventoryview.Columns["manufacturer"].Width = 130;
                ownerinventoryview.Columns["daterecieved"].Width = 130;
                ownerinventoryview.Columns["expirydate"].Width = 130;
                ownerinventoryview.Columns["status"].Width = 110;
            }
            else
            {
                ownerinventoryview.Columns["id"].Width = 70;
                ownerinventoryview.Columns["name"].Width = 140;
                ownerinventoryview.Columns["quantity"].Width = 90;
                ownerinventoryview.Columns["category"].Width = 140;
                ownerinventoryview.Columns["unitprice"].Width = 100;
                ownerinventoryview.Columns["manufacturer"].Width = 140;
                ownerinventoryview.Columns["daterecieved"].Width = 140;
                ownerinventoryview.Columns["expirydate"].Width = 140;
                ownerinventoryview.Columns["status"].Width = 120;
            }
        }
        public void interfaceadjustment1()
        {
            if (form_manager.adminview.logic)
            {
                fullinventoryview.Columns["id"].Width = 60;
                fullinventoryview.Columns["name"].Width = 130;
                fullinventoryview.Columns["quantity"].Width = 80;
                fullinventoryview .Columns["category"].Width = 130;
                fullinventoryview.Columns["unitprice"].Width = 90;
                fullinventoryview.Columns["manufacturer"].Width = 130;
                fullinventoryview.Columns["daterecieved"].Width = 130;
                fullinventoryview.Columns["expirydate"].Width = 130;
                fullinventoryview.Columns["status"].Width = 110;
            }
            else
            {
                fullinventoryview.Columns["id"].Width = 70;
                fullinventoryview.Columns["name"].Width = 140;
                fullinventoryview.Columns["quantity"].Width = 90;
                fullinventoryview.Columns["category"].Width = 140;
                fullinventoryview.Columns["unitprice"].Width = 100;
                fullinventoryview.Columns["manufacturer"].Width = 140;
                fullinventoryview.Columns["daterecieved"].Width = 140;
                fullinventoryview.Columns["expirydate"].Width = 140;
                fullinventoryview.Columns["status"].Width = 120;
            }
        }

        void reset()
        {
            ownerinventoryview.ClearSelection();
            txtname.Clear();
            txtmanufacturer.Clear();
            combocategory.SelectedIndex = -1;
            txtquantity.Clear();
            txtunitprice.Clear();
            daterecieved.Value = DateTime.Now;
            expirydate.Value = DateTime.Now;
        }

        private async void admininventory_Load(object sender, EventArgs e)
        {
            if (form_manager.adminview.isvalid1)
            {
                panel5.Size = new Size(1063, 400);
            }

            if (form_manager.adminview.isvalid)
            {
                panel5.Size = new Size(1063, 550);
            }

            ppp.Visible = false;
          await getdatafromdatabase.getdata("select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 ", ownerinventoryview, fullinventoryview);
            interfaceadjustment();
            reset();
            paneleditor.Visible = false;
            panelfullinventory.Visible = false;
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;

        }
        private void txtunitprice_TextChanged(object sender, EventArgs e)
        {
            if (!float.TryParse(txtunitprice.Text, out _))
            {
                label12.Text = "Numeric value only";
            }
            else
            {
                label12.Text = "";
            }
            if (string.IsNullOrEmpty(txtunitprice.Text))
            {
                label12.Text = "";
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where  name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", txtsearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                ownerinventoryview.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                ownerinventoryview.DataSource = null;
            }
        }

        private void combosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where category like @category +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@category", combosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                ownerinventoryview.DataSource = dataTable;
                interfaceadjustment();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                ownerinventoryview.DataSource = null;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            label16.Visible = false;
            paneleditor.Visible = true;
            label11.Location = new Point(406, 160 );
            txtid.Location = new Point(395, 112);
            label8.Location = new Point(406, 90);
            txtid.Size = new Size(195, 39);
            txtmanufacturer.Visible = false;
            txtname.Visible = false;
            txtquantity.Visible = false;
            txtunitprice.Visible = false;
            daterecieved.Visible = false;
            expirydate.Visible = false;
            combocategory.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            panel4.Visible = false;
            txtid.Enabled = true;
            if (form_manager.adminview.isvalid)
            {
                panel5.Height = 300;
            }
            btneditoroperator.Text = "Delete";
            txtid.Clear();
        }





        private async void btneditoroperator_Click(object sender, EventArgs e)
        {
            if (btneditoroperator.Text == "Delete")
            {
                bool test = false;
                string query1 = @"

          CREATE TABLE inventory_Temp (
          id int primary key ,
          quantity int,
          category varchar(50),
          unitprice decimal(10,2),
          manufacturer varchar(255),
          daterecieved date ,
          name varchar(255),
          expirydate date  
          );
          ALTER TABLE inventory_Temp
          ADD status AS 
              CASE 
                  WHEN quantity = 0 THEN 'Out of Stock'
                  ELSE 'In Stock'
              END;";
                string query2 = "delete from Inventory2 where id =@id";
                string query3 = @"INSERT INTO inventory_Temp (id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate)
          SELECT ROW_NUMBER() OVER (ORDER BY id) AS id, name,quantity,category,unitprice,manufacturer,daterecieved,expirydate
          FROM Inventory2;
          drop table Inventory2;
          EXEC sp_rename 'inventory_Temp', 'Inventory2';
          ";
                try
                {
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
                    con.Open();
                    int i = cmd2.ExecuteNonQuery();
                    if (i > 0)
                    {
                        messagebox m = new messagebox();
                        m.Show();
                        form_manager.messagebox.messagepic.Image = Properties.Resources._checked;
                        form_manager.messagebox.tittle.Text = "";
                        form_manager.messagebox.message.Text = "data deleted successfully";
                        reset();
                        test = true;
                        txtid.Clear();
                    }
                    else
                    {
                        messagebox m = new messagebox();
                        m.Show();
                        form_manager.messagebox.tittle.Text = "Error";
                        form_manager.messagebox.message.Text = "ID not found";       
                    }
                }
                catch
                {     
                    messagebox m = new messagebox();
                    m.Show();
                    form_manager.messagebox.tittle.Text = "Error";
                    form_manager.messagebox.message.Text = "ID is required";
                }
                finally { con.Close(); }
                if (test)
                {
                    con.Open();
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.ExecuteNonQuery();
                    con.Close();
                }
            }

            if (btneditoroperator.Text == "Update")
            {

                con.Open();
                if (is_valid())
                {
                        string query = "update Inventory2 set name=@name,category=@category,manufacturer=@manufacturer,unitprice=@unitprice,quantity=@quantity,daterecieved=@daterecieved,expirydate=@expirydate where id=@id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
                        cmd.Parameters.AddWithValue("@name", txtname.Text);
                        cmd.Parameters.AddWithValue("@category", combocategory.Text);
                        cmd.Parameters.AddWithValue("@manufacturer", txtmanufacturer.Text);
                        cmd.Parameters.AddWithValue("@daterecieved", daterecieved.Text);
                        cmd.Parameters.AddWithValue("@expirydate", expirydate.Text);
                        cmd.Parameters.AddWithValue("@unitprice", float.Parse(txtunitprice.Text));
                        cmd.Parameters.AddWithValue("@quantity", int.Parse(txtquantity.Text));
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                        messagebox m = new messagebox();
                        m.Show();
                        form_manager.messagebox.messagepic.Image = Properties.Resources._checked;
                        form_manager.messagebox.tittle.Text = "";
                        form_manager.messagebox.message.Text = "data updated successfully";

                        reset();
                        }
                    } 
                    con.Close();
            }
            if (btneditoroperator.Text == "Add")
            {
                if (is_valid())
                {
                    con.Open();
                    string query = "insert into Inventory2 (id,name,category,quantity,unitprice,manufacturer,daterecieved,expirydate) values (@id,@name,@category,@quantity,@unitprice,@manufacturer,@daterecieved,@expirydate)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtid.Text));
                    cmd.Parameters.AddWithValue("@name", txtname.Text);
                    cmd.Parameters.AddWithValue("@category", combocategory.Text);
                    cmd.Parameters.AddWithValue("@manufacturer", txtmanufacturer.Text);
                    cmd.Parameters.AddWithValue("@daterecieved", daterecieved.Text);
                    cmd.Parameters.AddWithValue("@expirydate", expirydate.Text);
                    cmd.Parameters.AddWithValue("@unitprice", float.Parse(txtunitprice.Text));
                    cmd.Parameters.AddWithValue("@quantity", int.Parse(txtquantity.Text));
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        messagebox m = new messagebox();
                        m.Show();
                        form_manager.messagebox.messagepic.Image = Properties.Resources._checked;
                        form_manager.messagebox.tittle.Text = "";
                        form_manager.messagebox.message.Text = "data inserted successfully";

                        reset();
                    }
                }
                con.Close();
             }
       await getdatafromdatabase.getdata("select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 ", ownerinventoryview, fullinventoryview);

        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            txtsearch.Clear();
            combosort.SelectedIndex = -1;
        }

        private void btneditorclear_Click(object sender, EventArgs e)
        {
            if (btneditoroperator.Text == "Delete")
            {
                txtid.Clear();
            }
            if (btneditoroperator.Text == "Update")
            {
                txtid.Enabled = true;
                txtid.Clear();
                txtid.Enabled = false;

            }
            reset();
        }

        private void btneditorcancel_Click(object sender, EventArgs e)
        {
            btneditoroperator.Text = "";
            paneleditor.Visible = false;
            panel4.Visible = true;
            ppp.Visible = false;
            if (form_manager.adminview.isvalid1)
            {
               panel5.Size = new Size(1063, 400);
            }
            else
            {
                panel5.Size = new Size(1063, 550);
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtid.Text, out _))
            {
                label11.Text = "Numeric value only";
            }
            else
            {
                label11.Text = "";
            }
            if (string.IsNullOrEmpty(txtid.Text))
            {
                label11.Text = "";
            }
        }

        private void txtunitprice_TextChanged_1(object sender, EventArgs e)
        {
            if (!float.TryParse(txtunitprice.Text, out _))
            {
                label12.Text = "Numeric value only";
            }
            else
            {
                label12.Text = "";
            }
            if (string.IsNullOrEmpty(txtunitprice.Text))
            {
                label12.Text = "";
                if (btneditoroperator.Text == "Update")
                {label16.Visible = true; }

            }
            else { 
            label16.Visible=false;
                }

        }
        public void changes()
        {
            if (form_manager.adminview.isvalid1)
            {
                if (btneditoroperator.Text == "Delete" || btneditoroperator.Text == "Update" || btneditoroperator.Text == "Add")
                { panel5.Size = new Size(1063, 215); }
                else 
                { panel5.Size = new Size(1063, 400); }
            }
            else
            {
                if (btneditoroperator.Text == "Delete" || btneditoroperator.Text == "Update" || btneditoroperator.Text == "Add")
                { panel5.Size = new Size(1063, 300); }
                else { panel5.Size = new Size(1063,550); }
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtquantity.Text, out _))
            {
                label13.Text = "Numeric value only";
            }
            else
            {
                label13.Text = "";
            }
            if (string.IsNullOrEmpty(txtquantity.Text))
            {
                label13.Text = "";
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            paneleditor.Visible = true;
            label11.Location = new Point(229, 55);
            txtid.Location = new Point(22, 45);
            label8.Location = new Point(36, 25);
            txtid.Size = new Size(195, 39);
            txtmanufacturer.Visible = true;
            txtname.Visible = true;
            txtquantity.Visible = true;
            txtunitprice.Visible = true;
            daterecieved.Visible = true;
            label3.Visible = true;
            expirydate.Visible = true;
            combocategory.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            panel4.Visible = false;
            if (form_manager.adminview.isvalid)
            {
                panel5.Height = 300;
            }
            btneditoroperator.Text = "Update";
            reset();
            txtid.Clear();
            label16.Visible = true;
            txtid.Enabled=false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            panel5.Size = new Size(1063, 215);
            ppp.Visible = true;
            label16.Visible=false;
            paneleditor.Visible = true;
            label11.Location = new Point(229, 55);
            txtid.Location = new Point(22, 45);
            label8.Location = new Point(36, 25);
            txtid.Size = new Size(195, 39);
            txtmanufacturer.Visible = true;
            txtname.Visible = true;
            txtquantity.Visible = true;
            txtunitprice.Visible = true;
            daterecieved.Visible = true;
            label3.Visible = true;
            expirydate.Visible = true;
            combocategory.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            panel4.Visible = false;
            if (form_manager.adminview.isvalid)
            {
                panel5.Height = 300;
            }
            btneditoroperator.Text = "Add";
            reset();
            SqlCommand cmd = new SqlCommand("select max(id) as id from Inventory2", con);
            con.Open();
            SqlDataReader sdr=cmd.ExecuteReader();
         if (sdr.Read())
                { int i;
                if (sdr["id"] == DBNull.Value)
                { 
                    i = 1;
                    txtid.Text = i.ToString();
                }
                else
                {
                    i = Convert.ToInt32(sdr["id"]) + 1;
                    txtid.Text = i.ToString();
                }
                }
            con.Close();
            txtid.Enabled = false;


        }

        private void btnfullinventory_Click(object sender, EventArgs e)
        {
            ppp.Visible = false;
            panel1.Visible = false;
            panel5.Visible = false;
            panel4.Visible = false;
            panelfullinventory.Visible = true;
            panelfullinventory.Dock = DockStyle.Fill;
            interfaceadjustment1();
            reset();

        }
        private void btnfullinventorycancel_Click(object sender, EventArgs e)
        {
            panelfullinventory.Visible = false;
            panel1.Visible = true;
            panel5.Visible = true;
            panel4.Visible = true;
            ppp.Visible = false;
        }

        private void fireset_Click(object sender, EventArgs e)
        {
            fisearch.Clear();
            ficombosort.SelectedIndex = -1;
        }

        private void fisearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where name like @name +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", fisearch.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                fullinventoryview.DataSource = dataTable;
                interfaceadjustment1();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                fullinventoryview.DataSource = null;
            }
        }

        private void ficombosort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select id,name,quantity,category,unitprice,manufacturer,daterecieved,expirydate,status from Inventory2 where category like @category +'%'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@category", ficombosort.Text.Trim());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                fullinventoryview.DataSource = dataTable;
                interfaceadjustment1();

            }
            else
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.messagepic.Image = Image.FromFile(@"C:\Users\HP\Downloads\exclamation-mark.png");
                form_manager.messagebox.tittle.Text = "";
                form_manager.messagebox.message.Text = "no record found";
                fullinventoryview.DataSource = null;
            }
        }

        private bool is_valid()
        {
            if (txtid.Text == string.Empty)
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Failed";
                form_manager.messagebox.message.Text = "please select a record";
                return false;
            }
            if (txtname.Text == string.Empty)
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Failed";
                form_manager.messagebox.message.Text = "name is required"; 
                return false;
            }
            if (combocategory.Text == string.Empty)
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Failed";
                form_manager.messagebox.message.Text = "category is required";
                return false;
            }
           
            if (txtquantity.Text == string.Empty)
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Failed";
                form_manager.messagebox.message.Text = "quantity is required";
                return false;
            }
            if (txtunitprice.Text == string.Empty)
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Failed";
                form_manager.messagebox.message.Text = "unitprice is required";
                return false;
            }
            if (txtmanufacturer.Text == string.Empty)
            {
                messagebox m = new messagebox();
                m.Show();
                form_manager.messagebox.tittle.Text = "Failed";
                form_manager.messagebox.message.Text = "manufacturer is required";
                return false;
            }

            return true;
        }
        private void ownerinventoryview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ownerinventoryview.Rows[e.RowIndex];

                if (btneditoroperator.Text != "Add")
                { txtid.Text = selectedRow.Cells[0].Value.ToString(); }
                txtname.Text = selectedRow.Cells[1].Value.ToString();
                txtquantity.Text = selectedRow.Cells[2].Value.ToString();
                combocategory.SelectedItem = selectedRow.Cells[3].Value.ToString();
                txtunitprice.Text = selectedRow.Cells[4].Value.ToString();
                txtmanufacturer.Text = selectedRow.Cells[5].Value.ToString();
                string dateRecieved = selectedRow.Cells[6].Value.ToString();
                string ExpiryDate = selectedRow.Cells[7].Value.ToString();
                if (DateTime.TryParse(ExpiryDate, out DateTime expiryDate))
                {
                    expirydate.Value = expiryDate;
                }
                if (DateTime.TryParse(dateRecieved, out DateTime Daterecieved))
                {
                    daterecieved.Value = Daterecieved;
                }

            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
 
