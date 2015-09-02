using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
            Console.WriteLine("10 : Run car creation method for OO learning");
            userInput = Console.ReadLine();

            if (int.TryParse(userInput, out userChoice))//better than a parse, because it doesn't throw an exception. however parse better for handling?
            {
                //Console.WriteLine(Choice.Asterisk.ToString());
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
                    case 10:
                        createCar();
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
            //OOPClass classInstance = new OOPClass();
            //Console.WriteLine(classInstance.ToString());//outputs namespace and class
            string userInput;
            int userChoice;
            int milliseconds = 500;

            OOPClass[,] OOPArray = new OOPClass[20, 20];
            int iValue;
            int jValue;
            //FILL MY GRID
            int neighborsAlive;

            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    //j manages going across horizontally. will makes sure it goes across 20 spaces.
                    //this is the section where you'll need to populate it with the method below
                    
                    //TO BE PASSED INTO METHOD

                    iValue = i - 1;
                    jValue = j - 1;

                    OOPArray[i - 1, j - 1] = new OOPClass(iValue, jValue);//ARRAY IS NOW POPULATED WITH OOPCLASS OBJECTS
                    //Console.Write(lifeGrid[i - 1, j - 1]);
                }
            }
            //NOW LOOP THROUGH ARRAY OF CUSTOM OBJECTS AND DISPLAY THEM
            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    Console.Write(OOPArray[i - 1, j - 1 ].testChar);//test iteration, to view what cells have been set + confirm initialization
                }
                Console.WriteLine();
            }

            /*INSERT MASSIVE, COMPLEX, UPDATE LOOP HERE. WHILE USERINPUT != Q. CONTINUE
              COMPLEX LOGIC + ALGORITHMS INC
             */
            

            /*WHILE USER != Q. RE-RUN, CHANGING TESTCHAR AS NEEDED. RE-PRINT.*/

            Console.WriteLine("Press 1 to begin GoL. 2 to Exit \n");
            userInput = Console.ReadLine();
            Console.Clear();
            //if (int.TryParse(userInput, out userChoice))
            //{
                //while (userChoice != 2) 
                do     
                {
                    //loop through and check neighbors/update
                   
                        Console.SetCursorPosition(0, 0);
                        //clear console to give impression it's updating
                        Thread.Sleep(milliseconds);
                        Console.Clear();
                        for (int i = 1; i <= 20; i++)
                        {
                            //i managed the grid going down. this ensures it will go down 20 lines
                            for (int j = 1; j <= 20; j++)
                            {
                                //do code here.
                                //Deal with:
                                //1. Check neighbors + add to is neighbor alive. Reset to 0 each loop?
                                //2. 
                                /*BELOW WILL ONLY RUN IF IT HAS NEIGHBORS*/
                                //consider setting to 0 every iteration?
                                OOPArray[i - 1, j - 1].aliveNeighbours = 0;

                                if (OOPArray[i - 1, j - 1].topLeft == true)//if it has a top left neighbout
                                {
                                    if (OOPArray[i - 2, j - 2].isAlive == true)//-2 as we're going up a level and back one
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                if (OOPArray[i - 1, j - 1].top == true)
                                {
                                    if (OOPArray[i - 2, j - 1].isAlive == true)//-2 as we're going up a level only
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                if (OOPArray[i - 1, j - 1].topRight == true)//-2 and 0 as we're going up one and to the right
                                {
                                    if (OOPArray[i - 2, j].isAlive == true)//-2 as we're going up a level right one
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                if (OOPArray[i - 1, j - 1].right == true)
                                {
                                    if (OOPArray[i - 1, j].isAlive == true)//we're going just one to right
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                if (OOPArray[i - 1, j - 1].bottomRight == true)
                                {
                                    if (OOPArray[i, j].isAlive == true)//we're going down 1, 1 to right
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                if (OOPArray[i - 1, j - 1].bottom == true)
                                {
                                    if (OOPArray[i, j - 1].isAlive == true)//we're going down 1, 1 to right
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                if (OOPArray[i - 1, j - 1].bottomLeft == true)
                                {
                                    if (OOPArray[i, j - 2].isAlive == true)//we're going down 1, 1 to right
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                if (OOPArray[i - 1, j - 1].left == true)
                                {
                                    if (OOPArray[i - 1, j - 2].isAlive == true)//we're going down 1, 1 to right
                                    {
                                        OOPArray[i - 1, j - 1].aliveNeighbours++;//add one to this variable
                                    }
                                }

                                //NOW EXECUTE STATEMENTS, BASED UPON ALIVE NEIGHBORS

                                //now set it dead

                                //THEN LOOP THROUGH AGAIN. AFTER .5 SEC DELAY
                                //if less than 2 neighbours alive, cell dies.
                                if (OOPArray[i - 1, j - 1].aliveNeighbours < 2 )
                                {
                                    OOPArray[i - 1, j - 1].isAlive = false;//it dies
                                }
                                //if 2 or 3 neighbours, cell remains alive
                                if (OOPArray[i - 1, j - 1].aliveNeighbours == 2 || OOPArray[i - 1, j - 1].aliveNeighbours == 3)
                                {
                                    OOPArray[i - 1, j - 1].isAlive = true;//
                                }
                                //if over 3 neighbours alive, cell dies due to overcrowding
                                if (OOPArray[i - 1, j - 1].aliveNeighbours > 3 )
                                {
                                    OOPArray[i - 1, j - 1].isAlive = false;
                                }
                                //if dead && neighbours = 3, alive due to repopulation
                                if (OOPArray[i - 1, j - 1].aliveNeighbours == 3 && OOPArray[i - 1, j - 1].isAlive == false)
                                {
                                    OOPArray[i - 1, j - 1].isAlive = true;
                                }
                               
                            }

                        }

                        //now loop through and draw cells

                        //need to call a console.clear above, so it appears as if it keeps going
                        for (int i = 1; i <= 20; i++)
                        {
                            //i managed the grid going down. this ensures it will go down 20 lines
                            for (int j = 1; j <= 20; j++)
                            {
                                if (OOPArray[i - 1, j - 1].isAlive == true)
                                {
                                    Console.Write("#");
                                }
                                else
                                {
                                    Console.Write(" ");
                                }

                            }
                            Console.WriteLine();
                        }
                      
                } while (Console.Read() != 'q') ;
            //}
        }

        static void createCar()
        {
            Console.WriteLine("fou le fa fa");

            string make = "ford";
            string name = "Dave";
            string color = "red";


            cars myCar1 = new cars(make, name, color);

            Console.WriteLine(myCar1.Color);

            cars[] carArray = new cars[2];

            for (int i = 0; i < carArray.Length; i++)
            {
                carArray[i] = new cars(make, name, color);//array of car objects has been made
            }
            carArray[1].Make = "Jaguar";//test of changing item within array
            for (int i = 0; i < carArray.Length; i++)
            {
                Console.WriteLine(carArray[i].Make);
                Console.WriteLine(carArray[i].Name);
                Console.WriteLine(carArray[i].Color);
            }
        }

    }
}
