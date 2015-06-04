using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Book
    {
        public int bookingid { get; set; }
        public string check_in_date { get; set; }
        public string check_out_date { get; set; }
        public int no_of_rooms { get; set; }
        public int no_of_adults { get; set; }
        public int no_of_children { get; set; }
        public int guestid { get; set; }
        public int staffid { get; set; }
        public string roomno { get; set; }

        public Book() { }

        public Book(int bookingid, string check_in_date, string check_out_date, int no_of_rooms, int no_of_adults,
                    int no_of_children, int guestid, int staffid, string roomno)
        {
            this.bookingid = bookingid;
            this.check_in_date = check_in_date;
            this.check_out_date = check_out_date;
            this.no_of_rooms = no_of_rooms;
            this.no_of_adults = no_of_adults;
            this.no_of_children = no_of_children;
            this.guestid = guestid;
            this.staffid = staffid;
            this.roomno = roomno;
        }
    }
}
