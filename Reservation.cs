using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PROJECT
{
    public partial class Reservation : MetroFramework.Forms.MetroForm
    {
        public Reservation()
        {
            InitializeComponent();
           


        }

        public static string name;
        public static string surname;
        public static string date;
        public static string time;
        public static string numberofpeople;
        public static string phonenumber;

       



        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text == "" || surnametxt.Text == "" || timetxt.Text == "" || numberofpeopltxt.Text == "" || tablenumbertxt.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Input Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else if (phonenumbertxt.TextLength != 11)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter a legit number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else{
                try
                {
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = Connection.ConnectionDB;
                    command.CommandText = "INSERT INTO reserveddb VALUES(null,?firstname,?surname,?date,?time,?numberofpeople,?phone_number,?table_number,?other_info)";
                    command.Parameters.Add("?firstname", MySqlDbType.VarChar).Value = firstnametxt.Text;
                    command.Parameters.Add("?surname", MySqlDbType.VarChar).Value = surnametxt.Text;
                    command.Parameters.Add("?date", MySqlDbType.VarChar).Value = this.datetxt.Text;
                    command.Parameters.Add("?time", MySqlDbType.VarChar).Value = time;
                    timetxt.Text.Remove(time.Length - 3, 3);
                    command.Parameters.Add("?numberofpeople", MySqlDbType.Int16).Value = numberofpeopltxt.Text;
                    command.Parameters.Add("?phone_number", MySqlDbType.VarChar).Value = phonenumbertxt.Text;
                    command.Parameters.Add("?table_number", MySqlDbType.Int16).Value = tablenumbertxt.Text;
                    command.Parameters.Add("?other_info", MySqlDbType.VarChar).Value = otherinfotxt.Text;

                    if (command.Connection.State == ConnectionState.Closed) command.Connection.Open();
                    int success = command.ExecuteNonQuery();
                    if (success == 0) // Error
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Their was an problem the customer details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "You have reservered a table for " + firstnametxt.Text, "Succcess ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Database ERROR!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                finally
                {
                    Connection.ConnectionDB.Close();
                }

                name = "";
                surname = "";
                time = "";
                numberofpeople = "";
                phonenumber = "";
                
                Menu M = new Menu();
                M.Show();
                this.Hide();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text == "" || surnametxt.Text == "" || timetxt.Text == "" || numberofpeopltxt.Text == "" || phonenumbertxt.Text == "" || tablenumbertxt.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter details before generating a receipt ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {

           

            receiptbox.Items.Clear();
            receiptbox.Items.Add("                 Reservation          ");
            receiptbox.Items.Add("-------------------------------------------");
            receiptbox.Items.Add("Name:     " + firstnametxt.Text);
            receiptbox.Items.Add(" ");
            receiptbox.Items.Add("Surname:     " + surnametxt.Text);
            receiptbox.Items.Add(" ");
            receiptbox.Items.Add("Date:     " + datetxt.Text);
            receiptbox.Items.Add(" ");
            receiptbox.Items.Add("Time:     " + timetxt.Text);
            receiptbox.Items.Add(" ");
            receiptbox.Items.Add("No. of People:     " + numberofpeopltxt.Text);
            receiptbox.Items.Add(" ");
            receiptbox.Items.Add("Table Number:     " + tablenumbertxt.Text);
            }
        }

        private void printbtn_Click(object sender, EventArgs e)
        {

            if (firstnametxt.Text == "" || surnametxt.Text == "" || timetxt.Text == "" || numberofpeopltxt.Text == "" || phonenumbertxt.Text == "" || tablenumbertxt.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter details before generating a receipt ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else { 
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt);

            DialogResult result = printDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                printDocument.Print();

            }

            }
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Monotype Corsiva", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            foreach (string customer_details in receiptbox.Items)
            {
                string type = customer_details;
                string value = customer_details;
                string productLine = type;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5;


            }
        }

        private void tablelayoutbutton_Click(object sender, EventArgs e)
        {
            name = firstnametxt.Text;
            surname = surnametxt.Text;
            time = timetxt.Text;
            date = this.datetxt.Text;
            numberofpeople = numberofpeopltxt.Text;
            phonenumber = phonenumbertxt.Text;

            TableLayout TL = new TableLayout();
            TL.Show();
            this.Hide();

        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            tablenumbertxt.Text = TableLayout.TableNumber;
            firstnametxt.Text = name;
            surnametxt.Text = surname;
            datetxt.Text = date;
            timetxt.Text = time;
            numberofpeopltxt.Text = numberofpeople;
            phonenumbertxt.Text = phonenumber;

            if (tablenumbertxt.Text == "1")
            {
                TableLayout.pressed1 = true;
                
            }
            else if (tablenumbertxt.Text == "2")
            {
                TableLayout.pressed2 = true;
                
            }
            else if (tablenumbertxt.Text == "3")
            {
                TableLayout.pressed3 = true;
               
            }
            else if (tablenumbertxt.Text == "4")
            {
                TableLayout.pressed4 = true;
                
            }
            else if (tablenumbertxt.Text == "5")
            {
                TableLayout.pressed5 = true;
               
            }
            else if (tablenumbertxt.Text == "6")
            {
                TableLayout.pressed6 = true;
                
            }
            else if (tablenumbertxt.Text == "7")
            {
                TableLayout.pressed7 = true;
                
            }
            else if (tablenumbertxt.Text == "8")
            {
                TableLayout.pressed8 = true;
                
            }
            else if (tablenumbertxt.Text == "9")
            {
                TableLayout.pressed9 = true;
              
            }
            else if (tablenumbertxt.Text == "10")
            {
                TableLayout.pressed10 = true;
               
            }
            else if (tablenumbertxt.Text == "11")
            {
                TableLayout.pressed11 = true;
                
            }
            else if (tablenumbertxt.Text == "12")
            {
                TableLayout.pressed12 = true;
               
            }

            else if (tablenumbertxt.Text == "13")
            {
                TableLayout.pressed13 = true;
                
            }

            else if (tablenumbertxt.Text == "14")
            {
                TableLayout.pressed14 = true;
               
            }

            else if (tablenumbertxt.Text == "15")
            {
                TableLayout.pressed15 = true;
                
            }

            else if (tablenumbertxt.Text == "16")
            {
                TableLayout.pressed16 = true;
               
            }
        }

      

        private void phonenumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Please enter numbers only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void numberofpeopltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Please enter numbers only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void firstnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Please enter letters only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }

        private void surnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Please enter letters only ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}


    

