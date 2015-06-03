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
        private string noOfRoom;

        public string NoOfRoom
        {
            get { return noOfRoom; }
            set { noOfRoom = value; }
        }
        private string noOfAdult;

        public string NoOfAdult
        {
            get { return noOfAdult; }
            set { noOfAdult = value; }
        }
        private string noOfChildren;

        public string NoOfChildren
        {
            get { return noOfChildren; }
            set { noOfChildren = value; }
        }

        public booking(string checkin, string checkout, string noofroom, string noofadult, string noofchildren  )
        {
            this.checkin = checkin;
            this.checkout = checkout;
            this.noOfRoom = noofroom;
            this.noOfAdult = noofadult;
            this.noOfChildren = noofchildren;
        }
    }
}
