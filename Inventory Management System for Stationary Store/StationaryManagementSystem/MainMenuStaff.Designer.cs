namespace StationaryManagementSystem
{
    partial class MainMenuStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuStaff));
            menuStrip1 = new MenuStrip();
            manageUserToolStripMenuItem = new ToolStripMenuItem();
            uPDATEDELETEUserToolStripMenuItem = new ToolStripMenuItem();
            manageCategoryToolStripMenuItem = new ToolStripMenuItem();
            manageItemsToolStripMenuItem = new ToolStripMenuItem();
            uPDATEDELETEItemsToolStripMenuItem = new ToolStripMenuItem();
            billToolStripMenuItem = new ToolStripMenuItem();
            generateBillToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            it6 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.RoyalBlue;
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageUserToolStripMenuItem, manageCategoryToolStripMenuItem, manageItemsToolStripMenuItem, billToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, it6, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1069, 38);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageUserToolStripMenuItem
            // 
            manageUserToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uPDATEDELETEUserToolStripMenuItem });
            manageUserToolStripMenuItem.Enabled = false;
            manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            manageUserToolStripMenuItem.Size = new Size(150, 32);
            manageUserToolStripMenuItem.Text = "Manage User";
            // 
            // uPDATEDELETEUserToolStripMenuItem
            // 
            uPDATEDELETEUserToolStripMenuItem.Name = "uPDATEDELETEUserToolStripMenuItem";
            uPDATEDELETEUserToolStripMenuItem.Size = new Size(355, 32);
            uPDATEDELETEUserToolStripMenuItem.Text = "ADD/UPDATE/DELETE User";
            // 
            // manageCategoryToolStripMenuItem
            // 
            manageCategoryToolStripMenuItem.Enabled = false;
            manageCategoryToolStripMenuItem.Name = "manageCategoryToolStripMenuItem";
            manageCategoryToolStripMenuItem.Size = new Size(194, 32);
            manageCategoryToolStripMenuItem.Text = "Manage Category";
            // 
            // manageItemsToolStripMenuItem
            // 
            manageItemsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uPDATEDELETEItemsToolStripMenuItem });
            manageItemsToolStripMenuItem.Enabled = false;
            manageItemsToolStripMenuItem.Name = "manageItemsToolStripMenuItem";
            manageItemsToolStripMenuItem.Size = new Size(160, 32);
            manageItemsToolStripMenuItem.Text = "Manage Items";
            // 
            // uPDATEDELETEItemsToolStripMenuItem
            // 
            uPDATEDELETEItemsToolStripMenuItem.Name = "uPDATEDELETEItemsToolStripMenuItem";
            uPDATEDELETEItemsToolStripMenuItem.Size = new Size(365, 32);
            uPDATEDELETEItemsToolStripMenuItem.Text = "ADD/UPDATE/DELETE Items";
            // 
            // billToolStripMenuItem
            // 
            billToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { generateBillToolStripMenuItem });
            billToolStripMenuItem.Name = "billToolStripMenuItem";
            billToolStripMenuItem.Size = new Size(57, 32);
            billToolStripMenuItem.Text = "Bill";
            // 
            // generateBillToolStripMenuItem
            // 
            generateBillToolStripMenuItem.Name = "generateBillToolStripMenuItem";
            generateBillToolStripMenuItem.Size = new Size(221, 32);
            generateBillToolStripMenuItem.Text = "Generate Bill";
            generateBillToolStripMenuItem.Click += generateBillToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Enabled = false;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(128, 32);
            toolStripMenuItem1.Text = "Dashboard";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(38, 32);
            toolStripMenuItem2.Text = "  ";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(32, 32);
            toolStripMenuItem3.Text = " ";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(44, 32);
            toolStripMenuItem4.Text = "   ";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(44, 32);
            toolStripMenuItem5.Text = "   ";
            // 
            // it6
            // 
            it6.Name = "it6";
            it6.Size = new Size(32, 32);
            it6.Text = " ";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(92, 32);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-413, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1482, 789);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MainMenuStaff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1069, 678);
            Controls.Add(menuStrip1);
            Controls.Add(pictureBox1);
            Name = "MainMenuStaff";
            ShowIcon = false;
            Text = "MainMenuStaff";
            Load += MainMenuStaff_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageUserToolStripMenuItem;
        private ToolStripMenuItem uPDATEDELETEUserToolStripMenuItem;
        private ToolStripMenuItem manageCategoryToolStripMenuItem;
        private ToolStripMenuItem manageItemsToolStripMenuItem;
        private ToolStripMenuItem uPDATEDELETEItemsToolStripMenuItem;
        private ToolStripMenuItem billToolStripMenuItem;
        private ToolStripMenuItem generateBillToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem it6;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}