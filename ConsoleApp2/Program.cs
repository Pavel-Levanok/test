﻿using System;

namespace CodeSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string name = "";
string surname = "";
int age = 0;
            
            int response = 0;
int height = 0;

while(response != -1)
{
                Console.WriteLine(@"Enter 0 to enter name 
                                    Enter 1 to enter surname
                                    Enter 2 to enter age
                                    Enter -1 to exit
                                    Enter 3 to enter height
                                    Enter -2 to print resume");

                response = int.Parse(Console.ReadLine());

    if (response == 0)
    {
        Console.WriteLine("Enter your NAME");
        name = Console.ReadLine();
    }
                if (response == 1)
                {
                    Console.WriteLine("Enter your surname");
                    surname = Console.ReadLine();
                }

                if (response == 2)
                {
                    Console.WriteLine("Enter your age");
                    age = int.Parse(Console.ReadLine());
                }

                if (response == 3)
                {
                    Console.WriteLine("Enter your height");
                    height = int.Parse(Console.ReadLine());
                }

                if (response == -2)
                {
                    Console.WriteLine(name);
                    Console.WriteLine(surname);
                    Console.WriteLine(age);
                    Console.WriteLine(height);
                }


            }

Console.ReadKey();


        }
    }
}


