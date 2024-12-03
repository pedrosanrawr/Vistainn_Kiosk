﻿using System;
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
    public partial class AddOnsForm : Form
    {
        private mainPage parentPage;

        public AddOnsForm(mainPage parent)
        {
            InitializeComponent();
            this.parentPage = parent;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new SelectRoomForm(parentPage));
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new CustomerInfoForm(parentPage));
        }
    }
}