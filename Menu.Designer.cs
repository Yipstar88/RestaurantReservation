namespace PROJECT
{
    partial class Menu
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
            this.reservebtn = new System.Windows.Forms.Button();
            this.viewbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.takeawaybtn = new System.Windows.Forms.Button();
            this.assigntablesbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservebtn
            // 
            this.reservebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservebtn.Location = new System.Drawing.Point(30, 79);
            this.reservebtn.Name = "reservebtn";
            this.reservebtn.Size = new System.Drawing.Size(236, 127);
            this.reservebtn.TabIndex = 0;
            this.reservebtn.Text = "RESERVE TABLE";
            this.reservebtn.UseVisualStyleBackColor = true;
            this.reservebtn.Click += new System.EventHandler(this.reservebtn_Click);
            // 
            // viewbtn
            // 
            this.viewbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.Location = new System.Drawing.Point(419, 79);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(236, 127);
            this.viewbtn.TabIndex = 2;
            this.viewbtn.Text = "VIEW RESERVED TABLES";
            this.viewbtn.UseVisualStyleBackColor = true;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(611, 8);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(97, 38);
            this.logoutbtn.TabIndex = 4;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // takeawaybtn
            // 
            this.takeawaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeawaybtn.Location = new System.Drawing.Point(30, 253);
            this.takeawaybtn.Name = "takeawaybtn";
            this.takeawaybtn.Size = new System.Drawing.Size(236, 127);
            this.takeawaybtn.TabIndex = 5;
            this.takeawaybtn.Text = "TAKE AWAY";
            this.takeawaybtn.UseVisualStyleBackColor = true;
            this.takeawaybtn.Click += new System.EventHandler(this.takeawaybtn_Click);
            // 
            // assigntablesbtn
            // 
            this.assigntablesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assigntablesbtn.Location = new System.Drawing.Point(419, 253);
            this.assigntablesbtn.Name = "assigntablesbtn";
            this.assigntablesbtn.Size = new System.Drawing.Size(236, 127);
            this.assigntablesbtn.TabIndex = 6;
            this.assigntablesbtn.Text = "ASSIGN RESERVATION TO TABLES";
            this.assigntablesbtn.UseVisualStyleBackColor = true;
            this.assigntablesbtn.Click += new System.EventHandler(this.assigntablesbtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 432);
            this.Controls.Add(this.assigntablesbtn);
            this.Controls.Add(this.takeawaybtn);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.reservebtn);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reservebtn;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button takeawaybtn;
        private System.Windows.Forms.Button assigntablesbtn;
    }
}