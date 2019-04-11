namespace PROJECT
{
    partial class Reservation
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
            this.logoutbtn = new System.Windows.Forms.Button();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.surnametxt = new System.Windows.Forms.TextBox();
            this.numberofpeopltxt = new System.Windows.Forms.TextBox();
            this.tablenumbertxt = new System.Windows.Forms.TextBox();
            this.firstnamelbl = new System.Windows.Forms.Label();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.numberofpeoplelbl = new System.Windows.Forms.Label();
            this.phonenumberlbl = new System.Windows.Forms.Label();
            this.tablenumberlbl = new System.Windows.Forms.Label();
            this.timetxt = new System.Windows.Forms.TextBox();
            this.timelbl = new System.Windows.Forms.Label();
            this.otherinfolbl = new System.Windows.Forms.Label();
            this.otherinfotxt = new System.Windows.Forms.TextBox();
            this.reservebtn = new System.Windows.Forms.Button();
            this.phonenumbertxt = new System.Windows.Forms.TextBox();
            this.bar = new System.Windows.Forms.TextBox();
            this.generatebtn = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.datetxt = new System.Windows.Forms.DateTimePicker();
            this.backbtn = new System.Windows.Forms.Button();
            this.receiptbox = new System.Windows.Forms.ListBox();
            this.tablelayoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(1192, 5);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(91, 46);
            this.logoutbtn.TabIndex = 0;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // firstnametxt
            // 
            this.firstnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.Location = new System.Drawing.Point(269, 57);
            this.firstnametxt.MaxLength = 10;
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(234, 40);
            this.firstnametxt.TabIndex = 1;
            this.firstnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstnametxt_KeyPress);
            // 
            // surnametxt
            // 
            this.surnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnametxt.Location = new System.Drawing.Point(269, 120);
            this.surnametxt.MaxLength = 10;
            this.surnametxt.Name = "surnametxt";
            this.surnametxt.Size = new System.Drawing.Size(234, 40);
            this.surnametxt.TabIndex = 2;
            this.surnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnametxt_KeyPress);
            // 
            // numberofpeopltxt
            // 
            this.numberofpeopltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofpeopltxt.Location = new System.Drawing.Point(269, 309);
            this.numberofpeopltxt.MaxLength = 2;
            this.numberofpeopltxt.Name = "numberofpeopltxt";
            this.numberofpeopltxt.Size = new System.Drawing.Size(56, 40);
            this.numberofpeopltxt.TabIndex = 4;
            this.numberofpeopltxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberofpeopltxt_KeyPress);
            // 
            // tablenumbertxt
            // 
            this.tablenumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablenumbertxt.Location = new System.Drawing.Point(269, 436);
            this.tablenumbertxt.MaxLength = 2;
            this.tablenumbertxt.Name = "tablenumbertxt";
            this.tablenumbertxt.ReadOnly = true;
            this.tablenumbertxt.Size = new System.Drawing.Size(56, 40);
            this.tablenumbertxt.TabIndex = 6;
            // 
            // firstnamelbl
            // 
            this.firstnamelbl.AutoSize = true;
            this.firstnamelbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelbl.Location = new System.Drawing.Point(52, 67);
            this.firstnamelbl.Name = "firstnamelbl";
            this.firstnamelbl.Size = new System.Drawing.Size(142, 36);
            this.firstnamelbl.TabIndex = 7;
            this.firstnamelbl.Text = "First Name";
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnamelbl.Location = new System.Drawing.Point(52, 124);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(109, 36);
            this.surnamelbl.TabIndex = 8;
            this.surnamelbl.Text = "Surname";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(54, 185);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(70, 36);
            this.datelbl.TabIndex = 9;
            this.datelbl.Text = "Date";
            // 
            // numberofpeoplelbl
            // 
            this.numberofpeoplelbl.AutoSize = true;
            this.numberofpeoplelbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofpeoplelbl.Location = new System.Drawing.Point(54, 313);
            this.numberofpeoplelbl.Name = "numberofpeoplelbl";
            this.numberofpeoplelbl.Size = new System.Drawing.Size(211, 36);
            this.numberofpeoplelbl.TabIndex = 10;
            this.numberofpeoplelbl.Text = "Number of people";
            // 
            // phonenumberlbl
            // 
            this.phonenumberlbl.AutoSize = true;
            this.phonenumberlbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberlbl.Location = new System.Drawing.Point(52, 385);
            this.phonenumberlbl.Name = "phonenumberlbl";
            this.phonenumberlbl.Size = new System.Drawing.Size(178, 36);
            this.phonenumberlbl.TabIndex = 11;
            this.phonenumberlbl.Text = "Phone Number";
            // 
            // tablenumberlbl
            // 
            this.tablenumberlbl.AutoSize = true;
            this.tablenumberlbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablenumberlbl.Location = new System.Drawing.Point(52, 451);
            this.tablenumberlbl.Name = "tablenumberlbl";
            this.tablenumberlbl.Size = new System.Drawing.Size(171, 36);
            this.tablenumberlbl.TabIndex = 12;
            this.tablenumberlbl.Text = "Table Number";
            // 
            // timetxt
            // 
            this.timetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timetxt.Location = new System.Drawing.Point(269, 238);
            this.timetxt.MaxLength = 15;
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(148, 40);
            this.timetxt.TabIndex = 14;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(52, 251);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(69, 36);
            this.timelbl.TabIndex = 15;
            this.timelbl.Text = "Time";
            // 
            // otherinfolbl
            // 
            this.otherinfolbl.AutoSize = true;
            this.otherinfolbl.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherinfolbl.Location = new System.Drawing.Point(54, 511);
            this.otherinfolbl.Name = "otherinfolbl";
            this.otherinfolbl.Size = new System.Drawing.Size(129, 36);
            this.otherinfolbl.TabIndex = 16;
            this.otherinfolbl.Text = "Other info";
            // 
            // otherinfotxt
            // 
            this.otherinfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherinfotxt.Location = new System.Drawing.Point(269, 508);
            this.otherinfotxt.Multiline = true;
            this.otherinfotxt.Name = "otherinfotxt";
            this.otherinfotxt.Size = new System.Drawing.Size(234, 135);
            this.otherinfotxt.TabIndex = 17;
            // 
            // reservebtn
            // 
            this.reservebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservebtn.Location = new System.Drawing.Point(1102, 545);
            this.reservebtn.Name = "reservebtn";
            this.reservebtn.Size = new System.Drawing.Size(171, 85);
            this.reservebtn.TabIndex = 18;
            this.reservebtn.Text = "Reserve Table";
            this.reservebtn.UseVisualStyleBackColor = true;
            this.reservebtn.Click += new System.EventHandler(this.reservebtn_Click);
            // 
            // phonenumbertxt
            // 
            this.phonenumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumbertxt.Location = new System.Drawing.Point(269, 375);
            this.phonenumbertxt.MaxLength = 11;
            this.phonenumbertxt.Name = "phonenumbertxt";
            this.phonenumbertxt.Size = new System.Drawing.Size(234, 40);
            this.phonenumbertxt.TabIndex = 19;
            this.phonenumbertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phonenumbertxt_KeyPress);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar.Location = new System.Drawing.Point(623, 5);
            this.bar.Multiline = true;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(15, 663);
            this.bar.TabIndex = 20;
            // 
            // generatebtn
            // 
            this.generatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebtn.Location = new System.Drawing.Point(1112, 120);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(161, 98);
            this.generatebtn.TabIndex = 22;
            this.generatebtn.Text = "Generate Receipt";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // printbtn
            // 
            this.printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.Location = new System.Drawing.Point(1112, 270);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(161, 98);
            this.printbtn.TabIndex = 23;
            this.printbtn.Text = "Print Receipt";
            this.printbtn.UseVisualStyleBackColor = true;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // datetxt
            // 
            this.datetxt.CustomFormat = "";
            this.datetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetxt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetxt.Location = new System.Drawing.Point(269, 185);
            this.datetxt.Name = "datetxt";
            this.datetxt.Size = new System.Drawing.Size(137, 31);
            this.datetxt.TabIndex = 24;
            this.datetxt.Value = new System.DateTime(2018, 4, 18, 0, 0, 0, 0);
            // 
            // backbtn
            // 
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(1095, 5);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(91, 46);
            this.backbtn.TabIndex = 25;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // receiptbox
            // 
            this.receiptbox.Enabled = false;
            this.receiptbox.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptbox.FormattingEnabled = true;
            this.receiptbox.ItemHeight = 43;
            this.receiptbox.Location = new System.Drawing.Point(655, 67);
            this.receiptbox.Name = "receiptbox";
            this.receiptbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.receiptbox.Size = new System.Drawing.Size(436, 563);
            this.receiptbox.TabIndex = 26;
            // 
            // tablelayoutbutton
            // 
            this.tablelayoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablelayoutbutton.Location = new System.Drawing.Point(353, 436);
            this.tablelayoutbutton.Name = "tablelayoutbutton";
            this.tablelayoutbutton.Size = new System.Drawing.Size(205, 40);
            this.tablelayoutbutton.TabIndex = 27;
            this.tablelayoutbutton.Text = "Choose Table";
            this.tablelayoutbutton.UseVisualStyleBackColor = true;
            this.tablelayoutbutton.Click += new System.EventHandler(this.tablelayoutbutton_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 658);
            this.Controls.Add(this.tablelayoutbutton);
            this.Controls.Add(this.receiptbox);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.generatebtn);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.phonenumbertxt);
            this.Controls.Add(this.reservebtn);
            this.Controls.Add(this.otherinfotxt);
            this.Controls.Add(this.otherinfolbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.tablenumberlbl);
            this.Controls.Add(this.phonenumberlbl);
            this.Controls.Add(this.numberofpeoplelbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.surnamelbl);
            this.Controls.Add(this.firstnamelbl);
            this.Controls.Add(this.tablenumbertxt);
            this.Controls.Add(this.numberofpeopltxt);
            this.Controls.Add(this.surnametxt);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.logoutbtn);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.TextBox surnametxt;
        private System.Windows.Forms.TextBox numberofpeopltxt;
        private System.Windows.Forms.TextBox tablenumbertxt;
        private System.Windows.Forms.Label firstnamelbl;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label numberofpeoplelbl;
        private System.Windows.Forms.Label phonenumberlbl;
        private System.Windows.Forms.Label tablenumberlbl;
        private System.Windows.Forms.TextBox timetxt;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label otherinfolbl;
        private System.Windows.Forms.TextBox otherinfotxt;
        private System.Windows.Forms.Button reservebtn;
        private System.Windows.Forms.TextBox phonenumbertxt;
        private System.Windows.Forms.TextBox bar;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.DateTimePicker datetxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ListBox receiptbox;
        private System.Windows.Forms.Button tablelayoutbutton;
    }
}