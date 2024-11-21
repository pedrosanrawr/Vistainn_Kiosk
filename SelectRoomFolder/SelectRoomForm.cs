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

namespace Vistainn_Kiosk
{
    public partial class SelectRoomForm : Form
    {
        Database database = new Database();
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
            parentPage.loadForm(new ReviewForm(parentPage));
        }

        //back button - click
        private void backButton_Click(object sender, EventArgs e)
        {
            parentPage.loadForm(new CustomerInfoForm(parentPage));
        }

        //load room list - method
        private void loadRoomList()
        {
            string query = "SELECT RoomType, Rate, picture FROM room";
            MySqlConnection conn = new MySqlConnection(database.connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string roomType = reader["RoomType"].ToString();
                double rate = Convert.ToDouble(reader["Rate"]);
                byte[] imageBytes = reader["picture"] as byte[];

                createRoomDisplay(roomType, rate, imageBytes);
            }

        }

        //create room display - method
        private void createRoomDisplay(string roomType, double rate, byte[] imageBytes)
        {
            //elememts sa loob ng flowlayoutpanel

            //1. button
            Guna2Button roomButton = new Guna2Button
            {
                Width = 183,
                Height = 239,
                BackColor = Color.Transparent,
                FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(225))))),
                BorderRadius = 20,
                Padding = new Padding(5),
            };

            //2. picture box
            Guna2PictureBox pictureBox = new Guna2PictureBox
            {
                Width = 140,
                Height = 140,
                Image = imageBytes != null ? Image.FromStream(new MemoryStream(imageBytes)) : null,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(20, 20),
                BorderRadius = 10
            };
            roomButton.Controls.Add(pictureBox);

            //3. room type label
            Label roomTypeLabel = new Label
            {
                Text = roomType.ToUpper(),
                Width = 1000,
                Height = 19,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49))))),
                Location = new Point(16, 173),
                Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
            };
            roomButton.Controls.Add(roomTypeLabel);

            //4. rate label
            Label rateLabel = new Label
            {
                Text = "₱" + rate.ToString("F2"),
                Size = new System.Drawing.Size(100, 17),
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49))))),
                Location = new System.Drawing.Point(17, 202)
            };
            roomButton.Controls.Add(rateLabel);

            roomFlowLayoutPanel.Controls.Add(roomButton);
        }
    }
}

