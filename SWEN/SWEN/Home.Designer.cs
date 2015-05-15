namespace Login
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
            this.SuspendLayout();
            // 
            // buttonRoomBooking
            // 
            this.buttonRoomBooking.Location = new System.Drawing.Point(228, 40);
            this.buttonRoomBooking.Name = "buttonRoomBooking";
            this.buttonRoomBooking.Size = new System.Drawing.Size(227, 69);
            this.buttonRoomBooking.TabIndex = 0;
            this.buttonRoomBooking.Text = "ROOM BOOKING AN AVAILABILITY";
            this.buttonRoomBooking.UseVisualStyleBackColor = true;
            this.buttonRoomBooking.Click += new System.EventHandler(this.buttonRoomBooking_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(228, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(227, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "HOUSEKEEPING AND STAFF MANAGEMENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonHouseStaff_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(228, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "REPORTING";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(596, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 297);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRoomBooking);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRoomBooking;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}