using DatabaseHelper;
using SWEN_Assignment_3.Classes.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SWEN_Assignment_3.Classes
{
    class DBManager
    {
        
       
        // Create - GUEST
        private const string GSM_CONN_STR = "data source=localhost;" +
"initial catalog=DelonixRegia;integrated security=true;";
       
       

        /* 
         * ---------- RETRIEVE & VALIDATE -----------
         */
        // Retrieve GuestID
        
      

        // Retrieve - BOOKING (ALL)
        public static ArrayList RetrieveAllBooking()
        {
            ArrayList result = new ArrayList();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from Booking";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Booking c = new Booking();
                    c.BookingID = (int)dr["bookingid"];
                    c.Check_In_Date =(String)dr["check_in_date"];
                    c.Check_Out_Date = (String)dr["check_out_date"];
                    //c.Start_time = (dr["Start_time"]).ToString();
                    c.No_Of_Rooms = (int)dr["no_of_rooms"];
                    c.No_Of_Adults = (int)dr["no_of_adults"];
                    c.No_Of_Children = (int)dr["no_of_children"];
                    c.GuestID = (int)dr["guestid"];
                    c.StaffID = (int)dr["staffid"];

                    result.Add(c);
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return result;
                
            }
        

      

        // Retrieve - VIEW BOOKING (BID)
        public static ArrayList ViewBookingByBID(int bookingid)
        {
           /* Booking c = null;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Booking WHERE bookingid=@bookingid";
                comm.Parameters.AddWithValue("@bookingid", bookingid);
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.Read())
                {
                    c = new Booking();
                    c.BookingID = (int)dr["bookingid"];
                    c.Check_In_Date = (dr["check_in_date"]).ToString();
                    c.Check_Out_Date = (dr["check_out_date"]).ToString();
                    //c.Start_time = (dr["Start_time"]).ToString();
                    c.No_Of_Rooms = (int)dr["no_of_rooms"];
                    c.No_Of_Adults = (int)dr["no_of_adults"];
                    c.No_Of_Children = (int)dr["no_of_children"];
                    c.GuestID = (int)dr["guestid"];
                    c.StaffID = (int)dr["staffid"];
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return c;
            
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Booking");
            r.AddRestriction("bookingid", "=", Convert.ToString(bookingid));
            SqlDataReader dr = r.RunQuery();
            BOOK c = new BOOK();

            while (dr.Read())
            {
                 c.BookingID = (int)dr["bookingid"];
                    c.Check_In_Date = (dr["check_in_date"]).ToString();
                    c.Check_Out_Date = (dr["check_out_date"]).ToString();
                    //c.Start_time = (dr["Start_time"]).ToString();
                    c.No_Of_Rooms = (int)dr["no_of_rooms"];
                    c.No_Of_Adults = (int)dr["no_of_adults"];
                    c.No_Of_Children = (int)dr["no_of_children"];
                    c.GuestID = (int)dr["guestid"];
                    c.StaffID = (int)dr["staffid"];
            }

            return c;
        */
            ArrayList result = new ArrayList();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from Booking";
                SqlDataReader dr = comm.ExecuteReader();
               
                while (dr.Read())
                {
                    Booking c = new Booking();
                    int id = (int)dr["bookingid"];
                    if (id == bookingid)
                    {

                        c.BookingID = (int)dr["bookingid"];
                        c.Check_In_Date = (String)dr["check_in_date"];
                        c.Check_Out_Date = (String)dr["check_out_date"];
                        //c.Start_time = (dr["Start_time"]).ToString();
                        c.No_Of_Rooms = (int)dr["no_of_rooms"];
                        c.No_Of_Adults = (int)dr["no_of_adults"];
                        c.No_Of_Children = (int)dr["no_of_children"];
                        c.GuestID = (int)dr["guestid"];
                        c.StaffID = (int)dr["staffid"];

                        result.Add(c);
                    }
                }
                
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return result;
        }
        // Retrieve - VIEW ROOM (RID)
       

        // Retrieve - VIEW GUEST (BID)
        public static Guest ViewGuestByBID(int bookingid)
        {
            Guest g = new Guest();
            SqlConnection conn = null;

            try
            {
                //
                conn = new SqlConnection();
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();

                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT g.name, g.phone, g.email, g.address, g.postalcode, g.country, g.paymenttype" +
                                    " FROM Guest g, Booking b" +
                                    " WHERE b.bookingid=@bookingid AND b.guestid = g.guestid";
                comm.Parameters.AddWithValue("@bookingid", bookingid);

                SqlDataReader dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    g.name = (string)dr["name"];
                    g.phone = (int)dr["phone"];
                    g.email = (string)dr["email"];
                    g.address = (string)dr["address"];
                    g.postalcode = (int)dr["postalcode"];
                    g.country = (string)dr["country"];
                    g.paymenttype = (string)dr["paymenttype"];
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return g;
        }

       

      


        // Update - GUEST
        
       

       
        public static int GetTotalCount()
        {
            ArrayList result = new ArrayList();
            SqlConnection conn = null;
            int count = 0;
            try
            {
                conn = new SqlConnection();
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from Booking";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Booking c = new Booking();
                    c.BookingID = (int)dr["bookingid"];
                    c.Check_In_Date = (String)dr["check_in_date"];
                    c.Check_Out_Date = (String)dr["check_out_date"];
                    //c.Start_time = (dr["Start_time"]).ToString();
                    c.No_Of_Rooms = (int)dr["no_of_rooms"];
                    c.No_Of_Adults = (int)dr["no_of_adults"];
                    c.No_Of_Children = (int)dr["no_of_children"];
                    c.GuestID = (int)dr["guestid"];
                    c.StaffID = (int)dr["staffid"];
                    int adults = Convert.ToInt32(c.No_Of_Adults);
                    int children = Convert.ToInt32(c.No_Of_Children);
                    count += adults;
                    count += children;
                    result.Add(c);
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return count;

        }
        public static Book getbookingByID(int bookingid)
        {
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Booking");
            r.AddRestriction("bookingid", "=", Convert.ToString(bookingid));
            SqlDataReader dr = r.RunQuery();
            Book c = new Book();

            while (dr.Read())
            {
                c.bookingid = (int)dr["bookingid"];
                c.check_in_date = (dr["check_in_date"]).ToString();
                c.check_out_date = (dr["check_out_date"]).ToString();
                //c.Start_time = (dr["Start_time"]).ToString();
                c.no_of_rooms = (int)dr["no_of_rooms"];
                c.no_of_adults = (int)dr["no_of_adults"];
                c.no_of_children = (int)dr["no_of_children"];
                c.guestid = (int)dr["guestid"];
                c.staffid = (int)dr["staffid"];
            }

            return c;
        }
        public static Guest getGuestByID(int guestid)
        {
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Guest");
            r.AddRestriction("guestid", "=", Convert.ToString(guestid));
            SqlDataReader dr = r.RunQuery();
            Guest c = new Guest();

            while (dr.Read())
            {
                c.guestid = (int)dr["guestid"];
                c.name = (String)dr["name"];
                c.phone = (int)dr["phone"];
                //c.Start_time = (dr["Start_time"]).ToString();
                c.email = (String)dr["email"];
                c.address = (String)dr["address"];
                c.postalcode = (int)dr["postalcode"];
                c.country = (String)dr["country"];
                c.paymenttype = (String)dr["paymenttype"];
            }

            return c;
        }
        public static Boolean updateBooking(Book b)
        {
            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Booking","bookingid="+Convert.ToString(b.bookingid));
            //r.AddData("bookingid",Convert.ToString(b.BookingID));
            r.AddData("check_in_date", b.check_in_date);
            r.AddData("check_out_date", b.check_out_date);
            r.AddData("no_of_rooms", Convert.ToString(b.no_of_rooms));
            r.AddData("no_of_adults", Convert.ToString(b.no_of_adults));
            r.AddData("no_of_children", Convert.ToString(b.no_of_children));
            r.AddData("guestid", Convert.ToString(b.guestid));
            r.AddData("staffid", Convert.ToString(b.staffid));
            return r.RunQuery();
        }
        public static Boolean updateGuest(Guest b)
        {
            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Guest", "guestid=" + Convert.ToString(b.guestid));
            //r.AddData("guestid", Convert.ToString(b.GuestID));
            r.AddData("name", b.name);
            r.AddData("phone", Convert.ToString(b.phone));
            r.AddData("email", b.email);
            r.AddData("address", b.address);
            r.AddData("postalcode", Convert.ToString(b.postalcode));
            r.AddData("country", b.country);
            r.AddData("paymenttype",b.paymenttype);
            return r.RunQuery();
        }
        public static decimal gettotalroompricebyBID(int bookingid)
        {
           
            decimal Price = 0;
            SqlConnection conn = null;
            try
            {
                 conn = new SqlConnection();
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT room_rates,bookingid from Room";
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    

                    int id = (int)dr["bookingid"];
                    if (id == bookingid)
                    {
                     
                        decimal Room_Rates = (decimal)dr["room_rates"];
                        Price += Room_Rates;
                    }
               /* conn = new SqlConnection();
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from Room";
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    Room c = new Room();

                    int id = (int)dr["bookingid"];
                    if (id == bookingid)
                    {
                        c.BookingID = id;
                        c.RoomID = (int)dr["roomid"];
                        c.RoomNo = (string)dr["roomno"];
                        c.Room_Type = (string)dr["room_type"];
                        c.Bed_Type = (string)dr["bed_type"];
                        c.Status = (string)dr["status"];
                        c.Room_Rates = (decimal)dr["room_rates"];
                        Price += c.Room_Rates;
                    }*/

                    
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
            return Price;
        }
        public static Boolean updatecheckout(int bookingid)
        {

           DatabaseUpdateQuery r = new DatabaseUpdateQuery("Room", "bookingid=" + Convert.ToString(bookingid));
           
            r.AddData("status", "vacant");
            return r.RunQuery();
        }
        public static Boolean updatecheckin(int bookingid)
        {

            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Room", "bookingid=" + Convert.ToString(bookingid));

            r.AddData("status", "occupied");
            return r.RunQuery();
        }
        public static Boolean deleteBooking(int bookingid)
        {
            DatabaseDeleteQuery r = new DatabaseDeleteQuery("Booking","bookingid="+bookingid);
            return r.RunQuery();

        }
    }
}