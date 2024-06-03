namespace StationaryManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
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
            panel1.BackColor = Color.MidnightBlue;
            panel1.BackgroundImage = Properties.Resources.istockphoto_1185144619_612x612;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(name);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(575, 380);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Clarendon Blk BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(190, 36);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 11;
            label1.Text = "Admin Login";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.LightCyan;
            linkLabel1.LinkColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(92, 289);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(166, 31);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log in as Staff";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(105, 188);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 55);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Blue;
            button2.Location = new Point(299, 276);
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
            pass.Location = new Point(180, 204);
            pass.Margin = new Padding(3, 4, 3, 4);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.Size = new Size(298, 39);
            pass.TabIndex = 4;
            pass.TextChanged += textBox2_TextChanged;
            // 
            // name
            // 
            name.BackColor = Color.Snow;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(180, 125);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(298, 39);
            name.TabIndex = 3;
            name.TextChanged += textBox1_TextChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 380);
            Controls.Add(panel1);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Login";
            Load += Form2_Load;
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
        private Button button2;
        private TextBox pass;
        private TextBox name;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}