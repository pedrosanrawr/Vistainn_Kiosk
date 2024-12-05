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
using System.Text.RegularExpressions;
using System.Windows.Controls;
using Vistainn_Kiosk.CustomerInfoFolder;

namespace Vistainn_Kiosk
{
    public partial class CustomerInfoForm : Form
    {
        Database database = new Database();
        private mainPage parentPage;

        public CustomerInfoForm() { }

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

            parentPage.loadForm(new InvoiceForm(parentPage));
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new AddOnsForm(parentPage));
        }
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

