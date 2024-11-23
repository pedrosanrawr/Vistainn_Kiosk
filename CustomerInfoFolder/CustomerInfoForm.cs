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

            try
            {
                if (string.IsNullOrEmpty(CustomerData.CustomerId))
                {
                    string query1 = "INSERT INTO customer(FullName, PhoneNo, Email) VALUES (@FullName, @PhoneNo, @Email)";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con, trans);
                    cmd1.Parameters.AddWithValue("@FullName", CustomerData.FullName);
                    cmd1.Parameters.AddWithValue("@PhoneNo", CustomerData.PhoneNo);
                    cmd1.Parameters.AddWithValue("@Email", CustomerData.Email);
                    cmd1.ExecuteNonQuery();

                    string getCustomerIdQuery = "SELECT LAST_INSERT_ID()";
                    MySqlCommand getCustomerIdCmd = new MySqlCommand(getCustomerIdQuery, con, trans);
                    CustomerData.CustomerId = getCustomerIdCmd.ExecuteScalar().ToString();

                    string query2 = "INSERT INTO booking (FullName, check_in, check_out) VALUES (@FullName, @CheckIn, @CheckOut)";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con, trans);
                    cmd2.Parameters.AddWithValue("@FullName", CustomerData.FullName);
                    cmd2.Parameters.AddWithValue("@CheckIn", CustomerData.CheckIn);
                    cmd2.Parameters.AddWithValue("@CheckOut", CustomerData.CheckOut);
                    cmd2.ExecuteNonQuery();
                }
                else
                {
                    string query1 = "UPDATE customer SET FullName = @FullName, PhoneNo = @PhoneNo, Email = @Email WHERE CustomerId = @CustomerId";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con, trans);
                    cmd1.Parameters.AddWithValue("@FullName", CustomerData.FullName);
                    cmd1.Parameters.AddWithValue("@PhoneNo", CustomerData.PhoneNo);
                    cmd1.Parameters.AddWithValue("@Email", CustomerData.Email);
                    cmd1.Parameters.AddWithValue("@CustomerId", CustomerData.CustomerId);
                    cmd1.ExecuteNonQuery();

                    string query2 = "UPDATE booking SET check_in = @CheckIn, check_out = @CheckOut WHERE FullName = @FullName";
                    MySqlCommand cmd2 = new MySqlCommand(query2, con, trans);
                    cmd2.Parameters.AddWithValue("@CheckIn", CustomerData.CheckIn);
                    cmd2.Parameters.AddWithValue("@CheckOut", CustomerData.CheckOut);
                    cmd2.Parameters.AddWithValue("@FullName", CustomerData.FullName);
                    cmd2.ExecuteNonQuery();
                }

                trans.Commit();

                parentPage.loadForm(new SelectRoomForm(parentPage));
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

    }
}

//static class - customerData
public static class CustomerData
{
    public static string CustomerId { get; set; } 
    public static string FullName { get; set; }
    public static string PhoneNo { get; set; }
    public static string Email { get; set; }
    public static DateTime CheckIn { get; set; }
    public static DateTime CheckOut { get; set; }
}

