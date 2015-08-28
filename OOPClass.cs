using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2dArray
{
    class OOPClass//this is the actual class
    {
        //to create this class, it needs to be instantiated. This needs to be done in the code containing the main method
        //private methods: invisible to external classes
        //public methods: part of interface. other classes will interact with these.
        //this KEYWORD.

         private bool topLeft = false;
         private bool top = false;
         private bool topRight = false;
         private bool right = false;
         private bool bottomRight = false;
         private bool bottom = false;
         private bool bottomLeft = false;
         private bool left = false;
         private bool isAlive = false;
         private int generationsPassed;
         private int iValue = 0;
         private int jValue = 0;


        private void lifeCells()
        {
            
            ////for loop recursive. attempt to print a 20 x 20 grid of #
            ////after this, i'll attempt to change the grid so that a die is rolled for each cell. it will either consist of either 1 or 0.
            ////past this, it's a matter of encorporating an algorithm to checkadjacenet cells, then change contents depending on neighbours?

            //string[,] lifeGrid = new string[20, 20];

            //cellClass[,] cellGrid = new cellClass[20, 20];//2d array of cell class objects

            //int iValue = 0;
            //int jValue = 0;
            //int randomReturnedNumber = 0;// returned number from RNG method.


            //////GRID FOR FILLING TABLE WITH CELL CLASS
            //for (int i = 1; i <= 20; i++)
            //{
            //    //i managed the grid going down. this ensures it will go down 20 lines
            //    for (int j = 1; j <= 20; j++)
            //    {
            //        //j manages going across horizontally. will makes sure it goes across 20 spaces.
            //        //this is the section where you'll need to populate it with the method below
            //        cellClass cellObj = new cellClass();
            //        //TO BE PASSED INTO METHOD
            //        randomReturnedNumber = randomNumer();
            //        iValue = i - 1;
            //        jValue = j - 1;
            //        cellObj.createCell
            //        cellGrid[i - 1, j - 1] = cellObj.createCell(randomReturnedNumber, iValue, jValue);
            //        //Console.Write(lifeGrid[i - 1, j - 1]);
            //    }
            //}




            ////PRINT THE GRID WITH CELL CLASS
            //for (int i = 1; i <= 20; i++)
            //{
            //    //i managed the grid going down. this ensures it will go down 20 lines
            //    for (int j = 1; j <= 20; j++)
            //    {
            //        //j manages going across horizontally. will makes sure it goes across 20 spaces.

            //        /*BELOW PRINTS EITHER 1 OR 2. ITERATION 1.0
            //          It's currently commented out and will remain that way. it was included for testing.
            //          What's currently below is the next iteration.*/
            //        //Console.Write(lifeGrid[i - 1, j - 1]);

            //        /*BELOW IT EITHER ADDS " " OR "#". ITERATION 1.1
            //         */
            //        if (lifeGrid[i - 1, j - 1] == "1")
            //        {
            //            Console.Write(" ");
            //        }
            //        if (lifeGrid[i - 1, j - 1] == "2")
            //        {
            //            Console.Write("#");
            //        }
            //        /*3rd iteration needs to pass in [i,j] to a method, for the cell to be created with an instance of the method/object below.
            //         *                      
            //         */
            //    }
            //    Console.WriteLine();



            //}


            ////print the grid
            //for (int i = 1; i <= 20; i++)
            //{
            //    //i managed the grid going down. this ensures it will go down 20 lines
            //    for (int j = 1; j <= 20; j++)
            //    {
            //        //j manages going across horizontally. will makes sure it goes across 20 spaces.

            //        /*BELOW PRINTS EITHER 1 OR 2. ITERATION 1.0
            //          It's currently commented out and will remain that way. it was included for testing.
            //          What's currently below is the next iteration.*/
            //        //Console.Write(lifeGrid[i - 1, j - 1]);

            //        /*BELOW IT EITHER ADDS " " OR "#". ITERATION 1.1
            //         */
            //        if (lifeGrid[i - 1, j - 1] == "1")
            //        {
            //            Console.Write(" ");
            //        }
            //        if (lifeGrid[i - 1, j - 1] == "2")
            //        {
            //            Console.Write("#");
            //        }
            //        /*3rd iteration needs to pass in [i,j] to a method, for the cell to be created with an instance of the method/object below.
            //         *                      
            //         */
            //    }
            //    Console.WriteLine();




            //    /*2D GRID IS NOW PRINTED. NEXT STEP IS CHECKING NEIGHBOURS.
            //      */
            //}

            ///*Here, make a class for the item, which will then be created and set variables. 
            // * The array for the main app will not be a string array. It will be an array of class objects
            // * There will be variables for the following:
            // * 
            // * bool topLeft = false;
            // * bool top = false;
            // * bool topRight = false;
            // * bool right = false;
            // * bool bottomRight = false;
            // * bool bottom = false;
            // * bool bottomLeft = false; 
            // * bool left = false;
            // * bool isAlive = false;
            // * int generationsPassed;
            // * 
            // * The variables will be used to track whether it has any adjacent cells, based upon it's position within the 2D array upon creation,
            // * along with whether it is alive (based upon value rolled for the cell), also how many generations it has been alive OR not as the case may be
            // * 
            // * 
            // */ 
        }

    }
}
