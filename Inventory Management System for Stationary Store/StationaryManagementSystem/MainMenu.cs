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
    public partial class MainMenu : Form
    {
        public MainMenu(String str)
        {
            //it6.Text += str;
            InitializeComponent();
        }

        private void manageItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product i = new Product();
            i.ShowDialog();
        }

        private void manageCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.ShowDialog();
        }

        private void generateBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();
            s.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
