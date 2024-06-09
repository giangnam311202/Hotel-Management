namespace AppQuanLyKhachSan
{
    partial class ThemHoaDon_receptionist
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

        private Label lblHotelName;
        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private DataGridView dgvInvoiceDetails;
        private Label lblTotalAmount;
        private Button btnExit;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoaDon_receptionist));
            lblHotelName = new Label();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            dgvInvoiceDetails = new DataGridView();
            lblTotalAmount = new Label();
            btnExit = new Button();
            labelHoaDon = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button4 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblHotelName
            // 
            lblHotelName.AutoSize = true;
            lblHotelName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHotelName.Location = new Point(12, 9);
            lblHotelName.Name = "lblHotelName";
            lblHotelName.Size = new Size(97, 25);
            lblHotelName.TabIndex = 0;
            lblHotelName.Text = "My Hotel";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(12, 92);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(167, 25);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Tên Khách Hàng:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Cursor = Cursors.IBeam;
            txtCustomerName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCustomerName.Location = new Point(194, 92);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Nhập họ tên khách hàng";
            txtCustomerName.Size = new Size(236, 30);
            txtCustomerName.TabIndex = 4;
            // 
            // dgvInvoiceDetails
            // 
            dgvInvoiceDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoiceDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoiceDetails.Location = new Point(12, 195);
            dgvInvoiceDetails.Name = "dgvInvoiceDetails";
            dgvInvoiceDetails.RowHeadersWidth = 51;
            dgvInvoiceDetails.Size = new Size(418, 295);
            dgvInvoiceDetails.TabIndex = 9;
            dgvInvoiceDetails.CellClick += dgvInvoiceDetails_CellClick;
            dgvInvoiceDetails.CellContentClick += dgvInvoiceDetails_CellContentClick;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(17, 532);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(151, 25);
            lblTotalAmount.TabIndex = 11;
            lblTotalAmount.Text = "Tổng Số Tiền:";
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.BackColor = Color.Gray;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(737, 571);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 50);
            btnExit.TabIndex = 13;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // labelHoaDon
            // 
            labelHoaDon.AutoSize = true;
            labelHoaDon.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHoaDon.Location = new Point(366, 34);
            labelHoaDon.Name = "labelHoaDon";
            labelHoaDon.Size = new Size(167, 42);
            labelHoaDon.TabIndex = 14;
            labelHoaDon.Text = "Hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 162);
            label2.Name = "label2";
            label2.Size = new Size(179, 25);
            label2.TabIndex = 16;
            label2.Text = "Phiếu Thuê phòng:";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(194, 162);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nhập mã phiếu thuê";
            textBox1.Size = new Size(231, 30);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.BackColor = Color.Green;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(544, 571);
            button4.Name = "button4";
            button4.Size = new Size(150, 50);
            button4.TabIndex = 18;
            button4.Text = "Thanh toán";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            textBox2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(174, 529);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(131, 30);
            textBox2.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 532);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 20;
            label1.Text = "VND";
            label1.Click += label1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(464, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 295);
            dataGridView1.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(464, 166);
            label3.Name = "label3";
            label3.Size = new Size(168, 25);
            label3.TabIndex = 22;
            label3.Text = "Chi tiết phiếu thuê";
            // 
            // ThemHoaDon_receptionist
            // 
            ClientSize = new Size(914, 641);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(labelHoaDon);
            Controls.Add(btnExit);
            Controls.Add(lblTotalAmount);
            Controls.Add(dgvInvoiceDetails);
            Controls.Add(txtCustomerName);
            Controls.Add(lblCustomerName);
            Controls.Add(lblHotelName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ThemHoaDon_receptionist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)dgvInvoiceDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        private Label labelHoaDon;
        private Label label2;
        private TextBox textBox1;
        private Button button4;
        private TextBox textBox2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label3;
    }
}