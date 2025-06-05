using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Дефинирайте клас Company, който описва  работниците в една фирма. Нека класът съдържа полета за:  номер на работник (цяло число),  
         * вид договор (0 - срочен, 1 - граждански, 2 - безсрочен) (цяло число), националност (символен низ), заплащане (реално число) и следните елементи:
•	Конструктор по подразбиране и конструктор с параметри;
•	Методи за достъп (setter, getter) до  полетата;
•	Метод за извеждане съдържанието на полетата на обект
•	Метод Citizen, който по въведен от потребителя номер на работник, извежда дали е българин или чужденец с думи
•	Метод NumForeigner, който връща брой чужденци във фирмата
•	Метод SumBulgarians, който връща сумата, която трябва да отдели фирмата, за да плати на българите, работещи във фирмата

В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности за полетата им. Тествайте създадените методи.
*/
namespace Zadacha7
{
    internal class Company
    {
        private int _number;
        private int _type;
        private string _nationality;
        private double _salary;

        public Company()
        {
            this._number = 0;
            this._type = 0;
            this._nationality = "";
            this._salary = 0;
        }

        public Company(int number, int type, string nationality, double salary)
        {
            this._number = Number;
            this._type = Type;
            this._nationality = Nationality;            
            this._salary = Salary;
        }

        public int Number
        {
            get { return this._number; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Number must be greater than 0");
                    this._number = 0; // or throw an exception
                }
                else
                    this._number = value; 
            }
        }

        public int Type
        {
            get { return this._type; }
            set 
            {
                if (value < 0 || value > 2)
                {
                    Console.WriteLine("Type must be between 0 and 2");
                    this._type = 0; // or throw an exception
                }
                else
                    this._type = value; 
            }
        }

        public string Nationality
        {
            get { return this._nationality; }
            set { this._nationality = value; }
        }

        public double Salary
        {
            get { return this._salary; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Salary must be greater than or equal to 0");
                    this._salary = 0; // or throw an exception
                }
                else
                    this._salary = value; 
            }
        }

        public void PrintCompany()
        {
            string str = "";
            if (Type == 0) str = "Fixed contract";
            else if (Type == 1) str = "Civil contract";
            else if (Type == 2) str = "Indefinite contract";
            Console.WriteLine("Worker number = {0}, Type of contract: {1}, Nationality = {2}, Salary = {3} BGN", Number, str, Nationality, Salary);
        }

        public void Citizen()
        {
            Console.WriteLine("Worker {0} is a {1}", Number, Nationality);
        }
    }
}
