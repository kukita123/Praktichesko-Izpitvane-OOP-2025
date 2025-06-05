using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Задача 2:
Дефинирайте клас Speciality, който да представя данните за специалностите един в университет. 
Нека класът съдържа полета за:  наименование на специалността (символен низ), брой жени (цяло число), 
брой мъже  (цяло число), среден успех за специалността  (реално число) и следните елементи:
•	Конструктор по подразбиране и конструктор с параметри;
•	Методи за достъп (setter, getter) до  полетата;
•	Метод за извеждане съдържанието на полетата на обект
•	Метод ОutputScore, който по въведено от потребителя наименование на специалност, извежда средния успех 
   с думи (2-слаб, 3-среден, 4-добър, 5-мн.добър, 6-отличен)
•	Метод NumberStudents, който връща брой студенти в специалност, въведена от потребителя 
(брой студенти = брой мъже + брой жени)

В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности 
за полетата им. Тествайте създадените методи.

*/
namespace Zadacha2
{
    internal class Speciality
    {
        private string _specialityName;
        private int _countWomen;
        private int _countMen;
        private double _specialityMarks;

        public Speciality()
        {
            this._specialityName = "";
            this._countWomen = 0;
            this._countMen = 0;
            this._specialityMarks = 2;
        }
        public Speciality(string specialityName, int countWomen, int countMen, double specialityMarks)
        {
            this._specialityName = SpecialityName;
            this._countWomen = CountWomen;
            this._countMen = CountMen;
            this._specialityMarks = SpecialityMarks;
        }
        public string SpecialityName
        {
            get { return this._specialityName; }
            set { this._specialityName = value; }
        }
        public int CountMen
        {
            get { return this._countMen; }
            set 
            { 
                if (value > 0)
                    this._countMen = value;
                else
                    this._countMen = 0;
            }
        }
        public int CountWomen
        {
            get { return this._countWomen; }
            set 
            {
                {
                    if (value > 0)
                        this._countWomen = value;
                    else
                        this._countWomen = 0;
                }
            }
        }
        public double SpecialityMarks
        {
            get { return this._specialityMarks; }
            set
            {
                if (value > 2 && value <= 6)
                {
                    this._specialityMarks = value;
                }
                else
                    this._specialityMarks = 2;
            }
        }
        public void DisplaySpecialityData()
        {
            Console.WriteLine("Speciality data:");
            Console.WriteLine(@"Name: {0}, Count women: {1}, Count men: {2}, Marks: {3}",
                SpecialityName, CountMen, _countWomen, SpecialityMarks);
        }
        public void ОutputScore(string specialityName)
        {
            if (specialityName == SpecialityName)
            {
                if (SpecialityMarks < 3)
                    Console.WriteLine("Слаб");
                else if (SpecialityMarks >= 3 && SpecialityMarks < 3.5)
                    Console.WriteLine("Среден");
                else if (SpecialityMarks >= 3.5 && SpecialityMarks < 4.5)
                    Console.WriteLine("Добър");
                else if (SpecialityMarks >= 4.5 && SpecialityMarks < 5.5)
                    Console.WriteLine("Много добър");
                else
                    Console.WriteLine("Отличен");
            }
            else
                return;
        }
        public int NumberStudents()
        {
            return CountMen + CountWomen;
        }
    }
}
