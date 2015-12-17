using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Odbc;

namespace Management
{
    [Serializable]
    public class DBConnector
    {
        static string username = "root";
        static string password = "Try2BBest";
        static string connect_str = "DSN=mySQL;" + 
            "UID=" + username + ";PWD=" + password + ";";
        OdbcConnection conn;
        
        public void Select(string sql)
        {
            conn = new OdbcConnection(connect_str);
            conn.Open();
            OdbcCommand cmd = new OdbcCommand(sql, conn);
            OdbcDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Console.Write(reader.GetBoolean(0));
            }
            conn.Close();
        }

        private void NonQuery(string sql)
        {
            conn = new OdbcConnection(connect_str);
            conn.Open();
            OdbcCommand cmd = new OdbcCommand(sql, conn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
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
