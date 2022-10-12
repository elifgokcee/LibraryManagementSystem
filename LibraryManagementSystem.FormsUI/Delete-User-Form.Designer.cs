namespace LibraryManagamentSystem.FormsUI
{
    partial class Delete_User_Form
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
            this.addLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.addPublisherSurNameLabel = new System.Windows.Forms.Label();
            this.deleteUserpasswordBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addAuthorLabel = new System.Windows.Forms.Label();
            this.deleteUserNameBox = new System.Windows.Forms.TextBox();
            this.addLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLanguageGroupBox
            // 
            this.addLanguageGroupBox.BackColor = System.Drawing.Color.Tan;
            this.addLanguageGroupBox.Controls.Add(this.addPublisherSurNameLabel);
            this.addLanguageGroupBox.Controls.Add(this.deleteUserpasswordBox);
            this.addLanguageGroupBox.Controls.Add(this.deleteButton);
            this.addLanguageGroupBox.Controls.Add(this.addAuthorLabel);
            this.addLanguageGroupBox.Controls.Add(this.deleteUserNameBox);
            this.addLanguageGroupBox.Location = new System.Drawing.Point(64, 12);
            this.addLanguageGroupBox.Name = "addLanguageGroupBox";
            this.addLanguageGroupBox.Size = new System.Drawing.Size(355, 405);
            this.addLanguageGroupBox.TabIndex = 3;
            this.addLanguageGroupBox.TabStop = false;
            // 
            // addPublisherSurNameLabel
            // 
            this.addPublisherSurNameLabel.AutoSize = true;
            this.addPublisherSurNameLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPublisherSurNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPublisherSurNameLabel.Location = new System.Drawing.Point(56, 134);
            this.addPublisherSurNameLabel.Name = "addPublisherSurNameLabel";
            this.addPublisherSurNameLabel.Size = new System.Drawing.Size(73, 23);
            this.addPublisherSurNameLabel.TabIndex = 4;
            this.addPublisherSurNameLabel.Text = "Password";
            // 
            // deleteUserpasswordBox
            // 
            this.deleteUserpasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteUserpasswordBox.Location = new System.Drawing.Point(60, 186);
            this.deleteUserpasswordBox.Multiline = true;
            this.deleteUserpasswordBox.Name = "deleteUserpasswordBox";
            this.deleteUserpasswordBox.Size = new System.Drawing.Size(215, 29);
            this.deleteUserpasswordBox.TabIndex = 3;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Location = new System.Drawing.Point(148, 319);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(138, 46);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addAuthorLabel
            // 
            this.addAuthorLabel.AutoSize = true;
            this.addAuthorLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addAuthorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addAuthorLabel.Location = new System.Drawing.Point(56, 31);
            this.addAuthorLabel.Name = "addAuthorLabel";
            this.addAuthorLabel.Size = new System.Drawing.Size(77, 23);
            this.addAuthorLabel.TabIndex = 1;
            this.addAuthorLabel.Text = "Username";
            // 
            // deleteUserNameBox
            // 
            this.deleteUserNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteUserNameBox.Location = new System.Drawing.Point(60, 75);
            this.deleteUserNameBox.Multiline = true;
            this.deleteUserNameBox.Name = "deleteUserNameBox";
            this.deleteUserNameBox.Size = new System.Drawing.Size(215, 32);
            this.deleteUserNameBox.TabIndex = 0;
            // 
            // Delete_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.addLanguageGroupBox);
            this.Name = "Delete_User_Form";
            this.Text = "Delete_User_Form";
            this.Load += new System.EventHandler(this.Delete_User_Form_Load);
            this.addLanguageGroupBox.ResumeLayout(false);
            this.addLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addLanguageGroupBox;
        private System.Windows.Forms.Label addPublisherSurNameLabel;
        private System.Windows.Forms.TextBox deleteUserpasswordBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label addAuthorLabel;
        private System.Windows.Forms.TextBox deleteUserNameBox;
    }
}