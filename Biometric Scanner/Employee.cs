using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biometric_Scanner
{
  public class Employee
  {
    public int Id { get; set; }
    public string Id_number { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }

    public Employee(int Id, string Id_number, string firstname, string lastname)
    {
      this.Id = Id;
      this.Id_number = Id_number;
      this.Firstname = firstname;
      this.Lastname = lastname;
    }

    public override string ToString()
    {
      return $"{Id_number} - {Lastname} {Firstname}";
    }
  }
}
