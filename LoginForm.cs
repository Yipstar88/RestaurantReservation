using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;

namespace PROJECT
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private bool TryLogin()
        {

            try
            {
                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                string command = "SELECT * FROM admindb WHERE Name = @user AND Pass = @pswd";
                MySqlCommand email = new MySqlCommand(command, Connection.ConnectionDB);
                email.Parameters.AddWithValue("@user", usertxt.Text);
                email.Parameters.AddWithValue("@pswd", passtxt.Text);
                MySqlDataReader dr;

                dr = email.ExecuteReader();
                if (!dr.HasRows)
                {
                    MessageBox.Show("Account information are incorrect.");
                    return false;
                }
                dr.Read();
                //return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error "+ ex);
            }
            finally
            {
                Connection.ConnectionDB.Close();
               
            }
            return true;
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {

            if (TryLogin())
            {              
                Menu M = new Menu();
                M.Show();
                this.Hide();
            }
        }
    }
}
