using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vistainn_Kiosk
{
    public partial class InvoiceForm : Form
    {
        private Database database = new Database();
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

            var addOns = GetSelectedAddOns(out double totalAddOnsAmount);

            double nightlyRate = 1000; 
            int numberOfNights = (checkOutDate - checkInDate).Days;
            double roomRate = SelectedRoomData.Rate;
            double totalRoomCost = nightlyRate * numberOfNights + roomRate;
            double totalBookingAmount = totalRoomCost + totalAddOnsAmount;

            if (SaveBookingAndPayment(fullName, phoneNo, email, roomNo, roomType, pax, checkInDate, checkOutDate, addOns, totalBookingAmount, paymentMethod))
            {
                MessageBox.Show("Booking confirmed! Thank you for choosing VistaInn.", "Booking Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new startPage().Show();
                this.Close();
            }
        }

        private List<string> GetSelectedAddOns(out double totalAmount)
        {
            totalAmount = 0;
            List<string> addOnDetails = new List<string>();

            foreach (var addOn in AddOnItem.AddOnsList)
            {
                if (addOn.IsSelected)
                {
                    totalAmount += addOn.GetTotalPrice();
                    addOnDetails.Add($"{addOn.Name} - {addOn.Quantity} x ₱{addOn.Price:0.00} = ₱{addOn.GetTotalPrice():0.00}");
                }
            }

            return addOnDetails;
        }

        private bool SaveBookingAndPayment(string fullName, string phoneNo, string email, string roomNo, string roomType, int pax, DateTime checkInDate, DateTime checkOutDate, List<string> addOns, double totalBookingAmount, string paymentMethod)
        {
            string bookingQuery = @"
            INSERT INTO booking (FullName, PhoneNo, Email, RoomNo, RoomType, Pax, CheckIn, CheckOut, AoName, AoPrice, AoQty, Status)
            VALUES (@FullName, @PhoneNo, @Email, @RoomNo, @RoomType, @Pax, @CheckIn, @CheckOut, @AoName, @AoPrice, @AoQty, @Status);
            SELECT LAST_INSERT_ID();";

            string paymentQuery = @"
            INSERT INTO payment (BookingId, FullName, Amount, PaymentMethod, Status)
            VALUES (@BookingId, @FullName, @Amount, @PaymentMethod, @Status);";

            try
            {
                using (var conn = new MySqlConnection(database.connectionString))
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
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
                        cmd.Parameters.AddWithValue("@AoName", string.Join(",", addOns));
                        cmd.Parameters.AddWithValue("@AoPrice", string.Join(",", addOns.Select(a => a.Split('-')[1].Trim().Split('=')[0].Trim('₱'))));
                        cmd.Parameters.AddWithValue("@AoQty", string.Join(",", addOns.Select(a => a.Split('x')[0].Trim())));
                        cmd.Parameters.AddWithValue("@Status", "Confirmed");

                        long bookingId = Convert.ToInt64(cmd.ExecuteScalar());

                        var paymentCmd = new MySqlCommand(paymentQuery, conn, transaction);
                        paymentCmd.Parameters.AddWithValue("@BookingId", bookingId);
                        paymentCmd.Parameters.AddWithValue("@FullName", fullName);
                        paymentCmd.Parameters.AddWithValue("@Amount", totalBookingAmount);
                        paymentCmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        paymentCmd.Parameters.AddWithValue("@Status", "Pending");

                        paymentCmd.ExecuteNonQuery();
                        transaction.Commit();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving booking and payment details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // displays the invoice in the ui
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

            double totalAddOnsAmount = 0;
            var addOns = GetSelectedAddOns(out totalAddOnsAmount);

            addOnsLabel.Text = string.Join(Environment.NewLine, addOns);

            double nightlyRate = 1000;
            int numberOfNights = (CustomerData.CheckOut - CustomerData.CheckIn).Days;
            double roomRate = SelectedRoomData.Rate;
            double totalRoomCost = nightlyRate * numberOfNights + roomRate;
            double totalBookingAmount = totalRoomCost + totalAddOnsAmount;

            totalPriceLabel.Text = $"₱{totalBookingAmount:0.00}";
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            DisplayInvoice();
        }
    }
}
