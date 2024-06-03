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

namespace StationaryManagementSystem
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-969LCKU;Initial Catalog=StationaryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("select * from tbl_admin where admin_name = '" + name.Text + "' and admin_pass='" + pass.Text + "';", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MainMenu f1 = new MainMenu(name.Text);
                f1.Show();

            }
            else
            {
                MessageBox.Show("invalid user");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffLogin l = new StaffLogin();
            l.Show();
            this.Hide();
        }
    }
}