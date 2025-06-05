using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Дефинирайте клас Animal, който да представя животните в зоологическа градина. Нека класът съдържа полета за: номер (цяло число),
        * име (символен низ), тегло в килограми (цяло число), и следните елементи: 
•	Конструктор по подразбиране и конструктор с параметри;
•	Методи за достъп (setter, getter) до  полетата;
•	Метод за извеждане съдържанието на полетата на обект
•	Метод OutputWeight, който да извежда теглото на животните. Функцията да позволява извеждане на теглото в кг, 
       паунди (1килограм е равен на 2,2046 паунда), тона. Вида на мерната единица да се въвежда от потребителя 
•	Метод DoubleWeight, който по въведен от потребителя номер на животно  да връща неговото тегло, умножено по 2 
В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности за полетата им. Тествайте създадените методи.
*/
namespace Zadacha5
{
    internal class Animal
    {
        private int _number;
        private string _name;
        private int _weight;
        public Animal()
        {
            this._number = 1;
            this._name = "NoName";
            this._weight = 0;
        }
        public Animal(int number, string name, int weigth)
        {
            this._number = Number;
            this._name = name;
            if (weigth > 0)
                this._weight = weigth;
            else
                this._weight = 0;
        }
        public int Number
        {
            get { return this._number; }
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Number must be greater than 0");
                    this._number = 1; // or throw an exception
                }
                else
                    this._number = value; 
            }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int Weight
        {
            get { return this._weight; }
            set 
            { 
                if(value>0)
                    this._weight = value;
                else
                {
                    Console.WriteLine("Weight must be greater than 0");
                    this._weight = 0; // or throw an exception
                }
            }
        }

        public void PrintAnimals()
        {
            Console.WriteLine("Number = {0}, Name: {1}, Weight = {2} kg.", Number, Name, Weight);
        }
        public void OutputWeight(string type)
        {
            if (type == "kg")
                Console.WriteLine("Weight of {0} is {1} kg", Name, Weight);
            else if (type == "pound")
                Console.WriteLine("Weight of {0} is {1:f2} pounds", Name, (double)Weight * 2.2046);
            else if (type == "ton")
                Console.WriteLine("Weight of {0} is {1:f2} ton", Name, (double)Weight / 1000);
            else 
                Console.WriteLine("Incorect data");
        }
    }
}
