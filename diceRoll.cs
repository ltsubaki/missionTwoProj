using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace missionTwoProj
{
    internal class diceRoll
    {
        public void doDiceRoll(int numRolls)
        {
            //initialize variables
            int die1 = 0;
            int die2 = 0;
            int total = 0;

            int[] rollTotals = new int[13];

            double currPercent = 0.0;
            string finalOutput = "";


            //roll the two dice
            //create a Random object
            Random random = new Random();

            //for the number of times that the user sepcified
            for (int i = 0; i < numRolls; i++) 
            {
                //generate a random number between 1 and 6
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);

                total = die1 + die2;
                rollTotals[total]++;
            }

            //for every possible total rolled
            for (int i = 2; i < rollTotals.Length; i++)
            {
                string asteriskOutput = "";

                //add to a string the number of asterisks (representing percent)
                currPercent = (int)((double)(rollTotals[i]) / numRolls * 100);
                asteriskOutput = new string('*', (int)currPercent);
                finalOutput = finalOutput + i + ": " + asteriskOutput + "\n";
            }
        System.Console.WriteLine(finalOutput);
        }
    }
}
