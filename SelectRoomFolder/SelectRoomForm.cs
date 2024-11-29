using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Vistainn_Kiosk.SelectRoomFolder;

namespace Vistainn_Kiosk
{
    public partial class SelectRoomForm : Form
    {
        Database database = new Database();
        Rooms rooms = new Rooms();

        List<RoomData> roomList = new List<RoomData>();

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
            string query = "SELECT * FROM room GROUP BY RoomType ORDER BY Pax";

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
                string bathroom = reader["Bathroom"].ToString();
                string bedroom = reader["BedRoom"].ToString();
                string kitchen = reader["Kitchen"].ToString();
                string technology = reader["Technology"].ToString();
                string general = reader["General"].ToString();

                roomList.Add(new RoomData
                {
                    RoomType = roomType,
                    Rate = rate,
                    Image = imageBytes,
                    Pax = pax,
                    Bathroom = bathroom,
                    Bedroom = bedroom,
                    Kitchen = kitchen,
                    Technology = technology,
                    General = general
                });
            }

            var sortedRoomList = roomList.OrderBy(r => r.Pax).ToList();
            roomFlowLayoutPanel.Controls.Clear();
            foreach (var room in sortedRoomList)
            {
                rooms.createRoomDisplay(room.RoomType, room.Rate, room.Image);
                rooms.roomButton.Tag = room;
                roomFlowLayoutPanel.Controls.Add(rooms.roomButton);
                rooms.roomButton.Click += RoomButton_Click;
            }
        }

        /* dito gumawa ako ng roombutton click event which is connected sha sa roomButton element sa room class tas pag clinick toh
           magloload ung data dun*/
        private void RoomButton_Click(object sender, EventArgs e)
        {
            //kukuhain nito ung index ng button na clinick
            var clickButton = (Guna2Button)sender;
            //tapos eto, nireretrieve nia ung mga data sa roomDataClass
            var clckRoom = (RoomData)clickButton.Tag;
            /*tas maglagay u ng mga elements (like bathroomLabel ganon basta ung mga need na elements) 
             * sa drag and drop tas populate mo dun ung data sa roomdata class like pede mong copy paste 
             * nlng ung nilagay ko sa titleLabel eg.: bedRoomLabel.Text = clckRoom.Bedroom.ToUpper();*/
            titleLabel.Text = clckRoom.RoomType.ToUpper();
            bedroomLabel.Text = "Bedroom: " + clckRoom.Bedroom.ToUpper();    
        }

        //pax numeric up/down - event
        private void paxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int selectedPax = (int)paxNumericUpDown.Value;

            IEnumerable<RoomData> filteredRooms;
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

    //roomData class
    public class RoomData
    {
        public string RoomType { get; set; }
        public double Rate { get; set; }
        public byte[] Image { get; set; }
        public int Pax { get; set; }
        public string Bathroom { get; set; }
        public string Bedroom { get; set; }
        public string Kitchen { get; set; }
        public string Technology { get; set; }
        public string General { get; set; }
    }
}
