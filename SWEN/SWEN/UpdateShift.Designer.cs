namespace SWEN
{
    partial class UpdateShift
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxStaffID = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delonixRegiaDataSet = new SWEN.DelonixRegiaDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDutyType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRoomID = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCreateShift = new System.Windows.Forms.Button();
            this.staffTableAdapter = new SWEN.DelonixRegiaDataSetTableAdapters.StaffTableAdapter();
            this.roomTableAdapter = new SWEN.DelonixRegiaDataSetTableAdapters.RoomTableAdapter();
            this.comboBoxSelectDutyID = new System.Windows.Forms.ComboBox();
            this.housekeepingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.housekeepingTableAdapter = new SWEN.DelonixRegiaDataSetTableAdapters.HousekeepingTableAdapter();
            this.housekeepingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delonixRegiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStaffID
            // 
            this.comboBoxStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStaffID.FormattingEnabled = true;
            this.comboBoxStaffID.Location = new System.Drawing.Point(99, 128);
            this.comboBoxStaffID.Name = "comboBoxStaffID";
            this.comboBoxStaffID.Size = new System.Drawing.Size(264, 21);
            this.comboBoxStaffID.TabIndex = 20;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.delonixRegiaDataSet;
            // 
            // delonixRegiaDataSet
            // 
            this.delonixRegiaDataSet.DataSetName = "DelonixRegiaDataSet";
            this.delonixRegiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Staff ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Time";
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(99, 102);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerStartTime.TabIndex = 17;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(99, 76);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(264, 20);
            this.dateTimePickerDate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date";
            // 
            // comboBoxDutyType
            // 
            this.comboBoxDutyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDutyType.FormattingEnabled = true;
            this.comboBoxDutyType.Items.AddRange(new object[] {
            "General Maintenance",
            "Estate Maintenance",
            "Room Maintenance"});
            this.comboBoxDutyType.Location = new System.Drawing.Point(99, 48);
            this.comboBoxDutyType.Name = "comboBoxDutyType";
            this.comboBoxDutyType.Size = new System.Drawing.Size(264, 21);
            this.comboBoxDutyType.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Duty Type";
            // 
            // comboBoxRoomID
            // 
            this.comboBoxRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomID.FormattingEnabled = true;
            this.comboBoxRoomID.Location = new System.Drawing.Point(99, 155);
            this.comboBoxRoomID.Name = "comboBoxRoomID";
            this.comboBoxRoomID.Size = new System.Drawing.Size(264, 21);
            this.comboBoxRoomID.TabIndex = 22;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.delonixRegiaDataSet;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Room ID";
            // 
            // buttonCreateShift
            // 
            this.buttonCreateShift.Location = new System.Drawing.Point(13, 198);
            this.buttonCreateShift.Name = "buttonCreateShift";
            this.buttonCreateShift.Size = new System.Drawing.Size(350, 23);
            this.buttonCreateShift.TabIndex = 23;
            this.buttonCreateShift.Text = "Update";
            this.buttonCreateShift.UseVisualStyleBackColor = true;
            this.buttonCreateShift.Click += new System.EventHandler(this.buttonUpdateShift_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxSelectDutyID
            // 
            this.comboBoxSelectDutyID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectDutyID.FormattingEnabled = true;
            this.comboBoxSelectDutyID.Location = new System.Drawing.Point(99, 12);
            this.comboBoxSelectDutyID.Name = "comboBoxSelectDutyID";
            this.comboBoxSelectDutyID.Size = new System.Drawing.Size(264, 21);
            this.comboBoxSelectDutyID.TabIndex = 25;
            this.comboBoxSelectDutyID.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSelectDutyID_SelectionChangeCommitted);
            // 
            // housekeepingBindingSource
            // 
            this.housekeepingBindingSource.DataMember = "Housekeeping";
            this.housekeepingBindingSource.DataSource = this.delonixRegiaDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Select Duty ID";
            // 
            // housekeepingTableAdapter
            // 
            this.housekeepingTableAdapter.ClearBeforeFill = true;
            // 
            // housekeepingBindingSource1
            // 
            this.housekeepingBindingSource1.DataMember = "Housekeeping";
            this.housekeepingBindingSource1.DataSource = this.delonixRegiaDataSet;
            // 
            // UpdateShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 237);
            this.Controls.Add(this.comboBoxSelectDutyID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDutyType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRoomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCreateShift);
            this.Name = "UpdateShift";
            this.Text = "UpdateShift";
            this.Load += new System.EventHandler(this.UpdateShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delonixRegiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.housekeepingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStaffID;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DelonixRegiaDataSet delonixRegiaDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDutyType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRoomID;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCreateShift;
        private DelonixRegiaDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private DelonixRegiaDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxSelectDutyID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource housekeepingBindingSource;
        private DelonixRegiaDataSetTableAdapters.HousekeepingTableAdapter housekeepingTableAdapter;
        private System.Windows.Forms.BindingSource housekeepingBindingSource1;
    }
}