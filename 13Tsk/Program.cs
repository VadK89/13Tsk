using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Tsk
{
    /*Задан класс Building, который описывает здание. Класс содержит следующие элементы:
     •	адрес здания;
     •	длина здания;
     •	ширина здания;
     •	высота здания.
     В классе Building нужно реализовать следующие методы:
     •	конструктор с 4 параметрами;
     •	свойства get/set для доступа к полям класса;
     •	метод Print(), который выводит информацию о здании.
     Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. В классе MultiBuilding реализовать следующие элементы:
     •	конструктор с 5 параметрами – реализует вызов конструктора базового класса;
     •	свойство get/set доступа к внутреннему полю класса;
     •	метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
     Класс MultiBuilding сделать таким, что не может быть унаследован.

     * 
      */
    class Program
    {
        static void Main(string[] args)
        {

            //Ввод исходных данных первого здания      
            Console.WriteLine("Введите исходные данные для первого здания");
            Console.WriteLine("Введите адрес здания");
            string ad = Console.ReadLine();
            Console.WriteLine("Введите длину здания");
            double leng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину здания");
            double wid = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту здания");
            double hei = Convert.ToDouble(Console.ReadLine());
            Building building = new Building(ad, leng, wid, hei);
            //Ввод исходных данных второго здания 
            Console.WriteLine("Введите исходные данные для второго здания");
            Console.WriteLine("Введите адрес второго здания");
            string ad1 = Console.ReadLine();
            Console.WriteLine("Введите длину второго здания");
            double leng1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину второго здания");
            double wid1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите высоту второго здания");
            double hei1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите количество этажей второго здания");
            int flo = Convert.ToInt32(Console.ReadLine());
            MultiBuilding building1 = new MultiBuilding(ad1, leng1, wid1, hei1, flo);
            //Вывод результатов
            Console.WriteLine("Данные о первом здании");
            building.Print();
            Console.WriteLine("Данные о втором здании");
            building1.Print();
            Console.ReadLine();
        }
    }

    //Создаем класс Building
    class Building
    {
        //Задаем свойстсва
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        //Задаем базовый конструктор
        public Building()
        {

        }

        //Задаем конструктор с 4 параметрами
        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }
        //Создаем метод Print для вывода информации
        public void Print()
        {
            Console.WriteLine("Адрес здания: {0}", Address);
            Console.WriteLine("Длина здания составляет: {0} м", Length);
            Console.WriteLine("Ширина здания составляет: {0} м", Width);
            Console.WriteLine("Высота здания составляет: {0} м", Height);
        }

    }
    //Создаем класс MultiBuilding,на основании класса Building
    sealed class MultiBuilding : Building
    {
        //Задаем дополнительное свойство этажности
        public int Floor { get; set; }

        //Задаем дополнительный конструктор на 5 параметров
        public MultiBuilding(string address1, double length1, double width1, double height1, int floor1)
        {
            Address = address1;
            Length = length1;
            Width = width1;
            Height = height1;
            Floor = floor1;
        }
        //Задаем метод для вывод информации
        public void Print()
        {
            base.Print();
            Console.WriteLine("Количество этажей в здании {0}", Floor);
        }


    }
}
