namespace basedata_13
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.middleNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.addNewPassengerButton = new System.Windows.Forms.Button();
            this.totalBaggageWeightBox = new System.Windows.Forms.TextBox();
            this.luggagePiecesNumBox = new System.Windows.Forms.TextBox();
            this.flightNumberBox = new System.Windows.Forms.TextBox();
            this.baggageReceiptNumBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateTableButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileButton = new System.Windows.Forms.Button();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.sumWeightBox = new System.Windows.Forms.TextBox();
            this.findBaggageBox = new System.Windows.Forms.TextBox();
            this.findBaggageButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.foundedFlightBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteByLastNameButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.findLastNameBox = new System.Windows.Forms.TextBox();
            this.detectHeavyWeightButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.deleteRowTableButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.middleName,
            this.Author,
            this.Year,
            this.Publisher,
            this.Price});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.Location = new System.Drawing.Point(16, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(729, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView1_Paint);
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // middleName
            // 
            this.middleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.middleName.HeaderText = "Middle Name";
            this.middleName.Name = "middleName";
            this.middleName.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Author.HeaderText = "Flights";
            this.Author.Name = "Author";
            this.Author.Width = 62;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Year.HeaderText = "Receipt";
            this.Year.Name = "Year";
            this.Year.Width = 69;
            // 
            // Publisher
            // 
            this.Publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Publisher.HeaderText = "Luggage";
            this.Publisher.Name = "Publisher";
            this.Publisher.Width = 74;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Total Weight";
            this.Price.Name = "Price";
            this.Price.Width = 93;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "Add new book";
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.middleNameBox);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.addNewPassengerButton);
            this.groupBox1.Controls.Add(this.totalBaggageWeightBox);
            this.groupBox1.Controls.Add(this.luggagePiecesNumBox);
            this.groupBox1.Controls.Add(this.flightNumberBox);
            this.groupBox1.Controls.Add(this.baggageReceiptNumBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 328);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new passenger";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(11, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Middle Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Last Name";
            // 
            // middleNameBox
            // 
            this.middleNameBox.Location = new System.Drawing.Point(119, 72);
            this.middleNameBox.Name = "middleNameBox";
            this.middleNameBox.Size = new System.Drawing.Size(132, 20);
            this.middleNameBox.TabIndex = 13;
            this.middleNameBox.Text = "Default name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(119, 46);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(132, 20);
            this.lastNameBox.TabIndex = 12;
            this.lastNameBox.Text = "Default name";
            // 
            // addNewPassengerButton
            // 
            this.addNewPassengerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewPassengerButton.Location = new System.Drawing.Point(14, 230);
            this.addNewPassengerButton.Name = "addNewPassengerButton";
            this.addNewPassengerButton.Size = new System.Drawing.Size(237, 30);
            this.addNewPassengerButton.TabIndex = 1;
            this.addNewPassengerButton.Text = "Add";
            this.addNewPassengerButton.UseVisualStyleBackColor = true;
            this.addNewPassengerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalBaggageWeightBox
            // 
            this.totalBaggageWeightBox.Location = new System.Drawing.Point(172, 186);
            this.totalBaggageWeightBox.Name = "totalBaggageWeightBox";
            this.totalBaggageWeightBox.Size = new System.Drawing.Size(79, 20);
            this.totalBaggageWeightBox.TabIndex = 11;
            this.totalBaggageWeightBox.Text = "154";
            // 
            // luggagePiecesNumBox
            // 
            this.luggagePiecesNumBox.Location = new System.Drawing.Point(172, 160);
            this.luggagePiecesNumBox.Name = "luggagePiecesNumBox";
            this.luggagePiecesNumBox.Size = new System.Drawing.Size(79, 20);
            this.luggagePiecesNumBox.TabIndex = 10;
            this.luggagePiecesNumBox.Text = "12";
            // 
            // flightNumberBox
            // 
            this.flightNumberBox.Location = new System.Drawing.Point(172, 108);
            this.flightNumberBox.Name = "flightNumberBox";
            this.flightNumberBox.Size = new System.Drawing.Size(79, 20);
            this.flightNumberBox.TabIndex = 9;
            this.flightNumberBox.Text = "55210";
            // 
            // baggageReceiptNumBox
            // 
            this.baggageReceiptNumBox.Location = new System.Drawing.Point(172, 134);
            this.baggageReceiptNumBox.Name = "baggageReceiptNumBox";
            this.baggageReceiptNumBox.Size = new System.Drawing.Size(79, 20);
            this.baggageReceiptNumBox.TabIndex = 8;
            this.baggageReceiptNumBox.Text = "22110";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Baggage Weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Luggage Pieces Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baggage receipt number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Flight Number";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(119, 20);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(132, 20);
            this.firstNameBox.TabIndex = 1;
            this.firstNameBox.Text = "Default name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteRowTableButton);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.updateTableButton);
            this.groupBox2.Location = new System.Drawing.Point(286, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 328);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Passengers list";
            // 
            // updateTableButton
            // 
            this.updateTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateTableButton.Location = new System.Drawing.Point(481, 282);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(107, 30);
            this.updateTableButton.TabIndex = 14;
            this.updateTableButton.Text = "Update";
            this.updateTableButton.UseVisualStyleBackColor = true;
            this.updateTableButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 595);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.Location = new System.Drawing.Point(819, 569);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(107, 28);
            this.openFileButton.TabIndex = 15;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveFileButton.Location = new System.Drawing.Point(941, 569);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(107, 28);
            this.saveFileButton.TabIndex = 16;
            this.saveFileButton.Text = "Save";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(792, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sum Weight of baggage:";
            // 
            // sumWeightBox
            // 
            this.sumWeightBox.Location = new System.Drawing.Point(978, 478);
            this.sumWeightBox.Name = "sumWeightBox";
            this.sumWeightBox.Size = new System.Drawing.Size(53, 20);
            this.sumWeightBox.TabIndex = 12;
            this.sumWeightBox.Text = "0";
            this.sumWeightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // findBaggageBox
            // 
            this.findBaggageBox.Location = new System.Drawing.Point(6, 47);
            this.findBaggageBox.Name = "findBaggageBox";
            this.findBaggageBox.Size = new System.Drawing.Size(157, 20);
            this.findBaggageBox.TabIndex = 18;
            this.findBaggageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // findBaggageButton
            // 
            this.findBaggageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBaggageButton.Location = new System.Drawing.Point(169, 40);
            this.findBaggageButton.Name = "findBaggageButton";
            this.findBaggageButton.Size = new System.Drawing.Size(76, 27);
            this.findBaggageButton.TabIndex = 19;
            this.findBaggageButton.Text = "Find ->";
            this.findBaggageButton.UseVisualStyleBackColor = true;
            this.findBaggageButton.Click += new System.EventHandler(this.findBaggageButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Baggage receipt number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.foundedFlightBox);
            this.groupBox3.Controls.Add(this.findBaggageBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.findBaggageButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 94);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Find baggage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(281, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Flight Number";
            // 
            // foundedFlightBox
            // 
            this.foundedFlightBox.Location = new System.Drawing.Point(251, 47);
            this.foundedFlightBox.Name = "foundedFlightBox";
            this.foundedFlightBox.Size = new System.Drawing.Size(157, 20);
            this.foundedFlightBox.TabIndex = 21;
            this.foundedFlightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteByLastNameButton);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.findLastNameBox);
            this.groupBox4.Location = new System.Drawing.Point(12, 458);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 65);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete passanger info by Last Name";
            // 
            // deleteByLastNameButton
            // 
            this.deleteByLastNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteByLastNameButton.Location = new System.Drawing.Point(284, 20);
            this.deleteByLastNameButton.Name = "deleteByLastNameButton";
            this.deleteByLastNameButton.Size = new System.Drawing.Size(124, 30);
            this.deleteByLastNameButton.TabIndex = 22;
            this.deleteByLastNameButton.Text = "Delete";
            this.deleteByLastNameButton.UseVisualStyleBackColor = true;
            this.deleteByLastNameButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Last name";
            // 
            // findLastNameBox
            // 
            this.findLastNameBox.Location = new System.Drawing.Point(85, 27);
            this.findLastNameBox.Name = "findLastNameBox";
            this.findLastNameBox.Size = new System.Drawing.Size(193, 20);
            this.findLastNameBox.TabIndex = 22;
            // 
            // detectHeavyWeightButton
            // 
            this.detectHeavyWeightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.detectHeavyWeightButton.Location = new System.Drawing.Point(77, 56);
            this.detectHeavyWeightButton.Name = "detectHeavyWeightButton";
            this.detectHeavyWeightButton.Size = new System.Drawing.Size(125, 28);
            this.detectHeavyWeightButton.TabIndex = 23;
            this.detectHeavyWeightButton.Text = "Detect";
            this.detectHeavyWeightButton.UseVisualStyleBackColor = true;
            this.detectHeavyWeightButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.detectHeavyWeightButton);
            this.groupBox5.Location = new System.Drawing.Point(435, 358);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(290, 104);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Heavyweight detector";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(262, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "Passengers with more than 30 kg baggage";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // deleteRowTableButton
            // 
            this.deleteRowTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRowTableButton.Location = new System.Drawing.Point(594, 282);
            this.deleteRowTableButton.Name = "deleteRowTableButton";
            this.deleteRowTableButton.Size = new System.Drawing.Size(124, 30);
            this.deleteRowTableButton.TabIndex = 23;
            this.deleteRowTableButton.Text = "Delete row";
            this.deleteRowTableButton.UseVisualStyleBackColor = true;
            this.deleteRowTableButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
            this.contextMenuStrip1.Text = "File";
            this.contextMenuStrip1.Click += new System.EventHandler(this.button3_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 617);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.sumWeightBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Airport database";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addNewPassengerButton;
        private System.Windows.Forms.TextBox totalBaggageWeightBox;
        private System.Windows.Forms.TextBox luggagePiecesNumBox;
        private System.Windows.Forms.TextBox flightNumberBox;
        private System.Windows.Forms.TextBox baggageReceiptNumBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateTableButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sumWeightBox;
        private System.Windows.Forms.TextBox findBaggageBox;
        private System.Windows.Forms.Button findBaggageButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox foundedFlightBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteByLastNameButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox findLastNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox middleNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button detectHeavyWeightButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button deleteRowTableButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

