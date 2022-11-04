using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
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
            Console.WriteLine("{0}:",Name);
            Say();
        }
    }


    class Dog : Animal
    {
        string name;
        string breedOfDog;

        public override string Name
        {
            get {return name;}
            set {name = value;}
        }

        public string BreedOfDog
        {
            get { return breedOfDog; }
            set { breedOfDog = value; }
        }
        public override void Say()
        {
            Console.WriteLine("Я собака породы {0}, Гав!", BreedOfDog);
        }

        public Dog (string name, string breedOfDog)
            :base (name)
        {
            this.Name = name;
            this.BreedOfDog = breedOfDog;
        }
    }

    class Cat : Animal
    {
        string name;
        string presenceOfWool;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PresenceOfWool
        {
            get { return presenceOfWool; }
            set { presenceOfWool = value; }
        }
        public override void Say()
        {
            Console.WriteLine("Я {0} кошка, Мяу!", PresenceOfWool);
        }

        public Cat(string name, string presenceOfWool)
            : base(name)
        {
            this.Name = name;
            this.PresenceOfWool = presenceOfWool;
        }
    }

}
