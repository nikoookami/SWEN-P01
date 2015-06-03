using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Payment
    {
        private int ownerid;
        private string cardholdername;
        private DateTime expirydate;
        private string creditcardno;
        private int guestid;

        public int OwnerID
        {
            get { return ownerid; }
            set { ownerid = value; }
        }

        public string CardholderName
        {
            get { return cardholdername; }
            set { cardholdername = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expirydate; }
            set { expirydate = value; }
        }

        public string CreditCardNo
        {
            get { return creditcardno; }
            set { creditcardno = value; }
        }

        public int GuestID
        {
            get { return guestid; }
            set { guestid = value; }
        }
    }
}
