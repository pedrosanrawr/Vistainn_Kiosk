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

namespace Vistainn_Kiosk
{
    public partial class InvoiceForm : Form
    {
        Database database = new Database();
        private mainPage parentPage;

        public InvoiceForm(mainPage parent)
        {
            InitializeComponent();
            this.parentPage = parent;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new CustomerInfoForm(parentPage));
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            string fullName = CustomerData.FullName;
            string phoneNo = CustomerData.PhoneNo;
            string email = CustomerData.Email;
            DateTime checkInDate = CustomerData.CheckIn;
            DateTime checkOutDate = CustomerData.CheckOut;
            string roomType = SelectedRoomData.RoomType;
            string roomNo = SelectedRoomData.RoomNo;
            string paymentMethod = SelectedRoomData.PaymentMethod;
            int pax = SelectedRoomData.Pax;

            double totalAddOnsAmount = 0;
            foreach (var addOn in AddOnItem.AddOnsList)
            {
                if (addOn.IsSelected)
                {
                    totalAddOnsAmount += addOn.GetTotalPrice();
                }
            }

            double nightlyRate = 1000;
            int numberOfNights = (checkOutDate - checkInDate).Days;
            double roomRate = SelectedRoomData.Rate;
            double totalRoomCost = nightlyRate * numberOfNights + roomRate;
            double totalBookingAmount = totalRoomCost + totalAddOnsAmount;

            string bookingQuery = @"
            INSERT INTO booking (FullName, PhoneNo, Email, RoomNo, RoomType, Pax, CheckIn, CheckOut, AoName, AoPrice, AoQty, Status)
            VALUES (@FullName, @PhoneNo, @Email, @RoomNo, @RoomType, @Pax, @CheckIn, @CheckOut, @AoName, @AoPrice, @AoQty, @Status);
            SELECT LAST_INSERT_ID();";

            string paymentQuery = @"
            INSERT INTO payment (BookingId, FullName, Amount, PaymentMethod, Status)
            VALUES (@BookingId, @FullName, @Amount, @PaymentMethod, @Status);";

            using (var conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();

                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        var cmd = new MySqlCommand(bookingQuery, conn, transaction);

                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@PhoneNo", phoneNo);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                        cmd.Parameters.AddWithValue("@RoomType", roomType);
                        cmd.Parameters.AddWithValue("@Pax", pax);
                        cmd.Parameters.AddWithValue("@CheckIn", checkInDate);
                        cmd.Parameters.AddWithValue("@CheckOut", checkOutDate);

                        var selectedAddOn = AddOnItem.AddOnsList.FirstOrDefault(addOn => addOn.IsSelected);
                        if (selectedAddOn != null)
                        {
                            cmd.Parameters.AddWithValue("@AoName", selectedAddOn.Name);
                            cmd.Parameters.AddWithValue("@AoPrice", selectedAddOn.Price);
                            cmd.Parameters.AddWithValue("@AoQty", selectedAddOn.Quantity);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@AoName", DBNull.Value);
                            cmd.Parameters.AddWithValue("@AoPrice", 0.0);
                            cmd.Parameters.AddWithValue("@AoQty", 0);
                        }

                        cmd.Parameters.AddWithValue("@Status", "Confirmed");

                        long bookingId = Convert.ToInt64(cmd.ExecuteScalar());

                        var paymentCmd = new MySqlCommand(paymentQuery, conn, transaction);
                        paymentCmd.Parameters.AddWithValue("@BookingId", bookingId);
                        paymentCmd.Parameters.AddWithValue("@FullName", fullName);
                        paymentCmd.Parameters.AddWithValue("@Amount", totalBookingAmount); 
                        paymentCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        paymentCmd.Parameters.AddWithValue("@Status", "Paid"); 

                        paymentCmd.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Booking confirmed! Thank you for choosing VistaInn.", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        startPage startPage = new startPage();
                        startPage.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error while saving booking and payment details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DisplayInvoice()
        {
            fullNameLabel.Text = CustomerData.FullName;
            phoneNoLabel.Text = CustomerData.PhoneNo;
            emailLabel.Text = CustomerData.Email;
            checkInLabel.Text = CustomerData.CheckIn.ToString("yyyy-MM-dd");
            checkOutLabel.Text = CustomerData.CheckOut.ToString("yyyy-MM-dd");
            roomTypeLabel.Text = SelectedRoomData.RoomType;
            roomNoLabel.Text = SelectedRoomData.RoomNo;
            paymentMethodLabel.Text = SelectedRoomData.PaymentMethod;
            paxLabel.Text = SelectedRoomData.Pax.ToString();
            addOnsLabel.Text = "";

                double totalAddOnsAmount = 0;
                foreach (var addOn in AddOnItem.AddOnsList)
                {
                    if (addOn.IsSelected)
                    {
                        string addOnDisplay = $"{addOn.Name} - {addOn.Quantity} x ₱{addOn.Price:0.00} = ₱{addOn.GetTotalPrice():0.00}";
                        addOnsLabel.Text += addOnDisplay + Environment.NewLine;

                        totalAddOnsAmount += addOn.GetTotalPrice();
                    }
                }

                double nightlyRate = 1000; 
                int numberOfNights = (CustomerData.CheckOut - CustomerData.CheckIn).Days;
                double roomRate = SelectedRoomData.Rate;
                double totalRoomCost = nightlyRate * numberOfNights + roomRate;
                double totalBookingAmount = totalRoomCost + totalAddOnsAmount; 

            totalPriceLabel.Text = $"₱{totalBookingAmount:0.00}";
        }

        //load form
        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            DisplayInvoice();
        }
    }
}
