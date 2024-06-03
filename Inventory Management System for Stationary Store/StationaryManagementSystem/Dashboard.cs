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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StationaryManagementSystem
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-969LCKU;Initial Catalog=StationaryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Dashboard()
        {
            InitializeComponent();
        }

        void Bind(Label l, int a)
        {
            con.Close();
            if (a == 1)
            {
                cmd = new SqlCommand("select COUNT(*) from tbl_product;", con);
            }
            else if (a == 2)
            {
                cmd = new SqlCommand("select SUM(amount) from tbl_customer;", con);
            }
            else if (a == 3)
            {
                cmd = new SqlCommand("select COUNT(*) from tbl_staff;", con);
            }
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                l.Text = dr.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
            con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Bind(Stock, 1);
            Bind(Sales, 2);
            Bind(user, 3);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            adp = new SqlDataAdapter("select * from tbl_customer", con);
            con.Open();
            adp.Fill(dt);
            con.Close();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = dt;
        }
    }
}
