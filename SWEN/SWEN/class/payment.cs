using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN
{
    class payment
    {
        private int ownerid;

        public int Ownerid
        {
            get { return ownerid; }
            set { ownerid = value; }
        }
        private string cardholdername;

        public string Cardholdername
        {
            get { return cardholdername; }
            set { cardholdername = value; }
        }
        private string expirydate;

        public string Expirydate
        {
            get { return expirydate; }
            set { expirydate = value; }
        }
        private string creaditNO;

        public string CreaditNO
        {
            get { return creaditNO; }
            set { creaditNO = value; }
        }
        public payment()
        {

        }
        public payment(int ownerid, string name, string expirydate,string cardno)
        {
            this.ownerid = ownerid;
            this.cardholdername = name;
            this.expirydate = expirydate;
            this.creaditNO = cardno;
        }
    }
}
