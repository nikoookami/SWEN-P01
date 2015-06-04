using DatabaseHelper;
using SWEN_Assignment_3.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN.Classes
{
    class GuestDBManager
    {
        public static ArrayList GetAllGuest()
        {
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Booking");
            SqlDataReader dr = r.RunQuery();
            ArrayList guest = new ArrayList();


            while (dr.Read())
            {
                Guest g = new Guest();
                g.guestid = (int)dr["guestid"];
                g.name = (string)dr["name"];
                g.phone = (int)dr["phone"];
                g.email = (string)dr["email"];
                g.address = (string)dr["address"];
                g.postalcode = (int)dr["postalcode"];
                g.country = (string)dr["country"];
               g.paymenttype = (string)dr["paymenttype"];

                guest.Add(g);
            }

            return guest;
        }

        public static Guest GetGuestByID(int guestid)
        {
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Guest");
            r.AddRestriction("guestid", "=", Convert.ToString(guestid));
            SqlDataReader dr = r.RunQuery();
            Guest g = new Guest();

            while (dr.Read())
            {
                g.guestid = (int)dr["guestid"];
                g.name = (string)dr["name"];
                g.phone = (int)dr["phone"];
                g.email = (string)dr["email"];
                g.address = (string)dr["address"];
                g.postalcode = (int)dr["postalcode"];
                g.country = (string)dr["country"];
                g.paymenttype = (string)dr["paymenttype"];
            }

            return g;
        }
    }
}
