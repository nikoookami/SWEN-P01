using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Collections;
using System.Data.SqlClient;
using DatabaseHelper;

namespace DatabaseHelper
{
    public class DatabaseDeleteQuery : DatabaseHelperMain
    {
        string query = "";
        string tableName = "";
        string restriction = "";

        public DatabaseDeleteQuery(DatabaseConnectionString dbString, string tableName, string restriction)
        {
            base.dbString = dbString;
            this.tableName = tableName;
            this.restriction = base.RealEscapeString(restriction);
        }


        public DatabaseDeleteQuery(string tableName, string restriction)
        {
            DatabaseHelperSettings settings = new DatabaseHelperSettings();
            DatabaseConnectionString dbString = new DatabaseConnectionString(settings.dbHost, settings.dbUsername, settings.dbPassword, settings.dbName);
            base.dbString = dbString;
            this.tableName = tableName;
            this.restriction = base.RealEscapeString(restriction);
        }

        public string BuildQuery()
        {
            query = "";
            query += "DELETE FROM ";
            query += tableName + " ";
            query += "WHERE ";
            query += restriction + " ";
            return query;
        }

        public bool RunQuery()
        {
            return RunQuery(this.BuildQuery());
        }

        public bool RunQuery(string query)
        {
            bool result = false;
            try
            {
                SqlConnection c = base.NewConnection();
                c.Open();
                SqlCommand command = new SqlCommand(query, c);
                int numInserted = command.ExecuteNonQuery();

                if (numInserted > 0)
                {
                    result = true;
                }

            }
            catch (SqlException e)
            {
                throw e;
            }

            return result;
        }

    }
}