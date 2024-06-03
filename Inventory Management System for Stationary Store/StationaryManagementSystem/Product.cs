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
using System.Xml.Linq;

namespace StationaryManagementSystem
{
    public partial class Product : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-969LCKU;Initial Catalog=StationaryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Product()
        {
            InitializeComponent();
        }
        void Fill_Product()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            adp = new SqlDataAdapter("select tbl_product.id,tbl_product.name,tbl_product.price,tbl_product.stock,tbl_category.name from tbl_product join tbl_category on tbl_product.cat_id=tbl_category.id;", con);
            con.Open();
            adp.Fill(dt);
            con.Close();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = dt;
        }
        void bind()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            adp = new SqlDataAdapter("select * from tbl_category;", con);
            con.Open();
            adp.Fill(dt);
            con.Close();
            cat.DataSource = dt;
            cat.ValueMember = "id";
            cat.DisplayMember = "name";
        }

        private void Product_Load(object sender, EventArgs e)
        {
            Fill_Product();
            bind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select * from tbl_product where id=" + id.Text + ";", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                name.Text = dr.GetValue(1).ToString();
                price.Text = dr.GetValue(2).ToString();
                quan.Text = dr.GetValue(3).ToString();
                cat.SelectedValue = dr.GetValue(4).ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
                id.Text = "";
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into tbl_product values('" + name.Text + "'," + price.Text + "," + quan.Text + "," + cat.SelectedValue + ");", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            Fill_Product();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("update tbl_product set name='" + name.Text + "', price=" + price.Text + ",stock=" + quan.Text + ", cat_id = " + cat.SelectedValue + " where id = " + id.Text + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Successfully");
            Fill_Product();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from tbl_product where id = " + id.Text + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Successfully");
            Fill_Product();
        }
    }
}
