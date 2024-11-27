using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vistainn_Kiosk.SelectRoomFolder;

namespace Vistainn_Kiosk
{
    public partial class SelectRoomForm : Form
    {
        Database database = new Database();
        Rooms rooms = new Rooms();

        private mainPage parentPage;

        public SelectRoomForm(mainPage parent)
        {
            InitializeComponent();
            loadRoomList();
            this.parentPage = parent;
        }

        //next button - click
        private void nextButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new CustomerInfoForm(parentPage));
        }

        //load room list - method
        private void loadRoomList()
        {
            string query = "SELECT RoomType, Rate, Picture FROM room GROUP BY RoomType";
            MySqlConnection conn = new MySqlConnection(database.connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string roomType = reader["RoomType"].ToString();
                double rate = Convert.ToDouble(reader["Rate"]);
                byte[] imageBytes = reader["Picture"] as byte[];

                rooms.createRoomDisplay(roomType, rate, imageBytes);
                roomFlowLayoutPanel.Controls.Add(rooms.roomButton);
            }
        }
    }
}

