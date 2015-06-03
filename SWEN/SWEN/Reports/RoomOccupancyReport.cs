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

namespace SWEN_Assignment_3.Reports
{
    public partial class RoomOccupancyReport : Form
    {
        public RoomOccupancyReport()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new ReportMenu();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList list = RoomDBManager.GetAllRoom();
            ArrayList list1 = BookingDBManager.getAllBooking();

            Room rm = new Room();
            rm = RoomDBManager.GetRoomByDate(dtpStartDate.Text);
            Book bk = new Book();
            bk = BookingDBManager.getbookingByID(rm.bookingid);

            string output = "";
            int roomcount = 0;
            int occupiedroomcount = 0;
            decimal total =0;

            DateTime StartDate = dtpStartDate.Value;
            DateTime EndDate = StartDate.AddDays(7);

            foreach (Book booking in list1)
            {
                foreach (Room room in list)
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
                        roomcount =+ booking.no_of_rooms;
                    }
                    if(room.status == "Occupied")
                    {
                        occupiedroomcount++;
                    }
                        
                        total =+ (occupiedroomcount/roomcount)*100;

                        //output += "Guest ID: " + booking.guestid + Environment.NewLine;
                    }
                }
            
                output += "Statistics: " + Environment.NewLine;
                output += "Percentage of the rooms that are occupied over the total number of rooms: " + total + Environment.NewLine;
                tbxOutput.Clear();
                tbxOutput.Text += output;
                
            }
   
         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

         private void btnWeekly_Click(object sender, EventArgs e)
         {

         }

         private void btnMonthly_Click(object sender, EventArgs e)
         {

         }
    }
}
