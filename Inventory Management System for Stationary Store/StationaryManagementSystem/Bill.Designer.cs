namespace StationaryManagementSystem
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            label8 = new Label();
            button3 = new Button();
            id = new TextBox();
            product = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            quan = new TextBox();
            date = new DateTimePicker();
            label5 = new Label();
            label1 = new Label();
            cat = new ComboBox();
            groupBox1 = new GroupBox();
            conno = new TextBox();
            label6 = new Label();
            label7 = new Label();
            name = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            button1.Location = new Point(14, 136);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(179, 44);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(16, 439);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(946, 195);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(104, 31);
            label3.Name = "label3";
            label3.Size = new Size(140, 54);
            label3.TabIndex = 6;
            label3.Text = "Billing";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.BackgroundImage = Properties.Resources.light_blue_abstract_background_square_shapes_bright_navy_dynamic_vector_diagonal_lines_cover_business_presentation_sale_207204559;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(976, 707);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // button6
            // 
            button6.BackColor = Color.Lime;
            button6.FlatAppearance.BorderColor = Color.Blue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(783, 60);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(179, 44);
            button6.TabIndex = 60;
            button6.Text = "New";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.FlatAppearance.BorderColor = Color.Blue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(274, 648);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(225, 44);
            button5.TabIndex = 58;
            button5.Text = "Print Bill";
            button5.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(id);
            groupBox2.Controls.Add(product);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(quan);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(date);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cat);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.Navy;
            groupBox2.Location = new Point(16, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(946, 199);
            groupBox2.TabIndex = 57;
            groupBox2.TabStop = false;
            groupBox2.Text = "Product";
            // 
            // button4
            // 
            button4.BackColor = Color.Lime;
            button4.FlatAppearance.BorderColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(423, 136);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(179, 44);
            button4.TabIndex = 59;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.ImageAlign = ContentAlignment.BottomCenter;
            label8.Location = new Point(637, 155);
            label8.Name = "label8";
            label8.Size = new Size(40, 25);
            label8.TabIndex = 56;
            label8.Text = "id :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(218, 136);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(179, 44);
            button3.TabIndex = 58;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // id
            // 
            id.BackColor = Color.LightBlue;
            id.BorderStyle = BorderStyle.FixedSingle;
            id.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            id.Location = new Point(692, 146);
            id.Margin = new Padding(3, 4, 3, 4);
            id.Name = "id";
            id.Size = new Size(148, 34);
            id.TabIndex = 57;
            // 
            // product
            // 
            product.BackColor = Color.LightBlue;
            product.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            product.FormattingEnabled = true;
            product.Location = new Point(618, 26);
            product.Name = "product";
            product.Size = new Size(306, 36);
            product.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.ImageAlign = ContentAlignment.BottomCenter;
            label2.Location = new Point(503, 37);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 23;
            label2.Text = "Product :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(9, 92);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 25;
            label4.Text = "Quantity :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // quan
            // 
            quan.BackColor = Color.LightBlue;
            quan.BorderStyle = BorderStyle.FixedSingle;
            quan.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            quan.Location = new Point(125, 83);
            quan.Margin = new Padding(3, 4, 3, 4);
            quan.Name = "quan";
            quan.Size = new Size(305, 34);
            quan.TabIndex = 28;
            // 
            // date
            // 
            date.CalendarForeColor = SystemColors.AppWorkspace;
            date.CalendarTrailingForeColor = Color.GreenYellow;
            date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(615, 83);
            date.Margin = new Padding(3, 4, 3, 4);
            date.Name = "date";
            date.Size = new Size(309, 34);
            date.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.ImageAlign = ContentAlignment.BottomCenter;
            label5.Location = new Point(9, 37);
            label5.Name = "label5";
            label5.Size = new Size(103, 25);
            label5.TabIndex = 29;
            label5.Text = "Category :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.ImageAlign = ContentAlignment.BottomCenter;
            label1.Location = new Point(503, 92);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 48;
            label1.Text = "Date :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // cat
            // 
            cat.BackColor = Color.LightBlue;
            cat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cat.FormattingEnabled = true;
            cat.Location = new Point(125, 27);
            cat.Name = "cat";
            cat.Size = new Size(305, 36);
            cat.TabIndex = 30;
            cat.SelectedIndexChanged += cat_SelectedIndexChanged;
            cat.Click += cat_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(conno);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(name);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.Navy;
            groupBox1.Location = new Point(16, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(946, 100);
            groupBox1.TabIndex = 56;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer";
            // 
            // conno
            // 
            conno.BackColor = Color.LightBlue;
            conno.BorderStyle = BorderStyle.FixedSingle;
            conno.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            conno.Location = new Point(622, 38);
            conno.Margin = new Padding(3, 4, 3, 4);
            conno.Name = "conno";
            conno.Size = new Size(309, 34);
            conno.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.ImageAlign = ContentAlignment.BottomCenter;
            label6.Location = new Point(14, 47);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 52;
            label6.Text = "Name :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.ImageAlign = ContentAlignment.BottomCenter;
            label7.Location = new Point(507, 47);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 54;
            label7.Text = "Con. No :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            name.BackColor = Color.LightBlue;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            name.Location = new Point(128, 38);
            name.Margin = new Padding(3, 4, 3, 4);
            name.Name = "name";
            name.Size = new Size(309, 34);
            name.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightBlue;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI Symbol", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(750, 655);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 34);
            textBox1.TabIndex = 51;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 128, 255);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(519, 648);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(225, 44);
            button2.TabIndex = 50;
            button2.Text = "Genrate Total";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.light_blue_abstract_background_square_shapes_bright_navy_dynamic_vector_diagonal_lines_cover_business_presentation_sale_207204559;
            ClientSize = new Size(976, 707);
            Controls.Add(panel1);
            Name = "Bill";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            Load += Bill_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
        private ComboBox cat;
        private Label label5;
        private TextBox quan;
        private Label label4;
        private ComboBox product;
        private Label label2;
        private DateTimePicker date;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private TextBox name;
        private Label label6;
        private TextBox conno;
        private Label label7;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button3;
        private Button button4;
        private Label label8;
        private TextBox id;
        private Button button5;
        private Button button6;
    }
}