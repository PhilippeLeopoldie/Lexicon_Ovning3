using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalregisterVersion2;

internal class Employee
{
    internal string PersonNummer { get; set; }
    internal string FirstName { get; set; }
    internal string LastName { get; set; }
    internal int Salary {get; set;}

    internal Employee(string personNummer, string firstName, string lastName, int salary) 
    {
        PersonNummer = personNummer;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }
}
