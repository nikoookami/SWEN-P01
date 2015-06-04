using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN
{
    class billing
    {
        private string guestid;

        public string Guestid
        {
            get { return guestid; }
            set { guestid = value; }
        }
        private string extrabillid;

        public string Extrabillid
        {
            get { return extrabillid; }
            set { extrabillid = value; }
        }
        private string desc;

        public string Desc
        {
            get { return desc; }
            set { desc = value; }
        }
        private string fees;

        public string Fees
        {
            get { return fees; }
            set { fees = value; }
        }
        private string qan;

        public string Qan
        {
            get { return qan; }
            set { qan = value; }
        }
        private string total;

        public string Total
        {
            get { return total; }
            set { total = value; }
        }
        public billing()
        {

        }
        public billing(string guestid, string billid,string fees,string desc, string qan, string total)
        {
            this.guestid = guestid;
            this.extrabillid = billid;
            this.fees = fees;
            this.desc = desc;
            this.qan = qan;
            this.total = total;
        }
    }
}
