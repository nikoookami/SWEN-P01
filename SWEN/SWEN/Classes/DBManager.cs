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
                    g.Name = (string)dr["name"];
                    g.Phone = (int)dr["phone"];
                    g.Email = (string)dr["email"];
                    g.Address = (string)dr["address"];
                    g.PostalCode = (int)dr["postalcode"];
                    g.Country = (string)dr["country"];
                    g.PaymentType = (string)dr["paymenttype"];
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
        public static BOOK getbookingByID(int bookingid)
        {
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
        }
        public static Guest getGuestByID(int guestid)
        {
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Guest");
            r.AddRestriction("guestid", "=", Convert.ToString(guestid));
            SqlDataReader dr = r.RunQuery();
            Guest c = new Guest();

            while (dr.Read())
            {
                c.GuestID = (int)dr["guestid"];
                c.Name = (String)dr["name"];
                c.Phone = (int)dr["phone"];
                //c.Start_time = (dr["Start_time"]).ToString();
                c.Email = (String)dr["email"];
                c.Address = (String)dr["address"];
                c.PostalCode = (int)dr["postalcode"];
                c.Country = (String)dr["country"];
                c.PaymentType = (String)dr["paymenttype"];
            }

            return c;
        }
        public static Boolean updateBooking(BOOK b)
        {
            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Booking","bookingid="+Convert.ToString(b.BookingID));
            //r.AddData("bookingid",Convert.ToString(b.BookingID));
            r.AddData("check_in_date", b.Check_In_Date);
            r.AddData("check_out_date", b.Check_Out_Date);
            r.AddData("no_of_rooms", Convert.ToString(b.No_Of_Rooms));
            r.AddData("no_of_adults", Convert.ToString(b.No_Of_Adults));
            r.AddData("no_of_children", Convert.ToString(b.No_Of_Children));
            r.AddData("guestid", Convert.ToString(b.GuestID));
            r.AddData("staffid", Convert.ToString(b.StaffID));
            return r.RunQuery();
        }
        public static Boolean updateGuest(Guest b)
        {
            DatabaseUpdateQuery r = new DatabaseUpdateQuery("Guest", "guestid=" + Convert.ToString(b.GuestID));
            //r.AddData("guestid", Convert.ToString(b.GuestID));
            r.AddData("name", b.Name);
            r.AddData("phone", Convert.ToString(b.Phone));
            r.AddData("email", b.Email);
            r.AddData("address", b.Address);
            r.AddData("postalcode", Convert.ToString(b.PostalCode));
            r.AddData("country", b.Country);
            r.AddData("paymenttype",b.PaymentType );
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
    }
}