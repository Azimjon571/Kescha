﻿using KESCHA.Classes;

string password = "";
do
{
    System.Console.WriteLine("Enter the Password:");
    password = Console.ReadLine();
}while(password != "12344321");

System.Console.Write("Please enter your name:");
string NName = Console.ReadLine();
string greeting = $" Hello, {NName} my name is Kescha";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Animal kescha =new Animal(name: "KESCHA", age, animalAge:5); 

System.Console.WriteLine($"The difference between your and Keschas age is {kescha.AgeDifference}.");

if(age > kescha.Age)
{
    System.Console.WriteLine("You are older than KESCHA");
}
else if(age == kescha.Age)
{
    System.Console.WriteLine("You are equal.");
}
else if(age<kescha.Age)
{
   System.Console.WriteLine("KESCHA older then you."); 
}