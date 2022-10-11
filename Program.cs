using KESCHA.Classes;

Animal kescha =new Animal(name: "KESCHA",  age:5);

string password = "";
do
{
    System.Console.WriteLine("Enter the Password:");
    password = Console.ReadLine();
}while(password != "12344321");

System.Console.Write("Please enter your name:");
string userName = Console.ReadLine();
kescha.Greeting(userName);

System.Console.Write("Enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());


kescha.CalculateAgerDifferenceWithNoReturn(userAge);
kescha.PrintAgeDifference();
kescha.CompareAges(userAge);
kescha.TellAboutFriends(userName, userAge);