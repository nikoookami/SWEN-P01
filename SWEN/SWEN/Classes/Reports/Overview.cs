using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Overview
    {
        private String guests;
        private String roomno;
        private String check_in;
        private String check_out;

        public String Guests
        {
            get { return guests; }
            set { guests = value; }
        }

        public String RoomNo
        {
            get { return roomno; }
            set { roomno = value; }
        }

        public String Check_in
        {
            get { return check_in; }
            set { check_in = value; }
        }

        public String Check_out
        {
            get { return check_out; }
            set { check_out = value; }
        }
    }
}
