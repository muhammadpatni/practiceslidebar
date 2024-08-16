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
    public partial class admininventory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7TMAKUL\\SQLEXPRESS;Initial Catalog=medical;Integrated Security=True;");
        public admininventory()
        {
            InitializeComponent();
        }
        
        private void getinventoryrecord()
        {
            string query = "select * from Inventory2 ";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            admininventoryview.DataSource = dt;
        }

        private void admininventory_Load(object sender, EventArgs e)
        {
            getinventoryrecord();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
