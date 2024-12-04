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
            if (roomNoComboBox.SelectedIndex == -1 || roomNoComboBox.Text == "No Rooms Available")
            {
                MessageBox.Show("Please select a room before proceeding.", 
                    "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (string.IsNullOrEmpty(paymentMethodComboBox.Text) ||
                (paymentMethodComboBox.Text != "CREDIT CARD" && paymentMethodComboBox.Text != "CASH"))
            {
                MessageBox.Show("Please select a valid payment method (ID Card or Cash) before proceeding.", 
                    "Payment Method Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

                            SelectedRoomData.RoomType = titleLabel.Text; 
                SelectedRoomData.RoomNo = roomNoComboBox.SelectedItem.ToString(); 
                SelectedRoomData.PaymentMethod = paymentMethodComboBox.Text; 
                SelectedRoomData.Pax = (int)paxNumericUpDown.Value; 

                parentPage.loadForm(new AddOnsForm(parentPage));
        }

        //load room list - method
        private void loadRoomList()
        {
            string query = "SELECT * FROM room GROUP BY RoomType ORDER BY RoomCapacity";

            using (var conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                roomList.Clear();

                while (reader.Read())
                {
                    roomList.Add(new RoomData
                    {
                        RoomType = reader["RoomType"].ToString(),
                        RoomNo = reader["RoomNo"].ToString(),
                        Rate = Convert.ToDouble(reader["Rate"]),
                        Image = reader["Picture"] as byte[],
                        RoomCapacity = Convert.ToInt32(reader["RoomCapacity"]),
                        Bathroom = reader["Bathroom"].ToString(),
                        Bedroom = reader["BedRoom"].ToString(),
                        Kitchen = reader["Kitchen"].ToString(),
                        Technology = reader["Technology"].ToString(),
                        General = reader["General"].ToString()
                    });
                }
            }

            if (paxNumericUpDown.Value != 0)
            {
                var filteredRooms = roomList.Where(r => r.RoomCapacity == 1).ToList();
                displayRooms(filteredRooms);
            }
            else
            {
                displayRooms(new List<RoomData>());
            }
        }


        //display rooms - method
        private void displayRooms(IEnumerable<RoomData> roomsToDisplay)
        {
            roomFlowLayoutPanel.Controls.Clear();

            foreach (var room in roomsToDisplay)
            {
                rooms.createRoomDisplay(room.RoomType, room.Rate, room.Image);
                rooms.roomButton.Tag = room;
                rooms.roomButton.Click += RoomButton_Click;

                roomFlowLayoutPanel.Controls.Add(rooms.roomButton);
            }
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Guna2Button)sender;
            var clickedRoom = (RoomData)clickedButton.Tag;

            titleLabel.Text = clickedRoom.RoomType.ToUpper();
            bedroomLabel.Text = $"Bedroom: {clickedRoom.Bedroom.ToUpper()}";
            bathroomLabel.Text = $"Bathroom: {clickedRoom.Bathroom.ToUpper()}";
            kitchenLabel.Text = $"Kitchen: {clickedRoom.Kitchen.ToUpper()}";
            technologyLabel.Text = $"Technology: {clickedRoom.Technology.ToUpper()}";
            generalLabel.Text = $"General: {clickedRoom.General.ToUpper()}";
            rateLabel.Text = $"Rate: ₱{clickedRoom.Rate:0.00}";

            PopulateRoomNoComboBox(clickedRoom.RoomType);
        }

        private void PopulateRoomNoComboBox(string roomType)
        {
            string query = "SELECT RoomNo FROM room WHERE RoomType = @RoomType AND Availability = 'Available'";

            using (var conn = new MySqlConnection(database.connectionString))
            {
                conn.Open();
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoomType", roomType);
                var reader = cmd.ExecuteReader();

                roomNoComboBox.Items.Clear();

                while (reader.Read())
                {
                    roomNoComboBox.Items.Add(reader["RoomNo"].ToString());
                }

                if (roomNoComboBox.Items.Count > 0)
                {
                    roomNoComboBox.SelectedIndex = 0;
                }
                else
                {
                    roomNoComboBox.Text = "No Rooms Available";
                }
            }
        }

        //pax numeric up/down - event
        private void paxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            int selectedPax = (int)paxNumericUpDown.Value;

            if (selectedPax == 0)
            {
                displayRooms(new List<RoomData>());
                return;
            }

            var filteredRooms = roomList.Where(r => r.RoomCapacity == selectedPax).ToList();
            displayRooms(filteredRooms);
        }

    }

    //roomData class
    public class RoomData
    {
        public string RoomType { get; set; }
        public double Rate { get; set; }
        public byte[] Image { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomNo { get; set; }
        public string Availability { get; set; }
        public string Bathroom { get; set; }
        public string Bedroom { get; set; }
        public string Kitchen { get; set; }
        public string Technology { get; set; }
        public string General { get; set; }
    }

    public static class SelectedRoomData
    {
        public static string RoomType { get; set; }
        public static string RoomNo { get; set; }
        public static string PaymentMethod { get; set; }
        public static int Pax { get; set; }
    }
}
