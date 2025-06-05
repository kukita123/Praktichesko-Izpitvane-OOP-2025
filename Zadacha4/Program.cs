namespace Zadacha4
{
    internal class Program
    {
        static public double PriceSum(Book[] books)
        {
            double sum = 0;
            foreach (var item in books)
            {
                sum += item.Count * item.Price;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(3, 21);
            Book[] books = new Book[n];

            for (int i = 0; i < books.Length; i++)
            {
                Console.Write("Enter book name: ");
                string bookName = Console.ReadLine();
                Console.Write("Enter autor: ");
                string autor = Console.ReadLine();
                Console.Write("Enter book's price: ");
                double bookPrice = double.Parse(Console.ReadLine());
                Console.Write("Enter book's count: ");
                int bookCount = int.Parse(Console.ReadLine());

                books[i] = new Book(bookName, autor, bookPrice, bookCount); // с конструктор с параметри

            }

            Console.Write("Enter book to chech availability: ");
            string book = Console.ReadLine();
            foreach (var item in books)
            {
                if (item.Name == book)
                    Console.WriteLine("Number available books: {0}", item.Availability(book));
                break;
            }

            double sum = 0;
            foreach (var item in books)
            {
                sum += item.Count * item.Price;
            }
            Console.WriteLine("The all books price is: {0}", sum);
        }
    }
}
