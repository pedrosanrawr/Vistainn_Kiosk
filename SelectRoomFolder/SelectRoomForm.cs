using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Vistainn_Kiosk.SelectRoomFolder;

namespace Vistainn_Kiosk
{
    public partial class SelectRoomForm : Form
    {
        Database database = new Database();
        Rooms rooms = new Rooms();

        List<Room> roomList = new List<Room>();

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
            string query = "SELECT RoomType, Rate, Picture, Pax FROM room GROUP BY RoomType ORDER BY Pax";

            MySqlConnection conn = new MySqlConnection(database.connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string roomType = reader["RoomType"].ToString();
                double rate = Convert.ToDouble(reader["Rate"]);
                byte[] imageBytes = reader["Picture"] as byte[];
                int pax = Convert.ToInt32(reader["Pax"]);

                roomList.Add(new Room
                {
                    RoomType = roomType,
                    Rate = rate,
                    Image = imageBytes,
                    Pax = pax
                });
            }

            var sortedRoomList = roomList.OrderBy(r => r.Pax).ToList();
            roomFlowLayoutPanel.Controls.Clear();
            foreach (var room in sortedRoomList)
            {
                rooms.createRoomDisplay(room.RoomType, room.Rate, room.Image);
                roomFlowLayoutPanel.Controls.Add(rooms.roomButton);
            }
        }

        //pax numeric up dowm - event
        private void paxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int selectedPax = (int)paxNumericUpDown.Value;

            IEnumerable<Room> filteredRooms;
            if (selectedPax == 0)
            {
                filteredRooms = roomList;
            }
            else
            {
                filteredRooms = roomList.Where(r => r.Pax == selectedPax).ToList();
            }

            roomFlowLayoutPanel.Controls.Clear();

            foreach (var room in filteredRooms)
            {
                rooms.createRoomDisplay(room.RoomType, room.Rate, room.Image);
                roomFlowLayoutPanel.Controls.Add(rooms.roomButton);
            }
        }
    }

    //room class
    public class Room
    {
        public string RoomType { get; set; }
        public double Rate { get; set; }
        public byte[] Image { get; set; }
        public int Pax { get; set; }
    }
}