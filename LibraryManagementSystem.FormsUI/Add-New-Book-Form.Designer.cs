namespace LibraryManagementSystem.FormsUI
{
    partial class Add_New_Book_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_New_Book_Form));
            this.AddBookForm = new System.Windows.Forms.GroupBox();
            this.publicationYearBox = new System.Windows.Forms.TextBox();
            this.addBookLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addBookPublisherComboBox = new System.Windows.Forms.ComboBox();
            this.addBookPublicationYearLabel = new System.Windows.Forms.Label();
            this.addBookCategoryLabel = new System.Windows.Forms.Label();
            this.addBookCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addBookAuthorComboBox = new System.Windows.Forms.ComboBox();
            this.addBookTitleBox = new System.Windows.Forms.TextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.AddBookForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBookForm
            // 
            this.AddBookForm.BackColor = System.Drawing.Color.Tan;
            this.AddBookForm.Controls.Add(this.publicationYearBox);
            this.AddBookForm.Controls.Add(this.addBookLanguageComboBox);
            this.AddBookForm.Controls.Add(this.label2);
            this.AddBookForm.Controls.Add(this.addBookButton);
            this.AddBookForm.Controls.Add(this.label1);
            this.AddBookForm.Controls.Add(this.addBookPublisherComboBox);
            this.AddBookForm.Controls.Add(this.addBookPublicationYearLabel);
            this.AddBookForm.Controls.Add(this.addBookCategoryLabel);
            this.AddBookForm.Controls.Add(this.addBookCategoryComboBox);
            this.AddBookForm.Controls.Add(this.addBookAuthorComboBox);
            this.AddBookForm.Controls.Add(this.addBookTitleBox);
            this.AddBookForm.Controls.Add(this.authorLabel);
            this.AddBookForm.Controls.Add(this.bookNameLabel);
            this.AddBookForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddBookForm.Location = new System.Drawing.Point(80, 44);
            this.AddBookForm.Name = "AddBookForm";
            this.AddBookForm.Size = new System.Drawing.Size(777, 415);
            this.AddBookForm.TabIndex = 0;
            this.AddBookForm.TabStop = false;
            // 
            // publicationYearBox
            // 
            this.publicationYearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.publicationYearBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.publicationYearBox.Location = new System.Drawing.Point(414, 220);
            this.publicationYearBox.Multiline = true;
            this.publicationYearBox.Name = "publicationYearBox";
            this.publicationYearBox.Size = new System.Drawing.Size(226, 22);
            this.publicationYearBox.TabIndex = 13;
            this.publicationYearBox.TextChanged += new System.EventHandler(this.publicationYearBox_TextChanged);
            // 
            // addBookLanguageComboBox
            // 
            this.addBookLanguageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookLanguageComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addBookLanguageComboBox.FormattingEnabled = true;
            this.addBookLanguageComboBox.Location = new System.Drawing.Point(414, 148);
            this.addBookLanguageComboBox.Name = "addBookLanguageComboBox";
            this.addBookLanguageComboBox.Size = new System.Drawing.Size(226, 24);
            this.addBookLanguageComboBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(411, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Language";
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addBookButton.FlatAppearance.BorderSize = 0;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBookButton.Location = new System.Drawing.Point(414, 312);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(226, 40);
            this.addBookButton.TabIndex = 10;
            this.addBookButton.Text = "Add";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(411, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Publisher";
            // 
            // addBookPublisherComboBox
            // 
            this.addBookPublisherComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookPublisherComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addBookPublisherComboBox.FormattingEnabled = true;
            this.addBookPublisherComboBox.Location = new System.Drawing.Point(414, 76);
            this.addBookPublisherComboBox.Name = "addBookPublisherComboBox";
            this.addBookPublisherComboBox.Size = new System.Drawing.Size(226, 24);
            this.addBookPublisherComboBox.TabIndex = 8;
            // 
            // addBookPublicationYearLabel
            // 
            this.addBookPublicationYearLabel.AutoSize = true;
            this.addBookPublicationYearLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBookPublicationYearLabel.Location = new System.Drawing.Point(411, 187);
            this.addBookPublicationYearLabel.Name = "addBookPublicationYearLabel";
            this.addBookPublicationYearLabel.Size = new System.Drawing.Size(119, 23);
            this.addBookPublicationYearLabel.TabIndex = 6;
            this.addBookPublicationYearLabel.Text = "Publication year";
            // 
            // addBookCategoryLabel
            // 
            this.addBookCategoryLabel.AutoSize = true;
            this.addBookCategoryLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBookCategoryLabel.Location = new System.Drawing.Point(41, 187);
            this.addBookCategoryLabel.Name = "addBookCategoryLabel";
            this.addBookCategoryLabel.Size = new System.Drawing.Size(69, 23);
            this.addBookCategoryLabel.TabIndex = 5;
            this.addBookCategoryLabel.Text = "Category";
            // 
            // addBookCategoryComboBox
            // 
            this.addBookCategoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBookCategoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addBookCategoryComboBox.FormattingEnabled = true;
            this.addBookCategoryComboBox.Location = new System.Drawing.Point(44, 218);
            this.addBookCategoryComboBox.Name = "addBookCategoryComboBox";
            this.addBookCategoryComboBox.Size = new System.Drawing.Size(226, 24);
            this.addBookCategoryComboBox.TabIndex = 4;
            // 
            // addBookAuthorComboBox
            // 
            this.addBookAuthorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addBookAuthorComboBox.FormattingEnabled = true;
            this.addBookAuthorComboBox.Location = new System.Drawing.Point(44, 148);
            this.addBookAuthorComboBox.Name = "addBookAuthorComboBox";
            this.addBookAuthorComboBox.Size = new System.Drawing.Size(226, 24);
            this.addBookAuthorComboBox.TabIndex = 3;
            // 
            // addBookTitleBox
            // 
            this.addBookTitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addBookTitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addBookTitleBox.Location = new System.Drawing.Point(44, 78);
            this.addBookTitleBox.Multiline = true;
            this.addBookTitleBox.Name = "addBookTitleBox";
            this.addBookTitleBox.Size = new System.Drawing.Size(226, 22);
            this.addBookTitleBox.TabIndex = 2;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.authorLabel.Location = new System.Drawing.Point(41, 115);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(61, 23);
            this.authorLabel.TabIndex = 1;
            this.authorLabel.Text = "Author ";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookNameLabel.Location = new System.Drawing.Point(41, 47);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(40, 23);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "Title";
            // 
            // Add_New_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(976, 576);
            this.Controls.Add(this.AddBookForm);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_New_Book_Form";
            this.Text = "Add New Book";
            this.Load += new System.EventHandler(this.Add_New_Book_Form_Load);
            this.AddBookForm.ResumeLayout(false);
            this.AddBookForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddBookForm;
        private System.Windows.Forms.ComboBox addBookLanguageComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox addBookPublisherComboBox;
        private System.Windows.Forms.Label addBookPublicationYearLabel;
        private System.Windows.Forms.Label addBookCategoryLabel;
        private System.Windows.Forms.ComboBox addBookCategoryComboBox;
        private System.Windows.Forms.ComboBox addBookAuthorComboBox;
        private System.Windows.Forms.TextBox addBookTitleBox;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.TextBox publicationYearBox;
    }
}