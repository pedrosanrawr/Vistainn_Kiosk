using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Vistainn_Kiosk.SelectRoomFolder
{
    internal class Rooms
    {
        // flowLayoutPanel elements 
        public Guna2Button roomButton;
        private Guna2PictureBox pictureBox;
        private Label roomTypeLabel;
        private Label rateLabel;

        // create room display - method
        public void createRoomDisplay(string roomType, double rate, byte[] imageBytes)
        {
            roomButton = new Guna2Button
            {
                Width = 183,
                Height = 239,
                BackColor = Color.Transparent,
                FillColor = Color.FromArgb(237, 228, 225),
                BorderRadius = 20,
                Padding = new Padding(5),
            };

            pictureBox = new Guna2PictureBox
            {
                Width = 140,
                Height = 140,
                Image = imageBytes != null ? Image.FromStream(new MemoryStream(imageBytes)) : null,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = new Point(20, 20),
                BorderRadius = 10,
            };
            roomButton.Controls.Add(pictureBox);

            roomTypeLabel = new Label
            {
                Text = roomType.ToUpper(),
                Width = 1000,
                Height = 19,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.FromArgb(0, 54, 49),
                Location = new Point(16, 173),
                Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
            };
            roomButton.Controls.Add(roomTypeLabel);

            rateLabel = new Label
            {
                Text = "₱" + rate.ToString("F2"),
                Size = new Size(100, 17),
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Century Gothic", 9.75F, FontStyle.Regular),
                ForeColor = Color.FromArgb(0, 54, 49),
                Location = new Point(17, 202)
            };
            roomButton.Controls.Add(rateLabel);
        }
    }
}
