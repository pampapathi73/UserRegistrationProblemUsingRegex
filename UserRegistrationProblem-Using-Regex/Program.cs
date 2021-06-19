using System;

namespace UserRegistrationProblem_Using_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Registration problem");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateFirstName("Pampapathi");
            // validateUser.validateFirstName("Pampapathi");
            validateUser.validateLastName("Reddy");
            validateUser.validateEmailId("pampapathik32@gmail.com");
            validateUser.validateMobileNumber("9845820686");
            validateUser.validatePassword("pampa@1234");
            validateUser.validateUperCasePassword("Pampa@1234");
            validateUser.validateNumericPassword("pampap33451");
            validateUser.validateSpecialcarPassword("pampa@3345");
            Console.ReadKey();
        }
    }
}

