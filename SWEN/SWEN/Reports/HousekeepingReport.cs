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
    public partial class HousekeepingReport : Form
    {
        HTMLReportTableNormal rt;

        public HousekeepingReport()
        {
            InitializeComponent();
            rt = new HTMLReportTableNormal("");
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HousekeepingReport_Load(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "ddMMyyyy";
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

        private void btnPreview_Click(object sender, EventArgs e)
        {
            wbOutput.DocumentText = rt.generateHTML(false);

        }

        private void cbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbView.SelectedItem == "Daily")
            {
                ArrayList list = new ArrayList();
                list = HousekeepingDBManager.GetAllHousekeeping();
                string output = "";

                foreach (Housekeeping hk in list)
                {
                    if (hk.housekeepingdate == dtpDate.Text)
                    {
                        output += "Housekeeping ID: " + hk.housekeepingid + Environment.NewLine;
                        output += "Housekeeping Type: " + hk.housekeepingtype + Environment.NewLine;
                        output += "Housekeeping Date: " + hk.housekeepingdate + Environment.NewLine;
                        output += "Housekeeping Time: " + hk.housekeepingtime + Environment.NewLine;
                        output += "Staff ID: " + hk.staffid + Environment.NewLine;
                        output += "Room ID: " + hk.roomid + Environment.NewLine + Environment.NewLine;
                    }
                    rt.overrideHTML(output);
                }
            }
            else if (cbView.SelectedItem == "Weekly")
            {
                ArrayList list = new ArrayList();
                list = HousekeepingDBManager.GetAllHousekeeping();
                string output = "";
                DateTime StartDate = dtpDate.Value;
                DateTime EndDate = StartDate.AddDays(7);
            
                    foreach (Housekeeping hk in list)
                    {
                        char[] dateFmt = hk.housekeepingdate.ToCharArray();
                        string fmtYear = dateFmt[4].ToString() + dateFmt[5].ToString() + dateFmt[6].ToString() + dateFmt[7].ToString();
                        string fmtMonth = dateFmt[2].ToString() + dateFmt[3].ToString();
                        string fmtDay = dateFmt[0].ToString() + dateFmt[1].ToString();

                        DateTime dd = new DateTime(Convert.ToInt32(fmtYear), Convert.ToInt32(fmtMonth), Convert.ToInt32(fmtDay));

                    if (StartDate<=dd && EndDate>=dd)
                    {
                        output += "Housekeeping ID: " + hk.housekeepingid + Environment.NewLine;
                        output += "Housekeeping Type: " + hk.housekeepingtype + Environment.NewLine;
                        output += "Housekeeping Date: " + hk.housekeepingdate + Environment.NewLine;
                        output += "Housekeeping Time: " + hk.housekeepingtime + Environment.NewLine;
                        output += "Staff ID: " + hk.staffid + Environment.NewLine;
                        output += "Room ID: " + hk.roomid + Environment.NewLine + Environment.NewLine;
                    }
            }
                    rt.overrideHTML(output);
            }
            else if (cbView.SelectedItem == "Monthly")
            {
                ArrayList list = new ArrayList();
                list = HousekeepingDBManager.GetAllHousekeeping();
                string output = "";
                DateTime StartDate = dtpDate.Value;
                DateTime EndDate = StartDate.AddDays(31);

                foreach (Housekeeping hk in list)
                {
                    char[] dateFmt = hk.housekeepingdate.ToCharArray();
                    string fmtYear = dateFmt[4].ToString() + dateFmt[5].ToString() + dateFmt[6].ToString() + dateFmt[7].ToString();
                    string fmtMonth = dateFmt[2].ToString() + dateFmt[3].ToString();
                    string fmtDay = dateFmt[0].ToString() + dateFmt[1].ToString();

                    DateTime dd = new DateTime(Convert.ToInt32(fmtYear), Convert.ToInt32(fmtMonth), Convert.ToInt32(fmtDay));

                    if (StartDate <= dd && EndDate >= dd)
                    {
                        output += "Housekeeping ID: " + hk.housekeepingid + Environment.NewLine;
                        output += "Housekeeping Type: " + hk.housekeepingtype + Environment.NewLine;
                        output += "Housekeeping Date: " + hk.housekeepingdate + Environment.NewLine;
                        output += "Housekeeping Time: " + hk.housekeepingtime + Environment.NewLine;
                        output += "Staff ID: " + hk.staffid + Environment.NewLine;
                        output += "Room ID: " + hk.roomid + Environment.NewLine + Environment.NewLine;
                    }

                }
                rt.overrideHTML(output);
            }
        }
    }
}
