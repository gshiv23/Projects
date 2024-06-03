using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StationaryManagementSystem
{
    public partial class Staff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-969LCKU;Initial Catalog=StationaryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        string gender;
        public Staff()
        {
            InitializeComponent();
        }

        void Fill_staff()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            DataTable dt = new DataTable();
            con.Close();
            adp = new SqlDataAdapter("select * from tbl_staff", con);
            con.Open();
            adp.Fill(dt);
            con.Close();
            dataGridView1.ClearSelection();
            dataGridView1.DataSource = dt;
        }

        private void User_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {
            Fill_staff() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select * from tbl_staff where id=" + id.Text + ";", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                name.Text = dr.GetValue(1).ToString();
                pass.Text = dr.GetValue(2).ToString();
                if (dr.GetValue(3).ToString() == "Female")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }
                conno.Text = dr.GetValue(4).ToString();
                date.Text = dr.GetValue(5).ToString();
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
            cmd = new SqlCommand("insert into tbl_staff values('" + name.Text + "','" + pass.Text + "','" + gender + "'," + conno.Text + ",'" + date.Text + "');", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Inserted Successfully");
            Fill_staff();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from tbl_staff where id=" + id.Text + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record deleted Successfully");
            Fill_staff();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = "Female";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("update tbl_staff set staff_name='" + name.Text + "', staff_pass='" + pass.Text + "',gender='" + gender + "', contact_no=" + conno.Text + ", joining_date='" + date.Text + "' where id=" + id.Text + ";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record updated Successfully");
            Fill_staff();
        }
    }
}
