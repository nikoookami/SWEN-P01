using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseHelper;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for DatabaseHelper
/// </summary>

namespace DatabaseHelper
{
    public class DatabaseHelperMain
    {

        public DatabaseConnectionString dbString = null;

        public DatabaseHelperMain() { }

        public SqlConnection NewConnection()
        {
            SqlConnection c = null;
            try
            {
                c = new SqlConnection();
                c.ConnectionString = dbString.GetDatabaseConnectionString();

            }
            catch (SqlException e)
            {
                throw e;
            }


            return c;
        }

        public string MergeArrayListString(ArrayList list, string glue)
        {
            int count = 0;
            string returnString = "";
            foreach (string item in list)
            {
                if (count == 0)
                {
                    returnString += item;
                }
                else
                {
                    returnString += glue + "" + item;
                }
                count++;
            }

            return returnString;
        }

        /*
         *Method adapted from: http://www.codeproject.com/Tips/483763/Equivalent-function-of-mysql-real-escape-string-in
         *License: The Code Project Open License (http://www.codeproject.com/info/cpol10.aspx)
         */
        public string RealEscapeString(string str)
        {
            return Regex.Replace(str, @"[\x00'""\b\n\r\t\cZ\\%_]", "");
        }



    }
}
