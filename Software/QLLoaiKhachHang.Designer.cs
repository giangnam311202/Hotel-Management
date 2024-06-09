namespace AppQuanLyKhachSan
{
    partial class QLLoaiKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLoaiKhachHang));
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox13 = new PictureBox();
            textBox10 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(34, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(538, 369);
            panel2.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(499, 284);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 42, 53);
            label2.Location = new Point(11, 13);
            label2.Name = "label2";
            label2.Size = new Size(519, 39);
            label2.TabIndex = 4;
            label2.Text = "Danh sách các loại khách hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.Location = new Point(633, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 312);
            panel3.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(65, 245);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nhập hệ số phụ thu";
            textBox2.Size = new Size(367, 30);
            textBox2.TabIndex = 8;
            textBox2.KeyPress += numberonly;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(65, 161);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập tên loại khách hàng";
            textBox1.Size = new Size(367, 30);
            textBox1.TabIndex = 6;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(14, 69);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(45, 53);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            // 
            // textBox10
            // 
            textBox10.Cursor = Cursors.IBeam;
            textBox10.Location = new Point(65, 83);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Mã loại khách hàng";
            textBox10.Size = new Size(367, 30);
            textBox10.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 42, 53);
            label3.Location = new Point(14, 13);
            label3.Name = "label3";
            label3.Size = new Size(432, 39);
            label3.TabIndex = 3;
            label3.Text = "Thông tin loại khách hàng";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 0, 192);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(735, 444);
            button4.Name = "button4";
            button4.Size = new Size(110, 50);
            button4.TabIndex = 25;
            button4.Text = "Cập nhật";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Microsoft Sans Serif", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(875, 444);
            button3.Name = "button3";
            button3.Size = new Size(110, 50);
            button3.TabIndex = 24;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Microsoft Sans Serif", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1015, 444);
            button2.Name = "button2";
            button2.Size = new Size(110, 50);
            button2.TabIndex = 23;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Microsoft Sans Serif", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(595, 444);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 22;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 42, 53);
            label1.Location = new Point(384, 21);
            label1.Name = "label1";
            label1.Size = new Size(401, 46);
            label1.TabIndex = 21;
            label1.Text = "Sửa loại khách hàng";
            label1.Click += label1_Click;
            // 
            // QLLoaiKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1157, 512);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "QLLoaiKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa loại khách hàng";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox13;
        private TextBox textBox10;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textBox2;
    }
}