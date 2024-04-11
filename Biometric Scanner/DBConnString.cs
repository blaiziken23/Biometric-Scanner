using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometric_Scanner
{
  public class DBConnString
  {
    /*static string server = Properties.Settings.Default.server;
    static string dbname = Properties.Settings.Default.dbname;
    static string username = Properties.Settings.Default.username;
    static string password = Properties.Settings.Default.password;*/

    static string server = "localhost";
    static string dbname = "atomic_builders_opc";
    static string username = "root";
    static string password = "";

    public static string connstring()
    {
      ConnectionString conn = new ConnectionString(server, dbname, username, password);
      return conn.ConnString();
    }
  }
}
