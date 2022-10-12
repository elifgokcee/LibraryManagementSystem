using System.Windows.Forms;

namespace LibraryManagementSystem.FormsUI
{
    partial class Home
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwBookList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.authorsComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearFilterButtıon = new System.Windows.Forms.Button();
            this.bookNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pymin = new System.Windows.Forms.ComboBox();
            this.pymax = new System.Windows.Forms.ComboBox();
            this.yearFilterButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.addNewBookButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reserveButton = new System.Windows.Forms.Button();
            this.nonRezerveButton = new System.Windows.Forms.Button();
            this.getAllBooks = new System.Windows.Forms.Button();
            this.dgwBookReservation = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.publisherLabel = new System.Windows.Forms.Label();
            this.publisherComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.searchReserveLabel = new System.Windows.Forms.Label();
            this.reserveSearchButton = new System.Windows.Forms.TextBox();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.getNonReservedBooks = new System.Windows.Forms.Button();
            this.addNewItemBox = new System.Windows.Forms.GroupBox();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.manageBookBox = new System.Windows.Forms.GroupBox();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.getMembersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.addNewItemBox.SuspendLayout();
            this.manageBookBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBookList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgwBookList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwBookList.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgwBookList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBookList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwBookList.EnableHeadersVisualStyles = false;
            this.dgwBookList.GridColor = System.Drawing.Color.Wheat;
            this.dgwBookList.Location = new System.Drawing.Point(21, 168);
            this.dgwBookList.MultiSelect = false;
            this.dgwBookList.Name = "dgwBookList";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwBookList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgwBookList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwBookList.RowTemplate.Height = 24;
            this.dgwBookList.Size = new System.Drawing.Size(702, 291);
            this.dgwBookList.TabIndex = 0;
            this.dgwBookList.DataSourceChanged += new System.EventHandler(this.dgwBookList_DataSourceChange);
            this.dgwBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookList_cellclick);
            this.dgwBookList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book name";
            // 
            // authorsComboBox
            // 
            this.authorsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authorsComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.authorsComboBox.FormattingEnabled = true;
            this.authorsComboBox.Location = new System.Drawing.Point(12, 121);
            this.authorsComboBox.Name = "authorsComboBox";
            this.authorsComboBox.Size = new System.Drawing.Size(211, 24);
            this.authorsComboBox.TabIndex = 3;
            // 
            // categoryBox
            // 
            this.categoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(283, 54);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(211, 24);
            this.categoryBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Authors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(279, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(9, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Publish year";
            // 
            // clearFilterButtıon
            // 
            this.clearFilterButtıon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clearFilterButtıon.FlatAppearance.BorderSize = 0;
            this.clearFilterButtıon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearFilterButtıon.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearFilterButtıon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clearFilterButtıon.Location = new System.Drawing.Point(283, 233);
            this.clearFilterButtıon.Name = "clearFilterButtıon";
            this.clearFilterButtıon.Size = new System.Drawing.Size(211, 32);
            this.clearFilterButtıon.TabIndex = 10;
            this.clearFilterButtıon.Text = "Clear filter";
            this.clearFilterButtıon.UseVisualStyleBackColor = false;
            this.clearFilterButtıon.Click += new System.EventHandler(this.clearFilterButtıon_Click);
            // 
            // bookNameBox
            // 
            this.bookNameBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bookNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookNameBox.Location = new System.Drawing.Point(12, 58);
            this.bookNameBox.Multiline = true;
            this.bookNameBox.Name = "bookNameBox";
            this.bookNameBox.Size = new System.Drawing.Size(211, 22);
            this.bookNameBox.TabIndex = 11;
            this.bookNameBox.TextChanged += new System.EventHandler(this.bookNameBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "-";
            // 
            // pymin
            // 
            this.pymin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pymin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pymin.FormattingEnabled = true;
            this.pymin.Location = new System.Drawing.Point(9, 193);
            this.pymin.Name = "pymin";
            this.pymin.Size = new System.Drawing.Size(84, 24);
            this.pymin.TabIndex = 15;
            // 
            // pymax
            // 
            this.pymax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pymax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pymax.FormattingEnabled = true;
            this.pymax.Location = new System.Drawing.Point(142, 193);
            this.pymax.Name = "pymax";
            this.pymax.Size = new System.Drawing.Size(81, 24);
            this.pymax.TabIndex = 16;
            // 
            // yearFilterButton
            // 
            this.yearFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.yearFilterButton.FlatAppearance.BorderSize = 0;
            this.yearFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yearFilterButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearFilterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yearFilterButton.Location = new System.Drawing.Point(9, 233);
            this.yearFilterButton.Name = "yearFilterButton";
            this.yearFilterButton.Size = new System.Drawing.Size(211, 32);
            this.yearFilterButton.TabIndex = 17;
            this.yearFilterButton.Text = "Filter books";
            this.yearFilterButton.UseVisualStyleBackColor = false;
            this.yearFilterButton.Click += new System.EventHandler(this.yearFilterButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutButton.Image = ((System.Drawing.Image)(resources.GetObject("logoutButton.Image")));
            this.logoutButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.logoutButton.Location = new System.Drawing.Point(1094, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(180, 45);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // addNewBookButton
            // 
            this.addNewBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addNewBookButton.FlatAppearance.BorderSize = 0;
            this.addNewBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewBookButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNewBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addNewBookButton.Location = new System.Drawing.Point(169, 12);
            this.addNewBookButton.Name = "addNewBookButton";
            this.addNewBookButton.Size = new System.Drawing.Size(155, 40);
            this.addNewBookButton.TabIndex = 19;
            this.addNewBookButton.Text = "Add New Book";
            this.addNewBookButton.UseVisualStyleBackColor = false;
            this.addNewBookButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(30, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 39);
            this.button2.TabIndex = 20;
            this.button2.Text = "Active Book Reservations";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // languageBox
            // 
            this.languageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Location = new System.Drawing.Point(283, 121);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(211, 24);
            this.languageBox.TabIndex = 21;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.languageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.languageLabel.Location = new System.Drawing.Point(279, 92);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(78, 23);
            this.languageLabel.TabIndex = 22;
            this.languageLabel.Text = "Languages";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Location = new System.Drawing.Point(8, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 40);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete book";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.reserveButton.FlatAppearance.BorderSize = 0;
            this.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reserveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reserveButton.Location = new System.Drawing.Point(8, 57);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(155, 40);
            this.reserveButton.TabIndex = 24;
            this.reserveButton.Text = "Make Rezerve";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.rezerveButton_Click);
            // 
            // nonRezerveButton
            // 
            this.nonRezerveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nonRezerveButton.Enabled = false;
            this.nonRezerveButton.FlatAppearance.BorderSize = 0;
            this.nonRezerveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nonRezerveButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonRezerveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nonRezerveButton.Location = new System.Drawing.Point(30, 163);
            this.nonRezerveButton.Name = "nonRezerveButton";
            this.nonRezerveButton.Size = new System.Drawing.Size(211, 35);
            this.nonRezerveButton.TabIndex = 25;
            this.nonRezerveButton.Text = "Delete Reservation";
            this.nonRezerveButton.UseVisualStyleBackColor = false;
            this.nonRezerveButton.Click += new System.EventHandler(this.nonRezerveButton_Click);
            // 
            // getAllBooks
            // 
            this.getAllBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.getAllBooks.FlatAppearance.BorderSize = 0;
            this.getAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getAllBooks.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getAllBooks.Location = new System.Drawing.Point(169, 57);
            this.getAllBooks.Name = "getAllBooks";
            this.getAllBooks.Size = new System.Drawing.Size(155, 40);
            this.getAllBooks.TabIndex = 26;
            this.getAllBooks.Text = "Get All Books";
            this.getAllBooks.UseVisualStyleBackColor = false;
            this.getAllBooks.Click += new System.EventHandler(this.getAllBooks_Click);
            // 
            // dgwBookReservation
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgwBookReservation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwBookReservation.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgwBookReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwBookReservation.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBookReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgwBookReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwBookReservation.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgwBookReservation.EnableHeadersVisualStyles = false;
            this.dgwBookReservation.GridColor = System.Drawing.Color.Wheat;
            this.dgwBookReservation.Location = new System.Drawing.Point(21, 480);
            this.dgwBookReservation.MultiSelect = false;
            this.dgwBookReservation.Name = "dgwBookReservation";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwBookReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgwBookReservation.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgwBookReservation.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgwBookReservation.RowTemplate.Height = 24;
            this.dgwBookReservation.Size = new System.Drawing.Size(702, 291);
            this.dgwBookReservation.TabIndex = 0;
            this.dgwBookReservation.DataSourceChanged += new System.EventHandler(this.dgwReserveList_DataSourceChange);
            this.dgwBookReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookReservation_CellClick);
            this.dgwBookReservation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBookReservation_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.publisherLabel);
            this.groupBox1.Controls.Add(this.publisherComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bookNameBox);
            this.groupBox1.Controls.Add(this.authorsComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.categoryBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.languageBox);
            this.groupBox1.Controls.Add(this.languageLabel);
            this.groupBox1.Controls.Add(this.pymin);
            this.groupBox1.Controls.Add(this.clearFilterButtıon);
            this.groupBox1.Controls.Add(this.yearFilterButton);
            this.groupBox1.Controls.Add(this.pymax);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(746, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 279);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox1_Paint);
            // 
            // publisherLabel
            // 
            this.publisherLabel.AutoSize = true;
            this.publisherLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.publisherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.publisherLabel.Location = new System.Drawing.Point(279, 161);
            this.publisherLabel.Name = "publisherLabel";
            this.publisherLabel.Size = new System.Drawing.Size(77, 23);
            this.publisherLabel.TabIndex = 24;
            this.publisherLabel.Text = "Publishers";
            // 
            // publisherComboBox
            // 
            this.publisherComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publisherComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.publisherComboBox.FormattingEnabled = true;
            this.publisherComboBox.Location = new System.Drawing.Point(283, 187);
            this.publisherComboBox.Name = "publisherComboBox";
            this.publisherComboBox.Size = new System.Drawing.Size(211, 24);
            this.publisherComboBox.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.searchReserveLabel);
            this.groupBox2.Controls.Add(this.reserveSearchButton);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.nonRezerveButton);
            this.groupBox2.Location = new System.Drawing.Point(746, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 279);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox2_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(31, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 37);
            this.button3.TabIndex = 32;
            this.button3.Text = "Get All Reservations";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // searchReserveLabel
            // 
            this.searchReserveLabel.AutoSize = true;
            this.searchReserveLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchReserveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchReserveLabel.Location = new System.Drawing.Point(27, 31);
            this.searchReserveLabel.Name = "searchReserveLabel";
            this.searchReserveLabel.Size = new System.Drawing.Size(117, 23);
            this.searchReserveLabel.TabIndex = 31;
            this.searchReserveLabel.Text = "Reserve number";
            // 
            // reserveSearchButton
            // 
            this.reserveSearchButton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reserveSearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reserveSearchButton.Location = new System.Drawing.Point(30, 65);
            this.reserveSearchButton.Multiline = true;
            this.reserveSearchButton.Name = "reserveSearchButton";
            this.reserveSearchButton.Size = new System.Drawing.Size(211, 22);
            this.reserveSearchButton.TabIndex = 30;
            this.reserveSearchButton.TextChanged += new System.EventHandler(this.reserveSearchButton_TextChanged);
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addPublisherButton.FlatAppearance.BorderSize = 0;
            this.addPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPublisherButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPublisherButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPublisherButton.Location = new System.Drawing.Point(169, 57);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(155, 40);
            this.addPublisherButton.TabIndex = 30;
            this.addPublisherButton.Text = "Add Publisher";
            this.addPublisherButton.UseVisualStyleBackColor = false;
            this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addLanguageButton.FlatAppearance.BorderSize = 0;
            this.addLanguageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLanguageButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addLanguageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addLanguageButton.Location = new System.Drawing.Point(8, 57);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(155, 40);
            this.addLanguageButton.TabIndex = 31;
            this.addLanguageButton.Text = "Add Language";
            this.addLanguageButton.UseVisualStyleBackColor = false;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addAuthorButton.FlatAppearance.BorderSize = 0;
            this.addAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthorButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAuthorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addAuthorButton.Location = new System.Drawing.Point(169, 12);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(155, 40);
            this.addAuthorButton.TabIndex = 32;
            this.addAuthorButton.Text = "Add Author";
            this.addAuthorButton.UseVisualStyleBackColor = false;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // getNonReservedBooks
            // 
            this.getNonReservedBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.getNonReservedBooks.FlatAppearance.BorderSize = 0;
            this.getNonReservedBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getNonReservedBooks.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getNonReservedBooks.Location = new System.Drawing.Point(8, 12);
            this.getNonReservedBooks.Name = "getNonReservedBooks";
            this.getNonReservedBooks.Size = new System.Drawing.Size(155, 40);
            this.getNonReservedBooks.TabIndex = 33;
            this.getNonReservedBooks.Text = "Get Books";
            this.getNonReservedBooks.UseVisualStyleBackColor = false;
            this.getNonReservedBooks.Click += new System.EventHandler(this.getNonReservedBooks_Click);
            // 
            // addNewItemBox
            // 
            this.addNewItemBox.Controls.Add(this.deleteUserButton);
            this.addNewItemBox.Controls.Add(this.addUserButton);
            this.addNewItemBox.Controls.Add(this.addPublisherButton);
            this.addNewItemBox.Controls.Add(this.deleteButton);
            this.addNewItemBox.Controls.Add(this.addAuthorButton);
            this.addNewItemBox.Controls.Add(this.addLanguageButton);
            this.addNewItemBox.Location = new System.Drawing.Point(21, 12);
            this.addNewItemBox.Name = "addNewItemBox";
            this.addNewItemBox.Padding = new System.Windows.Forms.Padding(1);
            this.addNewItemBox.Size = new System.Drawing.Size(330, 150);
            this.addNewItemBox.TabIndex = 35;
            this.addNewItemBox.TabStop = false;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteUserButton.FlatAppearance.BorderSize = 0;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteUserButton.Location = new System.Drawing.Point(169, 102);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(155, 40);
            this.deleteUserButton.TabIndex = 38;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUserButton.Location = new System.Drawing.Point(8, 102);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(155, 40);
            this.addUserButton.TabIndex = 37;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // manageBookBox
            // 
            this.manageBookBox.Controls.Add(this.deleteMemberButton);
            this.manageBookBox.Controls.Add(this.getNonReservedBooks);
            this.manageBookBox.Controls.Add(this.addMemberButton);
            this.manageBookBox.Controls.Add(this.getAllBooks);
            this.manageBookBox.Controls.Add(this.reserveButton);
            this.manageBookBox.Controls.Add(this.addNewBookButton);
            this.manageBookBox.Location = new System.Drawing.Point(373, 12);
            this.manageBookBox.Name = "manageBookBox";
            this.manageBookBox.Padding = new System.Windows.Forms.Padding(1);
            this.manageBookBox.Size = new System.Drawing.Size(330, 150);
            this.manageBookBox.TabIndex = 36;
            this.manageBookBox.TabStop = false;
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deleteMemberButton.FlatAppearance.BorderSize = 0;
            this.deleteMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteMemberButton.Location = new System.Drawing.Point(169, 102);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(155, 40);
            this.deleteMemberButton.TabIndex = 30;
            this.deleteMemberButton.Text = "Delete Member";
            this.deleteMemberButton.UseVisualStyleBackColor = false;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addMemberButton.FlatAppearance.BorderSize = 0;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addMemberButton.Location = new System.Drawing.Point(8, 102);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(155, 40);
            this.addMemberButton.TabIndex = 31;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // getMembersButton
            // 
            this.getMembersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.getMembersButton.FlatAppearance.BorderSize = 0;
            this.getMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getMembersButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.getMembersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.getMembersButton.Location = new System.Drawing.Point(746, 114);
            this.getMembersButton.Name = "getMembersButton";
            this.getMembersButton.Size = new System.Drawing.Size(155, 40);
            this.getMembersButton.TabIndex = 37;
            this.getMembersButton.Text = "Get Members";
            this.getMembersButton.UseVisualStyleBackColor = false;
            this.getMembersButton.Click += new System.EventHandler(this.getMembersButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1367, 807);
            this.Controls.Add(this.getMembersButton);
            this.Controls.Add(this.manageBookBox);
            this.Controls.Add(this.addNewItemBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwBookReservation);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.dgwBookList);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBookReservation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.addNewItemBox.ResumeLayout(false);
            this.manageBookBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBookList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox authorsComboBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearFilterButtıon;
        private System.Windows.Forms.TextBox bookNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox pymin;
        private System.Windows.Forms.ComboBox pymax;
        private System.Windows.Forms.Button yearFilterButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button addNewBookButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.Button nonRezerveButton;
        private System.Windows.Forms.Button getAllBooks;
        private DataGridView dgwBookReservation;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label searchReserveLabel;
        private TextBox reserveSearchButton;
        private Button addPublisherButton;
        private Button addLanguageButton;
        private Button addAuthorButton;
        private Label publisherLabel;
        private ComboBox publisherComboBox;
        private Button getNonReservedBooks;
        private Button button3;
        private GroupBox addNewItemBox;
        private GroupBox manageBookBox;
        private Button deleteUserButton;
        private Button addUserButton;
        private Button deleteMemberButton;
        private Button addMemberButton;
        private Button getMembersButton;
    }
}