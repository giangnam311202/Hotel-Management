namespace AppQuanLyKhachSan
{
    partial class LapPTP_receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapPTP_receptionist));
            panel1 = new Panel();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            pictureBox13 = new PictureBox();
            textBox10 = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            pictureBox14 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox14).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 927);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(16, 79);
            panel5.Name = "panel5";
            panel5.Size = new Size(452, 265);
            panel5.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 45);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Mã phòng";
            textBox1.Size = new Size(327, 30);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(23, 42, 53);
            label4.Location = new Point(15, 17);
            label4.Name = "label4";
            label4.Size = new Size(237, 25);
            label4.TabIndex = 4;
            label4.Text = "Phòng trống trong ngày";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(427, 181);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(789, 371);
            button2.Name = "button2";
            button2.Size = new Size(110, 50);
            button2.TabIndex = 12;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(668, 371);
            button1.Name = "button1";
            button1.Size = new Size(110, 50);
            button1.TabIndex = 11;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(pictureBox13);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(groupBox1);
            panel3.Location = new Point(474, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(420, 265);
            panel3.TabIndex = 2;
            // 
            // pictureBox13
            // 
            pictureBox13.Image = (Image)resources.GetObject("pictureBox13.Image");
            pictureBox13.Location = new Point(7, 102);
            pictureBox13.Name = "pictureBox13";
            pictureBox13.Size = new Size(34, 30);
            pictureBox13.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox13.TabIndex = 5;
            pictureBox13.TabStop = false;
            // 
            // textBox10
            // 
            textBox10.Cursor = Cursors.IBeam;
            textBox10.Location = new Point(47, 102);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Mã phòng";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(363, 30);
            textBox10.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(23, 42, 53);
            label3.Location = new Point(30, 34);
            label3.Name = "label3";
            label3.Size = new Size(358, 39);
            label3.TabIndex = 3;
            label3.Text = "Thông tin phòng thuê";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(pictureBox14);
            groupBox1.Location = new Point(3, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ngày thuê phòng";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(46, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(339, 30);
            dateTimePicker1.TabIndex = 13;
            // 
            // pictureBox14
            // 
            pictureBox14.Image = (Image)resources.GetObject("pictureBox14.Image");
            pictureBox14.Location = new Point(6, 43);
            pictureBox14.Name = "pictureBox14";
            pictureBox14.Size = new Size(34, 34);
            pictureBox14.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox14.TabIndex = 14;
            pictureBox14.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(23, 42, 53);
            label1.Location = new Point(251, 16);
            label1.Name = "label1";
            label1.Size = new Size(424, 46);
            label1.TabIndex = 1;
            label1.Text = "Lập phiếu thuê phòng";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(16, 431);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 357);
            panel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.Firebrick;
            button4.Cursor = Cursors.Hand;
            button4.ForeColor = Color.White;
            button4.Location = new Point(549, 32);
            button4.Name = "button4";
            button4.Size = new Size(110, 50);
            button4.TabIndex = 14;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            button3.Location = new Point(421, 32);
            button3.Name = "button3";
            button3.Size = new Size(110, 50);
            button3.TabIndex = 14;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(15, 97);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.ScrollBars = ScrollBars.None;
            dataGridView2.Size = new Size(853, 243);
            dataGridView2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(32, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 18);
            label5.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 42, 53);
            label2.Location = new Point(32, 34);
            label2.Name = "label2";
            label2.Size = new Size(364, 39);
            label2.TabIndex = 2;
            label2.Text = "Thông tin khách hàng";
            // 
            // LapPTP_receptionist
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(932, 863);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "LapPTP_receptionist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lập phiếu thuê phòng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox13).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox14).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private PictureBox pictureBox13;
        private TextBox textBox10;
        private GroupBox groupBox1;
        private PictureBox pictureBox14;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView2;
    }
}