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

            if (CustomerData.CheckIn < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be in the past. Please select a valid date.");
                return;
            }

            if (CustomerData.CheckOut <= CustomerData.CheckIn)
            {
                MessageBox.Show("Check-out date must be later than check-in date. Please select a valid date.");
                return;
            }

            MySqlConnection con = new MySqlConnection(database.connectionString);
            con.Open();
            MySqlTransaction trans = con.BeginTransaction();

            try
            {
                if (string.IsNullOrEmpty(CustomerData.BookingId))
                {
                    string query1 = "INSERT INTO booking(FullName, PhoneNo, Email) VALUES (@FullName, @PhoneNo, @Email)";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con, trans);
                    cmd1.Parameters.AddWithValue("@FullName", CustomerData.FullName);
                    cmd1.Parameters.AddWithValue("@PhoneNo", CustomerData.PhoneNo);
                    cmd1.Parameters.AddWithValue("@Email", CustomerData.Email);
                    cmd1.Parameters.AddWithValue("@CheckIn", CustomerData.CheckIn);
                    cmd1.Parameters.AddWithValue("@CheckOut", CustomerData.CheckOut);
                    cmd1.ExecuteNonQuery();
                }
                else
                {
                    string query1 = "UPDATE booking SET FullName = @FullName, PhoneNo = @PhoneNo, Email = @Email WHERE BookingId = @BookingId";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con, trans);
                    cmd1.Parameters.AddWithValue("@FullName", CustomerData.FullName);
                    cmd1.Parameters.AddWithValue("@PhoneNo", CustomerData.PhoneNo);
                    cmd1.Parameters.AddWithValue("@Email", CustomerData.Email);
                    cmd1.Parameters.AddWithValue("@BookingId", CustomerData.BookingId);
                    cmd1.Parameters.AddWithValue("@CheckIn", CustomerData.CheckIn);
                    cmd1.Parameters.AddWithValue("@CheckOut", CustomerData.CheckOut);
                }

                trans.Commit();

                parentPage.loadForm(new ReviewForm(parentPage));
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new SelectRoomForm(parentPage));
        }
    }
}

//static class - customerData
public static class CustomerData
{
    public static string BookingId { get; set; } 
    public static string FullName { get; set; }
    public static string PhoneNo { get; set; }
    public static string Email { get; set; }
    public static DateTime CheckIn { get; set; }
    public static DateTime CheckOut { get; set; }
}

