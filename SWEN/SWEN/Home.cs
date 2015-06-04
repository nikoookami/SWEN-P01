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
using HTMLReport;
using System.IO;
using SWEN_Assignment_3.Classes;
using SWEN_Assignment_3.Classes.Reports;
using SWEN_Assignment_3;
using System.Data.SqlClient;
namespace SWEN
{
    public partial class Home : Form
    {
        static SqlConnection cnn = new SqlConnection("Server=SIRIUS;Database=DelonixRegia;User ID=bspiSCM;password=Nikoookami02");

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
            var form = new BookingMenu();
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

        private void Home_Load(object sender, EventArgs e)
        {
            SqlCommand selectCommand = new SqlCommand("SELECT * FROM Staff", cnn);
            SqlDataAdapter ada = new SqlDataAdapter(selectCommand);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            labelNoOfStaff.Text = "No. of staff: " + dt.Rows.Count;
        }
    }
}
