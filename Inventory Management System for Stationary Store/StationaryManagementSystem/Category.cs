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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace StationaryManagementSystem
{
    public partial class Category : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-969LCKU;Initial Catalog=StationaryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Category()
        {
            InitializeComponent();
        }

        void Fill_cat()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            adp = new SqlDataAdapter("select * from tbl_category", con);
            con.Open();
            adp.Fill(dt);
            con.Close();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Fill_cat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("update tbl_category set name = '" + name.Text + "' where id = " + id.Text + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Successfully");
            Fill_cat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select * from tbl_category where id='" + id.Text + "';", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                name.Text = dr.GetValue(1).ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
                id.Text = "";
            }
            con.Close();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into tbl_category values('" + name.Text + "');", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            Fill_cat();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from tbl_category where id = " + id.Text + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Successfully");
            Fill_cat();
        }
    }
}
