using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace PROJECT
{
    public partial class ViewReservation : MetroFramework.Forms.MetroForm
    {
        public ViewReservation()
        {
            InitializeComponent();
            loadData();
        }

        MySqlDataAdapter adapter;
        public DataTable dataTable = new DataTable();
        public static string deletedtablenumber;

        public void loadData()
        {
            try
            {
                dataTable.Clear();
                string query = "SELECT ID, firstname,surname,date,time,numberofpeople,phone_number,table_number,other_info FROM reserveddb";

                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                adapter = new MySqlDataAdapter(query, Connection.ConnectionDB);

                adapter.FillSchema(dataTable, SchemaType.Source);
                dataTable.Columns[0].DataType = typeof(string);
                adapter.Fill(dataTable);

                customerdetailslist.DataSource = dataTable;
                this.customerdetailslist.DefaultCellStyle.Font = new Font("Monotype Corsiva", 15);

                customerdetailslist.Columns[0].Width = 50;
                customerdetailslist.Columns[3].Width = 130;
                customerdetailslist.Columns[5].Width = 75;
                customerdetailslist.Columns[6].Width = 120;
                customerdetailslist.Columns[7].Width = 150;
                customerdetailslist.Columns[8].Width = 200;
                
            }
            catch
            {
                //show database error
            }
            finally
            {
                Connection.ConnectionDB.Close();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Menu M = new Menu();
            M.Show();
            this.Hide();
        }

        private void viewtablesbtn_Click(object sender, EventArgs e)
        {
            TableLayout TL = new TableLayout();
            TL.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (customerdetailslist.SelectedRows.Count == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a reservation to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Connection.ConnectionDB;

                    cmd.CommandText = "DELETE FROM reserveddb WHERE ID = ?id";
                    cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = customerdetailslist.SelectedRows[0].Cells["ID"].Value.ToString();

                    if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                    int success = cmd.ExecuteNonQuery();
                    if (success == 0) // Error
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "You have deleted a reservation!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deletedtablenumber = customerdetailslist.SelectedRows[0].Cells["table_number"].Value.ToString();                     
                    }
                }
                catch
                {
                    MetroFramework.MetroMessageBox.Show(this, "Database Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    dataTable.Clear();
                }
                finally
                {
                    Connection.ConnectionDB.Close();
                }              
            }

            ViewReservation VR = new ViewReservation();
            VR.Show();
            this.Hide();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }
    }
}
