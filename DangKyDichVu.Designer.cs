namespace AppQuanLyKhachSan
{
    partial class DangKyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyDichVu));
            panel1 = new Panel();
            button3 = new Button();
            button4 = new Button();
            panel5 = new Panel();
            dataGridView3 = new DataGridView();
            label5 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            dataGridView2 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            pictureBox13 = new PictureBox();
            textBox10 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox14 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 839);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.BackColor = Color.Firebrick;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            button3.Location = new Point(927, 704);
            button3.Name = "button3";
            button3.Size = new Size(110, 50);
            button3.TabIndex = 25;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom;
            button4.BackColor = Color.FromArgb(0, 0, 192);
            button4.Cursor = Cursors.Hand;
            button4.ForeColor = Color.White;
            button4.Location = new Point(801, 704);
            button4.Name = "button4";
            button4.Size = new Size(110, 50);
            button4.TabIndex = 24;
            button4.Text = "Cập nhật";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dataGridView3);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(34, 369);
            panel5.Name = "panel5";
            panel5.Size = new Size(611, 397);
            panel5.TabIndex = 6;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(0, 59);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(611, 335);
            dataGridView3.TabIndex = 5;
            dataGridView3.CellClick += dataGridView3_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(23, 42, 53);
            label5.Location = new Point(8, 14);
            label5.Name = "label5";
            label5.Size = new Size(342, 25);
            label5.TabIndex = 4;
            label5.Text = "Danh sách các dịch vụ đã đăng ký";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(dataGridView2);
            panel4.Location = new Point(34, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(396, 285);
            panel4.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 42, 53);
            label4.Location = new Point(16, 14);
            label4.Name = "label4";
            label4.Size = new Size(222, 25);
            label4.TabIndex = 6;
            label4.Text = "Danh sách phiếu thuê";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(71, 69);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập mã phòng";
            textBox1.Size = new Size(278, 30);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(16, 103);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(333, 179);
            dataGridView2.TabIndex = 22;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.BackColor = Color.Gray;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1053, 704);
            button2.Name = "button2";
            button2.Size = new Size(110, 50);
            button2.TabIndex = 14;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(675, 704);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 13;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(454, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 285);
            panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(693, 230);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 42, 53);
            label2.Location = new Point(8, 14);
            label2.Name = "label2";
            label2.Size = new Size(230, 25);
            label2.TabIndex = 4;
            label2.Text = "Danh sách các dịch vụ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 42, 53);
            label1.Location = new Point(445, 17);
            label1.Name = "label1";
            label1.Size = new Size(318, 46);
            label1.TabIndex = 4;
            label1.Text = "Đăng ký dịch vụ";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(687, 369);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 265);
            panel3.TabIndex = 3;
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
            textBox10.PlaceholderText = "Mã phòng";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(361, 30);
            textBox10.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 42, 53);
            label3.Location = new Point(16, 16);
            label3.Name = "label3";
            label3.Size = new Size(435, 39);
            label3.TabIndex = 3;
            label3.Text = "Thông tin Đăng ký dịch vụ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(pictureBox14);
            groupBox1.Location = new Point(3, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày đăng ký dịch vụ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(354, 30);
            dateTimePicker1.TabIndex = 13;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(6, 36);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(50, 41);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 14;
            pictureBox14.TabStop = false;
            // 
            // DangKyDichVu
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1186, 803);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "DangKyDichVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký dịch vụ";
            Load += DangKyDichVu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox13;
        private TextBox textBox10;
        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox14;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private DataGridView dataGridView2;
        private Label label4;
        private Panel panel5;
        private DataGridView dataGridView3;
        private Label label5;
        private Button button4;
        private Button button3;
    }
}