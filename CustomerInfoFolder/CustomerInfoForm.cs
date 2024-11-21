using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistainn_Kiosk;

namespace Vistainn_Kiosk
{
    public partial class CustomerInfoForm : Form
    {

        Database database = new Database();
        private mainPage parentPage;

        public CustomerInfoForm(mainPage parent)
        {
            InitializeComponent();
            this.parentPage = parent;
        }

        //next button - click
        private void nextButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlTransaction trans = con.BeginTransaction();

            string query1 = "INSERT INTO customer(FullName, PhoneNo, Email) VALUES (@FullName,@PhoneNo, @Email)";
            MySqlCommand cmd1 = new MySqlCommand(query1, con, trans);

            cmd1.Parameters.AddWithValue("@FullName", this.fullNameTextBox.Text);
            cmd1.Parameters.AddWithValue("@PhoneNo", this.phoneNoTextBox.Text);
            cmd1.Parameters.AddWithValue("@Email", this.emailTextBox.Text);
            cmd1.ExecuteNonQuery();

            string query2 = "INSERT INTO booking (check_in, check_out) VALUES (@CheckIn, @CheckOut)";
            MySqlCommand cmd2 = new MySqlCommand(query2, con, trans);
            cmd2.Parameters.AddWithValue("@CheckIn", this.checkInDateTimePicker.Value);
            cmd2.Parameters.AddWithValue("@CheckOut", this.checkOutDateTimePicker.Value);
            cmd2.ExecuteNonQuery();

            trans.Commit();
            parentPage.loadForm(new SelectRoomForm(parentPage));
        }
    }
}