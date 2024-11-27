using System.IO;
using System.Windows.Forms;
using System.Windows;

namespace Vistainn_Kiosk
{
    partial class SelectRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roomFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.paxNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.paxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BorderColor = System.Drawing.Color.Transparent;
            this.nextButton.BorderRadius = 20;
            this.nextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.nextButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.nextButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.nextButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.nextButton.Location = new System.Drawing.Point(893, 567);
            this.nextButton.Name = "nextButton";
            this.nextButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.nextButton.Size = new System.Drawing.Size(143, 45);
            this.nextButton.TabIndex = 17;
            this.nextButton.Text = "NEXT";
            this.nextButton.UseTransparentBackground = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.BorderThickness = 3;
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.Location = new System.Drawing.Point(555, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(589, 653);
            this.guna2Panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(141, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 41);
            this.label1.TabIndex = 20;
            this.label1.Text = "SELECT ROOM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomFlowLayoutPanel
            // 
            this.roomFlowLayoutPanel.AutoScroll = true;
            this.roomFlowLayoutPanel.Location = new System.Drawing.Point(62, 125);
            this.roomFlowLayoutPanel.Name = "roomFlowLayoutPanel";
            this.roomFlowLayoutPanel.Size = new System.Drawing.Size(427, 487);
            this.roomFlowLayoutPanel.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "NO. OF GUESTS:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paxNumericUpDown
            // 
            this.paxNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.paxNumericUpDown.BorderRadius = 12;
            this.paxNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paxNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paxNumericUpDown.Location = new System.Drawing.Point(181, 77);
            this.paxNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.paxNumericUpDown.Name = "paxNumericUpDown";
            this.paxNumericUpDown.Size = new System.Drawing.Size(96, 29);
            this.paxNumericUpDown.TabIndex = 23;
            this.paxNumericUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.paxNumericUpDown.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.paxNumericUpDown.ValueChanged += new System.EventHandler(this.paxNumericUpDown_ValueChanged);
            // 
            // SelectRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1098, 652);
            this.Controls.Add(this.paxNumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomFlowLayoutPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectRoomForm";
            this.Text = "SelectRoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.paxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button nextButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.FlowLayoutPanel roomFlowLayoutPanel;
        private Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown paxNumericUpDown;
    }
}