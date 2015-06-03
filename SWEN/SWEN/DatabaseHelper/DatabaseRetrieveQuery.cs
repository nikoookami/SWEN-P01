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
    public class DatabaseRetrieveQuery : DatabaseHelperMain
    {
        string query = "";
        string tableName = "";
        ArrayList SelectColumn;
        ArrayList Restrictions;
        string opend = "";

        public DatabaseRetrieveQuery(DatabaseConnectionString dbString, string tableName)
        {
            base.dbString = dbString;

            this.tableName = tableName;
            SelectColumn = new ArrayList();
            Restrictions = new ArrayList();
        }

        public DatabaseRetrieveQuery(string tableName)
        {
            DatabaseHelperSettings settings = new DatabaseHelperSettings();
            DatabaseConnectionString dbString = new DatabaseConnectionString(settings.dbHost, settings.dbUsername, settings.dbPassword, settings.dbName);

            base.dbString = dbString;
            this.tableName = tableName;
            SelectColumn = new ArrayList();
            Restrictions = new ArrayList();
        }

        public void AddColumn(string ColumnName)
        {
            SelectColumn.Add(ColumnName);
        }

        public void AddRestriction(string restriction)
        {
            Restrictions.Add(restriction);
        }

        public void AddRestriction(string col, string op, string result)
        {
            Restrictions.Add(col + "" + op + "'" + result + "'");
        }

        public void AddOpend(string Opend)
        {
            this.opend = Opend;
        }

        public string BuildQuery()
        {
            query = "";
            query += "SELECT ";
            if (SelectColumn.Count == 0)
            {
                query += "* ";
            }
            else
            {
                query += base.MergeArrayListString(SelectColumn, ",") + " ";
            }
            query += "FROM ";
            query += tableName + " ";
            if (Restrictions.Count > 0)
            {
                query += "WHERE ";
                query += base.MergeArrayListString(Restrictions, " AND ") + " ";
            }

            query += opend;

            return query;
        }

        public SqlDataReader RunQuery()
        {
            return RunQuery(this.BuildQuery());
        }

        public SqlDataReader RunQuery(string query)
        {
            SqlDataReader result;
            try
            {
                SqlConnection c = base.NewConnection();
                c.Open();
                SqlCommand command = new SqlCommand(query, c);
                result = command.ExecuteReader();
            }
            catch (SqlException e)
            {
                throw e;
            }

            return result;
        }
    }
}
