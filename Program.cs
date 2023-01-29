/*
 Author: Domenick Rado
Date:1/29/2023
Description: C# console application for iterative statements
*/

using System;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Deliverable_3_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer number between 1 and 100: ");
            try
            {


                int input = int.Parse(Console.ReadLine());

                Console.WriteLine("Specify the series tye: even or odd ");
                string series = Console.ReadLine();

                if (series == "odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Enter an integer number between 1 and 100: ");
            }
        }
    } 
}