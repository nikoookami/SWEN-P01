using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Staff
    {
        private int staffID;
        private string name;
        private DateTime dob;
        private int bankNo;
        private string address;
        private int telNo;
        private string dutyType;
        private string username;

        public int StaffID
        {
            get { return staffID; }
            set { staffID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }

        public int BankNo
        {
            get { return bankNo; }
            set { bankNo = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int TelNo
        {
            get { return telNo; }
            set { telNo = value; }
        }

        public string DutyType
        {
            get { return dutyType; }
            set { dutyType = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
