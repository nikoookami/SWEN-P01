using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Guest
    {
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
    }
    } 

