using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Тима", "овчарка");
            Cat cat = new Cat("Мурка", "лысая");
            dog.ShowInfo();
            cat.ShowInfo();
            Console.ReadKey();
        }
    }
}
