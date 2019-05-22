using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09999
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            m1.Run();
        } 
    }

    class Manager
    {
        public Manager() { Console.WriteLine("I am in the Manager Class Constructor"); }
        public void Run()
        {
            Dog fido = new Dog();
            Cat fifi = new Cat();
        }

        public string DoCompetition() { return "to be implemented"; }
    }

    class Dog
    {
        static Random rand = new Random();
        static int HowManyDogsHaveBeenCreated = 0;
        string DogName;
        public int Strength;

        public Dog() {
            Dog.HowManyDogsHaveBeenCreated++;
            this.Strength = SetStrength(); }

        public int SetStrength() {
            return rand.Next(1,100);
        }
       
    }

    class Cat
    {
        static Random rand = new Random();
        static int HowManyCatsHaveBeenCreated = 0;
        string CatName;
        public int Strength;
        public int SetStrength()
        {
            return rand.Next(1, 100);
        }
    }
 }
