System.Console.WriteLine("Ismingizni kiriting:");
string name = Console.ReadLine();
string greeting = $"Assalomu Aleykum, {name} men Keschaman";
System.Console.WriteLine(greeting);

System.Console.WriteLine("Yoshingizni kiriting: ");
int Age = Convert.ToInt32(Console.ReadLine());
int keschAge = 5;
int ageDifference = Age - keschAge;
System.Console.WriteLine($"Bizning yoshimiz o`tasidagi farq {ageDifference} yosh ekan.");