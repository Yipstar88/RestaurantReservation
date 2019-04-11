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
    public partial class TakeAway : MetroFramework.Forms.MetroForm
    {
        public TakeAway()
        {
            InitializeComponent();
            loadstarter();
            loadbaguettes();
            loadpho();
            loadbunbo();
            loadnoodles();
            loadrice();


        }

        public static string foodname;
        public static Decimal foodprice;
        public static Decimal totalamount;

        public static string firstname;
        public static string email;

        MySqlDataAdapter adapter;
        public DataTable starterdata = new DataTable();
        public DataTable baguettedata = new DataTable();
        public DataTable phodata = new DataTable();
        public DataTable bunbodata = new DataTable();
        public DataTable noodledata = new DataTable();
        public DataTable ricedata = new DataTable();



        public void loadstarter()
        {
            try
            {
                starterdata.Clear();
                string query = "SELECT * FROM fooddb LIMIT 0,17";

                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                adapter = new MySqlDataAdapter(query, Connection.ConnectionDB);

                adapter.FillSchema(starterdata, SchemaType.Source);
                starterdata.Columns[0].DataType = typeof(string);
                adapter.Fill(starterdata);

                startersdatagrid.DataSource = starterdata;
                this.startersdatagrid.DefaultCellStyle.Font = new Font("Monotype Corsiva", 15);

                startersdatagrid.Columns[0].Visible = false;
                startersdatagrid.Columns[1].Width = 50;
                startersdatagrid.Columns[2].Width = 150;


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

        public void loadbaguettes()
        {
            try
            {
                baguettedata.Clear();
                string query = "SELECT * FROM fooddb LIMIT 17,11";

                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                adapter = new MySqlDataAdapter(query, Connection.ConnectionDB);

                adapter.FillSchema(baguettedata, SchemaType.Source);
                baguettedata.Columns[0].DataType = typeof(string);
                adapter.Fill(baguettedata);

                baguettesdatagrid.DataSource = baguettedata;
                this.baguettesdatagrid.DefaultCellStyle.Font = new Font("Monotype Corsiva", 15);

                baguettesdatagrid.Columns[0].Visible = false;
                baguettesdatagrid.Columns[1].Width = 50;
                baguettesdatagrid.Columns[2].Width = 150;


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

        public void loadpho()
        {
            try
            {
                phodata.Clear();
                string query = "SELECT * FROM fooddb LIMIT 28,5";

                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                adapter = new MySqlDataAdapter(query, Connection.ConnectionDB);

                adapter.FillSchema(phodata, SchemaType.Source);
                phodata.Columns[0].DataType = typeof(string);
                adapter.Fill(phodata);

                phodatagrid.DataSource = phodata;
                this.phodatagrid.DefaultCellStyle.Font = new Font("Monotype Corsiva", 15);

                phodatagrid.Columns[0].Visible = false;
                phodatagrid.Columns[1].Width = 50;
                phodatagrid.Columns[2].Width = 150;

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

        public void loadbunbo()
        {
            try
            {
                bunbodata.Clear();
                string query = "SELECT * FROM fooddb LIMIT 33,3";

                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                adapter = new MySqlDataAdapter(query, Connection.ConnectionDB);

                adapter.FillSchema(bunbodata, SchemaType.Source);
                bunbodata.Columns[0].DataType = typeof(string);
                adapter.Fill(bunbodata);

                bunbodatagrid.DataSource = bunbodata;
                this.bunbodatagrid.DefaultCellStyle.Font = new Font("Monotype Corsiva", 15);

                bunbodatagrid.Columns[0].Visible = false;
                bunbodatagrid.Columns[1].Width = 50;
                bunbodatagrid.Columns[2].Width = 150;


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

        public void loadnoodles()
        {
            try
            {
                noodledata.Clear();
                string query = "SELECT * FROM fooddb LIMIT 36,11";

                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                adapter = new MySqlDataAdapter(query, Connection.ConnectionDB);

                adapter.FillSchema(noodledata, SchemaType.Source);
                noodledata.Columns[0].DataType = typeof(string);
                adapter.Fill(noodledata);

                noodlesdatagrid.DataSource = noodledata;
                this.noodlesdatagrid.DefaultCellStyle.Font = new Font("Monotype Corsiva", 15);

                noodlesdatagrid.Columns[0].Visible = false;
                noodlesdatagrid.Columns[1].Width = 50;
                noodlesdatagrid.Columns[2].Width = 150;

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

        public void loadrice()
        {
            try
            {
                ricedata.Clear();
                string query = "SELECT * FROM fooddb LIMIT 48,9";

                if (Connection.ConnectionDB.State == ConnectionState.Closed) Connection.ConnectionDB.Open();
                adapter = new MySqlDataAdapter(query, Connection.ConnectionDB);

                adapter.FillSchema(ricedata, SchemaType.Source);
                ricedata.Columns[0].DataType = typeof(string);
                adapter.Fill(ricedata);

                ricedatagrid.DataSource = ricedata;
                this.ricedatagrid.DefaultCellStyle.Font = new Font("Monotype Corsiva", 15);

                ricedatagrid.Columns[0].Visible = false;
                ricedatagrid.Columns[1].Width = 50;
                ricedatagrid.Columns[2].Width = 150;


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

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }

        private void startersdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foodname = startersdatagrid.SelectedRows[0].Cells["food_name"].Value.ToString();
            foodprice = Convert.ToDecimal(startersdatagrid.SelectedRows[0].Cells["food_price"].Value);
            orderbox.Items.Add(foodname.PadRight(50) + foodprice);
            orderbox.Items.Add("-------------------------");
            totalpricelbl.Visible = true;
            totalamount = totalamount + foodprice;
            totalpricelbl.Text = totalamount.ToString();

        }

        private void baguettesdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foodname = baguettesdatagrid.SelectedRows[0].Cells["food_name"].Value.ToString();
            foodprice = Convert.ToDecimal(baguettesdatagrid.SelectedRows[0].Cells["food_price"].Value);
            orderbox.Items.Add(foodname.PadRight(50) + foodprice);
            orderbox.Items.Add("-------------------------");
            totalpricelbl.Visible = true;
            totalamount = totalamount + foodprice;
            totalpricelbl.Text = totalamount.ToString();
        }

        private void phodatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foodname = phodatagrid.SelectedRows[0].Cells["food_name"].Value.ToString();
            foodprice = Convert.ToDecimal(phodatagrid.SelectedRows[0].Cells["food_price"].Value);
            orderbox.Items.Add(foodname.PadRight(50) + foodprice);
            orderbox.Items.Add("-------------------------");
            totalpricelbl.Visible = true;
            totalamount = totalamount + foodprice;
            totalpricelbl.Text = totalamount.ToString();
        }

        private void bunbodatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foodname = bunbodatagrid.SelectedRows[0].Cells["food_name"].Value.ToString();
            foodprice = Convert.ToDecimal(bunbodatagrid.SelectedRows[0].Cells["food_price"].Value);
            orderbox.Items.Add(foodname.PadRight(50) + foodprice);
            orderbox.Items.Add("-------------------------");
            totalpricelbl.Visible = true;
            totalamount = totalamount + foodprice;
            totalpricelbl.Text = totalamount.ToString();
        }

        private void noodlesdatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foodname = noodlesdatagrid.SelectedRows[0].Cells["food_name"].Value.ToString();
            foodprice = Convert.ToDecimal(noodlesdatagrid.SelectedRows[0].Cells["food_price"].Value);
            orderbox.Items.Add(foodname.PadRight(50) + foodprice);
            orderbox.Items.Add("-------------------------");
            totalpricelbl.Visible = true;
            totalamount = totalamount + foodprice;
            totalpricelbl.Text = totalamount.ToString();
        }

        private void ricedatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foodname = ricedatagrid.SelectedRows[0].Cells["food_name"].Value.ToString();
            foodprice = Convert.ToDecimal(ricedatagrid.SelectedRows[0].Cells["food_price"].Value);
            orderbox.Items.Add(foodname.PadRight(50) + foodprice);
            orderbox.Items.Add("-------------------------");
            totalpricelbl.Visible = true;
            totalamount = totalamount + foodprice;
            totalpricelbl.Text = totalamount.ToString();
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            firstname = firstnametxt.Text;
            email = emailtxt.Text;

            try
            {
                MySqlCommand command = new MySqlCommand();
                command.Connection = Connection.ConnectionDB;

                command.CommandText = "INSERT INTO fooddb VALUES(null,?firstname,?email)";
                command.Parameters.Add("?firstname", MySqlDbType.VarChar).Value = firstnametxt.Text;
                command.Parameters.Add("?email", MySqlDbType.VarChar).Value = emailtxt.Text;

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


        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            orderbox.Items.Add(totallbl.Text.PadRight(50) + totalamount);

            Graphics graphic = e.Graphics;

            Font font = new Font("Monotype Corsiva", 12);

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" ORDER FOR " + firstname, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Food Name".PadRight(50) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            offset = offset + (int)fontHeight + 5; //make the spacing consistent
           
            foreach (string customer_details in orderbox.Items)
            {

                string type = customer_details;
                string value = customer_details;
                string productLine = type;

                graphic.DrawString(productLine, font, new SolidBrush(Color.Black), startX, startY + offset);

                offset = offset + (int)fontHeight + 5;


            }
        }


    }
}
