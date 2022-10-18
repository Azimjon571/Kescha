namespace KESCHA.Classes
{
    public abstract class Animal : IAnimal
    {
        protected string Name { get; set; }
        protected int Age {get; set; }
        internal int AgeDifference { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public Animal()
        {
            Name = "No name";
            Age=0;
            AgeDifference=0;
            CreatedDate=DateTimeOffset.UtcNow;
        }
        
        public Animal(string name, int age)
        {
            Name=name;
            Age=age;
            CreatedDate=DateTimeOffset.UtcNow;
        }
        public Animal(
            string name, 
            int userAge, 
            int animalAge)
        {
            Name=name;
            Age=animalAge;
            CalculateAgerDifference( userAge, animalAge);
            CreatedDate=DateTimeOffset.UtcNow;
        }
        
        public abstract void Greeting2(string userName);
        public void Password()
        {
            string password = "";
                do
                {
                    System.Console.WriteLine("Enter the Password:");
                    password = Console.ReadLine();
                }while(password != "12344321");
        }

           public virtual void Greeting(string userName)
        {
            if (userName== "")
            {
                userName = "Unknown person";
            }
            Console.WriteLine($" Hello, {userName} my name is {Name}");
        }
        public void PrintAgeDifference()
        {
            Console.WriteLine($"The difference between your and {Name} age is {AgeDifference}.");
        }

        public void CompareAges(int userAge)
        {
            if(userAge > Age)
            {
                Console.WriteLine($"You are older than {Name}");
            }
                else if(userAge == Age)
            {
                Console.WriteLine($"You are equal with {Name}.");
            }
                else if(userAge < Age)
            {
                System.Console.WriteLine($"{Name} older then you."); 
            }
        }

        public void TellAboutFriends(string userName, int youAge)
        {
            Console.WriteLine("Let me tell you about my friends!");
            string[] friendsName = new string [3];
            friendsName[0]="Abror";
            friendsName[1]="Aziz";
            friendsName[2]=userName;
            if (friendsName[2]=="")
            {
                friendsName[2]="Unknawn Person";
            }
            int[] friendsAges = {12, 15, youAge};
            
            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine($"{friendsName[i]} is {friendsAges[i]} year old");
            }
          
        }
        public void CalculateAgerDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge-Age;
        }
        
        public void CalculateAgerDifference(int userAge, int animalAge)
        {
            AgeDifference = userAge-animalAge;
        }


    }    
}

