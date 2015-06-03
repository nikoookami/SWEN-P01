using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Booking
    {
        private int bookingid;
        private String check_in_date;
        private String check_out_date;
        private int no_of_rooms;
        private int no_of_adults;
        private int no_of_children;
        private int guestid;
        private int staffid;

        public int BookingID
        {
            get { return bookingid; }
            set { bookingid = value; }
        }

        public string Check_In_Date
        {
            get { return check_in_date; }
            set { check_in_date = value; }
        }

        public string Check_Out_Date
        {
            get { return check_out_date; }
            set { check_out_date = value; }
        }

        public int No_Of_Rooms
        {
            get { return no_of_rooms; }
            set { no_of_rooms = value; }
        }

        public int No_Of_Adults
        {
            get { return no_of_adults; }
            set { no_of_adults = value; }
        }

        public int No_Of_Children
        {
            get { return no_of_children; }
            set { no_of_children = value; }
        }

        public int GuestID
        {
            get { return guestid; }
            set { guestid = value; }
        }

        public int StaffID
        {
            get { return staffid; }
            set { staffid = value; }
        }
    }
}
