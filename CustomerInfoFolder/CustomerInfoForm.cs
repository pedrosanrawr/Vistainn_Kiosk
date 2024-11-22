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

            fullNameTextBox.Text = CustomerData.FullName;
            phoneNoTextBox.Text = CustomerData.PhoneNo;
            emailTextBox.Text = CustomerData.Email;
            checkInDateTimePicker.Value = CustomerData.CheckIn != DateTime.MinValue ? CustomerData.CheckIn : DateTime.Today;
            checkOutDateTimePicker.Value = CustomerData.CheckOut != DateTime.MinValue ? CustomerData.CheckOut : DateTime.Today.AddDays(1);
        }

        //next button - click
        private void nextButton_Click(object sender, EventArgs e)
        {
            CustomerData.FullName = this.fullNameTextBox.Text;
            CustomerData.PhoneNo = this.phoneNoTextBox.Text;
            CustomerData.Email = this.emailTextBox.Text;
            CustomerData.CheckIn = this.checkInDateTimePicker.Value;
            CustomerData.CheckOut = this.checkOutDateTimePicker.Value;

            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlTransaction trans = con.BeginTransaction();

            string query1 = "INSERT INTO customer(FullName, PhoneNo, Email) VALUES (@FullName, @PhoneNo, @Email)";
            MySqlCommand cmd1 = new MySqlCommand(query1, con, trans);
            cmd1.Parameters.AddWithValue("@FullName", CustomerData.FullName);
            cmd1.Parameters.AddWithValue("@PhoneNo", CustomerData.PhoneNo);
            cmd1.Parameters.AddWithValue("@Email", CustomerData.Email);
            cmd1.ExecuteNonQuery();

            string query2 = "INSERT INTO booking (check_in, check_out) VALUES (@CheckIn, @CheckOut)";
            MySqlCommand cmd2 = new MySqlCommand(query2, con, trans);
            cmd2.Parameters.AddWithValue("@CheckIn", CustomerData.CheckIn);
            cmd2.Parameters.AddWithValue("@CheckOut", CustomerData.CheckOut);
            cmd2.ExecuteNonQuery();

            trans.Commit();

            parentPage.loadForm(new SelectRoomForm(parentPage));
        }
    }
    
    //static class - customerData
    public static class CustomerData
    {
        public static string FullName { get; set; }
        public static string PhoneNo { get; set; }
        public static string Email { get; set; }
        public static DateTime CheckIn { get; set; }
        public static DateTime CheckOut { get; set; }
    }
}