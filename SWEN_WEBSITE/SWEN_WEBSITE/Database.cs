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
       private const string GSM_CONN_STR = "data source=.\\SQLEXPRESS;initial catalog=DelonixRegiaWebsite;integrated security=true;";


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
                    comm.CommandText = "insert into BokingInfo " +
                             "(FullName,PhoneNum,Email,Address,Postal,Country,NoOfAdults,NoOfChildren,CheckInDate,CheckOutDate,NoOfROom,RoomType,PaymentType,Remarks) values " +
                             "(@FullName,@PhoneNum,@Email,@Address,@Postal,@Country,@NoOfAdults,@NoOfChildren,@CheckInDate,@CheckOutDate,@NoOfROom,@RoomType,@PaymentType,@Remarks);";

                    comm.Parameters.AddWithValue("@FullName", u.Name);
                    comm.Parameters.AddWithValue("@PhoneNum", u.PhoneNumber);
                    comm.Parameters.AddWithValue("@Email", u.Email);
                    comm.Parameters.AddWithValue("@Address", u.Address);
                    comm.Parameters.AddWithValue("@Postal", u.Postal);
                    comm.Parameters.AddWithValue("@Country", u.Country);
                    comm.Parameters.AddWithValue("@NoOfAdults", u.Adult);
                    comm.Parameters.AddWithValue("@NoOfChildren", u.Children);
                    comm.Parameters.AddWithValue("@CheckInDate", u.Checkiin);
                    comm.Parameters.AddWithValue("@CheckOutDate", u.Checkout);
                    comm.Parameters.AddWithValue("@NoOfROom", u.Noofroom1);
                    comm.Parameters.AddWithValue("@RoomType", u.Roomtype);
                    comm.Parameters.AddWithValue("@PaymentType", u.PaymentType);
                    comm.Parameters.AddWithValue("@Remarks", u.Remarks);

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