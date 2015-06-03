namespace SWEN
{
    partial class AddStaff
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
            this.textBoxStaffName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBankAcc = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStaffLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDutyType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDoB = new System.Windows.Forms.DateTimePicker();
            this.Btn_AddStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStaffName
            // 
            this.textBoxStaffName.Location = new System.Drawing.Point(105, 6);
            this.textBoxStaffName.Name = "textBoxStaffName";
            this.textBoxStaffName.Size = new System.Drawing.Size(167, 20);
            this.textBoxStaffName.TabIndex = 0;
            this.textBoxStaffName.Text = "John Chan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date of birth";
            // 
            // textBoxBankAcc
            // 
            this.textBoxBankAcc.Location = new System.Drawing.Point(105, 110);
            this.textBoxBankAcc.Name = "textBoxBankAcc";
            this.textBoxBankAcc.Size = new System.Drawing.Size(167, 20);
            this.textBoxBankAcc.TabIndex = 4;
            this.textBoxBankAcc.Text = "015-74655-927";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(105, 84);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(167, 20);
            this.textBoxPhone.TabIndex = 5;
            this.textBoxPhone.Text = "81282389";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(105, 58);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(167, 20);
            this.textBoxAddress.TabIndex = 6;
            this.textBoxAddress.Text = "32 Geylang Lor 123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bank account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone number";
            // 
            // comboBoxStaffLevel
            // 
            this.comboBoxStaffLevel.FormattingEnabled = true;
            this.comboBoxStaffLevel.Items.AddRange(new object[] {
            "Administration",
            "Management",
            "Receptionist"});
            this.comboBoxStaffLevel.Location = new System.Drawing.Point(105, 136);
            this.comboBoxStaffLevel.Name = "comboBoxStaffLevel";
            this.comboBoxStaffLevel.Size = new System.Drawing.Size(167, 21);
            this.comboBoxStaffLevel.TabIndex = 10;
            this.comboBoxStaffLevel.Text = "Receptionist";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Staff level";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Duty type";
            // 
            // comboBoxDutyType
            // 
            this.comboBoxDutyType.FormattingEnabled = true;
            this.comboBoxDutyType.Items.AddRange(new object[] {
            "General maintenance",
            "Room maintenance",
            "Estate maintenance",
            "Security"});
            this.comboBoxDutyType.Location = new System.Drawing.Point(105, 163);
            this.comboBoxDutyType.Name = "comboBoxDutyType";
            this.comboBoxDutyType.Size = new System.Drawing.Size(167, 21);
            this.comboBoxDutyType.TabIndex = 12;
            this.comboBoxDutyType.Text = "Security";
            // 
            // dateTimePickerDoB
            // 
            this.dateTimePickerDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDoB.Location = new System.Drawing.Point(105, 32);
            this.dateTimePickerDoB.Name = "dateTimePickerDoB";
            this.dateTimePickerDoB.Size = new System.Drawing.Size(167, 20);
            this.dateTimePickerDoB.TabIndex = 38;
            this.dateTimePickerDoB.Value = new System.DateTime(1992, 6, 20, 0, 0, 0, 0);
            // 
            // Btn_AddStaff
            // 
            this.Btn_AddStaff.Location = new System.Drawing.Point(197, 194);
            this.Btn_AddStaff.Name = "Btn_AddStaff";
            this.Btn_AddStaff.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddStaff.TabIndex = 39;
            this.Btn_AddStaff.Text = "Add";
            this.Btn_AddStaff.UseVisualStyleBackColor = true;
            this.Btn_AddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 229);
            this.Controls.Add(this.Btn_AddStaff);
            this.Controls.Add(this.dateTimePickerDoB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDutyType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxStaffLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxBankAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStaffName);
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.Load += new System.EventHandler(this.AddStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStaffName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBankAcc;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStaffLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxDutyType;
        private System.Windows.Forms.DateTimePicker dateTimePickerDoB;
        private System.Windows.Forms.Button Btn_AddStaff;
    }
}