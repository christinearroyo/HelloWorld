// See https://aka.ms/new-console-template for more information

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args) 
            {
           
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
            Console.ReadLine();

           
            }
    }
}