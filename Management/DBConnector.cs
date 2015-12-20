using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Management
{
    public class DBConnector
    {
        static string username = "root";
        static string password = "Try2BBest";

        static string connect_str = "DSN=mySQL;" + 
            "UID=" + username + ";PWD=" + password + ";";
        OdbcConnection conn;

        public DBConnector()
        {
            conn = new OdbcConnection(connect_str);
            conn.Open();
        }

        public OdbcDataReader Select(string sql)
        {
            OdbcCommand command = new OdbcCommand(sql, conn);
            OdbcDataReader reader = command.ExecuteReader();
            /*
            while(reader.Read())
            {
                Console.Write(reader.GetBoolean(0));
            }
            */
            return reader;
        }

        public void Close()
        {
            conn.Close();
        }

        private void NonQuery(string sql)
        {
            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void Insert(string sql)
        {
            NonQuery(sql);
        }

        public void Update(string sql)
        {
            NonQuery(sql);
        }

        public void Delete(string sql)
        {
            NonQuery(sql);
        }
    }
}
