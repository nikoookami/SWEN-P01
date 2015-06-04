using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Guest
    {
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
    }
} 

