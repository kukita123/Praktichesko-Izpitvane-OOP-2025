namespace Zadacha5
{
    internal class Program
    {
        public static int DoubleWeight(Animal animal)
        {
            return animal.Weight * 2;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(3, 20);
            

            Animal[] animal = new Animal[n];
            for (int i = 0; i < animal.Length; i++)
            {
                animal[i] = new Animal();
            }
            for (int i = 0; i < animal.Length; i++)
            {
                Console.WriteLine("Enter animal number");
                animal[i].Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter animal name");
                animal[i].Name = Console.ReadLine();
                Console.WriteLine("Enter animal weight");
                animal[i].Weight = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("These are the animals:");
            for (int i = 0; i < animal.Length; i++)
            {
                animal[i].PrintAnimals();
            }

            Console.WriteLine("Enter unit of measure type: kg, pound or ton");
            string unit = Console.ReadLine();
            for (int i = 0; i < animal.Length; i++)
            {
                animal[i].OutputWeight(unit);
            }
            Console.WriteLine("Enter number of an animal whose weight is doubled");
            int dNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < animal.Length; i++)
            {
                if (animal[i].Number == dNumber)
                    Console.WriteLine("Double wight of {0} is = {1} kg.", animal[i].Name, DoubleWeight(animal[i]));
            }

        }
    }
}
