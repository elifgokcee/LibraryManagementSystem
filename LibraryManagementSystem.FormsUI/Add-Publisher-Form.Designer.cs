namespace LibraryManagementSystem.FormsUI
{
    partial class Add_Publisher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Publisher_Form));
            this.addLanguageGroupBox = new System.Windows.Forms.GroupBox();
            this.addPublisherButton = new System.Windows.Forms.Button();
            this.addPublisherLabel = new System.Windows.Forms.Label();
            this.addPublisherNameBox = new System.Windows.Forms.TextBox();
            this.addLanguageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addLanguageGroupBox
            // 
            this.addLanguageGroupBox.BackColor = System.Drawing.Color.Tan;
            this.addLanguageGroupBox.Controls.Add(this.addPublisherButton);
            this.addLanguageGroupBox.Controls.Add(this.addPublisherLabel);
            this.addLanguageGroupBox.Controls.Add(this.addPublisherNameBox);
            this.addLanguageGroupBox.Location = new System.Drawing.Point(138, 84);
            this.addLanguageGroupBox.Name = "addLanguageGroupBox";
            this.addLanguageGroupBox.Size = new System.Drawing.Size(332, 343);
            this.addLanguageGroupBox.TabIndex = 1;
            this.addLanguageGroupBox.TabStop = false;
            // 
            // addPublisherButton
            // 
            this.addPublisherButton.BackColor = System.Drawing.Color.PeachPuff;
            this.addPublisherButton.FlatAppearance.BorderSize = 0;
            this.addPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPublisherButton.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPublisherButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPublisherButton.Location = new System.Drawing.Point(124, 254);
            this.addPublisherButton.Name = "addPublisherButton";
            this.addPublisherButton.Size = new System.Drawing.Size(138, 43);
            this.addPublisherButton.TabIndex = 2;
            this.addPublisherButton.Text = "Add";
            this.addPublisherButton.UseVisualStyleBackColor = false;
            this.addPublisherButton.Click += new System.EventHandler(this.addPublisherButton_Click);
            // 
            // addPublisherLabel
            // 
            this.addPublisherLabel.AutoSize = true;
            this.addPublisherLabel.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPublisherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPublisherLabel.Location = new System.Drawing.Point(44, 79);
            this.addPublisherLabel.Name = "addPublisherLabel";
            this.addPublisherLabel.Size = new System.Drawing.Size(113, 23);
            this.addPublisherLabel.TabIndex = 1;
            this.addPublisherLabel.Text = "Publisher name";
            // 
            // addPublisherNameBox
            // 
            this.addPublisherNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addPublisherNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addPublisherNameBox.Location = new System.Drawing.Point(47, 120);
            this.addPublisherNameBox.Multiline = true;
            this.addPublisherNameBox.Name = "addPublisherNameBox";
            this.addPublisherNameBox.Size = new System.Drawing.Size(215, 22);
            this.addPublisherNameBox.TabIndex = 0;
            // 
            // Add_Publisher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(631, 526);
            this.Controls.Add(this.addLanguageGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Publisher_Form";
            this.Text = "Add_Publisher_Form";
            this.Load += new System.EventHandler(this.Add_Publisher_Form_Load);
            this.addLanguageGroupBox.ResumeLayout(false);
            this.addLanguageGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addLanguageGroupBox;
        private System.Windows.Forms.Button addPublisherButton;
        private System.Windows.Forms.Label addPublisherLabel;
        private System.Windows.Forms.TextBox addPublisherNameBox;
    }
}