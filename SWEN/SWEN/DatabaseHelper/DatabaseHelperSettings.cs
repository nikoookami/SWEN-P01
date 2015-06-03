using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatabaseHelper;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

/// <summary>
/// Summary description for DatabaseHelperSettings
/// </summary>

namespace DatabaseHelper
{
    public class DatabaseHelperSettings : DatabaseHelperMain
    {
        public string dbHost;
        public string dbUsername;
        public string dbPassword;
        public string dbName;

        public DatabaseHelperSettings()
        {

            dbHost = "localhost";
            dbUsername = "shawnie";
            dbPassword = "1234";
            dbName = "Supplier2Database";

        }
    }

}
