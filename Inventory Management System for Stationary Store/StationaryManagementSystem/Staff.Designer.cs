namespace StationaryManagementSystem
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button4 = new Button();
            id = new TextBox();
            label7 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            name = new TextBox();
            label5 = new Label();
            pass = new TextBox();
            date = new DateTimePicker();
            label1 = new Label();
            label6 = new Label();
            conno = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Lavender;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 401);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(830, 231);
            dataGridView1.TabIndex = 12;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(631, 234);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(179, 44);
            button3.TabIndex = 29;
            button3.Text = "View";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.FlatAppearance.BorderColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(631, 106);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 44);
            button1.TabIndex = 28;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(631, 348);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(179, 44);
            button2.TabIndex = 27;
            button2.Text = "Delete User";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(292, 19);
            label3.Name = "label3";
            label3.Size = new Size(271, 54);
            label3.TabIndex = 10;
            label3.Text = "Manage Staff";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.BackgroundImage = Properties.Resources.light_blue_abstract_background_square_shapes_bright_navy_dynamic_vector_diagonal_lines_cover_business_presentation_sale_207204559;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(id);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pass);
            panel1.Controls.Add(date);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(conno);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 659);
            panel1.TabIndex = 8;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(631, 291);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(179, 43);
            button4.TabIndex = 68;
            button4.Text = "Update User";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // id
            // 
            id.BackColor = Color.LightBlue;
            id.BorderStyle = BorderStyle.FixedSingle;
            id.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            id.Location = new Point(631, 188);
            id.Margin = new Padding(3, 4, 3, 4);
            id.Name = "id";
            id.Size = new Size(179, 34);
            id.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.BottomCenter;
            label7.Location = new Point(697, 159);
            label7.Name = "label7";
            label7.Size = new Size(40, 25);
            label7.TabIndex = 66;
            label7.Text = "id :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.FromArgb(224, 224, 224);
            radioButton2.Location = new Point(333, 229);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 32);
            radioButton2.TabIndex = 65;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.FromArgb(224, 224, 224);
            radioButton1.Location = new Point(217, 228);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(76, 32);
            radioButton1.TabIndex = 64;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(22, 233);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 63;
            label4.Text = "Gender:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            name.BackColor = Color.LightBlue;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(217, 120);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(360, 34);
            name.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(22, 126);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 61;
            label5.Text = "Staff Name:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pass
            // 
            pass.BackColor = Color.LightBlue;
            pass.BorderStyle = BorderStyle.FixedSingle;
            pass.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pass.Location = new Point(217, 174);
            pass.Margin = new Padding(3, 4, 3, 4);
            pass.Name = "pass";
            pass.Size = new Size(360, 34);
            pass.TabIndex = 60;
            pass.TextChanged += textBox1_TextChanged;
            // 
            // date
            // 
            date.CalendarForeColor = SystemColors.AppWorkspace;
            date.CalendarTrailingForeColor = Color.GreenYellow;
            date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(218, 341);
            date.Margin = new Padding(3, 4, 3, 4);
            date.Name = "date";
            date.Size = new Size(359, 34);
            date.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(24, 350);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 58;
            label1.Text = "Date of Joining:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(24, 287);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 54;
            label6.Text = "Contact :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // conno
            // 
            conno.BackColor = Color.LightBlue;
            conno.BorderStyle = BorderStyle.FixedSingle;
            conno.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            conno.Location = new Point(218, 278);
            conno.Margin = new Padding(3, 4, 3, 4);
            conno.Name = "conno";
            conno.Size = new Size(360, 34);
            conno.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(22, 181);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 50;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 659);
            Controls.Add(panel1);
            Name = "Staff";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private DateTimePicker date;
        private Label label1;
        private Label label6;
        private TextBox conno;
        private Label label2;
        private TextBox name;
        private Label label5;
        private TextBox pass;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private TextBox id;
        private Label label7;
        private Button button4;
    }
}