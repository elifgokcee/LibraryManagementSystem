namespace LibraryManagementSystem.FormsUI
{
    partial class Add_Language_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Language_Form));
            this.addLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.addLanguageLabel = new System.Windows.Forms.Label();
            this.addLanguageBox = new System.Windows.Forms.TextBox();
            this.addLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLanguageGroupBox
            // 
            this.addLanguageGroupBox.BackColor = System.Drawing.Color.Tan;
            this.addLanguageGroupBox.Controls.Add(this.addLanguageButton);
            this.addLanguageGroupBox.Controls.Add(this.addLanguageLabel);
            this.addLanguageGroupBox.Controls.Add(this.addLanguageBox);
            this.addLanguageGroupBox.Location = new System.Drawing.Point(99, 45);
            this.addLanguageGroupBox.Name = "addLanguageGroupBox";
            this.addLanguageGroupBox.Size = new System.Drawing.Size(355, 377);
            this.addLanguageGroupBox.TabIndex = 0;
            this.addLanguageGroupBox.TabStop = false;
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addLanguageButton.FlatAppearance.BorderSize = 0;
            this.addLanguageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLanguageButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addLanguageButton.Location = new System.Drawing.Point(157, 284);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(127, 37);
            this.addLanguageButton.TabIndex = 2;
            this.addLanguageButton.Text = "Add";
            this.addLanguageButton.UseVisualStyleBackColor = false;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // addLanguageLabel
            // 
            this.addLanguageLabel.AutoSize = true;
            this.addLanguageLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addLanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addLanguageLabel.Location = new System.Drawing.Point(65, 67);
            this.addLanguageLabel.Name = "addLanguageLabel";
            this.addLanguageLabel.Size = new System.Drawing.Size(114, 23);
            this.addLanguageLabel.TabIndex = 1;
            this.addLanguageLabel.Text = "Language name";
            // 
            // addLanguageBox
            // 
            this.addLanguageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addLanguageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addLanguageBox.Location = new System.Drawing.Point(69, 115);
            this.addLanguageBox.Multiline = true;
            this.addLanguageBox.Name = "addLanguageBox";
            this.addLanguageBox.Size = new System.Drawing.Size(215, 36);
            this.addLanguageBox.TabIndex = 0;
            // 
            // Add_Language_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(579, 467);
            this.Controls.Add(this.addLanguageGroupBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Language_Form";
            this.Text = "Add Language";
            this.Load += new System.EventHandler(this.Add_Language_Form_Load);
            this.addLanguageGroupBox.ResumeLayout(false);
            this.addLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addLanguageGroupBox;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.Label addLanguageLabel;
        private System.Windows.Forms.TextBox addLanguageBox;
    }
}