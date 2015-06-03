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
    public partial class RoomStatusReport : Form
    {
        HTMLReportTableNormal rt;

        public RoomStatusReport()
        {
            InitializeComponent();
            rt = new HTMLReportTableNormal("");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ReportMenu();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void tbxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            list = RoomDBManager.GetAllRoom();
            string output = "";
            string selected = cbxStatus.SelectedItem.ToString();

            foreach (Room rm in list)
            {
                if (rm.status == "Vacant" && rm.status == selected)
                {
                    output += "Room ID: " + rm.roomid + Environment.NewLine;
                    output += "Booking ID: " + rm.bookingid + Environment.NewLine;
                    output += "Room Number: " + rm.roomno + Environment.NewLine;
                    output += "Room Type: " + rm.room_type + Environment.NewLine;
                    output += "Room Status: " + rm.status + Environment.NewLine;
                    output += "Room Rates: " + rm.room_rates + Environment.NewLine + Environment.NewLine;
                }
                else if (rm.status == "Occupied" && rm.status == selected)
                {
                    output += "Room ID: " + rm.roomid + Environment.NewLine;
                    output += "Booking ID: " + rm.bookingid + Environment.NewLine;
                    output += "Room Number: " + rm.roomno + Environment.NewLine;
                    output += "Room Type: " + rm.room_type + Environment.NewLine;
                    output += "Room Status: " + rm.status + Environment.NewLine;
                    output += "Room Rates: " + rm.room_rates + Environment.NewLine + Environment.NewLine;
                }

                rt.overrideHTML(output);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            wbOutput.DocumentText = rt.generateHTML(false);

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

