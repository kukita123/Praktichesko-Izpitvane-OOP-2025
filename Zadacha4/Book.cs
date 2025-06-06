using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Задача 4:
Дефинирайте клас  Book,  който да представя наличните книги в библиотека. Нека класът съдържа полета за: 
    заглавие на книгата (символен низ), автор (символен низ), цена (реално число), брой налични книги (цяло число) и следните елементи:
•	Конструктор по подразбиране и конструктор с параметри;
•	Методи за достъп (setter, getter) до  полетата;
•	Метод за извеждане съдържанието на полетата на обект
•	Метод за проверка, който по въведено от потребителя заглавие на книга, връща дали има свободни 
    бройки от книгата.
•	Метод за изчисляване общата цена на всички книги.
В Main() декларирайте масив от n обекта от класа (3 <= n <= 20) и въведете конкретни стойности за полетата им.
Тествайте създадените методи.

     */
namespace Zadacha4
{
    internal class Book
    {
        private string _name;
        private string _autor;
        private double _price;
        private int _count;

        public Book()
        {
            this._name = "";
            this._autor = "";
            this._price = 0;
            this._count = 0;
        }
        public Book(string name, string autor, double price, int count)
        {
            this._name = Name;
            this._autor = Autor;
            this.Price = price;
            this.Count = count;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Autor
        {
            get { return this._autor; }
            set { this._autor = value; }
        }
        public double Price
        {
            get { return this._price; }
            set 
            {
                if (value > 0)
                    this._price = value;
                else 
                    this._price = 0;
            }

        }
        public int Count
        {
            get { return this._count; }
            set 
            {
                if (value > 0)
                    this._count = value;
                else
                    this._count = 0;
            }
        }

        public void DisplayBook()
        {
            Console.WriteLine(@"Book name: {0},
Autor: {1},
Price: {2},
Available counts: {3}",
Name, Autor, Price, Count);
        }
        public int Availability(string name)
        {
            if (Name == name && Count > 0)
                return Count;
            return 0;
        }
    }
}
