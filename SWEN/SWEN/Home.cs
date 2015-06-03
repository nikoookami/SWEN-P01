using SWEN_Assignment_3.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Login();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonRoomBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new RoomBooking();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonHouseStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HouseStaff();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ReportMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
