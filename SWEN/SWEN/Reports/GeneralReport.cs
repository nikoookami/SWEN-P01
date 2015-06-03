using SWEN_Assignment_3.Classes;
using System;
using System.Collections;
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

namespace SWEN_Assignment_3.Reports
{
    public partial class GeneralReport : Form
    {
        HTMLReportTableNormal rt;

        public GeneralReport()
        {
            InitializeComponent();
            rt = new HTMLReportTableNormal("");
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Room rm = new Room();
            rm = RoomDBManager.getRoomByRn(tbxRoomNoSearch.Text);
            Book bk = new Book();
            bk = BookingDBManager.getbookingByID(rm.bookingid);

            string output = "";

            char[] cd = Convert.ToString(bk.check_in_date).ToCharArray();
            string checkInDateFormatted = cd[0].ToString() + cd[1].ToString() + "-" + cd[2].ToString() + cd[3].ToString() + "-" + cd[4].ToString() + cd[5].ToString() + cd[6].ToString() + cd[7].ToString();

            char[] cd1 = Convert.ToString(bk.check_out_date).ToCharArray();
            string checkOutDateFormatted = cd1[0].ToString() + cd1[1].ToString() + "-" + cd1[2].ToString() + cd1[3].ToString() + "-" + cd1[4].ToString() + cd1[5].ToString() + cd1[6].ToString() + cd1[7].ToString();
            output += "Booking ID: " + Convert.ToString(bk.bookingid) + Environment.NewLine;
            output+= "Guest ID: " + Convert.ToString(bk.guestid) + Environment.NewLine;
            output += "Check in date: " + checkInDateFormatted + Environment.NewLine;
            output += "Check out date: " + checkOutDateFormatted + Environment.NewLine;
            output += "Number of adults: " + Convert.ToString(bk.no_of_adults) + Environment.NewLine;
            output += "Number of children: " + Convert.ToString(bk.no_of_children) + Environment.NewLine;

            rt.overrideHTML(output);
            wbOutput.DocumentText = rt.generateHTML(false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ReportMenu();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdDocSave.Filter = "HTML documents (*.html)|*.html";
            sfdDocSave.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            wbOutput.DocumentText = rt.generateHTML(true);
        }

        private void sfdDocSave_FileOk(object sender, CancelEventArgs e)
        {
            string name = sfdDocSave.FileName;
            StreamWriter w = new StreamWriter(name);
            w.Write(rt.generateHTML(false));
            w.Close();
        }
    }
}
