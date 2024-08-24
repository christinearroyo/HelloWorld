// See https://aka.ms/new-console-template for more information

using Microsoft.Win32.SafeHandles;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) 
            {

            // [data types],[identifier],= [value];
            string FirstName = "User: Christine ";
            char MiddleInitial = 'R';
            string LastName = " Arroyo";
            int Age = 18;
            bool isOnline = true;
            DateTime attendance = DateTime.Now;
            double num = 23.50;
            long new_num = (long)num;

            Console.Write(FirstName);
            Console.Write(MiddleInitial);
            Console.WriteLine(LastName);
            Console.WriteLine(Age);
            Console.WriteLine(isOnline);
            Console.WriteLine(attendance);
            Console.WriteLine(num);
            Console.WriteLine(new_num);
            Console.WriteLine();

            // 3 ways to write conditionals ^^ (conditional: 1)
            Console.WriteLine("Tin's Big Giveway");
                Console.Write("Choose a door: 1, 2 or 3: ");
                string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                message = "You won a new car!";
            
            else if (userValue == "2")
                message = "You won a plane ticket to Boracay!";
            
            else if (userValue == "3")
                message = "You won a new Gaming Laptop! Yey";
            else
            {
                message = "You won NOTHING ";
                message = message + "You Lose.";
            }

            Console.WriteLine(message);
            Console.WriteLine("Press Enter");
            Console.ReadLine();

          
            // conditional 2 (comment) and 3
            Console.WriteLine("Secret Door");
            Console.Write("Choose Door 1, 2,and 3: ");
            string userChoice = Console.ReadLine();

            string message1 = (userChoice == "1") ? "go to heaven" : "go to hell";

            //Console.Write("You will ");
            //Console.Write(message1);
            //Console.Write(".");

            Console.WriteLine("You entered: {0}, therefore you will {1}.", userChoice, message1);
            Console.ReadLine();

            }
    }
}