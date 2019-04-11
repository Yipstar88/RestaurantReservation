using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class TableLayout : MetroFramework.Forms.MetroForm
    {
        public static string TableNumber;
        public static Boolean pressed1;
        public static Boolean pressed2;
        public static Boolean pressed3;
        public static Boolean pressed4;
        public static Boolean pressed5;
        public static Boolean pressed6;
        public static Boolean pressed7;
        public static Boolean pressed8;
        public static Boolean pressed9;
        public static Boolean pressed10;
        public static Boolean pressed11;
        public static Boolean pressed12;
        public static Boolean pressed13;
        public static Boolean pressed14;
        public static Boolean pressed15;
        public static Boolean pressed16;
        
        public TableLayout()
        {
            InitializeComponent();

        }
        
        private void buttontable1_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable1.Text;
            buttontable1.BackColor = Color.Red;
            pressed1 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable2_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable2.Text;
            buttontable2.BackColor = Color.Red;
            pressed2 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable3_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable3.Text;
            buttontable3.BackColor = Color.Red;
            pressed3 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable4_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable4.Text;
            buttontable4.BackColor = Color.Red;
            pressed4 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();

        }

        private void buttontable5_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable5.Text;
            buttontable1.BackColor = Color.Red;
            pressed5 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable6_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable6.Text;
            buttontable1.BackColor = Color.Red;
            pressed6 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable7_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable7.Text;
            buttontable1.BackColor = Color.Red;
            pressed7 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable8_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable8.Text;
            buttontable1.BackColor = Color.Red;
            pressed8 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable9_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable9.Text;
            buttontable1.BackColor = Color.Red;
            pressed9 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable10_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable10.Text;
            buttontable1.BackColor = Color.Red;
            pressed10 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable11_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable11.Text;
            buttontable1.BackColor = Color.Red;
            pressed11 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable12_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable12.Text;
            buttontable1.BackColor = Color.Red;
            pressed12 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable13_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable13.Text;
            buttontable1.BackColor = Color.Red;
            pressed13 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable14_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable14.Text;
            buttontable1.BackColor = Color.Red;
            pressed14 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable15_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable15.Text;
            buttontable1.BackColor = Color.Red;
            pressed15 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void buttontable16_Click(object sender, EventArgs e)
        {
            TableNumber = buttontable16.Text;
            buttontable1.BackColor = Color.Red;
            pressed16 = true;
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }

        private void TableLayout_Load(object sender, EventArgs e)
        {
            if (buttontable1.Text == ViewReservation.deletedtablenumber)
            {
                buttontable1.BackColor = Color.LightGray;
                buttontable1.Enabled = true;
                pressed1 = false;
            }

            if (buttontable2.Text == ViewReservation.deletedtablenumber)
            {
                buttontable2.BackColor = Color.LightGray;
                buttontable2.Enabled = true;
                pressed2 = false;
            }

            if (buttontable3.Text == ViewReservation.deletedtablenumber)
            {
                buttontable3.BackColor = Color.LightGray;
                buttontable3.Enabled = true;
                pressed3 = false;
            }

            if (buttontable4.Text == ViewReservation.deletedtablenumber)
            {
                buttontable4.BackColor = Color.LightGray;
                buttontable4.Enabled = true;
                pressed4 = false;
            }

            if (buttontable5.Text == ViewReservation.deletedtablenumber)
            {
                buttontable5.BackColor = Color.LightGray;
                buttontable5.Enabled = true;
                pressed5 = false;
            }

            if (buttontable6.Text == ViewReservation.deletedtablenumber)
            {
                buttontable6.BackColor = Color.LightGray;
                buttontable6.Enabled = true;
                pressed6 = false;
            }

            if (buttontable7.Text == ViewReservation.deletedtablenumber)
            {
                buttontable7.BackColor = Color.LightGray;
                buttontable7.Enabled = true;
                pressed7 = false;
            }

            if (buttontable8.Text == ViewReservation.deletedtablenumber)
            {
                buttontable8.BackColor = Color.LightGray;
                buttontable8.Enabled = true;
                pressed8 = false;
            }

            if (buttontable9.Text == ViewReservation.deletedtablenumber)
            {
                buttontable9.BackColor = Color.LightGray;
                buttontable9.Enabled = true;
                pressed9 = false;
            }

            if (buttontable10.Text == ViewReservation.deletedtablenumber)
            {
                buttontable10.BackColor = Color.LightGray;
                buttontable10.Enabled = true;
                pressed10 = false;
            }

            if (buttontable11.Text == ViewReservation.deletedtablenumber)
            {
                buttontable11.BackColor = Color.LightGray;
                buttontable11.Enabled = true;
                pressed11 = false;
            }

            if (buttontable12.Text == ViewReservation.deletedtablenumber)
            {
                buttontable12.BackColor = Color.LightGray;
                buttontable12.Enabled = true;
                pressed12 = false;
            }

            if (buttontable13.Text == ViewReservation.deletedtablenumber)
            {
                buttontable13.BackColor = Color.LightGray;
                buttontable13.Enabled = true;
                pressed13 = false;
            }

            if (buttontable14.Text == ViewReservation.deletedtablenumber)
            {
                buttontable14.BackColor = Color.LightGray;
                buttontable14.Enabled = true;
                pressed14 = false;
            }

            if (buttontable15.Text == ViewReservation.deletedtablenumber)
            {
                buttontable15.BackColor = Color.LightGray;
                buttontable15.Enabled = true;
                pressed15 = false;
            }

            if (buttontable16.Text == ViewReservation.deletedtablenumber)
            {
                buttontable16.BackColor = Color.LightGray;
                buttontable16.Enabled = true;
                pressed16 = false;
            }

            if (pressed1 == true)
            {
                buttontable1.BackColor = Color.Red;
                buttontable1.Enabled = false;
            }

            if(pressed2 == true)
            {
                buttontable2.BackColor = Color.Red;
                buttontable2.Enabled = false;
            }

            if (pressed3 == true)
            {
                buttontable3.BackColor = Color.Red;
                buttontable3.Enabled = false;
            }

            if (pressed4 == true)
            {
                buttontable4.BackColor = Color.Red;
                buttontable4.Enabled = false;
            }

            if (pressed5 == true)
            {
                buttontable5.BackColor = Color.Red;
                buttontable5.Enabled = false;
            }

            if (pressed6 == true)
            {
                buttontable6.BackColor = Color.Red;
                buttontable6.Enabled = false;
            }

            if (pressed7 == true)
            {
                buttontable7.BackColor = Color.Red;
                buttontable7.Enabled = false;
            }

            if (pressed8 == true)
            {
                buttontable8.BackColor = Color.Red;
                buttontable8.Enabled = false;
            }

            if (pressed9 == true)
            {
                buttontable9.BackColor = Color.Red;
                buttontable9.Enabled = false;
            }

            if (pressed10 == true)
            {
                buttontable10.BackColor = Color.Red;
                buttontable10.Enabled = false;
            }

            if (pressed11 == true)
            {
                buttontable11.BackColor = Color.Red;
                buttontable11.Enabled = false;
            }

            if (pressed12 == true)
            {
                buttontable12.BackColor = Color.Red;
                buttontable12.Enabled = false;
            }

            if (pressed13 == true)
            {
                buttontable13.BackColor = Color.Red;
                buttontable13.Enabled = false;
            }

            if (pressed14 == true)
            {
                buttontable14.BackColor = Color.Red;
                buttontable14.Enabled = false;
            }

            if (pressed15 == true)
            {
                buttontable15.BackColor = Color.Red;
                buttontable15.Enabled = false;
            }

            if (pressed16 == true)
            {
                buttontable16.BackColor = Color.Red;
                buttontable16.Enabled = false;
            }
  
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            buttontable1.BackColor = Color.LightGray;
            buttontable2.BackColor = Color.LightGray;
            buttontable3.BackColor = Color.LightGray;
            buttontable4.BackColor = Color.LightGray;
            buttontable5.BackColor = Color.LightGray;
            buttontable6.BackColor = Color.LightGray;
            buttontable7.BackColor = Color.LightGray;
            buttontable8.BackColor = Color.LightGray;
            buttontable9.BackColor = Color.LightGray;
            buttontable10.BackColor = Color.LightGray;
            buttontable12.BackColor = Color.LightGray;
            buttontable13.BackColor = Color.LightGray;
            buttontable14.BackColor = Color.LightGray;
            buttontable15.BackColor = Color.LightGray;
            buttontable16.BackColor = Color.LightGray;
           
        }
    }
}
