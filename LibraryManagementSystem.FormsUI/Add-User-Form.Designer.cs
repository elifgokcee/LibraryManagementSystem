namespace LibraryManagamentSystem.FormsUI
{
    partial class Add_User_Form
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
            this.addUserRolecomboBox = new System.Windows.Forms.ComboBox();
            this.addUserPassword = new System.Windows.Forms.Label();
            this.addUserPasswordBox = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.addUserLabel = new System.Windows.Forms.Label();
            this.addUsernameBox = new System.Windows.Forms.TextBox();
            this.addLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLanguageGroupBox
            // 
            this.addLanguageGroupBox.BackColor = System.Drawing.Color.Tan;
            this.addLanguageGroupBox.Controls.Add(this.addUserRolecomboBox);
            this.addLanguageGroupBox.Controls.Add(this.addUserPassword);
            this.addLanguageGroupBox.Controls.Add(this.addUserPasswordBox);
            this.addLanguageGroupBox.Controls.Add(this.addUserButton);
            this.addLanguageGroupBox.Controls.Add(this.addUserLabel);
            this.addLanguageGroupBox.Controls.Add(this.addUsernameBox);
            this.addLanguageGroupBox.Location = new System.Drawing.Point(93, 18);
            this.addLanguageGroupBox.Name = "addLanguageGroupBox";
            this.addLanguageGroupBox.Size = new System.Drawing.Size(355, 427);
            this.addLanguageGroupBox.TabIndex = 3;
            this.addLanguageGroupBox.TabStop = false;
            // 
            // addUserRolecomboBox
            // 
            this.addUserRolecomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserRolecomboBox.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUserRolecomboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addUserRolecomboBox.FormattingEnabled = true;
            this.addUserRolecomboBox.Location = new System.Drawing.Point(71, 259);
            this.addUserRolecomboBox.Name = "addUserRolecomboBox";
            this.addUserRolecomboBox.Size = new System.Drawing.Size(215, 31);
            this.addUserRolecomboBox.TabIndex = 5;
           
            // 
            // addUserPassword
            // 
            this.addUserPassword.AutoSize = true;
            this.addUserPassword.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addUserPassword.Location = new System.Drawing.Point(81, 148);
            this.addUserPassword.Name = "addUserPassword";
            this.addUserPassword.Size = new System.Drawing.Size(73, 23);
            this.addUserPassword.TabIndex = 4;
            this.addUserPassword.Text = "Password";
            // 
            // addUserPasswordBox
            // 
            this.addUserPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addUserPasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addUserPasswordBox.Location = new System.Drawing.Point(71, 189);
            this.addUserPasswordBox.Multiline = true;
            this.addUserPasswordBox.Name = "addUserPasswordBox";
            this.addUserPasswordBox.PasswordChar = '*';
            this.addUserPasswordBox.Size = new System.Drawing.Size(215, 29);
            this.addUserPasswordBox.TabIndex = 3;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addUserButton.Location = new System.Drawing.Point(148, 319);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(138, 46);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // addUserLabel
            // 
            this.addUserLabel.AutoSize = true;
            this.addUserLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addUserLabel.Location = new System.Drawing.Point(81, 49);
            this.addUserLabel.Name = "addUserLabel";
            this.addUserLabel.Size = new System.Drawing.Size(77, 23);
            this.addUserLabel.TabIndex = 1;
            this.addUserLabel.Text = "Username";
            // 
            // addUsernameBox
            // 
            this.addUsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addUsernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addUsernameBox.Location = new System.Drawing.Point(71, 90);
            this.addUsernameBox.Multiline = true;
            this.addUsernameBox.Name = "addUsernameBox";
            this.addUsernameBox.Size = new System.Drawing.Size(215, 32);
            this.addUsernameBox.TabIndex = 0;
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(540, 462);
            this.Controls.Add(this.addLanguageGroupBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Add_User_Form";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.Add_User_Form_Load);
            this.addLanguageGroupBox.ResumeLayout(false);
            this.addLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addLanguageGroupBox;
        private System.Windows.Forms.Label addUserPassword;
        private System.Windows.Forms.TextBox addUserPasswordBox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label addUserLabel;
        private System.Windows.Forms.TextBox addUsernameBox;
        private System.Windows.Forms.ComboBox addUserRolecomboBox;
    }
}