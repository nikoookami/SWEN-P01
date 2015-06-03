using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes.Reports
{
    class Room
    {
        private int roomid;
        private string roomno;
        private string room_type;
        private string bed_type;
        private string status;
        private double room_rates;
        private int bookingid;

        public int RoomID
        {
            get { return roomid; }
            set { roomid = value; }
        }

        public string RoomNo
        {
            get { return roomno; }
            set { roomno = value; }
        }

        public string Room_Type
        {
            get { return room_type; }
            set { room_type = value; }
        }

        public string Bed_Type
        {
            get { return bed_type; }
            set { bed_type = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public double Room_Rates
        {
            get { return room_rates; }
            set { room_rates = value; }
        }

        public int BookingID
        {
            get { return bookingid; }
            set { bookingid = value; }
        }
    }
}
