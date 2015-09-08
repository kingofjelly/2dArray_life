using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2dArray
{
    public class OOPClass//this is the actual class
    {


        static Random numberGen = new Random();//this num gen is used called upon instantiasation of object

        static int randomNumer()//running number gen for 1,2 for the letter from the die.1 = dead. 2 = alive
        {
            int roll;//contains the initial roll of the number gen
            int dieRollUpdate;//contains the updated value
            roll = numberGen.Next(1, 3);//uses the global Random generator of numberGen, to gen a no. between 1 & 7, then 1,17
            dieRollUpdate = roll;
            return dieRollUpdate;//returns this value. this is the value that is evaluated, then re-rolled if needed.
        }



         public bool topLeft { get; set; }
         public bool top { get; set; }
         public bool topRight { get; set; }
         public bool right { get; set; }
         public bool bottomRight { get; set; }
         public bool bottom { get; set; }
         public bool bottomLeft { get; set; }
         public bool left { get; set; }
         public bool isAlive { get; set; }//X
         public int generationsPassed { get; set; }
         public int iValue { get; set; }//X
         public int jValue { get; set; }//X
         public string testChar { get; set; }//used for testing after grid creation + population //X
         public int aliveNeighbours { get; set; }//this will be accessed from main method, to tally up living neighbour cells


         public OOPClass(int ivalue, int jvalue)//down and right values. method below will work out what the above values should be
        {
             //this method, upon instantiation, sets all variables above.
            iValue = ivalue;
            jValue = jvalue;
            int alive = randomNumer();
          

            //runs the RNG above, giving out a number. This is either 1 or 2. 1 = dead. 2 = alive. Depending on this, a different 
            //char will be assigned to testChar, for test visibility or the array, aftercreation.

             //here i set the boolean variables for this object. all decide whether it has neighbour.

             //section below checks where it is in the array, based upon valued entered on initial creation
             //E.g [0,0] = top left. [0,19] = top right. This is relevant for checking neighbours

            //CHECK IF ALIVE
            //figure out if alive or not
            if (alive == 1)
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }
             //set string for test initial display. Will replace @ with ""
            if (alive == 1)
            {
                testChar = "#";
            }
            else
            {
                testChar = " ";
            }

            top = true;
            topRight = true;
            right = true;
            bottomRight = true;
            bottom = true;
            bottomLeft = true;
            left = true;
            topLeft = true;

            //set all booleans relating to position above to be true by default. Statements below will change them. This disables booleans depending on what neighbours it
            //cannot possibly have.will therefore skip some methods in main Program.cs

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
                topLeft = false;
                bottomLeft = false;
            }
            if (iValue == 0 && jValue > 0 && jValue < 19)
            {
                //top edge
                top = false;
                topLeft = false;
                topRight = false;
            }
            if (iValue > 0 && iValue < 19 && jValue == 19)
            {
                //right edge
                right = false;
                topRight = false;
                bottomRight = false;
            }
            if (iValue == 19 && jValue > 0 && jValue < 19)
            {
                //bottom edge
                bottom = false;
                bottomLeft = false;
                bottomRight = false;
            }


        }




        //BELOW IS ALL MY PREVIOUS WORKINGS, ALONG WITH WAYS TO CHECK WHETER IT'S AN EDGE OBJ

        //    //CHECK IF PREVIOUSLY CREATED, IF NOT, CHECK IF HAS ADJACENT CELLS
        //    //pass through if beencreated = false?
        //    if (beenCreated = false)
        //    {
        //        //disable multiple options if on corners
        //        if(iValue == 0 && jValue == 0)
        //        {
        //            //top left corner
        //            bottomLeft =false;
        //            left = false;
        //            topLeft = false;
        //            top = false;
        //            topRight = false;
        //        }
        //        if (iValue == 0 && jValue == 19)
        //        {
        //            //top right corner
        //            topLeft = false;
        //            top = false;
        //            topRight = false;
        //            right = false;
        //            bottomRight = false;                                        
        //        }
        //        if (iValue == 19 && jValue == 0)
        //        {
        //            //bottom left
        //            topLeft = false;
        //            left = false;
        //            bottomLeft = false;
        //            bottom = false;
        //            bottomRight = false;
        //        }
        //        if (iValue == 19 && jValue == 19)
        //        {
        //            //bottom right
        //            bottomLeft = false;
        //            bottom = false;
        //            bottomRight = false;
        //            right = false;
        //            topRight = false;
        //        }
        //        //disable side if on edge
        //        if (iValue > 0 && iValue < 19 && jValue == 0)
        //        {
        //            //left edge
        //            left = false;
        //        }
        //        if (iValue == 0 && jValue > 0 && jValue < 19)
        //        {
        //            //top edge
        //            top = false;
        //        }
        //        if (iValue > 0 && iValue < 19 && jValue == 19)
        //        {
        //            //right edge
        //            right = false;
        //        }
        //        if (iValue == 19 && jValue > 0 && jValue < 19)
        //        {
        //            //bottom edge
        //            bottom = false;
        //        }

        //    }

        //}

         public void updateGameOfLife()//Probably not needed now.
         {
             //this method is called, from within OOP calss, after entire grid has been instantiated.
         }
    }
}
