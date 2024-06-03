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
    public partial class StaffLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-969LCKU;Initial Catalog=StationaryManagement;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            con.Close();
            cmd = new SqlCommand("select * from tbl_staff where staff_name = '" + name.Text + "' and staff_pass='" + pass.Text + "';", con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                MainMenuStaff m1 = new MainMenuStaff(name.Text.ToString());
                m1.Show();
            }
            else
            {
                MessageBox.Show("invalid user");
            }
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
