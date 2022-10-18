using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KESCHA.Classes;

namespace Kescha.Classes
{
    public class Bird :  Animal
    {
        public Bird(string name, int age)
            :base(name, age) 
        {
        
        }

        public override void Greeting(string userName)
        {
            if (userName== "")
            {
                userName = "Unknown person";
            }
            Console.WriteLine($"Hello {userName} my name is Kescha");
        }

        public override void Greeting2(string userName)
        {
            Console.Write(" This is Abstact Method");
        }
    }
}