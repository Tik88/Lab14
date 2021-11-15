using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog ();
            cat.Name = "Кошка";
            dog.Name = "Собака";
            cat.ShowInfo();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string Name { set; get; }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write("{0} ", Name);
            Say();
        }
    }  
    class Cat : Animal
    {
        string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog : Animal
    {
        string name;
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override void Say()
        {
            Console.WriteLine("Гав ");
        }
    }
   

}
