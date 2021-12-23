using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_Abstract_class
{
    /*Разработать абстрактный класс Animal, который описывает животное.Класс содержит следующие элементы:
      абстрактное свойство - название животного.
     В классе Animal нужно определить следующие методы:
        -конструктор, устанавливающий значение по умолчанию для названия;
        -абстрактный метод Say(), который выводит звук, который издает животное;
        -неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук(вызывая метод Say()).
 
Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal.В классах реализовать следующие элементы:
 
    свойство – название животного;
    метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
 
Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.*/


    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();

        public void ShowInfo() 
        {
            Console.WriteLine(Name);
            Say();

        }

    }

    class Cat : Animal
    {

 
        public override string Name { get; set; }
        public Cat(string name) : base(name) { }

        public override void Say()  //переопределен метод класса
        {
            Console.WriteLine("МЯУ");

        }



    }
    class Dog : Animal
    {

        public override string Name { get; set; }

        public Dog(string name) : base(name) { }

        public override void Say()  //Метод класса
        {
            Console.WriteLine("ГАВ");

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите градусы в диапазоне от 0 до 360");
            //int a = Convert.ToInt32(Console.ReadLine());

            Cat cat = new Cat("Мурка");
            Dog dog = new Dog("Шарик");
            cat.ShowInfo();
            dog.ShowInfo();






            Console.ReadKey();
        }
    }
}

