using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN_Assignment_3.Classes
{
    class Housekeeping
    {
        public int housekeepingid { get; set; }
        public string housekeepingtype { get; set; }
        public string housekeepingdate { get; set; }
        public string housekeepingtime { get; set; }
        public int staffid { get; set; }
        public int roomid { get; set; }

        public Housekeeping() { }
        
        public Housekeeping(int housekeepingid, string housekeepingtype, string housekeepingdate,
                            string housekeepingtime, int staffid, int roomid)
        {
            this.housekeepingid = housekeepingid;
            this.housekeepingtype = housekeepingtype;
            this.housekeepingdate = housekeepingdate;
            this.housekeepingtime = housekeepingtime;
            this.staffid = staffid;
            this.roomid = roomid;
        }

    }
}
