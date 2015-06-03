using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    class DataBase
    {
        private const string GSM_CONN_STR = "data source=.\\SQLEXPRESS;initial catalog=DelonixRegia;integrated security=true;";

        public static bool Insertbookinfo(booking u)
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
                    comm.CommandText = "insert into Booking " +
                            "(check_in_date, check_out_date,no_of_rooms,no_of_adults,no_of_children) values " +
                            "(@check_in_date,@check_out_date,@no_of_rooms,@no_of_adults,@no_of_children);" 
                            ;
                    comm.Parameters.AddWithValue("(@check_in_date", u.Checkin);
                    comm.Parameters.AddWithValue("@check_out_date", u.Checkout);
                    comm.Parameters.AddWithValue("@no_of_rooms", u.NoOfRoom);
                    comm.Parameters.AddWithValue("@no_of_adults", u.NoOfAdult);
                    comm.Parameters.AddWithValue("@no_of_children", u.NoOfChildren);
                    

                    int rows = comm.ExecuteNonQuery();
                    if (rows > 0)
                        result = true;

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return result;
        }
        public static ArrayList GetAllInfo()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList products = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from Booking ";
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    booking p = new booking(dr["check_in_date"].ToString(), dr["check_out_date"].ToString(), dr["no_of_rooms"].ToString(), dr["no_of_adults"].ToString(), dr["no_of_children"].ToString());
                    products.Add(p);
                }

                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return products;

        }
    }
}
