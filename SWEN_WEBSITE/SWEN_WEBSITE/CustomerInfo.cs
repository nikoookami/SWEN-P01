using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWEN_WEBSITE
{
    public class CustomerInfo
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
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
        private string adult;

        public string Adult
        {
            get { return adult; }
            set { adult = value; }
        }
        private string children;

        public string Children
        {
            get { return children; }
            set { children = value; }
        }
        private string checkiin;

        public string Checkiin
        {
            get { return checkiin; }
            set { checkiin = value; }
        }
        private string Noofroom;

        public string Noofroom1
        {
            get { return Noofroom; }
            set { Noofroom = value; }
        }
        private string roomtype;

        public string Roomtype
        {
            get { return roomtype; }
            set { roomtype = value; }
        }
        private string paymentType;

        public string PaymentType
        {
            get { return paymentType; }
            set { paymentType = value; }
        }
        private string remarks;

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
        private string checkout;

        public string Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }

        public CustomerInfo(string name, string number, string email, string address, string postal, string country, string adult, string children, string checkin, string checkout, string noOfRoom, string  roomtype, string paymenttype, string remarks  )
        {
            this.name = name;
            this.phoneNumber = number;
            this.email = email;
            this.address = address;
            this.postal = postal;
            this.country = country;
            this.adult = adult;
            this.children = children;
            this.checkiin = checkin;
            this.checkout = checkout;
            this.Noofroom = noOfRoom;
            this.roomtype = roomtype;
            this.paymentType = paymenttype;
            this.remarks = remarks;

        }
    }
}