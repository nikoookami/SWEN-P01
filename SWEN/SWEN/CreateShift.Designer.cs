namespace SWEN
{
    partial class CreateShift
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDutyType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStaffID = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delonixRegiaDataSet = new SWEN.DelonixRegiaDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRoomID = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCreateShift = new System.Windows.Forms.Button();
            this.staffTableAdapter = new SWEN.DelonixRegiaDataSetTableAdapters.StaffTableAdapter();
            this.roomTableAdapter = new SWEN.DelonixRegiaDataSetTableAdapters.RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delonixRegiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Duty Type";
            // 
            // comboBoxDutyType
            // 
            this.comboBoxDutyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDutyType.FormattingEnabled = true;
            this.comboBoxDutyType.Items.AddRange(new object[] {
            "General Maintenance",
            "Estate Maintenance",
            "Room Maintenance"});
            this.comboBoxDutyType.Location = new System.Drawing.Point(82, 10);
            this.comboBoxDutyType.Name = "comboBoxDutyType";
            this.comboBoxDutyType.Size = new System.Drawing.Size(264, 21);
            this.comboBoxDutyType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(82, 38);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(264, 20);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(82, 64);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerStartTime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Staff ID";
            // 
            // comboBoxStaffID
            // 
            this.comboBoxStaffID.DataSource = this.staffBindingSource;
            this.comboBoxStaffID.DisplayMember = "staffid";
            this.comboBoxStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStaffID.FormattingEnabled = true;
            this.comboBoxStaffID.Location = new System.Drawing.Point(82, 90);
            this.comboBoxStaffID.Name = "comboBoxStaffID";
            this.comboBoxStaffID.Size = new System.Drawing.Size(264, 21);
            this.comboBoxStaffID.TabIndex = 8;
            this.comboBoxStaffID.ValueMember = "staffid";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Room ID";
            // 
            // comboBoxRoomID
            // 
            this.comboBoxRoomID.DataSource = this.roomBindingSource;
            this.comboBoxRoomID.DisplayMember = "roomid";
            this.comboBoxRoomID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomID.FormattingEnabled = true;
            this.comboBoxRoomID.Location = new System.Drawing.Point(82, 117);
            this.comboBoxRoomID.Name = "comboBoxRoomID";
            this.comboBoxRoomID.Size = new System.Drawing.Size(264, 21);
            this.comboBoxRoomID.TabIndex = 10;
            this.comboBoxRoomID.ValueMember = "roomid";
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.delonixRegiaDataSet;
            // 
            // buttonCreateShift
            // 
            this.buttonCreateShift.Location = new System.Drawing.Point(12, 160);
            this.buttonCreateShift.Name = "buttonCreateShift";
            this.buttonCreateShift.Size = new System.Drawing.Size(334, 23);
            this.buttonCreateShift.TabIndex = 12;
            this.buttonCreateShift.Text = "Create";
            this.buttonCreateShift.UseVisualStyleBackColor = true;
            this.buttonCreateShift.Click += new System.EventHandler(this.buttonCreateShift_Click);
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // CreateShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 195);
            this.Controls.Add(this.buttonCreateShift);
            this.Controls.Add(this.comboBoxRoomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxStaffID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxDutyType);
            this.Controls.Add(this.label1);
            this.Name = "CreateShift";
            this.Text = "CreateShift";
            this.Load += new System.EventHandler(this.CreateShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delonixRegiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDutyType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStaffID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRoomID;
        private System.Windows.Forms.Button buttonCreateShift;
        private DelonixRegiaDataSet delonixRegiaDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DelonixRegiaDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private DelonixRegiaDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
    }
}