namespace SWEN
{
    partial class CancelShift
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
            this.comboBoxSelectShiftID = new System.Windows.Forms.ComboBox();
            this.ConfirmCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select shift ID";
            // 
            // comboBoxSelectShiftID
            // 
            this.comboBoxSelectShiftID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectShiftID.FormattingEnabled = true;
            this.comboBoxSelectShiftID.Location = new System.Drawing.Point(105, 10);
            this.comboBoxSelectShiftID.Name = "comboBoxSelectShiftID";
            this.comboBoxSelectShiftID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectShiftID.TabIndex = 1;
            // 
            // ConfirmCancel
            // 
            this.ConfirmCancel.Location = new System.Drawing.Point(105, 61);
            this.ConfirmCancel.Name = "ConfirmCancel";
            this.ConfirmCancel.Size = new System.Drawing.Size(75, 23);
            this.ConfirmCancel.TabIndex = 2;
            this.ConfirmCancel.Text = "Confirm";
            this.ConfirmCancel.UseVisualStyleBackColor = true;
            this.ConfirmCancel.Click += new System.EventHandler(this.ConfirmCancel_Click);
            // 
            // CancelShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 96);
            this.Controls.Add(this.ConfirmCancel);
            this.Controls.Add(this.comboBoxSelectShiftID);
            this.Controls.Add(this.label1);
            this.Name = "CancelShift";
            this.Text = "CancelShift";
            this.Load += new System.EventHandler(this.CancelShift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectShiftID;
        private System.Windows.Forms.Button ConfirmCancel;
    }
}