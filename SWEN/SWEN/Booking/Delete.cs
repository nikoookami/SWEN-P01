using SWEN_Assignment_3;
using SWEN_Assignment_3.Booking;
using SWEN_Assignment_3.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Booking
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DBManager.deleteBooking(Convert.ToInt32(textBox1.Text))==true)
            {
                MessageBox.Show("Booking Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Booking Was Not Deleted! Please Try Again!");
            }

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Home();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void recordReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new BookingMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CheckOut();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Update();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new CheckIn();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
