using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN_Assignment_3.Reports
{
    public partial class ReportMenu : Form
    {
        public ReportMenu()
        {
            InitializeComponent();
        }


        private void btnHousekeeping_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new HousekeepingReport();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new OverviewReport();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnRoomOccupancy_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new RoomOccupancyReport();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new GeneralReport();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new RoomStatusReport();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Home();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }
    }
}
