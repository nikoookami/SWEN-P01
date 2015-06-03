namespace SWEN
{
    partial class DeleteStaff
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
            this.comboBoxSelectStaffID = new System.Windows.Forms.ComboBox();
            this.labelSelectStaffID = new System.Windows.Forms.Label();
            this.buttonConfirmDelete = new System.Windows.Forms.Button();
            this.delonixRegiaDataSet = new SWEN.DelonixRegiaDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new SWEN.DelonixRegiaDataSetTableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.delonixRegiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSelectStaffID
            // 
            this.comboBoxSelectStaffID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSelectStaffID.DataSource = this.staffBindingSource;
            this.comboBoxSelectStaffID.DisplayMember = "staffid";
            this.comboBoxSelectStaffID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectStaffID.FormattingEnabled = true;
            this.comboBoxSelectStaffID.Location = new System.Drawing.Point(93, 10);
            this.comboBoxSelectStaffID.Name = "comboBoxSelectStaffID";
            this.comboBoxSelectStaffID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectStaffID.TabIndex = 0;
            this.comboBoxSelectStaffID.ValueMember = "staffid";
            // 
            // labelSelectStaffID
            // 
            this.labelSelectStaffID.AutoSize = true;
            this.labelSelectStaffID.Location = new System.Drawing.Point(13, 13);
            this.labelSelectStaffID.Name = "labelSelectStaffID";
            this.labelSelectStaffID.Size = new System.Drawing.Size(74, 13);
            this.labelSelectStaffID.TabIndex = 1;
            this.labelSelectStaffID.Text = "Select staff ID";
            // 
            // buttonConfirmDelete
            // 
            this.buttonConfirmDelete.Location = new System.Drawing.Point(103, 84);
            this.buttonConfirmDelete.Name = "buttonConfirmDelete";
            this.buttonConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmDelete.TabIndex = 2;
            this.buttonConfirmDelete.Text = "Confirm";
            this.buttonConfirmDelete.UseVisualStyleBackColor = true;
            this.buttonConfirmDelete.Click += new System.EventHandler(this.buttonConfirmDelete_Click);
            // 
            // delonixRegiaDataSet
            // 
            this.delonixRegiaDataSet.DataSetName = "DelonixRegiaDataSet";
            this.delonixRegiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.delonixRegiaDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.buttonConfirmDelete);
            this.Controls.Add(this.labelSelectStaffID);
            this.Controls.Add(this.comboBoxSelectStaffID);
            this.Name = "DeleteStaff";
            this.Text = "DeleteStaff";
            this.Load += new System.EventHandler(this.DeleteStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.delonixRegiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectStaffID;
        private System.Windows.Forms.Label labelSelectStaffID;
        private System.Windows.Forms.Button buttonConfirmDelete;
        private DelonixRegiaDataSet delonixRegiaDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private DelonixRegiaDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
    }
}