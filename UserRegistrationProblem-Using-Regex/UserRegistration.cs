using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem_Using_Regex
{
    class UserRegistration
    {
        public void validateFirstName(string firstName)
        {
            string stringForFirstName = "^[A-Z][a-z]{3,5}?";
            if (Regex.IsMatch(firstName, stringForFirstName))
                Console.WriteLine(firstName + " is Valid");
            else
                Console.WriteLine(firstName + " is Invalid");
        }
        public void validateLastName(string lastName)
        {
            string stringForLastName = "^[A-Z][a-z]{3,5}?";
            if (Regex.IsMatch(lastName, stringForLastName))
                Console.WriteLine(lastName + " is Valid");
            else
                Console.WriteLine(lastName + " is Invalid");
        }
    }
}

