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
using System.Xml.Linq;

namespace StationaryManagementSystem
{
    public partial class Bill : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-969LCKU;Initial Catalog=StationaryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        int a;
        public Bill()
        {
            InitializeComponent();
        }
        void Fill_bill()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            adp = new SqlDataAdapter("select tbl_bill.bill_id,tbl_product.name,tbl_product.price,tbl_bill.quantity,tbl_bill.price,tbl_bill.date from tbl_bill join tbl_product on tbl_bill.product_id=tbl_product.id where cust_id = (select id from tbl_customer where name ='none');", con);
            con.Open();
            adp.Fill(dt);
            con.Close();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = dt;
        }
        void bind_cat()
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

        void bind_product()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            adp = new SqlDataAdapter("select * from tbl_product where cat_id='" + cat.SelectedValue + "';", con) ;
            con.Open();
            adp.Fill(dt);
            con.Close();

            product.DataSource = dt;
            product.ValueMember = "id";
            product.DisplayMember = "name";
        }
        void create_customer()
        {
            dataGridView1.ClearSelection();
            con.Close();
            con.Open();
            cmd = new SqlCommand("insert into tbl_customer values('none',100,100);", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("new customer creted");


            name.Text = "";
            conno.Text = "";
            product.SelectedValue = 0;
            cat.SelectedValue = 0;
            quan.Text = "";
        }
        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void Bill_Load_1(object sender, EventArgs e)
        {
            bind_cat();
            a = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = new SqlCommand("insert into tbl_bill values(" + product.SelectedValue + "," + quan.Text + ",((select price from tbl_product where id = " + product.SelectedValue + ")*" + quan.Text + "),'" + date.Text + "',(select id from tbl_customer where name='none'));", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("update tbl_product set stock=stock-" + quan.Text + " where id=" + product.SelectedValue + ";", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            Fill_bill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select SUM(price) from tbl_bill where cust_id=(select id from tbl_customer where name='none');", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textBox1.Text = dr.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
            con.Close();

            con.Close();
            con.Open();
            cmd = new SqlCommand("update tbl_customer set name='" + name.Text + "',conno=" + conno.Text + ",amount=" + textBox1.Text + " where name='none';", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Successfully");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                bind_product();
            }
        }

        private void cat_Click(object sender, EventArgs e)
        {
            //bind_product();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            cmd = new SqlCommand("update tbl_bill set product_id=" + product.SelectedValue + ",quantity=" + quan.Text + ",price=(select price from tbl_product where id = " + product.SelectedValue + ")*" + quan.Text + ",date='" + date.Text + "',cust_id=(select id from tbl_customer where name='none') where bill_id=" + id.Text + ";", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Successfully");
            Fill_bill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select * from tbl_bill;", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                product.SelectedValue = dr.GetValue(1).ToString();
                quan.Text = dr.GetValue(2).ToString();
                date.Text = dr.GetValue(4).ToString();
                cat.SelectedValue = dr.GetValue(5).ToString();
            }
            else
            {
                MessageBox.Show("Record not found");
            }
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            create_customer();
        }
    }
}
