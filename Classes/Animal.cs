namespace KESCHA.Classes
{
    class Animal
    {
        public string Name { get; set; }
        public int Age {get; set; }

        public int AgeDifference { get; set; }

        public Animal()
        {
            Name = "No name";
            Age=0;
            AgeDifference=0;
        }
        
        public Animal(
            string name, 
            int userAge, 
            int animalAge)
        {
            Name=name;
            Age=animalAge;
            CalculateAgerDifference( userAge, animalAge);
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

        public void TellAboutFriends(string userName)
        {
            Console.WriteLine("Let me tell you about my friends!");
            string[] friendsName = new string [3];
            friendsName[0]="Abror";
            friendsName[1]="Aziz";
            friendsName[2]=userName;

            foreach (var items in friendsName)
            {
                Console.WriteLine(items);
            }
        }

        
        private void CalculateAgerDifference(int userAge, int animalAge)
        {
            AgeDifference = userAge-animalAge;
        }


    }    
}

