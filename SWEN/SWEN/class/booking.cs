using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class booking
    {
        private string checkin;

        public string Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }
        private string checkout;

        public string Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }
        private int noOfRoom;

        public int NoOfRoom
        {
            get { return noOfRoom; }
            set { noOfRoom = value; }
        }
        private int noOfAdult;

        public int NoOfAdult
        {
            get { return noOfAdult; }
            set { noOfAdult = value; }
        }
        private int noOfChildren;

        public int NoOfChildren
        {
            get { return noOfChildren; }
            set { noOfChildren = value; }
        }

        public booking(string checkin, string checkout, int noofroom, int noofadult, int noofchildren  )
        {
            this.checkin = checkin;
            this.checkout = checkout;
            this.noOfRoom = noofroom;
            this.noOfAdult = noofadult;
            this.noOfChildren = noofchildren;
        }
    }
}
