using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KESCHA.Classes
{
    public interface IAnimal
    {
        void PrintAgeDifference();
        void Greeting2(string userName);
        void Password();
        void Greeting(string userName);
        void CompareAges(int userAge);
        void TellAboutFriends(string userName, int youAge);
        void CalculateAgerDifferenceWithNoReturn(int userAge);
        void CalculateAgerDifference(int userAge, int animalAge);

    }
}