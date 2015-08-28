using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2dArray
{

    class gOLClass
    {
        /*
         * This class will be used for Object Orientated Programming (OOP) and teaching myself the principles
         * I aim to use methods created within this class, within the main program and my implementation of Conways 'Game of Life' within the cmd,
         * using # symbols for the blocks. Whether this will be possible, we will find out. My guess is that it will work, however just be visually unappealing,
         * whilst still obeying the rules
         * 
         * This class is for if even is rolled during the initial population of the grid. 
         * A seperate class will be made for if odd is rolled, however I plan to have that class inherit from this as a learning exercise
         */

        /* Background Color
         * Foreground Color
         * Console.Write("#")
         * Above 3 items are contents to be of this class? Will try to figure out soon how I can inherit. Possibly just inherit, then change color.
         * This needs to contain the basic items. Most generic items.
         * 
         */
        static Random numberGen = new Random();//this num gen is used for the array, 1, 3. Will give eiter 1 or 2.

        static int randomNumer()//running number gen for 1,2 for the letter from the die, then 1,17 for position on grid.
        {
            int roll;//contains the initial roll of the number gen
            int dieRollUpdate;//contains the updated value
            roll = numberGen.Next(1, 3);//uses the global Random generator of numberGen, to gen a no. between 1 & 7, then 1,17
            dieRollUpdate = roll;
            return dieRollUpdate;//returns this value. this is the value that is evaluated, then re-rolled if needed.
        }

        public void printGrid()
        {

            OOPClass cells = new OOPClass();

            OOPClass[,] lifeGrid = new OOPClass[20, 20];
            //cellClass[,] cellGrid = new cellClass[20, 20];//2d array of cell class objects


            ////GRID FOR FILLING TABLE WITH CELL CLASS
            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    //j manages going across horizontally. will makes sure it goes across 20 spaces.
                    //this is the section where you'll need to populate it with the method below
                    cellClass cellObj = new cellClass();
                    //TO BE PASSED INTO METHOD
                    randomReturnedNumber = randomNumer();
                    iValue = i - 1;
                    jValue = j - 1;
                    cellObj.createCell
                    cellGrid[i - 1, j - 1] = cellObj.createCell(randomReturnedNumber, iValue, jValue);
                    //Console.Write(lifeGrid[i - 1, j - 1]);
                }
            }
                  
            

            //print the grid
            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    //j manages going across horizontally. will makes sure it goes across 20 spaces.

                    /*BELOW PRINTS EITHER 1 OR 2. ITERATION 1.0
                      It's currently commented out and will remain that way. it was included for testing.
                      What's currently below is the next iteration.*/
                    //Console.Write(lifeGrid[i - 1, j - 1]);

                    /*BELOW IT EITHER ADDS " " OR "#". ITERATION 1.1
                     */
                    if (lifeGrid[i - 1, j - 1] == "1")
                    {
                        Console.Write(" ");
                    }
                    if (lifeGrid[i - 1, j - 1] == "2")
                    {
                        Console.Write("#");
                    }
                    /*3rd iteration needs to pass in [i,j] to a method, for the cell to be created with an instance of the method/object below.
                     *                      
                     */
                }
                Console.WriteLine();

            }    
        
        }
        //this is my class i've made, with the object createCell in, especially for use within the main Program class above

        public void printGridNumber()
        {
            //for loop recursive. attempt to print a 20 x 20 grid of #
            //after this, i'll attempt to change the grid so that a die is rolled for each cell. it will either consist of either 1 or 0.
            //past this, it's a matter of encorporating an algorithm to checkadjacenet cells, then change contents depending on neighbours?

            string[,] lifeGrid = new string[20, 20];

            int randomReturnedNumber = 0;// returned number from RNG method.

            //fill the grid
            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    //j manages going across horizontally. will makes sure it goes across 20 spaces.
                    //this is the section where you'll need to populate it with the method below
                    lifeGrid[i - 1, j - 1] = randomNumer().ToString();
                    //Console.Write(lifeGrid[i - 1, j - 1]);
                }
            }

            //print the grid
            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    //j manages going across horizontally. will makes sure it goes across 20 spaces.

                    /*BELOW PRINTS EITHER 1 OR 2. ITERATION */
                    
                    Console.Write(lifeGrid[i - 1, j - 1]);

                }
                Console.WriteLine();

            }

            
        }
     

        public void printGridHash()
        {
            //for loop recursive. attempt to print a 20 x 20 grid of #
            //after this, i'll attempt to change the grid so that a die is rolled for each cell. it will either consist of either 1 or 0.
            //past this, it's a matter of encorporating an algorithm to checkadjacenet cells, then change contents depending on neighbours?

            string[,] lifeGrid = new string[20, 20];

            int randomReturnedNumber = 0;// returned number from RNG method.

            //fill the grid
            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    //j manages going across horizontally. will makes sure it goes across 20 spaces.
                    //this is the section where you'll need to populate it with the method below
                    lifeGrid[i - 1, j - 1] = randomNumer().ToString();
                    //Console.Write(lifeGrid[i - 1, j - 1]);
                }
            }

            //print the grid
            for (int i = 1; i <= 20; i++)
            {
                //i managed the grid going down. this ensures it will go down 20 lines
                for (int j = 1; j <= 20; j++)
                {
                    //j manages going across horizontally. will makes sure it goes across 20 spaces.                    

                    /*BELOW IT EITHER ADDS " " OR "#"
                     */
                    if (lifeGrid[i - 1, j - 1] == "1")
                    {
                        Console.Write(" ");
                    }
                    if (lifeGrid[i - 1, j - 1] == "2")
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine();

            }
        }
       
       
        
        public class cellClass
        {

            public void createCell(int status, int iValue, int jValue)
            {
                /*status = 1 or 2. Dead or alive
                 *iValue = [i,] 
                 *jValue = [,j]
                 */
                //this method creates the object which will be loaded into the array in the method above. it will contain
                //various statements which will check if it has neighbors and whether it's alive
                //It will do this, by examining 2 x int variables, relating to its place in the 2D array, when it's called.
                /*1. CHECK IF CREATED BEFORE                                                                                                                            X
                 *2. CHECK POSITION AND WHAT ADJACENT CELLS IT HAS                                                                                                      X
                 *3. CHECK IF ALIVE                                                                                                                                     X
                 *4. ASSIGN TO 2D ARRAY
                 *5. SECOND RUN THROUGH, SKIP TO LOWER SECTION, IF ALREADY CREATED. IF ALIVE, ADD ANOTHER TO GEN. IF NOT, RESET TO 0
                 *6. CHECK ADJACENT CELLS, BASED UPON BOOLEANS SET DURING FIRST RUN THROUGH. USE MATHS IN ORDER TO CHECK.
                 *   Said checks will be multiple if statements. E.g if topLeft = true. So there will be 8 of them, checking adjacent cells and if theyre alive.
                 *   This will then tally towards an aliveNeighbours int, which then decides if the cell in question will still be alive.
                 *
                 */

                bool beenCreated = false; //this will be recorded after creation, so further iterations can skip sections when this  = true 

                bool topLeft = false;
                bool top = false;
                bool topRight = false;
                bool right = false;
                bool bottomRight = false;
                bool bottom = false;
                bool bottomLeft = false;
                bool left = false;
                bool isAlive = false;
                int generationsPassed;

                //CHECK IF ALIVE
                //figure out if alive or not
                if (status == 2)
                {
                    isAlive = true;
                }
                else
                {
                    isAlive = false;
                }

                //CHECK IF PREVIOUSLY CREATED, IF NOT, CHECK IF HAS ADJACENT CELLS
                //pass through if beencreated = false?
                if (beenCreated == false)
                {
                    //disable multiple options if on corners
                    if (iValue == 0 && jValue == 0)
                    {
                        //top left corner
                        bottomLeft = false;
                        left = false;
                        topLeft = false;
                        top = false;
                        topRight = false;
                    }
                    if (iValue == 0 && jValue == 19)
                    {
                        //top right corner
                        topLeft = false;
                        top = false;
                        topRight = false;
                        right = false;
                        bottomRight = false;
                    }
                    if (iValue == 19 && jValue == 0)
                    {
                        //bottom left
                        topLeft = false;
                        left = false;
                        bottomLeft = false;
                        bottom = false;
                        bottomRight = false;
                    }
                    if (iValue == 19 && jValue == 19)
                    {
                        //bottom right
                        bottomLeft = false;
                        bottom = false;
                        bottomRight = false;
                        right = false;
                        topRight = false;
                    }
                    //disable side if on edge
                    if (iValue > 0 && iValue < 19 && jValue == 0)
                    {
                        //left edge
                        left = false;
                    }
                    if (iValue == 0 && jValue > 0 && jValue < 19)
                    {
                        //top edge
                        top = false;
                    }
                    if (iValue > 0 && iValue < 19 && jValue == 19)
                    {
                        //right edge
                        right = false;
                    }
                    if (iValue == 19 && jValue > 0 && jValue < 19)
                    {
                        //bottom edge
                        bottom = false;
                    }

                }

            }
        }




    }
}
