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
            //for loop recursive. attempt to print a 20 x 20 grid of #
            //after this, i'll attempt to change the grid so that a die is rolled for each cell. it will either consist of either 1 or 0.
            //past this, it's a matter of encorporating an algorithm to checkadjacenet cells, then change contents depending on neighbours?
            
            string [,] lifeGrid = new string [20,20];

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

            /*2D GRID IS NOW PRINTED. NEXT STEP IS CHECKING NEIGHBOURS.
              */
        }

        /*Here, make a class for the item, which will then be created and set variables. 
         * The array for the main app will not be a string array. It will be an array of class objects
         * There will be variables for the following:
         * 
         * bool topLeft = false;
         * bool top = false;
         * bool topRight = false;
         * bool right = false;
         * bool bottomRight = false;
         * bool bottom = false;
         * bool bottomLeft = false; 
         * bool left = false;
         * bool isAlive = false;
         * int generationsPassed;
         * 
         * The variables will be used to track whether it has any adjacent cells, based upon it's position within the 2D array upon creation,
         * along with whether it is alive (based upon value rolled for the cell), also how many generations it has been alive OR not as the case may be
         * 
         * 
         */

        private void createCell()
        {
            //this method creates the object which will be loaded into the array in the method above. it will contain
            //various statements which will check if it has neighbors and whether it's alive
            //It will do this, by examining 2 x int variables, relating to its place in the 2D array, when it's called.

        }


    }

    
    
}
