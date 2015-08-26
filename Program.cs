using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2dArray
{
    class Program
    {
        /* DMC 25/08/15 AKA JellyKing
         * This is an application i'm writing to teach myself about 2D arrays and algorithms for working out spacing
         * 
         * Goals for this project
         * BONUS:Incorporate 4.6. Make pyramid of asterisks out of user defined number
         * 1.Learn about 2D arrays. Create a multiplication table, working to a grid which increments by 1. See wk9 (personal reference to material referencing)
         * 2.Progress to examine algorithms for adjacent cells. 
         * 3.Progress to turn into game of life. Run while Console.Read()!= q
         */
        static void Main(string[] args)
        {
            asteriskPyramid();
            asteriskPyramidEvolved();
        }

        static void asteriskPyramid()
        {
            //this method makes a pyramid of increasing size, depending on the number entered by the user.
            /* E.g User enteres 4
             * *
             * **
             * ***
             * ****
             * 
             */

            string userInput;
            int userChoice;

            Console.WriteLine("Please enter a number in numeric form");
            userInput = Console.ReadLine();

            //below is the method which prints asterisks in a line.
            if (int.TryParse(userInput, out userChoice))
            {
                for (int i = 0; i < userChoice; i++)
                {
                    //while it doesn't equal user choice, add asterisk.
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
            //while (Console.Read() != 'q') ;

            //tryparse to int?
            /*
             * The first value you enter is the string you want to convert
             * The second variable is what you want to user to store the converted number. The keyword OUT must be used
             * 
             */
        }

        static void asteriskPyramidEvolved()
        {
            
            string userInput;
            int userChoice;
            //int asteriskCounter = 0;//this is what has to be matched
            int asteriskCounterSpillover = 0; //this will cause the app to spillover to a new line
            Console.WriteLine("Please enter a number in numeric form \n");
            userInput = Console.ReadLine();
            //multiple versions of i? how to solve it.
            /* I think the way to tackle this is 1 x i = user entered value
             * 1 x i = duplicate of user entered value. This value will be the cap it has to hit.
             * Increment line increase?
             * I need one number which increases each time it's hit, whilst it's under end user number
             *             
             */

            //below is the method which prints asterisks in a line.
            if (int.TryParse(userInput, out userChoice))
            {
                for (int i = 0; i < userChoice; i++)
                {
                    asteriskCounterSpillover++;
                    //immidiately initialize and add count asterisk counter. Begins as 1.
                    for (int j = 0; j < asteriskCounterSpillover; j++)
                    {
                        Console.Write("*");
                        //for each number in x in counter, do asterisk, add x 1, then new line. when final total = user input, stop
                    }
                    Console.WriteLine();//now bump down to new line                    
                  
                }
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
            while (Console.Read() != 'q') ;

            //tryparse to int?
            /*
             * The first value you enter is the string you want to convert
             * The second variable is what you want to user to store the converted number. The keyword OUT must be used
             * 
             */
        }


    }
}
