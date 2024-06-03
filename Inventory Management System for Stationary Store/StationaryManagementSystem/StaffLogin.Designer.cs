namespace StationaryManagementSystem
{
    partial class StaffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffLogin));
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button2 = new Button();
            pass = new TextBox();
            name = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.BackgroundImage = Properties.Resources.istockphoto_1185144619_612x612;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(name);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(544, 364);
            panel1.TabIndex = 7;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Navy;
            linkLabel1.Location = new Point(52, 271);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(206, 31);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "continue as Admin";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(77, 171);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Clarendon Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(166, 33);
            label3.Name = "label3";
            label3.Size = new Size(241, 36);
            label3.TabIndex = 6;
            label3.Text = "STAFF LOGIN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(128, 128, 255);
            button2.Location = new Point(273, 258);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(179, 44);
            button2.TabIndex = 5;
            button2.Text = "Log in";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pass
            // 
            pass.BackColor = Color.Snow;
            pass.BorderStyle = BorderStyle.FixedSingle;
            pass.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pass.Location = new Point(166, 182);
            pass.Margin = new Padding(3, 4, 3, 4);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(286, 39);
            pass.TabIndex = 4;
            // 
            // name
            // 
            name.BackColor = Color.Snow;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(167, 110);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(286, 39);
            name.TabIndex = 3;
            // 
            // StaffLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 364);
            Controls.Add(panel1);
            Name = "StaffLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += EmployeeLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button2;
        private TextBox pass;
        private TextBox name;
        private LinkLabel linkLabel1;
    }
}