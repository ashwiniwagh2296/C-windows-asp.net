namespace FlightBookingAppFROM12
{
    partial class Form1
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
            this.lbl_TO = new System.Windows.Forms.Label();
            this.txt_TO = new System.Windows.Forms.TextBox();
            this.txt_FROM = new System.Windows.Forms.TextBox();
            this.lbl_FROM = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_TransportDocuments = new System.Windows.Forms.Label();
            this.rdb_Passport = new System.Windows.Forms.RadioButton();
            this.rdb_IDcard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_DocumentNO = new System.Windows.Forms.Label();
            this.txt_DocumentsNo = new System.Windows.Forms.TextBox();
            this.lbl_documentISSUEdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_documentEXPIRYdate = new System.Windows.Forms.Label();
            this.lbl_Baggage = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbl_kgs = new System.Windows.Forms.Label();
            this.btn_Book = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_TO
            // 
            this.lbl_TO.AutoSize = true;
            this.lbl_TO.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TO.Location = new System.Drawing.Point(51, 31);
            this.lbl_TO.Name = "lbl_TO";
            this.lbl_TO.Size = new System.Drawing.Size(33, 16);
            this.lbl_TO.TabIndex = 0;
            this.lbl_TO.Text = "TO:";
            // 
            // txt_TO
            // 
            this.txt_TO.Location = new System.Drawing.Point(90, 31);
            this.txt_TO.Name = "txt_TO";
            this.txt_TO.Size = new System.Drawing.Size(100, 20);
            this.txt_TO.TabIndex = 1;
            // 
            // txt_FROM
            // 
            this.txt_FROM.Location = new System.Drawing.Point(368, 33);
            this.txt_FROM.Name = "txt_FROM";
            this.txt_FROM.Size = new System.Drawing.Size(100, 20);
            this.txt_FROM.TabIndex = 3;
            // 
            // lbl_FROM
            // 
            this.lbl_FROM.AutoSize = true;
            this.lbl_FROM.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FROM.Location = new System.Drawing.Point(306, 33);
            this.lbl_FROM.Name = "lbl_FROM";
            this.lbl_FROM.Size = new System.Drawing.Size(56, 16);
            this.lbl_FROM.TabIndex = 2;
            this.lbl_FROM.Text = "FROM:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(78, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2020, 8, 31, 0, 0, 0, 0), new System.DateTime(2020, 9, 6, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(137, 254);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(119, 20);
            this.txt_FirstName.TabIndex = 6;
            this.txt_FirstName.TextChanged += new System.EventHandler(this.txt_FirstName_TextChanged);
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FirstName.Location = new System.Drawing.Point(51, 258);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(80, 16);
            this.lbl_FirstName.TabIndex = 5;
            this.lbl_FirstName.Text = "First Name:";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(467, 250);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(126, 20);
            this.txt_LastName.TabIndex = 8;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LastName.Location = new System.Drawing.Point(383, 254);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(78, 16);
            this.lbl_LastName.TabIndex = 7;
            this.lbl_LastName.Text = "Last Name:";
            this.lbl_LastName.Click += new System.EventHandler(this.lbl_LastName_Click);
            // 
            // lbl_TransportDocuments
            // 
            this.lbl_TransportDocuments.AutoSize = true;
            this.lbl_TransportDocuments.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TransportDocuments.Location = new System.Drawing.Point(51, 304);
            this.lbl_TransportDocuments.Name = "lbl_TransportDocuments";
            this.lbl_TransportDocuments.Size = new System.Drawing.Size(145, 16);
            this.lbl_TransportDocuments.TabIndex = 9;
            this.lbl_TransportDocuments.Text = "Transport Documents:";
            // 
            // rdb_Passport
            // 
            this.rdb_Passport.AutoSize = true;
            this.rdb_Passport.Location = new System.Drawing.Point(16, 12);
            this.rdb_Passport.Name = "rdb_Passport";
            this.rdb_Passport.Size = new System.Drawing.Size(66, 17);
            this.rdb_Passport.TabIndex = 10;
            this.rdb_Passport.TabStop = true;
            this.rdb_Passport.Text = "Passport";
            this.rdb_Passport.UseVisualStyleBackColor = true;
            this.rdb_Passport.CheckedChanged += new System.EventHandler(this.rdb_Passport_CheckedChanged);
            // 
            // rdb_IDcard
            // 
            this.rdb_IDcard.AutoSize = true;
            this.rdb_IDcard.Location = new System.Drawing.Point(114, 11);
            this.rdb_IDcard.Name = "rdb_IDcard";
            this.rdb_IDcard.Size = new System.Drawing.Size(61, 17);
            this.rdb_IDcard.TabIndex = 11;
            this.rdb_IDcard.TabStop = true;
            this.rdb_IDcard.Text = "ID Card";
            this.rdb_IDcard.UseVisualStyleBackColor = true;
            this.rdb_IDcard.CheckedChanged += new System.EventHandler(this.rdb_IDcard_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Passport);
            this.groupBox1.Controls.Add(this.rdb_IDcard);
            this.groupBox1.Location = new System.Drawing.Point(202, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 29);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lbl_DocumentNO
            // 
            this.lbl_DocumentNO.AutoSize = true;
            this.lbl_DocumentNO.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DocumentNO.Location = new System.Drawing.Point(419, 302);
            this.lbl_DocumentNO.Name = "lbl_DocumentNO";
            this.lbl_DocumentNO.Size = new System.Drawing.Size(104, 16);
            this.lbl_DocumentNO.TabIndex = 13;
            this.lbl_DocumentNO.Text = " Documents No:";
            // 
            // txt_DocumentsNo
            // 
            this.txt_DocumentsNo.Location = new System.Drawing.Point(529, 300);
            this.txt_DocumentsNo.Name = "txt_DocumentsNo";
            this.txt_DocumentsNo.Size = new System.Drawing.Size(119, 20);
            this.txt_DocumentsNo.TabIndex = 14;
            // 
            // lbl_documentISSUEdate
            // 
            this.lbl_documentISSUEdate.AutoSize = true;
            this.lbl_documentISSUEdate.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documentISSUEdate.Location = new System.Drawing.Point(51, 350);
            this.lbl_documentISSUEdate.Name = "lbl_documentISSUEdate";
            this.lbl_documentISSUEdate.Size = new System.Drawing.Size(147, 16);
            this.lbl_documentISSUEdate.TabIndex = 15;
            this.lbl_documentISSUEdate.Text = "Documents Issue Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 346);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(638, 346);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 18;
            // 
            // lbl_documentEXPIRYdate
            // 
            this.lbl_documentEXPIRYdate.AutoSize = true;
            this.lbl_documentEXPIRYdate.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documentEXPIRYdate.Location = new System.Drawing.Point(478, 349);
            this.lbl_documentEXPIRYdate.Name = "lbl_documentEXPIRYdate";
            this.lbl_documentEXPIRYdate.Size = new System.Drawing.Size(154, 16);
            this.lbl_documentEXPIRYdate.TabIndex = 17;
            this.lbl_documentEXPIRYdate.Text = "Documents Expiry Date:";
            // 
            // lbl_Baggage
            // 
            this.lbl_Baggage.AutoSize = true;
            this.lbl_Baggage.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Baggage.Location = new System.Drawing.Point(49, 395);
            this.lbl_Baggage.Name = "lbl_Baggage";
            this.lbl_Baggage.Size = new System.Drawing.Size(61, 16);
            this.lbl_Baggage.TabIndex = 19;
            this.lbl_Baggage.Text = "Baggage:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 395);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 20);
            this.numericUpDown1.TabIndex = 20;
            // 
            // lbl_kgs
            // 
            this.lbl_kgs.AutoSize = true;
            this.lbl_kgs.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kgs.Location = new System.Drawing.Point(223, 399);
            this.lbl_kgs.Name = "lbl_kgs";
            this.lbl_kgs.Size = new System.Drawing.Size(28, 16);
            this.lbl_kgs.TabIndex = 21;
            this.lbl_kgs.Text = "kgs";
            // 
            // btn_Book
            // 
            this.btn_Book.BackColor = System.Drawing.Color.Tomato;
            this.btn_Book.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Book.Location = new System.Drawing.Point(24, 440);
            this.btn_Book.Name = "btn_Book";
            this.btn_Book.Size = new System.Drawing.Size(907, 33);
            this.btn_Book.TabIndex = 22;
            this.btn_Book.Text = "Book (Without Paying)";
            this.btn_Book.UseVisualStyleBackColor = false;
            this.btn_Book.Click += new System.EventHandler(this.btn_Book_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 521);
            this.Controls.Add(this.btn_Book);
            this.Controls.Add(this.lbl_kgs);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lbl_Baggage);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.lbl_documentEXPIRYdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_documentISSUEdate);
            this.Controls.Add(this.txt_DocumentsNo);
            this.Controls.Add(this.lbl_DocumentNO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_TransportDocuments);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.lbl_FirstName);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.txt_FROM);
            this.Controls.Add(this.lbl_FROM);
            this.Controls.Add(this.txt_TO);
            this.Controls.Add(this.lbl_TO);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Booking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TO;
        private System.Windows.Forms.TextBox txt_TO;
        private System.Windows.Forms.TextBox txt_FROM;
        private System.Windows.Forms.Label lbl_FROM;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_TransportDocuments;
        private System.Windows.Forms.RadioButton rdb_Passport;
        private System.Windows.Forms.RadioButton rdb_IDcard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_DocumentNO;
        private System.Windows.Forms.TextBox txt_DocumentsNo;
        private System.Windows.Forms.Label lbl_documentISSUEdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_documentEXPIRYdate;
        private System.Windows.Forms.Label lbl_Baggage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbl_kgs;
        private System.Windows.Forms.Button btn_Book;
    }
}

