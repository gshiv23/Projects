using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryManagementSystem
{
    public partial class MainMenuStaff : Form
    {
        public MainMenuStaff(string str)
        {
            //it6.Text = str;
            InitializeComponent();
        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill b1 = new Bill();
            b1.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MainMenuStaff_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
