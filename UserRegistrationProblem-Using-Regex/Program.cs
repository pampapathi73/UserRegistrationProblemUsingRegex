﻿using System;

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
            Console.ReadKey();
        }
    }
}

