
using System;
using Kescha.Classes;
using KESCHA.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Bird kescha = new Bird(name: "KESCHA", age: 5);
        Pet kasee = new Pet(name: "Kasee", age: 7);
        kescha.Password();
        Console.Write("Please enter your name:");
        string userName = Console.ReadLine();
        
        kescha.Greeting(userName);

        kasee.Greeting(userName);

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        kescha.CalculateAgerDifferenceWithNoReturn(userAge);
        kescha.PrintAgeDifference();
        kescha.CompareAges(userAge);
        kescha.TellAboutFriends(userName, userAge);
    }
}