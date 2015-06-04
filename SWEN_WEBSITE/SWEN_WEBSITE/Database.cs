using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;


namespace SWEN_WEBSITE
{
    public class Database
    {
        private const string GSM_CONN_STR = "data source=.\\SQLEXPRESS;initial catalog=DelonixRegia;integrated security=true;";


        public static bool InsertProductID(CustomerInfo u)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            if (u != null)
            {

                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = GSM_CONN_STR;
                    conn.Open();
                    comm.Connection = conn;
                    comm.CommandText = "insert into Guest " +
                             "(guestid,name,phone,email,address,postalcode,country,paymenttype) values " +
                             "(@guestid,@name,@phone,@email,@address,@postalcode,@country,@paymenttype);"+
                             "insert into Booking " +
                             "(bookingid,check_in_date,check_out_date,no_of_rooms,no_of_adults,no_of_children,guestid,staffid,roomno) values " +
                             "(@bookingid,@check_in_date,@check_out_date,@no_of_rooms,@no_of_adults,@no_of_children,@guestid,@staffid,@roomno);";

                    comm.Parameters.AddWithValue("@guestid", "12");
                    comm.Parameters.AddWithValue("@name", u.Name);
                    comm.Parameters.AddWithValue("@phone", u.PhoneNumber);
                    comm.Parameters.AddWithValue("@email", u.Email);
                    comm.Parameters.AddWithValue("@address", u.Address);
                    comm.Parameters.AddWithValue("@postalcode", u.Postal);
                    comm.Parameters.AddWithValue("@country", u.Country);
                    comm.Parameters.AddWithValue("@paymenttype", u.PaymentType);

                    comm.Parameters.AddWithValue("@bookingid", "131");
                    comm.Parameters.AddWithValue("@check_in_date", u.Checkiin);
                    comm.Parameters.AddWithValue("@check_out_date", u.Checkout);
                    comm.Parameters.AddWithValue("@no_of_rooms", u.Noofroom1);
                    comm.Parameters.AddWithValue("@no_of_adults", u.Adult);
                    comm.Parameters.AddWithValue("@no_of_children", u.Children);
                    comm.Parameters.AddWithValue("@staffid", "1212");
                    comm.Parameters.AddWithValue("@roomno", u.Noofroom1);

                    int rows = comm.ExecuteNonQuery();
                    if (rows > 0)
                        result = true;

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
    }
}