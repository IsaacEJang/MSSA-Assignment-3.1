using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._1
{
    internal class Program
    {

        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 3.1");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part(int i)
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n---------------PART {i}---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //static void TryAgain()
        //{
        //    StartPoint:
        //    while (true)
        //    {
        //        // ask user if they want to try again
        //        Console.WriteLine("\nWant to try again? (Y / N)");
        //        char answer = char.Parse(Console.ReadLine().ToUpper());

        //        // wants to continue
        //        if (answer == 'Y')
        //        {
        //            goto StartPoint;
        //        }

        //        // does not want to continue
        //        else if (answer == 'N')
        //        {
        //            break;
        //        }

        //        // invaid entry
        //        else
        //        {
        //            Console.ForegroundColor = ConsoleColor.Red;
        //            Console.WriteLine("\nEnter valid character");
        //            Console.ForegroundColor = ConsoleColor.White;
        //            continue;
        //        }
        //    }

        //}

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }

        static void Main(string[] args)
        {
            Introduction();

            /*Return even numbers
            Write a method that returns a string of even numbers greater than 0 and less than 100.

            (Use StringBuilder class)

            Expected input and output

            ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38
            40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"
            */

            Console.WriteLine("I can return a string of even numbers greater than 0 and less than 100.\n");

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(ReturnEvenNumbers());


            Transition();
            Part(2);
        StartPoint2:

            /*
            2. If year is leap

            Given a year as integer, write a method that checks if year is leap.

            Expected input and output

            IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
            */

            Console.WriteLine("\nEnter a year an I will tell you if it is a leap year");
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            if (IfYearIsLeap(year) == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n{IfYearIsLeap(year)}: {year} is a leap year.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{IfYearIsLeap(year)}: {year} is not a leap year.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // Try Again loop
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint2;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }


            Transition();
            Part(3);
        StartPoint3:

            /*
            3. Write a program in C# Sharp to create a function to input a string and count number 
            of spaces are in the string.
            Test Data :
            Please input a string : This is a test string.
            Expected Output :
            "This is a test string." contains 4 spaces
            */

            Console.WriteLine("\nI can tell you how many spaces there are in your sentence.");
            Console.Write("Please input a string: ");
            string sentence = Console.ReadLine();

            int spaceCounter = 0;


            foreach (char c in sentence)
            {
                if (c == ' ')
                {
                    spaceCounter++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n'{sentence}' containes {spaceCounter} spaces.\n");
            Console.ForegroundColor = ConsoleColor.White;

            // Try Again loop
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint3;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }

            Transition();
            Part(4);
        StartPoint4:


            /*
            4. Write a C# Sharp program to accept a coordinate point in an XY coordinate
            system and determine in which quadrant the coordinate point lies.
            Test Data :
            Input the value for X coordinate :7
            Input the value for Y coordinate :9
            Expected Output :
            The coordinate point (7,9) lies in the First quadrant.
            */

            Console.WriteLine("\nEnter a coordinate and I will tell you which quadrant it is in.");
            Console.Write("Input the value for X coordinate: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Input the value for Y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nThe coordinate point ({x},{y}) lies in the {FindQuadrant(x, y)}.\n");
            Console.ForegroundColor = ConsoleColor.White;

            // Try Again loop
            while (true)
            {
                // ask user if they want to try again
                Console.WriteLine("\nWant to try again? (Y / N)");
                char answer = char.Parse(Console.ReadLine().ToUpper());

                // wants to continue
                if (answer == 'Y')
                {
                    goto StartPoint4;
                }

                // does not want to continue
                else if (answer == 'N')
                {
                    break;
                }

                // invaid entry
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nEnter valid character");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
            }
             
            Transition();
            Part(5);
         StartPoint5:

            /*
            5. Write a function which takes an array as input and finds the first 
            occurrence of 2 consecutive 1s and changes their value to 0.

            For e.g: Input : [0,2,1,1,9,1,1]

            Output: [0,2,0,0,9,1,1]*/

            Console.WriteLine("\nInput an array and the first occurrence of 2 consecutive 1s and I will changes their value to 0");
            Console.Write("Please enter an array of integers separated by commas: ");
            string input = Console.ReadLine(); //takes user's array as a temp string

            // puts string into array and converts to int array
            int[] array = input.Split(',').Select(int.Parse).ToArray();

            // calls consecutiveOnes fuction and gets the new array
            int[] newArray = ConsecutiveOnes(array);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nNew Array: [{string.Join(",", newArray)}]");
            Console.ForegroundColor = ConsoleColor.White;

            // Try Again loop
            TryAgain:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint5;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain;
            }

            ClosingMessage();
            Console.ReadKey();
        }

        static string ReturnEvenNumbers()
        {
            StringBuilder evenNumbers = new StringBuilder();

            for (int i = 2; i < 100; i += 2)
            {
                evenNumbers.Append(i).Append(" ");
            }

            return evenNumbers.ToString();
        }

        static bool IfYearIsLeap(int year)
        {
            if (year % 4 == 0) // if year is divisable by 4, return true
            {
                if (year % 100 == 0) // however, if year is divisable by 100, return false
                {
                    if (year % 400 == 0) // however, if year is divisiable by 400, return true
                    {
                        return true;
                    }
                    
                    else { return false; }
                }
                
                else { return true; }

            }
            else { return false; }
        }

        static string FindQuadrant(int x, int y)
        {
            if (x > 0 && y > 0) { return "First Quadrant"; }
            if (x < 0 && y > 0) { return "Second Quadrant"; }
            if (x < 0 && y < 0) { return "Third Quadrant"; }
            if (x > 0 && y < 0) { return "Fourth Quadrant"; }

            return "Orgin";
        }

        static int[] ConsecutiveOnes(int[] array)
        {
            for(int i  = 0; i < array.Length; i++)
            {
                if (array[i] == 1 && array[i+1] == 1)
                {
                    array[i] = 0;
                    array[i+1] = 0;
                    break;
                }
            }
            return array;
        }

    }
}
