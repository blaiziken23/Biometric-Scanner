using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometric_Scanner
{
  public class ConnectionString
  {
    public string server { get; set; }
    public string database { get; set; }
    public string username { get; set; }
    public string password { get; set; }

    public ConnectionString(string server, string database, string username, string password)
    {
      this.server = server;
      this.database = database;
      this.username = username;
      this.password = password;
    }

    public string ConnString()
    {
      return $"server = { server }; database = { database }; uid = { username }; password = { password };";
    }
  }
}
