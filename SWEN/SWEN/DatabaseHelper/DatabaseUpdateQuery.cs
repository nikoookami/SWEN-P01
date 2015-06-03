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
    public class DatabaseUpdateQuery : DatabaseHelperMain
    {
        string query = "";
        string tableName = "";
        string restriction = "";
        ArrayList UpdateData;

        public DatabaseUpdateQuery(DatabaseConnectionString dbString, string tableName, string restriction)
        {
            base.dbString = dbString;

            this.tableName = tableName;
            UpdateData = new ArrayList();
            this.restriction = restriction;
        }

        public DatabaseUpdateQuery(string tableName, string restriction)
        {
            DatabaseHelperSettings settings = new DatabaseHelperSettings();
            DatabaseConnectionString dbString = new DatabaseConnectionString(settings.dbHost, settings.dbUsername, settings.dbPassword, settings.dbName);

            base.dbString = dbString;
            this.tableName = tableName;
            UpdateData = new ArrayList();
            this.restriction = restriction;
        }

        public void AddData(string colName, string colValue)
        {
            UpdateData.Add("" + colName + " = '" + base.RealEscapeString(colValue) + "'");
        }

        public string BuildQuery()
        {
            query = "";

            query += "UPDATE ";
            query += tableName + " ";
            query += "SET ";
            query += base.MergeArrayListString(UpdateData, ",");
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
