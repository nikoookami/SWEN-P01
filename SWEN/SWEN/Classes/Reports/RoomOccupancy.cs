using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes.Reports
{
    class RoomOccupancy
    {
        private string date;
        private string roomNo;
        private int daysoccupied;
        private string check_in;
        private string check_out;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }


        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public int Daysoccupied
        {
            get { return daysoccupied; }
            set { daysoccupied = value; }
        }

        public string Check_in
        {
            get { return check_in; }
            set { check_in = value; }
        }

        public string Check_out
        {
            get { return check_out; }
            set { check_out = value; }
        }
    }
}
