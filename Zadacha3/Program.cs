namespace Zadacha3
{
    internal class Program
    {
        static double SumApartment(Apartment[] apartments)
        {
            double sum = 0;
            foreach (var item in apartments)
            {
                sum += item.Price + item.AdditionalSum();
            }
            return sum;
        }
        static void Main(string[] args)
        {

            Random random = new Random();
            int n = random.Next(3, 21);

            Apartment[] apartments = new Apartment[n];
            for (int i = 0; i < apartments.Length; i++)
            {
                apartments[i] = new Apartment();
                Console.Write("Район на апартамент - 1, 2 или 3: ");
                apartments[i].Place = int.Parse(Console.ReadLine());
                Console.Write("Размер: ");
                apartments[i].Size = int.Parse(Console.ReadLine());
                Console.Write("Цена: ");
                apartments[i].Price = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Обща цена на апартаментите: {0}", SumApartment(apartments));

            for (int i = 0; i < apartments.Length; i++)
            {
                Console.WriteLine("Апартамент {0}", i + 1);
                apartments[i].DisplayApartmentData();
            }
        }   
    }
}
