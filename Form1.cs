using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace belgiumcampusstudents
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        public string constring = "Data Source=DESKTOP-H1ADE8T\\SQLEXPRESS;Initial Catalog=players;Integrated Security=True";
        

        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                var q = "insert into tblfootball(id , playername)values('" + txtID.Text.ToString() + "','" + txtName.Text.ToString();
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("ConnectionState made successfully");

            }
        }
    }
}
