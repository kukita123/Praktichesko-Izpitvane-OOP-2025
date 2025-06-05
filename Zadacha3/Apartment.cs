using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Задача 3:
Дефинирайте клас Apartment, който да представя наличните апартаменти за продажба от строителна фирма. 
Нека класът съдържа полета за: местоположение (1 - център, 2 - широк център, 3 - други райони) (цяло число), 
квадратура (цяло число), цена (реално число) и следните елементи:
•	Конструктор по подразбиране и конструктор с параметри;
•	Методи за достъп (setter, getter) до полетата;
•	Метод за извеждане съдържанието на полетата на обект
•	Метод PriceOutput, който извежда цените на всички апартаменти, които се намират в центъра(0.5 т)
•	Метод АdditionalSum за изчисляване и извеждане на допълнителното оскъпяване на всеки един апартамент. 
    Допълнителното оскъпяване се изчислява по следната формула:
        o	ако местоположението на апартамента е центъра и квадратурата е по-голяма от 120 кв.м, допълнителното 
        оскъпяване е 1300
        o	ако апартаментът е в широкия център и квадратурата е по-голяма от 120 кв.м, допълнителното 
        оскъпяване е 1000
        o	във всички останали случаи няма оскъпяване
•	Метод SumApartment, който връща сумата от цените на всички апартаменти 

В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности за полетата им. Тествайте създадените методи.

     */
namespace Zadacha3
{
    internal class Apartment
    {
        private int _place;
        private int _size;
        private double _price;

        public Apartment()
        {
            this._place = 0;
            this._size = 0;
            this._price = 0;
        }
        public Apartment(int place, int size, double price)
            : this()
        {
            this._place = Place;
            this._size = Size;
            this._price = Price;
        }
        public int Place
        {
            get { return this._place; }
            set 
            {
                if (value == 1 || value == 2 || value == 3)
                    this._place = value;
                else
                    this._place = 0; // Invalid place, set to default
            }
        }
        public int Size
        {
            get { return this._size; }
            set 
            {
                if (value > 20)
                    this._size = value;
                else
                    this._size = 0; 
            }
        }
        public double Price
        {
            get { return this._price; }
            set 
            {
                if (value >= 0)
                    this._price = value;
                else
                    this._price = 0; // Invalid price, set to default
            }
        }
        public void DisplayApartmentData()
        {
            string place = "";
            if (Place == 1)
                place = "център";
            if (Place == 2)
                place = "широк център";
            if (Place == 3)
                place = "други райони";
            Console.WriteLine("Местоположение: {0}, размер: {1} кв. м., цена с оскъпяване: {2}", place, Size, Price + this.AdditionalSum());
        }
        public double AdditionalSum()
        {
            double additionalSum = 0;
            if (Place == 1 && Size > 120)
                additionalSum = 1300;
            if (Place == 2 && Size > 120)
                additionalSum = 1000;

            return additionalSum;
        }
    }
}
