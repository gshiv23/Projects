namespace StationaryManagementSystem
{
    partial class Dashboard
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
            panel1 = new Panel();
            Stock = new Label();
            label2 = new Label();
            panel2 = new Panel();
            Sales = new Label();
            label4 = new Label();
            panel3 = new Panel();
            user = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(Stock);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(123, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 160);
            panel1.TabIndex = 0;
            // 
            // Stock
            // 
            Stock.AutoSize = true;
            Stock.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Stock.Location = new Point(74, 79);
            Stock.Name = "Stock";
            Stock.Size = new Size(0, 41);
            Stock.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(56, 17);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 2;
            label2.Text = "Product";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(Sales);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(447, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 160);
            panel2.TabIndex = 3;
            // 
            // Sales
            // 
            Sales.AutoSize = true;
            Sales.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Sales.Location = new Point(74, 79);
            Sales.Name = "Sales";
            Sales.Size = new Size(0, 41);
            Sales.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(93, 15);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 2;
            label4.Text = "Sales";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Controls.Add(user);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(762, 72);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 160);
            panel3.TabIndex = 3;
            // 
            // user
            // 
            user.AutoSize = true;
            user.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            user.Location = new Point(74, 79);
            user.Name = "user";
            user.Size = new Size(0, 41);
            user.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(91, 17);
            label6.Name = "label6";
            label6.Size = new Size(58, 28);
            label6.TabIndex = 2;
            label6.Text = "Staff";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(976, 228);
            dataGridView1.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.light_blue_abstract_background_square_shapes_bright_navy_dynamic_vector_diagonal_lines_cover_business_presentation_sale_207204559;
            ClientSize = new Size(1135, 542);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Stock;
        private Label label2;
        private Panel panel2;
        private Label Sales;
        private Label label4;
        private Panel panel3;
        private Label user;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
    }
}