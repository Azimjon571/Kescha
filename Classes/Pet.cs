using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KESCHA.Classes;

namespace Kescha.Classes
{
    public class Pet : Animal
    {
        public Pet(string name, int age)
        : base(name, age){}
        
        public override void Greeting(string userName)
        {
            if (userName== "")
            {
                userName = "Unknown person";
            }
            Console.WriteLine($"Meow {userName} my name is Kasee");
        }

        public override void Greeting2(string userName)
        {
            Console.WriteLine(" This is Abstact Method,");
        }
    }
}