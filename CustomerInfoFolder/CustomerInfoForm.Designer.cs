namespace Vistainn_Kiosk
{
    partial class CustomerInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkInDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.checkOutDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
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
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.nextButton.Location = new System.Drawing.Point(893, 567);
            this.nextButton.Name = "nextButton";
            this.nextButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(37)))), ((int)(((byte)(31)))));
            this.nextButton.Size = new System.Drawing.Size(143, 45);
            this.nextButton.TabIndex = 13;
            this.nextButton.Text = "NEXT";
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(326, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "CUSTOMER INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(417, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "FULL NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.AcceptsReturn = true;
            this.fullNameTextBox.BorderRadius = 10;
            this.fullNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullNameTextBox.DefaultText = "";
            this.fullNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.fullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fullNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.fullNameTextBox.Location = new System.Drawing.Point(420, 178);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.PasswordChar = '\0';
            this.fullNameTextBox.PlaceholderText = "";
            this.fullNameTextBox.SelectedText = "";
            this.fullNameTextBox.Size = new System.Drawing.Size(262, 26);
            this.fullNameTextBox.TabIndex = 60;
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.BorderRadius = 10;
            this.phoneNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNoTextBox.DefaultText = "";
            this.phoneNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.phoneNoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.phoneNoTextBox.Location = new System.Drawing.Point(420, 248);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.PasswordChar = '\0';
            this.phoneNoTextBox.PlaceholderText = "";
            this.phoneNoTextBox.SelectedText = "";
            this.phoneNoTextBox.Size = new System.Drawing.Size(262, 26);
            this.phoneNoTextBox.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(417, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 61;
            this.label3.Text = "PHONE NUMBER";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.BorderRadius = 10;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.emailTextBox.Location = new System.Drawing.Point(420, 317);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(262, 26);
            this.emailTextBox.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(417, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 63;
            this.label4.Text = "EMAIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(417, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "CHECK-IN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.checkInDateTimePicker.BorderRadius = 10;
            this.checkInDateTimePicker.Checked = true;
            this.checkInDateTimePicker.FillColor = System.Drawing.Color.DimGray;
            this.checkInDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkInDateTimePicker.Location = new System.Drawing.Point(420, 387);
            this.checkInDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkInDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(262, 30);
            this.checkInDateTimePicker.TabIndex = 110;
            this.checkInDateTimePicker.Value = new System.DateTime(2024, 11, 16, 9, 16, 16, 375);
            // 
            // checkOutDateTimePicker
            // 
            this.checkOutDateTimePicker.BackColor = System.Drawing.Color.Transparent;
            this.checkOutDateTimePicker.BorderRadius = 10;
            this.checkOutDateTimePicker.Checked = true;
            this.checkOutDateTimePicker.FillColor = System.Drawing.Color.DimGray;
            this.checkOutDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.checkOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(420, 465);
            this.checkOutDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.checkOutDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(262, 30);
            this.checkOutDateTimePicker.TabIndex = 112;
            this.checkOutDateTimePicker.Value = new System.DateTime(2024, 11, 16, 9, 16, 16, 375);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(49)))));
            this.label6.Location = new System.Drawing.Point(417, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 111;
            this.label6.Text = "CHECK-OUT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(1098, 652);
            this.Controls.Add(this.checkOutDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkInDateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CustomerInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox fullNameTextBox;
        public Guna.UI2.WinForms.Guna2TextBox phoneNoTextBox;
        private System.Windows.Forms.Label label3;
        public Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2DateTimePicker checkInDateTimePicker;
        public Guna.UI2.WinForms.Guna2DateTimePicker checkOutDateTimePicker;
        private System.Windows.Forms.Label label6;
    }
}