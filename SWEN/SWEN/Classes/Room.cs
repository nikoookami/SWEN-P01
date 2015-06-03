using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Room
    {
        public int roomid { get; set; }
        public int bookingid { get; set; }
        public string roomno { get; set; }
        public string room_type { get; set; }
        public string bed_type { get; set; }
        public string status { get; set; }
        public decimal room_rates { get; set; }

        public Room() { }

        public Room(int roomid, int bookingid, string roomno, string room_type, string bed_type,
                        string status, decimal room_rates)
        {
            this.roomid = roomid;
            this.bookingid = bookingid;
            this.roomno = roomno;
            this.room_type = room_type;
            this.bed_type = bed_type;
            this.status = status;
            this.room_rates = room_rates;
        }
    }
}
