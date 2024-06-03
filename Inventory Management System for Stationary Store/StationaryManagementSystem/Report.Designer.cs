namespace StationaryManagementSystem
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 16);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.ImageAlign = ContentAlignment.BottomCenter;
            label3.Location = new Point(91, 23);
            label3.Name = "label3";
            label3.Size = new Size(122, 45);
            label3.TabIndex = 6;
            label3.Text = "Report";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 467);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 467);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Report";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Panel panel1;
    }
}