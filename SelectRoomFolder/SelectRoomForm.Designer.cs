using System.IO;
using System.Windows.Forms;
using System.Windows;
using System.Drawing;

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
            this.rateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.paymentMethodComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.roomNoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.generalLabel = new System.Windows.Forms.Label();
            this.kitchenLabel = new System.Windows.Forms.Label();
            this.technologyLabel = new System.Windows.Forms.Label();
            this.bathroomLabel = new System.Windows.Forms.Label();
            this.bedroomLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.paxNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2Panel2.SuspendLayout();
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
            this.guna2Panel2.Controls.Add(this.rateLabel);
            this.guna2Panel2.Controls.Add(this.label9);
            this.guna2Panel2.Controls.Add(this.paymentMethodComboBox);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.roomNoComboBox);
            this.guna2Panel2.Controls.Add(this.generalLabel);
            this.guna2Panel2.Controls.Add(this.kitchenLabel);
            this.guna2Panel2.Controls.Add(this.technologyLabel);
            this.guna2Panel2.Controls.Add(this.bathroomLabel);
            this.guna2Panel2.Controls.Add(this.bedroomLabel);
            this.guna2Panel2.Controls.Add(this.DescriptionLabel);
            this.guna2Panel2.Controls.Add(this.titleLabel);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.guna2Panel2.Location = new System.Drawing.Point(555, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(565, 653);
            this.guna2Panel2.TabIndex = 19;
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.BackColor = System.Drawing.Color.Transparent;
            this.rateLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.rateLabel.Location = new System.Drawing.Point(38, 345);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(0, 28);
            this.rateLabel.TabIndex = 43;
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label9.Location = new System.Drawing.Point(41, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "SELECT PAYMENT METHOD*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paymentMethodComboBox
            // 
            this.paymentMethodComboBox.AutoRoundedCorners = true;
            this.paymentMethodComboBox.BackColor = System.Drawing.Color.Transparent;
            this.paymentMethodComboBox.BorderColor = System.Drawing.Color.Gray;
            this.paymentMethodComboBox.BorderRadius = 17;
            this.paymentMethodComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.paymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentMethodComboBox.FillColor = System.Drawing.Color.Gainsboro;
            this.paymentMethodComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.paymentMethodComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.paymentMethodComboBox.ItemHeight = 30;
            this.paymentMethodComboBox.Items.AddRange(new object[] {
            "CASH"});
            this.paymentMethodComboBox.Location = new System.Drawing.Point(44, 509);
            this.paymentMethodComboBox.Name = "paymentMethodComboBox";
            this.paymentMethodComboBox.Size = new System.Drawing.Size(179, 36);
            this.paymentMethodComboBox.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.label8.Location = new System.Drawing.Point(40, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "SELECT ROOM NUMBER*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomNoComboBox
            // 
            this.roomNoComboBox.AutoRoundedCorners = true;
            this.roomNoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.roomNoComboBox.BorderColor = System.Drawing.Color.Gray;
            this.roomNoComboBox.BorderRadius = 17;
            this.roomNoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roomNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomNoComboBox.FillColor = System.Drawing.Color.Gainsboro;
            this.roomNoComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNoComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomNoComboBox.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.roomNoComboBox.ItemHeight = 30;
            this.roomNoComboBox.Location = new System.Drawing.Point(43, 427);
            this.roomNoComboBox.Name = "roomNoComboBox";
            this.roomNoComboBox.Size = new System.Drawing.Size(179, 36);
            this.roomNoComboBox.TabIndex = 37;
            // 
            // generalLabel
            // 
            this.generalLabel.AutoSize = true;
            this.generalLabel.BackColor = System.Drawing.Color.Transparent;
            this.generalLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.generalLabel.Location = new System.Drawing.Point(38, 301);
            this.generalLabel.Name = "generalLabel";
            this.generalLabel.Size = new System.Drawing.Size(0, 30);
            this.generalLabel.TabIndex = 30;
            this.generalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kitchenLabel
            // 
            this.kitchenLabel.AutoSize = true;
            this.kitchenLabel.BackColor = System.Drawing.Color.Transparent;
            this.kitchenLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.kitchenLabel.Location = new System.Drawing.Point(38, 257);
            this.kitchenLabel.Name = "kitchenLabel";
            this.kitchenLabel.Size = new System.Drawing.Size(0, 30);
            this.kitchenLabel.TabIndex = 29;
            this.kitchenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // technologyLabel
            // 
            this.technologyLabel.AutoSize = true;
            this.technologyLabel.BackColor = System.Drawing.Color.Transparent;
            this.technologyLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technologyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.technologyLabel.Location = new System.Drawing.Point(38, 213);
            this.technologyLabel.Name = "technologyLabel";
            this.technologyLabel.Size = new System.Drawing.Size(0, 30);
            this.technologyLabel.TabIndex = 28;
            this.technologyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bathroomLabel
            // 
            this.bathroomLabel.AutoSize = true;
            this.bathroomLabel.BackColor = System.Drawing.Color.Transparent;
            this.bathroomLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bathroomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.bathroomLabel.Location = new System.Drawing.Point(38, 169);
            this.bathroomLabel.Name = "bathroomLabel";
            this.bathroomLabel.Size = new System.Drawing.Size(0, 30);
            this.bathroomLabel.TabIndex = 27;
            this.bathroomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bedroomLabel
            // 
            this.bedroomLabel.AutoSize = true;
            this.bedroomLabel.BackColor = System.Drawing.Color.Transparent;
            this.bedroomLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bedroomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.bedroomLabel.Location = new System.Drawing.Point(38, 125);
            this.bedroomLabel.Name = "bedroomLabel";
            this.bedroomLabel.Size = new System.Drawing.Size(0, 30);
            this.bedroomLabel.TabIndex = 26;
            this.bedroomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(38, 77);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(183, 32);
            this.DescriptionLabel.TabIndex = 25;
            this.DescriptionLabel.Text = "DESCRIPTION";
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.titleLabel.Location = new System.Drawing.Point(37, 21);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(212, 41);
            this.titleLabel.TabIndex = 24;
            this.titleLabel.Text = "ROOM TYPE";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.paxNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.paxNumericUpDown.Location = new System.Drawing.Point(181, 77);
            this.paxNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.paxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.paxNumericUpDown.Name = "paxNumericUpDown";
            this.paxNumericUpDown.Size = new System.Drawing.Size(96, 29);
            this.paxNumericUpDown.TabIndex = 23;
            this.paxNumericUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.paxNumericUpDown.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(144)))), ((int)(((byte)(36)))));
            this.paxNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectRoomForm";
            this.Text = "SelectRoomForm";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
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
        public Label titleLabel;
        public Label DescriptionLabel;
        public Label bedroomLabel;
        public Label rateLabel;
        public Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox paymentMethodComboBox;
        public Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox roomNoComboBox;
        public Label generalLabel;
        public Label kitchenLabel;
        public Label technologyLabel;
        public Label bathroomLabel;
    }
}