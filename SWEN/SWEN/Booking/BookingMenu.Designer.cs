namespace SWEN_Assignment_3
{
    partial class BookingMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recordReservationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordReservationMenu,
            this.checkInMenu,
            this.checkOutMenu,
            this.updateMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(335, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recordReservationMenu
            // 
            this.recordReservationMenu.BackColor = System.Drawing.Color.DarkMagenta;
            this.recordReservationMenu.Name = "recordReservationMenu";
            this.recordReservationMenu.Size = new System.Drawing.Size(120, 20);
            this.recordReservationMenu.Text = "Record Reservation";
        
            // 
            // checkInMenu
            // 
            this.checkInMenu.BackColor = System.Drawing.Color.Violet;
            this.checkInMenu.Name = "checkInMenu";
            this.checkInMenu.Size = new System.Drawing.Size(67, 20);
            this.checkInMenu.Text = "Check-In";
            this.checkInMenu.Click += new System.EventHandler(this.checkInMenu_Click);
            // 
            // checkOutMenu
            // 
            this.checkOutMenu.BackColor = System.Drawing.Color.Turquoise;
            this.checkOutMenu.Name = "checkOutMenu";
            this.checkOutMenu.Size = new System.Drawing.Size(77, 20);
            this.checkOutMenu.Text = "Check-Out";
            this.checkOutMenu.Click += new System.EventHandler(this.checkOutMenu_Click);
            // 
            // updateMenu
            // 
            this.updateMenu.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.updateMenu.Name = "updateMenu";
            this.updateMenu.Size = new System.Drawing.Size(57, 20);
            this.updateMenu.Text = "Update";
            this.updateMenu.Click += new System.EventHandler(this.updateMenu_Click);
            // 
            // BookingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 261);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookingMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem recordReservationMenu;
        private System.Windows.Forms.ToolStripMenuItem checkInMenu;
        private System.Windows.Forms.ToolStripMenuItem checkOutMenu;
        private System.Windows.Forms.ToolStripMenuItem updateMenu;
    }
}

