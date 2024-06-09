namespace AppQuanLyKhachSan
{
    partial class XoaPTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XoaPTP));
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel10 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            panel9 = new Panel();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            pictureBox10 = new PictureBox();
            pictureBox9 = new PictureBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(23, 43, 53);
            label7.Location = new Point(15, 14);
            label7.Name = "label7";
            label7.Size = new Size(313, 32);
            label7.TabIndex = 8;
            label7.Text = "Xóa phiếu thuê phòng";
            label7.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 739);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(panel9);
            panel2.Location = new Point(15, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(966, 633);
            panel2.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel10.Controls.Add(button1);
            panel10.Controls.Add(dataGridView1);
            panel10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel10.Location = new Point(2, 232);
            panel10.Name = "panel10";
            panel10.Size = new Size(961, 398);
            panel10.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Gray;
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = Color.White;
            button1.Location = new Point(766, 345);
            button1.Name = "button1";
            button1.Size = new Size(181, 50);
            button1.TabIndex = 17;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(947, 310);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(23, 42, 53);
            label9.Location = new Point(15, 194);
            label9.Name = "label9";
            label9.Size = new Size(288, 25);
            label9.TabIndex = 2;
            label9.Text = "Danh sách phiếu thuê phòng";
            label9.Click += label9_Click;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Controls.Add(button2);
            panel9.Controls.Add(button3);
            panel9.Controls.Add(textBox3);
            panel9.Controls.Add(textBox2);
            panel9.Controls.Add(pictureBox10);
            panel9.Controls.Add(pictureBox9);
            panel9.Controls.Add(label8);
            panel9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel9.Location = new Point(0, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(963, 177);
            panel9.TabIndex = 1;
            panel9.Paint += panel9_Paint;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Firebrick;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.White;
            button2.Location = new Point(768, 13);
            button2.Name = "button2";
            button2.Size = new Size(149, 50);
            button2.TabIndex = 17;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.FromArgb(23, 42, 53);
            button3.Cursor = Cursors.Hand;
            button3.ForeColor = Color.White;
            button3.Location = new Point(768, 86);
            button3.Name = "button3";
            button3.Size = new Size(149, 50);
            button3.TabIndex = 16;
            button3.Text = "Làm mới";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(515, 66);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Mã phòng";
            textBox3.Size = new Size(221, 30);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += DataFilter;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(224, 65);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mã phiếu thuê";
            textBox2.Size = new Size(203, 30);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += DataFilter;
            // 
            // pictureBox10
            // 
            pictureBox10.Anchor = AnchorStyles.Top;
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(455, 59);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(43, 41);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 13;
            pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.Top;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(165, 59);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(43, 41);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 11;
            pictureBox9.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(23, 42, 53);
            label8.Location = new Point(15, 13);
            label8.Name = "label8";
            label8.Size = new Size(276, 25);
            label8.TabIndex = 0;
            label8.Text = "Thông tin phiếu thuê phòng";
            label8.Click += label8_Click;
            // 
            // XoaPTP
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1021, 760);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "XoaPTP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xoá phiếu thuê phòng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Panel panel10;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label9;
        private Panel panel9;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox2;
        private PictureBox pictureBox10;
        private PictureBox pictureBox9;
        private Label label8;
    }
}