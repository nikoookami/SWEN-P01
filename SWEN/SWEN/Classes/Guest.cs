using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Guest
    {
<<<<<<< HEAD
        public int guestid { get; set; }
        public string name { get; set; }
        public int phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public int postalcode { get; set; }
        public string country { get; set; }
        public string paymenttype { get; set; }

        public Guest() { }

        public Guest(int guestid, string name, int phone, string email, string address, int postalcode,
                     string country, string paymenttype)
        {
            this.guestid = guestid;
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.postalcode = postalcode;
            this.country = country;
            this.paymenttype = paymenttype;
        }

=======
          private int guestid;
        private string name;
        private int phone;
        private string email;
        private string address;
        private int postalcode;
        private string country;
        private string paymenttype;

        public int GuestID
        {
            get { return guestid; }
            set { guestid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int PostalCode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }        

        public string PaymentType
        {
            get { return paymenttype; }
            set { paymenttype = value; }
        }
>>>>>>> origin/ChengKai
    }
    } 

