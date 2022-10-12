namespace LibraryManagementSystem.FormsUI
{
    partial class RezerveBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezerveBookForm));
            this.button1 = new System.Windows.Forms.Button();
            this.bookName = new System.Windows.Forms.TextBox();
            this.rezervePersonTCNoBox = new System.Windows.Forms.TextBox();
            this.rezerveNumber = new System.Windows.Forms.TextBox();
            this.rezervePersonTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createdDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookRezervation = new System.Windows.Forms.GroupBox();
            this.bookRezervation.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(257, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make Rezerve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookName
            // 
            this.bookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookName.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookName.Location = new System.Drawing.Point(257, 72);
            this.bookName.Multiline = true;
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Size = new System.Drawing.Size(217, 32);
            this.bookName.TabIndex = 1;
            this.bookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookName.TextChanged += new System.EventHandler(this.bookName_TextChanged);
            // 
            // rezervePersonTCNoBox
            // 
            this.rezervePersonTCNoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezervePersonTCNoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rezervePersonTCNoBox.Location = new System.Drawing.Point(257, 240);
            this.rezervePersonTCNoBox.Multiline = true;
            this.rezervePersonTCNoBox.Name = "rezervePersonTCNoBox";
            this.rezervePersonTCNoBox.Size = new System.Drawing.Size(217, 29);
            this.rezervePersonTCNoBox.TabIndex = 2;
            this.rezervePersonTCNoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rezervePersonTCNoBox.TextChanged += new System.EventHandler(this.rezervePersonTCNoBox_TextChanged);
            // 
            // rezerveNumber
            // 
            this.rezerveNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rezerveNumber.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezerveNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rezerveNumber.Location = new System.Drawing.Point(257, 128);
            this.rezerveNumber.Multiline = true;
            this.rezerveNumber.Name = "rezerveNumber";
            this.rezerveNumber.ReadOnly = true;
            this.rezerveNumber.Size = new System.Drawing.Size(217, 29);
            this.rezerveNumber.TabIndex = 3;
            this.rezerveNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rezervePersonTC
            // 
            this.rezervePersonTC.AutoSize = true;
            this.rezervePersonTC.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervePersonTC.Location = new System.Drawing.Point(46, 240);
            this.rezervePersonTC.Name = "rezervePersonTC";
            this.rezervePersonTC.Size = new System.Drawing.Size(170, 23);
            this.rezervePersonTC.TabIndex = 4;
            this.rezervePersonTC.Text = "Person identity number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // createdDate
            // 
            this.createdDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.createdDate.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createdDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.createdDate.Location = new System.Drawing.Point(257, 183);
            this.createdDate.Multiline = true;
            this.createdDate.Name = "createdDate";
            this.createdDate.ReadOnly = true;
            this.createdDate.Size = new System.Drawing.Size(217, 29);
            this.createdDate.TabIndex = 7;
            this.createdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(89, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Created Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "RezervationNumber";
            // 
            // bookRezervation
            // 
            this.bookRezervation.BackColor = System.Drawing.Color.Tan;
            this.bookRezervation.Controls.Add(this.bookName);
            this.bookRezervation.Controls.Add(this.rezervePersonTC);
            this.bookRezervation.Controls.Add(this.label3);
            this.bookRezervation.Controls.Add(this.label1);
            this.bookRezervation.Controls.Add(this.rezerveNumber);
            this.bookRezervation.Controls.Add(this.createdDate);
            this.bookRezervation.Controls.Add(this.label2);
            this.bookRezervation.Controls.Add(this.rezervePersonTCNoBox);
            this.bookRezervation.Controls.Add(this.button1);
            this.bookRezervation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bookRezervation.Location = new System.Drawing.Point(226, 41);
            this.bookRezervation.Name = "bookRezervation";
            this.bookRezervation.Size = new System.Drawing.Size(563, 534);
            this.bookRezervation.TabIndex = 10;
            this.bookRezervation.TabStop = false;
            this.bookRezervation.Paint += new System.Windows.Forms.PaintEventHandler(this.bookReservation_Paint);
            this.bookRezervation.Enter += new System.EventHandler(this.bookRezervation_Enter);
            // 
            // RezerveBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(975, 615);
            this.Controls.Add(this.bookRezervation);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RezerveBookForm";
            this.Text = "Book Reservation";
            this.Load += new System.EventHandler(this.RezerveBookForm_Load);
            this.bookRezervation.ResumeLayout(false);
            this.bookRezervation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox bookName;
        private System.Windows.Forms.TextBox rezervePersonTCNoBox;
        private System.Windows.Forms.TextBox rezerveNumber;
        private System.Windows.Forms.Label rezervePersonTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createdDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bookRezervation;
    }
}