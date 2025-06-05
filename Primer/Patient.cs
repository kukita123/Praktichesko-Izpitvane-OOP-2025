using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Дефинирайте клас Patient, който да представя пациентите в една клиника. Нека класът съдържа полета за: номер (цяло число),  
		   име (символен низ), тегло в килограми (цяло число), височина в метри (реално число), и следните елементи:
	   Конструктор по подразбиране и конструктор с параметри;
	   Методи за достъп (setter, getter) до  полетата;
	   Метод за извеждане съдържанието на полетата на обект
	   Метод Output_IBM, която по въведен от потребителя номер на пациент,  връща индекса на телесната маса.  Формулата е: (0.5 т.)
	индекс на телесна маса=(тегло в килограми)/〖височна(в метри)〗^2 
	   Метод OutputMessage, която по въведен от потребителя номер на пациент извежда съобщение на екрана:
	   ако височина*100-тегло>120, извежда се „опасност от поднормено тегло” 
	   ако височина*100-тегло<90, извежда се „опасност от наднормено тегло” 
	   ако височина*100-тегло е >=90, но <=120 извежда се „нормално тегло”
	   Метод CountPatients, която връща брой пациенти с височина над 1.70 м

	В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности за полетата им. Тествайте създадените методи.
    */
namespace Primer
{
    internal class Patient
    {
        private int _number;
        private string _name;
        private int _weight;
        private double _height;

        public Patient()
        {
            this._number = 0;
            this._name = "";
            this._weight = 0;
            this._height = 0;
        }

        public Patient(int number, string name, int weight, int height)
        {
            this._number = Number;
            this._name = Name;          
            this._weight = Weight;          
            this._height = Height;            
        }

        public int Number
        {
            get { return this._number; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Number must be greater than or equal to 0");
                    this._number = 0; // or throw an exception
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
                if (value < 0)
                {
                    Console.WriteLine("Weight must be greater than or equal to 0");
                    this._weight = 0; // or throw an exception
                }
                else
                    this._weight = value; 
            }
        }

        public double Height
        {
            get { return this._height; }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Height must be greater than 0");
                    this._height = 0; // or throw an exception
                }
                else
                    this._height = value; 
            }
        }

        public void PrintPatient()
        {
            Console.WriteLine("Number = {0}, Name: {1}, Weight = {2} kg., Height = {3}", Number, Name, Weight, Height);
        }
    }

}

