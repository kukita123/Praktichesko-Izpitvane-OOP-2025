namespace Zadacha6
{
    internal class Program
    {
        static double SumRooms(Room[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!arr[i].Occupied)
                    sum += arr[i].Price;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(3, 10);           

            Room[] rooms = new Room[n];
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room();
            }
            for (int i = 0; i < rooms.Length; i++)
            {
                Console.WriteLine("Enter room number");
                rooms[i].Number = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter room type: 0-single, 1-double, 2-apartment");
                rooms[i].Type = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Occupancy of the room: Yes or No ");
                string occup = Console.ReadLine();
                if (occup.ToLower() == "yes")
                    rooms[i].Occupied = true;
                else 
                    rooms[i].Occupied = false;
                Console.WriteLine("Enter room price");
                rooms[i].Price = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("These are the rooms:");
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i].PrintRoom();
            }
            Console.WriteLine("Enter number of room: ");
            int num = int.Parse(Console.ReadLine());
            foreach (var item in rooms)
            {
                if (item.Number == num)
                    Console.WriteLine("Room number {0} are on {1} floor.", item.Number, item.RoomFloor());
            }
            Console.WriteLine("The sum of the hotel's free room rates is = {0}", SumRooms(rooms));
        }
    }
}
