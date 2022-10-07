string password = "";
do
{
    System.Console.WriteLine("Enter the Password:");
    password = Console.ReadLine();
}while(password != "12344321");

System.Console.Write("Please enter your name:");
string name = Console.ReadLine();
string greeting = $" Hello, {name} my name is Kescha";
System.Console.WriteLine(greeting);

System.Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
int keschasAge = 5;
int ageDifference = age - keschasAge;

System.Console.WriteLine($"The difference between your and Keschas age is {ageDifference}.");
if(age > keschasAge)
{
    System.Console.WriteLine("You are older than KESCHA");
}
else if(age == keschasAge)
{
    System.Console.WriteLine("You are equal.");
}
else if(age<keschasAge)
{
   System.Console.WriteLine("KESCHA older then you."); 
}