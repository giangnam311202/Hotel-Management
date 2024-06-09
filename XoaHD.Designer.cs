namespace AppQuanLyKhachSan
{
    partial class XoaHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaHD));
            label7 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel9 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            panel10 = new Panel();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel9.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 43, 53);
            label7.Location = new Point(15, 18);
            label7.Name = "label7";
            label7.Size = new Size(186, 32);
            label7.TabIndex = 8;
            label7.Text = "Xoá hoá đơn";
            label7.Click += label7_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(193, 97);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.Firebrick;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(625, 95);
            button1.Name = "button1";
            button1.Size = new Size(170, 50);
            button1.TabIndex = 5;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(242, 105);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Mã hoá đơn";
            textBox1.Size = new Size(338, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(23, 42, 53);
            label8.Location = new Point(23, 14);
            label8.Name = "label8";
            label8.Size = new Size(187, 25);
            label8.TabIndex = 0;
            label8.Text = "Thông tin hoá đơn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(23, 42, 53);
            label9.Location = new Point(13, 247);
            label9.Name = "label9";
            label9.Size = new Size(199, 25);
            label9.TabIndex = 2;
            label9.Text = "Danh sách hoá đơn";
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox2);
            panel9.Controls.Add(button1);
            panel9.Controls.Add(textBox1);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(3, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(946, 231);
            panel9.TabIndex = 4;
            panel9.Paint += panel9_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(3, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(953, 774);
            panel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(23, 42, 53);
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(730, 706);
            button2.Name = "button2";
            button2.Size = new Size(170, 58);
            button2.TabIndex = 9;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(dataGridView1);
            panel10.Location = new Point(2, 291);
            panel10.Name = "panel10";
            panel10.Size = new Size(1007, 409);
            panel10.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(933, 392);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 863);
            panel1.TabIndex = 24;
            // 
            // XoaHD
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(950, 866);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "XoaHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xoá hoá đơn";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private PictureBox pictureBox2;
        private Button button1;
        private TextBox textBox1;
        private Label label8;
        private Label label9;
        private Panel panel9;
        private Panel panel2;
        private Panel panel10;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
    }
}