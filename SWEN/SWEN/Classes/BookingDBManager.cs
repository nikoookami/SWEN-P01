using DatabaseHelper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN_Assignment_3.Classes
{
    class BookingDBManager
    {
        private const string GSM_CONN_STR = "data source=localhost;" +
                "initial catalog=DelonixRegia;integrated security=true;";

        
        /*public static ArrayList GetAllBooking()
        {
            ArrayList booking = new ArrayList();
            SqlConnection conn = null;
            Book b = new Book();
            try
            {
                conn = new SqlConnection();

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                
                comm.CommandText = "SELECT * FROM Booking";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    
                    b.bookingid = (int)dr["bookingid"];
                    b.check_in_date = (string)dr["check_in_date"];
                    b.check_out_date = (string)dr["check_out_date"];
                    b.no_of_rooms = (int)dr["no_of_rooms"];
                    b.no_of_adults = (int)dr["no_of_adults"];
                    b.no_of_children = (int)dr["no_of_children"];
                    b.guestid = (int)dr["guestid"];
                    b.staffid = (int)dr["staffid"];

                    booking.Add(b);
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return booking;

        }*/
        

        
        public static Book GetBookingByDate(string date)
        {
            ArrayList booking = new ArrayList();
            SqlConnection conn = null;
            Book b = null;
            try
            {
                conn = new SqlConnection();

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT no_of_adults, no_of_children, check_in_date, check_out_date FROM Booking WHERE check_in_date = '"+date+"'";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                     b = new Book();
                    //b.BookingID = (int)dr["bookingid"];
                    b.check_in_date = (string)dr["check_in_date"];
                    b.check_out_date = (string)dr["check_out_date"];
                    //b.No_Of_Rooms = (int)dr["no_of_rooms"];
                    b.no_of_adults = (int)dr["no_of_adults"];
                    b.no_of_children = (int)dr["no_of_children"];
                    //b.GuestID = (int)dr["guestid"];
                    //b.StaffID = (int)dr["staffid"];
                    //b.roomno = (string)dr["roomno"];

                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
            return b;

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
                c.roomno = (string)dr["roomno"];
            }

            return c;
        }
        
        public static ArrayList getAllBooking()
        {
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Booking");
            SqlDataReader dr = r.RunQuery();
            ArrayList booking = new ArrayList();
            

            while (dr.Read())
            {
                Book c = new Book();
                c.bookingid = (int)dr["bookingid"];
                c.check_in_date = (dr["check_in_date"]).ToString();
                c.check_out_date = (dr["check_out_date"]).ToString();
                c.no_of_rooms = (int)dr["no_of_rooms"];
                c.no_of_adults = (int)dr["no_of_adults"];
                c.no_of_children = (int)dr["no_of_children"];
                c.guestid = (int)dr["guestid"];
                c.staffid = (int)dr["staffid"];
                c.roomno = (string)dr["roomno"];

                booking.Add(c);
            }

            return booking;
        }
         
        


    }
}

