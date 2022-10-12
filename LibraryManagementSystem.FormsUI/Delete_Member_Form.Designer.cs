namespace LibraryManagamentSystem.FormsUI
{
    partial class Delete_Member_Form
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
            this.deleteIdentity = new System.Windows.Forms.Label();
            this.deleteMemberIdentityBox = new System.Windows.Forms.TextBox();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.addMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMemberGroupBox
            // 
            this.addMemberGroupBox.BackColor = System.Drawing.Color.Tan;
            this.addMemberGroupBox.Controls.Add(this.deleteIdentity);
            this.addMemberGroupBox.Controls.Add(this.deleteMemberIdentityBox);
            this.addMemberGroupBox.Controls.Add(this.deleteMemberButton);
            this.addMemberGroupBox.Location = new System.Drawing.Point(103, 24);
            this.addMemberGroupBox.Name = "addMemberGroupBox";
            this.addMemberGroupBox.Size = new System.Drawing.Size(330, 403);
            this.addMemberGroupBox.TabIndex = 5;
            this.addMemberGroupBox.TabStop = false;
            // 
            // deleteIdentity
            // 
            this.deleteIdentity.AutoSize = true;
            this.deleteIdentity.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteIdentity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteIdentity.Location = new System.Drawing.Point(72, 65);
            this.deleteIdentity.Name = "deleteIdentity";
            this.deleteIdentity.Size = new System.Drawing.Size(120, 23);
            this.deleteIdentity.TabIndex = 4;
            this.deleteIdentity.Text = "Identity number";
            // 
            // deleteMemberIdentityBox
            // 
            this.deleteMemberIdentityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteMemberIdentityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteMemberIdentityBox.Location = new System.Drawing.Point(63, 123);
            this.deleteMemberIdentityBox.Multiline = true;
            this.deleteMemberIdentityBox.Name = "deleteMemberIdentityBox";
            this.deleteMemberIdentityBox.Size = new System.Drawing.Size(215, 29);
            this.deleteMemberIdentityBox.TabIndex = 3;
            this.deleteMemberIdentityBox.TextChanged += new System.EventHandler(this.deleteMemberIdentityBox_TextChanged);
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.BackColor = System.Drawing.Color.PeachPuff;
            this.deleteMemberButton.FlatAppearance.BorderSize = 0;
            this.deleteMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteMemberButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteMemberButton.Location = new System.Drawing.Point(140, 281);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(138, 46);
            this.deleteMemberButton.TabIndex = 2;
            this.deleteMemberButton.Text = "Delete";
            this.deleteMemberButton.UseVisualStyleBackColor = false;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // Delete_Member_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.addMemberGroupBox);
            this.Name = "Delete_Member_Form";
            this.Text = "Delete Member";
            this.Load += new System.EventHandler(this.Delete_Member_Form_Load);
            this.addMemberGroupBox.ResumeLayout(false);
            this.addMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addMemberGroupBox;
        private System.Windows.Forms.Label deleteIdentity;
        private System.Windows.Forms.TextBox deleteMemberIdentityBox;
        private System.Windows.Forms.Button deleteMemberButton;
    }
}