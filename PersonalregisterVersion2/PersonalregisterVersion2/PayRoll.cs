using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonalregisterVersion2;

internal static class PayRoll
{
    static Dictionary<string,Employee> EmployeesList = new Dictionary<string,Employee>();


    internal static void GetEmployeeByPersonNummer(string personNummer)
    {
        if(!EmployeesList.TryGetValue(personNummer, out Employee employee))
        {
            Console.WriteLine($"No employee with 'PersonNummer:' {personNummer} found!");
        } else
        {
            DisplayDetail(employee);
        }
    }

    internal static void RegisterEmployee(Employee employee)
    {
        EmployeesList.Add(employee.PersonNummer, employee);
    }

    internal static void GetDetails()
    {
        if(!EmployeesList.Any())
        {
            Console.WriteLine("No employees registered yet!");
        } else
        {
            foreach (var employee in EmployeesList)
            {
                DisplayDetail(employee.Value);
            }
        }
            
    }

    private static void DisplayDetail(Employee employee)
    {
        Console.WriteLine($"PersonNummer: {employee.PersonNummer}" +
                   $" Firstname:{employee.FirstName}" +
                   $" Lastname:{employee.LastName}" +
                   $" Salary: {employee.Salary}");
    }
}
