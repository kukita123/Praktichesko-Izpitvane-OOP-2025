namespace Zadacha7
{
    internal class Program
    {
        static int NumForeigner(Company[] arr)
        {
            int br = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Nationality != "Bulgarian")
                    br++;
            }
            return br;
        }

        static double SumBulgarians(Company[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Nationality == "Bulgarian")
                    sum += arr[i].Salary;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(3, 10);
           
            Company[] workers = new Company[n];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Company();
            }
            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine("Enter worker number");
                workers[i].Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter type of contract: 0 - Fixed contract, 1 - Civil contract, 2 - Indefinite contract");
                workers[i].Type = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter nationality of worker: Bulgarian or Foreigner");
                workers[i].Nationality = Console.ReadLine();
                Console.WriteLine("Enter worker salary");
                workers[i].Salary = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("These are the workers:");
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].PrintCompany();
            }

            Console.WriteLine("Enter number of worker: ");
            int num = int.Parse(Console.ReadLine());
            foreach (var item in workers)
            {
                if (item.Number == num)
                    item.Citizen();
            }

            Console.WriteLine("The number of foreign worker in company are = {0}", NumForeigner(workers));
            Console.WriteLine("The amount that the company has to set aside in order to pay the Bulgarians working in the company are: {0}", SumBulgarians(workers));
        }
    }
}
