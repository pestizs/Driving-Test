﻿using System;

namespace Driving_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program will ask the user for their age and ask them if they are able to take the Uk driving test

            //Variable to store the input
            string userInput;
            int userAge;
            int legalAge = 18;
            int yearsToGo;

            //Get the users age
            Console.WriteLine("Please enter your age in whole years:");
            userInput = Console.ReadLine();
            userAge = Int32.Parse(userInput);

            yearsToGo = legalAge - userAge;

            //Select whih message to show
            //Is the user old enough
            if (userAge >= 18)
                Console.WriteLine("You are old enought to take the test.");
            else
            {
                Console.WriteLine("You are not old enough to take the test, sorry.");
                Console.WriteLine("You have to wait another " + yearsToGo + " years for until your test.");
            }
            //Pause at the end
            Console.ReadLine();



        }
    }
}