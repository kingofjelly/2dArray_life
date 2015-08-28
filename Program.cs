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
            mainUserInterface();
            //asteriskPyramid();
            //asteriskPyramidEvolved();
        }

        enum Choice { Asterisk = 1, AsteriskOld, Boggle, GameOfLife, TimesTable , toOneHundred }//enums for user choices at main menu

        static void mainUserInterface()
        {
            /*This method will utilise enums to present the user with a menu upon app load. from there, other small applications can be accessed.
             * The aim of this is to get me using enums, opposed to if userEntry == 1.
             *              
             */
            
            string userInput;
            int userChoice;
            Console.Clear();
            Console.WriteLine("Welcome to the application \n What do you want to do?");
            Console.WriteLine("Options: See the following for a brief overview of what happens");
            Console.WriteLine("1 : Run an application displaying a pyramid of asterisks");
            Console.WriteLine("2 : Run an older application displaying a pyramid of asterisks");
            Console.WriteLine("3 : Run the game of boggle");
            Console.WriteLine("4 : Run game of life 1,2's");
            Console.WriteLine("5 : Run game of life #, ");
            Console.WriteLine("6 : Run game of life cells");
            Console.WriteLine("7 : Run 2DArray times table application");
            Console.WriteLine("8 : Run 2DArray and loop from 1 - 100");
            Console.WriteLine("9 : Run OOP test method");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userChoice))//better than a parse, because it doesn't throw an exception. however parse better for handling?
            {
                Console.WriteLine(Choice.Asterisk.ToString());
                //switch statement here
                switch (userChoice)
                {
                    case (int)Choice.Asterisk:
                        asteriskPyramidEvolved();
                        break;
                    case 2:
                        asteriskPyramid();
                        break;
                    case 3:
                        boggleGame();
                        break;
                    case 4:
                        gameOfLifeNumber();
                        break;
                    case 5:
                        gameOfLifeHash();
                        break;
                    case 6:
                        gameOfLife();
                        break;
                    case 7:
                        timesTable();
                        break;
                    case 8:
                        toHundred();
                        break;
                    case 9:
                        OOPInteraction();
                        break;
                    default:
                        mainUserInterface();
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid entry");
            }
           

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

        static void boggleGame()
        {
            Console.WriteLine("So you want to play boggle");
        }

        static void gameOfLife()
        {
            Console.WriteLine("So you want to see game of life?");
            gOLClass lifeGrid = new gOLClass();
            lifeGrid.printGrid();//forms grid consisting of 0's or 1's
        }
        static void gameOfLifeNumber()
        {
            Console.WriteLine("So you want to see game of life?");
            gOLClass lifeGrid = new gOLClass();
            lifeGrid.printGridNumber();//forms grid consisting of 0's or 1's
        }
        static void gameOfLifeHash()
        {
            Console.WriteLine("So you want to see game of life?");
            gOLClass lifeGrid = new gOLClass();
            lifeGrid.printGridHash();//forms grid consisting of 0's or 1's
        }

        static void timesTable()
        {
            Console.WriteLine("Times table");
            /* I plan on using this method to teach myself about 2D arrays more thoroughly and building on the nesting of for loops, as demonstrated
             * above, in asteriskPyramidEvolved(), in order to make a 10x10 grid form, where by it incrementally counts from 1 - 100, or does times tables
             */
            int[,] multiplicationTable = new int[10, 10];
            // Fill the table
           

            for (int i = 1; i <= 10; i++)
            {
                //this is for values
                for (int j = 1; j <= 10; j++)
                {
                    multiplicationTable[i - 1, j - 1] = i * j;
                }
            }

           
            for (int i = 1; i <= 10; i++)
            {
                //this is for displaying
                for (int j = 1; j <= 10; j++)
                {
                    WritePadded(multiplicationTable[i - 1, j - 1]);
                }
                Console.WriteLine();
            }


        }
               

        static void toHundred()
        {
            //this method counts from 1 - 100. It was worked out, revisiting asterisk advanced and the nested for loops.
            Console.WriteLine("Counting from 1 to a hundred in a 2D array");
            /* I plan on using this method to teach myself about 2D arrays more thoroughly and building on the nesting of for loops, as demonstrated
             * above, in asteriskPyramidEvolved(), in order to make a 10x10 grid form, where by it incrementally counts from 1 - 100, or does times tables
             */
            int[,] additionTable = new int[10, 10];
            // Fill the table
            int numberCounter = 0;//this is an int which will be used to tally up numbers
            for (int i = 1; i <= 10; i++)
            {
                //this is for values
                //add 10 for each repeat? or at bottom
                for (int j = 1; j <= 10; j++)
                {                   
                    additionTable[i - 1, j - 1] = numberCounter + 1;
                    numberCounter++;
                }

            }
            //THE REAL AMMENDMENTS NEED TO HAPPEN ABOVE
            for (int i = 1; i <= 10; i++)
            {
                //this is for displaying

                for (int j = 1; j <= 10; j++)
                {
                    WritePadded(additionTable[i - 1, j - 1]);
                }
                Console.WriteLine();
            }
        }

        static void WritePadded(int number)
        {
            if (number < 10)
            {
                Console.Write("  ");
            }
            else if (number < 100)
            {
                Console.Write(" ");
            }
            Console.Write(number);
            Console.Write(" ");
        }

        static void OOPInteraction()
        {
            OOPClass classInstance = new OOPClass();
            Console.WriteLine(classInstance.ToString());//outputs namespace and class
            
        }

    }
}
