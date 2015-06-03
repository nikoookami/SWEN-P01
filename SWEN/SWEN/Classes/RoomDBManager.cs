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
    class RoomDBManager
    {
        private const string GSM_CONN_STR = "data source=localhost;" +
                "initial catalog=DelonixRegia;integrated security=true;";

        public static ArrayList GetAllRoom()
        {
            
            ArrayList room = new ArrayList();
            SqlConnection conn = null;
            
            try
            {
                conn = new SqlConnection();
                
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Room";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Room r = new Room();
                    r.roomid = (int)dr["roomid"];
                    r.bookingid = (int)dr["bookingid"];
                    r.roomno = (string)dr["roomno"];
                    r.room_type = (string)dr["room_type"];
                    r.bed_type = (string)dr["bed_type"];
                    r.status = (string)dr["status"];
                    r.room_rates = (decimal)dr["room_rates"];

                    room.Add(r);
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
            return room;

        }

        public static Room getRoomByRn(string roomno)
        {
            DatabaseRetrieveQuery r = new DatabaseRetrieveQuery("Room");
            r.AddRestriction("roomno", "=", Convert.ToString(roomno));
            SqlDataReader dr = r.RunQuery();

            Room c = new Room();

            while (dr.Read())
            {
                c.roomid = (int)dr["roomid"];
                c.bookingid = (int)dr["bookingid"];
                c.roomno = (string)dr["roomno"];
                c.room_type = (string)dr["room_type"];
                c.bed_type = (string)dr["bed_type"];
                c.status = (string)dr["status"];
                c.room_rates = (decimal)dr["room_rates"];
            }
            return c;
        }

        public static Room GetRoomByDate(string date)
        {
            ArrayList booking = new ArrayList();
            SqlConnection conn = null;
            Room rm = null;
            try
            {
                conn = new SqlConnection();

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Room WHERE check_in_date = '" + date + "'";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    rm = new Room();
                    rm.roomid = (int)dr["roomid"];
                    rm.bookingid = (int)dr["bookingid"];
                    rm.roomno = (string)dr["roomno"];
                    rm.room_type = (string)dr["room_type"];
                    rm.bed_type = (string)dr["bed_type"];
                    rm.status = (string)dr["status"];
                    rm.room_rates = (decimal)dr["room_rates"];

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
            return rm;

        }
        
    }
}
