namespace SWEN_Assignment_3.Reports
{
    partial class ReportMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnHousekeeping = new System.Windows.Forms.Button();
            this.btnOverview = new System.Windows.Forms.Button();
            this.btnRoomOccupancy = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports Menu";
            // 
            // btnHousekeeping
            // 
            this.btnHousekeeping.Location = new System.Drawing.Point(114, 156);
            this.btnHousekeeping.Name = "btnHousekeeping";
            this.btnHousekeeping.Size = new System.Drawing.Size(265, 51);
            this.btnHousekeeping.TabIndex = 2;
            this.btnHousekeeping.Text = "Housekeeping Report";
            this.btnHousekeeping.UseVisualStyleBackColor = true;
            this.btnHousekeeping.Click += new System.EventHandler(this.btnHousekeeping_Click);
            // 
            // btnOverview
            // 
            this.btnOverview.Location = new System.Drawing.Point(114, 213);
            this.btnOverview.Name = "btnOverview";
            this.btnOverview.Size = new System.Drawing.Size(265, 51);
            this.btnOverview.TabIndex = 3;
            this.btnOverview.Text = "Overview Report";
            this.btnOverview.UseVisualStyleBackColor = true;
            this.btnOverview.Click += new System.EventHandler(this.btnOverview_Click);
            // 
            // btnRoomOccupancy
            // 
            this.btnRoomOccupancy.Location = new System.Drawing.Point(114, 270);
            this.btnRoomOccupancy.Name = "btnRoomOccupancy";
            this.btnRoomOccupancy.Size = new System.Drawing.Size(265, 51);
            this.btnRoomOccupancy.TabIndex = 4;
            this.btnRoomOccupancy.Text = "Room Occupancy Report";
            this.btnRoomOccupancy.UseVisualStyleBackColor = true;
            this.btnRoomOccupancy.Click += new System.EventHandler(this.btnRoomOccupancy_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(114, 99);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(265, 51);
            this.btnGeneral.TabIndex = 5;
            this.btnGeneral.Text = "General Report";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(114, 327);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(265, 50);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.Text = "Room Status Report";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(12, 9);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 48);
            this.btnHome.TabIndex = 7;
            this.btnHome.Text = "Back to Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 417);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnGeneral);
            this.Controls.Add(this.btnRoomOccupancy);
            this.Controls.Add(this.btnOverview);
            this.Controls.Add(this.btnHousekeeping);
            this.Controls.Add(this.label1);
            this.Name = "ReportMenu";
            this.Text = "ReportMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHousekeeping;
        private System.Windows.Forms.Button btnOverview;
        private System.Windows.Forms.Button btnRoomOccupancy;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnHome;
    }
}