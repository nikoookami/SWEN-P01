﻿namespace SWEN
{
    partial class Home
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
            this.buttonRoomBooking = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelOccupiedRooms = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNoOfStaff = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRoomBooking
            // 
            this.buttonRoomBooking.Location = new System.Drawing.Point(242, 82);
            this.buttonRoomBooking.Name = "buttonRoomBooking";
            this.buttonRoomBooking.Size = new System.Drawing.Size(227, 64);
            this.buttonRoomBooking.TabIndex = 0;
            this.buttonRoomBooking.Text = "ROOM BOOKING AN AVAILABILITY";
            this.buttonRoomBooking.UseVisualStyleBackColor = true;
            this.buttonRoomBooking.Click += new System.EventHandler(this.buttonRoomBooking_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "HOUSEKEEPING AND STAFF MANAGEMENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonHouseStaff_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "REPORTING";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(394, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Access level: Administrator";
            this.label1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 64);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(3, 5);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(101, 13);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Name: David Wang";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelOccupiedRooms);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 64);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Check-in/Check-out: 7/3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Check-in/Check-out: 7/3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. of guests: 35";
            // 
            // labelOccupiedRooms
            // 
            this.labelOccupiedRooms.AutoSize = true;
            this.labelOccupiedRooms.Location = new System.Drawing.Point(3, 3);
            this.labelOccupiedRooms.Name = "labelOccupiedRooms";
            this.labelOccupiedRooms.Size = new System.Drawing.Size(124, 13);
            this.labelOccupiedRooms.TabIndex = 4;
            this.labelOccupiedRooms.Text = "Occupied Rooms: 23/40";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.labelNoOfStaff);
            this.panel3.Location = new System.Drawing.Point(12, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 64);
            this.panel3.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Overtime: 0";
            this.label11.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Absence: 0";
            this.label5.Visible = false;
            // 
            // labelNoOfStaff
            // 
            this.labelNoOfStaff.AutoSize = true;
            this.labelNoOfStaff.Location = new System.Drawing.Point(3, 3);
            this.labelNoOfStaff.Name = "labelNoOfStaff";
            this.labelNoOfStaff.Size = new System.Drawing.Size(71, 13);
            this.labelNoOfStaff.TabIndex = 4;
            this.labelNoOfStaff.Text = "No. of staff: 0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(12, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 64);
            this.panel4.TabIndex = 7;
            this.panel4.Visible = false;
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "On 12 Jun 2015";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "On 12 Jun 2015";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Upcoming: Weekly staff shift report";
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Last report: Monthly guest report";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(242, 292);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 67);
            this.button5.TabIndex = 9;
            this.button5.Text = "SALES AND CASHIER";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Location = new System.Drawing.Point(12, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 64);
            this.panel5.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AllowDrop = true;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Transcation:10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Sales module";
            // 
            // label14
            // 
            this.label14.AllowDrop = true;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Staff ID:1234";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 420);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRoomBooking);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRoomBooking;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelOccupiedRooms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelNoOfStaff;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}