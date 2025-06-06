using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Дефинирайте клас Employee, който да представя работниците в една фирма. Нека класът съдържа полета за: 
 име на работника (символен низ), часове извънреден труд (цяло число), заплата (реално число), 
 година на постъпване във фирмата (цяло число) и следните елементи:
•	Конструктор по подразбиране и конструктор с параметри;
•	Методи за достъп (setter, getter) до  полетата;
•	Метод за извеждане съдържанието на полетата на обект
•	Метод SalaryOutput, която връща заплатата на работника, по въведено от потребителя име на работник (приемаме, че няма два работника с еднакви имена)
•	Метод Amount за изчисляване на допълнително възнаграждение, по въведено от потребителя име на работник. 
    Допълнителното възнаграждение се изчислява по следната формула: 
    o	ако брой часове <5, не се начислява допълнително възнаграждение
    o	ако са >=5, но <=10, допълнителното възнаграждение е 10% от заплатата
    o	ако са >10, допълнителното възнаграждение е 15% от заплатата
•	Метод ServiceYears, с който се проверява дали въведен от потребителя работник има повече от три прослужени
    години във фирмата (прослужени години = текущата година -годината на постъпване)
В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности за полетата им.
Тествайте създадените методи. 

 */
namespace Zadacha1
{
    internal class Employee
    {

        private string _name;
        private int _hours;
        private double _salary;
        private int _year;

        public Employee()
        {
            this._name = "";
            this._hours = 0;
            this._salary = 0;
            this._year = 0;
        }
        public Employee(string name, int hours, double salary, int year)
        {
            this._name = name;
            this.Hours = hours;
            this.Salary = salary;
            this.Year = year;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int Hours
        {
            get { return this._hours; }
            set
            {
                if (value > 0 && value < 10)
                    this._hours = value;
                else
                    this._hours = 0;
            }
        }
        public double Salary
        {
            get { return this._salary; }
            set
            {
                if (value > 1900)  //1900 - minimalna rabotna zaplata
                    this._salary = value;
                else
                    this._salary = 1900;
            }
        }
        public int Year
        {
            get { return this._year; }
            set
            {
                if (value < DateTime.Now.Year) //или 2025
                    this._year = value;
                else
                    this._year = DateTime.Now.Year;
            }
        }
        public void DisplayEmployee()
        {
            Console.WriteLine(
                @"Employee name: {0},
                 Overtime: {1},
                 Salary: {2},
                 Year of admission: {3}",
                Name, Hours, Salary, Year);
        }
        public double Amount()
        {
            double amount;
            if (this._hours < 5)
                amount = 0;
            else if (this._hours > 5 && this._hours < 10)
                amount = this.Salary * 10 / 100;
            else
                amount = this.Salary * 15 / 100;

            return amount;
        }
        public bool ServiceYears()
        {
            if (DateTime.Now.Year - this._year > 3) //или 2025 - this.year > 3
                return true;
            return false;
        }
    }
}
