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
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        private string postal;

        public string Postal
        {
            get { return postal; }
            set { postal = value; }
        }
        private string country;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        private string guestid;

        public string Guestid
        {
            get { return guestid; }
            set { guestid = value; }
        }


        public booking(string name,string num,string email,string address,string postal,string country ,string noofadult, string noofchildren,string checkin, string checkout, string noofroom ,string guestid  )
        {
            this.guestid = guestid;
            this.name = name;
            this.number = num;
            this.email = email;
            this.address = address;
            this.postal = postal;
            this.country = country;
            this.checkin = checkin;
            this.checkout = checkout;
            this.noOfRoom = noofroom;
            this.noOfAdult = noofadult;
            this.noOfChildren = noofchildren;

        }
    }
}
