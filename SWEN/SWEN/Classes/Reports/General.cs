using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes.Reports
{
    class General
    {
        private String guests;
        private String roomno;
        private String check_in;

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
    }
}
