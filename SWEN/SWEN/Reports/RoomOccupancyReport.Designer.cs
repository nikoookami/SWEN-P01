﻿namespace SWEN_Assignment_3.Reports
{
    partial class RoomOccupancyReport
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnWeekly = new System.Windows.Forms.Button();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.wbOutput = new System.Windows.Forms.WebBrowser();
            this.sfdDocSave = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Daily";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 32);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 48);
            this.label5.TabIndex = 9;
            this.label5.Text = "Room Occupancy Report";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(90, 111);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtpStartDate.TabIndex = 10;
            // 
            // btnWeekly
            // 
            this.btnWeekly.Location = new System.Drawing.Point(314, 169);
            this.btnWeekly.Name = "btnWeekly";
            this.btnWeekly.Size = new System.Drawing.Size(88, 41);
            this.btnWeekly.TabIndex = 13;
            this.btnWeekly.Text = "Weekly";
            this.btnWeekly.UseVisualStyleBackColor = true;
            this.btnWeekly.Click += new System.EventHandler(this.btnWeekly_Click);
            // 
            // btnMonthly
            // 
            this.btnMonthly.Location = new System.Drawing.Point(623, 169);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(88, 41);
            this.btnMonthly.TabIndex = 14;
            this.btnMonthly.Text = "Monthly";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(80, 640);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 41);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save As";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(539, 640);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 41);
            this.btnPrint.TabIndex = 16;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // wbOutput
            // 
            this.wbOutput.Location = new System.Drawing.Point(13, 216);
            this.wbOutput.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbOutput.Name = "wbOutput";
            this.wbOutput.Size = new System.Drawing.Size(737, 418);
            this.wbOutput.TabIndex = 17;
            // 
            // sfdDocSave
            // 
            this.sfdDocSave.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdDocSave_FileOk);
            // 
            // RoomOccupancyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 693);
            this.Controls.Add(this.wbOutput);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.btnWeekly);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "RoomOccupancyReport";
            this.Text = "RoomOccupancyReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnWeekly;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.WebBrowser wbOutput;
        private System.Windows.Forms.SaveFileDialog sfdDocSave;
    }
}