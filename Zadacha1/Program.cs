namespace Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(3, 21);

            Employee[] employees = new Employee[n];
            for (int i = 0; i < employees.Length; i++)
            {
                employees[i] = new Employee();
                Console.Write("Enter employee's name: ");
                employees[i].Name = Console.ReadLine();
                Console.Write("Enter overtime: ");
                employees[i].Hours = int.Parse(Console.ReadLine());
                Console.Write("Enter employee's salary: ");
                employees[i].Salary = double.Parse(Console.ReadLine());
                Console.Write("Enter employee's year of admission: ");
                employees[i].Year = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("These are the employees:");
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee number {i + 1}");
                employees[i].DisplayEmployee();
            }

            Console.WriteLine();
            Console.Write("Enter the employee name to calculate the amount: ");
            string name = Console.ReadLine();
            double extraSalary = 0;
            bool serviseYears = false;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Name == name)
                {
                    extraSalary = employees[i].Amount();
                    serviseYears = employees[i].ServiceYears();
                }
            }
            Console.WriteLine($"The {name}'s amount is: {extraSalary}");
            if (serviseYears)
                Console.WriteLine($"The {name} has more than three years experience");
            else
                Console.WriteLine($"The {name} hasn't more than three years experience");

        }
    }
}
