namespace PersonalregisterVersion2;

internal class Program
{
    static void Main(string[] args)
    {
        var quit = "Q";
        string choice;
        Presentation();
        while (choice.ToUpper() != quit)
        {
            Presentation();
        }

        void Presentation()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1: Add a new Employee");
            Console.WriteLine("2: Display all employees details");
            Console.WriteLine("3: Display one employee details");
            Console.WriteLine("Q: Quit");
            choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "1":
                    AddEmployee();
                    break;
                case "2":
                    PayRoll.GetDetails();
                    break;
                case "3":
                    GetEmployeeById();
                    break;
                case "Q": break;
                default:
                    Console.WriteLine("Wrong entry!");
                    Presentation();
                    break;
            };
        }

        void GetEmployeeById()
        {
            var personNummer = "";

            while (!isValid(personNummer))
            {
                Console.WriteLine("Enter PersonNummer:");
                personNummer = Console.ReadLine();
            }

            PayRoll.GetEmployeeByPersonNummer(personNummer);
        }

        void AddEmployee()
        {
            string personNummer, firstName, lastName;
            int salary = 0;
            personNummer = firstName = lastName = "";
            
            while(!isValid(personNummer))
            {
                Console.WriteLine("Enter PersonNummer:");
                personNummer = Console.ReadLine();
            }

            while (!isValid(firstName))
            {
                Console.WriteLine("Enter Firstname:");
                firstName = Console.ReadLine();
            }

            while (!isValid(lastName))
            {
                Console.WriteLine("Enter Lastname:");
                lastName = Console.ReadLine();
            }

            Console.WriteLine("Enter Salary:");
            var inputSalary = Console.ReadLine();
            
            while(!int.TryParse(inputSalary, out salary))
            {
                Console.WriteLine("Wrong entry!");
                Console.WriteLine("Enter Salary:");
                inputSalary = Console.ReadLine();
            }
            Employee employee = new Employee( personNummer, firstName,lastName,salary);

            PayRoll.RegisterEmployee(employee);
        }
        
        Boolean isValid(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
