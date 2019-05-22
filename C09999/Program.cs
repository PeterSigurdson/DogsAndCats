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
            
        } 
    }

    class Dog
    {
        static Random rand = new Random();
        static int HowManyDogsHaveBeenCreated = 0;
        string DogName;
        public int SetStrength() {
            return rand.Next(1,100);
        }
       
    }

    class Cat
    {
        static int HowManyCatsHaveBeenCreated = 0;
        string CatName;
        public int Strength;
        public int SetStrength()
        {
            return rand.Next(1, 100);
        }
    }
 }
