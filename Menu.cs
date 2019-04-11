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
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void reservebtn_Click(object sender, EventArgs e)
        {
            Reservation R = new Reservation();
            R.Show();
            this.Hide();
        }
      
        private void viewbtn_Click(object sender, EventArgs e)
        {
            ViewReservation VR = new ViewReservation();
            VR.Show();
            this.Hide();
        }

        private void takeawaybtn_Click(object sender, EventArgs e)
        {
            TakeAway TA = new TakeAway();
            TA.Show();
            this.Hide();
        }

        private void assigntablesbtn_Click(object sender, EventArgs e)
        {
            AssignTable AS = new AssignTable();
            AS.Show();
            this.Hide();
        }
    }
}
