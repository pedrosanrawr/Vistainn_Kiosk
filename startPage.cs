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
    public partial class startPage : Form
    {
        private mainPage parentPage;

        public startPage(mainPage parent)
        {
            InitializeComponent();
            this.parentPage = parent;
        }

        //book now button
        private void booknowButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new SelectRoomForm(parentPage));
        }
    }
}
