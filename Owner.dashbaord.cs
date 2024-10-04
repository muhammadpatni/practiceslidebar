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
        }

        void GetNumberOfItems()
        {
            int numberOfItems = 0;
            string query = "select count(*) from Inventory2";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            numberOfItems = Convert.ToInt16(cmd.ExecuteScalar());
            lbnumberofitems.Text=numberOfItems.ToString(); 
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
