﻿System.Console.Write("Please enter your name:");
string name = Console.ReadLine();
string greeting = $" Hello, {name} my name is Kescha";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
int keschasAge = 5;
int ageDifference = age - keschasAge;

System.Console.WriteLine($"The difference between your and Keschas age is {ageDifference}.");
System.Console.WriteLine($"You are older than KESCHA: {age > keschasAge}");
System.Console.WriteLine($"You are younger than KESCHA: {age < keschasAge}");
System.Console.WriteLine($"You are older than KESCHA: {age >= keschasAge}");
System.Console.WriteLine($"You are younger than or equal to KESCHA: {age <= keschasAge}");
System.Console.WriteLine($"Your age is equal to KESCHA`s age: {age == keschasAge} ");
System.Console.WriteLine($"Your age is not equal to KESCHA`s age: {age != keschasAge}");