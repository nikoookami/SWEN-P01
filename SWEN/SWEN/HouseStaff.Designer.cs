namespace SWEN
{
    partial class HouseStaff
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.buttonBackToHome = new System.Windows.Forms.Button();
            this.buttonCancelShift = new System.Windows.Forms.Button();
            this.buttonUpdateShift = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.staffid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bankNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.housekeepingid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDeleteStaff = new System.Windows.Forms.Button();
            this.buttonCreateShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBackToHome
            // 
            this.buttonBackToHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBackToHome.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBackToHome.Location = new System.Drawing.Point(920, 12);
            this.buttonBackToHome.Name = "buttonBackToHome";
            this.buttonBackToHome.Size = new System.Drawing.Size(96, 23);
            this.buttonBackToHome.TabIndex = 5;
            this.buttonBackToHome.Text = "Back to Home";
            this.buttonBackToHome.UseVisualStyleBackColor = false;
            this.buttonBackToHome.Click += new System.EventHandler(this.buttonBackToHome_Click);
            // 
            // buttonCancelShift
            // 
            this.buttonCancelShift.Location = new System.Drawing.Point(12, 215);
            this.buttonCancelShift.Name = "buttonCancelShift";
            this.buttonCancelShift.Size = new System.Drawing.Size(140, 23);
            this.buttonCancelShift.TabIndex = 8;
            this.buttonCancelShift.Text = "Cancel shift";
            this.buttonCancelShift.UseVisualStyleBackColor = true;
            this.buttonCancelShift.Click += new System.EventHandler(this.buttonCancelShift_Click);
            // 
            // buttonUpdateShift
            // 
            this.buttonUpdateShift.Location = new System.Drawing.Point(12, 186);
            this.buttonUpdateShift.Name = "buttonUpdateShift";
            this.buttonUpdateShift.Size = new System.Drawing.Size(140, 23);
            this.buttonUpdateShift.TabIndex = 7;
            this.buttonUpdateShift.Text = "Update shift";
            this.buttonUpdateShift.UseVisualStyleBackColor = true;
            this.buttonUpdateShift.Click += new System.EventHandler(this.buttonUpdateShift_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add staff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.staffid,
            this.fullname,
            this.dob,
            this.bankNo,
            this.address,
            this.telno,
            this.housekeepingid,
            this.username});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(158, 70);
            this.listView1.Margin = new System.Windows.Forms.Padding(50, 50, 3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(336, 470);
            this.listView1.TabIndex = 9;
            this.listView1.TileSize = new System.Drawing.Size(1, 1);
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // staffid
            // 
            this.staffid.Text = "Staff ID";
            this.staffid.Width = 48;
            // 
            // fullname
            // 
            this.fullname.Text = "Full Name";
            this.fullname.Width = 59;
            // 
            // dob
            // 
            this.dob.Text = "Birth Date";
            this.dob.Width = 59;
            // 
            // bankNo
            // 
            this.bankNo.Text = "Bank Account";
            this.bankNo.Width = 80;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 50;
            // 
            // telno
            // 
            this.telno.Text = "Telephone Number";
            // 
            // housekeepingid
            // 
            this.housekeepingid.Text = "Housekeeping ID";
            // 
            // username
            // 
            this.username.Text = "Username";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Update/View staff details";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonUpdateStaff_Click);
            // 
            // calendar1
            // 
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calendar1.Location = new System.Drawing.Point(500, 70);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(516, 470);
            this.calendar1.TabIndex = 13;
            this.calendar1.Text = "calendar1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Staff List";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(734, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Shift schedule";
            // 
            // buttonDeleteStaff
            // 
            this.buttonDeleteStaff.Location = new System.Drawing.Point(13, 128);
            this.buttonDeleteStaff.Name = "buttonDeleteStaff";
            this.buttonDeleteStaff.Size = new System.Drawing.Size(139, 23);
            this.buttonDeleteStaff.TabIndex = 16;
            this.buttonDeleteStaff.Text = "Delete staff";
            this.buttonDeleteStaff.UseVisualStyleBackColor = true;
            this.buttonDeleteStaff.Click += new System.EventHandler(this.buttonDeleteStaff_Click);
            // 
            // buttonCreateShift
            // 
            this.buttonCreateShift.Location = new System.Drawing.Point(12, 157);
            this.buttonCreateShift.Name = "buttonCreateShift";
            this.buttonCreateShift.Size = new System.Drawing.Size(140, 23);
            this.buttonCreateShift.TabIndex = 17;
            this.buttonCreateShift.Text = "Create shift";
            this.buttonCreateShift.UseVisualStyleBackColor = true;
            this.buttonCreateShift.Click += new System.EventHandler(this.buttonCreateShift_Click);
            // 
            // HouseStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 552);
            this.Controls.Add(this.buttonCreateShift);
            this.Controls.Add(this.buttonDeleteStaff);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonCancelShift);
            this.Controls.Add(this.buttonUpdateShift);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBackToHome);
            this.Name = "HouseStaff";
            this.Text = "Housekeeping and Staff management";
            this.Load += new System.EventHandler(this.HouseStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToHome;
        private System.Windows.Forms.Button buttonCancelShift;
        private System.Windows.Forms.Button buttonUpdateShift;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader staffid;
        private System.Windows.Forms.ColumnHeader fullname;
        private System.Windows.Forms.ColumnHeader dob;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader bankNo;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader telno;
        private System.Windows.Forms.ColumnHeader housekeepingid;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.Button buttonDeleteStaff;
        private System.Windows.Forms.Button buttonCreateShift;
    }
}