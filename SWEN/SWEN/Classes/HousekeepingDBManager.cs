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
    class HousekeepingDBManager
    {
        private const string GSM_CONN_STR = "data source=localhost;" +
                "initial catalog=DelonixRegia;integrated security=true;";

        public static ArrayList GetAllHousekeeping()
        {
            ArrayList housekeeping = new ArrayList();
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection();

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Housekeeping";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Housekeeping h = new Housekeeping();
                    h.housekeepingid = (int)dr["housekeepingid"];
                    h.housekeepingtype = (string)dr["housekeepingtype"];
                    h.housekeepingdate = (string)dr["housekeepingdate"];
                    h.housekeepingtime = (string)dr["housekeepingtime"];
                    h.staffid = (int)dr["staffid"];
                    h.roomid = (int)dr["roomid"];

                    housekeeping.Add(h);
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
            return housekeeping;
        }

        public static Housekeeping GetHousekeepingByDate(string date)
        {
            ArrayList booking = new ArrayList();
            SqlConnection conn = null;
            Housekeeping b = null;
            try
            {
                conn = new SqlConnection();

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Housekeeping WHERE housekeepingdate = '" + date + "'";
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    b = new Housekeeping();
                    b.housekeepingid = (int)dr["housekeepingid"];
                    b.housekeepingtype = (string)dr["housekeepingtype"];
                    b.housekeepingdate = (string)dr["housekeepingdate"];
                    b.housekeepingtime = (string)dr["housekeepingtime"];
                    b.staffid = (int)dr["staffid"];
                    b.roomid = (int)dr["roomid"];

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
    }
}
