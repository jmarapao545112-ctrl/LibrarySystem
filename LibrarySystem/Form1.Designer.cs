namespace LibrarySystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            lblFeeResult = new Label();
            btnCalculateFee = new Button();
            cmbMemberType = new ComboBox();
            label5 = new Label();
            numDaysLate = new NumericUpDown();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label3 = new Label();
            txtCheckoutTitle = new TextBox();
            txtCheckoutBookId = new TextBox();
            label4 = new Label();
            lvActivityLog = new ListView();
            Timestamp = new ColumnHeader();
            ActivityType = new ColumnHeader();
            Details = new ColumnHeader();
            txtQuantity = new TextBox();
            lblStatus = new Label();
            prgEmail = new ProgressBar();
            btnProcessCheckout = new Button();
            label2 = new Label();
            dgvBooks = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            ISBN = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            IsReference = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            button5 = new Button();
            btnEditSelected = new Button();
            btnAddBook = new Button();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDaysLate).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 51);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(320, 31);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Image = Properties.Resources._751623_200;
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 732);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 156);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(181, 44);
            button4.TabIndex = 3;
            button4.Text = "Checkout/Circulation";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 107);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(181, 44);
            button3.TabIndex = 2;
            button3.Text = "Members";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 56);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(181, 44);
            button2.TabIndex = 1;
            button2.Text = "Books/Catalog";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 5);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(181, 44);
            button1.TabIndex = 0;
            button1.Text = "Dashboard";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dgvBooks);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(btnEditSelected);
            panel3.Controls.Add(btnAddBook);
            panel3.Controls.Add(txtSearch);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(181, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 732);
            panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblFeeResult);
            groupBox2.Controls.Add(btnCalculateFee);
            groupBox2.Controls.Add(cmbMemberType);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numDaysLate);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(527, 293);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(21, 20, 21, 20);
            groupBox2.Size = new Size(497, 419);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "LATE FEE CALCULATOR";
            // 
            // lblFeeResult
            // 
            lblFeeResult.BorderStyle = BorderStyle.FixedSingle;
            lblFeeResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeeResult.Location = new Point(23, 179);
            lblFeeResult.Name = "lblFeeResult";
            lblFeeResult.Size = new Size(290, 25);
            lblFeeResult.TabIndex = 4;
            lblFeeResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculateFee
            // 
            btnCalculateFee.BackColor = Color.SteelBlue;
            btnCalculateFee.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculateFee.ForeColor = Color.White;
            btnCalculateFee.Location = new Point(282, 108);
            btnCalculateFee.Name = "btnCalculateFee";
            btnCalculateFee.Size = new Size(112, 29);
            btnCalculateFee.TabIndex = 3;
            btnCalculateFee.Text = "Calculate Fee";
            btnCalculateFee.UseVisualStyleBackColor = false;
            btnCalculateFee.Click += btnCalculateFee_Click;
            // 
            // cmbMemberType
            // 
            cmbMemberType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMemberType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMemberType.FormattingEnabled = true;
            cmbMemberType.Items.AddRange(new object[] { "Student", "Faculty", "Guest" });
            cmbMemberType.Location = new Point(282, 51);
            cmbMemberType.Name = "cmbMemberType";
            cmbMemberType.Size = new Size(179, 28);
            cmbMemberType.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 56);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 1;
            label5.Text = "Days Late:";
            // 
            // numDaysLate
            // 
            numDaysLate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDaysLate.Location = new Point(104, 53);
            numDaysLate.Name = "numDaysLate";
            numDaysLate.Size = new Size(97, 27);
            numDaysLate.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCheckoutTitle);
            groupBox1.Controls.Add(txtCheckoutBookId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lvActivityLog);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(prgEmail);
            groupBox1.Controls.Add(btnProcessCheckout);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 293);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(21, 20, 21, 20);
            groupBox1.Size = new Size(491, 419);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOOK CHECKOUT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 106);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 11;
            label6.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 70);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 10;
            label3.Text = "ID:";
            // 
            // txtCheckoutTitle
            // 
            txtCheckoutTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCheckoutTitle.Location = new Point(71, 101);
            txtCheckoutTitle.Name = "txtCheckoutTitle";
            txtCheckoutTitle.Size = new Size(153, 27);
            txtCheckoutTitle.TabIndex = 9;
            // 
            // txtCheckoutBookId
            // 
            txtCheckoutBookId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCheckoutBookId.Location = new Point(57, 65);
            txtCheckoutBookId.Name = "txtCheckoutBookId";
            txtCheckoutBookId.Size = new Size(167, 27);
            txtCheckoutBookId.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 265);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 7;
            label4.Text = "Activity Log";
            // 
            // lvActivityLog
            // 
            lvActivityLog.Columns.AddRange(new ColumnHeader[] { Timestamp, ActivityType, Details });
            lvActivityLog.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvActivityLog.FullRowSelect = true;
            lvActivityLog.GridLines = true;
            lvActivityLog.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvActivityLog.Location = new Point(12, 288);
            lvActivityLog.Name = "lvActivityLog";
            lvActivityLog.Size = new Size(471, 121);
            lvActivityLog.TabIndex = 6;
            lvActivityLog.UseCompatibleStateImageBehavior = false;
            lvActivityLog.View = View.Details;
            // 
            // Timestamp
            // 
            Timestamp.Text = "Timestamp";
            Timestamp.Width = 100;
            // 
            // ActivityType
            // 
            ActivityType.Text = "Activity Type";
            ActivityType.Width = 100;
            // 
            // Details
            // 
            Details.Text = "Details";
            Details.Width = 250;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(146, 32);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(78, 27);
            txtQuantity.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(24, 230);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // prgEmail
            // 
            prgEmail.Location = new Point(21, 179);
            prgEmail.Name = "prgEmail";
            prgEmail.Size = new Size(427, 29);
            prgEmail.Style = ProgressBarStyle.Continuous;
            prgEmail.TabIndex = 2;
            // 
            // btnProcessCheckout
            // 
            btnProcessCheckout.BackColor = Color.SteelBlue;
            btnProcessCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessCheckout.ForeColor = Color.White;
            btnProcessCheckout.Location = new Point(301, 33);
            btnProcessCheckout.Name = "btnProcessCheckout";
            btnProcessCheckout.Size = new Size(149, 29);
            btnProcessCheckout.TabIndex = 1;
            btnProcessCheckout.Text = "Process Checkout";
            btnProcessCheckout.UseVisualStyleBackColor = false;
            btnProcessCheckout.Click += btnProcessCheckout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 37);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 0;
            label2.Text = "Current Quantity:";
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.ColumnHeadersHeight = 30;
            dgvBooks.Columns.AddRange(new DataGridViewColumn[] { ID, Title, ISBN, Author, Status, IsReference, Year, Quantity });
            dgvBooks.Location = new Point(21, 56);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 30;
            dgvBooks.Size = new Size(1003, 231);
            dgvBooks.TabIndex = 4;
            dgvBooks.CellClick += dgvBooks_CellClick;
        
            // 
            // ID
            // 
            ID.DataPropertyName = "Id";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // ISBN
            // 
            ISBN.DataPropertyName = "Isbn";
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.Width = 125;
            // 
            // Author
            // 
            Author.DataPropertyName = "Authors";
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // IsReference
            // 
            IsReference.DataPropertyName = "IsReference";
            IsReference.HeaderText = "IsReference";
            IsReference.MinimumWidth = 6;
            IsReference.Name = "IsReference";
            IsReference.Width = 125;
            // 
            // Year
            // 
            Year.DataPropertyName = "Year";
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.ForeColor = Color.White;
            button5.Location = new Point(736, 15);
            button5.Name = "button5";
            button5.Size = new Size(129, 29);
            button5.TabIndex = 3;
            button5.Text = "Delete Selected";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnEditSelected
            // 
            btnEditSelected.BackColor = Color.SeaGreen;
            btnEditSelected.ForeColor = Color.White;
            btnEditSelected.Location = new Point(603, 15);
            btnEditSelected.Name = "btnEditSelected";
            btnEditSelected.Size = new Size(111, 29);
            btnEditSelected.TabIndex = 2;
            btnEditSelected.Text = "Edit Selected";
            btnEditSelected.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.SteelBlue;
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(477, 15);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(105, 29);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "+ Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(19, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(428, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search by title or ISBN...";
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1227, 783);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Library Management System";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDaysLate).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Button btnAddBook;
        private TextBox txtSearch;
        private Button btnEditSelected;
        private Button button5;
        private DataGridView dgvBooks;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnProcessCheckout;
        private Label label2;
        private TextBox txtQuantity;
        private Label lblStatus;
        private ProgressBar prgEmail;
        private ListView lvActivityLog;
        private Label label4;
        private ColumnHeader Timestamp;
        private ColumnHeader ActivityType;
        private ColumnHeader Details;
        private Label label5;
        private NumericUpDown numDaysLate;
        private ComboBox cmbMemberType;
        private Button btnCalculateFee;
        private Label lblFeeResult;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn IsReference;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Quantity;
        private Label label3;
        private TextBox txtCheckoutTitle;
        private TextBox txtCheckoutBookId;
        private Label label6;
    }
}
