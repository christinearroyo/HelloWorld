﻿// See https://aka.ms/new-console-template for more information

using HelloWorld;
using Microsoft.VisualBasic;
using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;

/*method hide
private static void MyMethod(string nickName)
{
Console.WriteLine("Hello there! Whats your name?");
string userInput = Console.ReadLine();
Console.WriteLine("Hi! " + userInput);
Console.WriteLine("New Student: " + userInput);
Console.WriteLine("can be called " + nickName);
Console.ReadLine();

Console.WriteLine("your age?");
int userAge = int.Parse(Console.ReadLine());

if (userAge == 18)
{
Console.WriteLine("shes an adult");
}
else {
Console.WriteLine("shes just a minor");
}
Console.ReadLine();

}
*/

/*
MyMethod(nickName: "Tin");
*/



// [data types],[identifier],= [value]; "DATA TYPES AND VARIABLES"
/*
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


Console.WriteLine("What's your name?");
Console.Write("type your first name: ");
string FirstName;
FirstName = Console.ReadLine();

//string LastName;
//Console.Write("type your lastname: ");
//LastName = Console.ReadLine();

Console.Write("type your lastname: ");
string LastName = Console.ReadLine();

Console.WriteLine();
Console.Write("Hello, " + FirstName + " " + LastName);
Console.ReadLine();
*/

/*
// 3 ways to write conditionals ^^ (conditional: 1) "CONDITIONALS"
Console.WriteLine();
Console.WriteLine("Big Giveway");
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
*/

/*
//for iteration statement. "ITERATION"
for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        if (i == 7);
    }
        Console.ReadLine();
*/

/*
//"ARRAYS"
string[] names = new string[] { "Christine", "Astrid", "Cypherie", "Tintne", "Ceesiw" };
foreach (string name in names)
Console.WriteLine(name);
Console.ReadLine();
*/

/*
int[] numbers = new int[4];

numbers[0] = 10;
numbers[1] = 16;
numbers[2] = 25;
numbers[3] = 50;

Console.WriteLine(numbers.Length);
Console.ReadLine ();
*/

/*
int n = 10; // You can change this value to make a larger or smaller triangle
for (int i = 1; i <= n; i++)
{
    Console.Write(new string(' ', n - i));
    Console.WriteLine(new string('*', 2 * i - 1))
}
*/

/*
DateTime myTime = DateTime.Now;
Console.WriteLine(myTime.ToBinary String());

Console.ReadLine();
*/

/*
Friend myFriend = new Friend();

myFriend.Name = "Hanna";
myFriend.Age = 20;
myFriend.isFriend = true;

Friend myOneFriend;
myOneFriend = myFriend;

Console.WriteLine("{0} {1} {2}",
    myOneFriend.Name,
    myOneFriend.Age,
    myOneFriend.isFriend);

Console.ReadLine();
*/
internal class Program
{
    private static void Main(string[] args)
    {
        List<Friend> myFriend = new List<Friend>()
            {
                new Friend() { NAME="FATIMA", AGE="18" }
            };

        var age = from Friend in myFriend
                  where Friend.AGE == "18"
                  select Friend;

        foreach (var Friend in age)
        {
            Console.WriteLine(Friend.NAME, Friend.AGE);
        }
    }
}
/*
class Friend
{
   public string Name { get; set; }
   public int Age { get; set; }
   public bool isFriend { get; set; }
}
*/
