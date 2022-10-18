
using System;
using Kescha.Classes;
using KESCHA.Classes;
using KESCHA.Enums;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {    
            Bird kescha = new Bird(name: "KESCHA", age: 5);
            Pet kasee = new Pet(name: "Kasee", age: 7);
            kasee.Type=PetType.Cat;
            Console.WriteLine("Kescha was created: " + kescha.CreatedDate);
            Console.WriteLine("Kasee was created: " + kasee.CreatedDate);
            kescha.Password();
            Console.WriteLine(kasee.Type);
            Console.Write("Please enter your name:");
            string userName = Console.ReadLine();
            kescha.Greeting(userName);
            kasee.Greeting(userName);
            Console.Write("Abstract methods: ");
            kescha.Greeting2(userName);
            kasee.Greeting2(userName);
            Console.Write("Enter your age: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            kescha.CalculateAgerDifferenceWithNoReturn(userAge);
            kescha.PrintAgeDifference();
            kescha.CompareAges(userAge);
            kescha.TellAboutFriends(userName, userAge);
        }
        catch (FormatException formatException)
        {
            System.Console.WriteLine($"Error was thrown. Message: {formatException.Message}");
        }
    }
}