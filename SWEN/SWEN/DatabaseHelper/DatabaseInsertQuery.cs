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
    public class DatabaseInsertQuery : DatabaseHelperMain
    {

        string query = "";
        string tableName = "";
        ArrayList InsertColName;
        ArrayList InsertData;

        public DatabaseInsertQuery(DatabaseConnectionString dbString, string tableName)
        {
            base.dbString = dbString;

            this.tableName = tableName;
            InsertColName = new ArrayList();
            InsertData = new ArrayList();
        }

        public DatabaseInsertQuery(string tableName)
        {
            DatabaseHelperSettings settings = new DatabaseHelperSettings();
            DatabaseConnectionString dbString = new DatabaseConnectionString(settings.dbHost, settings.dbUsername, settings.dbPassword, settings.dbName);

            base.dbString = dbString;
            this.tableName = tableName;
            InsertColName = new ArrayList();
            InsertData = new ArrayList();
        }

        public void AddData(string colName, string data)
        {
            InsertColName.Add(colName);
            InsertData.Add("'" + base.RealEscapeString(data) + "'");
        }

        public string BuildQuery()
        {
            query = "";

            query += "INSERT INTO ";
            query += tableName + " ";
            query += "(" + base.MergeArrayListString(InsertColName, ",") + ") ";
            query += "VALUES ";
            query += "(" + base.MergeArrayListString(InsertData, ",") + ") ";
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

