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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
            loadForm(new SelectRoomForm(this));
        }

        //loadForm
        public void loadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }


    }

    // database class
    class Database
    {
        public string connectionString = "Server=localhost;Database=Vistainn_; Uid=root; Pwd=;";
    }
}
