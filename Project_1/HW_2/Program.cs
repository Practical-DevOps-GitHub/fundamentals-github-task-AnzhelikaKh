using System;
using System.Collections.Generic;

namespace Homework
{
    internal class Homework_2
    {
        static void Main(string[] args)
        {
            /*----1----
             * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
             * Display the count on the console.
             */
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            /*----2----
             Write a program and continuously ask the user to enter a number or "ok" to exit. 
             Calculate the sum of all the previously entered numbers and display it on the console.
             */
            //int sum = 0;
            //Console.WriteLine("Enter number or 'OK' to exit.");
            //while (true)
            //{
            //    string input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //    {
            //        break;
            //    }

            //    if (int.TryParse(input, out int number))
            //    {
            //        sum += number;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number or 'ok' to exit.");
            //    }
            //}
            //Console.WriteLine($"Sum of all entered numbers: {sum}");
            /*----3----
             Write a program and ask the user to enter a number. 
            Compute the factorial of the number and print it on the console. 
            For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */
            //Console.WriteLine("Enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //var factorial = 1;
            //for (int i = number; i > 0; i--)
            //{                
            //    factorial *= i;
            //}
            //Console.WriteLine($"Factorial of entered number: {factorial}");
            /*----4----
             Write a program that picks a random number between 1 and 10. 
             Give the user 4 chances to guess the number. 
             If the user guesses the number, display “You won"; otherwise, display “You lost". 
             (To make sure the program is behaving correctly, you can display the secret number on the console first.)
             */
            //var random = new Random();
            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine("Guess the number! ");
            //    int userTry = Convert.ToInt32(Console.ReadLine());
            //    int Computer = random.Next(1, 10);
            //    //Console.WriteLine("secret!  " + Computer);
            //    if (userTry == Computer)
            //    {
            //        Console.WriteLine("You won");
            //    }else Console.WriteLine("You lost");
            //}

            /*----5----
             *  Write a program and ask the user to enter a series of numbers separated by comma. 
             *  Find the maximum of the numbers and display it on the console. For example, 
             *  if the user enters “5, 3, 8, 1, 4", the program should display 8.
             */
            Console.WriteLine("Enter a series of numbers separated by commas:");

            string input = Console.ReadLine();

            // Split the input string into an array of strings using commas as separators
            string[] numbersAsString = input.Split(',');

            int maxNumber = int.MinValue;

            foreach (string numStr in numbersAsString)
            {
                if (int.TryParse(numStr, out int number))
                {
                    // Compare with the current maxNumber and update if the new number is greater
                    maxNumber = Math.Max(maxNumber, number);
                }
                else
                {
                    Console.WriteLine($"Invalid input: {numStr} is not a valid number.");
                    return; // Exit the program if an invalid input is detected
                }
            }

            Console.WriteLine($"The maximum number is: {maxNumber}");
        }
    }
}
