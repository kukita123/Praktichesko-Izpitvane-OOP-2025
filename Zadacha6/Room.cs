using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Дефинирайте клас Room, която описва  стаите в един хотел. Нека класът съдържа полета за:  номер на стая (цяло число), 
     вид стая (0-единична, 1-двойна, 2-апартамент) (цяло число), заетост (логическа стойност), цена (реално число) и следните елементи:
•	Конструктор по подразбиране и конструктор с параметри;
•	Методи за достъп (setter, getter) до  полетата;
•	Метод за извеждане съдържанието на полетата на обект
•	Метод RoomFloor, която по въведен от потребителя номер на стая  връща етажа, на която се намира стаята – цифрата на десетиците показва номера на етажа
•	Метод SumRooms, която извежда сумата от цените на свободните стаи в хотела

В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности за полетата им. Тествайте създадените методи.
*/
namespace Zadacha6
{
    internal class Room
    {
        private int _number;
        private int _type;
        private bool _occupied;
        private double _price;
        public Room()
        {
            this._number = 0;
            this._type = 0;
            this._occupied = false;
            this._price = 0;
        }
        public Room(int number, int type, bool occupied, double price)
        {
            this.Number = number;
            this.Type = type;
            this.Occupied = occupied;
            this.Price = price;
        }
        public int Number
        {
            get { return this._number; }
            set
            {
                if (value >= 10 && value < 100)                
                    this._number = value;                
                else
                {
                    Console.WriteLine("Number must be between 10 and 99");
                    this._number = 10; // or throw an exception
                }
            }
        }
        public int Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        public bool Occupied
        {
            get { return this._occupied; }
            set { this._occupied = value; }
        }
        public double Price
        {
            get { return this._price; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Price must be greater than or equal to 0");
                    this._price = 0; // or throw an exception
                }
                else
                    this._price = value; 
            }
        }
        public void PrintRoom()
        {
            string str = "";
            if (Occupied) 
                str = "Yes";
            else 
                str = "No";
            Console.WriteLine("Number = {0}, Type: {1}, Occupied = {2}, Price = {3} BGN", Number, Type, str, Price);
        }
        public int RoomFloor()
        {
            int floor = Number / 10 ;
            return floor;
        }
    }
}
