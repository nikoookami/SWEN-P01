using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseHelper
{
    public class DatabaseConnectionString
    {
        public string DatabaseServer { get; set; }
        public string DatabaseUsername { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseName { get; set; }

        public DatabaseConnectionString(string DatabaseServer, string DatabaseUsername, string DatabasePassword, string DatabaseName)
        {
            this.DatabaseServer = DatabaseServer;
            this.DatabaseUsername = DatabaseUsername;
            this.DatabasePassword = DatabasePassword;
            this.DatabaseName = DatabaseName;
        }

        public DatabaseConnectionString()
        {

        }

        public String GetDatabaseConnectionString()
        {
            //return "server=" + DatabaseServer + ";database=" + DatabaseName + ";uid=" + DatabaseUsername + ";password=" + DatabasePassword + "";
            return "data source=localhost;initial catalog=DelonixRegia;integrated security=true;";
        }
    }
}

