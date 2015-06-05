using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWEN
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
                            "(check_in_date, check_out_date,no_of_rooms,no_of_adults,no_of_children,guestid,roomno) values " +
                            "(@check_in_date,@check_out_date,@no_of_rooms,@no_of_adults,@no_of_children,@guestid,@roomno);" +
                            "insert into Guest " +
                            "(name,phone,address,postalcode,country,guestid,email) values " +
                            "(@name,@phone,@address,@postalcode,@country,@guestid,@email);"
                            ;
                    
                    comm.Parameters.AddWithValue("@check_in_date", u.Checkin);
                    comm.Parameters.AddWithValue("@check_out_date", u.Checkout);
                    comm.Parameters.AddWithValue("@no_of_rooms", u.NoOfRoom);
                    comm.Parameters.AddWithValue("@no_of_adults", u.NoOfAdult);
                    comm.Parameters.AddWithValue("@no_of_children", u.NoOfChildren);
                    comm.Parameters.AddWithValue("@guestid", u.Guestid);
                    comm.Parameters.AddWithValue("@name", u.Name);
                    comm.Parameters.AddWithValue("@phone", u.Number);
                    comm.Parameters.AddWithValue("@address", u.Address);
                    comm.Parameters.AddWithValue("@postalcode", u.Postal);
                    comm.Parameters.AddWithValue("@country", u.Country);
                    comm.Parameters.AddWithValue("@roomno", u.NoOfRoom);
                    comm.Parameters.AddWithValue("@email", u.Email);
                    

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
                comm.CommandText = "SELECT * from Guest b,Booking a where a.guestid=b.guestid   ";
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    booking p = new booking(dr["name"].ToString(), dr["phone"].ToString(), dr["email"].ToString(), dr["address"].ToString(), dr["postalcode"].ToString(), dr["country"].ToString(), dr["no_of_adults"].ToString(), dr["no_of_children"].ToString(), dr["check_in_date"].ToString(), dr["check_out_date"].ToString(), dr["no_of_rooms"].ToString(), dr["guestid"].ToString());
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
        public static ArrayList GetSalesInfo(string id)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList products = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from Sales WHERE guestid=@guestid  ";
                comm.Parameters.AddWithValue("@guestid", id);
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    sales l = new sales(dr["guestid"].ToString(), dr["productID"].ToString(), dr["productName"].ToString(), dr["prices"].ToString(), dr["quantity"].ToString(), dr["total"].ToString(), dr["remarks"].ToString());
                    products.Add(l);
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

        public static bool Insertsalesinfo(string guestid, string productname, string productid, string price, string quantity, string total)
        {
            bool result = false;
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            if (guestid != null && productname!=null)
            {

                try
                {
                    conn = new SqlConnection();
                    conn.ConnectionString = GSM_CONN_STR;
                    conn.Open();
                    comm.Connection = conn;
                    comm.CommandText = "insert into Sales " +
                            "(guestid,productName,productID,prices,total,quantity) values " +
                            "(@guestid,@productName,@productID,@prices,@total,@quantity)"
                            ;
                    

                    comm.Parameters.AddWithValue("@guestid", guestid);
                    comm.Parameters.AddWithValue("@productName", productname);
                    comm.Parameters.AddWithValue("@productID", productid);
                    comm.Parameters.AddWithValue("@prices", price);
                    comm.Parameters.AddWithValue("@quantity", quantity);
                    comm.Parameters.AddWithValue("@total", total);
                   
                    


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
        public static string Getproductid(string productname)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string products=null;
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT productID from Product  where @productName=productName   ";
                comm.Parameters.AddWithValue("@productName", productname);
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {

                    products = dr["productID"].ToString();
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
        public static string Getproductprice(string productname)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string products1=null;
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT prices from Product  where @productName=productName   ";
                comm.Parameters.AddWithValue("@productName", productname);
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {

                    products1 = dr["prices"].ToString();
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
            return products1;

        }
        public static string Getproductqant(string productid)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string products1 = null;
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT quantity from Sales  where @productID=productID  ";
                comm.Parameters.AddWithValue("@productID", productid);
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {

                    products1 = dr["quantity"].ToString();
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
            return products1;

        }
        public static string Getproductpricesales(string productid)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string products1 = null;
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT prices from Sales  where @productID=productID  ";
                comm.Parameters.AddWithValue("@productID", productid);
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {

                    products1 = dr["prices"].ToString();
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
            return products1;

        }

        public static string  UpdateSalesinfo(string qan, string price, string id,string total)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string products1 = null;
       bool result = false;
            try
            {
                
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "UPDATE Sales SET prices=@prices,quantity=@quantity,total=@total WHERE productID=@productID;  ";


                comm.Parameters.AddWithValue("@prices", price);
                comm.Parameters.AddWithValue("@quantity", qan);
                comm.Parameters.AddWithValue("@productID", id);
                comm.Parameters.AddWithValue("@total", total);

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
          return products1;

        }
        public static int deletebyname(string name)
        {
            int rowsdeleted = 0;
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            string products1 = null;
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "DELETE Sales where productName=@productName  ";
                comm.Parameters.AddWithValue("@productName", name);
                rowsdeleted = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return rowsdeleted;

        }
        public static int deletebyid(string name)
        {
            int rowsdeleted = 0;
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
         
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "DELETE Sales where guestid=@guestid  ";
                comm.Parameters.AddWithValue("@guestid", name);
                rowsdeleted = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return rowsdeleted;

        }
        public static payment Getpaymentinfo(string guestid)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            
            payment u = new payment();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Payment WHERE guestid=@guestid ";
                comm.Parameters.AddWithValue("@guestid", guestid);
                SqlDataReader dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    u.Ownerid= (int)dr["ownerid"];
                    u.Cardholdername = (string)dr["cardholdername"];
                    u.Expirydate = (string)dr["expirydate"];
                    u.CreaditNO = (string)dr["creditcardno"];
                  
                   
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;

        }
        public static int Updatepaymentinfo(payment u, string id)
        {
            int rowsinserted = 0;
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            
            try
            {

                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "UPDATE  Payment SET ownerid=@ownerid,cardholdername=@cardholdername,expirydate=@expirydate, creditcardno=@creditcardno WHERE guestid=@guestid";

                comm.Parameters.AddWithValue("@guestid", id);
                comm.Parameters.AddWithValue("@ownerid", u.Ownerid);
                comm.Parameters.AddWithValue("@cardholdername", u.Cardholdername);
                comm.Parameters.AddWithValue("@expirydate", u.Expirydate);
                comm.Parameters.AddWithValue("@creditcardno", u.CreaditNO);

                rowsinserted = comm.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return rowsinserted;

        }
        public static ArrayList GetAllBillInfo(string u)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            ArrayList products = new ArrayList();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from Bill where guestid=@guestid ";
                comm.Parameters.AddWithValue("@guestid", u);
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    billing p = new billing(dr["guestid"].ToString(), dr["extrabillID"].ToString(),  dr["description"].ToString(), dr["fees"].ToString(), dr["quantity"].ToString(), dr["total"].ToString());
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
        public static sales Getsalesinfo(string guestid)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();
            
            sales u = new sales();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Sales WHERE guestid=@guestid ";
                comm.Parameters.AddWithValue("@guestid", guestid);
                SqlDataReader dr = comm.ExecuteReader();

                if (dr.Read())
                {
                   u.Guestid = (string)dr["guestid"];
                    u.Productid = (string)dr["productID"];
                    u.Productname = (string)dr["productName"];
                    u.Price = (string)dr["prices"];
                    u.Quan = (string)dr["quantity"];
                    u.Total = (string)dr["total"];
                   


                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;

        }

        public static billing Getallbillinfobyid(string guestid)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            billing u = new billing();
            try
            {
                conn.ConnectionString = GSM_CONN_STR;
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = "SELECT * FROM Bill WHERE guestid=@guestid ";
                comm.Parameters.AddWithValue("@guestid", guestid);
                SqlDataReader dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    u.Extrabillid = (string)dr["extrabillID"];
                    u.Desc = (string)dr["description"];
                    u.Fees = (string)dr["fees"];
                    u.Qan = (string)dr["quantity"];
                   
                    u.Total = (string)dr["total"];



                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return u;

        }
    }
}
