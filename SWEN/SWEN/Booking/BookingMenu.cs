using SWEN;
using SWEN.Booking;
using SWEN_Assignment_3.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN_Assignment_3
{
    public partial class BookingMenu : Form
    {
        public BookingMenu()
        {
            InitializeComponent();
        }
      

     

        private void checkInMenu_Click(object sender, EventArgs e)
        {
         this.Hide();
            var form = new CheckIn();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void checkOutMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CheckOut();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void updateMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Update();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Home();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Delete();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

    }
}
