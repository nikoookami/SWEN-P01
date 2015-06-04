using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN
{
    class sales
    {
        private string guestid;

        public string Guestid
        {
            get { return guestid; }
            set { guestid = value; }
        }
        private string productid;

        public string Productid
        {
            get { return productid; }
            set { productid = value; }
        }
        private string productname;

        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        private string quan;

        public string Quan
        {
            get { return quan; }
            set { quan = value; }
        }
        private string total;

        public string Total
        {
            get { return total; }
            set { total = value; }
        }
       public sales()
        {

        }
        public sales(string guestid, string productid, string productname, string price, string quan, string total, string remarks)
        {
            this.guestid = guestid;
            this.productid = productid;
            this.productname = productname;
            this.price = price;
            this.remarks = remarks;
            this.quan = quan;
            this.total = total;
        }
    }
}
