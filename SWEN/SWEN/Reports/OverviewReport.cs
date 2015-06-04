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
using SWEN.Classes;

namespace SWEN_Assignment_3.Reports
{
    public partial class OverviewReport : Form
    {
        HTMLReportTableNormal rt;

        public OverviewReport()
        {
            InitializeComponent();
            rt = new HTMLReportTableNormal("");
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = BookingDBManager.GetAllBooking();
            string output = "";
            int adultcount = 0;
            int childrencount = 0;
            int totalcount = 0;

            DateTime StartDate = dtpStartDate.Value;

            int totalNumberOfGuestInHotel = 0;
            int totalNumberOfChild = 0;
            int totalNumberOfAdult = 0;

                foreach(Book booking in list)
                {
                    char[] dateFmt = booking.check_in_date.ToCharArray();
                    string fmtYear = dateFmt[4].ToString() + dateFmt[5].ToString() + dateFmt[6].ToString() + dateFmt[7].ToString();
                    string fmtMonth = dateFmt[2].ToString() + dateFmt[3].ToString();
                    string fmtDay = dateFmt[0].ToString() + dateFmt[1].ToString();

                    DateTime dd = new DateTime(Convert.ToInt32(fmtYear), Convert.ToInt32(fmtMonth), Convert.ToInt32(fmtDay));

                    char[] dateFmt1 = booking.check_out_date.ToCharArray();
                    string fmtYear1 = dateFmt1[4].ToString() + dateFmt1[5].ToString() + dateFmt1[6].ToString() + dateFmt1[7].ToString();
                    string fmtMonth1 = dateFmt1[2].ToString() + dateFmt1[3].ToString();
                    string fmtDay1 = dateFmt1[0].ToString() + dateFmt1[1].ToString();

                    DateTime dd1 = new DateTime(Convert.ToInt32(fmtYear1), Convert.ToInt32(fmtMonth1), Convert.ToInt32(fmtDay1));

                    if (StartDate >= dd)
                    {
                        adultcount =+ booking.no_of_adults;
                        childrencount =+ booking.no_of_children;
                        totalcount =+ booking.no_of_adults + booking.no_of_children;
                        totalNumberOfGuestInHotel += totalcount;
                        totalNumberOfChild += childrencount;
                        totalNumberOfAdult += adultcount;

                        output += "Guest ID: " + booking.guestid + Environment.NewLine;
                        output += "Number of adults: " + adultcount + Environment.NewLine;
                        output += "Number of children: " + childrencount + Environment.NewLine + Environment.NewLine;
                    }
            }
                output += "In Summary: " + Environment.NewLine;
                output += "Total number of adults in hotel: " + totalNumberOfAdult + Environment.NewLine;

                output += "Total number of children in hotel: " + totalNumberOfChild + Environment.NewLine;
      
                output += "Total number of guests in hotel: " + totalNumberOfGuestInHotel + Environment.NewLine;


                rt.overrideHTML(output);
                wbOutput.DocumentText = rt.generateHTML(false);

        }

        private void tbxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void OverviewReport_Load(object sender, EventArgs e)
        {
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "ddMMyyyy";

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

