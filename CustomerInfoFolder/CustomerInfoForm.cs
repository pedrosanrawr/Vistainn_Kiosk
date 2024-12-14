using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Vistainn_Kiosk;
using Vistainn_Kiosk.CustomerInfoFolder;

namespace Vistainn_Kiosk
{
    public partial class CustomerInfoForm : Form
    {
        Database database = new MySqlDatabase();
        private mainPage parentPage;

        public CustomerInfoForm(mainPage parent)
        {
            InitializeComponent();
            this.parentPage = parent;
        }

        //next button - click
        private void nextButton_Click(object sender, EventArgs e)
        {
            CustomerData.FullName = this.fullNameTextBox.Text;
            CustomerData.PhoneNo = this.phoneNoTextBox.Text;
            CustomerData.Email = this.emailTextBox.Text;
            CustomerData.CheckIn = this.checkInDateTimePicker.Value;
            CustomerData.CheckOut = this.checkOutDateTimePicker.Value;

            if (!CustomerInfoFolder.Validation.ValidateDates(CustomerData.CheckIn, CustomerData.CheckOut)) return;
            if (!CustomerInfoFolder.Validation.ValidateEmail(CustomerData.Email)) return;
            if (!CustomerInfoFolder.Validation.ValidatePhoneNumber(CustomerData.PhoneNo)) return;
            if (!CustomerInfoFolder.Validation.ValidateName(CustomerData.FullName)) return;

            parentPage.loadForm(new InvoiceForm(parentPage));
        }

        //back button - click
        private void backButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new AddOnsForm(parentPage));
        }     
    }

    //customer data class
    public static class CustomerData
    {
        public static string FullName { get; set; }
        public static string PhoneNo { get; set; }
        public static string Email { get; set; }
        public static DateTime CheckIn { get; set; }
        public static DateTime CheckOut { get; set; }
    }
}
