using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistainn_Kiosk.SelectRoomFolder
{
    internal class Rooms
    {
        //flowlayout elements 
        public Guna2Button roomButton;
        private Guna2PictureBox pictureBox;
        private Label roomTypeLabel;
        private Label rateLabel;

        //create room display - method
        public void createRoomDisplay(string roomType, double rate, byte[] imageBytes)
        {
            roomButton = new Guna2Button
            {
                Width = 183,
                Height = 239,
                BackColor = Color.Transparent,
                FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(225))))),
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
                BorderRadius = 10
            };
            roomButton.Controls.Add(pictureBox);

            roomTypeLabel = new Label
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

            rateLabel = new Label
            {
                Text = "₱" + rate.ToString("F2"),
                Size = new System.Drawing.Size(100, 17),
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49))))),
                Location = new System.Drawing.Point(17, 202)
            };
            roomButton.Controls.Add(rateLabel);
        }
    }
}
