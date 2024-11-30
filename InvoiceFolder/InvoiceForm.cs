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
            MessageBox.Show("Booking confirmed! Thank you for choosing VistaInn.",
                           "Booking Successful",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

            startPage startPage = new startPage();
            startPage.Show();
            this.Hide();
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
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            DisplayInvoice();
        }
    }
}
