namespace LibraryManagamentSystem.FormsUI
{
    partial class Add_Member_Form
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
            this.addMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.addUserPassword = new System.Windows.Forms.Label();
            this.addMemberIdentityBox = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addFirstNameBox = new System.Windows.Forms.TextBox();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.addMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMemberGroupBox
            // 
            this.addMemberGroupBox.BackColor = System.Drawing.Color.Tan;
            this.addMemberGroupBox.Controls.Add(this.dateOfBirth);
            this.addMemberGroupBox.Controls.Add(this.label1);
            this.addMemberGroupBox.Controls.Add(this.lastNameLabel);
            this.addMemberGroupBox.Controls.Add(this.lastNameBox);
            this.addMemberGroupBox.Controls.Add(this.addUserPassword);
            this.addMemberGroupBox.Controls.Add(this.addMemberIdentityBox);
            this.addMemberGroupBox.Controls.Add(this.addMemberButton);
            this.addMemberGroupBox.Controls.Add(this.firstNameLabel);
            this.addMemberGroupBox.Controls.Add(this.addFirstNameBox);
            this.addMemberGroupBox.Location = new System.Drawing.Point(46, 39);
            this.addMemberGroupBox.Name = "addMemberGroupBox";
            this.addMemberGroupBox.Size = new System.Drawing.Size(595, 403);
            this.addMemberGroupBox.TabIndex = 4;
            this.addMemberGroupBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(338, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Birth of year";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastNameLabel.Location = new System.Drawing.Point(338, 49);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 23);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lastNameBox.Location = new System.Drawing.Point(331, 90);
            this.lastNameBox.Multiline = true;
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(215, 32);
            this.lastNameBox.TabIndex = 6;
            // 
            // addUserPassword
            // 
            this.addUserPassword.AutoSize = true;
            this.addUserPassword.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addUserPassword.Location = new System.Drawing.Point(81, 148);
            this.addUserPassword.Name = "addUserPassword";
            this.addUserPassword.Size = new System.Drawing.Size(120, 23);
            this.addUserPassword.TabIndex = 4;
            this.addUserPassword.Text = "Identity number";
            // 
            // addMemberIdentityBox
            // 
            this.addMemberIdentityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addMemberIdentityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addMemberIdentityBox.Location = new System.Drawing.Point(71, 189);
            this.addMemberIdentityBox.Multiline = true;
            this.addMemberIdentityBox.Name = "addMemberIdentityBox";
            this.addMemberIdentityBox.Size = new System.Drawing.Size(215, 29);
            this.addMemberIdentityBox.TabIndex = 3;
            // 
            // addMemberButton
            // 
            this.addMemberButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addMemberButton.FlatAppearance.BorderSize = 0;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addMemberButton.Location = new System.Drawing.Point(408, 284);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(138, 46);
            this.addMemberButton.TabIndex = 2;
            this.addMemberButton.Text = "Add";
            this.addMemberButton.UseVisualStyleBackColor = false;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.firstNameLabel.Location = new System.Drawing.Point(81, 49);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(83, 23);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First name";
            // 
            // addFirstNameBox
            // 
            this.addFirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addFirstNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addFirstNameBox.Location = new System.Drawing.Point(71, 90);
            this.addFirstNameBox.Multiline = true;
            this.addFirstNameBox.Name = "addFirstNameBox";
            this.addFirstNameBox.Size = new System.Drawing.Size(215, 32);
            this.addFirstNameBox.TabIndex = 0;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Location = new System.Drawing.Point(331, 196);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(211, 22);
            this.dateOfBirth.TabIndex = 11;
            // 
            // Add_Member_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(707, 496);
            this.Controls.Add(this.addMemberGroupBox);
            this.Name = "Add_Member_Form";
            this.Text = "Add Member";
            this.Load += new System.EventHandler(this.Add_Member_Form_Load);
            this.addMemberGroupBox.ResumeLayout(false);
            this.addMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addMemberGroupBox;
        private System.Windows.Forms.Label addUserPassword;
        private System.Windows.Forms.TextBox addMemberIdentityBox;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox addFirstNameBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
    }
}