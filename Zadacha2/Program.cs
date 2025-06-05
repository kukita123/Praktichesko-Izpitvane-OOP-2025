namespace Zadacha2
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(3, 21);

            Speciality[] specialityies = new Speciality[n];
            for (int i = 0; i < specialityies.Length; i++)
            {
                specialityies[i] = new Speciality();
                Console.WriteLine("Enter data for speciality number {0}:", i + 1);

                Console.Write("Enter speciality name:");
                specialityies[i].SpecialityName = Console.ReadLine();
                Console.Write("Enter women count:");
                specialityies[i].CountWomen = int.Parse(Console.ReadLine());
                Console.Write("Enter men count:");
                specialityies[i].CountMen = int.Parse(Console.ReadLine());
                Console.Write("Enter speciality marks:");
                specialityies[i].SpecialityMarks = double.Parse(Console.ReadLine());
            }
            foreach (var item in specialityies)
            {
                item.DisplaySpecialityData();
            }
            Console.WriteLine("Enter speciality name to check:");
            string specialityName = Console.ReadLine();
            foreach (var item in specialityies)
            {
                if (item.SpecialityName == specialityName)
                {
                    item.ОutputScore(specialityName);
                    Console.WriteLine("Number of stubents: {0}", item.NumberStudents());
                }
            }
        }
    }
}
