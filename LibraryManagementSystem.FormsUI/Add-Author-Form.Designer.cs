namespace LibraryManagementSystem.FormsUI
{
    partial class Add_Author_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Author_Form));
            this.addLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.addPublisherSurNameLabel = new System.Windows.Forms.Label();
            this.addAuthorSurNameBox = new System.Windows.Forms.TextBox();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.addAuthorLabel = new System.Windows.Forms.Label();
            this.addAuthorNameBox = new System.Windows.Forms.TextBox();
            this.addLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLanguageGroupBox
            // 
            this.addLanguageGroupBox.BackColor = System.Drawing.Color.Tan;
            this.addLanguageGroupBox.Controls.Add(this.addPublisherSurNameLabel);
            this.addLanguageGroupBox.Controls.Add(this.addAuthorSurNameBox);
            this.addLanguageGroupBox.Controls.Add(this.addAuthorButton);
            this.addLanguageGroupBox.Controls.Add(this.addAuthorLabel);
            this.addLanguageGroupBox.Controls.Add(this.addAuthorNameBox);
            this.addLanguageGroupBox.Location = new System.Drawing.Point(133, 57);
            this.addLanguageGroupBox.Name = "addLanguageGroupBox";
            this.addLanguageGroupBox.Size = new System.Drawing.Size(355, 427);
            this.addLanguageGroupBox.TabIndex = 2;
            this.addLanguageGroupBox.TabStop = false;
            // 
            // addPublisherSurNameLabel
            // 
            this.addPublisherSurNameLabel.AutoSize = true;
            this.addPublisherSurNameLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPublisherSurNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPublisherSurNameLabel.Location = new System.Drawing.Point(81, 175);
            this.addPublisherSurNameLabel.Name = "addPublisherSurNameLabel";
            this.addPublisherSurNameLabel.Size = new System.Drawing.Size(119, 23);
            this.addPublisherSurNameLabel.TabIndex = 4;
            this.addPublisherSurNameLabel.Text = "Author surname";
            // 
            // addAuthorSurNameBox
            // 
            this.addAuthorSurNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addAuthorSurNameBox.Location = new System.Drawing.Point(71, 215);
            this.addAuthorSurNameBox.Multiline = true;
            this.addAuthorSurNameBox.Name = "addAuthorSurNameBox";
            this.addAuthorSurNameBox.Size = new System.Drawing.Size(215, 29);
            this.addAuthorSurNameBox.TabIndex = 3;
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addAuthorButton.FlatAppearance.BorderSize = 0;
            this.addAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAuthorButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAuthorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addAuthorButton.Location = new System.Drawing.Point(148, 319);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(138, 46);
            this.addAuthorButton.TabIndex = 2;
            this.addAuthorButton.Text = "Add";
            this.addAuthorButton.UseVisualStyleBackColor = false;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // addAuthorLabel
            // 
            this.addAuthorLabel.AutoSize = true;
            this.addAuthorLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addAuthorLabel.Location = new System.Drawing.Point(81, 49);
            this.addAuthorLabel.Name = "addAuthorLabel";
            this.addAuthorLabel.Size = new System.Drawing.Size(98, 23);
            this.addAuthorLabel.TabIndex = 1;
            this.addAuthorLabel.Text = "Author name";
            // 
            // addAuthorNameBox
            // 
            this.addAuthorNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addAuthorNameBox.Location = new System.Drawing.Point(71, 90);
            this.addAuthorNameBox.Multiline = true;
            this.addAuthorNameBox.Name = "addAuthorNameBox";
            this.addAuthorNameBox.Size = new System.Drawing.Size(215, 32);
            this.addAuthorNameBox.TabIndex = 0;
            // 
            // Add_Author_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(621, 541);
            this.Controls.Add(this.addLanguageGroupBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Author_Form";
            this.Text = "Add Author";
            this.Load += new System.EventHandler(this.Add_Author_Form_Load);
            this.addLanguageGroupBox.ResumeLayout(false);
            this.addLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addLanguageGroupBox;
        private System.Windows.Forms.Label addPublisherSurNameLabel;
        private System.Windows.Forms.TextBox addAuthorSurNameBox;
        private System.Windows.Forms.Button addAuthorButton;
        private System.Windows.Forms.Label addAuthorLabel;
        private System.Windows.Forms.TextBox addAuthorNameBox;
    }
}