using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Seek_Sale
{
    public class DBConnector
    {
        public static string username = "root";
        public static string password = "690111";
        public static string connect_str = "dsn=seeksale;DRIVER={MySQL ODBC 5.3 Unicode Driver};" +
                                "SERVER=localhost;" +
                                "DATABASE=leftover;" +
                                "UID=" + username + ";" +
                                "PASSWORD=" + password + ";";
        string msg;
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
