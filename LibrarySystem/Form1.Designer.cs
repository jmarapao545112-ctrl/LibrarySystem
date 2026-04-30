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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1204, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 7);
            label1.Name = "label1";
            label1.Size = new Size(267, 25);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CadetBlue;
            pictureBox1.Image = Properties.Resources._751623_200;
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 21);
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
            panel2.Location = new Point(0, 38);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 543);
            panel2.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 117);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(9, 0, 0, 0);
            button4.Size = new Size(158, 33);
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
            button3.Location = new Point(0, 80);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(9, 0, 0, 0);
            button3.Size = new Size(158, 33);
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
            button2.Location = new Point(0, 42);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(9, 0, 0, 0);
            button2.Size = new Size(158, 33);
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
            button1.Location = new Point(0, 4);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(9, 0, 0, 0);
            button1.Size = new Size(158, 33);
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
            panel3.Location = new Point(158, 38);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1046, 543);
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
            groupBox2.Location = new Point(550, 272);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(18, 15, 18, 15);
            groupBox2.Size = new Size(471, 262);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "LATE FEE CALCULATOR";
            // 
            // lblFeeResult
            // 
            lblFeeResult.BorderStyle = BorderStyle.FixedSingle;
            lblFeeResult.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFeeResult.Location = new Point(20, 134);
            lblFeeResult.Name = "lblFeeResult";
            lblFeeResult.Size = new Size(156, 19);
            lblFeeResult.TabIndex = 4;
            lblFeeResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalculateFee
            // 
            btnCalculateFee.BackColor = Color.SteelBlue;
            btnCalculateFee.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalculateFee.ForeColor = Color.White;
            btnCalculateFee.Location = new Point(247, 81);
            btnCalculateFee.Margin = new Padding(3, 2, 3, 2);
            btnCalculateFee.Name = "btnCalculateFee";
            btnCalculateFee.Size = new Size(98, 22);
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
            cmbMemberType.Location = new Point(247, 38);
            cmbMemberType.Margin = new Padding(3, 2, 3, 2);
            cmbMemberType.Name = "cmbMemberType";
            cmbMemberType.Size = new Size(157, 23);
            cmbMemberType.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 42);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 1;
            label5.Text = "Days Late:";
            // 
            // numDaysLate
            // 
            numDaysLate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numDaysLate.Location = new Point(91, 40);
            numDaysLate.Margin = new Padding(3, 2, 3, 2);
            numDaysLate.Name = "numDaysLate";
            numDaysLate.Size = new Size(85, 23);
            numDaysLate.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lvActivityLog);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(prgEmail);
            groupBox1.Controls.Add(btnProcessCheckout);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 272);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(18, 15, 18, 15);
            groupBox1.Size = new Size(509, 262);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "BOOK CHECKOUT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 134);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
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
            lvActivityLog.Location = new Point(21, 158);
            lvActivityLog.Margin = new Padding(3, 2, 3, 2);
            lvActivityLog.Name = "lvActivityLog";
            lvActivityLog.Size = new Size(374, 92);
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
            txtQuantity.Location = new Point(128, 24);
            txtQuantity.Margin = new Padding(3, 2, 3, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(69, 23);
            txtQuantity.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(20, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status";
            // 
            // prgEmail
            // 
            prgEmail.Location = new Point(20, 62);
            prgEmail.Margin = new Padding(3, 2, 3, 2);
            prgEmail.Name = "prgEmail";
            prgEmail.Size = new Size(374, 22);
            prgEmail.Style = ProgressBarStyle.Continuous;
            prgEmail.TabIndex = 2;
            // 
            // btnProcessCheckout
            // 
            btnProcessCheckout.BackColor = Color.SteelBlue;
            btnProcessCheckout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProcessCheckout.ForeColor = Color.White;
            btnProcessCheckout.Location = new Point(263, 25);
            btnProcessCheckout.Margin = new Padding(3, 2, 3, 2);
            btnProcessCheckout.Name = "btnProcessCheckout";
            btnProcessCheckout.Size = new Size(130, 22);
            btnProcessCheckout.TabIndex = 1;
            btnProcessCheckout.Text = "Process Checkout";
            btnProcessCheckout.UseVisualStyleBackColor = false;
            btnProcessCheckout.Click += btnProcessCheckout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
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
            dgvBooks.Location = new Point(18, 42);
            dgvBooks.Margin = new Padding(3, 2, 3, 2);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 30;
            dgvBooks.Size = new Size(1003, 211);
            dgvBooks.TabIndex = 4;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 125;
            // 
            // ISBN
            // 
            ISBN.HeaderText = "ISBN";
            ISBN.MinimumWidth = 6;
            ISBN.Name = "ISBN";
            ISBN.Width = 125;
            // 
            // Author
            // 
            Author.HeaderText = "Author";
            Author.MinimumWidth = 6;
            Author.Name = "Author";
            Author.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 125;
            // 
            // IsReference
            // 
            IsReference.HeaderText = "IsReference";
            IsReference.MinimumWidth = 6;
            IsReference.Name = "IsReference";
            IsReference.Width = 125;
            // 
            // Year
            // 
            Year.HeaderText = "Year";
            Year.MinimumWidth = 6;
            Year.Name = "Year";
            Year.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.ForeColor = Color.White;
            button5.Location = new Point(644, 11);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(113, 22);
            button5.TabIndex = 3;
            button5.Text = "Delete Selected";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnEditSelected
            // 
            btnEditSelected.BackColor = Color.SeaGreen;
            btnEditSelected.ForeColor = Color.White;
            btnEditSelected.Location = new Point(528, 11);
            btnEditSelected.Margin = new Padding(3, 2, 3, 2);
            btnEditSelected.Name = "btnEditSelected";
            btnEditSelected.Size = new Size(97, 22);
            btnEditSelected.TabIndex = 2;
            btnEditSelected.Text = "Edit Selected";
            btnEditSelected.UseVisualStyleBackColor = false;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.SteelBlue;
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(417, 11);
            btnAddBook.Margin = new Padding(3, 2, 3, 2);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(92, 22);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "+ Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 11);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(375, 23);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search by title or ISBN...";
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1204, 581);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn ISBN;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn IsReference;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Quantity;
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
    }
}
